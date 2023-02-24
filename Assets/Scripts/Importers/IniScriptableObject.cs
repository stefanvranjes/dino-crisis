using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundData
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
}

public class IniScriptableObject : ScriptableObject
{
    public string prefabName;

    public uint ADDR;
    public uint SIZE;
    public SoundData[] DATA;
}
