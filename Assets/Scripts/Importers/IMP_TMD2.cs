using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "tmd2")]
public class IMP_TMD2 : ScriptedImporter
{
    public uint ramAddress;
    public GridScriptableObject grid;
    public ClutScriptableObject clut;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (grid != null && clut != null)
            {
                Tmd2ScriptableObject tmd = ScriptableObject.CreateInstance("Tmd2ScriptableObject") as Tmd2ScriptableObject;

                tmd.VERT_OFFSET = reader.ReadUInt32(0) - ramAddress;
                tmd.NRML_OFFSET = reader.ReadUInt32(4) - ramAddress;
                tmd.TRI_OFFSET = reader.ReadUInt32(8) - ramAddress;
                tmd.QUAD_OFFSET = reader.ReadUInt32(12) - ramAddress;
                tmd.TRI_COUNT = reader.ReadUInt16(16);
                tmd.QUAD_COUNT = reader.ReadUInt16(18);
                tmd.BONE_COUNT = reader.ReadInt32(20);
                tmd.BONES = new Bone[tmd.BONE_COUNT];
                reader.Seek(0x18, SeekOrigin.Begin);
                int vertCount = 0;

                for (int i = 0; i < tmd.BONE_COUNT; i++)
                {
                    Bone b = new Bone();
                    b.DAT_00 = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                    b.DAT_06 = reader.ReadSByte();
                    b.DAT_07 = reader.ReadByte();
                    vertCount += b.DAT_07;
                    tmd.BONES[i] = b;
                    reader.Seek(0xc, SeekOrigin.Current); //tmp
                }

                tmd.VERTS = new Vector3[vertCount];
                tmd.UVS = new Vector2[tmd.TRI_COUNT * 3 + tmd.QUAD_COUNT * 4];
                tmd.UVS2 = new Vector3[tmd.TRI_COUNT + tmd.QUAD_COUNT];
                tmd.NRMLS = new Vector3Int[vertCount];
                tmd.TRIS = new int[tmd.TRI_COUNT * 3];
                tmd.QUADS = new int[tmd.QUAD_COUNT * 6];
                tmd.TEX_2D = grid.tex4;
                tmd.TEX8_2D = grid.tex8;
                tmd.CLUT_2D = clut.TEX_2D;
                float translateFactor = 16f;
                reader.Seek(tmd.VERT_OFFSET, SeekOrigin.Begin);
                
                for (int i = 0; i < vertCount; i++)
                {
                    tmd.VERTS[i] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    reader.Seek(2, SeekOrigin.Current);
                }

                reader.Seek(tmd.NRML_OFFSET, SeekOrigin.Begin);

                for (int i = 0; i < vertCount; i++)
                {
                    tmd.NRMLS[i] = reader.ReadSVector();
                    reader.Seek(2, SeekOrigin.Current);
                }

                int triEnd = 0;
                reader.Seek(tmd.TRI_OFFSET, SeekOrigin.Begin);

                for (int i = 0; i < tmd.TRI_COUNT; i++, triEnd++)
                {
                    tmd.TRIS[i * 3] = reader.ReadUInt16();
                    tmd.TRIS[i * 3 + 1] = reader.ReadUInt16();
                    tmd.TRIS[i * 3 + 2] = reader.ReadUInt16();
                    Vector2Int uv3 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    Vector2Int uv1 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort palette = reader.ReadUInt16();
                    Vector2Int uv2 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort texpage = reader.ReadUInt16();
                    bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
                    int clutX = (palette & 0x3f) * 16;
                    int clutY = palette >> 6;
                    tmd.UVS2[i] = new Vector3((float)(clutX - clut.VRAM_X) / clut.WIDTH, (float)(clutY - clut.VRAM_Y) / clut.HEIGHT, lowColors ? 0f : 1f);
                    int f = lowColors ? 4 : 2;
                    int d = lowColors ? 1 : 1;
                    int pageX = (texpage & 0xf) * 64 * f;
                    int pageY = (texpage >> 4 & 1) * 256;
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
                }

                reader.Seek(tmd.QUAD_OFFSET, SeekOrigin.Begin);

                for (int i = 0; i < tmd.QUAD_COUNT; i++)
                {
                    tmd.QUADS[i * 6] = reader.ReadUInt16();
                    tmd.QUADS[i * 6 + 1] = reader.ReadUInt16();
                    tmd.QUADS[i * 6 + 2] = reader.ReadUInt16();
                    tmd.QUADS[i * 6 + 3] = reader.ReadUInt16();
                    tmd.QUADS[i * 6 + 4] = tmd.QUADS[i * 6 + 2];
                    tmd.QUADS[i * 6 + 5] = tmd.QUADS[i * 6 + 1];
                    Vector2Int uv1 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort palette = reader.ReadUInt16();
                    Vector2Int uv2 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort texpage = reader.ReadUInt16();
                    Vector2Int uv3 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    Vector2Int uv4 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    int clutX = (palette & 0x3f) * 16;
                    int clutY = palette >> 6;
                    bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
                    tmd.UVS2[triEnd + i] = new Vector3((float)(clutX - clut.VRAM_X) / clut.WIDTH, (float)(clutY - clut.VRAM_Y) / clut.HEIGHT, lowColors ? 0f : 1f);
                    int f = lowColors ? 4 : 2;
                    int d = lowColors ? 1 : 1;
                    int pageX = (texpage & 0xf) * 64 * f;
                    int pageY = (texpage >> 4 & 1) * 256;
                    float width = lowColors ? grid.tex4.width : grid.tex8.width;
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
                }

                ctx.AddObjectToAsset("tmd2", tmd);
                ctx.SetMainObject(tmd);
            }
        }
    }
}
