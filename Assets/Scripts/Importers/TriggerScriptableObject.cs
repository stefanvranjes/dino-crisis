using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//writable class (needs instantiating upon start)
public class TriggerScriptableObject : ScriptableObject
{
    public string prefabName;

    public Vector2Int[] DAT_00; //0x00
    public byte DAT_10; //0x10
    public byte DAT_11; //0x11
    public byte DAT_12; //0x12
    public bool DAT_13; //0x13 - writable
    public byte DAT_18; //0x18
    public byte DAT_19; //0x19
    public byte DAT_1A; //0x1A - writable
    public byte DAT_1B; //0x1B - writable
    public ushort DAT_1C; //0x1C
    public byte DAT_1E; //0x1E
    public byte DAT_1F; //0x1F
    public byte DAT_23; //0x23
    public byte BDAT_24; //0x24
    public int IDAT_24; //0x24
    public byte DAT_28; //0x28
    public byte DAT_29; //0x29
}
