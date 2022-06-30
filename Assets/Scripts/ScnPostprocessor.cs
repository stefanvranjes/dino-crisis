using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScnPostprocessor : AssetPostprocessor
{
    public static List<int> movieIds;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_SCN scnImporter = assetImporter as IMP_SCN;

            if (scnImporter != null)
            {
                scnImporter.movieIds = movieIds.ToArray();
            }
        }
    }
}
