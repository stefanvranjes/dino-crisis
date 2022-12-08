using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "vab")]
public class IMP_VAB : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            VabScriptableObject vab = ScriptableObject.CreateInstance("VabScriptableObject") as VabScriptableObject;

            int srcLength = reader.ReadInt32();
            vab.SRCS = new SoundSourceData[srcLength];

            for (int i = 0; i < srcLength; i++)
            {
                SoundSourceData src = new SoundSourceData();
                src.DAT_00 = new Vector2Int[4];
                src.DAT_00[0] = reader.ReadSVector2();
                src.DAT_00[1] = reader.ReadSVector2();
                src.DAT_00[2] = reader.ReadSVector2();
                src.DAT_00[3] = reader.ReadSVector2();
                src.DAT_10 = reader.ReadByte();
                src.DAT_11 = reader.ReadByte();
                reader.Seek(2, SeekOrigin.Current);
                vab.SRCS[i] = src;
            }

            ctx.AddObjectToAsset("vab", vab);
            ctx.SetMainObject(vab);
        }
    }
}
