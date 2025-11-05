using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct UNK_7888
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public int DAT_0C;
}

struct UNK_7918
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public Vector3Int DAT_0C;
    public short DAT_12;
}

struct UNK_816C
{
    public uint DAT_00;
    public ushort DAT_04;
}

struct UNK_81B0
{
    public uint DAT_00;
    public ushort DAT_04;
    public ushort DAT_06;
}

public class ST2 : LevelManager
{
    public static new ST2 instance;

    public FUN_B58BC[] DAT_7470 = new FUN_B58BC[19] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08,
                                                      null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, FUN_464F8,
                                                      FUN_55F4, FUN_6184, FUN_53E4, FUN_46670, FUN_5838 };
    public FUN_B58C0[] DAT_74BC = new FUN_B58C0[5] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_2438, FUN_4C28 };
    public FUN_C2570[] DAT_74D4 = new FUN_C2570[11] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, FUN_6E40,
                                                      FUN_7F808, null, FUN_6B14, FUN_6C50 };
    public FUN_C1CF8[] DAT_7500 = new FUN_C1CF8[13] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC, FUN_22178,
                                                      null, null, null, FUN_222AC, FUN_22464, FUN_2268C };
    public byte[][] DAT_73E0 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 11, 27, 15, 13, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 6, 0, 0, 22, 26, 21, 21, 23, 31, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_72F0; //0x72F0 (ST2)
    public uint[] DAT_7250 = new uint[100] { 0x0, 0x8000001d, 0x0, 0x8000000c, 0x0, 0xb, 0x80000016, 0x0, 0x5, 0x8000000e, 0x0, 0x8000001e, 0x0, 0x8000001a, 0x0, 0x8, 0x80000016, 0x0, 0x8, 0x80000020, 0x0, 0xb, 0x80000012, 0x0, 0x8, 0x80000019, 0x0, 0x9, 0x80000023, 0x0, 0x5, 0x8000001b, 0x0, 0x80000016, 0x0, 0x6, 0x8000000e, 0x0, 0x7, 0x8000001d, 0x90300, 0x102f, 0x732, 0x0, 0x0, 0x7ffe0000, 0xa0401, 0xfcde, 0xc6a, 0x0, 0x0, 0x7ffe0000, 0x2, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x3, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x4, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x5, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x6, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x7, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x8, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x9, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000 };
    public CapsuleCollider[] DAT_7558 = new CapsuleCollider[] { }; //0x7558 (ST2)
    private UNK_7888[] PTR_DAT_7888; //0x7888 (ST2)
    private UNK_7918[] PTR_DAT_7918; //0x7918 (ST2)
    private short[] DAT_7AE4 = new short[] { 4, -4, 32, -32, 32, -32, 16, -16, 8, -8, 2, -2, 1, -1 }; //0x7AE4 (ST2)
    private short[] DAT_7B00 = new short[] { 4, -4, 16, -16, 16, -16, 8, -8, 4, -4, 1, -1, 1, -1 }; //0x7B00 (ST2)
    private byte[] DAT_7B1C = new byte[2] { 48, 49 }; //0x7B1C (ST2)
    public CapsuleCollider[] DAT_7CD0 = new CapsuleCollider[] { }; //0x7CD0 (ST2)
    private CapsuleCollider[] DAT_7CF4 = new CapsuleCollider[] { }; //0x7CF4 (ST2)
    private int[] DAT_7D00 = new int[] { 3, 9, 20, 19, 4, 10, 5, 11, 6, 12, 7, 13, 8, 14 }; //0x7D00 (ST2)
    public short[] DAT_7D44 = new short[] { }; //0x7D44 (ST2)
    private byte[] DAT_7D54 = new byte[] { 1, 1, 1, 1, 3, 3, 3, 3, 5, 5, 0, 0, 0xff, 1, 1, 0 }; //0x7D54 (ST2)
    private Vector2Int[][] DAT_7DC0; //0x7DC0 (ST2)
    private short[] DAT_7DF0 = new short[] { }; //0x7DF0 (ST2)
    private sbyte[] DAT_7E14 = new sbyte[] { 4, 4, 1, 1, 1, 4, 4, 1, 1, 4, 1, 4, 1, 1, 1, 4 }; //0x7E14 (ST2)
    private byte[] DAT_7E24 = new byte[] { 1, 5, 1, 7, 4, 0x82, 0, 0 }; //0x7E24 (ST2)
    private delegate void FUN_7BF8(CriPlayer p); //0x7BF8 (ST2)
    private delegate void FUN_7C00(CriPlayer p); //0x7C00 (ST2)
    private delegate void FUN_7C14(CriPlayer p); //0x7C14 (ST2)
    private delegate void FUN_7C30(CriPlayer p); //0x7C30 (ST2)
    private delegate void FUN_7C4C(CriPlayer p); //0x7C4C (ST2)
    private delegate void FUN_7DA0(CriPlayer p); //0x7DA0 (ST2)
    private delegate void FUN_7DA8(CriPlayer p); //0x7DA8 (ST2)
    private delegate void FUN_7DB4(CriPlayer p); //0x7DB4 (ST2)
    private delegate void FUN_7E08(CriPlayer p); //0x7E08 (ST2)
    private delegate void FUN_7E2C(CriPlayer p); //0x7E2C (ST2)
    private delegate void FUN_7E34(CriPlayer p); //0x7E34 (ST2)
    private delegate void FUN_7E3C(CriPlayer p); //0x7E3C (ST2)
    private delegate void FUN_7E60(CriPlayer p); //0x7E60 (ST2)
    private delegate void FUN_8114(CriPlayer p); //0x8114 (ST2)
    private delegate void FUN_8134(CriPlayer p); //0x8134 (ST2)
    private delegate void FUN_8150(CriPlayer p); //0x8150 (ST2)
    private delegate void FUN_8158(CriPlayer p1, CriPlayer p2); //0x8158 (ST2)
    private delegate void FUN_8164(CriPlayer p); //0x8164 (ST2)
    private delegate void FUN_81A4(CriParticle p); //0x81A4 (ST2)
    private delegate void FUN_8210(CriParticle p); //0x8210 (ST2)
    private delegate void FUN_8240(CriParticle p); //0x8240 (ST2)
    private delegate void FUN_8264(CriParticle p); //0x8264 (ST2)
    private delegate void FUN_8274(CriStatic s); //0x8274 (ST2)
    private delegate void FUN_8280(CriStatic s); //0x8280 (ST2)
    private delegate void FUN_8294(CriStatic s); //0x8294 (ST2)
    private FUN_7BF8[] PTR_FUN_7BF8; //0x7BF8 (ST2)
    private FUN_7C00[] PTR_FUN_7C00; //0x7C00 (ST2)
    private FUN_7C14[] PTR_FUN_7C14; //0x7C14 (ST2)
    private FUN_7C30[] PTR_FUN_7C30; //0x7C30 (ST2)
    private FUN_7C4C[] PTR_FUN_7C4C; //0x7C4C (ST2)
    private FUN_7DA0[] PTR_FUN_7DA0; //0x7DA0 (ST2)
    private FUN_7DA8[] PTR_FUN_7DA8; //0x7DA8 (ST2)
    private FUN_7DB4[] PTR_FUN_7DB4; //0x7DB4 (ST2)
    private FUN_7E08[] PTR_FUN_7E08; //0x7E08 (ST2)
    private FUN_7E2C[] PTR_FUN_7E2C; //0x7E2C (ST2)
    private FUN_7E34[] PTR_FUN_7E34; //0x7E34 (ST2)
    private FUN_7E3C[] PTR_FUN_7E3C; //0x7E3C (ST2)
    private FUN_7E60[] PTR_FUN_7E60; //0x7E60 (ST2)
    private FUN_8114[] PTR_FUN_8114; //0x8114 (ST2)
    private FUN_8134[] PTR_FUN_8134; //0x8134 (ST2)
    private FUN_8150[] PTR_FUN_8150; //0x8150 (ST2)
    private FUN_8158[] PTR_FUN_8158; //0x8158 (ST2)
    private FUN_8164[] PTR_FUN_8164; //0x8164 (ST2)
    private FUN_81A4[] PTR_FUN_81A4; //0x81A4 (ST2)
    private int[] DAT_8148 = new int[2] { 24, 25 }; //0x8148 (ST2)
    private UNK_816C[] PTR_DAT_816C = new UNK_816C[] //0x816C (ST2)
    {
        new UNK_816C
        {
            DAT_00=0x8013233C,
            DAT_04=0x7ebc
        },
        new UNK_816C
        {
            DAT_00=0x80132404,
            DAT_04=0x7ebd
        },
        new UNK_816C
        {
            DAT_00=0x80132504,
            DAT_04=0x7ebb
        },
        new UNK_816C
        {
            DAT_00=0x8013250c,
            DAT_04=0x7ebb
        },
        new UNK_816C
        {
            DAT_00=0x80132514,
            DAT_04=0x7ebb
        },
        new UNK_816C
        {
            DAT_00=0x8013251c,
            DAT_04=0x7ebb
        },
        new UNK_816C
        {
            DAT_00=0x8013252c,
            DAT_04=0x7ebb
        }
    };
    private UNK_81B0[] PTR_DAT_81B0 = new UNK_81B0[] //0x81B0 (ST2)
    {
        new UNK_81B0
        {
            DAT_00=0x8012cf54,
            DAT_04=0x7ef9,
            DAT_06=0
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf5c,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf64,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf6c,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf7c,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf84,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf94,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cf9c,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cfa4,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cfac,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cfb4,
            DAT_04=0x7ef9,
            DAT_06=30
        },
        new UNK_81B0
        {
            DAT_00=0x8012cfbc,
            DAT_04=0x7ef9,
            DAT_06=30
        }
    };
    private FUN_8210[] PTR_FUN_8210; //0x8210 (ST2)
    private byte[] DAT_821C = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 0 }; //0x821C (ST2)
    private byte[] DAT_8228 = new byte[] { 1, 5, 3, 7, 9, 2, 6, 10, 8, 3, 5, 9, 1, 4, 7, 8, 1, 3, 1, 5, 2, 3, 9, 2 }; //0x8228 (ST2)
    private FUN_8240[] PTR_FUN_8240; //0x8240 (ST2)
    private byte[] DAT_8250 = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 0, 8, 1, 6, 1, 4, 8 }; //0x8250 (ST2)
    private byte[] DAT_825C = new byte[] { 8, 1, 6, 1, 4, 8 }; //0x825C (ST2)
    private FUN_8264[] PTR_FUN_8264; //0x8264 (ST2)
    private FUN_8274[] PTR_FUN_8274; //0x8274 (ST2)
    private FUN_8280[] PTR_FUN_8280; //0x8280 (ST2)
    private FUN_8294[] PTR_FUN_8294; //0x8294 (ST2)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_7BF8 = new FUN_7BF8[4]
            {
                FUN_1DD0,
                FUN_1E24,
                FUN_21A4,
                FUN_2130
            };
            PTR_FUN_7C00 = new FUN_7C00[1]
            {
                FUN_21A4
            };
            PTR_FUN_7C14 = new FUN_7C14[1]
            {
                FUN_10C
            };
            PTR_FUN_7C30 = new FUN_7C30[1]
            {
                FUN_10C
            };
            PTR_FUN_7C4C = new FUN_7C4C[5]
            {
                FUN_2224,
                FUN_2398, 
                FUN_1F70, 
                FUN_1FAC, 
                FUN_21C4
            };
            PTR_FUN_7DA0 = new FUN_7DA0[2]
            {
                FUN_31F0,
                FUN_3254
            };
            PTR_FUN_7DA8 = new FUN_7DA8[3]
            {
                FUN_33F8,
                FUN_34A4,
                FUN_2D98
            };
            PTR_FUN_7DB4 = new FUN_7DB4[3]
            {
                FUN_36B0,
                FUN_3734,
                FUN_3880
            };
            PTR_FUN_7E08 = new FUN_7E08[2]
            {
                FUN_3980, 
                FUN_3AA0
            };
            PTR_FUN_7E2C = new FUN_7E2C[2]
            {
                FUN_4070,
                FUN_40AC
            };
            PTR_FUN_7E34 = new FUN_7E34[2]
            {
                FUN_4124,
                FUN_418C
            };
            PTR_FUN_7E3C = new FUN_7E3C[9]
            {
                FUN_3EC0, 
                FUN_3E84, 
                FUN_3E84, 
                FUN_40E8, 
                FUN_3674, 
                FUN_41F8, 
                FUN_329C, 
                FUN_3944, 
                FUN_2DEC
            };
            PTR_FUN_7E60 = new FUN_7E60[1]
            {
                FUN_4298
            };
            PTR_FUN_8114 = new FUN_8114[1]
            {
                FUN_2D98
            };
            PTR_FUN_8134 = new FUN_8134[5]
            {
                FUN_331C, 
                FUN_4258, 
                FUN_43A4, 
                FUN_43E0,
                FUN_4BEC
            };
            PTR_FUN_8150 = new FUN_8150[2]
            {
                FUN_4FD8, 
                FUN_50B8
            };
            PTR_FUN_8158 = new FUN_8158[3]
            {
                FUN_516C, 
                FUN_51D0, 
                FUN_5260
            };
            PTR_FUN_8164 = new FUN_8164[1]
            {
                FUN_5130
            };
            PTR_FUN_81A4 = new FUN_81A4[3]
            {
                FUN_5444,
                FUN_54EC,
                FUN_60068
            };
            PTR_FUN_8210 = new FUN_8210[3]
            {
                FUN_5630,
                FUN_5740,
                FUN_60068
            };
            PTR_FUN_8240 = new FUN_8240[4]
            {
                FUN_5884,
                FUN_58F8,
                FUN_5B0C,
                FUN_60068
            };
            PTR_FUN_8264 = new FUN_8264[4]
            {
                FUN_61D0,
                FUN_6254,
                FUN_6468,
                FUN_60068
            };
            PTR_FUN_8274 = new FUN_8274[2]
            {
                FUN_6B50,
                FUN_6B94
            };
            PTR_FUN_8280 = new FUN_8280[2]
            {
                FUN_6C8C,
                FUN_6CD8
            };
            PTR_FUN_8294 = new FUN_8294[2]
            {
                FUN_6E7C,
                FUN_6EC0
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


    //FUN_04 (ST2)
    public override void Initialize()
    {
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();
        PTR_FUN_B58BC = DAT_7470;
        PTR_FUN_B58C0 = DAT_74BC;
        PTR_FUN_C2570 = DAT_74D4;
        PTR_FUN_C1CF8 = DAT_7500;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_73E0[uVar3];
        GameManager.instance.DAT_46 = 2;
        GameManager.instance.DAT_B0 = DAT_7250;

        for (int i = 0; i < DAT_72F0.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
            puVar5 = DAT_72F0.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 2);
    }

    //FUN_10C (ST2)
    private void FUN_10C(CriPlayer param1)
    {
        return;
    }

    //FUN_3AC (ST2)
    private void FUN_3AC(CriPlayer param1)
    {
        ushort uVar1;
        CriParticle oVar2;
        CriObject oVar3;

        if (param1.DAT_1DA == PTR_DAT_7888[param1.DAT_1D9].DAT_00)
        {
            do
            {
                oVar2 = SceneManager.instance.FUN_5FFA0();

                if (oVar2 != null)
                {
                    oVar2.tags = PTR_DAT_7888[param1.DAT_1D9].DAT_01;
                    oVar2.DAT_2F = PTR_DAT_7888[param1.DAT_1D9].DAT_02;
                    oVar3 = Utilities.FUN_601C8(param1.skeleton, PTR_DAT_7888[param1.DAT_1D9].DAT_03);
                    oVar2.DAT_4C = oVar3;
                    oVar2.screen = PTR_DAT_7888[param1.DAT_1D9].DAT_04;
                    uVar1 = PTR_DAT_7888[param1.DAT_1D9].DAT_0A;
                    oVar2.DAT_60 = uVar1;
                    oVar2.DAT_62 = uVar1;
                    oVar2.IDAT_6C = PTR_DAT_7888[param1.DAT_1D9].DAT_0C;
                    param1.DAT_1D9++;
                }
            } while (PTR_DAT_7888[param1.DAT_1D9].DAT_00 == param1.DAT_1DA);

            if (8 < param1.DAT_1D9)
                param1.DAT_1C0 &= 0xbfffffff;
        }

        param1.DAT_1DA++;
    }

    //FUN_55C (ST2)
    private void FUN_55C(CriPlayer param1)
    {
        ushort uVar1;
        CriParticle oVar2;
        CriObject oVar3;

        if (param1.DAT_60 == PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_00)
        {
            do
            {
                oVar2 = SceneManager.instance.FUN_5FFA0();

                if (oVar2 != null)
                {
                    oVar2.tags = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_01;
                    oVar2.DAT_2F = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_02;
                    oVar3 = Utilities.FUN_601C8(param1.skeleton, PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_03);
                    oVar2.DAT_4C = oVar3;
                    oVar2.screen = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_04;
                    uVar1 = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_0A;
                    oVar2.DAT_62 = uVar1;
                    oVar2.DAT_60 = uVar1;
                    oVar2.DAT_40 = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_0C;
                    oVar2.DAT_70.y = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_12;
                    param1.DAT_1E6++;
                }
            } while (PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_00 == param1.DAT_60);

            if (20 < (byte)param1.DAT_1E6)
                param1.DAT_1C0 &= 0xfffeffff;
        }
    }

    //FUN_850 (ST2)
    private void FUN_850(CriPlayer param1)
    {
        CriCamera oVar1;
        short sVar2;

        oVar1 = SceneManager.instance.cCamera;
        sVar2 = (short)(param1.DAT_1D3 & 0x7f);
        oVar1.DAT_38 += (short)(DAT_7B00[param1.DAT_1D2] * sVar2);
        oVar1.DAT_3A += (short)(DAT_7AE4[param1.DAT_1D2] * sVar2);
        param1.DAT_1D2++;

        if (13 < param1.DAT_1D2)
        {
            param1.DAT_1D2 = 0;
            param1.DAT_1D3 = 0;
        }
    }

    //FUN_8F0 (ST2)
    private void FUN_8F0(CriPlayer param1)
    {
        byte bVar1;

        bVar1 = param1.frame.DAT_02;

        if (bVar1 != 0)
        {
            GameManager.FUN_64650();
            param1.UDAT_1D2 = 0x8100;
            GameManager.instance.FUN_5C94C(param1, DAT_7B1C[bVar1]);
        }
    }

    //FUN_1DD0 (ST2)
    private void FUN_1DD0(CriPlayer param1)
    {
        param1.DAT_40.z = -70;
        param1.DAT_3D++;
        param1.FUN_609C8(10, 8, 10);
        GameManager.instance.FUN_5C94C(param1, 56);
    }

    //FUN_1E24 (ST2)
    private void FUN_1E24(CriPlayer param1)
    {
        CriCamera cVar1;
        ushort uVar2;
        bool bVar3;
        ushort uVar4;

        cVar1 = SceneManager.instance.cCamera;
        uVar4 = (ushort)(param1.vr.y + 0x400 & 0xfff);

        if (uVar4 < 0x454)
        {
            uVar4 = (ushort)(uVar4 + 10 & 0xfff);
            uVar2 = (ushort)(uVar4 - 0x400);

            if (uVar4 < 0x455) goto LAB_1EA4;
        }
        else
        {
            uVar4 = (ushort)(uVar4 - 10 & 0xfff);
            uVar2 = (ushort)(uVar4 - 0x400);

            if (0x453 < uVar4) goto LAB_1EA4;
        }

        uVar2 = 0x54;
        LAB_1EA4:
        param1.vr.y = uVar2 & 0xfff;
        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 3;
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
            param1.FUN_609C8(6, 0, 10);
            param1.DAT_40.z = 70;
            param1.DAT_3A = 0;
            param1.BDAT_1DC = 0;
            param1.IDAT_1C4 = 0;
        }

        if ((param1.DAT_1C0 & 0x40000000) != 0)
            FUN_3AC(param1);

        if (cVar1.DAT_68 == 6)
        {
            if (-0xf01 < param1.screen.z)
                return;

            param1.screen.z = -0xf00;
        }
        else
        {
            if (-0xd01 < param1.screen.z)
                return;

            param1.screen.z = -0xd00;
        }

        param1.DAT_40.z = 0;
    }

    //FUN_1F70 (ST2)
    private void FUN_1F70(CriPlayer param1)
    {
        PTR_FUN_7BF8[param1.DAT_3D](param1);
    }

    //FUN_1FAC (ST2)
    private void FUN_1FAC(CriPlayer param1)
    {
        return;
    }

    //FUN_2130 (ST2)
    private void FUN_2130(CriPlayer param1)
    {
        FUN_8F0(param1);

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.DAT_40.z = 30;
            param1.FUN_609C8(11, 9, 10);
        }
        else if (param1.DAT_3E == 1)
            param1.FUN_60AB4();
    }

    //FUN_21A4 (ST2)
    private void FUN_21A4(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_21C4 (ST2)
    private void FUN_21C4(CriPlayer param1)
    {
        PTR_FUN_7C00[param1.DAT_3D](param1);

        if ((param1.DAT_1C0 & 0x10000) != 0)
            FUN_55C(param1);
    }

    //FUN_2224 (ST2)
    private void FUN_2224(CriPlayer param1)
    {
        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.DAT_112 = 10;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_120 = 0;
        param1.PTR_120 = null;
        param1.DAT_175 = 2;
        param1.DAT_11C = 0;
        param1.DAT_3C++;
        param1.FUN_609C8(11, 1, 10);
        param1.DAT_3C = 4;
        param1.DAT_12F = 4;
        param1.DAT_3D = 0;
        param1.DAT_1DF = 0;
        param1.DAT_1C0 = 0;
        param1.DAT_124 = 0;
        param1.PTR_124 = DAT_7558;
        param1.DAT_154 = SceneManager.instance.skinnedObjects[10];
    }

    //FUN_22D0 (ST2)
    private void FUN_22D0(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;

        if ((param1.DAT_11E & 0x80) == 0)
            return;

        param1.DAT_11E &= 0x7f;

        if (param1.DAT_3C == 2)
            return;

        bVar1 = (byte)(param1.DAT_1A0 >> 4);

        if (param1.DAT_3D == 3)
        {
            if (0 < param1.DAT_40.z)
                param1.DAT_40.z = 0;

            if (bVar1 == 1)
            {
                if (param1.DAT_60 < 15) goto LAB_2370;

                param1.DAT_3C = 2;
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                sVar2 = (short)(param1.DAT_11C + 3);
            }
            else
            {
                if (bVar1 != 3) goto LAB_2370;

                param1.DAT_3C = 2;
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                sVar2 = (short)(param1.DAT_11C + 6);
            }

            param1.DAT_11C = sVar2;
        }

        LAB_2370:
        if ((param1.DAT_1C0 & 0x40000000) == 0)
        {
            param1.DAT_1C0 |= 0x40000000;
            param1.DAT_1D9 = 0;
            param1.DAT_1DA = 0;
        }
    }

    //FUN_2398 (ST2)
    private void FUN_2398(CriPlayer param1)
    {
        if ((param1.DAT_1C0 & 0x40000000) != 0)
            FUN_3AC(param1);

        if ((param1.DAT_1C0 & 0x10000) != 0)
            FUN_55C(param1);

        PTR_FUN_7C14[param1.DAT_3D](param1);
        PTR_FUN_7C30[param1.DAT_3D](param1);
    }

    //FUN_2D98 (ST2)
    private void FUN_2D98(CriPlayer param1)
    {
        return;
    }

    //FUN_2DA0 (ST2)
    private void FUN_2DA0(CriPlayer param1, short param2, short param3)
    {
        param1.DAT_10C.x = param2;
        param1.DAT_10C.z = param3;
        param1.SDAT_1D4 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        param1.DAT_40.z = 75;
        param1.DAT_1C0 |= 3;
    }

    //FUN_2DEC (ST2)
    private void FUN_2DEC(CriPlayer param1)
    {
        Vector3Int local_10;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F++;
            FUN_2DA0(param1, 0xaf, 0x1300);
            GameManager.instance.FUN_5DC54();
        }
        else
        {
            if (param1.frame.DAT_01 == 49)
                GameManager.instance.FUN_5C94C(param1, 48);

            if (param1.frame.DAT_01 == 98)
            {
                GameManager.instance.FUN_5C94C(param1, 50);
                GameManager.instance.FUN_5C94C(param1, 55);
                //FUN_1D988
            }

            if (param1.frame.DAT_01 == 125)
            {
                GameManager.instance.FUN_5C94C(param1, 49);
                GameManager.instance.FUN_5C94C(param1, 56);
                //FUN_1D988
            }
        }

        param1.FUN_60AB4();
        param1.FUN_656EC();
        local_10 = new Vector3Int(0, param1.SDAT_1D4, 0);
        Utilities.RotMatrix_gte(ref local_10, ref param1.cTransform.rotation);
    }

    //FUN_2EFC (ST2)
    private void FUN_2EFC(CriPlayer param1)
    {
        byte bVar1;
        int iVar2;
        bool bVar2;
        sbyte sVar3;
        uint uVar4;
        uint uVar5;

        if ((param1.DAT_11E & 0x80) == 0)
            return;

        param1.DAT_11E &= 0x7f;
        bVar2 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (bVar2)
            return;

        if (param1.DAT_3C == 2)
            return;

        if ((param1.DAT_1C0 & 0x10000000) != 0)
            return;

        bVar1 = (byte)(param1.DAT_1A0 >> 4);
        uVar4 = (uint)(param1.DAT_1A0 & 0xf);

        if (bVar1 == 2)
            uVar5 = DAT_7D54[uVar4];
        else
        {
            if (bVar1 < 3)
            {
                uVar5 = 0;

                if (bVar1 == 1)
                    uVar5 = DAT_7D54[uVar4 + 4];
            }
            else
            {
                uVar5 = 0;

                if (bVar1 == 3)
                    uVar5 = DAT_7D54[uVar4 + 8];
            }
        }

        iVar2 = (int)(uVar5 + param1.IDAT_1C4);
        param1.DAT_1C4 = (sbyte)iVar2;
        param1.DAT_11C = (short)(uVar5 + param1.DAT_11C);

        if (10 < iVar2)
            param1.DAT_1C0 |= 0x40;

        sVar3 = (sbyte)param1.DAT_3D;
        uVar4 = 0x102;

        if (sVar3 != 7)
        {
            if (2 < (ushort)param1.DAT_11C)
            {
                iVar2 = DAT_7D54[uVar4 + 12];

                if (-1 < iVar2)
                {
                    uVar4 = (uint)(iVar2 << 8 | 2);
                    goto LAB_3088;
                }

                sVar3 = (sbyte)(param1.DAT_3D);
            }

            if (sVar3 != 2)
                return;

            uVar4 = 0x102;

            if (bVar1 == 2 && param1.DAT_3A != 1)
                return;
        }

        LAB_3088:
        param1.DAT_3C = (byte)uVar4;
        param1.DAT_3D = (byte)(uVar4 >> 8);
        param1.DAT_3E = (byte)(uVar4 >> 0x10);
        param1.DAT_3F = (byte)(uVar4 >> 0x18);
        param1.DAT_11C = 0;
    }

    //FUN_30A0 (ST2)
    private void FUN_30A0(CriPlayer param1)
    {
        CriCamera cVar2;
        short sVar3;

        cVar2 = SceneManager.instance.cCamera;

        if ((param1.UDAT_1D2 & 1) == 0)
        {
            cVar2.DAT_38 += 8;
            cVar2.DAT_3A += 8;
            sVar3 = (short)(param1.UDAT_1D2 + 1);
        }
        else
        {
            cVar2.DAT_38 -= 8;
            cVar2.DAT_3A -= 8;
            sVar3 = (short)(param1.UDAT_1D2 - 1);
        }

        param1.UDAT_1D2 = (ushort)sVar3;

        if ((uint)param1.UDAT_1D2 >> 14 == 3)
        {
            cVar2.DAT_38 = 0;
            cVar2.DAT_3A = 0;
            param1.UDAT_1D2 = 0;
        }
    }

    //FUN_31F0 (ST2)
    private void FUN_31F0(CriPlayer param1)
    {
        param1.DAT_3E++;
        FUN_2DA0(param1, 175, 0x1300);
        param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 6], 0, 0);
    }

    //FUN_3254 (ST2)
    private void FUN_3254(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_40.z = 0;
            param1.DAT_1C0 |= 0x800;
        }
    }

    //FUN_329C (ST2)
    private void FUN_329C(CriPlayer param1)
    {
        Vector3Int local_10;

        PTR_FUN_7DA0[param1.DAT_3E](param1);
        local_10 = new Vector3Int(0, param1.SDAT_1D4, 0);
        Utilities.RotMatrix_gte(ref local_10, ref param1.cTransform.rotation);

        if (param1.frame.DAT_03 != 0)
            GameManager.instance.FUN_5C94C(param1, 57);
    }

    //FUN_331C (ST2)
    private void FUN_331C(CriPlayer param1)
    {
        CriObject oVar2;

        param1.DAT_3C = 4;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.DAT_130 = 0;
        param1.PTR_130 = DAT_7CF4;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_120 = 0;
        param1.PTR_120 = null;
        param1.DAT_140 = 1;
        param1.BDAT_1E2 = 0;
        param1.DAT_1D4 = 0;
        param1.DAT_1D5 = 0;
        oVar2 = Utilities.FUN_601C8(param1.skeleton, 2);
        param1.PTR_1CC = oVar2;
        param1.DAT_175 = 2;
        param1.DAT_11C = 0;
        param1.DAT_1DF = 0;
        param1.DAT_1EA = 0; //ushort instead of byte??
        param1.DAT_1C0 |= 0x21;
        param1.DAT_1C4 = 0;
        param1.DAT_1C5 = 0;
        param1.DAT_1C6 = 0;
        param1.DAT_1C7 = 0;
        param1.DAT_154 = SceneManager.instance.skinnedObjects[10];
        GameManager.instance.PTR_FUN_148 = FUN_530C;
        GameManager.instance.PTR_FUN_14C = FUN_5348;
        param1.PTR_124 = DAT_7CD0;
        param1.DAT_124 = 0;
        param1.DAT_12F = 3;
    }

    //FUN_33F8 (ST2)
    private void FUN_33F8(CriPlayer param1)
    {
        short sVar1;
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        param1.DAT_3E++;
        param1.FUN_609C8(1, 0, 0);

        if (param1.DAT_3C != 4)
        {
            param1.DAT_112 = 10;
            param1.DAT_40.z = 100;
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar2.screen);
            param1.SDAT_1D6 = sVar1;
        }

        param1.DAT_1C0 |= 0x400;

        //if (param1.DAT_3C != 4)
        //    ; //FUN_1D988
    }

    //FUN_34A4 (ST2)
    private void FUN_34A4(CriPlayer param1)
    {
        byte bVar1;
        CriPlayer oVar2;
        bool bVar2;

        oVar2 = (CriPlayer)param1.DAT_154;

        if (param1.DAT_3C != 4)
        {
            if (param1.DAT_112 == 0)
                param1.DAT_40.z = 0;
            else
                param1.DAT_112--;
        }

        bVar1 = param1.frame.DAT_02;

        if (bVar1 == 2)
        {
            param1.UDAT_1D2 |= 0x4000;

            if (param1.DAT_3C != 4)
            {
                oVar2.DAT_3F++;
                param1.DAT_3D = 6;
                param1.DAT_3E = 1;
                param1.DAT_3F = 0;
                param1.BDAT_1E2 = 4;
                FUN_2DA0(param1, 175, 0x1300);
            }
        }
        else if (bVar1 < 3)
        {
            if (bVar1 == 1)
            {
                param1.UDAT_1D2 |= 0x8000;
                oVar2.DAT_154 = param1;
                GameManager.instance.FUN_5C94C(param1, 51);

                if (param1.DAT_3C != 4)
                {
                    oVar2.DAT_3C = 5;
                    oVar2.DAT_3D = 1;
                    oVar2.DAT_3E = 0;
                    oVar2.DAT_3F = 0;
                    oVar2.DAT_154 = param1;
                    oVar2.DAT_1E0 = oVar2.DAT_98;
                    oVar2.DAT_98 = param1.DAT_98;
                }
            }
        }
        else if (bVar1 == 3)
            GameManager.instance.FUN_2984C(0x8001);

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            if (param1.DAT_3C == 4)
            {
                InventoryManager.FUN_4A7E8(3, 0x3f, true);
                param1.DAT_3E++;
            }
            else
            {
                param1.DAT_3D = 6;
                param1.DAT_3E = 1;
                param1.DAT_3F = 0;
                param1.BDAT_1E2 = 4;
                FUN_2DA0(param1, 175, 0x1300);
            }

            param1.DAT_1C0 &= 0xfffffbff;
        }

        if (param1.UDAT_1D2 != 0)
            FUN_30A0(param1);
    }

    //FUN_3674 (ST2)
    private void FUN_3674(CriPlayer param1)
    {
        PTR_FUN_7DA8[param1.DAT_3E](param1);
    }

    //FUN_36B0 (ST2)
    private void FUN_36B0(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 8], 0, 0);
        param1.DAT_112 = 12;
        param1.DAT_40.z = 25;
        GameManager.instance.FUN_5C94C(param1, 53);
        param1.BDAT_1E2 = 0;
        param1.DAT_1C0 |= 0x400;
    }

    //FUN_3734 (ST2)
    private void FUN_3734(CriPlayer param1)
    {
        bool bVar1;
        CriSkinned oVar2;
        bool bVar3;
        uint uVar4;

        oVar2 = SceneManager.instance.skinnedObjects[10];

        if (param1.DAT_112 == 0)
            param1.DAT_40.z = 0;
        else
            param1.DAT_112--;

        bVar3 = param1.FUN_60AB4();

        if (!bVar3)
        {
            bVar3 = SceneManager.instance.FUN_802B8(param1, false, 2);

            if (!bVar3)
                return;

            uVar4 = param1.DAT_1C0;
            bVar1 = true;

            if ((uVar4 & 0x1000) != 0)
                bVar1 = oVar2.health < 201;

            if (bVar1)
            {
                param1.DAT_3E++;
                param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 10], 0, 10);
                FUN_2DA0(param1, 0xaf, 0x1300);
                //FUN_1D988
                return;
            }
        }
        else
        {
            param1.DAT_3D = 6;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_11C = 0;
            param1.BDAT_1E2 = 1;
            uVar4 = param1.DAT_1C0 | 9;
        }

        param1.DAT_1C0 &= 0xfffffbff;
    }

    //FUN_3880 (ST2)
    private void FUN_3880(CriPlayer param1)
    {
        bool bVar1;
        CriSkinned oVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 8;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_40.z = 0;
            param1.DAT_120 = 0;
            param1.PTR_120 = null;
            oVar1 = param1.DAT_154;
            param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 2], 0, 0);
            oVar1.DAT_152 = 1;
            oVar1.DAT_154 = param1;
            oVar1.DAT_3C = 5;
            oVar1.DAT_3D = 0;
            oVar1.DAT_3E = 0;
            oVar1.DAT_3F = 0;
            oVar1.DAT_11E |= 0x80;
            oVar1.vr.y = param1.vr.y;
            oVar1.DAT_98 = param1.DAT_98;
            param1.FUN_656EC();
            param1.DAT_1C0 |= 0x10000000;
        }
    }

    //FUN_3944 (ST2)
    private void FUN_3944(CriPlayer param1)
    {
        PTR_FUN_7DB4[param1.DAT_3E](param1);
    }

    //FUN_3980 (ST2)
    private void FUN_3980(CriPlayer param1)
    {
        param1.DAT_1DF++;

        if (param1.DAT_3A == 3)
            param1.DAT_1DB = 1;
        else
        {
            param1.DAT_3A = (byte)(param1.DAT_3D - 1);
            param1.DAT_1DB = (sbyte)(-0x301 < param1.DAT_154.screen.x ? 1 : 0);

            if (param1.DAT_3A == 0 || GameManager.instance.FUN_768C8(param1.DAT_154.screen, DAT_7DC0[param1.DAT_1DB]))
                goto LAB_3A1C;
        }

        param1.DAT_3A = 0;
        LAB_3A1C:
        param1.DAT_112 = 0;
        param1.DAT_40.z = 0;
        param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB], 0, 0);
        param1.PTR_120 = DAT_7CD0;
        param1.DAT_120 = 0;
        param1.DAT_12E = 3;
        param1.DAT_3E++;
        param1.DAT_1C0 = param1.DAT_1C0 & 0x7ffffff6 | 0x400;
        param1.BDAT_1E2 = param1.DAT_3D;
    }

    //FUN_3AA0 (ST2)
    private void FUN_3AA0(CriPlayer param1)
    {
        bool bVar1;
        bool bVar2;
        uint uVar3;
        CriSkinned oVar4;

        oVar4 = param1.DAT_154;

        if (param1.frame.DAT_01 == 16)
        {
            param1.DAT_40.z = DAT_7DF0[param1.DAT_3A * 2];
            param1.DAT_112 = DAT_7DF0[(param1.DAT_3A << 2 | 2) / 2];
            GameManager.instance.FUN_5C94C(param1, 48);
        }

        if (param1.DAT_112 == 0)
            param1.DAT_40.z = 0;
        else
            param1.DAT_112--;

        bVar2 = param1.FUN_60AB4();

        if (!bVar2)
        {
            bVar2 = SceneManager.instance.FUN_802B8(param1, true, 2);

            if (!bVar2)
                return;

            uVar3 = param1.DAT_1C0;
            bVar1 = true;

            if ((uVar3 & 0x1000) != 0)
                bVar1 = oVar4.health < 201;

            if (param1.DAT_3D == 2)
                bVar1 = true;

            if (bVar1)
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 8;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_40.z = 0;
                oVar4.PTR_120 = null;
                oVar4.DAT_120 = 0;
                param1.PTR_120 = null;
                param1.DAT_120 = 0;
                param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 2], 0, 10);
                oVar4.DAT_152 = 1;
                oVar4.DAT_154 = param1;
                oVar4.DAT_3C = 5;
                oVar4.DAT_3D = 0;
                oVar4.DAT_3E = 0;
                oVar4.DAT_3F = 0;
                oVar4.DAT_11E |= 0x80;
                oVar4.vr.y = param1.vr.y;
                oVar4.DAT_98 = param1.DAT_98;
                param1.FUN_656EC();
                GameManager.instance.FUN_5C94C(param1, 49);
                FUN_2DA0(param1, 0xaf, 0x1300);
                param1.DAT_1C0 |= 0x10000000;
                //FUN_1D988
                return;
            }
        }
        else
        {
            param1.DAT_40.z = 0;
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 4], 0, 0);
            uVar3 = param1.DAT_1C0;
        }

        param1.DAT_1C0 = uVar3 & 0xfffffbff;
    }

    //FUN_3E84 (ST2)
    private void FUN_3E84(CriPlayer param1)
    {
        PTR_FUN_7E08[param1.DAT_3E](param1);
    }

    //FUN_3EC0 (ST2)
    private void FUN_3EC0(CriPlayer param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        int iVar3;
        uint uVar4;

        uVar4 = param1.DAT_1C0;

        if ((uVar4 & 0x80) == 0)
        {
            if (param1.DAT_154.screen.x < -0x2ff)
            {
                bVar1 = param1.DAT_1EF;
                param1.DAT_1EF = (byte)(bVar1 + 1);
                bVar1 = DAT_7E24[bVar1];
                param1.DAT_3D = (byte)(bVar1 & 0x7f);

                if ((bVar1 & 0x80) != 0)
                    param1.DAT_1C0 |= 0x80;

                param1.DAT_1C0 &= 0xfffff7ff;
                return;
            }

            param1.DAT_1C0 = uVar4 | 0x80;

            if ((uVar4 & 0x800) == 0)
            {
                param1.DAT_3D = 6;
                param1.DAT_11C = 0;
                param1.DAT_1C0 |= 9;
                return;
            }
        }

        if (1 < param1.BDAT_1E2 - 1)
            param1.DAT_1DF = 0;

        param1.DAT_3E = 0;
        bVar3 = InventoryManager.FUN_4A87C(3, 0x22);

        if (!bVar3)
        {
            if (1 < param1.DAT_1DF)
            {
                param1.DAT_3D = 4;
                return;
            }

            if (param1.BDAT_1E2 == 4)
            {
                param1.DAT_3D = 2;
                return;
            }

            do
            {
                iVar3 = (int)GameManager.FUN_64650();
                sVar2 = DAT_7E14[iVar3 >> 3 & 0xf];
                param1.DAT_3D = (byte)sVar2;
            } while (sVar2 == param1.BDAT_1E2);
        }
        else
        {
            InventoryManager.FUN_4A7E8(3, 0x22, false);
            param1.DAT_3D = 1;
            param1.DAT_3A = 3;
        }

        param1.DAT_1C0 &= 0xfffff7ff;
    }

    //FUN_4070 (ST2)
    private void FUN_4070(CriPlayer param1)
    {
        param1.DAT_1DF = 0;
        param1.DAT_3E++;
        param1.FUN_609C8(16, 0, 0);
    }

    //FUN_40AC (ST2)
    private void FUN_40AC(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.BDAT_1E2 = 3;
        }
    }

    //FUN_40E8 (ST2)
    private void FUN_40E8(CriPlayer param1)
    {
        PTR_FUN_7E2C[param1.DAT_3E](param1);
    }

    //FUN_4124 (ST2)
    private void FUN_4124(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(15, 0, 10);
        FUN_2DA0(param1, 175, 0xd22);
        param1.DAT_40.z = 20;
        GameManager.instance.FUN_5C94C(param1, 52);
        param1.BDAT_1E2 = 0;
    }

    //FUN_418C (ST2)
    private void FUN_418C(CriPlayer param1)
    {
        param1.FUN_60AB4();

        if (param1.frameNum == 45)
        {
            param1.DAT_3D = 6;
            param1.DAT_3E = 1;
            FUN_2DA0(param1, 175, 0x1300);
            param1.DAT_40.z += 10;
            param1.DAT_1C0 |= 9;
        }
    }

    //FUN_41F8 (ST2)
    private void FUN_41F8(CriPlayer param1)
    {
        Vector3Int local_10;

        PTR_FUN_7E34[param1.DAT_3E](param1);
        local_10 = new Vector3Int(0, param1.SDAT_1D4, 0);
        Utilities.RotMatrix_gte(ref local_10, ref param1.cTransform.rotation);
    }

    //FUN_4258 (ST2)
    private void FUN_4258(CriPlayer param1)
    {
        PTR_FUN_7E3C[param1.DAT_3D & 0x7f](param1);
    }

    //FUN_4298 (ST2)
    private void FUN_4298(CriPlayer param1)
    {
        bool bVar1;

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(17, 0, 0);
        }
        else
        {
            bVar1 = param1.FUN_60AB4();

            if (bVar1)
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1E2 = 0;
            }
        }
    }

    //FUN_4300 (ST2)
    private void FUN_4300(CriPlayer param1)
    {
        param1.DAT_3C = 1;
        param1.DAT_3D = 6;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_3E = 1;
        param1.FUN_609C8(DAT_7D00[(byte)param1.DAT_1DB + 12], 0, 0);
        FUN_2DA0(param1, 0xaf, 0x1300);
        param1.DAT_40.z = 100;
        GameManager.instance.FUN_5C94C(param1, 54);
        param1.DAT_1C0 = param1.DAT_1C0 & 0xffffffdf | 0x80;
        param1.BDAT_1E2 = 0;
    }

    //FUN_43A4 (ST2)
    private void FUN_43A4(CriPlayer param1)
    {
        PTR_FUN_7E60[param1.DAT_3D](param1);
    }

    //FUN_43E0 (ST2)
    private void FUN_43E0(CriPlayer param1)
    {
        return;
    }

    //FUN_4BEC (ST2)
    private void FUN_4BEC(CriPlayer param1)
    {
        PTR_FUN_8114[param1.DAT_3D](param1);
    }

    //FUN_4FD8 (ST2)
    private void FUN_4FD8(CriPlayer param1)
    {
        uint uVar1;
        CriPlayer oVar2;

        oVar2 = (CriPlayer)param1.DAT_154;
        param1.FUN_66418();
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_8148[oVar2.DAT_1DB], 0, 0);
        param1.DAT_140 = 0xffff;
        param1.DAT_12C = 0xffff;
        param1.FUN_65714();
        param1.DAT_1C0 &= 0xfffffffe;
        SceneManager.instance.cCamera.DAT_70 = 1;
        SceneManager.instance.cCamera.PTR_FUN_8C = SceneManager.instance.cCamera.FUN_2D20;
        SceneManager.instance.staticObjects[9].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[9].flags &= 0xfffffffd;
        uVar1 = SceneManager.instance.staticObjects[13].flags;

        if (uVar1 != 0)
            SceneManager.instance.staticObjects[13].flags = uVar1 & 0xfffffffd;
    }

    //FUN_50B8 (ST2)
    private void FUN_50B8(CriPlayer param1)
    {
        CriSkinned oVar1;

        oVar1 = param1.DAT_154;
        param1.FUN_60AB4();
        param1.FUN_65714();

        if (oVar1.frame.DAT_01 == 42)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_5130 (ST2)
    private void FUN_5130(CriPlayer param1)
    {
        PTR_FUN_8150[param1.DAT_3E](param1);
    }

    //FUN_516C (ST2)
    private void FUN_516C(CriPlayer param1, CriPlayer param2)
    {
        param1.DAT_40.z = -0xf;
        param1.DAT_3E++;
        param1.FUN_609C8(22, 0, 10);
        param2.SDAT_1D4 = (short)Utilities.FUN_615EC(param1.screen, param2.screen);
    }

    //FUN_51D0 (ST2)
    private void FUN_51D0(CriPlayer param1, CriPlayer param2)
    {
        Vector3Int local_18;

        param1.FUN_60AB4();

        if (param1.DAT_3F != 0)
        {
            param1.DAT_3F = 0;
            param1.DAT_40.z = 0;
            param1.DAT_3E++;
            param1.FUN_609C8(23, 4, 0);
        }

        local_18 = new Vector3Int(0, param2.SDAT_1D4, 0);
        Utilities.RotMatrix(ref local_18, ref param1.cTransform.rotation);
    }

    //FUN_5260 (ST2)
    private void FUN_5260(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_98 = param1.DAT_1E0;
        }
    }

    //FUN_529C (ST2)
    private void FUN_529C(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        CriPlayer oVar2;

        oVar2 = (CriPlayer)param2.DAT_154;
        PTR_FUN_8158[param2.DAT_3E](param1, oVar2);
        sVar1 = (short)Utilities.FUN_64838(param2.vr.y, 150, (ushort)oVar2.SDAT_1D4);
        param2.vr.y += sVar1;
    }

    //FUN_5444 (ST2)
    private void FUN_5444(CriParticle param1)
    {
        ushort uVar1;

        if ((param1.DAT_2F & 0x80) != 0)
            FUN_55D0(param1);

        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_816C[param1.DAT_2F].DAT_00));
        uVar1 = PTR_DAT_816C[param1.DAT_2F].DAT_04;
        param1.DAT_56 = 0x65;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.DAT_76 = 30;
        param1.DAT_54 = uVar1;
        param1.DAT_3C++;
    }

    //FUN_54EC (ST2)
    private void FUN_54EC(CriParticle param1)
    {
        short sVar1;

        param1.DAT_40 += param1.DAT_70;
        param1.screen += param1.DAT_40;

        if (param1.DAT_2F < 2)
        {
            param1.FUN_606D8();

            if ((param1.DAT_58.FRAMES[param1.DAT_5C].DAT_04 & 0xe0) == 0)
                return;
        }
        else
        {
            sVar1 = param1.DAT_76;
            param1.DAT_76 = (short)(sVar1 - 1);

            if (sVar1 != 1)
                return;
        }

        param1.DAT_3C++;
    }

    //FUN_55D0 (ST2)
    private void FUN_55D0(CriParticle param1)
    {
        byte bVar1;
        ushort uVar2;

        bVar1 = param1.DAT_2F;
        param1.DAT_2F = 0;
        param1.IDAT_6C = 0;
        param1.DAT_70.y = 0;
        uVar2 = (ushort)(bVar1 & 0x7f);
        param1.DAT_62 = uVar2;
        param1.DAT_60 = uVar2;
    }

    //FUN_5630 (ST2)
    private void FUN_5630(CriParticle param1)
    {
        ushort uVar1;
        byte bVar2;
        int iVar3;
        int iVar4;

        param1.DAT_56 = 0x25;
        iVar4 = param1.DAT_2F;
        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_81B0[iVar4].DAT_00));

        if (iVar3 == 1)
            param1.DAT_3C++;

        param1.DAT_54 = PTR_DAT_81B0[iVar4].DAT_04;
        param1.DAT_50.a |= 2;
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;

        if (param1.DAT_2F == 0)
        {
            param1.DAT_60 = 30;
            param1.DAT_62 = 21;
        }
        else
        {
            uVar1 = PTR_DAT_81B0[iVar4].DAT_06;
            param1.DAT_62 = uVar1;
            param1.DAT_60 = uVar1;
            bVar2 = (byte)Utilities.Rand();
            param1.DAT_6C[0] = bVar2;
            bVar2 = (byte)Utilities.Rand();
            param1.DAT_6C[1] = bVar2;
            bVar2 = (byte)Utilities.Rand();
            param1.DAT_6C[2] = bVar2;
        }

        param1.vr.z = param1.DAT_6C[2];
        param1.DAT_6C[3] = 30;
        param1.flags |= 2;
        param1.DAT_3C++;
    }

    //FUN_5740 (ST2)
    private void FUN_5740(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;
        short sVar3;

        param1.vr.x += param1.DAT_6C[0];
        param1.vr.y += param1.DAT_6C[1];
        param1.vr.z += param1.DAT_6C[2];
        sVar3 = (short)(param1.DAT_70.x + 20);
        param1.DAT_70.x = sVar3;
        param1.screen.y += sVar3;
        param1.screen.x = param1.screen.x - 0x50 + param1.DAT_68 * 2;
        param1.screen.z = param1.screen.z + param1.DAT_69 * -2;
        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C++;
        else
        {
            sVar1 = (sbyte)(param1.DAT_6C[3] - 1);
            param1.DAT_6C[3] = (byte)sVar1;

            if (sVar1 == 0)
                param1.DAT_3C++;
        }
    }

    //FUN_5884 (ST2)
    private void FUN_5884(CriParticle param1)
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

    //FUN_58F8 (ST2)
    private void FUN_58F8(CriParticle param1)
    {
        sbyte sVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                if ((sbyte)param1.DAT_6A < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 145);
                    param1.DAT_6A++;
                }

                if (param1.DAT_6A != 3) goto LAB_5A1C;

                goto LAB_5A10;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_5A10;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_5A1C;

                goto LAB_5A10;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_5A1C;

                goto LAB_5A10;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;
            }

            if (param1.DAT_6A != 3) goto LAB_5A1C;

            goto LAB_5A10;
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_5A1C;

            goto LAB_5A10;
        }

        LAB_5A10:
        param1.DAT_69 = 1;

        LAB_5A1C:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            param1.DAT_6C[param1.DAT_68] = DAT_821C[param1.DAT_6A * 3 + param1.DAT_69];
            sVar1 = (sbyte)(param1.DAT_68 + 1);
            param1.DAT_68 = (byte)sVar1;

            if (3 < sVar1)
                param1.DAT_3C++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 147);

            if ((sbyte)param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.DAT_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_5B0C (ST2)
    private void FUN_5B0C(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.DAT_6C[uVar1] != DAT_8228[param1.DAT_2F * 4 + uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 149);
                return;
            }

            bVar2++;
            uVar1 = bVar2;
        } while (bVar2 < 4);

        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_61D0 (ST2)
    private void FUN_61D0(CriParticle param1)
    {
        uint uVar2;

        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
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

    //FUN_6254 (ST2)
    private void FUN_6254(CriParticle param1)
    {
        sbyte sVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                if ((sbyte)param1.DAT_6A < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 145);
                    param1.DAT_6A++;
                }

                if (param1.DAT_6A != 3) goto LAB_6378;

                goto LAB_636C;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_636C;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_6378;

                goto LAB_636C;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_6378;

                goto LAB_636C;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_6378;

                goto LAB_636C;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }
            
            if (param1.DAT_6A != 3) goto LAB_6378;
        }

        LAB_636C:
        param1.DAT_69 = 1;

        LAB_6378:
        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            param1.DAT_6C[param1.DAT_68] = DAT_8250[param1.DAT_6A * 3 + param1.DAT_69];
            sVar1 = (sbyte)(param1.DAT_68 + 1);
            param1.DAT_68 = (byte)sVar1;

            if (5 < sVar1)
                param1.DAT_3C++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 147);

            if ((sbyte)param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.DAT_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_6468 (ST2)
    public void FUN_6468(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            bVar2++;

            if (param1.DAT_6C[uVar1] != DAT_825C[uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 149);
                return;
            }

            uVar1 = bVar2;
        } while (bVar2 < 6);

        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_6B50 (ST2)
    private void FUN_6B50(CriStatic param1)
    {
        ushort uVar1;

        uVar1 = (ushort)(param1.DAT_75 * 2);
        param1.SDAT_78 = (short)uVar1;

        if (0xff < uVar1)
            param1.SDAT_78 = (short)(uVar1 - 0x200);

        param1.DAT_7A = 40;
        param1.tags++;
    }

    //FUN_6B94 (ST2)
    private void FUN_6B94(CriStatic param1)
    {
        return;
    }

    //FUN_6C8C (ST2)
    private void FUN_6C8C(CriStatic param1)
    {
        byte bVar1;

        bVar1 = (byte)Utilities.Rand();
        param1.DAT_78 = (byte)((bVar1 & 31) + 30);
        bVar1 = (byte)Utilities.Rand();
        param1.DAT_79 = (byte)((bVar1 & 15) + 10);
        param1.tags++;
    }

    //FUN_6CD8 (ST2)
    private void FUN_6CD8(CriStatic param1)
    {
        return;
    }

    //FUN_6E7C (ST2)
    private void FUN_6E7C(CriStatic param1)
    {
        param1.tags++;
        param1.DAT_4C = Vector3Int.zero;
        //FUN_6EE0
    }

    //FUN_6EC0 (ST2)
    private void FUN_6EC0(CriStatic param1)
    {
        FUN_70A0(param1);
    }

    //FUN_6FB4 (ST2)
    private void FUN_6FB4(CriStatic param1)
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

    //FUN_70A0 (ST2)
    private bool FUN_70A0(CriStatic param1)
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
            if (param1.DAT_6F != 0) goto LAB_7234;

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
                uVar3 = (uint)param1.DAT_6C - param1.DAT_6D;
                aVar4 = param1.DAT_68;
            }

            param1.DAT_5C = (int)(uVar3 * 4 + 1);
            bVar5 = param1.DAT_68[uVar3 * 4];
            param1.DAT_6F = bVar5;

            if ((bVar1 & 4) != 0 && 1 < bVar5)
                param1.DAT_6F = (byte)(bVar5 >> 1);

            if ((bVar1 & 8) == 0) goto LAB_7234;

            sVar2 = (sbyte)(param1.DAT_6F << 1);
        }
        else
            sVar2 = (sbyte)(param1.DAT_6F + 1);

        param1.DAT_6F = (byte)sVar2;
        LAB_7234:
        FUN_6FB4(param1);
        return bVar6;
    }

    //FUN_2438 (ST2)
    public static void FUN_2438(CriPlayer param1)
    {
        uint uVar1;
        sbyte sVar2;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            return;

        if (param1.DAT_3C != 0)
        {
            if ((param1.DAT_18E & 0x80) != 0) goto LAB_2574;

            sVar2 = (sbyte)(param1.DAT_1E2 >> 8);

            if (sVar2 == 6)
            {
                if (SceneManager.instance.cCamera.DAT_68 == 7)
                {
                    param1.DAT_1C0 = param1.DAT_1C0 & 0xfffdffff | 0x40000;
                    goto LAB_2514;
                }
            }

            if (sVar2 == 7 && SceneManager.instance.cCamera.DAT_68 == 6)
                param1.DAT_1C0 &= 0xfff9ffff;
        }

        LAB_2514:
        param1.DAT_34 = param1.screen;
        instance.FUN_22D0(param1);
        instance.PTR_FUN_7C4C[param1.DAT_3C](param1);
        SceneManager.instance.FUN_802B8(param1, false, 1);
        param1.FUN_62F3C(ref param1.DAT_40);

        LAB_2574:
        if ((param1.UDAT_1D2 & 0x8000) != 0)
            instance.FUN_850(param1);

        if (param1.DAT_3C == 4)
            uVar1 = param1.flags & 0xfffffffb;
        else
            uVar1 = param1.flags | 4;

        param1.flags = uVar1;
        param1.DAT_1E2 = (ushort)(SceneManager.instance.cCamera.DAT_68 << 8 | (byte)param1.DAT_1E2);
    }

    //FUN_4C28 (ST2)
    public static void FUN_4C28(CriPlayer param1)
    {
        byte bVar1;
        bool bVar2;
        short sVar3;
        short sVar4;
        int iVar5;
        bool bVar5;
        uint uVar6;
        CriSkinned oVar7;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            return;

        if (param1.DAT_3C != 0 && (param1.DAT_18E & 0x80) != 0)
            return;

        oVar7 = param1.DAT_154;
        param1.DAT_34 = param1.screen;
        instance.FUN_2EFC(param1);
        bVar5 = GameManager.instance.FUN_768C8(oVar7.screen, DAT_7DC0[0]);

        if (!bVar5)
            uVar6 = param1.DAT_1C0 & 0xffffefff;
        else
            uVar6 = param1.DAT_1C0 | 0x1000;

        param1.DAT_1C0 = uVar6;
        instance.PTR_FUN_8134[param1.DAT_3C](param1);
        param1.FUN_62F3C(ref param1.DAT_40);

        if (param1.DAT_3C == 4 || (ushort)param1.DAT_1D0 == 0)
            param1.DAT_1C0 |= 0x40;
        else
            param1.DAT_1D0--;

        if ((param1.DAT_1C0 & 0x40) != 0 && param1.DAT_3C == 1 && param1.DAT_3D == 0)
        {
            InventoryManager.FUN_4A7E8(3, 0x3e, true);
            oVar7.DAT_11E = 0;
        }

        bVar5 = SceneManager.instance.FUN_802B8(param1, false, 3);

        if (!bVar5)
        {
            param1.FUN_66208();
            goto LAB_4EBC;
        }

        bVar2 = false;

        if (oVar7.DAT_152 == 0 && (oVar7.DAT_11E & 1) == 0)
        {
            bVar1 = param1.DAT_3D;

            if (bVar1 == 4)
            {
                if ((param1.DAT_1C0 & 0x400) != 0 && (param1.DAT_12B & 6) == 0)
                    goto LAB_4E30;
            }
            else
            {
                if (bVar1 < 5)
                {
                    if (bVar1 < 3 && bVar1 != 0)
                    {
                        if ((param1.DAT_1C0 & 0x400) != 0 && (param1.DAT_12B & 6) == 0)
                            goto LAB_4E30;
                    }
                }
                else
                {
                    if (bVar1 == 7)
                    {
                        if ((param1.DAT_1C0 & 0x400) != 0 && (param1.DAT_12B & 6) == 0)
                            goto LAB_4E30;
                    }
                }
            }

            bVar2 = true;
        }

        LAB_4E30:
        if (bVar2)
        {
            oVar7.DAT_11E |= 0x80;
            sVar3 = oVar7.FUN_64804(param1.screen);
            oVar7.DAT_3E = (byte)(((sVar3 + 0x200 & 0xfff) >> 10) | 0x10);
            oVar7.DAT_3C = 2;
            oVar7.DAT_3D = 0;
            oVar7.DAT_177 = 20;
            sVar3 = (short)(oVar7.health - 200);
            oVar7.health = sVar3;

            if (sVar3 < 100)
                oVar7.health = 100;

            //FUN_1D988
        }

        LAB_4EBC:
        if ((param1.DAT_1C0 & 1) != 0 && param1.DAT_3C != 4 && oVar7.DAT_152 == 0)
        {
            sVar4 = (short)Utilities.FUN_615EC(param1.screen, oVar7.screen);
            iVar5 = (int)Utilities.FUN_64838(param1.vr.y, 10, sVar4);
            param1.vr.y += iVar5;

            if (0x900 < param1.vr.y * 0x10000 >> 0x10)
                param1.vr.y = 0x900;

            if (param1.vr.y < 0x6d0)
                param1.vr.y = 0x6d0;
        }

        if ((param1.DAT_1C0 & 2) != 0)
        {
            uVar6 = Utilities.FUN_63160(param1.DAT_10C, param1.screen);

            if (uVar6 < 10000)
            {
                param1.DAT_40.z = 0;
                param1.screen.x = param1.DAT_10C.x;
                param1.screen.z = param1.DAT_10C.z;
                param1.DAT_1C0 &= 0xfffffffd;
            }
        }

        if (param1.DAT_3C == 4)
            uVar6 = param1.flags & 0xfffffffb;
        else
            uVar6 = param1.flags | 4;

        param1.flags = uVar6;
    }

    //FUN_530C (ST2)
    public static void FUN_530C(CriPlayer param1)
    {
        instance.PTR_FUN_8164[param1.DAT_3D](param1);
    }

    //FUN_5348 (ST2)
    public static void FUN_5348(CriPlayer param1)
    {
        return;
    }

    //FUN_53E4 (ST2)
    public static void FUN_53E4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_81A4[param1.DAT_3C](param1);
    }

    //FUN_55F4 (ST2)
    public static void FUN_55F4(CriParticle param1)
    {
        instance.PTR_FUN_8210[param1.DAT_3C](param1);
    }

    //FUN_5838 (ST2)
    public static void FUN_5838(CriParticle param1)
    {
        instance.PTR_FUN_8240[param1.DAT_3C](param1);
        //FUN_5BBC
    }

    //FUN_6184 (ST2)
    public static void FUN_6184(CriParticle param1)
    {
        instance.PTR_FUN_8264[param1.DAT_3C](param1);
    }

    //FUN_6B14 (ST2)
    public static void FUN_6B14(CriStatic param1)
    {
        instance.PTR_FUN_8274[param1.tags](param1);
    }

    //FUN_6C50 (ST2)
    public static void FUN_6C50(CriStatic param1)
    {
        instance.PTR_FUN_8280[param1.tags](param1);
    }

    //FUN_6E40 (ST2)
    public static void FUN_6E40(CriStatic param1)
    {
        instance.PTR_FUN_8294[param1.tags](param1);
    }
}
