using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class _STATIC_OBJ_DATA
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public byte DAT_02; //0x02
    public byte DAT_03; //0x03
    public ushort DAT_04; //0x04
    public TmdScriptableObject DAT_08; //0x08;
    public Vector3Int DAT_0C; //0x0C
    public Vector3Int DAT_12; //0x12
}

public class ScnScriptableObject : ScriptableObject
{
    public string prefabName;

    public Object[] OBJECTS;
    public List<_STATIC_OBJ_DATA> staticObjs;
}
