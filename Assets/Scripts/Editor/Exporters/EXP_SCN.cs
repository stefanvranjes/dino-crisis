using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EXP_SCN
{
    public static void ExtractSCN(string inFile, string outDir)
    {
        using (BufferedBinaryReader reader2 = new BufferedBinaryReader(File.ReadAllBytes(inFile)))
        {
            //ram
            RamScriptableObject ram = EXP_DAT.RAM;

            // lgh
            int exportCount = 1;
            reader2.Seek(0, SeekOrigin.Begin);
            uint lghPosition = reader2.ReadUInt32() - 0x80100000;
            reader2.Seek(lghPosition, SeekOrigin.Begin);
            int lghSize = (reader2.ReadUInt16() + reader2.ReadUInt16()) * 0x14 + 0x24;
            string lghFile = outDir + Path.DirectorySeparatorChar;
            lghFile += Path.GetFileNameWithoutExtension(inFile);
            lghFile += "_" + exportCount.ToString("D2") + ".lgh";
            reader2.Seek(lghPosition, SeekOrigin.Begin);
            File.WriteAllBytes(lghFile, reader2.ReadBytes(lghSize));

            // way
            exportCount++;
            reader2.Seek(4, SeekOrigin.Begin);
            uint wayPosition = reader2.ReadUInt32();
            int waySize = (int)(reader2.ReadUInt32() - wayPosition);
            wayPosition -= 0x80100000;
            string wayFile = outDir + Path.DirectorySeparatorChar;
            wayFile += Path.GetFileNameWithoutExtension(inFile);
            wayFile += "_" + exportCount.ToString("D2") + ".way";
            reader2.Seek(wayPosition, SeekOrigin.Begin);
            File.WriteAllBytes(wayFile, reader2.ReadBytes(waySize));

            // cln
            exportCount++;
            reader2.Seek(8, SeekOrigin.Begin);
            uint clnPosition = reader2.ReadUInt32();
            int clnSize = (int)(reader2.ReadUInt32() - clnPosition);
            clnPosition -= 0x80100000;
            string clnFile = outDir + Path.DirectorySeparatorChar;
            clnFile += Path.GetFileNameWithoutExtension(inFile);
            clnFile += "_" + exportCount.ToString("D2") + ".cln";
            reader2.Seek(clnPosition, SeekOrigin.Begin);
            File.WriteAllBytes(clnFile, reader2.ReadBytes(clnSize));

            // mot
            exportCount++;
            reader2.Seek(0xc, SeekOrigin.Begin);
            uint motPosition = reader2.ReadUInt32();
            int motSize = (int)(reader2.ReadUInt32() - motPosition);
            motPosition -= 0x80100000;
            string motFile = outDir + Path.DirectorySeparatorChar;
            motFile += Path.GetFileNameWithoutExtension(inFile);
            motFile += "_" + exportCount.ToString("D2") + ".mot";
            reader2.Seek(motPosition, SeekOrigin.Begin);
            File.WriteAllBytes(motFile, reader2.ReadBytes(motSize));

            // scn
            exportCount++;
            reader2.Seek(0x14, SeekOrigin.Begin);
            uint scnPosition = reader2.ReadUInt32() - 0x80100000;
            int scnSize = (int)(reader2.Length - scnPosition);
            string scnFile = outDir + Path.DirectorySeparatorChar;
            scnFile += Path.GetFileNameWithoutExtension(inFile);
            scnFile += "_" + exportCount.ToString("D2") + ".scn";
            reader2.Seek(scnPosition, SeekOrigin.Begin);
            byte[] buffer = reader2.ReadBytes(scnSize);
            File.WriteAllBytes(scnFile, buffer);

            //vab
            exportCount++;
            reader2.Seek(0x18, SeekOrigin.Begin);
            uint vabPosition = reader2.ReadUInt32();
            int vabSize = (int)(reader2.ReadUInt32(-8) - vabPosition);
            vabPosition -= 0x80100000;
            string vabFile = outDir + Path.DirectorySeparatorChar;
            vabFile += Path.GetFileNameWithoutExtension(inFile);
            vabFile += "_" + exportCount.ToString("D2") + ".vab";
            reader2.Seek(vabPosition, SeekOrigin.Begin);
            File.WriteAllBytes(vabFile, reader2.ReadBytes(vabSize));
            AssetDatabase.Refresh();

            using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
            {
                int i = 0;
                int j;
                int dataLength = reader.ReadInt32(0) / 4;
                List<ContainerIdentifier> addrPairs = new List<ContainerIdentifier>();
                string fileName = Path.GetFileNameWithoutExtension(inFile);

                for (; i < dataLength; i++)
                {
                    reader.Seek(i * 4, SeekOrigin.Begin);
                    int offset = reader.ReadInt32();
                    int end = (i < dataLength - 1) ? reader.ReadInt32() : (int)reader.Length;
                    reader.Seek(offset, SeekOrigin.Begin);
                    j = 0;
                    bool breakLoop = false;

                    while (reader.Position != end && !breakLoop)
                    {
                        byte type = reader.ReadByte();

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
                                break;
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 10:
                            case 11:
                            case 12:
                            case 13:
                            case 14:
                            case 15:
                            case 16:
                            case 18:
                            case 19:
                            case 22:
                            case 23:
                            case 39:
                            case 49:
                            case 50:
                            case 51:
                            case 52:
                            case 62: //tmp
                            case 107:
                                reader.Seek(3, SeekOrigin.Current);
                                if (type == 4 && end == (int)reader.Length) breakLoop = true;
                                break;
                            case 9:
                            case 99: //tmp
                            case 106: //tmp
                                reader.Seek(7, SeekOrigin.Current);
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
                            case 71:
                            case 72:
                            case 73:
                            case 74:
                            case 82:
                            case 84:
                            case 87:
                            case 92:
                            case 93:
                            case 96:
                            case 97:
                            case 101:
                            case 102:
                            case 104:
                            case 108:
                            case 109:
                            case 110:
                            case 111: //tmp
                                reader.Seek(3, SeekOrigin.Current);
                                break;
                            case 21:
                            case 41:
                            case 42:
                            case 43:
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 32:
                                reader.Seek(0xf, SeekOrigin.Current);
                                GetContainerIdentifier(reader.ReadUInt32(), typeof(Tmd2ScriptableObject), 5);
                                GetContainerIdentifierTodArray(reader.ReadUInt32(), 5);
                                break;
                            case 33:
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 35:
                                reader.Seek(7, SeekOrigin.Current);
                                GetContainerIdentifier(reader.ReadUInt32(), typeof(TmdScriptableObject), 7);
                                reader.Seek(0x14, SeekOrigin.Current);
                                break;
                            case 36:
                                reader.Seek(3, SeekOrigin.Current);
                                uint pAddress = reader.ReadUInt32();

                                if (pAddress >= 0x80000000)
                                    GetContainerIdentifier(pAddress, typeof(TodScriptableObject), 8);

                                break;
                            case 40:
                                reader.Seek(-1, SeekOrigin.Current);

                                switch (reader.ReadByte(2))
                                {
                                    case 0:
                                        reader.Seek(0x30, SeekOrigin.Current);
                                        break;
                                    case 1:
                                        reader.Seek(0x28, SeekOrigin.Current);
                                        break;
                                    case 2:
                                    case 5:
                                    case 6:
                                    case 8:
                                    case 9:
                                    case 10:
                                    case 11:
                                        reader.Seek(0x20, SeekOrigin.Current);
                                        break;
                                    case 3:
                                        reader.Seek(0x24, SeekOrigin.Current);
                                        break;
                                    case 4:
                                        GetContainerIdentifier(reader.ReadUInt32(0x24), typeof(TmdScriptableObject), 9);
                                        reader.Seek(0x2c, SeekOrigin.Current);
                                        break;
                                    case 7:
                                        reader.Seek(0x34, SeekOrigin.Current);
                                        break;
                                }

                                break;
                            case 46:
                                reader.Seek(0x13, SeekOrigin.Current);
                                break;
                            case 53:
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 54:
                            case 55:
                            case 77:
                            case 78:
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 58:
                            case 90:
                                reader.Seek(11, SeekOrigin.Current);
                                break;
                            case 60:
                            case 63:
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 61:
                            case 83:
                            case 95:
                                reader.Seek(11, SeekOrigin.Current);
                                break;
                            case 64:
                                reader.Seek(11, SeekOrigin.Current);
                                break;
                            case 67:
                            case 68:
                            case 69:
                            case 70:
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 75:
                            case 85:
                                reader.Seek(11, SeekOrigin.Current);
                                break;
                            case 76:
                                reader.Seek(0x1f, SeekOrigin.Current);
                                break;
                            case 79:
                            case 80:
                            case 81:
                            case 88: //tmp
                                reader.Seek(7, SeekOrigin.Current);
                                break;
                            case 66:
                                reader.Seek(0x13, SeekOrigin.Current);
                                break;
                            default:
                                Debug.Log("Unknown case: " + type);
                                break;
                        }
                        j++;
                    }
                }

                addrPairs.Sort();
                reader2.Seek(0, SeekOrigin.Begin);
                lghPosition = reader2.ReadUInt32(0);

                for (i = 0; i < addrPairs.Count; i++)
                {
                    if (ram.objects.ContainsKey(addrPairs[i].ramAddress) &&
                        ram.objects[addrPairs[i].ramAddress] != null)
                        continue;

                    reader2.Seek(addrPairs[i].ramAddress - 0x80100000, SeekOrigin.Begin);
                    string extension = ".asset";

                    if (addrPairs[i].refType == typeof(TmdScriptableObject))
                    {
                        extension = ".tmd";
                        TmdPostprocessor.script = true;
                        TmdPostprocessor.address = addrPairs[i].ramAddress;
                    }
                    else if (addrPairs[i].refType == typeof(Tmd2ScriptableObject))
                    {
                        extension = ".tmd2";
                        Tmd2Postprocessor.script = true;
                        Tmd2Postprocessor.address = addrPairs[i].ramAddress;
                    }
                    else if (addrPairs[i].refType == typeof(TodScriptableObject))
                    {
                        extension = ".tod";
                        TodPostprocessor.script = true;
                        TodPostprocessor.address = addrPairs[i].ramAddress;
                    }
                    else if (addrPairs[i].refType == typeof(RefScriptableObject))
                    {
                        extension = ".ref";
                        RefPostprocessor.script = true;
                        RefPostprocessor.ram = new RamScriptableObject[] { ram };
                    }

                    int fileSize = 0;

                    for (int k = i + 1; k < addrPairs.Count; k++)
                    {
                        if (addrPairs[i].ramAddress != addrPairs[k].ramAddress)
                        {
                            fileSize = (int)(addrPairs[k].ramAddress - addrPairs[i].ramAddress);
                            break;
                        }
                    }

                    if (fileSize == 0)
                        fileSize = (int)(lghPosition - addrPairs[i].ramAddress);

                    string path = outDir + "/" + fileName + "_" + (++exportCount).ToString("D2") + extension;
                    File.WriteAllBytes(path, reader2.ReadBytes(fileSize));
                    AssetDatabase.Refresh();

                    if (path.StartsWith(Application.dataPath))
                        path = "Assets" + path.Substring(Application.dataPath.Length);

                    if (addrPairs[i].refType == typeof(TmdScriptableObject))
                    {
                        TmdScriptableObject tmd = AssetDatabase.LoadAssetAtPath(path, typeof(TmdScriptableObject)) as TmdScriptableObject;
                        TmdPostprocessor.script = false;

                        if (ram.objects.ContainsKey(addrPairs[i].ramAddress))
                        {
                            if (ram.objects[addrPairs[i].ramAddress] == null)
                                ram.objects[addrPairs[i].ramAddress] = tmd;
                        }
                        else
                            ram.objects.Add(addrPairs[i].ramAddress, tmd);
                    }
                    else if (addrPairs[i].refType == typeof(Tmd2ScriptableObject))
                    {
                        Tmd2ScriptableObject tmd2 = AssetDatabase.LoadAssetAtPath(path, typeof(Tmd2ScriptableObject)) as Tmd2ScriptableObject;
                        Tmd2Postprocessor.script = false;

                        if (ram.objects.ContainsKey(addrPairs[i].ramAddress))
                        {
                            if (ram.objects[addrPairs[i].ramAddress] == null)
                                ram.objects[addrPairs[i].ramAddress] = tmd2;
                        }
                        else
                            ram.objects.Add(addrPairs[i].ramAddress, tmd2);
                    }
                    else if (addrPairs[i].refType == typeof(TodScriptableObject))
                    {
                        TodScriptableObject tod = AssetDatabase.LoadAssetAtPath(path, typeof(TodScriptableObject)) as TodScriptableObject;
                        TodPostprocessor.script = false;

                        if (ram.objects.ContainsKey(addrPairs[i].ramAddress))
                        {
                            if (ram.objects[addrPairs[i].ramAddress] == null)
                                ram.objects[addrPairs[i].ramAddress] = tod;
                        }
                        else
                            ram.objects.Add(addrPairs[i].ramAddress, tod);
                    }
                    else if (addrPairs[i].refType == typeof(RefScriptableObject))
                    {
                        RefScriptableObject _ref = AssetDatabase.LoadAssetAtPath(path, typeof(RefScriptableObject)) as RefScriptableObject;
                        RefPostprocessor.script = false;

                        if (ram.objects.ContainsKey(addrPairs[i].ramAddress))
                        {
                            if (ram.objects[addrPairs[i].ramAddress] == null)
                                ram.objects[addrPairs[i].ramAddress] = _ref;
                        }
                        else
                            ram.objects.Add(addrPairs[i].ramAddress, _ref);
                    }
                }

                void GetContainerIdentifier(uint address, Type objectType, byte containerId)
                {
                    if (address < 0x80100000 || address > 0x80100000 + reader2.Length)
                        return;

                    addrPairs.Add(new ContainerIdentifier()
                    {
                        ramAddress = address,
                        refType = objectType
                    });
                }

                void GetContainerIdentifierTodArray(uint address, byte containerId)
                {
                    uint fileAddress = address - 0x80100000;
                    addrPairs.Add(new ContainerIdentifier()
                    {
                        ramAddress = address,
                        refType = typeof(RefScriptableObject)
                    });
                    reader2.Seek(fileAddress, SeekOrigin.Begin);

                    do
                    {
                        uint todAddress = reader2.ReadUInt32();

                        if (todAddress < 0x80100000 || todAddress > 0x80100000 + reader2.Length)
                            continue;

                        addrPairs.Add(new ContainerIdentifier()
                        {
                            ramAddress = todAddress,
                            refType = typeof(TodScriptableObject)
                        });
                    } while (reader2.ReadUInt32(4) > 0x80100000 && reader2.ReadUInt32(4) != 0xffffffff);
                }
            }
        }
    }

    public static void ExtractSCN2(string inFile, string timFile, string clutFile, string outDir)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(inFile, FileMode.Open)))
        {
            int number = 1;
            uint baseOffset = 0x80100000;
            reader.BaseStream.Seek(0x14, SeekOrigin.Begin);
            long scnPosition = reader.ReadUInt32() - baseOffset;
            reader.BaseStream.Seek(scnPosition, SeekOrigin.Begin);
            string outFile = outDir + Path.DirectorySeparatorChar;
            outFile += Path.GetFileNameWithoutExtension(inFile);
            outFile += "_" + number.ToString("D2") + ".scn";
            File.WriteAllBytes(outFile, reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position)));
            reader.BaseStream.Seek(scnPosition, SeekOrigin.Begin);
            int offset = reader.ReadInt32();
            reader.BaseStream.Seek(offset - 4, SeekOrigin.Current);
            List<uint> pointerList = new List<uint>();
            List<TmdScriptableObject> tmdList = new List<TmdScriptableObject>();
            RamScriptableObject ram = ScriptableObject.CreateInstance("RamScriptableObject") as RamScriptableObject;
            ram.objects = new UIntObjectDictionary();

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length && reader.ReadByte() != 0x23)
                    reader.BaseStream.Seek(3, SeekOrigin.Current);

                if (reader.BaseStream.Position == reader.BaseStream.Length)
                    break;

                do
                {
                    reader.BaseStream.Seek(7, SeekOrigin.Current);
                    uint pointer = reader.ReadUInt32();

                    if (pointer >> 0x18 != 0x80 || pointer < baseOffset || pointer > baseOffset + (uint)reader.BaseStream.Length)
                    {
                        reader.BaseStream.Seek(-11, SeekOrigin.Current);
                        break;
                    }

                    if (!pointerList.Contains(pointer))
                        pointerList.Add(pointer);
                    reader.BaseStream.Seek(0x14, SeekOrigin.Current);
                } while (reader.BaseStream.Position < reader.BaseStream.Length && reader.ReadByte() == 0x23);

                reader.BaseStream.Seek(3, SeekOrigin.Current);
            }

            TmdPostprocessor.script = true;

            if (timFile.StartsWith(Application.dataPath))
                timFile = "Assets" + timFile.Substring(Application.dataPath.Length);

            if (clutFile.StartsWith(Application.dataPath))
                clutFile = "Assets" + clutFile.Substring(Application.dataPath.Length);

            //TmdPostprocessor.grid = (GridScriptableObject)AssetDatabase.LoadAssetAtPath(timFile, typeof(GridScriptableObject));
            //TmdPostprocessor.clut = (ClutScriptableObject)AssetDatabase.LoadAssetAtPath(clutFile, typeof(ClutScriptableObject));

            for (int i = 0; i < pointerList.Count; i++)
            {
                number++;
                long tmdPosition = pointerList[i] - baseOffset;
                reader.BaseStream.Seek(tmdPosition + 8, SeekOrigin.Begin);
                int size = reader.ReadUInt16() * 0x28 + reader.ReadUInt16() * 0x34 + 12;
                reader.BaseStream.Seek(tmdPosition, SeekOrigin.Begin);
                TmdPostprocessor.address = pointerList[i];
                outFile = outDir + Path.DirectorySeparatorChar;
                outFile += Path.GetFileNameWithoutExtension(inFile);
                outFile += "_" + number.ToString("D2") + ".tmd";
                File.WriteAllBytes(outFile, reader.ReadBytes(size));
                AssetDatabase.Refresh();

                if (outFile.StartsWith(Application.dataPath))
                    outFile = "Assets" + outFile.Substring(Application.dataPath.Length);

                TmdScriptableObject tmd = (TmdScriptableObject)AssetDatabase.LoadAssetAtPath(outFile, typeof(TmdScriptableObject));
                ram.objects.Add(pointerList[i], tmd);
            }

            TmdPostprocessor.script = false;
            outFile = outDir + "/RAM.asset";

            if (outFile.StartsWith(Application.dataPath))
                outFile = "Assets" + outFile.Substring(Application.dataPath.Length);

            AssetDatabase.CreateAsset(ram, outFile);
            AssetDatabase.Refresh();
        }
    }
}
