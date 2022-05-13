using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TMD", menuName = "ScriptableObjects/TmdScriptableObject", order = 1)]
public class TmdScriptableObject : ScriptableObject
{
    public string prefabName;

    public uint TRI_OFFSET;
    public uint QUAD_OFFSET;
    public int TRI_COUNT;
    public int QUAD_COUNT;
    public byte[] CMDS;
    public Vector3[] VERTS;
    public Vector2[] UVS;
    public Vector2[] UVS2;
    public Color[] CLRS;
    public int[] TRIS;
    public int[] QUADS;
    public Texture2D TEX_2D;
    public Texture2D CLUT_2D;
}
