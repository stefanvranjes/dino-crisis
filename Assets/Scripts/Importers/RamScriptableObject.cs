using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIntObjectDictionary : SerializableDictionary<uint, Object> { }

[CreateAssetMenu(fileName = "RAM", menuName = "ScriptableObjects/RamScriptableObject", order = 1)]
public class RamScriptableObject : ScriptableObject
{
    public string prefabName;

    public UIntObjectDictionary objects;
}
