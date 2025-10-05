using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EXP_DOOR
{
    public static void ExtractDOOR(string inFile, string ramFile, string outDir)
    {
        if (ramFile.StartsWith(Application.dataPath))
            ramFile = "Assets" + ramFile.Substring(Application.dataPath.Length);

        RamScriptableObject ram = AssetDatabase.LoadAssetAtPath(ramFile, typeof(RamScriptableObject)) as RamScriptableObject;
        GridScriptableObject grid = null;
        ClutScriptableObject clut = null;
        string[] guids1 = AssetDatabase.FindAssets("t:GridScriptableObject", new[] { Path.GetDirectoryName(ramFile) });
        string[] guids2 = AssetDatabase.FindAssets("t:ClutScriptableObject", new[] { Path.GetDirectoryName(ramFile) });

        foreach (string guid1 in guids1)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid1);
            grid = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GridScriptableObject)) as GridScriptableObject;
        }

        foreach (string guid2 in guids2)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid2);
            clut = AssetDatabase.LoadAssetAtPath(assetPath, typeof(ClutScriptableObject)) as ClutScriptableObject;
        }

        if (ram != null && grid != null && clut != null)
        {
            using (BufferedBinaryReader reader = new BufferedBinaryReader(File.ReadAllBytes(inFile)))
            {
                for (int i = 0; reader.Position != reader.Length; i++)
                {
                    long originalPosition = reader.Position;
                    uint ramAddress = reader.ReadUInt32() - 12;
                    reader.Seek(4, SeekOrigin.Current);
                    int triCount = reader.ReadUInt16();
                    int quadCount = reader.ReadUInt16();
                    int length = triCount * 0x28 + quadCount * 0x34 + 12;
                    reader.Seek(originalPosition, SeekOrigin.Begin);
                    string outFile = outDir + "/" + Path.GetFileNameWithoutExtension(inFile) + "_" + i.ToString("D2") + ".tmd";
                    File.WriteAllBytes(outFile, reader.ReadBytes(length));
                    TmdPostprocessor.script = true;
                    TmdPostprocessor.address = ramAddress;
                    TmdPostprocessor.grid = grid;
                    TmdPostprocessor.clut = clut;
                    AssetDatabase.Refresh();

                    if (outFile.StartsWith(Application.dataPath))
                        outFile = "Assets" + outFile.Substring(Application.dataPath.Length);

                    TmdScriptableObject tmd = AssetDatabase.LoadAssetAtPath(outFile, typeof(TmdScriptableObject)) as TmdScriptableObject;
                    TmdPostprocessor.script = false;
                    ram.objects.Add(ramAddress, tmd);
                }

                EditorUtility.SetDirty(ram);
            }
        }
    }
}
