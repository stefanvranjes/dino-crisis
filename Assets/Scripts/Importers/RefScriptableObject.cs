using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "REF", menuName = "ScriptableObjects/RefScriptableObject", order = 1)]
public class RefScriptableObject : ScriptableObject
{
    public string prefabName;

    public Object[] ASSET_REFS;
}
