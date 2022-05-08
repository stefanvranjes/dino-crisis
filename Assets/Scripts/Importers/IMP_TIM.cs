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
                Texture2D texture = new Texture2D(width , height, TextureFormat.RGBA32, false, false);
                Color32[] pixels = new Color32[width * height];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int index = x + y * width;

                        if (palette32)
                            pixels[index] = GetColor32(clut.PALETTE[reader.ReadByte(index)]);
                        else
                        {
                            if (index % 2 == 0)
                                pixels[index] = GetColor32(clut.PALETTE[reader.ReadByte(index / 2) & 0xf]);
                            else
                                pixels[index] = GetColor32(clut.PALETTE[reader.ReadByte(index / 2) >> 4]);
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
                            (pixels[j + k].b, 
                             pixels[j + k].g, 
                             pixels[j + k].r, 
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

    private Color32 GetColor32(ushort color16)
    {
        ushort redMask = 0x7C00;
        ushort greenMask = 0x3E0;
        ushort blueMask = 0x1F;

        byte R5 = (byte)((color16 & redMask) >> 10);
        byte G5 = (byte)((color16 & greenMask) >> 5);
        byte B5 = (byte)(color16 & blueMask);

        byte R8 = (byte)(R5 << 3);
        byte G8 = (byte)(G5 << 3);
        byte B8 = (byte)(B5 << 3);

        byte A = 255;

        if (color16 >> 15 == 0)
        {
            if (R8 == 0 && G8 == 0 && B8 == 0)
                A = 0;
            else
                A = 255;
        }
        else
        {
            if (R8 == 0 && G8 == 0 && B8 == 0)
                A = 127;
            else
                A = 127;
        }

        return new Color32(R8, G8, B8, A);
    }
}
