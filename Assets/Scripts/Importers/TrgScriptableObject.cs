using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TriggerData
{
    public sbyte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
    public Vector3Int DAT_04;
    public short DAT_0A;
    public short DAT_0C;
    public short DAT_0E;
    public short DAT_10;
    public ushort DAT_12;
    public bool DAT_14;
    public ushort DAT_16;
}

[CreateAssetMenu(fileName = "TRG", menuName = "ScriptableObject/TrgScriptableObject", order = 1)]
public class TrgScriptableObject : ScriptableObject
{
    public string prefabName;

    public TriggerData[] TRIGGERS;
}
