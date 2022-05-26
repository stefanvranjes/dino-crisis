using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TMD3", menuName = "ScriptableObjects/Tmd3ScriptableObject", order = 1)]
public class Tmd3ScriptableObject : ScriptableObject
{
    public string prefabName;

    public uint TRI_OFFSET; //0x00
    public uint QUAD_OFFSET; //0x04
    public int TRI_COUNT; //0x08
    public int QUAD_COUNT; //0x0A
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
