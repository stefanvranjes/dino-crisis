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
    public int[] movieIds;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (ram != null)
            {
                ScnScriptableObject scn = ScriptableObject.CreateInstance("ScnScriptableObject") as ScnScriptableObject;

                scn.data = new List<_SCENE_OBJ_DATA>();
                int dataLength = reader.ReadInt32(0) / 4;

                for (int i = 0; i < dataLength; i++)
                {
                    reader.Seek(i * 4, SeekOrigin.Begin);
                    int offset = reader.ReadInt32();
                    reader.Seek(offset, SeekOrigin.Begin);
                    _SCENE_OBJ_DATA d = new _SCENE_OBJ_DATA();
                    d.index = i;
                    byte type = reader.ReadByte();
                    List<DataContainer> containers = new List<DataContainer>();

                    switch (type)
                    {
                        case 0:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                        case 31:
                        case 112:
                        case 113:
                            DataContainer c = new DataContainer();
                            c.DAT_00 = type;
                            containers.Add(c);
                            break;
                        case 1:
                        case 10:
                        case 14:
                        case 23:
                        case 39:
                            DataContainer2 c2 = new DataContainer2();
                            c2.DAT_00 = type;
                            c2.DAT_01 = reader.ReadSByte();
                            c2.DAT_02 = reader.ReadUInt16();
                            containers.Add(c2);
                            break;
                        case 9:
                            DataContainer3 c3 = new DataContainer3();
                            c3.DAT_00 = type;
                            c3.DAT_01 = reader.ReadSByte();
                            c3.DAT_02 = reader.ReadUInt16();
                            c3.DAT_04 = reader.ReadUInt16();
                            reader.Seek(2, SeekOrigin.Current);
                            containers.Add(c3);
                            break;
                        case 20:
                        case 24:
                        case 34:
                        case 37:
                        case 38:
                        case 44:
                        case 45:
                        case 47:
                        case 48:
                        case 59:
                        case 65:
                        case 72:
                        case 73:
                        case 74:
                        case 82:
                        case 84:
                        case 87:
                        case 93:
                        case 96:
                        case 97:
                        case 101:
                        case 102:
                        case 104:
                        case 108:
                        case 110:
                            DataContainer4 c4 = new DataContainer4();
                            c4.DAT_00 = type;
                            c4.DAT_01 = reader.ReadByte();
                            c4.DAT_02 = reader.ReadByte();
                            c4.DAT_03 = reader.ReadByte();
                            containers.Add(c4);
                            break;
                        case 21:
                        case 41:
                        case 42:
                        case 43:
                            DataContainer5 c5 = new DataContainer5();
                            c5.DAT_00 = type;
                            c5.DAT_01 = reader.ReadByte();
                            c5.DAT_02 = reader.ReadByte();
                            c5.DAT_03 = reader.ReadByte();
                            c5.DAT_04 = reader.ReadInt32();
                            containers.Add(c5);
                            break;
                        case 32:
                            DataContainer6 c6 = new DataContainer6();
                            c6.DAT_00 = type;
                            c6.DAT_01 = reader.ReadByte();
                            c6.DAT_02 = reader.ReadByte();
                            c6.DAT_03 = reader.ReadByte();
                            c6.DAT_04 = reader.ReadByte();
                            c6.DAT_05 = reader.ReadByte();
                            c6.DAT_06 = reader.ReadInt16();
                            c6.DAT_08 = reader.ReadSVector();
                            c6.DAT_0E = reader.ReadInt16();
                            c6.DAT_10 = (Tmd2ScriptableObject)ram.objects[reader.ReadUInt32()];
                            c6.DAT_14 = (TodScriptableObject)ram.objects[reader.ReadUInt32()];
                    }
                }
            }
        }
    }
}
#endif