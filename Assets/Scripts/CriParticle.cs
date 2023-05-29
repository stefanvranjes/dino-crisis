using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriParticle : CriObject
{
    public Vector3Int DAT_34; //0x34
    public byte DAT_3C; //0x3C
    public byte DAT_3D; //0x3D
    public byte DAT_3E; //0x3E
    public byte DAT_3F; //0x3F
    public Vector3Int DAT_40; //0x40
    public CriObject DAT_4C; //0x4C
    public Color32 DAT_50; //0x50
    public ushort DAT_54; //0x54
    public ushort DAT_56; //0x56
    public Tod2ScriptableObject DAT_58; //0x58
    public int DAT_5C; //0x5C
    public ushort DAT_60; //0x60
    public ushort DAT_62; //0x62
    public byte DAT_64; //0x64
    public byte DAT_65; //0x65
    public byte DAT_68; //0x68
    public byte DAT_69; //0x69
    public byte DAT_6A; //0x6A
    public byte DAT_6B; //0x6B
    public byte DAT_6C; //0x6C
    public int IDAT_6C; //0x6C
    private delegate void FUN_9C790();
    private delegate void FUN_9C7AC();
    private delegate void FUN_9C7B4();
    private delegate void FUN_9C7C0();
    public static uint[] DAT_9C774 = new uint[7]
    {
        0x8019dfd8, 0x8019e698, 0x8019e6d8, 0x8019dfd8,
        0x8019e0c0, 0x8019e058, 0x8019e610
    };
    private FUN_9C790[] PTR_FUN_9C790;
    public static uint[] DAT_9C7A4 = new uint[2] { 0x8019e0e8, 0x8019e0f0 };
    private FUN_9C7AC[] PTR_FUN_9C7AC;
    private FUN_9C7B4[] PTR_FUN_9C7B4;
    private FUN_9C7C0[] PTR_FUN_9C7C0;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_9C790 = new FUN_9C790[5]
        {
            FUN_44F08,
            FUN_44FC0,
            FUN_60068,
            FUN_45038,
            FUN_45104
        };
        PTR_FUN_9C7AC = new FUN_9C7AC[2]
        {
            FUN_45260, 
            FUN_60068
        };
        PTR_FUN_9C7B4 = new FUN_9C7B4[3]
        {
            FUN_452D0,
            FUN_452D0,
            FUN_45304
        };
        PTR_FUN_9C7C0 = new FUN_9C7C0[3]
        {
            FUN_4538C,
            FUN_45444,
            FUN_60068
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
        DAT_34 = Vector3Int.zero;
        DAT_3C = 0;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_40 = Vector3Int.zero;
        DAT_4C = null;
        DAT_50 = Color.black;
        DAT_54 = 0;
        DAT_56 = 0;
        DAT_58 = null;
        DAT_5C = 0;
        DAT_60 = 0;
        DAT_62 = 0;
        DAT_64 = 0;
        DAT_65 = 0;
        DAT_68 = 0;
        DAT_69 = 0;
        DAT_6A = 0;
        DAT_6B = 0;
        DAT_6C = 0;
        IDAT_6C = 0;
    }

    public void FUN_44EA8()
    {
        int iVar1;

        iVar1 = IDAT_6C - 1;
        IDAT_6C = iVar1;

        if (iVar1 == -1)
            FUN_451A4();

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
                FUN_45038();
                return;
            }

            DAT_62 = DAT_69;
            DAT_60 = DAT_69;
        }

        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_9C774[DAT_2F]));
        DAT_56 = 62;
        DAT_54 = 0x7df0;
        DAT_3C = 1;
        flags |= 2;
    }

    private void FUN_44FC0()
    {
        int iVar1;

        screen.y += DAT_40.y;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        DAT_40.y += DAT_68;
        iVar1 = FUN_606D8();

        if (iVar1 == 1)
            DAT_3C = 2;
    }

    private void FUN_45038()
    {
        short sVar1;

        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_9C7A4[DAT_2F]));
        DAT_56 = 30;
        DAT_54 = 0x7df0;
        DAT_50.r = 0xd0;
        DAT_65 = 3;
        vr.x = 0x400;
        DAT_50.a |= 2;
        DAT_4C = SceneManager.instance.cCamera;

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

        FUN_606D8();
    }

    private void FUN_451A4()
    {
        Vector3Int local_10;

        if (DAT_4C != null)
        {
            local_10 = Utilities.ApplyMatrixSV(ref DAT_4C.cTransform.rotation, ref screen);
            screen.x = DAT_4C.screen.x + local_10.x;
            screen.y = DAT_4C.screen.y + local_10.y;
            screen.z = DAT_4C.screen.z + local_10.z;
            DAT_40 = Utilities.ApplyMatrixSV(ref DAT_4C.cTransform.rotation, ref DAT_40);
            DAT_4C = null;
        } 
    }

    public void FUN_45224()
    {
        PTR_FUN_9C7AC[DAT_3C]();
    }

    private void FUN_45260()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (DAT_2F == 0)
        {
            if (iVar1 != 0)
                DAT_3C++;
        }
        else
            PTR_FUN_9C7B4[DAT_2F]();
    }

    private void FUN_452D0()
    {
        if (GameManager.instance.DAT_7C == 0)
            DAT_3C++;
    }

    private void FUN_45304()
    {
        if ((SceneManager.instance.DAT_7CDC[DAT_68].flags & 1) == 0)
            DAT_3C++;
    }

    public void FUN_45350()
    {
        PTR_FUN_9C7C0[DAT_3C]();
    }

    private void FUN_4538C()
    {
        DAT_54 = 0x7df0;
        DAT_56 = 30;
        flags |= 2;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8019e0c0));
        DAT_50.a |= 2;
        FUN_451A4();
        DAT_34 = screen;
        screen.y += 2000;
        SceneManager.instance.FUN_834F0(this);
        DAT_65 = 3;
        vr.x = 0x400;
        DAT_40.x = 0;
        DAT_4C = SceneManager.instance.cCamera;
        DAT_3C++;
    }

    private void FUN_45444()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (iVar1 != 0)
            DAT_3C++;
    }

    public void FUN_606A8(Tod2ScriptableObject param1)
    {
        DAT_5C = 0;
        DAT_58 = param1;
        DAT_64 = param1.FRAMES[0].DAT_05;
        FUN_606D8();
    }

    public int FUN_606D8()
    {
        byte bVar1;
        uint uVar2;
        int iVar3;
        Frame2 fVar4;

        iVar3 = 0;

        if (DAT_64 != 1)
        {
            if (DAT_64 != 0) goto LAB_6078C;

            fVar4 = DAT_58.FRAMES[DAT_5C];
            uVar2 = fVar4.DAT_04 & 0xe0U;

            if (uVar2 == 0x20) goto LAB_6078C;

            if ((int)uVar2 < 0x21)
            {
                if (uVar2 != 0) goto LAB_6078C;

                fVar4 = DAT_58.FRAMES[DAT_5C + (fVar4.DAT_04 & 0x1f)];
            }
            else
            {
                if (uVar2 != 0x40) goto LAB_6078C;

                fVar4 = DAT_58.FRAMES[0];
            }

            DAT_5C = System.Array.IndexOf(DAT_58.FRAMES, fVar4);
            bVar1 = fVar4.DAT_05;
            DAT_64 = bVar1;

            if (bVar1 != 1) goto LAB_6078C;
        }

        iVar3 = (DAT_58.FRAMES[DAT_5C].DAT_04 << 0x18) >> 0x1d;
        LAB_6078C:
        DAT_64--;
        return iVar3;
    }
}
