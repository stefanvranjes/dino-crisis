using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GianPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static int index;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_GIAN gianImporter = assetImporter as IMP_GIAN;

            if (gianImporter != null && script)
            {
                gianImporter.index = index;
            }
        }
    }
}
