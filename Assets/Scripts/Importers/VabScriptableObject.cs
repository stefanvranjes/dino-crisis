using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundSourceData
{
    public Vector2Int[] DAT_00;
    public byte DAT_10;
    public byte DAT_11;
}

public class VabScriptableObject : ScriptableObject
{
    public string prefabName;

    public SoundSourceData[] SRCS;
}
