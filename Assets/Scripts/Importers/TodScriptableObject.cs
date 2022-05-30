using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Packet
{
    public Vector3Int DAT_00;
    public Vector3Int DAT_06;
    public uint[] COMP;
}

[System.Serializable]
public class Frame
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
}

[CreateAssetMenu(fileName = "TOD", menuName = "ScriptableObjects/TodScriptableObject", order = 1)]
public class TodScriptableObject : ScriptableObject
{
    public string prefabName;

    public uint PACKET_OFFSET;
    public int FRAME_COUNT;
    public Frame[] FRAMES;
    public Packet[] PACKETS;
}
