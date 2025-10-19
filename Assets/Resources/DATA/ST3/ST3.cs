using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct UNK_11CD8
{
    public uint DAT_00; //0x00
    public byte DAT_04; //0x04
}

struct UNK_123CC
{
    public Vector3Int[] DAT_00; //0x00
    public byte DAT_04; //0x04
}

public class ST3 : LevelManager
{
    public static new ST3 instance;

    private byte[] DAT_28 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4 };
    public FUN_B58BC[] DAT_11B40 = new FUN_B58BC[22] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08,
                                                       null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, FUN_464F8,
                                                       FUN_3A4, FUN_CF0, FUN_14E4, FUN_1D80, FUN_1E88, FUN_2308, FUN_203C,
                                                       FUN_2170 };
    public FUN_B58C0[] DAT_11B98 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, FUN_6364 };
    public FUN_C2570[] DAT_11BC0 = new FUN_C2570[3] { FUN_4A26C, FUN_7F6F8, FUN_7F750 };
    public FUN_C1CF8[] DAT_11BE0 = new FUN_C1CF8[1] { FUN_20A98 };
    public byte[][] DAT_11AB0 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 10, 27, 15, 13, 0, 32, 25, 20, 18, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 8, 27, 0, 0, 0, 32, 25, 20, 20, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 8, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 6, 0, 0, 35, 0, 0, 0, 22, 0, 0, 0, 23, 0, 0, 0, 16, 26, 20, 19, 17, 31, 30, 29, 24, 0, 31, 31, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_118D0; //0x118D0 (ST3)
    public TrgScriptableObject DAT_119C0; //0x119C0 (ST3)
    public uint[] DAT_11674 = new uint[151] { 0x0, 0xa, 0x11, 0x22, 0x31, 0x36, 0x80000046, 0x0, 0x16, 0x3a, 0x80000060, 0x0, 0x8, 0x17, 0x36, 0x8000005b, 0x0, 0xa, 0x18, 0x26, 0x2e, 0x36, 0x80000044, 0x0, 0x16, 0x80000046, 0x0, 0xc, 0x10, 0x1d, 0x21, 0x32, 0x3b, 0x80000044, 0x0, 0x6, 0x9, 0x22, 0x2e, 0x33, 0x80000047, 0x0, 0x1f, 0x24, 0x39, 0x8000004e, 0x0, 0x15, 0x1b, 0x20, 0x29, 0x36, 0x80000060, 0x0, 0x8, 0x16, 0x36, 0x80000047, 0x0, 0xe, 0x2f, 0x33, 0x80000040, 0x0, 0xd, 0x24, 0x32, 0x38, 0x80000045, 0x0, 0x7, 0xc, 0x12, 0x21, 0x27, 0x30, 0x39, 0x80000041, 0x0, 0x7, 0xf, 0x30, 0x80000042, 0x0, 0x12, 0x1a, 0x25, 0x39, 0x80000052, 0x0, 0x8, 0xb, 0x12, 0x18, 0x24, 0x30, 0x80000048, 0x0, 0x6, 0x17, 0x2b, 0x80000040, 0x0, 0x6, 0x2a, 0x31, 0x80000040, 0x0, 0xf, 0x24, 0x36, 0x8000003e, 0x0, 0x13, 0x2b, 0x8000004c, 0x0, 0x26, 0x37, 0x80000046, 0x0, 0x12, 0x26, 0x35, 0x8000004e, 0x0, 0x20, 0x27, 0x3b, 0x8000004a, 0x0, 0x10, 0x30, 0x3c, 0x80000050, 0x0, 0x8, 0x18, 0x29, 0x35, 0x3b, 0x80000047, 0x0, 0x12, 0x34, 0x80000044, 0x0, 0x1b, 0x25, 0x34, 0x80000043 };
    private delegate void FUN_11C70(CriParticle p); //0x11C70 (ST3)
    private delegate void FUN_11C80(CriParticle p); //0x11C80 (ST3)
    private delegate void FUN_11CBC(CriParticle p); //0x11CBC (ST3)
    private delegate void FUN_11CCC(CriParticle p); //0x11CCC (ST3)
    private delegate void FUN_11CF0(CriParticle p); //0x11CF0 (ST3)
    private delegate void FUN_11CFC(CriParticle p); //0x11CFC (ST3)
    private delegate void FUN_11D34(CriParticle p); //0x11D34 (ST3)
    private delegate void FUN_11D64(CriParticle p); //0x11D64 (ST3)
    private delegate void FUN_12678(CriPlayer p); //0x12678 (ST3)
    private delegate void FUN_12684(CriPlayer p); //0x12684 (ST3)
    private delegate void FUN_12694(CriPlayer p); //0x12694 (ST3)
    private delegate void FUN_126A4(CriPlayer p); //0x126A4 (ST3)
    private delegate void FUN_126BC(CriPlayer p1, CriPlayer p2); //0x126BC (ST3)
    private delegate void FUN_126CC(CriPlayer p); //0x126CC (ST3)
    private delegate void FUN_126D8(CriPlayer p); //0x126D8 (ST3)
    private delegate void FUN_126E0(CriPlayer p); //0x126E0 (ST3)
    private delegate void FUN_12704(CriPlayer p); //0x12704 (ST3)
    private delegate void FUN_12754(CriPlayer p); //0x12754 (ST3)
    private delegate void FUN_12768(CriPlayer p); //0x12768 (ST3)
    private byte[] DAT_11C4C = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 0 }; //0x11C4C (ST3)
    private byte[] DAT_11C58 = new byte[] { 1, 5, 3, 7, 9, 2, 6, 10, 8, 3, 5, 9, 1, 4, 7, 8, 1, 3, 1, 5, 2, 3, 9, 2 }; //0x11C58 (ST3)
    private FUN_11C70[] PTR_FUN_11C70; //0x11C70 (ST3)
    private FUN_11C80[] PTR_FUN_11C80; //0x11C80 (ST3)
    private Vector3Int[] DAT_11C90 = new Vector3Int[] //0x11C90 (ST3)
    {
        new Vector3Int(-2320, -1230, -3900), new Vector3Int(-2610, -1230, -3900),
        new Vector3Int(-2900, -1230, -3900), new Vector3Int(-3190, -1230, -3900),
        new Vector3Int(-3480, -1230, -3900), new Vector3Int(-4390, -1075, 2600)
    };
    private short[] DAT_11CB4 = new short[] { -2290, -2580, -2870, -3160 };
    private FUN_11CBC[] PTR_FUN_11CBC; //0x11CBC (ST3)
    private FUN_11CCC[] PTR_FUN_11CCC; //0x11CCC (ST3)
    private UNK_11CD8[] DAT_11CD8 = new UNK_11CD8[] //0x11CD8 (ST3)
    {
        new UNK_11CD8
        {
            DAT_00=0x80118A38, 
            DAT_04=1
        }, 
        new UNK_11CD8
        {
            DAT_00=0, 
            DAT_04=1
        }, 
        new UNK_11CD8
        {
            DAT_00=0x80118A40, 
            DAT_04=1
        }
    }; 
    private FUN_11CF0[] PTR_FUN_11CF0; //0x11CF0 (ST3)
    private FUN_11CFC[] PTR_FUN_11CFC; //0x11CFC (ST3)
    private uint[] DAT_11D08 = new uint[] //0x11D08 (ST3)
    {
        0x8011d168, 0x8011d178, 0x8011d180, 0x8011d188,
        0x8011d190, 0x8011d1a0, 0x8011d1a8, 0x8011d1b0,
        0x8011d1b8, 0x8011d1c0, 0x8011d1f0
    };
    private FUN_11D34[] PTR_FUN_11D34; //0x11D34 (ST3)
    private uint[] DAT_11D44 = new uint[] //0x11D44 (ST3)
    {
        0x8010eef0, 0x8010f028, 0x8010f040, 0x8010f058,
        0x8010f068, 0x8010f078, 0x8010ef38, 0x8010efb0
    };
    private FUN_11D64[] PTR_FUN_11D64; //0x11D64 (ST3)
    private UNK_123CC[] DAT_123CC; //0x123CC (ST3)
    private CapsuleCollider[] DAT_123E4; //0x123E4 (ST3)
    private byte[] DAT_12408 = new byte[] { 48, 49 }; //0x12408 (ST3)
    private byte[] DAT_1240C = new byte[] { 50, 51 }; //0x1240C (ST3)
    private CriInteract.FUN_0C FUN_12418; //0x12418 (ST3)
    private CriInteract.FUN_0C FUN_124CC; //0x124CC (ST3)
    private FUN_12678[] PTR_FUN_12678; //0x12678 (ST3)
    private byte[] DAT_12680 = new byte[] { 56, 57 }; //0x12680 (ST3)
    private FUN_12684[] PTR_FUN_12684; //0x12684 (ST3)
    private FUN_12694[] PTR_FUN_12694; //0x12694 (ST3)
    private int[] DAT_1269C = new int[] { 5, 5 }; //0x1269C (ST3)
    private FUN_126A4[] PTR_FUN_126A4; //0x126A4 (ST3)
    private byte[] DAT_126AC = new byte[] { 54, 55 }; //0x126AC (ST3)
    private int[] DAT_126B0 = new int[] { 13, 3, 8 }; //0x126B0 (ST3)
    private FUN_126BC[] PTR_FUN_126BC; //0x126BC (ST3)
    private FUN_126CC[] PTR_FUN_126CC; //0x126CC (ST3)
    private FUN_126D8[] PTR_FUN_126D8; //0x126D8 (ST3)
    private FUN_126E0[] PTR_FUN_126E0; //0x126E0 (ST3)
    private FUN_12704[] PTR_FUN_12704; //0x12704 (ST3)
    private FUN_12754[] PTR_FUN_12754; //0x12754 (ST3)
    private FUN_12768[] PTR_FUN_12768; //0x12768 (ST3)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_11C70 = new FUN_11C70[4]
            {
                FUN_3F0,
                FUN_464,
                FUN_678,
                FUN_60068
            };
            PTR_FUN_11C80 = new FUN_11C80[4]
            {
                FUN_14E4_2, 
                FUN_1104, 
                FUN_1314, 
                FUN_60068
            };
            PTR_FUN_11CBC = new FUN_11CBC[4]
            {
                FUN_1520,
                FUN_17F8,
                FUN_1998,
                FUN_60068
            };
            PTR_FUN_11CCC = new FUN_11CCC[3]
            {
                FUN_1DBC,
                FUN_1E48,
                FUN_60068
            };
            PTR_FUN_11CF0 = new FUN_11CF0[3]
            {
                FUN_1EC4,
                FUN_1F4C,
                FUN_60068
            };
            PTR_FUN_11CFC = new FUN_11CFC[3]
            {
                FUN_209C,
                FUN_20F8,
                FUN_60068
            };
            PTR_FUN_11D34 = new FUN_11D34[3]
            {
                FUN_21D0,
                FUN_2278,
                FUN_60068
            };
            PTR_FUN_11D64 = new FUN_11D64[3]
            {
                FUN_2344,
                FUN_243C,
                FUN_60068
            };
            PTR_FUN_12678 = new FUN_12678[2]
            {
                FUN_43C8,
                FUN_4410
            };
            PTR_FUN_12684 = new FUN_12684[4]
            {
                FUN_45C4,
                FUN_4664,
                FUN_46D4,
                FUN_4738
            };
            PTR_FUN_12694 = new FUN_12694[2]
            {
                FUN_484C,
                FUN_48B8
            };
            PTR_FUN_126A4 = new FUN_126A4[2]
            {
                FUN_49F4,
                FUN_4B0C
            };
            PTR_FUN_126BC = new FUN_126BC[4]
            {
                FUN_5300,
                FUN_53F8,
                FUN_54D4,
                FUN_5678
            };
            PTR_FUN_126CC = new FUN_126CC[3]
            {
                FUN_58A0,
                FUN_592C,
                FUN_5A2C
            };
            PTR_FUN_126D8 = new FUN_126D8[2]
            {
                FUN_5A78,
                FUN_5AB0
            };
            PTR_FUN_126E0 = new FUN_126E0[9]
            {
                FUN_4CE0,
                FUN_525C,
                FUN_4334,
                FUN_4590,
                FUN_40D0,
                FUN_40D0,
                FUN_4EA8,
                FUN_40D0, 
                FUN_40D0
            };
            PTR_FUN_12704 = new FUN_12704[9]
            {
                FUN_4DAC,
                FUN_57B0,
                FUN_4554,
                FUN_4810,
                FUN_4C60,
                FUN_49B8,
                FUN_50C0,
                FUN_5A3C,
                FUN_5B54
            };
            PTR_FUN_12754 = new FUN_12754[]
            {
                FUN_4104,
                FUN_5B90
            };
            PTR_FUN_12768 = new FUN_12768[2]
            {
                FUN_677C,
                FUN_67F8
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

    //FUN_1A4 (ST3)
    public override void Initialize()
    {
        bool bVar1;
        TriggerData puVar2;
        uint uVar3;
        CriTrigger puVar4;

        base.Initialize();
        PTR_FUN_B58BC = DAT_11B40;
        PTR_FUN_B58C0 = DAT_11B98;
        PTR_FUN_C2570 = DAT_11BC0;
        PTR_FUN_C1CF8 = DAT_11BE0;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_11AB0[uVar3];
        GameManager.instance.DAT_B0 = DAT_11674;
        GameManager.instance.DAT_46 = 3;
        bVar1 = InventoryManager.FUN_4A87C(0, 0x5d);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_118D0.TRIGGERS.Length; i++)
            {
                puVar4 = LevelManager.instance.DAT_9EEC[i];
                puVar2 = DAT_118D0.TRIGGERS[i];
                puVar4.DAT_00 = puVar2.DAT_00;
                puVar4.DAT_01 = puVar2.DAT_01;
                puVar4.DAT_02 = puVar2.DAT_02;
                puVar4.DAT_03 = puVar2.DAT_03;
                puVar4.DAT_04 = puVar2.DAT_04;
                puVar4.DAT_0A = puVar2.DAT_0A;
                puVar4.DAT_0C = puVar2.DAT_0C;
                puVar4.DAT_0E = puVar2.DAT_0E;
                puVar4.DAT_10 = puVar2.DAT_10;
                puVar4.DAT_12 = puVar2.DAT_12;
                puVar4.DAT_14 = puVar2.DAT_14;
                puVar4.DAT_16 = puVar2.DAT_16;
            }
        }
        else
        {
            for (int i = 0; i < DAT_119C0.TRIGGERS.Length; i++)
            {
                puVar4 = LevelManager.instance.DAT_9EEC[i];
                puVar2 = DAT_119C0.TRIGGERS[i];
                puVar4.DAT_00 = puVar2.DAT_00;
                puVar4.DAT_01 = puVar2.DAT_01;
                puVar4.DAT_02 = puVar2.DAT_02;
                puVar4.DAT_03 = puVar2.DAT_03;
                puVar4.DAT_04 = puVar2.DAT_04;
                puVar4.DAT_0A = puVar2.DAT_0A;
                puVar4.DAT_0C = puVar2.DAT_0C;
                puVar4.DAT_0E = puVar2.DAT_0E;
                puVar4.DAT_10 = puVar2.DAT_10;
                puVar4.DAT_12 = puVar2.DAT_12;
                puVar4.DAT_14 = puVar2.DAT_14;
                puVar4.DAT_16 = puVar2.DAT_16;
            }
        }

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 3);
        //...
    }

    //FUN_3F0 (ST3)
    private void FUN_3F0(CriParticle param1)
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

    //FUN_464 (ST3)
    private void FUN_464(CriParticle param1)
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

                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_57C;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_588;
        }

        LAB_57C:
        param1.DAT_69 = 1;

        LAB_588:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            param1.DAT_6C[param1.DAT_68] = DAT_11C4C[(sbyte)param1.DAT_6A * 3 + (sbyte)param1.DAT_69];
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

    //FUN_678 (ST3)
    private void FUN_678(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.DAT_6C[uVar1] != DAT_11C58[param1.DAT_2F * 4 + uVar1])
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

    //FUN_1104 (ST3)
    private void FUN_1104(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic oVar5;
        Vector3Int local_28;
        Vector3Int local_30;
        Vector3Int local_38;
        Matrix3x3 auStack_58;

        oVar4 = (CriStatic)param1.PTR_68[0];
        oVar5 = (CriStatic)param1.PTR_68[1];
        bVar3 = InventoryManager.FUN_4A87C(3, 0x2c);

        if (bVar3)
        {
            bVar1 = param1.DAT_75;
            param1.DAT_75 = (byte)(bVar1 + 1);

            if (5 < bVar1)
            {
                GameManager.instance.FUN_5C94C(oVar4, 145);
                InventoryManager.FUN_4A7E8(3, 0x2c, false);
                param1.DAT_75 = 0;
            }
        }

        local_28 = new Vector3Int(0, (sbyte)param1.DAT_74 << 6, 0);
        auStack_58 = new Matrix3x3();
        Utilities.RotMatrix(ref local_28, ref auStack_58);
        local_38 = new Vector3Int(oVar4.VDAT_74.x, oVar4.screen.y, oVar4.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack_58, ref local_38);
        oVar4.screen.x = local_30.x + param1.DAT_70.x;
        oVar4.screen.z = local_30.z + param1.DAT_70.y;
        local_38 = new Vector3Int(oVar5.VDAT_74.x, oVar5.screen.y, oVar5.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack_58, ref local_38);
        oVar5.screen.x = local_30.x + param1.DAT_70.x;
        oVar5.screen.z = local_30.z + param1.DAT_70.y;
        sVar2 = (sbyte)(param1.DAT_74 + 1);
        param1.DAT_74 = (byte)sVar2;

        if (sVar2 == 28)
            GameManager.instance.FUN_5C94C(oVar4, 152);
        
        if (32 < (sbyte)param1.DAT_74)
        {
            param1.DAT_3C++;
            oVar4.screen.x = oVar5.VDAT_74.x + param1.DAT_70.x;
            oVar4.screen.z = oVar5.VDAT_74.y + param1.DAT_70.y;
            oVar5.screen.x = oVar4.VDAT_74.x + param1.DAT_70.x;
            oVar5.screen.z = oVar4.VDAT_74.y + param1.DAT_70.y;
        }
    }

    //FUN_1314 (ST3)
    private void FUN_1314(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        bool bVar5;
        int iVar5;
        int piVar6;
        CriStatic[] local_30 = new CriStatic[5];

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        piVar6 = 0;

        do
        {
            local_30[piVar6] = SceneManager.instance.staticObjects[piVar6];
            piVar6++;
        } while (piVar6 < 5);

        oVar4 = local_30[4];
        oVar3 = local_30[3];
        iVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, (uint)iVar5 + 0x24, false);
            iVar5++;
        } while (iVar5 < 4);

        if ((sbyte)oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, (uint)(sbyte)oVar4.DAT_78 + 0x24, true);

        if (GameManager.instance.DAT_9AA0 == 0x601 && oVar4.DAT_78 == 4)
        {
            bVar5 = InventoryManager.FUN_4A87C(0, 0xb5);

            if (bVar5)
            {
                oVar4.DAT_78 = oVar3.DAT_78;
                oVar3.DAT_78 = 4;
                sVar1 = (short)local_30[3].screen.x;
                sVar2 = (short)local_30[3].screen.z;
                local_30[3].screen.x = local_30[4].screen.x;
                local_30[3].screen.z = local_30[4].screen.z;
                local_30[4].screen.x = sVar1;
                local_30[4].screen.z = sVar2;
            }
        }

        iVar5 = 0;
        piVar6 = 0;

        while (iVar5 != 4)
        {
            iVar5++;

            if (local_30[piVar6].DAT_79 != local_30[piVar6].DAT_78)
                goto LAB_14AC;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_14AC;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_14AC:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_14E4 (ST3)
    private void FUN_14E4_2(CriParticle param1)
    {
        PTR_FUN_11CBC[param1.DAT_3C](param1);
    }

    //FUN_1520 (ST3)
    private void FUN_1520(CriParticle param1)
    {
        byte bVar2;
        bool bVar4;
        int iVar4;
        int piVar5;
        int iVar6;
        CriStatic oVar6;
        sbyte sVar7;
        int iVar8;
        int piVar9;
        CriStatic[] local_48 = new CriStatic[5];
        byte[] local_34 = new byte[24];

        iVar8 = 0;
        piVar9 = 0;
        System.Array.Copy(DAT_28, local_34, 24);
        System.Array.Copy(SceneManager.instance.staticObjects, local_48, 5);
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.screen.y = -1350;
        param1.screen.z = -3800;
        param1.DAT_50.a |= 2;
        param1.flags &= 0xfffffffd;
        bVar4 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (!bVar4)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x20);

            if (!bVar4)
            {
                bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

                if (!bVar4)
                {
                    bVar4 = InventoryManager.FUN_4A87C(3, 0x22);

                    if (bVar4)
                        iVar8 = 4;
                }
                else
                {
                    bVar4 = InventoryManager.FUN_4A87C(0, 0x76);

                    if (!bVar4)
                    {
                        bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

                        if (bVar4)
                            iVar8 = 2;
                    }
                    else
                        iVar8 = 3;

                    param1.DAT_78 = 0;
                }
            }
            else
                iVar8 = 1;
        }
        else
        {
            iVar8 = 0;
            param1.DAT_78 = 3;
        }

        bVar4 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            piVar5 = 0;

            do
            {
                oVar6 = local_48[piVar5];
                bVar2 = local_34[piVar5 + iVar8 * 5];
                oVar6.DAT_79 = (byte)piVar5;
                oVar6.DAT_78 = bVar2;
                piVar5++;
            } while (piVar5 < 5);
        }

        iVar4 = 0;

        do
        {
            iVar6 = 0;
            piVar5 = 0;

            do
            {
                iVar6++;

                if (local_48[piVar5].DAT_78 == iVar4)
                {
                    param1.PTR_68[piVar9] = local_48[piVar5];
                    break;
                }

                piVar5++;
            } while (iVar6 < 5);

            iVar4++;
            piVar9++;

            if (3 < iVar4)
            {
                InventoryManager.FUN_4A7E8(3, 0x3e, false);
                InventoryManager.FUN_4A7E8(3, 0x2c, true);
                InventoryManager.FUN_4A7E8(3, 0x2d, true);
                sVar7 = (sbyte)(iVar8 + 1);

                if (iVar8 == 4)
                    sVar7 = 1;
                else if (2 < iVar8 + 1)
                    sVar7 = 2;

                param1.DAT_3C += (byte)sVar7;
                param1.DAT_7A = 0;
                param1.DAT_7B = 0;
                return;
            }
        } while (true);
    }

    //FUN_17F8 (ST3)
    private void FUN_17F8(CriParticle param1)
    {
        short sVar1;
        sbyte sVar2;
        CriStatic oVar3;
        CriStatic oVar4;

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        oVar4 = (CriStatic)param1.PTR_68[param1.DAT_78];
        oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 5];
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar4, 145);

            //if (oVar4.DAT_79 != 4)
                //; //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);
        oVar4.screen.y = sVar1;

        if (-1075 < sVar1)
        {
            oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar3.flags |= 2;
            oVar3.screen.y = -1075;
            GameManager.instance.FUN_5C860(145);

            if (oVar4.DAT_79 != 4)
                GameManager.instance.FUN_5C94C(oVar3, 146);

            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            InventoryManager.FUN_4A7E8(3, 0x2d, true);
            param1.DAT_78++;
            param1.DAT_7A = 0;

            if (3 < param1.DAT_78)
            {
                param1.DAT_3C += 2;
                InventoryManager.FUN_4A7E8(3, 0x3e, true);
            }
        }
    }

    //FUN_1998 (ST3)
    private void FUN_1998(CriParticle param1)
    {
        sbyte sVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        CriStatic oVar4;
        CriParticle oVar5;
        CriStatic oVar6;
        CriStatic oVar7;

        oVar6 = (CriStatic)param1.PTR_68[param1.DAT_78];
        oVar7 = SceneManager.instance.staticObjects[param1.DAT_78 + 5];
        bVar4 = InventoryManager.FUN_4A87C(3, 0x2c);

        if (bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x2c, false);

            if ((oVar6.flags & 2) != 0)
            {
                iVar4 = 0;

                do
                {
                    iVar4++;
                    oVar5 = SceneManager.instance.FUN_5FFA0();
                    oVar5.tags = 18;
                    oVar5.flags |= 2;
                    oVar5.screen = DAT_11C90[param1.DAT_78];
                    oVar5.DAT_4C = null;
                } while (iVar4 < 2);
            }
        }

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar6, 145);

            //if (oVar6.DAT_79 != 4)
            //; //FUN_1D988
        }

        sVar3 = (short)(oVar7.vr.z + 35);
        oVar7.vr.z = sVar3;

        if (0x400 < sVar3)
            oVar7.vr.z = 0x400;

        if ((oVar6.flags & 2) != 0)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x2d);

            if (!bVar4)
                param1.flags &= 0xfffffffd;
            else
                FUN_1C70(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-1075 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar4.flags |= 2;
            oVar6.screen.y = -1075;
            GameManager.instance.FUN_5C860(145);

            if (oVar4.DAT_79 != 4)
                GameManager.instance.FUN_5C94C(oVar4, 146);

            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            InventoryManager.FUN_4A7E8(3, 0x2d, true);
            param1.DAT_78++;
            param1.DAT_7A = 0;

            if (3 < param1.DAT_78)
            {
                param1.DAT_3C++;
                InventoryManager.FUN_4A7E8(3, 0x3e, true);
            }
        }
    }

    //FUN_1C70 (ST3)
    private void FUN_1C70(CriParticle param1)
    {
        sbyte sVar1;

        sVar1 = (sbyte)param1.DAT_7B;

        if (sVar1 == 1)
            param1.flags &= 0xfffffffd;
        else
        {
            if (1 < sVar1)
            {
                if (sVar1 != 2)
                    return;

                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a50));
                param1.flags |= 2;
                param1.screen.x = DAT_11CB4[param1.DAT_78] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a48));
            param1.flags |= 2;
            param1.screen.x = DAT_11CB4[param1.DAT_78];
        }

        param1.DAT_7B++;
    }

    //FUN_1DBC (ST3)
    private void FUN_1DBC(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3f;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.vr.y = 0x400;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a58));
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;
        param1.DAT_3C++;
    }

    //FUN_1E48 (ST3)
    private void FUN_1E48(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_1EC4 (ST3)
    private void FUN_1EC4(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11CD8[0].DAT_00));
        param1.DAT_69 = 1;
        param1.DAT_68 = DAT_11CD8[0].DAT_04;
        param1.DAT_3C++;
    }

    //FUN_1F4C (ST3)
    private void FUN_1F4C(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if (DAT_11CD8[param1.DAT_69].DAT_00 == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11CD8[param1.DAT_69].DAT_00));
            }

            bVar1 = DAT_11CD8[param1.DAT_69].DAT_04;
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;
            param1.DAT_68 = bVar1;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_209C (ST3)
    private void FUN_209C(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x801223cc));
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f33;
        param1.DAT_3C = 1;
        param1.DAT_50.a |= 2;
        param1.flags |= 2;
    }

    //FUN_20F8 (ST3)
    private void FUN_20F8(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_68;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_21D0 (ST3)
    private void FUN_21D0(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11D08[param1.DAT_2F]));
        param1.DAT_56 = 0x25;
        param1.DAT_54 = 0x7f36;
        param1.DAT_50.a |= 2;
        param1.vr.x = param1.DAT_68 << 4;
        param1.flags |= 2;
        param1.vr.z = param1.DAT_6A << 4;
        param1.vr.y = param1.DAT_69 << 4;
        sVar1 = 3;

        if (iVar2 != 1)
            sVar1 = (sbyte)(param1.DAT_3C + 1);

        param1.DAT_3C = (byte)sVar1;
    }

    //FUN_2278 (ST3)
    private void FUN_2278(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_6B;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_2344 (ST3)
    private void FUN_2344(CriParticle param1)
    {
        byte bVar1;
        int iVar2;

        bVar1 = param1.DAT_2F;
        param1.flags |= 2;

        if (bVar1 == 0 || (bVar1 < 8 && 5 < bVar1))
        {
            param1.DAT_56 = 0x67;
            param1.DAT_54 = 0x7f37;
            param1.DAT_50.r = param1.DAT_69;
            param1.DAT_50.g = param1.DAT_6A;
            param1.DAT_50.b = param1.DAT_6B;
        }
        else
        {
            param1.DAT_56 = 0x27;
            param1.DAT_54 = 0x7f38;
            param1.vr.z = param1.DAT_69 << 4;
        }

        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11D44[param1.DAT_2F]));

        if (iVar2 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_243C (ST3)
    private void FUN_243C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_40D0 (ST3)
    private void FUN_40D0(CriPlayer param1)
    {
        return;
    }

    //FUN_40D8 (ST3)
    private void FUN_40D8(CriPlayer param1)
    {
        if (param1.DAT_154.health < 0xfb)
        {
            param1.DAT_2F = 1;
            return;
        }

        param1.DAT_2F = 0;
    }

    //FUN_4104 (ST3)
    private void FUN_4104(CriPlayer param1)
    {
        CriSkinned oVar1;
        CriInteract pbVar2;
        CriInteract oVar3;
        int iVar4;

        param1.DAT_120 = 0;
        param1.PTR_120 = DAT_123E4;
        param1.DAT_130 = 0;
        param1.PTR_130 = DAT_123E4;
        param1.DAT_124 = 2;
        param1.PTR_124 = DAT_123E4;
        param1.DAT_12E = 1;
        param1.DAT_12F = 1;
        param1.DAT_3C++;
        param1.FUN_77784(1, param1.PTR_130[param1.DAT_130].radius);
        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.FUN_609C8(0, 0, 0);
        param1.FUN_66404(0, 0x800, 0xc00);
        param1.FUN_66460(true);
        oVar1 = SceneManager.instance.skinnedObjects[10];
        param1.DAT_3A = param1.DAT_2F;
        param1.DAT_154 = oVar1;
        param1.PDAT_1D4 = DAT_123CC[param1.DAT_3A].DAT_00;
        param1.DAT_1DA = DAT_123CC[param1.DAT_3A].DAT_04;
        param1.DAT_1A5 = 7;
        param1.DAT_140 |= 1;
        param1.PDAT_1C8 = null;
        iVar4 = 0;

        do
        {
            if (iVar4 < 10)
            {
                pbVar2 = SceneManager.instance.DAT_8FFC[iVar4];

                if ((pbVar2.DAT_00 & 1) != 0 && pbVar2.DAT_01 == 23)
                {
                    param1.PDAT_1C8 = pbVar2;
                    goto LAB_4264;
                }
                else
                {
                    iVar4++;
                    continue;
                }
            }

            LAB_4264:
            oVar3 = param1.PDAT_1C8;

            if (oVar3 != null)
            {
                oVar3.BDAT_09++;
                oVar3.BDAT_0A++;

                if ((oVar3.BDAT_08 & 4) == 0)
                {
                    oVar3.TDAT_0C = param1.cSkin;
                    oVar3.TDAT_10 = param1.DAT_98;
                    oVar3.BDAT_08 |= 4;
                }
            }

            if (param1.DAT_18E == 100)
            {
                param1.DAT_3D = 8;
                param1.DAT_120 = 0;
                param1.PTR_120 = null;
                param1.DAT_130 = 0;
                param1.PTR_130 = null;
                param1.DAT_11E |= 0x40;
                param1.DAT_144 &= 0x7fff;

                if (oVar3 != null)
                    oVar3.BDAT_0A--;
            }

            FUN_40D8(param1);
            param1.IDAT_1C4 = 0;
            return;
        } while (true);
    }

    //FUN_4334 (ST3)
    private void FUN_4334(CriPlayer param1)
    {
        if (param1.screen.y == 0)
        {
            if ((param1.DAT_1C0 & 1) == 0)
            {
                if (param1.DAT_2F == 1 && (param1.PDAT_1C8.DAT_08 & 2) != 0)
                {
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 1;
                    param1.DAT_3F = 0;
                    param1.FUN_609C8(13, 1, 0);
                    param1.IDAT_1C4 = 30;
                }
            }
            else
            {
                param1.DAT_3D = 6;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_43C8 (ST3)
    private void FUN_43C8(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(13, 1, 0);
        param1.FUN_65890();
    }

    //FUN_4410 (ST3)
    private void FUN_4410(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        int iVar5;
        CriSkinned oVar6;

        oVar6 = param1.DAT_154;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 80, sVar1);
        param1.vr.y += sVar2;
        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.screen.y = 0;
            uVar4 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
            bVar3 = Utilities.FUN_64C0C(param1.screen, oVar6.screen, (short)param1.vr.y, 0x200);

            if (bVar3 && param1.DAT_148 < 5)
            {
                param1.DAT_3D = 3;
                param1.DAT_3E = 0;
                return;
            }

            uVar4 = GameManager.FUN_64650();

            if ((uVar4 & 1) == 0)
                iVar5 = 3;
            else
                iVar5 = 13;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar4 = GameManager.FUN_64650();

            if ((0x40 >> (int)(uVar4 & 7) & 1) != 0)
            {
                uVar4 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_1240C[uVar4 & 1]);
            }
        }

        param1.FUN_65890();
    }

    //FUN_4554 (ST3)
    private void FUN_4554(CriPlayer param1)
    {
        PTR_FUN_12678[param1.DAT_3E](param1);
    }

    //FUN_4590 (ST3)
    private void FUN_4590(CriPlayer param1)
    {
        if (param1.screen.y == 0 && (param1.DAT_1C0 & 1) != 0)
        {
            param1.DAT_3D = 6;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_45C4 (ST3)
    private void FUN_45C4(CriPlayer param1)
    {
        uint uVar1;

        param1.DAT_40.y = -100;
        param1.SDAT_1CC = 8;
        param1.DAT_40.z = 160;
        param1.DAT_3E++;
        param1.FUN_609C8(4, 0, 0);
        uVar1 = GameManager.FUN_64650();
        GameManager.instance.FUN_5C94C(param1, DAT_12680[uVar1 & 1]);

        if (param1.DAT_2F == 0)
            param1.DAT_1C0 |= 0x20;
    }

    //FUN_4664 (ST3)
    private void FUN_4664(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.frame.DAT_01 == 12)
        {
            param1.DAT_1C0 |= 0x40;
            param1.DAT_3E++;
        }
    }

    //FUN_46D4 (ST3)
    private void FUN_46D4(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.frame.DAT_01 == 12)
        {
            param1.DAT_1C0 &= 0xffffffbf;
            param1.DAT_3E++;
        }
    }

    //FUN_4738 (ST3)
    private void FUN_4738(CriPlayer param1)
    {
        int iVar1;

        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.screen.y == 0)
        {
            param1.DAT_1C0 &= 0xffffffdf;

            if (param1.DAT_2F == 0)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 1;
                param1.DAT_3F = 0;
                param1.FUN_609C8(13, 1, 0);
                iVar1 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar1 + (iVar1 / 30) * -30 + 60);
            }
            else
            {
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_4810 (ST3)
    private void FUN_4810(CriPlayer param1)
    {
        PTR_FUN_12684[param1.DAT_3E](param1);
    }

    //FUN_484C (ST3)
    private void FUN_484C(CriPlayer param1)
    {
        CriInteract oVar1;

        oVar1 = param1.PDAT_1C8;
        param1.DAT_3E++;
        param1.FUN_609C8(6, 0, 0);

        if (param1.DAT_2F == 1)
            oVar1.BDAT_08 |= 2;
    }

    //FUN_48B8 (ST3)
    private void FUN_48B8(CriPlayer param1)
    {
        ushort uVar1;
        int iVar2;
        bool bVar2;
        CriInteract oVar3;

        oVar3 = param1.PDAT_1C8;
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            if (param1.DAT_2F == 0)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 1;
                param1.DAT_3F = 0;
                param1.FUN_609C8(13, 1, 0);
                iVar2 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar2 + (iVar2 / 30) * -30 + 60);
            }
            else
            {
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_40.z = 0;
                param1.DAT_40.y = 0;
                param1.DAT_120 = 0;
                param1.PTR_120 = DAT_123E4;
                uVar1 = (ushort)GameManager.FUN_64650();
                param1.DAT_112 = (short)(uVar1 & 0xf);
                oVar3.BDAT_08 &= 0xfd;
            }
        }

        param1.FUN_65890();
    }

    //FUN_49B8 (ST3)
    private void FUN_49B8(CriPlayer param1)
    {
        PTR_FUN_12694[param1.DAT_3E](param1);
    }

    //FUN_49F4 (ST3)
    private void FUN_49F4(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriPlayer oVar4;

        param1.DAT_3E++;
        param1.DAT_12C |= 0x10;
        oVar4 = (CriPlayer)param1.DAT_154;
        param1.FUN_609C8(DAT_126AC[param1.DAT_2E], 1, 0);
        GameManager.instance.PTR_FUN_148 = FUN_6818;
        oVar4.DAT_154 = param1;
        oVar4.DAT_1E0 = param1.DAT_98;
        oVar4.DAT_3C = 5;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        oVar4.DAT_98 = param1.DAT_98;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
        param1.vr.y = sVar1;
        param1.DAT_112 = 90;

        if (param1.DAT_2E == 0)
            param1.vr.y = param1.vr.y + 0x800 & 0xfff;
        else
            param1.vr.y = oVar4.vr.y;

        sVar2 = (short)(oVar4.health - 5);
        oVar4.health = sVar2;

        if (sVar2 < 10)
            oVar4.health = 10;

        param1.IDAT_1C4 = 20;
    }

    //FUN_4B0C (ST3)
    private void FUN_4B0C(CriPlayer param1)
    {
        short sVar1;
        sbyte sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;
        param1.FUN_60AB4();
        sVar3 = param1.DAT_112;

        if (sVar3 < 1)
        {
            if (oVar5.frame.DAT_01 == 0x18)
            {
                param1.DAT_3D = 5;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_12C &= 0xffef;
                param1.SetSkeletonPrevious(param1);
                GameManager.instance.DAT_922C &= (byte)~(1 << (param1.DAT_2E & 31));
                sVar2 = (sbyte)(GameManager.instance.DAT_922D - 1);
                GameManager.instance.DAT_922D = (byte)sVar2;

                if (sVar2 == 0)
                    oVar5.DAT_3D++;

                oVar5.FUN_4FE30();
            }
        }
        else
        {
            bVar4 = GameManager.FUN_64C68();
            sVar1 = -5;

            if (!bVar4)
                sVar1 = -1;

            param1.DAT_112 = (short)(sVar3 + sVar1);
        }

        iVar4 = param1.IDAT_1C4 - 1;

        if (param1.IDAT_1C4 == 0)
        {
            sVar3 = (short)(oVar5.health - 5);
            oVar5.health = sVar3;

            if (sVar3 < 10)
                oVar5.health = 10;

            iVar4 = 20;
        }

        param1.IDAT_1C4 = iVar4;
    }

    //FUN_4C60 (ST3)
    private void FUN_4C60(CriPlayer param1)
    {
        CriSkinned oVar1;
        CriObject oVar2;

        oVar1 = param1.DAT_154;
        PTR_FUN_126A4[param1.DAT_3E](param1);
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, 8);
        param1.DAT_14C = oVar2.screen;
    }

    //FUN_4CE0 (ST3)
    private void FUN_4CE0(CriPlayer param1)
    {
        uint uVar1;
        CriInteract oVar2;

        Utilities.FUN_63160(param1.screen, param1.DAT_154.screen);
        oVar2 = param1.PDAT_1C8;

        if (param1.DAT_148 < 0x10)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            oVar2.BDAT_08 |= 8;
        }
        else if ((oVar2.BDAT_08 & 8) != 0)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
        }

        if (param1.DAT_3A != 1 && param1.frame.DAT_01 == 0x18)
        {
            uVar1 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_126AC[uVar1 & 1]);
        }
    }

    //FUN_4DAC (ST3)
    private void FUN_4DAC(CriPlayer param1)
    {
        byte bVar1;
        sbyte sVar2;
        uint uVar3;
        bool bVar4;
        int iVar5;

        bVar1 = param1.DAT_3E;

        if (bVar1 == 1)
        {
            bVar4 = param1.FUN_60AB4();

            if (!bVar4)
                return;

            uVar3 = GameManager.FUN_64650();

            if ((uVar3 & 0x40) == 0)
                return;

            iVar5 = 9;
            sVar2 = (sbyte)(param1.DAT_3E + 1);
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 != 0)
                    return;

                param1.DAT_3E = 1;
                uVar3 = GameManager.FUN_64650();
                param1.FUN_6103C(1, 1, (byte)(uVar3 & 0xf), 10);
                return;
            }

            if (bVar1 != 2)
                return;

            bVar4 = param1.FUN_60AB4();

            if (!bVar4)
                return;

            iVar5 = 1;
            sVar2 = (sbyte)(param1.DAT_3E - 1);
        }

        param1.DAT_3E = (byte)sVar2;
        param1.FUN_609C8(iVar5, 1, 10);
    }

    //FUN_4EA8 (ST3)
    private void FUN_4EA8(CriPlayer param1)
    {
        ushort uVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        int iVar5;
        Vector3Int puVar6;
        int iVar7;
        CriSkinned oVar7;
        Vector3Int local_20;

        local_20 = new Vector3Int(param1.screen.x, 0, param1.screen.z);
        oVar7 = param1.DAT_154;

        if ((param1.DAT_1C0 & 2) == 0)
        {
            iVar7 = (int)GameManager.FUN_64650();
            uVar4 = param1.DAT_1DA;

            if (uVar4 == 0)
                return; //trap(0x1c00)

            if (uVar4 == 0xffffffff && iVar7 == -0x80000000)
                return; //trap(0x1800)

            puVar6 = param1.PDAT_1D4[iVar7 % (int)uVar4];
            param1.DAT_158.x = puVar6.x;
            param1.DAT_158.z = puVar6.y;
            param1.SDAT_1D8 = (short)puVar6.z;
            param1.BDAT_1DC = (byte)(iVar7 % (int)uVar4);
            uVar4 = param1.DAT_1C0 | 2;
        }
        else
        {
            sVar2 = (short)Utilities.FUN_615EC(local_20, param1.DAT_10C);
            sVar3 = (short)Utilities.FUN_64838(param1.vr.y, 30, sVar2);
            param1.vr.y += sVar3;

            if (param1.DAT_148 != 0)
            {
                GameManager.instance.FUN_774CC(param1, oVar7.screen);
                uVar1 = param1.DAT_148;
                iVar5 = (int)GameManager.FUN_64650();
                iVar7 = iVar5;

                if (iVar5 < 0)
                    iVar7 = iVar5 + 7;

                if (uVar1 <= iVar5 + (iVar7 >> 3) * -8 + 0x10)
                    return;

                if (param1.screen.y != 0)
                    return;

                if (param1.DAT_2F == 0)
                {
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 1;
                    param1.DAT_3F = 0;
                }
                else
                {
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }

                param1.DAT_1DD = (byte)param1.PDAT_1C8.DAT_0B;
                param1.DAT_1C0 &= 0xfffffffc;
                param1.FUN_609C8(13, 1, 0);
                iVar7 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar7 + (iVar7 / 30) * -30 + 60);
                return;
            }

            param1.DAT_3D = 7;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_40.z = 0;
            uVar4 = param1.DAT_1C0 & 0xfffffffd;
        }

        param1.DAT_1C0 = uVar4;
    }

    //FUN_50C0 (ST3)
    private void FUN_50C0(CriPlayer param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        uint uVar4;

        bVar1 = param1.DAT_3E;

        if (bVar1 == 1)
        {
            bVar3 = param1.FUN_60AB4();

            if (bVar3)
            {
                param1.screen.y = 0;
                uVar4 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);

                if ((param1.DAT_1C0 & 2) != 0)
                {
                    GameManager.instance.FUN_774CC(param1, param1.DAT_158);

                    if (param1.DAT_148 < 4)
                    {
                        param1.DAT_3E++;
                        param1.FUN_609C8(8, 1, 10);
                        param1.DAT_40.y = 0;
                        param1.DAT_40.z = 70;
                        return;
                    }

                    uVar4 = GameManager.FUN_64650();
                    param1.FUN_609C8(DAT_126B0[uVar4 & 1], 0, 0);
                }
            }

            param1.FUN_65890();
        }
        else if (bVar1 < 2)
        {
            if (bVar1 == 0)
            {
                param1.DAT_3E = 1;
                param1.FUN_609C8(13, 0, 0);
            }
        }
        else if (bVar1 == 2)
        {
            param1.FUN_60AB4();
            sVar2 = (sbyte)param1.frame.DAT_01;

            if (sVar2 == 3 || sVar2 == 11)
            {
                uVar4 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
            }
        }
    }

    //FUN_525C (ST3)
    private void FUN_525C(CriPlayer param1)
    {
        byte bVar1;

        if (param1.DAT_3E != 0 && param1.screen.y == 0)
        {
            if (param1.DAT_2F == 1)
            {
                if (param1.IDAT_1C4 != 0)
                {
                    param1.IDAT_1C4--;
                    return;
                }

                bVar1 = 2;
            }
            else
            {
                bVar1 = 6;

                if ((uint)(byte)param1.PDAT_1C8.DAT_0B <= param1.DAT_1DD)
                {
                    if (param1.DAT_3E < 2)
                        return;

                    bVar1 = 2;

                    if (param1.DAT_112 != 0)
                    {
                        param1.DAT_112--;
                        return;
                    }
                }
            }

            param1.DAT_3D = bVar1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_5300 (ST3)
    private void FUN_5300(CriPlayer param1, CriPlayer param2)
    {
        int iVar2;
        bool bVar2;

        if (param1.DAT_3F == 0)
        {
            param1.FUN_609C8(2, 0, 10);
            param1.DAT_3F++;
        }
        else if (param1.DAT_3F == 1)
        {
            bVar2 = param1.FUN_60AB4();

            if (bVar2)
            {
                param1.DAT_3F = 0;
                param1.DAT_3E++;
                param1.FUN_609C8(13, 1, 0);
                param1.screen.y = 0;
                param1.UDAT_1D2 = (ushort)param2.vr.x;
            }

            iVar2 = (int)GameManager.FUN_64650();
            param2.DAT_112 = (short)(iVar2 + (iVar2 / 30) * -30 + 60);
        }
    }

    //FUN_53F8 (ST3)
    private void FUN_53F8(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        int iVar5;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.screen.y = 0;
            uVar4 = GameManager.FUN_64650();

            if ((uVar4 & 1) == 0)
                iVar5 = 3;
            else
                iVar5 = 13;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar4 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
        }

        param1.FUN_65890();
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 80, sVar1);
        param1.vr.y += sVar2;

        if (param1.DAT_148 < 6)
            param1.DAT_3E++;
    }

    //FUN_54D4 (ST3)
    private void FUN_54D4(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        ushort uVar2;
        int iVar3;
        bool bVar3;
        uint uVar4;
        int iVar5;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.screen.y = 0;
            uVar4 = GameManager.FUN_64650();
            iVar5 = 13;

            if ((uVar4 & 1) == 0)
                iVar5 = 3;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar4 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
        }

        param1.FUN_65890();

        if (param1.DAT_3F == 0)
        {
            iVar3 = param1.FUN_64804(param2.screen);

            if ((iVar3 + 0x300 & 0xfff) < 0x600)
                param1.UDAT_1D2 = (ushort)param1.vr.y;
        }

        sVar1 = (short)Utilities.FUN_64838(param1.vr.y, 80, param1.UDAT_1D2);
        param1.vr.y += sVar1;

        if (param1.DAT_142 == 0 && param1.DAT_12A == 0)
            param1.DAT_1D0 &= 0xfffffffe;
        else if ((param1.DAT_1D0 & 1) == 0)
        {
            param1.DAT_1D0 |= 1;
            param1.DAT_3F = 0;
            param1.UDAT_1D2 = (ushort)(param1.vr.y + 0x800 & 0xfff);

            if (param1.DAT_12A != 0)
                param1.DAT_3F = 1;
        }

        if (6 < param1.DAT_148)
        {
            param1.DAT_3E++;
            uVar2 = (ushort)Utilities.FUN_615EC(param1.screen, param2.screen);
            param1.UDAT_1D2 = uVar2;
        }

        if (11 < param1.DAT_148)
        {
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
        }
    }

    //FUN_5678 (ST3)
    private void FUN_5678(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;
        uint uVar3;
        short sVar4;
        int iVar5;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.screen.y = 0;
            uVar3 = GameManager.FUN_64650();
            iVar5 = 13;

            if ((uVar3 & 1) == 0)
                iVar5 = 4;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar3 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar3 & 1]);
        }

        param1.FUN_65890();
        param1.DAT_40.z = 0;
        sVar1 = (short)Utilities.FUN_64838(param1.vr.y, 80, param1.UDAT_1D2);
        param1.vr.y += sVar1;

        if (param1.DAT_40.x == 0)
        {
            uVar3 = GameManager.FUN_64650();
            sVar4 = 5;

            if ((uVar3 & 1) != 0)
                sVar4 = -5;

            param1.DAT_40.x = sVar4;
        }
        else
            param1.DAT_40.x = -param1.DAT_40.x;

        if (2 < param1.DAT_148 - 6U)
        {
            param1.DAT_3F = 1;
            param1.DAT_3E--;
            param1.UDAT_1D2 = (ushort)(param1.vr.y + 0x800 & 0xfff);
        }

        if (11 < param1.DAT_148)
        {
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
        }
    }

    //FUN_57B0 (ST3)
    private void FUN_57B0(CriPlayer param1)
    {
        uint uVar1;
        uint uVar2;
        int iVar3;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)param1.DAT_154;

        if (param1.DAT_3E != 0)
            param1.DAT_40.y += param1.SDAT_1CC;

        uVar1 = Utilities.FUN_63160(param1.screen, oVar3.screen);
        PTR_FUN_126BC[param1.DAT_3E](param1, oVar3);

        if (param1.frame.DAT_01 == 5)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == (iVar3 / 30) * 30)
            {
                uVar2 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_1240C[uVar2 & 1]);
            }
        }
    }

    //FUN_58A0 (ST3)
    private void FUN_58A0(CriPlayer param1)
    {
        param1.DAT_40.y = -60;
        param1.SDAT_1CC = 6;
        param1.DAT_120 = 0;
        param1.PTR_120 = null;
        param1.DAT_130 = 0;
        param1.PTR_130 = null;
        param1.DAT_40.z = 80;
        param1.DAT_3E++;
        param1.FUN_609C8(3, 1, 0);
        param1.vr.y = param1.SDAT_1D8;
        param1.DAT_11E |= 0x40;
        param1.DAT_144 &= 0x7fff;
    }

    private void FUN_592C(CriPlayer param1)
    {
        bool bVar1;
        CriInteract oVar1;
        CriInteract oVar2;
        
        bVar1 = param1.FUN_60AB4();

        if (!bVar1)
            param1.FUN_65890();
        else
        {
            oVar2 = param1.PDAT_1C8;
            oVar1 = null;

            if (oVar2 != null)
            {
                oVar2.DAT_14++;
                oVar2.BDAT_09--;
                oVar1 = oVar2;
            }

            oVar2 = SceneManager.instance.FUN_5FF08();

            if (oVar2 != null)
            {
                oVar2.DAT_01 = 24;
                oVar2.DAT_02 = 0;
                oVar2.DAT_04 = param1.DAT_3A;
                oVar2.DAT_05 = param1.BDAT_1DC;
                oVar2.TDAT_0C = param1.cSkin;
                oVar2.TDAT_10 = param1.DAT_98;
                oVar2.DAT_19 = (byte)oVar1.DAT_0B;
                oVar1.DAT_14--;
            }

            param1.FUN_6016C();
        }
    }

    //FUN_5A2C (ST3)
    private void FUN_5A2C(CriPlayer param1)
    {
        param1.DAT_40 = Vector3Int.zero;
    }

    //FUN_5A3C (ST3)
    private void FUN_5A3C(CriPlayer param1)
    {
        PTR_FUN_126CC[param1.DAT_3E](param1);
    }

    //FUN_5A78 (ST3)
    private void FUN_5A78(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(13, 0, 0);
    }

    //FUN_5AB0 (ST3)
    private void FUN_5AB0(CriPlayer param1)
    {
        bool bVar1;
        CriInteract oVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            oVar1 = param1.PDAT_1C8;

            if (oVar1 != null)
                oVar1.BDAT_08 |= 1;

            param1.DAT_120 = 0;
            param1.PTR_120 = DAT_123E4;
            param1.DAT_130 = 0;
            param1.PTR_130 = DAT_123E4;
            param1.DAT_144 |= 0x8000;
            param1.DAT_11E &= 0xbf;
            param1.DAT_13C = new Vector2Int(param1.screen.x, param1.screen.z);
        }

        param1.FUN_65890();
    }

    //FUN_5B54 (ST3)
    private void FUN_5B54(CriPlayer param1)
    {
        PTR_FUN_126D8[param1.DAT_3E](param1);
    }

    //FUN_5B90 (ST3)
    private void FUN_5B90(CriPlayer param1)
    {
        PTR_FUN_126E0[param1.DAT_3D](param1);
        PTR_FUN_12704[param1.DAT_3D](param1);
    }

    //FUN_62AC (ST3)
    private void FUN_62AC(CriPlayer param1)
    {
        ushort uVar1;
        CriInteract.FUN_0C dVar2;
        int iVar3;

        uVar1 = (ushort)((param1.DAT_1A1 << 8 | param1.DAT_1A0) >> 4 & 0xf);
        param1.DAT_11E &= 0x7f;

        if (uVar1 == 2)
        {
            dVar2 = FUN_12418;
            iVar3 = 9;
        }
        else
        {
            if (uVar1 < 3)
            {
                if (uVar1 != 1) goto LAB_6340;
            }
            else if (uVar1 != 3) goto LAB_6340;

            if ((param1.DAT_1A1 & 0xfU) - 2 < 4)
                return;

            dVar2 = FUN_124CC;
            iVar3 = 21;
        }

        SceneManager.instance.FUN_65D1C(param1, dVar2, (sbyte)iVar3);
        LAB_6340:
        param1.DAT_3C = 3;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_11E |= 0x40;
    }

    //FUN_677C (ST3)
    private void FUN_677C(CriPlayer param1)
    {
        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.DAT_40.x = 0;
            param1.DAT_40.z = 0;
            param1.FUN_609C8(12, 1, 10);
            GameManager.instance.FUN_5C94C(param1, 3);
        }
        else
            param1.FUN_60AB4();

        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_67F8 (ST3)
    private void FUN_67F8(CriPlayer param1)
    {
        param1.DAT_11E = 0;
        param1.DAT_3C = 1;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_152 = 0;
        param1.DAT_12C &= 0xffbf;
    }

    //FUN_3A4 (ST3)
    public static void FUN_3A4(CriParticle param1)
    {
        instance.PTR_FUN_11C70[param1.DAT_3C](param1);
        //FUN_728
    }

    //FUN_CF0 (ST3)
    public static void FUN_CF0(CriParticle param1)
    {
        instance.PTR_FUN_11C80[param1.DAT_3C](param1);
    }

    //FUN_14E4 (ST3)
    public static void FUN_14E4(CriParticle param1)
    {
        instance.PTR_FUN_11CBC[param1.DAT_3C](param1);
    }

    //FUN_1D80 (ST3)
    public static void FUN_1D80(CriParticle param1)
    {
        instance.PTR_FUN_11CCC[param1.DAT_3C](param1);
    }

    //FUN_1E88 (ST3)
    public static void FUN_1E88(CriParticle param1)
    {
        instance.PTR_FUN_11CF0[param1.DAT_3C](param1);
    }

    //FUN_203C (ST3)
    public static void FUN_203C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11CFC[param1.DAT_3C](param1);
    }

    //FUN_2170 (ST3)
    public static void FUN_2170(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11D34[param1.DAT_3C](param1);
    }

    //FUN_2308 (ST3)
    public static void FUN_2308(CriParticle param1)
    {
        instance.PTR_FUN_11D64[param1.DAT_3C](param1);
    }

    //FUN_6364 (ST3)
    public static void FUN_6364(CriPlayer param1)
    {
        CriSkinned oVar1;
        sbyte sVar2;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);
        oVar1 = SceneManager.instance.skinnedObjects[10];

        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            if (param1.DAT_3C == 0 || (param1.DAT_18E & 0x80) == 0)
            {
                param1.DAT_34 = param1.screen;

                if ((param1.DAT_1C0 & 2) == 0)
                {
                    param1.DAT_158.x = oVar1.screen.x;
                    param1.DAT_158.z = oVar1.screen.z;
                }

                sVar2 = GameManager.instance.FUN_774CC(param1, param1.DAT_158);
                param1.DAT_1DB = sVar2;

                if ((param1.DAT_11E & 0x80) != 0)
                    instance.FUN_62AC(param1);

                //...
            }
        }
    }

    //FUN_6818 (ST3)
    public static void FUN_6818(CriPlayer param1)
    {
        instance.PTR_FUN_12768[param1.DAT_3D](param1);
    }
}
