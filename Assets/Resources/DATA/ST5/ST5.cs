using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct UNK_1226C
{
    public uint DAT_00; //0x00
    public ushort DAT_04; //0x04
}

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
    public FUN_B58BC[] DAT_12034 = new FUN_B58BC[22] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758,
                                                       FUN_45B08, null, FUN_46A1C, null, null, null, FUN_45D38,
                                                       FUN_45E70, null, null, null, FUN_2D0, FUN_4FC, FUN_D23C,
                                                       FUN_770, FUN_910, FUN_9F4 };
    public FUN_B58C0[] DAT_1208C = new FUN_B58C0[9]  { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, null, null,
                                                       null, null };
    public FUN_C2570[] DAT_120B0 = new FUN_C2570[8]  { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null,
                                                       FUN_A8A8, FUN_7F808 };
    public FUN_C1CF8[] DAT_120D0 = new FUN_C1CF8[29] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_20A98,
                                                       FUN_21758, FUN_21ECC, FUN_22178, null, FUN_184C,
                                                       null, FUN_222AC, FUN_22464, FUN_2268C, null, null, null,
                                                       FUN_B54, FUN_2D68, FUN_1810, FUN_34FC, FUN_3070,
                                                       null, FUN_88D0, FUN_62CC, FUN_ACB8, FUN_E4DC,
                                                       FUN_F824, FUN_10204 };
    private delegate void FUN_121CC(CriParticle p); //0x121CC (ST5)
    private delegate void FUN_1225C(CriParticle p); //0x1225C (ST5)
    private delegate void FUN_12284(CriParticle p); //0x12284 (ST5)
    private delegate void FUN_12290(CriParticle p); //0x12290 (ST5)
    private delegate void FUN_122BC(CriParticle p); //0x122BC (ST5)
    private delegate void FUN_122C8(CriInteract i); //0x122C8 (ST5)
    private delegate void FUN_122E8(CriInteract i); //0x122E8 (ST5)
    private delegate void FUN_1237C(CriInteract i); //0x1237C (ST5)
    private delegate void FUN_123A0(CriInteract i); //0x123A0 (ST5)
    private delegate void FUN_12420(CriInteract i); //0x12420 (ST5)
    private delegate void FUN_12690(CriStatic s); //0x12690 (ST5)
    private delegate void FUN_126C8(CriInteract i); //0x126C8 (ST5)
    private delegate void FUN_12744(CriParticle p); //0x12744 (ST5)
    private delegate void FUN_12754(CriInteract i); //0x12754 (ST5)
    private delegate void FUN_12798(CriInteract i); //0x12798 (ST5)
    private delegate void FUN_12850(CriInteract i); //0x12850 (ST5)
    private uint[] DAT_12144 = new uint[] //0x12144 (ST5)
    {
        0x80138424, 0x80138434, 0x80138474, 0x80138504, 0x80138514,
        0x8013851c, 0x80138524, 0x8013852c, 0x80138534, 0x8013853c,
        0x80138544, 0x8013854c, 0x8013854c, 0x80138554, 0x801385c4,
        0x8013865c, 0x8013866c, 0x80133fcc, 0x80133fdc, 0x8013401c,
        0x801340ac, 0x801340bc, 0x801340c4, 0x801340cc, 0x801340d4,
        0x801340dc, 0x801340e4, 0x801340ec, 0x801340f4, 0x801340f4,
        0x801340fc, 0x8013416c, 0x80134204, 0x80134214
    };
    private FUN_121CC[] PTR_FUN_121CC; //0x121CC (ST5)
    private uint[] DAT_121D8 = new uint[] //0x121D8 (ST5)
    {
        0x80144e70, 0x80145b88, 0x80145bd8, 0x80146178, 0x80146718,
        0x80146750, 0x80146828, 0x80146908, 0x80146af8, 0x80146ba8,
        0x80146bb0, 0x80146bb8, 0x80146bc0, 0x80146bc8, 0x80146bd0,
        0x80146bd8, 0x80146be0, 0x80146be8, 0x80146bf0, 0x80146bf8,
        0x80146c00, 0x80146c10, 0x80146c18, 0x80146c20, 0x80146c28,
        0x80146c30, 0x80146c38, 0x80146c40, 0x80146c48, 0x80146c50,
        0x80146c58, 0x80146c60, 0x80146c68
    };
    private FUN_1225C[] PTR_FUN_1225C; //0x1225C (ST5)
    private UNK_1226C[] PTR_DAT_1226C = new UNK_1226C[] //0x1226C (ST5)
    {
        new UNK_1226C
        {
            DAT_00=0x801278B4,
            DAT_04=0x7EFB
        },
        new UNK_1226C
        {
            DAT_00=0x80127984,
            DAT_04=0x7EFB
        },
        new UNK_1226C
        {
            DAT_00=0x8012799C,
            DAT_04=0x7EFB
        }
    };
    private FUN_12284[] PTR_FUN_12284; //0x12284 (ST5)
    private FUN_12290[] PTR_FUN_12290; //0x12290 (ST5)
    private uint[] DAT_1229C = new uint[] //0x1229C (ST5)
    {
        0x80139200, 0x80139240, 0x80139270, 0x80139298,
        0x801392b8, 0x801392e0, 0x80139308, 0x80139358
    };
    private FUN_122BC[] PTR_FUN_122BC; //0x122BC (ST5)
    private FUN_122C8[] PTR_FUN_122C8; //0x122C8 (ST5)
    private FUN_122E8[] PTR_FUN_122E8; //0x122E8 (ST5)
    private FUN_1237C[] PTR_FUN_1237C; //0x1237C (ST5)
    private FUN_123A0[] PTR_FUN_123A0; //0x123A0 (ST5)
    private FUN_12420[] PTR_FUN_12420; //0x12420 (ST5)
    private FUN_12690[] PTR_FUN_12690; //0x12690 (ST5)
    private FUN_126C8[] PTR_FUN_126C8; //0x126C8 (ST5)
    private byte[] DAT_12720 = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 0 }; //0x12720 (ST5)
    private byte[] DAT_1272C = new byte[] { 1, 5, 3, 7, 9, 2, 6, 10, 8, 3, 5, 9, 1, 4, 7, 8, 1, 3, 1, 5, 2, 3, 9, 2 }; //0x1272C (ST5)
    private FUN_12744[] PTR_FUN_12744; //0x12744 (ST5)
    private FUN_12754[] PTR_FUN_12754; //0x12754 (ST5)
    private FUN_12798[] PTR_FUN_12798; //0x12798 (ST5)
    private byte[] DAT_12800 = new byte[] { 0xb4, 0x54, 0x94, 0x74, 0xb4, 0x94, 0xd4, 0x74, 0xb4, 0x2c, 0xfc, 0x2c, 0xfc, 0x74, 0xb4, 0xbc, 0x6c, 0xbc, 0x6c, 0x74, 0xb4, 0x74 };
    private byte[] DAT_12818 = new byte[] { 0x93, 0x92, 0x92, 0x93, 0x94, 0x92, 0x92, 0x92, 0x94, 0x92 };
    private byte[] DAT_12824 = new byte[] { 4, 2, 1, 3, 0, 2, 9, 3, 0, 7, 1, 3, 0, 2, 1, 6, 128, 0, 9, 5, 128, 6, 4, 128, 5, 7, 3, 128, 2, 128, 8, 6, 9, 128, 128, 7, 4, 8, 128, 1, 0, 2, 1, 3 };
    private FUN_12850[] PTR_FUN_12850; //0x12850 (ST5)
    private byte[] DAT_12868 = new byte[] { 3, 6, 7, 2, 0, 4 }; //0x12868 (ST5)
    private short[] DAT_12AEC = new short[0x100]; //0x12AEC (ST5)
    private Tmd3ScriptableObject[] DAT_12CEC = new Tmd3ScriptableObject[16]; //0x12CEC (ST5)
    private CriStatic DAT_12E04; //0x12E04 (ST5)
    private CriStatic DAT_12E08; //0x12E08 (ST5)
    private CriStatic DAT_12E0C; //0x12E0C (ST5)
    private CriStatic DAT_12E10; //0x12E10 (ST5)
    private CriStatic DAT_12E14; //0x12E14 (ST5)
    private CriStatic DAT_12E18; //0x12E18 (ST5)
    private byte[] DAT_12E3C = new byte[5]; //0x12E3C (ST5)
    private sbyte DAT_12E48; //0x12E48 (ST5)
    private byte[] DAT_12F78 = new byte[20]; //0x12F78 (ST5)
    private uint[] DAT_12F8C = new uint[3]; //0x12F8C (ST5)
    private uint[] DAT_12F9C = new uint[3]; //0x12F9C (ST5)
    private sbyte[] DAT_12FAC = new sbyte[11]; //0x12FAC (ST5)
    private sbyte[] DAT_12FBC = new sbyte[11]; //0x12FBC (ST5)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_121CC = new FUN_121CC[3]
            {
                FUN_30C,
                FUN_450,
                FUN_60068
            };
            PTR_FUN_1225C = new FUN_1225C[4]
            {
                FUN_538,
                FUN_6B8,
                FUN_71C,
                FUN_60068
            };
            PTR_FUN_12284 = new FUN_12284[3]
            {
                FUN_7AC,
                FUN_86C,
                FUN_60068
            };
            PTR_FUN_12290 = new FUN_12290[3]
            {
                FUN_94C,
                FUN_9C0,
                FUN_60068
            };
            PTR_FUN_122BC = new FUN_122BC[3]
            {
                FUN_A60,
                FUN_AEC,
                FUN_60068
            };
            PTR_FUN_122C8 = new FUN_122C8[7]
            {
                FUN_BA8,
                FUN_E44,
                FUN_FD4,
                FUN_D8C,
                FUN_5FF98,
                FUN_E44,
                FUN_10E8
            };
            PTR_FUN_122E8 = new FUN_122E8[5]
            {
                FUN_1164,
                FUN_11F4,
                FUN_13EC,
                FUN_14A4,
                FUN_5FF98
            };
            PTR_FUN_1237C = new FUN_1237C[7]
            {
                FUN_1888,
                FUN_196C,
                FUN_1B7C,
                FUN_1C70,
                FUN_1D58,
                FUN_1DB0,
                FUN_5FF98
            };
            PTR_FUN_123A0 = new FUN_123A0[5]
            {
                FUN_2DA4,
                FUN_2E70,
                FUN_2F88,
                FUN_3024,
                FUN_5FF98
            };
            PTR_FUN_12420 = new FUN_12420[4]
            {
                FUN_30BC,
                FUN_3148,
                FUN_32F8,
                FUN_5FF98
            };
            PTR_FUN_12690 = new FUN_12690[2]
            {
                FUN_A8E4,
                FUN_A928
            };
            PTR_FUN_126C8 = new FUN_126C8[7]
            {
                FUN_ACFC, 
                FUN_AFD4, 
                FUN_B0B8, 
                FUN_B110, 
                FUN_B150, 
                FUN_B318, 
                FUN_5FF98
            };
            PTR_FUN_12744 = new FUN_12744[4]
            {
                FUN_D288,
                FUN_D2FC,
                FUN_D510,
                FUN_60068
            };
            PTR_FUN_12754 = new FUN_12754[6]
            {
                FUN_DB88,
                FUN_DBE8,
                FUN_DCEC,
                FUN_DDFC,
                FUN_DE88,
                FUN_5FF98
            };
            PTR_FUN_12798 = new FUN_12798[6]
            {
                FUN_E518,
                FUN_E5A0,
                FUN_E618,
                FUN_E6C4,
                FUN_E770,
                FUN_5FF98
            };
            PTR_FUN_12850 = new FUN_12850[6]
            {
                FUN_1032C,
                FUN_103A4,
                FUN_106C0,
                FUN_10A20,
                FUN_10B74,
                FUN_5FF98
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

    //FUN_134 (ST5)
    public override void Initialize()
    {
        bool bVar1;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();
        PTR_FUN_B58BC = DAT_12034;
        PTR_FUN_B58C0 = DAT_1208C;
        PTR_FUN_C2570 = DAT_120B0;
        PTR_FUN_C1CF8 = DAT_120D0;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_11FA4[uVar3];
        GameManager.instance.DAT_B0 = DAT_11A90;
        GameManager.instance.DAT_46 = 5;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xe1);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_11DC4.TRIGGERS.Length; i++)
            {
                puVar4 = LevelManager.instance.DAT_9EEC[i];
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
                puVar4 = LevelManager.instance.DAT_9EEC[i];
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

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 5);
        bVar1 = InventoryManager.FUN_4A87C(0, 0xf);

        if (!bVar1)
        {
            LevelManager.instance.DAT_9EEC[3].DAT_03 |= 2;
            LevelManager.instance.DAT_9EEC[4].DAT_03 |= 2;
        }
    }

    //FUN_30C (ST5)
    private void FUN_30C(CriParticle param1)
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
        else if (bVar1 < 17 && 12 < bVar1)
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
            param1.vr.z = param1.DAT_69 << 4;
        }

        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (GameManager.instance.DAT_9AA0 == 10)
            uVar2 = param1.DAT_2F + 17U;
        else
            uVar2 = param1.DAT_2F;

        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_12144[uVar2 & 0xff]));

        if (iVar3 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_450 (ST5)
    private void FUN_450(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen += param1.DAT_40;
        iVar2 = param1.FUN_606D8();

        if (param1.DAT_2F < 2)
        {
            sVar1 = (sbyte)(param1.DAT_69 - 1);
            param1.DAT_69 = (byte)sVar1;

            if (sVar1 == 0)
                param1.DAT_3C = 2;
        }
        else if (iVar2 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_538 (ST5)
    private void FUN_538(CriParticle param1)
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
                    goto LAB_5DC;
                }
                else
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
        LAB_5DC:
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
            param1.vr.y = param1.DAT_6A << 4;
        }

        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_121D8[param1.DAT_2F]));

        if (iVar3 == 1)
            param1.DAT_3C = 3;
        else
            param1.DAT_3C = 1;

        if (param1.DAT_2F - 2 < 3)
            param1.DAT_3C = 2;
    }

    //FUN_6B8 (ST5)
    private void FUN_6B8(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 3;

        if (param1.DAT_69 != 0 && InventoryManager.FUN_4A87C(3, param1.DAT_69))
            param1.DAT_3C = 3;
    }

    //FUN_71C (ST5)
    private void FUN_71C(CriParticle param1)
    {
        param1.FUN_606D8();

        if (param1.DAT_69 != 0 && InventoryManager.FUN_4A87C(3, param1.DAT_69))
            param1.DAT_3C = 3;
    }

    //FUN_7AC (ST5)
    private void FUN_7AC(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_1226C[param1.DAT_2F & 15].DAT_00));
        param1.DAT_56 = 0x25;
        param1.DAT_54 = PTR_DAT_1226C[param1.DAT_2F & 15].DAT_04;

        if ((param1.DAT_2F & 15) == 0)
            param1.DAT_50.a |= 2;

        param1.DAT_40.y = 10;
        param1.DAT_68 = 9;
        param1.flags |= 2;
        param1.DAT_62 = param1.DAT_69;
        param1.DAT_60 = param1.DAT_69;
        param1.DAT_3C++;
    }

    //FUN_86C (ST5)
    private void FUN_86C(CriParticle param1)
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

    //FUN_94C (ST5)
    private void FUN_94C(CriParticle param1)
    {
        int iVar1;

        param1.DAT_56 = 0xfa;
        param1.DAT_54 = 0x7f70;
        param1.DAT_62 = param1.DAT_69;
        param1.flags |= 2;
        param1.DAT_60 = param1.DAT_69;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8012fd04));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_9C0 (ST5)
    private void FUN_9C0(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_A60 (ST5)
    private void FUN_A60(CriParticle param1)
    {
        int iVar1;

        param1.DAT_56 = 0x25;
        param1.DAT_54 = 0x7efd;
        param1.flags |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.DAT_50.a |= 2;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_1229C[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_AEC (ST5)
    private void FUN_AEC(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_BA8 (ST5)
    private void FUN_BA8(CriInteract param1)
    {
        byte bVar1;
        ushort uVar2;
        ushort uVar3;
        CriPlayer oVar4;
        byte bVar5;
        uint uVar6;
        short sVar7;
        uint uVar8;

        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        bVar1 = oVar4.DAT_1D7;
        param1.BDAT_08 = bVar1;

        if ((oVar4.DAT_1C0 & 8) != 0)
        {
            bVar5 = (byte)(bVar1 - 1);
            param1.BDAT_08 = bVar5;

            if ((bVar5 << 0x18) < 0)
                param1.BDAT_08 = 0;
        }

        if (oVar4.DAT_3D == 5)
        {
            if (param1.BDAT_08 == 0)
                uVar6 = (uint)(oVar4.frameNum * 0x16);
            else
                uVar6 = (uint)(oVar4.frameNum << 5);
        }
        else
        {
            if (oVar4.DAT_3D != 1)
            {
                param1.DAT_16 = 0;
                goto LAB_C98;
            }

            if (param1.DAT_08 == 0)
            {
                if (param1.BDAT_08 == 0)
                    uVar6 = (uint)(oVar4.frameNum * 0x16);
                else
                    uVar6 = (uint)(oVar4.frameNum << 5);
            }

            uVar6 = (uint)(oVar4.frameNum << 5);
        }

        uVar8 = oVar4.frameCount + 1U & 0xff;

        if (uVar8 == 0)
            return; // trap(0x1c00)

        param1.DAT_16 = (ushort)(uVar6 / uVar8);
        LAB_C98:
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
        InventoryManager.FUN_4A7E8(2, 18, true);
        param1.DAT_0A = param1.DAT_07;
        param1.DAT_07 = 0x80;
        param1.DAT_03 = (sbyte)(param1.DAT_02 + 1);

        if (param1.DAT_02 == 0)
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * -0x1a9);
        else
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * 0x1a9);

        param1.DAT_0C = sVar7;
    }

    //FUN_D8C (ST5)
    private void FUN_D8C(CriInteract param1)
    {
        byte bVar1;
        CriPlayer oVar4;
        short sVar2;
        ushort uVar3;

        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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
        InventoryManager.FUN_4A7E8(2, 18, false);
        oVar4.FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(oVar4.DAT_220), 1, 10, oVar4.DAT_220);
        param1.DAT_03++;
    }

    //FUN_E44 (ST5)
    private void FUN_E44(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        auStack56 = new Matrix3x3();
        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018da38), 1, (byte)param1.DAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -19;
        }
        else 
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e8b8), 1, (byte)param1.DAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -13;
        }

        param1.DAT_0A = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_FD4 (ST5)
    private void FUN_FD4(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        auStack56 = new Matrix3x3();
        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e178), 1, (byte)param1.DAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018f340), 1, (byte)param1.DAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 13;
        }

        param1.DAT_0A = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_10E8 (ST5)
    private void FUN_10E8(CriInteract param1)
    {
        CriPlayer oVar1;
        int iVar2;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar1.screen.x += param1.VDAT_0E.x;
        oVar1.screen.y += param1.VDAT_0E.y;
        oVar1.screen.z += param1.VDAT_0E.z;
        iVar2 = (int)(param1.DAT_0A - param1.VDAT_0E.y);
        param1.DAT_0A = (short)iVar2;

        if (iVar2 * 0x10000 < 0)
            param1.DAT_03 = 3;
    }

    //FUN_1164 (ST5)
    private void FUN_1164(CriInteract param1)
    {
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        //...
        param1.BDAT_0A = 0;
        param1.DAT_09 = false;
        param1.DAT_03 = 1;
    }

    //FUN_11F4 (ST5)
    private void FUN_11F4(CriInteract param1)
    {
        byte bVar1;

        //FUN_E94E4

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
            bVar1 = (byte)(param1.BDAT_08 - 1);

            if (param1.BDAT_08 == 0)
                bVar1 = 4;

            param1.BDAT_08 = bVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            bVar1 = (byte)(param1.BDAT_09 - 1);

            if (param1.BDAT_09 == 0)
                bVar1 = 1;

            param1.BDAT_09 = bVar1;
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
            //...
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
                //...
            }
        }
    }

    //FUN_13EC (ST5)
    private void FUN_13EC(CriInteract param1)
    {
        bool bVar1;
        int iVar5;

        bVar1 = false;
        //...

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

    //FUN_14A4 (ST5)
    private void FUN_14A4(CriInteract param1)
    {
        bool bVar1;

        //FUN_E94A4
        bVar1 = InventoryManager.FUN_4A87C(3, 48);

        if (bVar1)
            param1.DAT_03 = 4;
    }

    //FUN_1888 (ST5)
    private void FUN_1888(CriInteract param1)
    {
        byte bVar1;
        bool bVar3;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 18, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = 0;
        //...
        bVar3 = InventoryManager.FUN_4A87C(3, 0x20);
        bVar1 = 3;

        if (!bVar3)
            bVar1 = 1;

        param1.DAT_03 = (sbyte)bVar1;
    }

    //FUN_196C (ST5)
    private void FUN_196C(CriInteract param1)
    {
        short sVar1;

        //FUN_E9DBC

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
            //...
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

        //...
    }

    //FUN_1B7C (ST5)
    private void FUN_1B7C(CriInteract param1)
    {
        //...
        return;
    }

    //FUN_1C70 (ST5)
    private void FUN_1C70(CriInteract param1)
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;

        if (param1.DAT_0C == 0)
        {
            bVar3 = InventoryManager.FUN_4A87C(3, 0x24);

            if (bVar3)
            {
                bVar3 = InventoryManager.FUN_4A87C(3, 0x23);

                if (bVar3)
                    InventoryManager.FUN_4A7E8(2, 10, true);
            }
        }

        //FUN_EA16C
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

    //FUN_1D58 (ST5)
    private void FUN_1D58(CriInteract param1)
    {
        //...
        return;
    }

    //FUN_1DB0 (ST5)
    private void FUN_1DB0(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    //FUN_2DA4 (ST5)
    private void FUN_2DA4(CriInteract param1)
    {
        CriObject oVar1;
        CriStatic oVar2;

        oVar1 = Utilities.FUN_601C8(SceneManager.instance.skinnedObjects[param1.DAT_04].skeleton, 3);
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

    //FUN_2E70 (ST5)
    private void FUN_2E70(CriInteract param1)
    {
        bool bVar1;
        CriSkinned oVar2;
        CriObject oVar3;
        Vector3Int local_18;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
        {
            oVar2 = (CriSkinned)param1.PDAT_08;
            oVar3 = Utilities.FUN_601C8(SceneManager.instance.skinnedObjects[param1.DAT_04].skeleton, 3);
            oVar2.DAT_40.x = 0;
            oVar2.DAT_40.y = 0;
            local_18 = Utilities.ApplyMatrixSV(ref oVar3.cTransform.rotation, ref oVar2.screen);
            oVar2.screen.x += local_18.x;
            oVar2.screen.y += local_18.y;
            oVar2.screen.z += local_18.z;
            oVar2.vr.x = oVar3.vr.x;
            oVar2.vr.y = oVar3.vr.y;
            oVar2.vr.z += 0x400;
            param1.VDAT_0C = new Vector3Int(0, -40, 80);
            param1.DAT_03++;
        }
    }

    //FUN_2F88 (ST5)
    private void FUN_2F88(CriInteract param1)
    {
        CriSkinned oVar2;

        oVar2 = (CriSkinned)param1.PDAT_08;
        param1.DAT_0C += 3;
        param1.DAT_0E += 20;
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

    //FUN_3024 (ST5)
    private void FUN_3024(CriInteract param1)
    {
        param1.VDAT_0C.y -= 10;
        param1.PDAT_08.vr.y += param1.VDAT_0C.y;

        if (param1.VDAT_0C.y == 0)
            param1.DAT_03++;
    }

    //FUN_30BC (ST5)
    private void FUN_30BC(CriInteract param1)
    {
        short[] puVar1;
        uint uVar2;

        //LoadImage
        uVar2 = 0;
        puVar1 = DAT_12AEC;

        do
        {
            puVar1[uVar2] = 0x421;
            uVar2++;
        } while (uVar2 < 0x100);

        param1.DAT_03++;
    }

    //FUN_3148 (ST5)
    private void FUN_3148(CriInteract param1)
    {
        bool bVar1;
        CriPlayer oVar2;
        CriInteract puVar3;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x38);
        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

        if (bVar1)
        {
            //LoadImage?
            oVar2.DAT_174 &= 0x7f;
            FUN_3410(param1);

            if (!InventoryManager.FUN_4A87C(0, 0xda) && InventoryManager.FUN_4A87C(11, 1) && 
                InventoryManager.FUN_4A87C(11, 2) && InventoryManager.FUN_4A87C(11, 3) && 
                InventoryManager.FUN_4A87C(11, 4) && InventoryManager.FUN_4A87C(11, 5) && 
                InventoryManager.FUN_4A87C(11, 6) && InventoryManager.FUN_4A87C(11, 7) && 
                InventoryManager.FUN_4A87C(11, 8) && InventoryManager.FUN_4A87C(11, 9) && 
                InventoryManager.FUN_4A87C(11, 10))
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

    //FUN_32F8 (ST5)
    private void FUN_32F8(CriInteract param1)
    {
        bool bVar1;
        CriBone oVar1;
        CriPlayer oVar2;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar1 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 3);

        if (param1.BDAT_08 != oVar2.DAT_240 || oVar1.cMesh == DAT_12CEC[0])
            FUN_3410(param1);

        bVar1 = InventoryManager.FUN_4A87C(3, 0x38);

        if (!bVar1)
        {
            //LoadImage?
            oVar2.DAT_174 |= 0x80;

            if (oVar2.DAT_240 >> 4 != 0)
            {
                oVar1 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 3);
                oVar1.cMesh = DAT_12CEC[0];
            }

            param1.DAT_03--;
        }
    }

    //FUN_3410 (ST5)
    private void FUN_3410(CriInteract param1)
    {
        CriPlayer oVar1;
        CriBone oVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar2 = (CriBone)Utilities.FUN_601C8(oVar1.skeleton, 3);

        if (oVar1.DAT_240 >> 4 == 0)
            DAT_12CEC[0] = oVar2.cMesh;
        else
        {
            param1.BDAT_08 = oVar1.DAT_240;
            uVar3 = (uint)(oVar1.DAT_240 & 0xf);

            if (GameManager.instance.DAT_A2D3 == 3)
                uVar3 += 4;

            DAT_12CEC[0] = oVar2.cMesh;
            oVar2.cMesh = DAT_12CEC[uVar3 * 4 + (oVar1.DAT_240 >> 4 - 1)];
        }
    }

    //FUN_A8E4 (ST5)
    private void FUN_A8E4(CriStatic param1)
    {
        param1.tags++;
        param1.DAT_4C = Vector3Int.zero;
        //FUN_A948
    }

    //FUN_A928 (ST5)
    private void FUN_A928(CriStatic param1)
    {
        FUN_AB08(param1);
    }

    //FUN_AB08 (ST5)
    private bool FUN_AB08(CriStatic param1)
    {
        byte bVar1;
        sbyte sVar2;
        uint uVar3;
        byte[] aVar4;
        byte bVar5;
        bool bVar6;

        bVar1 = param1.DAT_6E;
        bVar6 = false;

        if ((bVar1 & 0x20) == 0)
        {
            if (param1.DAT_6F != 0) goto LAB_AC9C;

            sVar2 = (sbyte)param1.DAT_6D;
            bVar5 = (byte)(sVar2 + 1);
            param1.DAT_6D = bVar5;

            if ((bVar1 & 4) != 0)
            {
                bVar6 = param1.DAT_6C <= bVar5;

                if (param1.DAT_6C < bVar5)
                {
                    if ((bVar1 & 1) == 0)
                        param1.DAT_6D = (byte)sVar2;
                    else
                        param1.DAT_6D = 0;
                }

                if ((uint)param1.DAT_68[param1.DAT_6D * 4] >> 1 == 0)
                    param1.DAT_6D++;
            }

            bVar5 = param1.DAT_6D;

            if (param1.DAT_6C <= bVar5)
                bVar6 = true;

            if (param1.DAT_6C < bVar5)
            {
                if ((bVar1 & 1) == 0)
                    param1.DAT_6D = (byte)(bVar5 - 1);
                else
                    param1.DAT_6D = 0;
            }

            if ((bVar1 & 2) == 0)
            {
                uVar3 = param1.DAT_6D;
                aVar4 = param1.DAT_68;
            }
            else
            {
                uVar3 = (uint)(param1.DAT_6C - param1.DAT_6D);
                aVar4 = param1.DAT_68;
            }

            param1.DAT_5C = aVar4[uVar3 * 4 + 1];
            bVar5 = param1.DAT_68[uVar3 * 4];
            param1.DAT_6F = bVar5;

            if ((bVar1 & 4) != 0 && 1 < bVar5)
                param1.DAT_6F = (byte)((uint)bVar5 >> 1);

            if ((bVar1 & 8) == 0) goto LAB_AC9C;

            sVar2 = (sbyte)(param1.DAT_6F << 1);
        }
        else
            sVar2 = (sbyte)(param1.DAT_6F + 1);

        param1.DAT_6F = (byte)sVar2;
        LAB_AC9C:
        FUN_AA1C(param1);
        return bVar6;
    }

    //FUN_AA1C (ST5)
    private void FUN_AA1C(CriStatic param1)
    {
        param1.DAT_54 = param1.DAT_4C;
        param1.DAT_4C = param1.PTR_60[param1.DAT_5C].DAT_00;
        param1.screen.x -= param1.DAT_54.x - param1.DAT_4C.x;
        param1.screen.y -= param1.DAT_54.y - param1.DAT_4C.y;
        param1.screen.z -= param1.DAT_54.z - param1.DAT_4C.z;
        Utilities.FUN_60C94(param1.PTR_60[param1.DAT_5C].COMP, GameManager.instance.todUncomp, 1);
        param1.vr = GameManager.instance.todUncomp[0];
        param1.DAT_6F--;
    }

    //FUN_ACFC (ST5)
    private void FUN_ACFC(CriInteract param1)
    {
        byte[] puVar1;
        CriStatic oVar2;
        uint uVar3;

        param1.BDAT_09 = 0;
        param1.DAT_03 = 1;
        GameManager.instance.FUN_5C94C(null, 149);
        InventoryManager.FUN_4A7E8(3, 0x28, false);
        InventoryManager.FUN_4A7E8(3, 0x29, false);
        InventoryManager.FUN_4A7E8(3, 0x2a, false);
        InventoryManager.FUN_4A7E8(3, 0x2b, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, false);
        puVar1 = DAT_12E3C;
        uVar3 = 0;

        do
        {
            puVar1[uVar3] = 0;
            uVar3++;
        } while (uVar3 < 5);

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80117b88);
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_48 = 1;
            oVar2.cCollider = null;
            oVar2.flags |= 2;
            DAT_12E04 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80117b88);
            oVar2.DAT_48 = 2;
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_4A = 0x3ff;
            oVar2.cCollider = null;
            oVar2.flags |= 2;
            DAT_12E10 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80113a60);
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_48 = 1;
            oVar2.cCollider = null;
            DAT_12E08 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80113a60);
            oVar2.DAT_48 = 2;
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_4A = 0x3ff;
            oVar2.cCollider = null;
            DAT_12E14 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80119678);
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_48 = 1;
            oVar2.cCollider = null;
            DAT_12E0C = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80119678);
            oVar2.DAT_48 = 2;
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_4A = 0x3ff;
            oVar2.cCollider = null;
            DAT_12E18 = oVar2;
        }

        DAT_12E04.DAT_40 = DAT_12E10;
        DAT_12E08.DAT_40 = DAT_12E14;
        DAT_12E0C.DAT_40 = DAT_12E18;
    }

    //FUN_AFD4 (ST5)
    private void FUN_AFD4(CriInteract param1)
    {
        byte bVar1;

        if (109 < param1.BDAT_09)
        {
            if (param1.BDAT_09 - 30 < 61)
            {
                //FUN_D0C8
            }

            bVar1 = param1.BDAT_09;

            if (bVar1 == 31)
            {
                FUN_D1B8(0x10020, 0x2900fa, 165, 125);
                bVar1 = param1.BDAT_09;
            }

            if (bVar1 == 90)
                InventoryManager.FUN_4A7E8(3, 0x29, true);
        }
        else
        {
            param1.DAT_03 = 2;
            FUN_D1B8(0x3840007, 0x28003c, 225, 178);
        }

        param1.BDAT_09++;
    }

    //FUN_B0B8 (ST5)
    private void FUN_B0B8(CriInteract param1)
    {
        //...
    }

    //FUN_B110 (ST5)
    private void FUN_B110(CriInteract param1)
    {
        param1.DAT_03 = 5;
        InventoryManager.FUN_4A7E8(2, 9, true);
        InventoryManager.FUN_4A7E8(3, 0x28, true);
    }

    //FUN_B150 (ST5)
    private void FUN_B150(CriInteract param1)
    {
        byte bVar1;
        int iVar2;
        byte bVar3;

        DAT_12E14.screen.x += param1.SDAT_14;
        DAT_12E14.screen.y += param1.SDAT_16;
        DAT_12E18.screen.x += param1.SDAT_18;
        DAT_12E18.screen.y += param1.SDAT_1A;
        bVar1 = param1.BDAT_09;

        if (bVar1 < 0x82)
        {
            if ((bVar1 + 0xba) < 0x3d)
            {
                if (bVar1 == 0x50)
                    GameManager.instance.FUN_5C94C(null, 153);
            }
            else
            {
                //...
            }
        }
        else
        {
            param1.DAT_03 = 5;
            InventoryManager.FUN_4A7E8(2, 0xb, true);
        }

        bVar3 = param1.BDAT_09;

        if (bVar3 == 0x47)
        {
            FUN_D1B8(0x10005, 0x2c00fa, 160, 120);
            InventoryManager.FUN_4A7E8(3, 0x28, true);
            bVar3 = param1.BDAT_09;
        }

        if (bVar3 == 0x82)
            InventoryManager.FUN_4A7E8(3, 0x2c, true);

        param1.BDAT_09++;
        iVar2 = (int)Utilities.SquareRoot0(DAT_12E18.screen.x * DAT_12E18.screen.x + DAT_12E18.screen.y * DAT_12E18.screen.y);

        if (iVar2 < 200)
        {
            param1.SDAT_18 = (short)-param1.SDAT_18;
            param1.SDAT_1A = (short)-param1.SDAT_1A;
        }
    }

    private void FUN_B318(CriInteract param1)
    {
        InventoryManager.FUN_4A7E8(3, 0x28, false);
        InventoryManager.FUN_4A7E8(3, 0x29, false);
        InventoryManager.FUN_4A7E8(3, 0x2a, false);
        InventoryManager.FUN_4A7E8(3, 0x2b, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, false);
        DAT_12E04.FUN_5FF00();
        DAT_12E10.FUN_5FF00();
        DAT_12E08.FUN_5FF00();
        DAT_12E14.FUN_5FF00();
        DAT_12E0C.FUN_5FF00();
        DAT_12E18.FUN_5FF00();
        param1.DAT_03 = 6;
    }

    //FUN_D1B8 (ST5)
    private void FUN_D1B8(uint param1, uint param2, short param3, short param4)
    {
        CriParticle oVar1;
        
        oVar1 = SceneManager.instance.FUN_5FFA0();

        if (oVar1 != null)
        {
            oVar1.tags = 17;
            oVar1.DAT_69 = (byte)(param2 >> 0x10);
            oVar1.DAT_2F = (byte)param1;
            oVar1.DAT_68 = (byte)param2;
            oVar1.screen.x = param3;
            oVar1.screen.y = param4;
            oVar1.screen.z = (short)(param1 >> 0x10);
            oVar1.DAT_65 |= 0x80;
        }
    }

    //FUN_D288 (ST5)
    private void FUN_D288(CriParticle param1)
    {
        uint uVar2;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        uVar2 = 0;

        do
        {
            param1.DAT_6C[uVar2] = 0;
            uVar2++;
        } while (uVar2 < 8);

        param1.DAT_68 = 0;
        param1.DAT_69 = 0;
        param1.DAT_6A = 0;
        param1.DAT_3C++;
    }

    //FUN_D2FC (ST5)
    private void FUN_D2FC(CriParticle param1)
    {
        sbyte sVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                if ((sbyte)param1.DAT_6A < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_6A++;
                }

                if (param1.DAT_6A != 3) goto LAB_D420;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_D414;

                    GameManager.instance.FUN_5C94C(null, 144);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_D420;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_D420;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 144);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 144);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_D420;
        }

        LAB_D414:
        param1.DAT_69 = 1;

        LAB_D420:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 145);
            param1.DAT_6C[param1.DAT_68] = DAT_12720[param1.DAT_6A * 3 + param1.DAT_69];
            sVar1 = (sbyte)(param1.DAT_68 + 1);
            param1.DAT_68 = (byte)sVar1;

            if (3 < sVar1)
                param1.DAT_3C++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);

            if (param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 0xb, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.DAT_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_D510 (ST5)
    private void FUN_D510(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.DAT_6C[uVar1] != DAT_1272C[param1.DAT_2F * 4 + uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 148);
                return;
            }

            bVar2++;
            uVar1 = bVar2;
        } while (bVar2 < 4);

        GameManager.instance.FUN_5C94C(null, 147);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_DB88 (ST5)
    private void FUN_DB88(CriInteract param1)
    {
        byte[] puVar1;
        uint uVar2;

        param1.DAT_15 = -1;
        param1.BDAT_16 = 0;
        param1.DAT_14 = 0;
        //...
        param1.DAT_08 = 320;
        param1.DAT_0A = 240;
        param1.DAT_18 = 80;
        puVar1 = DAT_12F78;
        uVar2 = 0;

        do
        {
            puVar1[uVar2] = 0;
            uVar2++;
        } while (uVar2 < 20);

        param1.DAT_03 = 1;
    }

    //FUN_DBE8 (ST5)
    private void FUN_DBE8(CriInteract param1)
    {
        bool bVar1;

        if ((byte)param1.DAT_15 < 0x90)
            DAT_12E48 = 6;

        if (0xf0 < (byte)param1.DAT_15)
            DAT_12E48 = -6;

        param1.DAT_15 += DAT_12E48;
        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar1)
        {
            //FUN_E3C4

            if ((param1.DAT_0C & 0x10) != 0)
                GameManager.instance.FUN_5C94C(null, 153);

            param1.UDAT_0C++;
        }
        else
        {
            param1.DAT_03 = 2;
            param1.UDAT_0C = 0;
            GameManager.instance.FUN_5C860(153);
            GameManager.instance.FUN_5C94C(null, 151);
        }
    }

    //FUN_DCEC (ST5)
    private void FUN_DCEC(CriInteract param1)
    {
        uint uVar1;

        //FUN_DE94

        if (param1.BDAT_16 == 0)
        {
            param1.DAT_10 = DAT_12F78[param1.DAT_14];
            DAT_12F78[param1.DAT_14] = (byte)param1.UDAT_0C;
            //...
            uVar1 = param1.UDAT_0C + 4;
        }
        else
        {
            uVar1 = param1.UDAT_0C + 1;

            if (9 < param1.UDAT_0C)
            {
                if (0xef < param1.DAT_18)
                {
                    param1.DAT_18 = 0xf0;
                    param1.UDAT_0C = 0;
                    param1.DAT_03 = 3;
                    GameManager.instance.FUN_5C860(151);
                    return;
                }

                param1.DAT_18 += 4;
                return;
            }
        }

        param1.UDAT_0C = uVar1;
    }

    //FUN_DDFC (ST5)
    private void FUN_DDFC(CriInteract param1)
    {
        //FUN_DE94

        if (param1.UDAT_0C < 20)
            param1.UDAT_0C++;
        else
        {
            if (param1.DAT_18 < 11)
                param1.DAT_03 = 4;
            else
            {
                InventoryManager.FUN_4A7E8(3, 0x20, true);
                param1.DAT_18 -= 10;
            }
        }
    }

    //FUN_DE88 (ST5)
    private void FUN_DE88(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    //FUN_E518 (ST5)
    private void FUN_E518(CriInteract param1)
    {
        uint[] puVar1;
        uint[] puVar2;
        uint uVar3;

        uVar3 = 0;
        puVar2 = DAT_12F8C;
        puVar1 = DAT_12F9C;
        param1.DAT_1B = 0;
        param1.DAT_19 = 0;
        param1.DAT_18 = 0;
        param1.DAT_17 = 0;
        param1.DAT_16 = 0;
        param1.DAT_1A = 0x20;
        GameManager.instance.DAT_38 = 0x73;

        do
        {
            puVar1[uVar3] = 0;
            puVar2[uVar3] = 0;
            uVar3++;
        } while (uVar3 < 3);

        param1.DAT_03 = 9;
        GameManager.instance.FUN_2984C(0x8011);
    }

    //FUN_E5A0 (ST5)
    private void FUN_E5A0(CriInteract param1)
    {
        bool bVar1;

        if (param1.BDAT_16 < 30)
            param1.BDAT_16++;
        else
        {
            //...
            bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

            if (bVar1)
                param1.DAT_03 = 4;
        }

        //FUN_FC94
    }

    //FUN_E618 (ST5)
    private void FUN_E618(CriInteract param1)
    {
        if (param1.BDAT_16 < 0x32)
        {
            param1.BDAT_16++;
            //FUN_F5A0
        }
        else
        {
            //FUN_EDE0

            if (param1.DAT_17 == -1)
            {
                param1.BDAT_16 = 0;
                param1.DAT_17 = 0;
                param1.DAT_03 = 6;
            }

            param1.DAT_17++;
        }

        if (param1.BDAT_16 == 0x23)
            GameManager.instance.FUN_2984C(0x8012);

        //...
    }

    //FUN_E6C4 (ST5)
    private void FUN_E6C4(CriInteract param1)
    {
        if (param1.BDAT_16 < 0x32)
        {
            param1.BDAT_16++;
            //FUN_F5A0
        }
        else
        {
            //FUN_EDE0

            if (param1.DAT_17 == -1)
            {
                param1.BDAT_16 = 0;
                param1.DAT_17 = 0;
                param1.DAT_03 = 7;
            }

            param1.DAT_17++;
        }

        if (param1.BDAT_16 == 0x23)
            GameManager.instance.FUN_2984C(0x8012);

        //...
    }

    //FUN_E770 (ST5)
    private void FUN_E770(CriInteract param1)
    {
        param1.DAT_03 = 5;
        GameManager.instance.DAT_38 = 0;
    }

    //FUN_1032C (ST5)
    private void FUN_1032C(CriInteract param1)
    {
        int iVar3;

        iVar3 = 0;
        param1.BDAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.BDAT_0A = 0;
        param1.DAT_0B = 0;
        param1.BDAT_0C = 0;
        param1.DAT_0D = 0;
        param1.BDAT_0E = 0;
        param1.DAT_0F = 0;
        param1.DAT_14 = 0;
        param1.DAT_15 = 0;
        param1.BDAT_16 = 0;
        param1.DAT_17 = 0;
        param1.DAT_18 = 0;
        param1.DAT_19 = 0;
        param1.DAT_1A = 0;
        param1.DAT_1B = 0;

        do
        {
            DAT_12FAC[iVar3] = -1;
            DAT_12FBC[iVar3] = -1;
            iVar3++;
        } while (iVar3 < 11);

        param1.BDAT_0C = 10;
        param1.DAT_0D = 10;
        param1.SDAT_10 = 0xb0;
        param1.SDAT_12 = 0x70;
        param1.BDAT_16 = 0x20;
        param1.DAT_03++;
    }

    //FUN_103A4 (ST5)
    private void FUN_103A4(CriInteract param1)
    {
        sbyte sVar1;
        byte bVar2;
        uint uVar3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0)
                    {
                        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                            return;

                        GameManager.instance.FUN_5C94C(null, 145);
                        bVar2 = (byte)(param1.DAT_0F - 1);

                        if (param1.DAT_0F == 0)
                        {
                            InventoryManager.FUN_4A7E8(2, 0xb, true);
                            param1.FUN_5FF98();
                            return;
                        }

                        param1.DAT_0F = bVar2;
                        DAT_12FAC[bVar2] = -1;

                        if (param1.DAT_0F == 0)
                            param1.BDAT_0C = 10;
                        else
                            param1.BDAT_0C = (byte)DAT_12FAC[param1.DAT_0F - 1];

                        if (param1.DAT_0F < 2)
                            param1.DAT_0D = 10;
                        else
                            param1.DAT_0D = (byte)DAT_12FAC[param1.DAT_0F - 2];

                        DAT_12FBC[param1.BDAT_0C] = -1;
                        param1.DAT_18 = 1;
                        sVar1 = (sbyte)(param1.DAT_03 + 1);
                    }
                    else
                    {
                        uVar3 = DAT_12824[param1.BDAT_0C * 4 + 3];

                        if (uVar3 == 0x80)
                            return;

                        if (DAT_12FBC[uVar3] != -1)
                            return;

                        param1.DAT_0D = param1.BDAT_0C;
                        param1.DAT_0F++;
                        param1.BDAT_0C = DAT_12824[param1.BDAT_0C * 4 + 3];
                        DAT_12FBC[param1.DAT_0D] = 0;
                        sVar1 = (sbyte)(param1.DAT_03 + 1);
                    }
                }
                else
                {
                    uVar3 = DAT_12824[param1.BDAT_0C * 4 + 2];

                    if (uVar3 == 0x80)
                        return;

                    if (DAT_12FBC[uVar3] != -1)
                        return;

                    param1.DAT_0D = param1.BDAT_0C;
                    param1.DAT_0F++;
                    param1.BDAT_0C = DAT_12824[param1.BDAT_0C * 4 + 2];
                    DAT_12FBC[param1.DAT_0D] = 0;
                    sVar1 = (sbyte)(param1.DAT_03 + 1);
                }
            }
            else
            {
                uVar3 = DAT_12824[param1.BDAT_0C * 4 + 1];

                if (uVar3 == 0x80)
                    return;

                if (DAT_12FBC[uVar3] != -1)
                    return;

                param1.DAT_0D = param1.BDAT_0C;
                param1.DAT_0F++;
                param1.BDAT_0C = DAT_12824[param1.BDAT_0C * 4 + 1];
                DAT_12FBC[param1.DAT_0D] = 0;
                sVar1 = (sbyte)(param1.DAT_03 + 1);
            }
        }
        else
        {
            uVar3 = DAT_12824[param1.BDAT_0C * 4];

            if (uVar3 == 0x80)
                return;

            if (DAT_12FBC[uVar3] != -1)
                return;

            param1.DAT_0D = param1.BDAT_0C;
            param1.DAT_0F++;
            param1.BDAT_0C = DAT_12824[param1.BDAT_0C * 4];
            DAT_12FBC[param1.DAT_0D] = 0;
            sVar1 = (sbyte)(param1.DAT_03 + 1);
        }

        param1.DAT_03 = sVar1;
    }

    //FUN_106C0 (ST5)
    private void FUN_106C0(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int iVar3;
        byte bVar4;
        short sVar5;
        int iVar6;
        int pbVar7;
        int iVar8;

        param1.BDAT_16 = 0x80;

        if (param1.BDAT_08 != 0)
        {
            iVar8 = 2;

            if (param1.BDAT_08 != 1)
                return;

            bVar1 = (byte)(param1.DAT_15 & 3);
            param1.DAT_14 += 2;

            if (bVar1 == 1)
            {
                iVar3 = param1.SDAT_10 - param1.DAT_14;
                param1.SDAT_10 = (short)iVar3;
                pbVar7 = (sbyte)param1.BDAT_0C * 2;

                if (iVar3 * 0x10000 >> 0x10 < DAT_12800[pbVar7] - 4)
                {
                    iVar8 = 1;
                    param1.SDAT_10 = (short)(DAT_12800[pbVar7] - 4);
                }
            }
            else if (bVar1 < 2)
            {
                if ((param1.DAT_15 & 3) == 0)
                    iVar8 = 1;
            }
            else if (bVar1 == 2)
            {
                sVar5 = (short)(param1.SDAT_10 + (byte)param1.DAT_14);
                param1.SDAT_10 = sVar5;
                pbVar7 = (sbyte)param1.BDAT_0C * 2;

                if (DAT_12800[pbVar7] - 4 < sVar5)
                {
                    iVar8 = 1;
                    param1.SDAT_10 = (short)(DAT_12800[pbVar7] - 4);
                }
            }

            bVar1 = (byte)(param1.DAT_15 >> 4);
            bVar4 = (byte)(bVar1 & 3);

            if (bVar4 == 1)
            {
                iVar6 = (ushort)param1.SDAT_12 - (byte)param1.DAT_14;
                param1.SDAT_12 = (short)iVar6;
                iVar3 = (sbyte)param1.BDAT_0C * 2;

                if (DAT_12800[iVar3 + 1] - 4 <= iVar6 * 0x10000 >> 0x10) goto LAB_10980;
            }
            else
            {
                if (bVar4 < 2)
                {
                    if ((bVar1 & 3) == 0)
                        iVar8--;

                    goto LAB_10980;
                }

                if (bVar4 != 2) goto LAB_10980;

                sVar5 = (short)(param1.SDAT_12 + (byte)param1.DAT_14);
                param1.SDAT_12 = sVar5;
                iVar3 = (sbyte)param1.BDAT_0C * 2;

                if (sVar5 <= DAT_12800[iVar3 + 1] - 4) goto LAB_10980;
            }

            iVar8--;
            param1.SDAT_12 = (short)(DAT_12800[iVar3 + 1] - 4);

            LAB_10980:
            if (iVar8 != 0)
                return;

            DAT_12FAC[param1.DAT_0F - 1] = (sbyte)param1.BDAT_0C;

            if ((sbyte)param1.BDAT_0C < 10 && param1.DAT_18 == 0)
            {
                GameManager.instance.FUN_5C94C(null, DAT_12818[param1.BDAT_0C]);
                param1.DAT_19 = 1;
            }

            param1.DAT_03 = 1;
            param1.DAT_18 = 0;
            param1.BDAT_08 = 0;
            param1.BDAT_09 = 0;
            param1.BDAT_0A = 0;
            param1.DAT_0B = 0;

            if (param1.DAT_0F != 6)
                return;

            sVar2 = 4;

            if (!FUN_10CC8())
                sVar2 = 3;

            param1.DAT_03 = sVar2;
            return;
        }

        param1.DAT_14 = 2;
        param1.DAT_15 = 0;

        if (DAT_12800[param1.BDAT_0C * 2] - 4 < param1.SDAT_10)
        {
            bVar1 = (byte)(param1.DAT_15 | 1);
            param1.DAT_15 = (sbyte)bVar1;
        }
        else if (param1.SDAT_10 < DAT_12800[param1.BDAT_0C * 2] - 4)
        {
            bVar1 = (byte)(param1.DAT_15 | 2);
            param1.DAT_15 = (sbyte)bVar1;
        }

        if (DAT_12800[param1.BDAT_0C * 2 + 1] - 4 < param1.SDAT_12)
            bVar1 = (byte)(param1.DAT_15 | 0x10);
        else if (DAT_12800[param1.BDAT_0C * 2 + 1] - 4 <= param1.SDAT_12) goto LAB_107A0;
        else bVar1 = (byte)(param1.DAT_15 | 0x20);

        param1.DAT_15 = (sbyte)bVar1;
        LAB_107A0:
        param1.BDAT_08++;
    }

    //FUN_10A20 (ST5)
    private void FUN_10A20(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)param1.DAT_0B;
        param1.DAT_0B = (sbyte)(bVar1 + 1);

        if (19 < bVar1)
        {
            if (param1.BDAT_08 == 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.BDAT_08++;
            }
            else
            {
                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (60 < bVar1)
                {
                    InventoryManager.FUN_4A7E8(2, 0xa, true);
                    param1.FUN_5FF98();
                }
            }

            //...
        }
    }

    //FUN_10B74 (ST5)
    private void FUN_10B74(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)param1.DAT_0B;
        param1.DAT_0B = (sbyte)(bVar1 + 1);

        if (19 < bVar1)
        {
            if (param1.BDAT_08 == 0)
            {
                GameManager.instance.FUN_5C94C(null, 149);
                param1.BDAT_08++;
            }
            else
            {
                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (60 < bVar1)
                {
                    InventoryManager.FUN_4A7E8(2, 9, true);
                    param1.FUN_5FF98();
                }
            }

            //...
        }
    }

    //FUN_10CC8 (ST5)
    private bool FUN_10CC8()
    {
        int pcVar1;
        int iVar2;
        int iVar3;

        pcVar1 = 0;
        iVar2 = 0;

        do
        {
            iVar3 = iVar2 + 1;

            if (DAT_12FAC[pcVar1] != DAT_12868[iVar2])
                return false;

            pcVar1++;
            iVar2 = iVar3;
        } while (iVar3 < 6);

        return true;
    }

    //FUN_2D0 (ST5)
    public static void FUN_2D0(CriParticle param1)
    {
        instance.PTR_FUN_121CC[param1.DAT_3C](param1);
    }

    //FUN_4FC (ST5)
    public static void FUN_4FC(CriParticle param1)
    {
        instance.PTR_FUN_1225C[param1.DAT_3C](param1);
    }

    //FUN_770 (ST5)
    public static void FUN_770(CriParticle param1)
    {
        instance.PTR_FUN_12284[param1.DAT_3C](param1);
    }

    //FUN_910 (ST5)
    public static void FUN_910(CriParticle param1)
    {
        instance.PTR_FUN_12290[param1.DAT_3C](param1);
    }

    //FUN_9F4 (ST5)
    public static void FUN_9F4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_122BC[param1.DAT_3C](param1);
    }

    //FUN_B54 (ST5)
    public static void FUN_B54(CriInteract param1)
    {
        ((CriPlayer)SceneManager.instance.skinnedObjects[10]).DAT_1C0 &= 0xfffffffe;
        instance.PTR_FUN_122C8[param1.DAT_03](param1);
    }

    //FUN_1810 (ST5)
    public static void FUN_1810(CriInteract param1)
    {
        instance.PTR_FUN_122E8[param1.DAT_03](param1);
    }

    //FUN_184C (ST5)
    public static void FUN_184C(CriInteract param1)
    {
        instance.PTR_FUN_1237C[param1.DAT_03](param1);
    }

    //FUN_2D68 (ST5)
    public static void FUN_2D68(CriInteract param1)
    {
        instance.PTR_FUN_123A0[param1.DAT_03](param1);
    }

    //FUN_3070 (ST5)
    public static void FUN_3070(CriInteract param1)
    {
        instance.PTR_FUN_12420[param1.DAT_03](param1);
        InventoryManager.FUN_4A7E8(3, 0x38, false);
    }

    //FUN_34FC (ST5)
    public static void FUN_34FC(CriInteract param1)
    {
        return;
    }

    //FUN_62CC (ST5)
    public static void FUN_62CC(CriInteract param1)
    {
        return;
    }

    //FUN_88D0 (ST5)
    public static void FUN_88D0(CriInteract param1)
    {
        return;
    }

    //FUN_A8A8 (ST5)
    public static void FUN_A8A8(CriStatic param1)
    {
        instance.PTR_FUN_12690[param1.tags](param1);
    }

    //FUN_ACB8 (ST5)
    public static void FUN_ACB8(CriInteract param1)
    {
        instance.PTR_FUN_126C8[param1.DAT_03](param1);
        //FUN_CCB4
    }

    //FUN_D23C (ST5)
    public static void FUN_D23C(CriParticle param1)
    {
        instance.PTR_FUN_12744[param1.DAT_3C](param1);
        //FUN_D5C0
    }

    //FUN_E4DC (ST5)
    public static void FUN_E4DC(CriInteract param1)
    {
        instance.PTR_FUN_12754[param1.DAT_03](param1);
    }

    //FUN_F824 (ST5)
    public static void FUN_F824(CriInteract param1)
    {
        instance.PTR_FUN_12798[param1.DAT_03](param1);
        //FUN_F868
    }

    //FUN_10204 (ST5)
    public static void FUN_10204(CriInteract param1)
    {
        byte bVar1;

        if (param1.DAT_03 < 2)
        {
            if (param1.DAT_17 == 0)
            {
                bVar1 = (byte)(param1.DAT_16 + 6);
                param1.BDAT_16 = bVar1;

                if (bVar1 < 129) goto LAB_102B4;

                param1.DAT_16 = 0x80;
            }
            else
            {
                bVar1 = (byte)(param1.DAT_16 - 6);
                param1.DAT_16 = bVar1;

                if (31 < bVar1) goto LAB_102B4;

                param1.DAT_16 = 0x20;
            }

            param1.DAT_17 ^= 1;
            param1.BDAT_0E ^= 1;
        }
        else
        {
            param1.BDAT_16 = 0x80;
            param1.BDAT_0E = 1;
        }
    
        LAB_102B4:
        instance.PTR_FUN_12850[param1.DAT_03](param1);
        //...
    }
}
