using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScriptableObject : ScriptableObject
{
    public string prefabName;

    public Vector2Int[] DAT_00; //0x00
    public byte DAT_10; //0x10
    public byte DAT_11; //0x11
    public byte DAT_12; //0x12
    public byte DAT_13; //0x13
    public byte DAT_23; //0x23
    public byte DAT_24; //0x24
}
