using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EXP_CMN
{
    public static RamScriptableObject RAM;

    private static Dictionary<int, uint> START_OFFSETS = new Dictionary<int, uint>()
    {
        { 0x11, 0x1bb0 },
        { 0x12, 0x1c90 },
        { 0x13, 0x1bc0 },
        { 0x14, 0x1ca0 }
    };

    private static Dictionary<int, uint> END_OFFSETS = new Dictionary<int, uint>()
    {
        { 0x11, 0x1c60 },
        { 0x12, 0x1d40 },
        { 0x13, 0x1c64 },
        { 0x14, 0x1d44 }
    };

    public static void ExtractCOMMON(string inFile1, string inFile2, string outDir)
    {
        using (BufferedBinaryReader reader1 = new BufferedBinaryReader(File.ReadAllBytes(inFile1)))
        {
            using (BufferedBinaryReader reader2 = new BufferedBinaryReader(File.ReadAllBytes(inFile2)))
            {
                int identifier = reader1.ReadInt32();
                reader1.Seek(START_OFFSETS[identifier], SeekOrigin.Begin);
                uint[] filePositions = new uint[(END_OFFSETS[identifier] - START_OFFSETS[identifier]) / 4];
                int index = 0;

                while (reader1.Position != END_OFFSETS[identifier])
                {
                    uint elementPosition = reader1.ReadUInt32();

                    if (Array.IndexOf(filePositions, elementPosition) == -1 && 
                        elementPosition > 0x80160000 && elementPosition < 0x8017A000)
                        filePositions[index++] = elementPosition;
                }

                Array.Sort(filePositions);
                int exportCount = 0;
                string fileName = Path.GetFileNameWithoutExtension(inFile2);

                for (int i = 0; i < filePositions.Length; i++)
                {
                    if (filePositions[i] == 0) continue;

                    reader2.Seek(filePositions[i] - 0x80160000, SeekOrigin.Begin);

                    if (i == filePositions.Length - 1)
                    {
                        int fileSize = (int)(reader2.Length + 0x80160000 - filePositions[i]);
                        string path = outDir + "/" + fileName + "_" + (exportCount++).ToString("D2") + ".tmd3";
                        File.WriteAllBytes(path, reader2.ReadBytes(fileSize));
                        Tmd3Postprocessor.script = true;
                        Tmd3Postprocessor.address = filePositions[i];
                        AssetDatabase.Refresh();

                        if (path.StartsWith(Application.dataPath))
                            path = "Assets" + path.Substring(Application.dataPath.Length);

                        Tmd3Postprocessor.script = false;
                        Tmd3ScriptableObject tmd3 = AssetDatabase.LoadAssetAtPath(path, typeof(Tmd3ScriptableObject)) as Tmd3ScriptableObject;
                        RAM.objects.Add(filePositions[i], tmd3);
                    }
                    else
                    {
                        int fileSize = (int)(filePositions[i + 1] - filePositions[i]);
                        string path = outDir + "/" + fileName + "_" + (exportCount++).ToString("D2") + ".tod";
                        File.WriteAllBytes(path, reader2.ReadBytes(fileSize));
                        TodPostprocessor.script = true;
                        TodPostprocessor.address = filePositions[i];
                        AssetDatabase.Refresh();

                        if (path.StartsWith(Application.dataPath))
                            path = "Assets" + path.Substring(Application.dataPath.Length);

                        TodPostprocessor.script = false;
                        TodScriptableObject tod = AssetDatabase.LoadAssetAtPath(path, typeof(TodScriptableObject)) as TodScriptableObject;
                        RAM.objects.Add(filePositions[i], tod);
                    }
                }
            }
        }
    }
}
