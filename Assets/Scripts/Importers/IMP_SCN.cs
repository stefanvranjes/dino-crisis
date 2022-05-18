using System.IO;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif
using UnityEngine;

#if UNITY_EDITOR
[ScriptedImporter(1, "scn")]
public class IMP_SCN : ScriptedImporter
{
    public RamScriptableObject ram;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (ram != null)
            {
                ScnScriptableObject scn = ScriptableObject.CreateInstance("ScnScriptableObject") as ScnScriptableObject;

                scn.staticObjs = new List<_STATIC_OBJ_DATA>();
                uint baseOffset = 0x80100000;
                int offset = reader.ReadInt32();
                reader.Seek(offset - 4, SeekOrigin.Begin); //tmp

                while (reader.Position < reader.Length)
                {
                    while (reader.Position < reader.Length && reader.ReadByte() != 0x23)
                        reader.Seek(3, SeekOrigin.Current);

                    if (reader.Position == reader.Length)
                        break;

                    do
                    {
                        if (reader.ReadUInt32(7) >> 0x18 != 0x80 || 
                            !ram.objects.ContainsKey(reader.ReadUInt32(7)))
                            break;

                        _STATIC_OBJ_DATA data = new _STATIC_OBJ_DATA();
                        data.DAT_00 = 0x23;
                        data.DAT_01 = reader.ReadByte();
                        data.DAT_02 = reader.ReadByte();
                        data.DAT_03 = reader.ReadByte();
                        data.DAT_04 = reader.ReadUInt16();
                        reader.Seek(2, SeekOrigin.Current);
                        data.DAT_08 = ram.objects[reader.ReadUInt32()] as TmdScriptableObject;
                        data.DAT_0C = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                        data.DAT_12 = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                        reader.Seek(8, SeekOrigin.Current);
                        scn.staticObjs.Add(data);
                    } while (reader.Position < reader.Length && reader.ReadByte() == 0x23);

                    reader.Seek(3, SeekOrigin.Current);
                }

                ctx.AddObjectToAsset("scn", scn);
                ctx.SetMainObject(scn);
            }
        }
    }
}
#endif