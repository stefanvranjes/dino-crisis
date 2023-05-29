using System.IO;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "tod2")]
public class IMP_TOD2 : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            Tod2ScriptableObject tod2 = ScriptableObject.CreateInstance("Tod2ScriptableObject") as Tod2ScriptableObject;

            int length = buffer.Length / 8;
            tod2.FRAMES = new Frame2[length];

            for (int i = 0; i < length; i++)
            {
                Frame2 f = new Frame2();
                f.DAT_00 = reader.ReadByte();
                f.DAT_01 = reader.ReadByte();
                f.DAT_02 = reader.ReadByte();
                f.DAT_03 = reader.ReadByte();
                f.DAT_04 = reader.ReadByte();
                f.DAT_05 = reader.ReadByte();
                f.DAT_06 = reader.ReadSByte();
                f.DAT_07 = reader.ReadSByte();
                tod2.FRAMES[i] = f;
            }

            ctx.AddObjectToAsset("tod2", tod2);
            ctx.SetMainObject(tod2);
        }
    }
}
