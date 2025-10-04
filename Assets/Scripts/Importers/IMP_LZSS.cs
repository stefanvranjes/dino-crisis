using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMP_LZSS
{
    private static float translateFactor = 16f;

    public static Mesh LoadAsset2(string assetPath, Material material, Texpage page)
    {
        Mesh newMesh = new Mesh();

        using (BinaryReader reader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
        {
            //long startPosition = 0x0C;
            reader.BaseStream.Seek(0x0A, SeekOrigin.Begin);
            int quadCount = reader.ReadUInt16();
            Texture mainT = material.mainTexture;
            int vramX = page.VRAM_X;
            int vramY = page.VRAM_Y;

            List<Vector3> verticesList = new List<Vector3>();
            List<Vector2> uvsList = new List<Vector2>();
            List<Color32> colorsList = new List<Color32>();
            List<int> indicesList = new List<int>();

            for (int i = 0; i < quadCount; i++)
            {
                verticesList.Add(new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor);
                Vector2Int uv1 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                verticesList.Add(new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor);
                Vector2Int uv2 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                verticesList.Add(new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor);
                Vector2Int uv3 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                verticesList.Add(new Vector3(reader.ReadInt16(), -reader.ReadInt16(), reader.ReadInt16()) / translateFactor);
                Vector2Int uv4 = new Vector2Int(reader.ReadByte(), reader.ReadByte());
                ushort texpage = reader.ReadUInt16();
                int pageX = (texpage & 0xf) * 64;
                int pageY = (texpage >> 4 & 1) * 256;
                reader.BaseStream.Seek(2, SeekOrigin.Current);
                uv1.x = pageX + uv1.x - vramX;
                uv1.y = pageY + uv1.y - vramY;
                uvsList.Add(new Vector2(uv1.x / (float)(mainT.width - 1), 1f - uv1.y / (float)(mainT.height - 1)));
                uv2.x = pageX + uv2.x - vramX;
                uv2.y = pageY + uv2.y - vramY;
                uvsList.Add(new Vector2(uv2.x / (float)(mainT.width - 1), 1f - uv2.y / (float)(mainT.height - 1)));
                uv3.x = pageX + uv3.x - vramX;
                uv3.y = pageY + uv3.y - vramY;
                uvsList.Add(new Vector2(uv3.x / (float)(mainT.width - 1), 1f - uv3.y / (float)(mainT.height - 1)));
                uv4.x = pageX + uv4.x - vramX;
                uv4.y = pageY + uv4.y - vramY;
                uvsList.Add(new Vector2(uv4.x / (float)(mainT.width - 1), 1f - uv4.y / (float)(mainT.height - 1)));
                colorsList.Add(new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255));
                reader.BaseStream.Seek(1, SeekOrigin.Current);
                colorsList.Add(new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255));
                reader.BaseStream.Seek(1, SeekOrigin.Current);
                colorsList.Add(new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255));
                reader.BaseStream.Seek(1, SeekOrigin.Current);
                colorsList.Add(new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 255));
                reader.BaseStream.Seek(1, SeekOrigin.Current);
                indicesList.Add(i * 4);
                indicesList.Add(i * 4 + 1);
                indicesList.Add(i * 4 + 2);
                indicesList.Add(i * 4 + 3);
                indicesList.Add(i * 4 + 2);
                indicesList.Add(i * 4 + 1);
            }

            newMesh.SetVertices(verticesList);
            newMesh.SetUVs(0, uvsList);
            newMesh.SetColors(colorsList);
            newMesh.SetIndices(indicesList, MeshTopology.Triangles, 0);
        }

        return newMesh;
    }
}
