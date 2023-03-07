using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SVECTOR_SERIALIZED_ARRAY
{
    public Vector2Int[] sv2;
}

[CreateAssetMenu(fileName = "SV2", menuName = "ScriptableObjects/SV2ScriptableObject")]
public class SV2ScriptableObject : ScriptableObject
{
    public string prefabName;

    public SVECTOR_SERIALIZED_ARRAY[] SVECTORS;
}
