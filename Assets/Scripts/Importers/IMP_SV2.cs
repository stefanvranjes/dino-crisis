using System.IO;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "sv2")]
public class IMP_SV2 : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            SV2ScriptableObject sv2 = ScriptableObject.CreateInstance("SV2ScriptableObject") as SV2ScriptableObject;

            sv2.SVECTORS = new SVECTOR_SERIALIZED_ARRAY[reader.ReadInt32()];

            for (int i = 0; i < sv2.SVECTORS.Length; i++)
            {
                sv2.SVECTORS[i] = new SVECTOR_SERIALIZED_ARRAY();
                sv2.SVECTORS[i].sv2 = new Vector2Int[4];

                for (int j = 0; j < sv2.SVECTORS[i].sv2.Length; j++)
                    sv2.SVECTORS[i].sv2[j] = new Vector2Int(reader.ReadInt16(), reader.ReadInt16());
            }

            ctx.AddObjectToAsset("sv2", sv2);
            ctx.SetMainObject(sv2);
        }
    }
}
