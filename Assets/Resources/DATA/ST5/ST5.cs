using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST5 : LevelManager
{
    public static new ST5 instance;

    public uint[] DAT_11A90 = new uint[205] { 0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x11, 0x1a, 0x25, 0x29, 0x34, 0x49, 0x8000005c, 0x0, 0xf, 0x25, 0x30, 0x80000052, 0x0, 0x14, 0x1f, 0x28, 0x36, 0x47, 0x80000056, 0x0, 0x11, 0x1c, 0x2e, 0x41, 0x80000057, 0x0, 0xc, 0x1c, 0x2e, 0x41, 0x80000054, 0x0, 0x12, 0x29, 0x3a, 0x80000053, 0x0, 0xa, 0x10, 0x23, 0x2a, 0x3d, 0x80000055, 0x0, 0x10, 0x19, 0x20, 0x31, 0x3d, 0x80000057, 0x0, 0x23, 0x2c, 0x3f, 0x4f, 0x8000006e, 0x0, 0x4, 0x1b, 0x26, 0x49, 0x8000005a, 0x0, 0x14, 0x32, 0x4c, 0x80000060, 0x0, 0x8, 0x14, 0x23, 0x26, 0x2f, 0x3b, 0x46, 0x80000063, 0x0, 0x24, 0x31, 0x8000005a, 0x0, 0x11, 0x17, 0x22, 0x38, 0x3c, 0x41, 0x80000053, 0x0, 0x8, 0x1b, 0x1f, 0x36, 0x3e, 0x4e, 0x8000005f, 0x0, 0x3, 0x13, 0x23, 0x2a, 0x39, 0x44, 0x80000053, 0x0, 0xc, 0x1f, 0x29, 0x3a, 0x46, 0x80000055, 0x0, 0x7, 0x15, 0x20, 0x28, 0x39, 0x40, 0x46, 0x80000057, 0x0, 0x8, 0xb, 0xf, 0x12, 0x1f, 0x32, 0x36, 0x44, 0x48, 0x80000051, 0x0, 0xa, 0xf, 0x1a, 0x2b, 0x36, 0x3f, 0x80000056, 0x0, 0xa, 0x18, 0x29, 0x30, 0x3b, 0x8000005f, 0x0, 0xe, 0x80000023 };
    public TrgScriptableObject DAT_11DC4; //0x11DC4 (ST5)
    public TrgScriptableObject DAT_11EB4; //0x11EB4 (ST5)
    public byte[][] DAT_11FA4 = new byte[3][]
    {
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 10, 5, 1, 22, 0, 0, 0, 23, 0, 0, 0, 16, 20, 11, 6, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 }
    };
    public FUN_C1CF8[] DAT_120D0 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_20A98,
                                                     FUN_21758, FUN_21ECC, FUN_22178, null, FUN_184C,
                                                     null, FUN_222AC, FUN_22464, FUN_2268C, null, null, null,
                                                     FUN_B54, FUN_2D68, FUN_1810, FUN_34FC, FUN_3070,
                                                     null, FUN_88D0, FUN_62CC, FUN_ACB8, FUN_E4DC,
                                                     FUN_F824, FUN_62CC, FUN_ACB8 };

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    //FUN_134 (ST5)
    public override void Initialize()
    {
        bool bVar1;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_C1CF8 = DAT_120D0;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_11FA4[uVar3];
        SceneManager.instance.DAT_B0 = DAT_11A90;
        GameManager.instance.DAT_46 = 5;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xe1);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_11DC4.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_11EB4.TRIGGERS[i];
                puVar4.DAT_00 = puVar5.DAT_00;
                puVar4.DAT_01 = puVar5.DAT_01;
                puVar4.DAT_02 = puVar5.DAT_02;
                puVar4.DAT_03 = puVar5.DAT_03;
                puVar4.DAT_04 = puVar5.DAT_04;
                puVar4.DAT_0A = puVar5.DAT_0A;
                puVar4.DAT_0C = puVar5.DAT_0C;
                puVar4.DAT_0E = puVar5.DAT_0E;
                puVar4.DAT_10 = puVar5.DAT_10;
                puVar4.DAT_12 = puVar5.DAT_12;
                puVar4.DAT_14 = puVar5.DAT_14;
                puVar4.DAT_16 = puVar5.DAT_16;
            }
        }
        else
        {
            for (int i = 0; i < DAT_11EB4.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_11EB4.TRIGGERS[i];
                puVar4.DAT_00 = puVar5.DAT_00;
                puVar4.DAT_01 = puVar5.DAT_01;
                puVar4.DAT_02 = puVar5.DAT_02;
                puVar4.DAT_03 = puVar5.DAT_03;
                puVar4.DAT_04 = puVar5.DAT_04;
                puVar4.DAT_0A = puVar5.DAT_0A;
                puVar4.DAT_0C = puVar5.DAT_0C;
                puVar4.DAT_0E = puVar5.DAT_0E;
                puVar4.DAT_10 = puVar5.DAT_10;
                puVar4.DAT_12 = puVar5.DAT_12;
                puVar4.DAT_14 = puVar5.DAT_14;
                puVar4.DAT_16 = puVar5.DAT_16;
            }
        }

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 5);
        bVar1 = InventoryManager.FUN_4A87C(0, 0xf);

        if (!bVar1)
        {
            SceneManager.instance.DAT_9EEC[3].DAT_03 |= 2;
            SceneManager.instance.DAT_9EEC[4].DAT_03 |= 2;
        }
    }

    //FUN_B54 (ST4)
    public static void FUN_B54(CriInteract param1)
    {
        return;
    }

    //FUN_1810 (ST4)
    public static void FUN_1810(CriInteract param1)
    {
        return;
    }

    //FUN_184C (ST4)
    public static void FUN_184C(CriInteract param1)
    {
        return;
    }

    //FUN_2D68 (ST4)
    public static void FUN_2D68(CriInteract param1)
    {
        return;
    }

    //FUN_3070 (ST4)
    public static void FUN_3070(CriInteract param1)
    {
        return;
    }

    //FUN_34FC (ST4)
    public static void FUN_34FC(CriInteract param1)
    {
        return;
    }

    //FUN_62CC (ST4)
    public static void FUN_62CC(CriInteract param1)
    {
        return;
    }

    //FUN_88D0 (ST4)
    public static void FUN_88D0(CriInteract param1)
    {
        return;
    }

    //FUN_ACB8 (ST4)
    public static void FUN_ACB8(CriInteract param1)
    {
        return;
    }

    //FUN_E4DC (ST4)
    public static void FUN_E4DC(CriInteract param1)
    {
        return;
    }

    //FUN_F824 (ST4)
    public static void FUN_F824(CriInteract param1)
    {
        return;
    }
}
