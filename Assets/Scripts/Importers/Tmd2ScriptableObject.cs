using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bone
{
    public Vector3Int DAT_00; //svector
    public sbyte DAT_06;
    public byte DAT_07;
}

[CreateAssetMenu(fileName = "TMD2", menuName = "ScriptableObjects/Tmd2ScriptableObject", order = 1)]
public class Tmd2ScriptableObject : ScriptableObject
{
    public string prefabName;

    public uint VERTS_OFFSET; //0x00
    public uint NRMLS_OFFSET; //0x04
    public int BONE_COUNT; //0x14
    public Bone[] BONES; //0x18
    public Vector3Int[] VERTS;
    public Vector3Int[] NRMLS;
}
