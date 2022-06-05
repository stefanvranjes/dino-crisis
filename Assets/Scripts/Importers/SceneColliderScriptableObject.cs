using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ColliderSegment
{
    public byte FLOOR_COUNT; //0x10
    public uint FLOOR_OFFSET; //0x14
    public FloorCollider[] FLOOR_COLLIDERS; //0x110
}

[System.Serializable]
public class FloorCollider
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public Vector2Int[] DAT_04; //0x00
}

public class SceneColliderScriptableObject : ScriptableObject
{
    public string prefabName;

    public ColliderSegment[] SEGMENTS;
}
