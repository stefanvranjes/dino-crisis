using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "tmd")]
public class IMP_TMD : ScriptedImporter
{
    public uint ramAddress;
    public GridScriptableObject grid;
    public Texture2D mainT;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (grid != null && mainT != null)
            {
                TmdScriptableObject tmd = ScriptableObject.CreateInstance("TmdScriptableObject") as TmdScriptableObject;

                tmd.OFFSET_1 = reader.ReadUInt32(0) - ramAddress;
                tmd.OFFSET_2 = reader.ReadUInt32(4) - ramAddress;
                tmd.QUAD_COUNT_1 = reader.ReadUInt16(8);
                tmd.QUAD_COUNT_2 = reader.ReadUInt16(10);
                tmd.CMDS = new byte[tmd.QUAD_COUNT_2];
                tmd.VERTS = new Vector3[tmd.QUAD_COUNT_2 * 4];
                tmd.UVS = new Vector2[tmd.QUAD_COUNT_2 * 4];
                tmd.CLRS = new Color[tmd.QUAD_COUNT_2 * 4];
                tmd.TRIS = new int[tmd.QUAD_COUNT_2 * 6];
                tmd.TEX_2D = mainT;
                reader.Seek(12, SeekOrigin.Current);
                float translateFactor = 16f;
                int vramX = grid.VRAM_X * 2;
                int vramY = grid.VRAM_Y;

                for (int i = 0; i < tmd.QUAD_COUNT_2; i++)
                {
                    tmd.VERTS[i * 4] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv1 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[i * 4 + 1] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv2 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[i * 4 + 2] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv3 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    tmd.VERTS[i * 4 + 3] = new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor;
                    Vector2Int uv4 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                    ushort texpage = reader.ReadUInt16();
                    reader.Seek(2, SeekOrigin.Current);
                    int pageX = (texpage & 0xf) * 64 * 2;
                    int pageY = (texpage >> 4 & 1) * 256;
                    uv1.x = pageX + (uv1.x / 2) - vramX;
                    uv1.y = pageY + uv1.y - vramY;
                    tmd.UVS[i * 4] = new Vector2(uv1.x / (float)(mainT.width - 1), 1f - uv1.y / (float)(mainT.height - 1));
                    uv2.x = pageX + (uv2.x / 2) - vramX;
                    uv2.y = pageY + uv2.y - vramY;
                    tmd.UVS[i * 4 + 1] = new Vector2(uv2.x / (float)(mainT.width - 1), 1f - uv2.y / (float)(mainT.height - 1));
                    uv3.x = pageX + (uv3.x / 2) - vramX;
                    uv3.y = pageY + uv3.y - vramY;
                    tmd.UVS[i * 4 + 2] = new Vector2(uv3.x / (float)(mainT.width - 1), 1f - uv3.y / (float)(mainT.height - 1));
                    uv4.x = pageX + (uv4.x / 2) - vramX;
                    uv4.y = pageY + uv4.y - vramY;
                    tmd.UVS[i * 4 + 3] = new Vector2(uv4.x / (float)(mainT.width - 1), 1f - uv4.y / (float)(mainT.height - 1));
                    tmd.CLRS[i * 4] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    tmd.CMDS[i] = reader.ReadByte();
                    tmd.CLRS[i * 4 + 1] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.CLRS[i * 4 + 2] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.CLRS[i * 4 + 3] = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255);
                    reader.Seek(1, SeekOrigin.Current);
                    tmd.TRIS[i * 6] = i * 4;
                    tmd.TRIS[i * 6 + 1] = i * 4 + 1;
                    tmd.TRIS[i * 6 + 2] = i * 4 + 2;
                    tmd.TRIS[i * 6 + 3] = i * 4 + 3;
                    tmd.TRIS[i * 6 + 4] = i * 4 + 2;
                    tmd.TRIS[i * 6 + 5] = i * 4 + 1;
                }

                ctx.AddObjectToAsset("tmd", tmd);
                ctx.SetMainObject(tmd);
                Mesh mesh = new Mesh();
                mesh.SetVertices(tmd.VERTS);
                mesh.SetUVs(0, tmd.UVS);
                mesh.SetColors(tmd.CLRS);
                mesh.SetTriangles(tmd.TRIS, 0);
                ctx.AddObjectToAsset("mesh", mesh);
            }
        }
    }
}
