using System.IO;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif
using UnityEngine;

#if UNITY_EDITOR
[ScriptedImporter(1, "tmd")]
public class IMP_TMD : ScriptedImporter
{
    public uint ramAddress;
    public GridScriptableObject grid;
    public ClutScriptableObject clut;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            TmdScriptableObject tmd = ScriptableObject.CreateInstance("TmdScriptableObject") as TmdScriptableObject;

            if (grid != null && clut != null)
            {
                tmd.TRI_OFFSET = reader.ReadUInt32(0) - ramAddress;
                tmd.QUAD_OFFSET = reader.ReadUInt32(4) - ramAddress;
                tmd.TRI_COUNT = reader.ReadUInt16(8);
                tmd.QUAD_COUNT = reader.ReadUInt16(10);
                tmd.CMDS = new byte[tmd.TRI_COUNT + tmd.QUAD_COUNT];
                tmd.VERTS = new Vector3[tmd.TRI_COUNT * 3 + tmd.QUAD_COUNT * 4];
                tmd.UVS = new Vector2[tmd.TRI_COUNT * 3 + tmd.QUAD_COUNT * 4];
                tmd.UVS2 = new Vector3[tmd.TRI_COUNT + tmd.QUAD_COUNT];
                tmd.CLRS = new Color[tmd.TRI_COUNT * 3 + tmd.QUAD_COUNT * 4];
                tmd.TRIS = new int[tmd.TRI_COUNT * 3];
                tmd.QUADS = new int[tmd.QUAD_COUNT * 6];
                tmd.TEX_2D = grid.tex4;
                tmd.TEX8_2D = grid.tex8;
                tmd.CLUT_2D = clut.TEX_2D;
                float translateFactor = 16f;
                reader.Seek(tmd.TRI_OFFSET, SeekOrigin.Begin);
                int triEnd = 0;

                for (int i = 0; i < tmd.TRI_COUNT; i++, triEnd++)
                {
                    tmd.VERTS[i * 3] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv1 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[i * 3 + 1] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv2 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[i * 3 + 2] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv3 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort texpage = reader.ReadUInt16();
                    ushort palette = reader.ReadUInt16();
                    bool lowColors = (texpage >> 7 & 3) == 0 ?  true : false;
                    int clutX = (palette & 0x3f) * 16;
                    int clutY = palette >> 6;
                    tmd.UVS2[i] = new Vector3((float)(clutX - clut.VRAM_X) / clut.WIDTH, (float)(clutY - clut.VRAM_Y) / clut.HEIGHT, lowColors ? 0f : 1f);
                    int f = lowColors ? 4 : 2;
                    int d = lowColors ? 1 : 1;
                    int pageX = (texpage & 0xf) * 64 * f;
                    int pageY = (texpage >> 4 & 1) * 256 + 1;
                    float width = lowColors ? grid.tex4.width : grid.tex8.width;
                    float height = grid.tex4.height;
                    int vramX = grid.VRAM_X * f;
                    int vramY = grid.VRAM_Y;
                    uv1.x = pageX + (uv1.x / d) - vramX;
                    uv1.y = pageY + uv1.y - vramY;
                    tmd.UVS[i * 3] = new Vector2(uv1.x / width, 1f - uv1.y / height);
                    uv2.x = pageX + (uv2.x / d) - vramX;
                    uv2.y = pageY + uv2.y - vramY;
                    tmd.UVS[i * 3 + 1] = new Vector2(uv2.x / width, 1f - uv2.y / height);
                    uv3.x = pageX + (uv3.x / d) - vramX;
                    uv3.y = pageY + uv3.y - vramY;
                    tmd.UVS[i * 3 + 2] = new Vector2(uv3.x / width, 1f - uv3.y / height);
                    tmd.CLRS[i * 3] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    tmd.CMDS[i] = Cmd(reader.ReadByte(), texpage);
                    tmd.CLRS[i * 3 + 1] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.CLRS[i * 3 + 2] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.TRIS[i * 3] = i * 3;
                    tmd.TRIS[i * 3 + 1] = i * 3 + 1;
                    tmd.TRIS[i * 3 + 2] = i * 3 + 2;
                }

                reader.Seek(tmd.QUAD_OFFSET, SeekOrigin.Begin);

                for (int i = 0; i < tmd.QUAD_COUNT; i++)
                {
                    tmd.VERTS[triEnd * 3 + i * 4] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv1 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[triEnd * 3 + i * 4 + 1] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv2 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[triEnd * 3 + i * 4 + 2] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv3 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[triEnd * 3 + i * 4 + 3] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv4 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort texpage = reader.ReadUInt16();
                    ushort palette = reader.ReadUInt16();
                    int clutX = (palette & 0x3f) * 16;
                    int clutY = palette >> 6;
                    bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
                    tmd.UVS2[triEnd + i] = new Vector3((float)(clutX - clut.VRAM_X) / clut.WIDTH, (float)(clutY - clut.VRAM_Y) / clut.HEIGHT, lowColors ? 0f : 1f);
                    int f = lowColors ? 4 : 2;
                    int d = lowColors ? 1 : 1;
                    int pageX = (texpage & 0xf) * 64 * f;
                    int pageY = (texpage >> 4 & 1) * 256 + 1;
                    float width = lowColors ? grid.tex4.width: grid.tex8.width;
                    float height = grid.tex4.height;
                    int vramX = grid.VRAM_X * f;
                    int vramY = grid.VRAM_Y;
                    uv1.x = pageX + (uv1.x / d) - vramX;
                    uv1.y = pageY + uv1.y - vramY;
                    tmd.UVS[triEnd * 3 + i * 4] = new Vector2(uv1.x / width, 1f - uv1.y / height);
                    uv2.x = pageX + (uv2.x / d) - vramX;
                    uv2.y = pageY + uv2.y - vramY;
                    tmd.UVS[triEnd * 3 + i * 4 + 1] = new Vector2(uv2.x / width, 1f - uv2.y / height);
                    uv3.x = pageX + (uv3.x / d) - vramX;
                    uv3.y = pageY + uv3.y - vramY;
                    tmd.UVS[triEnd * 3 + i * 4 + 2] = new Vector2(uv3.x / width, 1f - uv3.y / height);
                    uv4.x = pageX + (uv4.x / d) - vramX;
                    uv4.y = pageY + uv4.y - vramY;
                    tmd.UVS[triEnd * 3 + i * 4 + 3] = new Vector2(uv4.x / width, 1f - uv4.y / height);
                    tmd.CLRS[triEnd * 3 + i * 4] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    tmd.CMDS[triEnd + i] = Cmd(reader.ReadByte(), texpage);
                    tmd.CLRS[triEnd * 3 + i * 4 + 1] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.CLRS[triEnd * 3 + i * 4 + 2] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.CLRS[triEnd * 3 + i * 4 + 3] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.QUADS[i * 6] = triEnd * 3 + i * 4;
                    tmd.QUADS[i * 6 + 1] = triEnd * 3 + i * 4 + 1;
                    tmd.QUADS[i * 6 + 2] = triEnd * 3 + i * 4 + 2;
                    tmd.QUADS[i * 6 + 3] = triEnd * 3 + i * 4 + 3;
                    tmd.QUADS[i * 6 + 4] = triEnd * 3 + i * 4 + 2;
                    tmd.QUADS[i * 6 + 5] = triEnd * 3 + i * 4 + 1;
                }
            }

            ctx.AddObjectToAsset("tmd", tmd);
            ctx.SetMainObject(tmd);
        }
    }

    private static byte Cmd(byte cmd, ushort texpage)
    {
        byte value = 0;

        //tex-blend
        switch (cmd)
        {
            case 0x24:
            case 0x26:
            case 0x2C:
            case 0x2E:
            case 0x34:
            case 0x36:
            case 0x3C:
            case 0x3E:
                value |= 0x10;
                break;
        }

        //semi-transparency
        switch (cmd)
        {
            case 0x26:
            case 0x27:
            case 0x2E:
            case 0x2F:
            case 0x32:
            case 0x36:
            case 0x3A:
            case 0x3E:
                int alpha = texpage >> 5 & 3;
                value |= (byte)(alpha + 1);
                break;
        }

        return value;
    }
}
#endif