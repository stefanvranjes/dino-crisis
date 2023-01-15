using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Tmd3Postprocessor : AssetPostprocessor
{
    public static bool script;
    public static uint address;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_TMD3 tmd3Importer = assetImporter as IMP_TMD3;

            if (tmd3Importer != null && script)
            {
                tmd3Importer.ramAddress = address;
            }
        }
    }
}
