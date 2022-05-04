using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TmdScriptableObject : ScriptableObject
{
    public string prefabName;

    public int QUAD_COUNT;
    public byte[] CMDS;
    public Vector3[] VERTS;
    public Vector2[] UVS;
    public Color[] CLRS;
    public int[] TRIS;
}
