using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "gnt")]
public class IMP_GNT : ScriptedImporter
{
    public int index;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            GntScriptableObject gnt = ScriptableObject.CreateInstance("GntScriptableObject") as GntScriptableObject;

            gnt.INDEX = index;
            reader.Seek(2, SeekOrigin.Begin);
            gnt.DAT_02 = reader.ReadUInt16();
            gnt.DAT_04 = reader.ReadInt32();
            gnt.BUFFER = new byte[reader.Length - reader.Position];

            for (int i = 0; i < gnt.BUFFER.Length; i++)
                gnt.BUFFER[i] = reader.ReadByte();

            ctx.AddObjectToAsset("gnt", gnt);
            ctx.SetMainObject(gnt);
        }
    }
}
