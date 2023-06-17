using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Frame3
{
    public byte DAT_00;
    public uint FRAME_NUM; //0x04
    public ushort DAT_0C;
    public Vector3Int POSITION; //0x0E
    public Vector3Int VELOCITY; //0x16
}

[CreateAssetMenu(fileName = "TOD3", menuName = "ScriptableObjects/Tod3ScriptableObject", order = 1)]
public class Tod3ScriptableObject : ScriptableObject
{
    public string prefabName;

    public Frame3[] FRAMES;
}
