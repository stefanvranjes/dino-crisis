using System.IO;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "tim")]
public class IMP_TIM : ScriptedImporter
{
    public ClutScriptableObject clut;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);
        
        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (clut != null)
            {
                GridScriptableObject grid = ScriptableObject.CreateInstance("GridScriptableObject") as GridScriptableObject;

                grid.VRAM_X = reader.ReadInt16();
                grid.VRAM_Y = reader.ReadInt16();
                bool palette32 = clut.WIDTH * clut.HEIGHT > 16 ? true : false;
                int width = reader.ReadInt16() * (palette32 ? 2 : 4);
                int height = reader.ReadInt16();
                reader.Seek(8, SeekOrigin.Current);
                Texture2D texture = new Texture2D(width, height, TextureFormat.RGBA32, false, false);
                Color32[] pixels = new Color32[width * height];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int index = x + y * width;

                        if (palette32)
                            pixels[index] = new Color32(reader.ReadByte(index), 0, 0, 0);
                        else
                        {
                            if (index % 2 == 0)
                                pixels[index] = new Color32((byte)(reader.ReadByte(index / 2) & 0xf), 0, 0, 0);
                            else
                                pixels[index] = new Color32((byte)(reader.ReadByte(index / 2) >> 4), 0, 0, 0);
                        }
                    }
                }

                Color32[] flipped = new Color32[width * height];
                int m = 0;

                for (int i = 0, j = pixels.Length - width; i < pixels.Length; i += width, j -= width)
                {
                    for (int k = 0; k < width; ++k)
                    {
                        flipped[m++] = new Color32
                            (pixels[j + k].r, 
                             pixels[j + k].g, 
                             pixels[j + k].b, 
                             pixels[j + k].a);
                    }
                }

                texture.SetPixels32(flipped);
                texture.wrapMode = TextureWrapMode.Clamp;
                texture.filterMode = FilterMode.Point;
                texture.Apply();
                ctx.AddObjectToAsset("tim", texture);
                ctx.SetMainObject(texture);
                ctx.AddObjectToAsset("grid", grid);
            }
        }
    }
}
