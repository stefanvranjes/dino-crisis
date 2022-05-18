using System.IO;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif

#if UNITY_EDITOR
[ScriptedImporter(1, "clut")]
public class IMP_CLUT : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            ClutScriptableObject clut = ScriptableObject.CreateInstance("ClutScriptableObject") as ClutScriptableObject;

            clut.VRAM_X = reader.ReadInt16();
            clut.VRAM_Y = reader.ReadInt16();
            clut.WIDTH = reader.ReadInt16();
            clut.HEIGHT = reader.ReadInt16();
            clut.PALETTE = new ushort[clut.WIDTH * clut.HEIGHT];
            Texture2D texture = new Texture2D(clut.WIDTH, clut.HEIGHT, TextureFormat.RGBA32, false, false);
            Color32[] pixels = new Color32[clut.WIDTH * clut.HEIGHT];
            reader.Seek(8, SeekOrigin.Current);

            for (int i = 0; i < clut.PALETTE.Length; i++)
                clut.PALETTE[i] = reader.ReadUInt16();

            for (int y = 0; y < clut.HEIGHT; y++)
            {
                for (int x = 0; x < clut.WIDTH; x++)
                {
                    int index = x + y * clut.WIDTH;
                    pixels[index] = GetColor32(clut.PALETTE[index]);
                }
            }

            texture.SetPixels32(pixels);
            texture.wrapMode = TextureWrapMode.Clamp;
            texture.filterMode = FilterMode.Point;
            texture.Apply();
            clut.TEX_2D = texture;
            ctx.AddObjectToAsset("clut", clut);
            ctx.SetMainObject(clut);
            ctx.AddObjectToAsset("tex", texture);
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

        return new Color32(B8, G8, R8, A);
    }
}
#endif