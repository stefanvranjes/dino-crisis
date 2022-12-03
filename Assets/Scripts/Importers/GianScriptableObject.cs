using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpuVoiceAttr
{
    public byte FLAGS; //0x01
    public byte DAT_02;
    public byte DAT_03;
    public byte SAMPLE_NOTE; //0x04
    public byte NOTE; //0x05
    public ushort ADSR1; //0x10
    public ushort ADSR2; //0x12
    public ushort ADDR; //0x16
}

public class GianScriptableObject : ScriptableObject
{
    public string prefabName;

    public SpuVoiceAttr[] ATTRS;
}
