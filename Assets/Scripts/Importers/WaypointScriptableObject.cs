using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WaypointContainer
{
    public byte DAT_00;
    public ushort[] OFF_02;
    public ushort[] OFF_04;
    public byte[] OFF_06;
}

public class WaypointScriptableObject : ScriptableObject
{
    public string prefabName;

    public WaypointContainer[] WAYPOINTS;
}
