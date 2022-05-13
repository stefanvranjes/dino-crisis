using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EXP_SCN
{
    public static void ExtractSCN(string inFile, string timFile, string clutFile, string outDir)
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

            while (reader.ReadByte() != 0x23)
                reader.BaseStream.Seek(3, SeekOrigin.Current);

            do
            {
                reader.BaseStream.Seek(7, SeekOrigin.Current);
                uint pointer = reader.ReadUInt32();
                if (!pointerList.Contains(pointer))
                    pointerList.Add(pointer);
                reader.BaseStream.Seek(0x14, SeekOrigin.Current);
            } while (reader.ReadByte() == 0x23);

            TmdPostprocessor.script = true;

            if (timFile.StartsWith(Application.dataPath))
                timFile = "Assets" + timFile.Substring(Application.dataPath.Length);

            if (clutFile.StartsWith(Application.dataPath))
                clutFile = "Assets" + clutFile.Substring(Application.dataPath.Length);

            TmdPostprocessor.grid = (GridScriptableObject)AssetDatabase.LoadAssetAtPath(timFile, typeof(GridScriptableObject));
            TmdPostprocessor.tim = (Texture2D)AssetDatabase.LoadAssetAtPath(timFile, typeof(Texture2D));
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
