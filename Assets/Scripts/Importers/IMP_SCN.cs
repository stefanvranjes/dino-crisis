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
        int stringLength = ctx.assetPath.Length;
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);
        byte[] buffer2 = File.ReadAllBytes(ctx.assetPath.Substring(0, stringLength - 3)); //resource buffer

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            using (BufferedBinaryReader reader2 = new BufferedBinaryReader(buffer2))
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
                                c6.DAT_10 = (Tmd2ScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32());
                                c6.DAT_14 = GetTodArray(reader.ReadUInt32());
                                containers.Add(c6);
                                break;
                            case 35:
                                DataContainer8 c8 = new DataContainer8();
                                c8.DAT_00 = type;
                                c8.DAT_01 = reader.ReadByte();
                                c8.DAT_02 = reader.ReadByte();
                                c8.DAT_03 = reader.ReadByte();
                                c8.DAT_04 = reader.ReadUInt16();
                                reader.Seek(2, SeekOrigin.Current);
                                c8.DAT_08 = (TmdScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32());
                                c8.DAT_0C = reader.ReadSVector();
                                c8.DAT_12 = reader.ReadSVector();
                                BoxCollider box = new BoxCollider();
                                box.DAT_00 = reader.ReadSVector();
                                box.DAT_06 = reader.ReadInt16();
                                c8.DAT_18 = box;
                                containers.Add(c8);
                                break;
                            case 36:
                                DataContainer9 c9 = new DataContainer9();
                                c9.DAT_00 = type;
                                c9.DAT_01 = reader.ReadByte();
                                c9.DAT_02 = reader.ReadByte();
                                c9.DAT_03 = reader.ReadByte();
                                c9.DAT_04 = (TodScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32());
                                containers.Add(c9);
                                break;
                            case 40:
                                DataContainer10 c10 = new DataContainer10();
                                c10.DAT_00 = type;
                                c10.DAT_01 = reader.ReadByte();
                                c10.DAT_02 = reader.ReadByte();
                                c10.DAT_03 = reader.ReadByte();
                                c10.DAT_04 = (TriggerScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32());
                                containers.Add(c10);
                                break;
                            case 46:
                                DataContainer11 c11 = new DataContainer11();
                                c11.DAT_00 = type;
                                reader.Seek(1, SeekOrigin.Current);
                                c11.DAT_02 = reader.ReadSVector();
                                c11.DAT_08 = reader.ReadSVector();
                                reader.Seek(2, SeekOrigin.Current);
                                c11.DAT_10 = reader.ReadInt16();
                                c11.DAT_12 = reader.ReadInt16();
                                containers.Add(c11);
                                break;
                            case 53:
                                DataContainer12 c12 = new DataContainer12();
                                c12.DAT_00 = type;
                                c12.DAT_01 = reader.ReadByte();
                                c12.DAT_02 = reader.ReadByte();
                                c12.DAT_03 = reader.ReadByte();
                                c12.DAT_04 = reader.ReadInt16();
                                reader.Seek(2, SeekOrigin.Current);
                                containers.Add(c12);
                                break;
                            case 54:
                            case 55:
                            case 77:
                            case 78:
                                DataContainer13 c13 = new DataContainer13();
                                c13.DAT_00 = type;
                                c13.DAT_01 = reader.ReadByte();
                                c13.DAT_02 = reader.ReadInt16();
                                c13.DAT_04 = reader.ReadInt16();
                                c13.DAT_06 = reader.ReadInt16();
                                containers.Add(c13);
                                break;
                            case 58:
                            case 90:
                                DataContainer14 c14 = new DataContainer14();
                                c14.DAT_00 = type;
                                c14.DAT_01 = reader.ReadByte();
                                c14.DAT_02 = reader.ReadByte();
                                c14.DAT_03 = reader.ReadByte();
                                c14.DAT_04 = new Vector3Int[1];
                                c14.DAT_04[0] = reader.ReadSVector();
                                reader.Seek(2, SeekOrigin.Current);
                                containers.Add(c14);
                                break;
                            case 60:
                            case 63:
                                DataContainer15 c15 = new DataContainer15();
                                c15.DAT_00 = type;
                                c15.DAT_01 = reader.ReadByte();
                                c15.DAT_02 = reader.ReadByte();
                                c15.DAT_03 = reader.ReadByte();
                                c15.DAT_04 = reader.ReadUInt16();
                                reader.Seek(2, SeekOrigin.Current);
                                containers.Add(c15);
                                break;
                            case 61:
                                DataContainer16 c16 = new DataContainer16();
                                c16.DAT_00 = type;
                                c16.DAT_01 = reader.ReadByte();
                                c16.DAT_02 = reader.ReadByte();
                                c16.DAT_03 = reader.ReadByte();
                                c16.DAT_04 = reader.ReadSVector();
                                c16.DAT_0A = reader.ReadByte();
                                c16.DAT_0B = reader.ReadByte();
                                containers.Add(c16);
                                break;
                            case 64:
                                DataContainer17 c17 = new DataContainer17();
                                c17.DAT_00 = type;
                                c17.DAT_01 = reader.ReadByte();
                                c17.DAT_02 = reader.ReadByte();
                                c17.DAT_03 = reader.ReadByte();
                                c17.DAT_04 = reader.ReadByte();
                                c17.DAT_05 = reader.ReadByte();
                                c17.DAT_06 = reader.ReadInt16();
                                c17.DAT_08 = reader.ReadInt16();
                                c17.DAT_0A = reader.ReadInt16();
                                containers.Add(c17);
                                break;
                            case 67:
                            case 68:
                            case 69:
                            case 70:
                                DataContainer18 c18 = new DataContainer18();
                                c18.DAT_00 = type;
                                c18.DAT_01 = reader.ReadByte();
                                c18.DAT_02 = reader.ReadInt16();
                                c18.DAT_04 = reader.ReadInt16();
                                c18.DAT_06 = reader.ReadInt16();
                                containers.Add(c18);
                                break;
                            case 75:
                            case 85:
                                DataContainer19 c19 = new DataContainer19();
                                c19.DAT_00 = type;
                                c19.DAT_01 = reader.ReadByte();
                                c19.DAT_02 = reader.ReadByte();
                                c19.DAT_03 = reader.ReadByte();
                                c19.DAT_04 = reader.ReadInt16();
                                c19.DAT_06 = reader.ReadInt16();
                                c19.DAT_08 = reader.ReadInt16();
                                c19.DAT_0A = reader.ReadUInt16();
                                containers.Add(c19);
                                break;
                            case 76:
                                DataContainer20 c20 = new DataContainer20();
                                c20.DAT_00 = type;
                                reader.Seek(1, SeekOrigin.Current);
                                c20.DAT_02 = reader.ReadSVector();
                                c20.DAT_08 = reader.ReadInt16();
                                c20.DAT_0A = reader.ReadInt16();
                                c20.DAT_0C = reader.ReadInt16();
                                c20.DAT_0E = reader.ReadInt16();
                                reader.Seek(2, SeekOrigin.Current);
                                c20.DAT_12 = reader.ReadSVector();
                                c20.DAT_18 = reader.ReadInt16();
                                c20.DAT_1A = reader.ReadInt16();
                                c20.DAT_1C = reader.ReadInt16();
                                c20.DAT_1E = reader.ReadInt16();
                                containers.Add(c20);
                                break;
                            case 79:
                            case 80:
                            case 81:
                                DataContainer21 c21 = new DataContainer21();
                                c21.DAT_00 = type;
                                c21.DAT_01 = reader.ReadByte();
                                c21.DAT_02 = reader.ReadByte();
                                c21.DAT_03 = reader.ReadByte();
                                c21.DAT_04 = reader.ReadByte();
                                c21.DAT_05 = reader.ReadByte();
                                reader.Seek(2, SeekOrigin.Current);
                                containers.Add(c21);
                                break;
                        }
                    }
                }

                Object GetAssetDatabaseObject(uint address)
                {
                    return null; //tmp
                }

                TodScriptableObject[] GetTodArray(uint address)
                {
                    return null; //tmp
                }
            }
        }
    }
}
#endif