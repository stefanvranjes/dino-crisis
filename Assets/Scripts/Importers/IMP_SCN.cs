using System;
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
        string fileName = Path.GetFileNameWithoutExtension(ctx.assetPath);
        string directory = Path.GetDirectoryName(ctx.assetPath);
        int exportCount = Int32.Parse(fileName.Substring(fileName.Length - 2));
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
                        int end = (i < dataLength - 1) ? reader.ReadInt32() : (int)reader.Length;
                        reader.Seek(offset, SeekOrigin.Begin);
                        _SCENE_OBJ_DATA d = new _SCENE_OBJ_DATA();
                        d.index = i;
                        byte type = reader.ReadByte();
                        List<DataContainer> containers = new List<DataContainer>();

                        while (reader.Position != end)
                        {
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
                                    c6.DAT_10 = (Tmd2ScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32(), typeof(Tmd2ScriptableObject));
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
                                    c8.DAT_08 = (TmdScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32(), typeof(TmdScriptableObject));
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
                                    c9.DAT_04 = (TodScriptableObject)GetAssetDatabaseObject(reader.ReadUInt32(), typeof(TodScriptableObject));
                                    containers.Add(c9);
                                    break;
                                case 40:
                                    DataContainer10 c10 = new DataContainer10();
                                    c10.DAT_00 = type;
                                    c10.DAT_01 = reader.ReadByte();
                                    c10.DAT_02 = reader.ReadByte();
                                    c10.DAT_03 = reader.ReadByte();
                                    c10.DAT_04 = GetTrigger(c10.DAT_02);
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

                        d.CONTAINERS = containers.ToArray();
                        scn.data.Add(d);
                    }
                }

                UnityEngine.Object GetAssetDatabaseObject(uint address, Type objectType)
                {
                    uint fileAddress = address - 0x80100000;

                    if (ram.objects.ContainsKey(address))
                        return ram.objects[address];
                    else
                    {
                        if (objectType == typeof(TmdScriptableObject))
                        {
                            reader2.Seek(fileAddress + 8, SeekOrigin.Begin);
                            exportCount++;
                            int tris = reader2.ReadUInt16();
                            int quads = reader2.ReadUInt16();
                            int size = tris * 0x28 + quads * 0x34;
                            string tmdFile = directory + "/" + fileName.Substring(0, fileName.Length - 2) + 
                                exportCount.ToString("D2") + ".tmd";
                            reader2.Seek(fileAddress, SeekOrigin.Begin);
                            File.WriteAllBytes(tmdFile, reader2.ReadBytes(size + 0xc));
                        }
                        else if (objectType == typeof(Tmd2ScriptableObject))
                        {
                            reader2.Seek(fileAddress + 0xc, SeekOrigin.Begin);
                            exportCount++;
                            uint quadOffset = reader2.ReadUInt32();
                            reader2.Seek(2, SeekOrigin.Current);
                            int quadCount = reader2.ReadUInt16();
                            string tmd2File = directory + "/" + fileName.Substring(0, fileName.Length - 2) +
                                exportCount.ToString("D2") + ".tmd2";
                            reader2.Seek(fileAddress, SeekOrigin.Begin);
                            File.WriteAllBytes(tmd2File, reader.ReadBytes((int)(quadOffset - address + quadCount * 0x14)));
                        }
                        else if (objectType == typeof(TodScriptableObject))
                        {

                        }
                    }
                    return null; //tmp
                }

                TodScriptableObject[] GetTodArray(uint address)
                {
                    return null; //tmp
                }

                Trigger GetTrigger(int type)
                {
                    long jump = reader.Position;

                    switch (type)
                    {
                        case 0:
                            jump += 0x2c;
                            break;
                        case 1:
                            jump += 0x24;
                            break;
                        case 2:
                        case 5:
                        case 6:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            jump += 0x1c;
                            break;
                        case 3:
                            jump += 0x20;
                            break;
                        case 4:
                            jump += 0x28;
                            break;
                        case 7:
                            jump += 0x30;
                            break;
                    }

                    switch(reader.ReadByte(0x10))
                    {
                        case 0:
                            Trigger2 t1 = new Trigger2();
                            SetInheritedValues(t1);
                            t1.DAT_18 = reader.ReadUInt16();
                            t1.DAT_1A = reader.ReadSVector();
                            t1.DAT_20 = reader.ReadInt16();
                            t1.DAT_22 = reader.ReadByte();
                            t1.DAT_23 = reader.ReadByte();
                            t1.DAT_24 = reader.ReadByte();
                            t1.DAT_25 = reader.ReadByte() == 1 ? true : false;
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t1;
                        case 1:
                            Trigger3 t2 = new Trigger3();
                            SetInheritedValues(t2);
                            t2.DAT_18 = reader.ReadInt32();
                            t2.DAT_1C = reader.ReadInt32();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t2;
                        case 2:
                            Trigger4 t3 = new Trigger4();
                            SetInheritedValues(t3);
                            t3.DAT_18 = reader.ReadByte();
                            t3.DAT_19 = reader.ReadByte();
                            t3.DAT_1A = reader.ReadByte() == 1 ? true : false;
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t3;
                        case 3:
                            Trigger5 t4 = new Trigger5();
                            SetInheritedValues(t4);
                            t4.DAT_18 = reader.ReadByte();
                            reader.Seek(1, SeekOrigin.Current);
                            t4.DAT_1A = reader.ReadUInt16();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t4;
                        case 4:
                            Trigger6 t5 = new Trigger6();
                            SetInheritedValues(t5);
                            t5.DAT_18 = reader.ReadUInt16();
                            t5.DAT_1A = reader.ReadUInt16();
                            t5.DAT_1C = reader.ReadUInt16();
                            t5.DAT_1E = reader.ReadByte();
                            t5.DAT_1F = reader.ReadByte();
                            t5.DAT_20 = GetAssetDatabaseObject(reader.ReadUInt32(), typeof(TmdScriptableObject)) as TmdScriptableObject;
                            t5.DAT_24 = reader.ReadInt32();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t5;
                        case 5:
                            Trigger7 t6 = new Trigger7();
                            t6.DAT_18 = reader.ReadByte();
                            t6.DAT_19 = reader.ReadByte();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t6;
                        case 6:
                            Trigger8 t7 = new Trigger8();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t7;
                        case 7:
                            Trigger9 t8 = new Trigger9();
                            t8.DAT_18 = reader.ReadInt16();
                            t8.DAT_1A = reader.ReadInt16();
                            t8.DAT_1C = reader.ReadInt16();
                            t8.DAT_1E = reader.ReadInt16();
                            reader.Seek(4, SeekOrigin.Current);
                            t8.DAT_24 = reader.ReadInt32();
                            t8.DAT_28 = reader.ReadByte();
                            t8.DAT_29 = reader.ReadByte();
                            t8.DAT_2A = reader.ReadUInt16();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t8;
                        case 8:
                            Trigger10 t9 = new Trigger10();
                            t9.DAT_18 = reader.ReadByte();
                            t9.DAT_19 = reader.ReadByte() == 1 ? true : false;
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t9;
                        case 9:
                            Trigger11 t10 = new Trigger11();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t10;
                        case 10:
                            Trigger12 t11 = new Trigger12();
                            t11.DAT_18 = reader.ReadByte();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t11;
                        case 11:
                            Trigger13 t12 = new Trigger13();
                            t12.DAT_18 = reader.ReadByte();
                            t12.DAT_19 = reader.ReadByte();
                            t12.DAT_1A = reader.ReadByte();
                            t12.DAT_1B = reader.ReadByte();
                            reader.Seek(jump, SeekOrigin.Begin);
                            return t12;
                        default:
                            reader.Seek(jump, SeekOrigin.Begin);
                            return null;
                    }

                    void SetInheritedValues(Trigger t)
                    {
                        t.DAT_00 = new Vector2Int[4];
                        t.DAT_00[0] = new Vector2Int(reader.ReadInt16(), reader.ReadInt16());
                        t.DAT_00[1] = new Vector2Int(reader.ReadInt16(), reader.ReadInt16());
                        t.DAT_00[2] = new Vector2Int(reader.ReadInt16(), reader.ReadInt16());
                        t.DAT_00[3] = new Vector2Int(reader.ReadInt16(), reader.ReadInt16());
                        t.DAT_10 = reader.ReadByte();
                        t.DAT_11 = reader.ReadByte();
                        t.DAT_12 = reader.ReadByte();
                        t.DAT_13 = reader.ReadByte() == 1 ? true : false;
                        reader.Seek(4, SeekOrigin.Current);
                    }
                }
            }
        }
    }
}
#endif