using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//writable class; needs intantiating!!!
[System.Serializable]
public class LightSource
{
    public byte DAT_00; //writable
    public byte DAT_01; //writable
    public byte DAT_02; //writable
    public byte DAT_03;
    public Vector3Int DAT_04; //writable
    public short DAT_0A;
    public short DAT_0E;
}

public class LightScriptableObject : ScriptableObject
{
    public ushort DAT_00;
    public ushort DAT_02;
    public byte DAT_06;
    public Color32 DAT_08;
    public Vector3Int DAT_0C;
    public Vector3Int DAT_12;
    public byte DAT_18;
    public byte DAT_19;
    public byte DAT_1A;
    public byte DAT_1E;
    public byte DAT_1F;
    public byte DAT_20;
    public LightSource[] DAT_24;
}
