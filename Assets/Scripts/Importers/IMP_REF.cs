using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "ref")]
public class IMP_REF : ScriptedImporter
{
    public RamScriptableObject[] ram;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (ram != null)
            {
                RefScriptableObject rfn = ScriptableObject.CreateInstance("RefScriptableObject") as RefScriptableObject;

                int length = (int)reader.Length / 4;
                rfn.ASSET_REFS = new Object[length];

                for (int i = 0; i < length; i++)
                {
                    uint address = reader.ReadUInt32();

                    for (int j = 0; j < ram.Length; j++)
                    {
                        if (ram[j].objects.ContainsKey(address))
                        {
                            rfn.ASSET_REFS[i] = ram[j].objects[address];
                            break;
                        }
                    }
                }

                ctx.AddObjectToAsset("ref", rfn);
                ctx.SetMainObject(rfn);
            }
        }
    }
}
