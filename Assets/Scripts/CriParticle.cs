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
    private delegate void FUN_9C790();
    private FUN_9C790[] PTR_FUN_9C790;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_9C790 = new FUN_9C790[]
        {
            FUN_44F08,
            FUN_44FC0,
            FUN_60068,
            FUN_45038,
            FUN_45104
        };
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

    public void FUN_44EA8()
    {
        //...
        PTR_FUN_9C790[DAT_3C]();
    }

    private void FUN_44F08()
    {
        byte bVar1;

        if ((DAT_2F & 0x80) != 0)
        {
            bVar1 = (byte)(DAT_2F & 0x7f);
            DAT_2F = bVar1;

            if (6 < bVar1)
            {
                DAT_2F = (byte)(bVar1 - 7);
                DAT_3C = 3;
                //FUN_45038
                return;
            }

            DAT_62 = DAT_69;
            DAT_60 = DAT_69;
        }

        //FUN_606A8
        DAT_56 = 62;
        DAT_54 = 0x7df0;
        DAT_3C = 1;
        flags |= 2;
    }

    private void FUN_44FC0()
    {
        screen.y += DAT_40.y;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        DAT_40.y += DAT_68;
        //...
    }

    private void FUN_45038()
    {
        short sVar1;

        //FUN_606A8
        DAT_56 = 30;
        DAT_54 = 0x7df0;
        DAT_50.r = 0xd0;
        DAT_65 = 3;
        vr.x = 0x400;
        DAT_50.a |= 2;
        //DAT_4C = SceneManager.instance.cCamera;

        if (DAT_68 == 0)
        {
            sVar1 = (short)(DAT_69 << 4);
            DAT_62 = (ushort)sVar1;
            DAT_60 = (ushort)sVar1;
            DAT_69 = 0;
            DAT_6A = 0;
        }

        DAT_6B = 0;
        flags |= 2;
        DAT_3C++;
    }

    private void FUN_45104()
    {
        byte bVar1;
        byte bVar2;

        if (DAT_69 != 0)
        {
            DAT_69--;
            bVar1 = DAT_6B;
            bVar2 = (byte)(bVar1 + DAT_68);
            DAT_6B = bVar2;

            if (bVar2 < bVar1)
            {
                DAT_60++;
                DAT_62++;
            }
        }

        if (DAT_6A < DAT_68)
            DAT_68 -= DAT_6A;
        else
            DAT_68 = 0;

        //FUN_606D8
    }
}
