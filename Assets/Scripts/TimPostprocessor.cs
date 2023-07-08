using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TimPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static ClutScriptableObject clut;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_TIM timImporter = assetImporter as IMP_TIM;

            if (timImporter != null && script)
            {
                timImporter.clut = clut;
            }
        }
    }
}
