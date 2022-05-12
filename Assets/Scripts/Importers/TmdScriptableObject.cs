using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TMD", menuName = "ScriptableObjects/TmdScriptableObject", order = 1)]
public class TmdScriptableObject : ScriptableObject
{
    public string prefabName;

    public uint OFFSET_1;
    public uint OFFSET_2;
    public int QUAD_COUNT_1;
    public int QUAD_COUNT_2;
    public byte[] CMDS;
    public Vector3[] VERTS;
    public Vector2[] UVS;
    public Color[] CLRS;
    public int[] TRIS;
    public Texture2D TEX_2D;
}
