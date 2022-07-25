using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriParticle : CriObject
{
    public byte DAT_3C; //0x3C
    public byte DAT_3D; //0x3D
    public byte DAT_3E; //0x3E
    public byte DAT_3F; //0x3F
    public Vector3Int DAT_40; //0x40
    public CriObject DAT_4C; //0x4C
    public Color32 DAT_50; //0x50
    public ushort DAT_54; //0x54
    public ushort DAT_56; //0x56
    public ushort DAT_60; //0x60
    public ushort DAT_62; //0x62
    public byte DAT_64; //0x64
    public byte DAT_65; //0x65
    public byte DAT_68; //0x68
    public byte DAT_69; //0x69
    public byte DAT_6A; //0x6A
    public byte DAT_6B; //0x6B
    public byte DAT_6C; //0x6C

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_3C = 0;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_40 = Vector3Int.zero;
        DAT_4C = null;
        DAT_50 = Color.black;
        DAT_54 = 0;
        DAT_56 = 0;
        DAT_60 = 0;
        DAT_62 = 0;
        DAT_64 = 0;
        DAT_65 = 0;
        DAT_68 = 0;
        DAT_69 = 0;
        DAT_6A = 0;
        DAT_6B = 0;
        DAT_6C = 0;
    }
}
