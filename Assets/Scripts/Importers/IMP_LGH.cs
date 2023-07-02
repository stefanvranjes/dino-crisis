using System.IO;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif
using UnityEngine;

#if UNITY_EDITOR
[ScriptedImporter(1, "lgh")]
public class IMP_LGT : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            LightScriptableObject lgh = ScriptableObject.CreateInstance("LightScriptableObject") as LightScriptableObject;

            lgh.DAT_00 = reader.ReadUInt16();
            lgh.DAT_02 = reader.ReadUInt16();
            reader.Seek(2, SeekOrigin.Current);
            lgh.DAT_06 = reader.ReadByte();
            reader.Seek(1, SeekOrigin.Current);
            lgh.DAT_08 = new Color32(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
            lgh.DAT_0C = reader.ReadSVector();
            lgh.DAT_12 = reader.ReadSVector();
            lgh.DAT_18 = reader.ReadByte();
            lgh.DAT_19 = reader.ReadByte();
            lgh.DAT_1A = reader.ReadByte();
            reader.Seek(3, SeekOrigin.Current);
            lgh.DAT_1E = reader.ReadByte();
            lgh.DAT_1F = reader.ReadByte();
            lgh.DAT_20 = reader.ReadByte();
            reader.Seek(3, SeekOrigin.Current);
            int sourceLength = lgh.DAT_00 + lgh.DAT_02;
            lgh.DAT_24 = new LightSource[sourceLength];

            for (int i = 0; i < sourceLength; i++)
            {
                LightSource src = new LightSource();
                src.DAT_00 = reader.ReadByte();
                src.DAT_01 = reader.ReadByte();
                src.DAT_02 = reader.ReadByte();
                src.DAT_03 = reader.ReadByte();
                src.DAT_04 = reader.ReadSVector();
                src.DAT_0A = reader.ReadInt16();
                reader.Seek(2, SeekOrigin.Current);
                src.DAT_0E = reader.ReadInt16();
                reader.Seek(4, SeekOrigin.Current);
                lgh.DAT_24[i] = src;
            }

            ctx.AddObjectToAsset("lgh", lgh);
            ctx.SetMainObject(lgh);
        }
    }
}
#endif