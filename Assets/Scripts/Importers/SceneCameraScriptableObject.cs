using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CameraMotion
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public byte DAT_02; //0x02
    public byte DAT_03; //0x03
    public Vector2Int[] DAT_04; //0x04
    public byte DAT_24; //0x24
    public byte DAT_25; //0x25
    public byte DAT_26; //0x26
    public byte DAT_27; //0x27
    public Vector3Int DAT_2C; //0x2C
    public short DAT_32; //0x32
    public Vector3Int DAT_34; //0x34
    public Vector3Int DAT_3C; //0x3C
}

public class SceneCameraScriptableObject : ScriptableObject
{
    public string prefabName;

    public CameraMotion[] MOTIONS;
}
