using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EXP_SCN
{
    public static void ExtractSCN(string inFile, string outDir)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(inFile, FileMode.Open)))
        {
            // lgh
            int exportCount = 1;
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            uint lghPosition = reader.ReadUInt32();
            reader.BaseStream.Seek(lghPosition, SeekOrigin.Begin);
            int lghSize = (reader.ReadUInt16() + reader.ReadUInt16()) * 0x10 + 0x24;
            string lghFile = outDir + Path.DirectorySeparatorChar;
            lghFile += Path.GetFileNameWithoutExtension(inFile);
            lghFile += "_" + exportCount.ToString("D2") + ".lgh";
            reader.BaseStream.Seek(lghPosition, SeekOrigin.Begin);
            File.WriteAllBytes(lghFile, reader.ReadBytes(lghSize));

            // cln
            exportCount++;
            reader.BaseStream.Seek(8, SeekOrigin.Begin);
            uint clnPosition = reader.ReadUInt32();
            int clnSize = (int)(reader.ReadUInt32() - clnPosition);
            string clnFile = outDir + Path.DirectorySeparatorChar;
            clnFile += Path.GetFileNameWithoutExtension(inFile);
            clnFile += "_" + exportCount.ToString("D2") + ".cln";
            reader.BaseStream.Seek(lghPosition, SeekOrigin.Begin);
            File.WriteAllBytes(clnFile, reader.ReadBytes(clnSize));

            // mot
            exportCount++;
            reader.BaseStream.Seek(0xc, SeekOrigin.Begin);
            uint motPosition = reader.ReadUInt32();
            int motSize = (int)(reader.ReadUInt32() - motPosition);
            string motFile = outDir + Path.DirectorySeparatorChar;
            motFile += Path.GetFileNameWithoutExtension(inFile);
            motFile += "_" + exportCount.ToString("D2") + ".mot";
            reader.BaseStream.Seek(motPosition, SeekOrigin.Begin);
            File.WriteAllBytes(motFile, reader.ReadBytes(motSize));

            // scn
            exportCount++;
            reader.BaseStream.Seek(0x14, SeekOrigin.Begin);
            uint scnPosition = reader.ReadUInt32();
            int scnSize = (int)(reader.BaseStream.Length + 0x80100000 - scnPosition);
            string scnFile = outDir + Path.DirectorySeparatorChar;
            scnFile += Path.GetFileNameWithoutExtension(inFile);
            scnFile += "_" + exportCount.ToString("D2") + ".scn";
            reader.BaseStream.Seek(scnPosition, SeekOrigin.Begin);
            File.WriteAllBytes(scnFile, reader.ReadBytes(scnSize));

            //ram
            RamScriptableObject ram = ScriptableObject.CreateInstance("RamScriptableObject") as RamScriptableObject;
            ram.objects = new UIntObjectDictionary();
            string ramFile = outDir + "/RAM.asset";
            if (ramFile.StartsWith(Application.dataPath))
                ramFile = "Assets" + ramFile.Substring(Application.dataPath.Length);
            AssetDatabase.CreateAsset(ram, ramFile);

            AssetDatabase.Refresh();
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

            TmdPostprocessor.grid = (GridScriptableObject)AssetDatabase.LoadAssetAtPath(timFile, typeof(GridScriptableObject));
            TmdPostprocessor.clut = (ClutScriptableObject)AssetDatabase.LoadAssetAtPath(clutFile, typeof(ClutScriptableObject));

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
