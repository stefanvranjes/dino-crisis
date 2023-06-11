using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WallSegment
{
    public byte WALL_COUNT; //0x01
    public uint WALL_OFFSET; //0x08
    public WallCollider[] WALL_COLLIDERS; //0x110
}

[System.Serializable]
public class FloorSegment
{
    public byte FLOOR_COUNT; //0x00
    public uint FLOOR_OFFSET; //0x04
    public FloorCollider[] FLOOR_COLLIDERS; //0x110
}

[System.Serializable]
public class FloorCollider
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public Vector2Int[] DAT_04; //0x00 -writable
}

[System.Serializable]
public class WallCollider
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01 -writable
    public byte DAT_02; //0x02
    public byte DAT_03; //0x03
    public Vector2Int DAT_04; //0x04
    public Vector2Int DAT_08; //0x08
    public ushort flags; //0x0C -writable
}

//writable class (must be instantiated!)
public class SceneColliderScriptableObject : ScriptableObject
{
    public string prefabName;

    public WallSegment[] WALL_SEGMENTS;
    public FloorSegment[] FLOOR_SEGMENT;
}
