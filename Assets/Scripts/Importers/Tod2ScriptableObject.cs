using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Frame2
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
    public byte DAT_04;
    public byte DAT_05;
    public sbyte DAT_06;
    public sbyte DAT_07;
}

[CreateAssetMenu(fileName = "TOD2", menuName = "ScriptableObjects/Tod2ScriptableObject", order = 1)]
public class Tod2ScriptableObject : ScriptableObject
{
    public string prefabName;

    public Frame2[] FRAMES;
}
