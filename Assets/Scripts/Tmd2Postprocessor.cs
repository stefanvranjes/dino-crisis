using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Tmd2Postprocessor : AssetPostprocessor
{
    public static bool script;
    public static uint address;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_TMD2 tmd2Importer = assetImporter as IMP_TMD2;

            if (tmd2Importer != null && script)
            {
                tmd2Importer.ramAddress = address;
            }
        }
    }
}
