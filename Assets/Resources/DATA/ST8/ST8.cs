using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST8 : LevelManager
{
    public static new ST8 instance;

    public uint[] DAT_119A4 = new uint[205] { 0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x11, 0x1a, 0x25, 0x29, 0x34, 0x49, 0x8000005c, 0x0, 0xf, 0x25, 0x30, 0x80000052, 0x0, 0x14, 0x1f, 0x28, 0x36, 0x47, 0x80000056, 0x0, 0x11, 0x1c, 0x2e, 0x41, 0x80000057, 0x0, 0xc, 0x1c, 0x2e, 0x41, 0x80000054, 0x0, 0x12, 0x29, 0x3a, 0x80000053, 0x0, 0xa, 0x10, 0x23, 0x2a, 0x3d, 0x80000055, 0x0, 0x10, 0x19, 0x20, 0x31, 0x3d, 0x80000057, 0x0, 0x23, 0x2c, 0x3f, 0x4f, 0x8000006e, 0x0, 0x4, 0x1b, 0x26, 0x49, 0x8000005a, 0x0, 0x14, 0x32, 0x4c, 0x80000060, 0x0, 0x8, 0x14, 0x23, 0x26, 0x2f, 0x3b, 0x46, 0x80000063, 0x0, 0x24, 0x31, 0x8000005a, 0x0, 0x11, 0x17, 0x22, 0x38, 0x3c, 0x41, 0x80000053, 0x0, 0x8, 0x1b, 0x1f, 0x36, 0x3e, 0x4e, 0x8000005f, 0x0, 0x3, 0x13, 0x23, 0x2a, 0x39, 0x44, 0x80000053, 0x0, 0xc, 0x1f, 0x29, 0x3a, 0x46, 0x80000055, 0x0, 0x7, 0x15, 0x20, 0x28, 0x39, 0x40, 0x46, 0x80000057, 0x0, 0x8, 0xb, 0xf, 0x12, 0x1f, 0x32, 0x36, 0x44, 0x48, 0x80000051, 0x0, 0xa, 0xf, 0x1a, 0x2b, 0x36, 0x3f, 0x80000056, 0x0, 0xa, 0x18, 0x29, 0x30, 0x3b, 0x8000005f, 0x0, 0xe, 0x80000023 };
    public TrgScriptableObject DAT_11CD8; //0x11CD8 (ST8)
    public byte[] DAT_11DC8 = new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 };
    public FUN_B58BC[] DAT_11DF8 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                     FUN_45B08, null, FUN_46A1C, null, null, null, FUN_45D38, 
                                                     FUN_45E70, null, null, null, FUN_1E4, FUN_410, FUN_D150, 
                                                     FUN_684, FUN_824, FUN_908 };
    public FUN_B58C0[] DAT_11E50 = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, null, null, 
                                                     null, null };
    public FUN_C2570[] DAT_11E74 = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, 
                                                     FUN_A7BC, FUN_7F808 };
    public FUN_C1CF8[] DAT_11E94 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, 
                                                     FUN_21ECC, FUN_22178, null, FUN_1760, null, FUN_222AC, 
                                                     FUN_22464, FUN_2268C, null, null, null, FUN_2C7C, 
                                                     FUN_1724, FUN_3410, FUN_2F84, null, FUN_87E4, FUN_61E0, 
                                                     FUN_ABCC, FUN_E3F0, FUN_F738, FUN_118B8 };
    private delegate void FUN_11F90(CriParticle p); //0x11F90 (ST8)
    private delegate void FUN_12020(CriParticle p); //0x12020 (ST8)
    private delegate void FUN_12048(CriParticle p); //0x12048 (ST8)
    private uint[] DAT_11F08 = new uint[] { 0x80138424, 0x80138434, 0x80138474, 0x80138504, 0x80138514, 0x8013851c, 0x80138524, 0x8013852c, 0x80138534, 0x8013853c, 0x80138544, 0x8013854c, 0x8013854c, 0x80138554, 0x801385c4, 0x8013865c, 0x8013866c, 0x80133fcc, 0x80133fdc, 0x8013401c, 0x801340ac, 0x801340bc, 0x801340c4, 0x801340cc, 0x801340d4, 0x801340dc, 0x801340e4, 0x801340ec, 0x801340f4, 0x801340f4, 0x801340fc, 0x8013416c, 0x80134204, 0x80134214 };
    private FUN_11F90[] PTR_FUN_11F90; //0x11F90 (ST8)
    private uint[] DAT_11F9C = new uint[] { 0x80144e70, 0x80145b88, 0x80145bd8, 0x80146178, 0x80146718, 0x80146750, 0x80146828, 0x80146908, 0x80146af8, 0x80146ba8, 0x80146bb0, 0x80146bb8, 0x80146bc0, 0x80146bc8, 0x80146bd0, 0x80146bd8, 0x80146be0, 0x80146be8, 0x80146bf0, 0x80146bf8, 0x80146c00, 0x80146c10, 0x80146c18, 0x80146c20, 0x80146c28, 0x80146c30, 0x80146c38, 0x80146c40, 0x80146c48, 0x80146c50, 0x80146c58, 0x80146c60, 0x80146c68 };
    private FUN_12020[] PTR_FUN_12020; //0x12020 (ST8)
    private uint[] DAT_12030 = new uint[] { 0x801278b4, 0x80127984, 0x8012799c };
    private ushort[] DAT_12034 = new ushort[] { 0x7efb, 0x7efb, 0x7efb };
    private FUN_12048[] PTR_FUN_12048; //0x12048 (ST8)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_11F90 = new FUN_11F90[3]
            {
                FUN_220,
                FUN_364,
                FUN_60068
            };
            PTR_FUN_12020 = new FUN_12020[4]
            {
                FUN_44C,
                FUN_5CC,
                FUN_630,
                FUN_60068
            };
            PTR_FUN_12048 = new FUN_12048[3]
            {
                FUN_6C0,
                FUN_780,
                FUN_60068
            };
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

    //FUN_10C (ST8)
    public override void Initialize()
    {
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_11DF8;
        PTR_FUN_B58C0 = DAT_11E50;
        PTR_FUN_C2570 = DAT_11E74;
        PTR_FUN_C1CF8 = DAT_11E94;
        SceneManager.instance.DAT_AC = DAT_11DC8;
        SceneManager.instance.DAT_B0 = DAT_119A4;
        GameManager.instance.DAT_46 = 8;

        for (int i = 0; i < DAT_11CD8.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_11CD8.TRIGGERS[i];
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

        GameManager.instance.FUN_5E130(0, 4, 0);
    }

    //FUN_220 (ST8)
    private void FUN_220(CriParticle param1)
    {
        byte bVar1;
        uint uVar2;
        int iVar3;

        bVar1 = param1.DAT_2F;
        param1.flags |= 2;

        if (bVar1 < 3)
        {
            param1.DAT_56 = 0x38;
            param1.DAT_54 = 0x7f35;
        }
        else
        {
            if (bVar1 < 17 && 12 < bVar1)
            {
                param1.DAT_56 = 0x78;
                param1.DAT_54 = 0x7f37;
                param1.DAT_50.r = param1.DAT_69;
                param1.DAT_50.g = param1.DAT_6A;
                param1.DAT_50.b = param1.DAT_6B;
            }
            else
            {
                param1.DAT_56 = 0x38;
                param1.DAT_54 = 0x7f36;
                param1.vr.z = (short)(param1.DAT_69 << 4);
            }
        }

        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (GameManager.instance.DAT_9AA0 == 10)
            uVar2 = param1.DAT_2F + 17U;
        else
            uVar2 = param1.DAT_2F;

        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11F08[uVar2 & 0xff]));

        if (iVar3 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_364 (ST8)
    private void FUN_364(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;
        iVar2 = param1.FUN_606D8();

        if (param1.DAT_2F < 2)
        {
            sVar1 = (sbyte)(param1.DAT_69 - 1);
            param1.DAT_69 = (byte)sVar1;

            if (sVar1 == 0)
                param1.DAT_3C = 2;
        }
        else
        {
            if (iVar2 == 1)
                param1.DAT_3C = 2;
        }
    }

    //FUN_44C (ST8)
    private void FUN_44C(CriParticle param1)
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;

        bVar1 = param1.DAT_2F;
        param1.flags |= 2;

        if (bVar1 == 7)
        {
            uVar2 = 0x67;
            param1.DAT_56 = uVar2;
        }
        else
        {
            if (bVar1 < 8)
            {
                uVar2 = 0x27;

                if (bVar1 < 2)
                {
                    uVar2 = 0x67;
                    param1.DAT_56 = uVar2;
                }
                else
                    param1.DAT_56 = uVar2;
            }
            else if (bVar1 == 9)
            {
                uVar2 = 0x47;
                param1.DAT_56 = uVar2;
            }
            else
                param1.DAT_56 = 0x27;
        }

        bVar1 = param1.DAT_2F;

        if (bVar1 == 7)
            uVar2 = 0x7eff;
        else
        {
            if (bVar1 < 8)
            {
                if (bVar1 != 0)
                {
                    param1.DAT_54 = 0x7efe;
                    goto LAB_4F0;
                }

                uVar2 = 0x7eff;
            }
            else
            {
                uVar2 = 0x7efe;

                if (bVar1 == 9)
                    uVar2 = 0x7eff;
            }
        }

        param1.DAT_54 = uVar2;
        LAB_4F0:
        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (param1.DAT_2F == 9)
            param1.DAT_62 = param1.DAT_6B;

        if (param1.DAT_6A != 0)
        {
            param1.DAT_65 |= 3;
            param1.vr.x = 0;
            param1.DAT_4C = SceneManager.instance.cCamera;
            param1.vr.y = (short)(param1.DAT_6A << 4);
        }

        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11F9C[param1.DAT_2F]));

        if (iVar3 == 1)
            param1.DAT_3C = 3;
        else
            param1.DAT_3C = 1;

        if (param1.DAT_2F - 2 < 3)
            param1.DAT_3C = 2;
    }

    //FUN_5CC (ST8)
    private void FUN_5CC(CriParticle param1)
    {
        int iVar1;
        bool bVar2;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 3;

        if (param1.DAT_69 != 0)
        {
            bVar2 = InventoryManager.FUN_4A87C(3, param1.DAT_69);

            if (bVar2)
                param1.DAT_3C = 3;
        }
    }

    //FUN_630 (ST8)
    private void FUN_630(CriParticle param1)
    {
        bool bVar1;

        param1.FUN_606D8();

        if (param1.DAT_69 != 0)
        {
            bVar1 = InventoryManager.FUN_4A87C(3, param1.DAT_69);

            if (bVar1)
                param1.DAT_3C = 3;
        }
    }

    //FUN_6C0 (ST8)
    private void FUN_6C0(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_12030[param1.DAT_2F & 15]));
        param1.DAT_56 = 0x25;
        param1.DAT_54 = DAT_12034[param1.DAT_2F & 15];

        if ((param1.DAT_2F & 15) == 0)
            param1.DAT_50.a |= 2;

        param1.DAT_40.y = 10;
        param1.DAT_68 = 9;
        param1.flags |= 2;
        param1.DAT_62 = param1.DAT_69;
        param1.DAT_60 = param1.DAT_69;
        param1.DAT_3C++;
    }

    //FUN_780 (ST8)
    private void FUN_780(CriParticle param1)
    {
        short sVar1;
        int iVar2;

        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C++;

        sVar1 = (short)(param1.DAT_40.y + param1.DAT_68);
        param1.DAT_40.y = sVar1;

        if ((param1.DAT_2F & 15) == 0)
            sVar1 = (short)(param1.screen.y - sVar1);
        else
            sVar1 = (short)(param1.screen.y + sVar1);

        param1.screen.y = sVar1;

        if (10000 < param1.screen.y)
            param1.DAT_3C++;
    }

    //FUN_1E4 (ST8)
    public static void FUN_1E4(CriParticle param1)
    {
        instance.PTR_FUN_11F90[param1.DAT_3C](param1);
    }

    //FUN_410 (ST8)
    public static void FUN_410(CriParticle param1)
    {
        instance.PTR_FUN_12020[param1.DAT_3C](param1);
    }

    //FUN_684 (ST8)
    public static void FUN_684(CriParticle param1)
    {

    }

    //FUN_824 (ST8)
    public static void FUN_824(CriParticle param1)
    {

    }

    //FUN_908 (ST8)
    public static void FUN_908(CriParticle param1)
    {

    }

    //FUN_A68 (ST8)
    public static void FUN_A68(CriInteract param1)
    {

    }

    //FUN_1724 (ST8)
    public static void FUN_1724(CriInteract param1)
    {

    }

    //FUN_1760 (ST8)
    public static void FUN_1760(CriInteract param1)
    {

    }

    //FUN_2C7C (ST8)
    public static void FUN_2C7C(CriInteract param1)
    {

    }

    //FUN_2F84 (ST8)
    public static void FUN_2F84(CriInteract param1)
    {

    }

    //FUN_3410 (ST8)
    public static void FUN_3410(CriInteract param1)
    {

    }

    //FUN_61E0 (ST8)
    public static void FUN_61E0(CriInteract param1)
    {

    }

    //FUN_87E4 (ST8)
    public static void FUN_87E4(CriInteract param1)
    {

    }

    //FUN_A7BC (ST8)
    public static void FUN_A7BC(CriStatic param1)
    {

    }

    //FUN_ABCC (ST8)
    public static void FUN_ABCC(CriInteract param1)
    {

    }

    //FUN_D150 (ST8)
    public static void FUN_D150(CriParticle param1)
    {

    }

    //FUN_E3F0 (ST8)
    public static void FUN_E3F0(CriInteract param1)
    {

    }

    //FUN_F738 (ST8)
    public static void FUN_F738(CriInteract param1)
    {

    }

    //FUN_10118 (ST8)
    public static void FUN_10118(CriInteract param1)
    {

    }

    //FUN_118B8 (ST8)
    public static void FUN_118B8(CriInteract param1)
    {

    }
}
