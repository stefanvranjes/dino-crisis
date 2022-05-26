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

    public uint VERT_OFFSET; //0x00
    public uint NRML_OFFSET; //0x04
    public uint TRI_OFFSET; //0x08
    public uint QUAD_OFFSET; //0x0C
    public ushort TRI_COUNT; //0x10
    public ushort QUAD_COUNT; //0x12
    public int BONE_COUNT; //0x14
    public Bone[] BONES; //0x18
    public Vector3[] VERTS;
    public Vector2[] UVS;
    public Vector3[] UVS2;
    public Vector3Int[] NRMLS;
    public int[] TRIS;
    public int[] QUADS;
    public Texture2D TEX_2D;
    public Texture2D TEX8_2D;
    public Texture2D CLUT_2D;
}
