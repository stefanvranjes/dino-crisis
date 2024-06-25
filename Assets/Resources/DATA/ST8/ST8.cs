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
    private delegate void FUN_12054(CriParticle p); //0x12054 (ST8)
    private delegate void FUN_12080(CriParticle p); //0x12080 (ST8)
    private delegate void FUN_1208C(CriInteract i); //0x1208C (ST8)
    private delegate void FUN_120AC(CriInteract i); //0x120AC (ST8)
    private delegate void FUN_12140(CriInteract i); //0x12140 (ST8)
    private delegate void FUN_12164(CriInteract i); //0x12164 (ST8)
    private delegate void FUN_121E4(CriInteract i); //0x121E4 (ST8)
    private delegate void FUN_121F4(CriInteract i); //0x121F4 (ST8)
    private uint[] DAT_11F08 = new uint[] { 0x80138424, 0x80138434, 0x80138474, 0x80138504, 0x80138514, 0x8013851c, 0x80138524, 0x8013852c, 0x80138534, 0x8013853c, 0x80138544, 0x8013854c, 0x8013854c, 0x80138554, 0x801385c4, 0x8013865c, 0x8013866c, 0x80133fcc, 0x80133fdc, 0x8013401c, 0x801340ac, 0x801340bc, 0x801340c4, 0x801340cc, 0x801340d4, 0x801340dc, 0x801340e4, 0x801340ec, 0x801340f4, 0x801340f4, 0x801340fc, 0x8013416c, 0x80134204, 0x80134214 };
    private FUN_11F90[] PTR_FUN_11F90; //0x11F90 (ST8)
    private uint[] DAT_11F9C = new uint[] { 0x80144e70, 0x80145b88, 0x80145bd8, 0x80146178, 0x80146718, 0x80146750, 0x80146828, 0x80146908, 0x80146af8, 0x80146ba8, 0x80146bb0, 0x80146bb8, 0x80146bc0, 0x80146bc8, 0x80146bd0, 0x80146bd8, 0x80146be0, 0x80146be8, 0x80146bf0, 0x80146bf8, 0x80146c00, 0x80146c10, 0x80146c18, 0x80146c20, 0x80146c28, 0x80146c30, 0x80146c38, 0x80146c40, 0x80146c48, 0x80146c50, 0x80146c58, 0x80146c60, 0x80146c68 };
    private FUN_12020[] PTR_FUN_12020; //0x12020 (ST8)
    private uint[] DAT_12030 = new uint[] { 0x801278b4, 0x80127984, 0x8012799c };
    private ushort[] DAT_12034 = new ushort[] { 0x7efb, 0x7efb, 0x7efb };
    private FUN_12048[] PTR_FUN_12048; //0x12048 (ST8)
    private FUN_12054[] PTR_FUN_12054; //0x12054 (ST8)
    private uint[] DAT_12060 = new uint[] { 0x80139200, 0x80139240, 0x80139270, 0x80139298, 0x801392b8, 0x801392e0, 0x80139308, 0x80139358 };
    private FUN_12080[] PTR_FUN_12080; //0x12080 (ST8)
    private FUN_1208C[] PTR_FUN_1208C; //0x1208C (ST8)
    private byte[] DAT_120A8 = new byte[] { 0, 3, 9, 2 };
    private FUN_120AC[] PTR_FUN_120AC; //0x120AC (ST8)
    private FUN_12140[] PTR_FUN_12140; //0x12140 (ST8)
    private FUN_12164[] PTR_FUN_12164; //0x12164 (ST8)
    private uint[][] DAT_121D8 = new uint[3][] { new uint[] { 0x8011746c, 0x80117c58, 0x80118744, 0x801191f0, 0x8011c2ac, 0x8011ca58, 0x8011d2a4, 0x8011dd50 },
                                                 new uint[] { 0x80119d1c, 0x8011a428, 0x80119d1c, 0x8011a428, 0x8011e85c, 0x8011f008, 0x8011e85c, 0x8011f008 },
                                                 new uint[] { 0x8011acd4, 0x8011b7e0, 0x8011acd4, 0x8011b7e0, 0x8011f954, 0x80120b40, 0x8011f954, 0x80120b40 } };
    private FUN_121E4[] PTR_FUN_121E4; //0x121E4 (ST8)
    private FUN_121F4[] PTR_FUN_121F4; //0x121F4 (ST8)
    private sbyte[] DAT_126A4 = new sbyte[10];
    private short[] DAT_128B0 = new short[0x100];
    private Tmd3ScriptableObject DAT_12AB0; //0x12AB0 (ST8)

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
            PTR_FUN_12054 = new FUN_12054[3]
            {
                FUN_860,
                FUN_8D4,
                FUN_60068
            };
            PTR_FUN_12080 = new FUN_12080[3]
            {
                FUN_974,
                FUN_A00,
                FUN_60068
            };
            PTR_FUN_1208C = new FUN_1208C[5]
            {
                FUN_ABC,
                FUN_D58,
                FUN_EE8,
                FUN_CA0,
                FUN_5FF98
            };
            PTR_FUN_120AC = new FUN_120AC[5]
            {
                FUN_1078,
                FUN_1108,
                FUN_1300,
                FUN_13B8,
                FUN_5FF98
            };
            PTR_FUN_12140 = new FUN_12140[7]
            {
                FUN_179C,
                FUN_1880,
                FUN_1A90,
                FUN_1B84,
                FUN_1C6C,
                FUN_1CC4,
                FUN_5FF98
            };
            PTR_FUN_12164 = new FUN_12164[5]
            {
                FUN_2CB8, 
                FUN_2D84, 
                FUN_2E9C, 
                FUN_2F38, 
                FUN_5FF98
            };
            PTR_FUN_121E4 = new FUN_121E4[4]
            {
                FUN_2FD0, 
                FUN_305C, 
                FUN_320C, 
                FUN_5FF98
            };
            PTR_FUN_121F4 = new FUN_121F4[]
            {
                FUN_3574, 
                FUN_35F4, 
                FUN_3650,

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

    //FUN_860 (ST8)
    private void FUN_860(CriParticle param1)
    {
        int iVar1;

        param1.DAT_56 = 0xfa;
        param1.DAT_54 = 0x7f70;
        param1.DAT_62 = param1.DAT_69;
        param1.flags |= 2;
        param1.DAT_60 = param1.DAT_68;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8012fd04));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_8D4 (ST8)
    private void FUN_8D4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_974 (ST8)
    private void FUN_974(CriParticle param1)
    {
        int iVar1;

        param1.DAT_56 = 0x25;
        param1.DAT_54 = 0x7efd;
        param1.flags |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.DAT_50.a |= 2;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_12060[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_A00 (ST8)
    private void FUN_A00(CriParticle param1)
    {
        int iVar1;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_ABC (ST8)
    private void FUN_ABC(CriInteract param1)
    {
        sbyte sVar1;
        ushort uVar2;
        ushort uVar3;
        CriPlayer oVar4;
        byte bVar5;
        uint uVar6;
        short sVar7;
        uint uVar8;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar1 = (sbyte)oVar4.DAT_1D7;
        param1.BDAT_08 = (byte)sVar1;

        if ((oVar4.DAT_1C0 & 8) != 0)
        {
            bVar5 = (byte)(sVar1 - 1);
            param1.BDAT_08 = bVar5;

            if ((bVar5 << 0x18) < 0)
                param1.BDAT_08 = 0;
        }

        if (oVar4.DAT_3D == 5)
        {
            if (param1.BDAT_08 == 0)
                uVar6 = oVar4.frameNum * 0x16U;
            else
                uVar6 = (uint)oVar4.frameNum << 5;
        }
        else
        {
            if (oVar4.DAT_3D != 1)
            {
                param1.BDAT_16 = 0;
                goto LAB_BAC;
            }

            if (param1.BDAT_08 == 0)
                uVar6 = oVar4.frameNum * 0x16U;

            uVar6 = (uint)oVar4.frameNum << 5;
        }

        uVar8 = oVar4.frameCount + 1U & 0xff;

        if (uVar8 == 0)
            return; //0x1c00

        param1.BDAT_16 = (byte)(uVar6 / uVar8);
        LAB_BAC:
        uVar2 = oVar4.DAT_140;
        oVar4.DAT_3C = 4;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        oVar4.DAT_152 = 2;
        uVar3 = oVar4.DAT_12C;
        oVar4.DAT_40.z = 0;
        oVar4.DAT_140 = (ushort)(uVar2 | 0x8000);
        bVar5 = oVar4.DAT_174;
        oVar4.DAT_12C = (ushort)(uVar3 | 0x10);
        oVar4.DAT_174 = (byte)(bVar5 & 0x7f);
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(2, 0x12, true);
        param1.DAT_0A = param1.DAT_07;
        param1.DAT_07 = 0x80;
        param1.DAT_03 = (sbyte)(param1.DAT_02 + 1);

        if (param1.DAT_02 == 0)
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * -0x1a9);
        else
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * 0x1a9);

        param1.DAT_0C = sVar7;
    }

    //FUN_D58 (ST8)
    private void FUN_D58(CriInteract param1)
    {
        short sVar1;
        CriSkinned oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.DAT_27C[10];
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018da38), 1, param1.BDAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e8b8), 1, param1.BDAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -13;
        }

        param1.UDAT_10 = (ushort)sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_EE8 (ST8)
    private void FUN_EE8(CriInteract param1)
    {
        short sVar1;
        CriSkinned oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.DAT_27C[10];
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e178), 1, param1.BDAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018f340), 1, param1.BDAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 13;
        }

        param1.UDAT_10 = (ushort)sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_CA0 (ST8)
    private void FUN_CA0(CriInteract param1)
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        CriPlayer oVar4;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar4.DAT_3C = 1;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        sVar2 = param1.DAT_0C;
        oVar4.DAT_140 &= 0x7fff;
        uVar3 = oVar4.DAT_12C;
        oVar4.DAT_152 = 0;
        oVar4.screen.y = sVar2;
        bVar1 = oVar4.DAT_174;
        oVar4.DAT_12C = (ushort)(uVar3 & 0xffef);
        oVar4.DAT_174 = (byte)(bVar1 | 0x80);
        InventoryManager.FUN_4A7E8(1, 2, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        oVar4.FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(oVar4.DAT_220), 1, 10, oVar4.DAT_220);
        param1.DAT_03++;
    }

    //FUN_1078 (ST8)
    private void FUN_1078(CriInteract param1)
    {
        int puVar1;
        uint uVar2;
        int puVar3;

        puVar3 = 0;
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        uVar2 = 0;
        puVar1 = puVar3;

        do
        {
            param1.SET_08(puVar1 + 4, 0xff);
            uVar2++;
            puVar1 = puVar3 + (int)uVar2;
        } while (uVar2 < 4);

        param1.BDAT_0A = 0;
        param1.BDAT_09 = 0;
        param1.SET_08(puVar3, 0);
        param1.DAT_03 = 1;
    }

    //FUN_1108 (ST8)
    private void FUN_1108(CriInteract param1)
    {
        sbyte sVar1;

        //FUN_13F8

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (param1.BDAT_08 == 4)
                param1.BDAT_08 = 0;
            else
                param1.BDAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            sVar1 = (sbyte)(param1.GET_08(0) - 1);

            if (param1.GET_08(0) == 0)
                sVar1 = 4;

            param1.SET_08(0, (byte)sVar1);
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            sVar1 = (sbyte)(param1.BDAT_09 - 1);

            if (param1.BDAT_09 == 0)
                sVar1 = 1;

            param1.BDAT_09 = (byte)sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (param1.BDAT_09 == 1)
                param1.BDAT_09 = 0;
            else
                param1.BDAT_09++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            param1.SET_08(param1.BDAT_0A + 4, (byte)(param1.GET_08(0) + param1.BDAT_09 * 5));

            if (param1.BDAT_0A == 3)
                param1.DAT_03 = 2;

            param1.BDAT_0A++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (param1.BDAT_0A == 0)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_03 = 4;
            }
            else
            {
                param1.SET_08(param1.BDAT_0A + 3, 0xff);
                param1.BDAT_0A--;
            }

            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_1300 (ST8)
    private void FUN_1300(CriInteract param1)
    {
        bool bVar1;
        int iVar2;
        int pcVar3;
        uint uVar4;
        int iVar5;
        int iVar6;

        iVar6 = 0;
        //FUN_13F8
        bVar1 = false;
        uVar4 = 0;
        iVar2 = iVar6;

        do
        {
            pcVar3 = (int)uVar4;
            uVar4++;

            if (param1.GET_08(iVar2 + 4) != DAT_120A8[pcVar3])
            {
                bVar1 = true;
                break;
            }

            iVar2 = iVar6 + (int)uVar4;
        } while (uVar4 < 4);

        if (bVar1)
        {
            InventoryManager.FUN_4A7E8(2, 10, true);
            iVar5 = 149;
        }
        else
        {
            InventoryManager.FUN_4A7E8(2, 9, true);
            iVar5 = 148;
        }

        GameManager.instance.FUN_5C94C(null, iVar5);
        param1.DAT_03 = 3;
    }

    //FUN_13B8 (ST8)
    private void FUN_13B8(CriInteract param1)
    {
        bool bVar1;

        //FUN_13F8
        bVar1 = InventoryManager.FUN_4A87C(3, 0x30);

        if (bVar1)
            param1.DAT_03 = 4;
    }

    //FUN_179C (ST8)
    private void FUN_179C(CriInteract param1)
    {
        sbyte sVar1;
        bool bVar3;
        uint uVar4;
        uint uVar5;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = 0;
        uVar4 = 0;

        do
        {
            DAT_126A4[uVar4] = -1;
            uVar5 = uVar4 + 1;
            uVar4 = uVar5;
        } while (uVar5 < 5);

        DAT_126A4[7] = 0;
        DAT_126A4[6] = 0;
        DAT_126A4[5] = 0;
        DAT_126A4[9] = 0;
        DAT_126A4[8] = 0;
        bVar3 = InventoryManager.FUN_4A87C(3, 0x20);
        sVar1 = 3;

        if (!bVar3)
            sVar1 = 1;

        param1.DAT_03 = sVar1;
    }

    //FUN_1880 (ST8)
    private void FUN_1880(CriInteract param1)
    {
        short sVar1;

        //FUN_1CD0

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (param1.DAT_08 == 4)
                param1.DAT_08 = 0;
            else
                param1.DAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            sVar1 = (short)(param1.DAT_08 - 1);

            if (param1.DAT_08 == 0)
                sVar1 = 4;

            param1.DAT_08 = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            sVar1 = (short)(param1.DAT_0A - 1);

            if (param1.DAT_0A == 0)
                sVar1 = 1;

            param1.DAT_0A = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (param1.DAT_0A == 1)
                param1.DAT_0A = 0;
            else
                param1.DAT_0A++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            DAT_126A4[DAT_126A4[5]] = (sbyte)(param1.DAT_08 + param1.DAT_0A * 5);

            if (DAT_126A4[5] == 4)
                param1.DAT_03 = 2;

            DAT_126A4[5]++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (DAT_126A4[5] == 0)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_03 = 5;
            }
            else
            {
                DAT_126A4[DAT_126A4[5]] = -1;
                DAT_126A4[5]--;
            }

            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_1A90 (ST8)
    private void FUN_1A90(CriInteract param1)
    {
        bool bVar1;

        if (DAT_126A4[6] < 31)
        {
            if (DAT_126A4[6] == 0)
            {
                InventoryManager.FUN_4A7E8(3, 0x22, false);
                InventoryManager.FUN_4A7E8(3, 0x23, false);
                InventoryManager.FUN_4A7E8(3, 0x24, false);

                if (param1.DAT_02 == 0)
                {
                    FUN_2380();
                    FUN_24A0();
                }
                else
                {
                    if (param1.DAT_02 == 1)
                    {
                        FUN_2550();
                        FUN_25FC();
                    }
                }
            }

            //FUN_1CD0
            DAT_126A4[6]++;
        }

        bVar1 = InventoryManager.FUN_4A87C(3, 0x21);

        if (bVar1)
        {
            param1.DAT_03 = 3;
            DAT_126A4[6] = 0;
        }
    }

    //FUN_1B84 (ST8)
    private void FUN_1B84(CriInteract param1)
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;

        if (param1.DAT_0C == 0)
            if (InventoryManager.FUN_4A87C(3, 0x24) || InventoryManager.FUN_4A87C(3, 0x23))
                InventoryManager.FUN_4A7E8(2, 10, true);

        //FUN_2080
        sVar2 = (short)(param1.DAT_0C + 1);
        param1.DAT_0C = sVar2;

        if (sVar2 == 150)
        {
            bVar3 = InventoryManager.FUN_4A87C(2, 10);
            sVar1 = 5;

            if (!bVar3)
                sVar1 = 4;

            param1.DAT_03 = sVar1;

            if (param1.DAT_0C == 150)
            {
                bVar3 = InventoryManager.FUN_4A87C(2, 10);

                if (!bVar3)
                    iVar4 = 148;
                else
                    iVar4 = 149;

                GameManager.instance.FUN_5C94C(null, iVar4);
            }
        }
    }

    //FUN_1C6C (ST8)
    private void FUN_1C6C(CriInteract param1)
    {
        //FUN_2080

        if (29 < DAT_126A4[6])
        {
            param1.DAT_03 = 5;
            DAT_126A4[6] = 0;
        }

        DAT_126A4[6]++;
    }

    //FUN_1CC4 (ST8)
    private void FUN_1CC4(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    //FUN_2380 (ST8)
    private void FUN_2380()
    {
        int pcVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        bool bVar5;
        byte[] local_18;
        
        bVar5 = false;
        local_18 = new byte[] { 5, 7, 0, 3, 6, 0, 0, 0, 5, 8, 1, 0, 4, 0, 0, 0 };
        pcVar1 = 0;
        uVar4 = 0;

        do
        {
            uVar2 = uVar4 + 1;

            if (DAT_126A4[pcVar1] != local_18[uVar4])
            {
                bVar5 = true;
                break;
            }

            pcVar1 = (int)uVar4 + 1;
            uVar4 = uVar2;
        } while (uVar2 < 5);

        if (bVar5)
        {
            pcVar1 = 0;
            uVar4 = 0;

            do
            {
                if (DAT_126A4[pcVar1] != local_18[(int)uVar4 + 8])
                {
                    InventoryManager.FUN_4A7E8(2, 10, true);
                    iVar3 = 149;
                    goto LAB_2488;
                }

                uVar2 = uVar4 + 1;
                pcVar1 = (int)uVar4 + 1;
                uVar4 = uVar2;
            } while (uVar2 < 5);

            iVar3 = 0x12;
        }
        else
            iVar3 = 9;

        InventoryManager.FUN_4A7E8(2, (uint)iVar3, true);
        iVar3 = 148;
        LAB_2488:
        GameManager.instance.FUN_5C94C(null, iVar3);
    }

    //FUN_24A0 (ST8)
    private void FUN_24A0()
    {
        byte bVar1;
        bool bVar2;
        uint uVar3;

        bVar1 = GameManager.instance.DAT_9ADF;

        if (bVar1 == 1)
        {
            bVar2 = InventoryManager.FUN_4A87C(2, 9);

            if (bVar2)
            {
                uVar3 = 0x22;
                goto LAB_2538;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                    uVar3 = 0x24;
                else
                    uVar3 = 0x23;

                goto LAB_2538;
            }

            if (bVar1 != 2)
            {
                uVar3 = 0x23;
                goto LAB_2538;
            }

            bVar2 = InventoryManager.FUN_4A87C(2, 0x12);

            if (bVar2)
            {
                uVar3 = 0x22;
                goto LAB_2538;
            }
        }

        uVar3 = 0x23;
        LAB_2538:
        InventoryManager.FUN_4A7E8(3, uVar3, true);
    }

    //FUN_2550 (ST8)
    private void FUN_2550()
    {
        int pcVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        byte[] local_10;

        local_10 = new byte[] { 3, 1, 4, 1, 5, 148, 0 };
        pcVar1 = 0;
        uVar2 = 0;

        do
        {
            if (DAT_126A4[pcVar1] != local_10[uVar2])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                iVar3 = 149;
                goto LAB_25E4;
            }

            uVar4 = uVar2 + 1;
            pcVar1 = (int)uVar4;
            uVar2 = uVar4;
        } while (uVar4 < 5);

        InventoryManager.FUN_4A7E8(2, 9, true);
        iVar3 = 148;
        LAB_25E4:
        GameManager.instance.FUN_5C94C(null, iVar3);
    }

    //FUN_25FC (ST8)
    private void FUN_25FC()
    {
        bool bVar1;
        uint uVar2;

        if (GameManager.instance.DAT_9ADF == 0)
            uVar2 = 0x24;
        else
        {
            if (GameManager.instance.DAT_9ADF == 3)
            {
                bVar1 = InventoryManager.FUN_4A87C(2, 9);

                if (bVar1)
                    uVar2 = 0x22;
                else
                    uVar2 = 0x23;
            }
            else
                uVar2 = 0x23;
        }

        InventoryManager.FUN_4A7E8(3, uVar2, true);
    }

    //FUN_2CB8 (ST8)
    private void FUN_2CB8(CriInteract param1)
    {
        CriBone oVar1;
        CriStatic oVar2;

        oVar1 = Utilities.FUN_601C8(SceneManager.instance.DAT_27C[param1.DAT_04].skeleton, 3) as CriBone;
        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            param1.PDAT_08 = oVar2;
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8017e000);
            oVar2.DAT_48 = 1;
            oVar2.screen = new Vector3Int(-50, 200, 80);
            oVar2.DAT_40 = oVar1;
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.cCollider = null;
            oVar2.flags |= 2;
        }

        param1.DAT_03++;
    }

    //FUN_2D84 (ST8)
    private void FUN_2D84(CriInteract param1)
    {
        bool bVar1;
        CriStatic oVar2;
        CriBone oVar3;
        Vector3Int local_18;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
        {
            oVar2 = (CriStatic)param1.PDAT_08;
            oVar3 = Utilities.FUN_601C8(SceneManager.instance.DAT_27C[param1.DAT_04].skeleton, 3) as CriBone;
            oVar2.DAT_40 = null;
            local_18 = Utilities.ApplyMatrixSV(ref oVar3.cTransform.rotation, ref oVar2.screen);
            oVar2.screen.x += local_18.x;
            oVar2.screen.y += local_18.y;
            oVar2.screen.z += local_18.z;
            oVar2.vr.x = oVar3.vr.x;
            oVar2.vr.y = oVar3.vr.y;
            oVar2.vr.z = oVar3.vr.z + 0x400;
            param1.VDAT_0C = new Vector3Int(0, -40, 80);
            param1.DAT_03++;
        }
    }

    //FUN_2E9C (ST8)
    private void FUN_2E9C(CriInteract param1)
    {
        CriStatic oVar2;

        oVar2 = (CriStatic)param1.PDAT_08;
        param1.VDAT_0C.x += 3;
        param1.VDAT_0C.y += 20;
        oVar2.screen.x += param1.VDAT_0C.x;
        oVar2.screen.y += param1.VDAT_0C.y;
        oVar2.screen.z += param1.VDAT_0C.z;
        oVar2.vr.x -= 1000;

        if (0 < oVar2.screen.y)
        {
            oVar2.screen.y = 0;
            param1.VDAT_0C.y = 400;
            oVar2.vr.x = 0;
            oVar2.vr.z = 0xc00;
            param1.DAT_03++;
        }
    }

    //FUN_2F38 (ST8)
    private void FUN_2F38(CriInteract param1)
    {
        param1.VDAT_0C.y -= 10;
        param1.PDAT_08.vr.y += param1.VDAT_0C.y;

        if (param1.VDAT_0C.y == 0)
            param1.DAT_03++;
    }

    //FUN_2FD0 (ST8)
    private void FUN_2FD0(CriInteract param1)
    {
        int puVar1;
        uint uVar2;

        //...
        uVar2 = 0;
        puVar1 = 0;

        do
        {
            DAT_128B0[puVar1] = 0x421;
            uVar2++;
            puVar1++;
        } while (uVar2 < 0x100);

        param1.DAT_03++;
    }

    //FUN_305C (ST8)
    private void FUN_305C(CriInteract param1)
    {
        bool bVar1;
        CriSkinned oVar2;
        CriInteract puVar3;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x38);
        oVar2 = SceneManager.instance.DAT_27C[10];

        if (bVar1)
        {
            //...
            oVar2.DAT_174 &= 0x7f;
            FUN_3324(param1);

            if (!InventoryManager.FUN_4A87C(0, 0xda) && 
               (InventoryManager.FUN_4A87C(11, 1) || InventoryManager.FUN_4A87C(11, 2) || 
                InventoryManager.FUN_4A87C(11, 3) || InventoryManager.FUN_4A87C(11, 4) || 
                InventoryManager.FUN_4A87C(11, 5) || InventoryManager.FUN_4A87C(11, 6) || 
                InventoryManager.FUN_4A87C(11, 7) || InventoryManager.FUN_4A87C(11, 8) || 
                InventoryManager.FUN_4A87C(11, 9) || InventoryManager.FUN_4A87C(11, 10)))
            {
                puVar3 = SceneManager.instance.DAT_8FFC[4];
                puVar3.DAT_01 = 28;
                puVar3.DAT_00 = 1;
                puVar3.DAT_02 = 1;
                puVar3.DAT_04 = 8;
                InventoryManager.FUN_4A7E8(3, 0x39, true);
            }

            param1.DAT_03++;
        }
    }

    //FUN_320C (ST8)
    private void FUN_320C(CriInteract param1)
    {
        CriBone oVar1;
        CriPlayer oVar2;
        bool bVar3;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 3);

        if (param1.BDAT_08 != oVar2.DAT_240 || oVar1.cMesh == DAT_12AB0)
            FUN_3324(param1);

        bVar3 = InventoryManager.FUN_4A87C(3, 0x38);

        if (!bVar3)
        {
            //...
            oVar2.DAT_174 |= 0x80;

            if (oVar2.DAT_240 >> 4 != 0)
            {
                oVar1 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 3);
                oVar1.cMesh = DAT_12AB0;
            }

            param1.DAT_03--;
        }
    }

    //FUN_3324 (ST8)
    private void FUN_3324(CriInteract param1)
    {
        CriPlayer oVar1;
        CriBone oVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, 3) as CriBone;

        if (oVar1.DAT_240 >> 4 == 0)
            DAT_12AB0 = oVar2.cMesh;
        else
        {
            param1.BDAT_08 = oVar1.DAT_240;
            uVar3 = oVar1.DAT_240 & 0xfU;

            if (GameManager.instance.DAT_A2D3 == 3)
                uVar3 += 4;

            DAT_12AB0 = oVar2.cMesh;
            oVar2.cMesh = (Tmd3ScriptableObject)Utilities.GetRamObject(DAT_121D8[(oVar1.DAT_240 >> 4) - 1][uVar3]);
        }
    }

    //FUN_3574 (ST8)
    private void FUN_3574(CriInteract param1)
    {
        if (param1.DAT_02 == 0)
        {
            param1.BDAT_08 = 15;
            param1.BDAT_09 = 0;
            param1.BDAT_0A = 0;
            param1.DAT_0B = 0;
        }
        else
        {
            param1.BDAT_08 = 165;
            param1.BDAT_09 = 90;
            param1.BDAT_0A = 0;
            param1.DAT_0B = 90;
        }

        param1.DAT_0D = 0xff;
        param1.DAT_0F = 0xff;
        param1.BDAT_0C = 0;
        param1.BDAT_0E = 0;
        param1.PTR_10 = null;
        param1.PDAT_14 = null;
        param1.UDAT_18 = 0x102;
        param1.DAT_04 = 0;
        param1.DAT_05 = 0;
        param1.DAT_06 = 0;
        param1.DAT_07 = 0;
        param1.DAT_03++;
    }

    //FUN_35F4 (ST8)
    private void FUN_35F4(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_15 + 1);
        param1.DAT_15 = (sbyte)bVar1;

        if (1 < bVar1)
        {
            param1.DAT_15 = 0;
            param1.DAT_14++;
        }

        if (7 < (byte)param1.DAT_14)
            param1.DAT_03++;
    }

    //FUN_3650 (ST8)
    private void FUN_3650(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;
        uint uVar4;

        bVar1 = param1.DAT_19;

        if (bVar1 == 1)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && param1.DAT_02 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_19 = 2;
                return;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_19 = 0;
                return;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_13--;
                return;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 4 < param1.DAT_13)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_03 = 4;
                uVar4 = (byte)param1.DAT_13;
                bVar3 = (byte)(param1.BDAT_08 << (6 - param1.DAT_13 & 31) & 0xc0);
                bVar1 = (byte)(param1.BDAT_0A << (6 - (int)uVar4 & 31) & 0xc0);
                param1.DAT_04 = (byte)(param1.BDAT_0A >> 2);
                param1.DAT_1A = (byte)(param1.BDAT_08 >> 2);

                if (uVar4 < 6)
                {
                    switch (uVar4)
                    {
                        case 0:
                            param1.DAT_0D = 0xfc;
                            param1.BDAT_0C = 0xfc;
                            param1.DAT_1A |= (byte)(param1.BDAT_08 << 6);
                            param1.DAT_04 |= (byte)(param1.BDAT_0A << 6);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            return;
                        case 1:
                            param1.DAT_0D = 0xf9;
                            param1.BDAT_0C = 0xf8;
                            param1.DAT_1A &= 0x3e;
                            param1.DAT_04 &= 0x3e;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 1);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 1);
                            return;
                        case 2:
                            param1.DAT_0D = 0xf3;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x3c;
                            param1.DAT_04 &= 0x3c;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 3);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 3);
                            return;
                        case 3:
                            param1.DAT_0D = 0xe7;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x38;
                            param1.DAT_04 &= 0x38;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 7);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 7);
                            return;
                        case 4:
                            param1.DAT_0D = 0xcf;
                            param1.BDAT_0C = 0xe0;
                            param1.DAT_1A &= 0x30;
                            param1.DAT_04 &= 0x30;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 15);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 15);
                            return;
                        case 5:
                            param1.DAT_0D = 0x9f;
                            param1.BDAT_0C = 0xc0;
                            param1.DAT_1A &= 0x20;
                            param1.DAT_04 &= 0x20;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 31);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 31);
                            return;
                    }
                }

                param1.DAT_1A |= bVar3;
                param1.DAT_06 = (byte)param1.DAT_13;
                param1.DAT_04 |= bVar1;
                return;
            }

            GameManager.instance.FUN_5C94C(null, 150);
            param1.DAT_13++;
            return;
        }

        if (1 < bVar1)
        {
            if (bVar1 == 2)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_19 = 1;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_13--;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 4 < param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 7;
                    uVar4 = (byte)param1.DAT_13;
                    param1.DAT_05 = (byte)(param1.DAT_0B >> 2);
                    param1.DAT_1B = (byte)(param1.BDAT_09 >> 2);
                    bVar3 = (byte)(param1.BDAT_09 << (6 - param1.DAT_13 & 31) & 0xc0);
                    bVar1 = (byte)(param1.DAT_0B << (6 - (int)uVar4 & 31) & 0xc0);

                    if (5 < uVar4)
                    {
                        param1.DAT_1B |= bVar3;
                        param1.DAT_05 |= bVar1;
                        return;
                    }

                    switch (uVar4)
                    {
                        case 0:
                            param1.DAT_0F = 0xfc;
                            param1.BDAT_0E = 0xfc;
                            param1.DAT_1B |= (byte)(param1.BDAT_09 << 6);
                            param1.DAT_05 |= (byte)(param1.DAT_0B << 6);
                            return;
                        case 1:
                            param1.DAT_0F = 0xf9;
                            param1.BDAT_0E = 0xf8;
                            param1.DAT_1B &= 0x3e;
                            param1.DAT_05 &= 0x3e;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 1);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 1);
                            return;
                        case 2:
                            param1.DAT_0F = 0xf3;
                            param1.BDAT_0E = 0xf0;
                            param1.DAT_1B &= 0x3c;
                            param1.DAT_05 &= 0x3c;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 3);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 3);
                            return;
                        case 3:
                            param1.DAT_0F = 0xe7;
                            param1.BDAT_0E = 0xf0;
                            param1.DAT_1B &= 0x38;
                            param1.DAT_05 &= 0x38;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 7);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 7);
                            return;
                        case 4:
                            param1.DAT_0F = 0xcf;
                            param1.BDAT_0E = 0xe0;
                            param1.DAT_1B &= 0x30;
                            param1.DAT_05 &= 0x30;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 15);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 15);
                            return;
                        case 5:
                            param1.DAT_0F = 0x9f;
                            param1.BDAT_0E = 0xc0;
                            param1.DAT_1B &= 0x20;
                            param1.DAT_05 &= 0x20;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 31);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 31);
                            return;
                    }
                }
            }
            else
            {
                if (bVar1 != 3)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_19 = 0;

                    if (param1.DAT_13 != 6)
                        return;

                    param1.DAT_13 = 5;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_13--;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 5 < param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x20a0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 10;
                    uVar4 = (byte)param1.DAT_13;
                    bVar3 = (byte)(param1.BDAT_08 << (6 - param1.DAT_13 & 31) & 0xc0);
                    bVar1 = (byte)(param1.BDAT_0A << (6 - (int)uVar4 & 31) & 0xc0);
                    param1.DAT_04 = (byte)(param1.BDAT_0A >> 2);
                    param1.DAT_1A = (byte)(param1.BDAT_08 >> 2);

                    if (uVar4 < 7)
                    {
                        switch (uVar4)
                        {
                            case 0:
                                param1.DAT_0D = 0xfc;
                                param1.BDAT_0C = 0xfc;
                                param1.DAT_1A |= (byte)(param1.BDAT_08 << 6);
                                param1.DAT_04 |= (byte)(param1.BDAT_0A << 6);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                return;
                            case 1:
                                param1.DAT_0D = 0xf9;
                                param1.DAT_0C = 0xf8;
                                param1.DAT_1A &= 0x3e;
                                param1.DAT_04 &= 0x3e;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 1);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 1);
                                return;
                            case 2:
                                param1.DAT_0D = 0xf3;
                                param1.DAT_0C = 0xf0;
                                param1.DAT_1A &= 0x3c;
                                param1.DAT_04 &= 0x3c;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 3);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 3);
                                return;
                            case 3:
                                param1.DAT_0D = 0xe7;
                                param1.DAT_0C = 0xf0;
                                param1.DAT_1A &= 0x38;
                                param1.DAT_04 &= 0x38;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 7);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 7);
                                return;
                            case 4:
                                param1.DAT_0D = 0xcf;
                                param1.DAT_0C = 0xe0;
                                param1.DAT_1A &= 0x30;
                                param1.DAT_04 &= 0x30;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 15);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 15);
                                return;
                        }
                    }

                    param1.DAT_1A |= bVar3;
                    param1.DAT_06 = (byte)param1.DAT_13;
                    param1.DAT_04 |= bVar1;
                    return;
                }
            }

            GameManager.instance.FUN_5C94C(null, 150);
            param1.DAT_13++;
            return;
        }

        if (bVar1 != 0)
            return;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 150);
            bVar1 = param1.DAT_18;

            if (bVar1 == 1)
            {
                param1.DAT_03 = 0;
                return;
            }

            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    InventoryManager.FUN_4A7E8(2, 11, true);
                    param1.DAT_03 = 16;
                    return;
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    param1.DAT_19 = 1;
                    return;
                }

                if (bVar1 == 3) goto LAB_376C;
            }
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_18++;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_18--;
            }

            if (param1.DAT_02 != 0)
            {
                if (param1.DAT_18 == 0xff)
                    param1.DAT_18 = 3;

                param1.DAT_18 &= 3;
                return;
            }

            sVar2 = (sbyte)param1.DAT_18;

            if (sVar2 == -1)
            {
                param1.DAT_18 = 2;
                sVar2 = (sbyte)param1.DAT_18;
            }

            if (sVar2 != 3)
                return;

            param1.DAT_18 = 0;
            return;
        }

        GameManager.instance.FUN_5C94C(null, 150);
        bVar1 = param1.DAT_18;

        if (bVar1 == 2)
        {
            param1.DAT_19 = 1;
            return;
        }

        if (bVar1 != 3)
            return;

        LAB_376C:
        param1.DAT_19 = bVar1;
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
        instance.PTR_FUN_12048[param1.DAT_3C](param1);
    }

    //FUN_824 (ST8)
    public static void FUN_824(CriParticle param1)
    {
        instance.PTR_FUN_12054[param1.DAT_3C](param1);
    }

    //FUN_908 (ST8)
    public static void FUN_908(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_12080[param1.DAT_3C](param1);
    }

    //FUN_A68 (ST8)
    public static void FUN_A68(CriInteract param1)
    {
        ((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_1C0 &= 0xfffffffe;
        instance.PTR_FUN_1208C[param1.DAT_03](param1);
    }

    //FUN_1724 (ST8)
    public static void FUN_1724(CriInteract param1)
    {
        instance.PTR_FUN_120AC[param1.DAT_03](param1);
    }

    //FUN_1760 (ST8)
    public static void FUN_1760(CriInteract param1)
    {
        instance.PTR_FUN_12140[param1.DAT_03](param1);
    }

    //FUN_2C7C (ST8)
    public static void FUN_2C7C(CriInteract param1)
    {
        instance.PTR_FUN_12164[param1.DAT_03](param1);
    }

    //FUN_2F84 (ST8)
    public static void FUN_2F84(CriInteract param1)
    {
        instance.PTR_FUN_121E4[param1.DAT_03](param1);
        InventoryManager.FUN_4A7E8(3, 0x38, false);
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
