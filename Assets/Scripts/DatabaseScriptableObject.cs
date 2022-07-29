using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DBASE", menuName = "ScriptableObjects/DatabaseScriptableObject", order = 1)]
public class DatabaseScriptableObject : ScriptableObject
{
    public RamScriptableObject playerCore;
    public RamScriptableObject common;
}
