using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "trg")]
public class IMP_TRG : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            TrgScriptableObject trg = ScriptableObject.CreateInstance("TrgScriptableObject") as TrgScriptableObject;

            int length = buffer.Length / 0x18;
            trg.TRIGGERS = new TriggerData[length];

            for (int i = 0; i < length; i++)
            {
                TriggerData data = new TriggerData();
                data.DAT_00 = reader.ReadSByte();
                data.DAT_01 = reader.ReadByte();
                data.DAT_02 = reader.ReadByte();
                data.DAT_03 = reader.ReadByte();
                data.DAT_04 = reader.ReadSVector();
                data.DAT_0A = reader.ReadInt16();
                data.DAT_0C = reader.ReadInt16();
                data.DAT_0E = reader.ReadInt16();
                data.DAT_10 = reader.ReadInt16();
                data.DAT_12 = reader.ReadUInt16();
                data.DAT_14 = reader.ReadByte() == 1;
                reader.Seek(1, SeekOrigin.Current);
                data.DAT_16 = reader.ReadUInt16();
                trg.TRIGGERS[i] = data;
            }

            ctx.AddObjectToAsset("trg", trg);
            ctx.SetMainObject(trg);
        }
    }
}
