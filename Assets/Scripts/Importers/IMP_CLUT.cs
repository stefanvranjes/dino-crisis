using System.IO;
using UnityEngine;
using UnityEditor.AssetImporters;

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
            reader.Seek(8, SeekOrigin.Current);

            for (int i = 0; i < clut.PALETTE.Length; i++)
                clut.PALETTE[i] = reader.ReadUInt16();

            ctx.AddObjectToAsset("clut", clut);
            ctx.SetMainObject(clut);
        }
    }
}
