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
                int width = reader.ReadInt16();
                int height = reader.ReadInt16();
                reader.Seek(8, SeekOrigin.Current);
                Texture2D texture4 = new Texture2D(width * 4, height, TextureFormat.RGBA32, false, false);
                Texture2D texture8 = new Texture2D(width * 2, height, TextureFormat.RGBA32, false, false);
                Color32[] pixels4 = new Color32[texture4.width * height];
                Color32[] pixels8 = new Color32[texture8.width * height];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < texture4.width; x++)
                    {
                        int index = x + y * texture4.width;
                        
                        if (index % 2 == 0)
                            pixels4[index] = new Color32((byte)(reader.ReadByte(index / 2) & 0xf), 0, 0, 0);
                        else
                            pixels4[index] = new Color32((byte)(reader.ReadByte(index / 2) >> 4), 0, 0, 0);
                    }
                }

                Color32[] flipped4 = new Color32[texture4.width * height];
                int m = 0;

                for (int i = 0, j = pixels4.Length - texture4.width; i < pixels4.Length; i += texture4.width, j -= texture4.width)
                {
                    for (int k = 0; k < texture4.width; ++k)
                    {
                        flipped4[m++] = new Color32
                            (pixels4[j + k].r, 
                             pixels4[j + k].g, 
                             pixels4[j + k].b, 
                             pixels4[j + k].a);
                    }
                }

                texture4.SetPixels32(flipped4);
                texture4.wrapMode = TextureWrapMode.Clamp;
                texture4.filterMode = FilterMode.Point;
                texture4.Apply();
                ctx.AddObjectToAsset("tim4", texture4);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < texture8.width; x++)
                    {
                        int index = x + y * texture8.width;
                        
                        pixels8[index] = new Color32(reader.ReadByte(index), 0, 0, 0);
                    }
                }

                Color32[] flipped8 = new Color32[texture8.width * height];
                m = 0;

                for (int i = 0, j = pixels8.Length - texture8.width; i < pixels8.Length; i += texture8.width, j -= texture8.width)
                {
                    for (int k = 0; k < texture8.width; ++k)
                    {
                        flipped8[m++] = new Color32
                            (pixels8[j + k].r,
                             pixels8[j + k].g,
                             pixels8[j + k].b,
                             pixels8[j + k].a);
                    }
                }

                texture8.SetPixels32(flipped8);
                texture8.wrapMode = TextureWrapMode.Clamp;
                texture8.filterMode = FilterMode.Point;
                texture8.Apply();
                ctx.AddObjectToAsset("tim8", texture8);
                ctx.SetMainObject(texture8);

                grid.tex4 = texture4;
                grid.tex8 = texture8;
                ctx.AddObjectToAsset("grid", grid);
            }
        }
    }
}
