using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//0x800E8000
public class ST1 : LevelManager
{
    public static new ST1 instance;
    private uint[] DAT_04 = new uint[4] { 0x80132b5c, 0x80132bfc, 0x80132ca4, 0x80132d6c };
    private uint[] DAT_14 = new uint[] { 4, 5, 6, 7 };
    private byte[] DAT_18 = new byte[] { 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
    private byte[] DAT_38 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4 };
    public FUN_B58BC[] DAT_7624 = new FUN_B58BC[23] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                      FUN_45B08, FUN_270, FUN_46A1C, FUN_35C, FUN_468, null,
                                                      FUN_45D38, FUN_45E70, FUN_464F8, FUN_7CC, FUN_1324,
                                                      FUN_1B18, FUN_27EC, FUN_28F4, FUN_23B4 };
    public FUN_B58C0[] DAT_7680 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 }; //0x7680 (ST1)
    public FUN_C2570[] DAT_76A8 = new FUN_C2570[5] { FUN_4A26C, FUN_7F6F8, FUN_7F750, FUN_6C74, FUN_7F7E4 }; //0x76A8 (ST1)
    public FUN_C1CF8[] DAT_76C8 = new FUN_C1CF8[15] { FUN_20A98, FUN_20AA0, FUN_20AA8, FUN_20B0C, FUN_21758,
                                                      FUN_21ECC, FUN_22178, FUN_2DD8, FUN_51A8, FUN_66C4, 
                                                      FUN_222AC, FUN_22464, FUN_2268C, FUN_71F4, FUN_6B74 };
    public byte[][] DAT_7594 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 11, 27, 15, 13, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 6, 0, 0, 22, 26, 21, 21, 23, 31, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 }
    }; //0x7594 (ST1)
    public TrgScriptableObject DAT_74A4; //0x74A4 (ST1)
    private delegate void FUN_7704(CriParticle p); //0x7704 (ST1)
    private delegate void FUN_7710(CriParticle p); //0x7710 (ST1)
    private delegate void FUN_780C(CriParticle p); //0x780C (ST1)
    private delegate void FUN_7840(CriParticle p); //0x7840 (ST1)
    private delegate void FUN_7864(CriParticle p); //0x7864 (ST1)
    private delegate void FUN_78A0(CriParticle p); //0x78A0 (ST1)
    private delegate void FUN_78B0(CriParticle p); //0x78B0 (ST1)
    private delegate void FUN_78BC(CriParticle p); //0x78BC (ST1)
    private delegate void FUN_78E0(CriParticle p); //0x78E0 (ST1)
    public uint[] DAT_7230 = new uint[157] { 0x0, 0x20, 0x2d, 0x39, 0x3f, 0x80000042, 0x0, 0x16, 0x1c, 0x21, 0x33, 0x80000050, 0x0, 0x15, 0x22, 0x38, 0x8000004a, 0x0, 0x8, 0x1e, 0x30, 0x8000004b, 0x0, 0x16, 0x28, 0x3c, 0x8000005a, 0x0, 0xc, 0x16, 0x24, 0x34, 0x3c, 0x40, 0x80000052, 0x0, 0x5, 0x14, 0x34, 0x39, 0x8000004a, 0x0, 0x17, 0x1f, 0x39, 0x80000057, 0x0, 0x1b, 0x2e, 0x3c, 0x8000004b, 0x0, 0x10, 0x28, 0x3f, 0x80000064, 0x0, 0x14, 0x21, 0x3c, 0x8000005b, 0x0, 0xd, 0x16, 0x23, 0x28, 0x80000042, 0x0, 0x1a, 0x22, 0x38, 0x80000057, 0x0, 0xf, 0x1c, 0x2b, 0x38, 0x80000045, 0x0, 0x5, 0x1d, 0x31, 0x80000042, 0x0, 0x6, 0x18, 0x22, 0x3d, 0x80000048, 0x0, 0x1d, 0x21, 0x32, 0x80000046, 0x0, 0x3, 0x9, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x80000053, 0x0, 0x13, 0x1e, 0x2e, 0x32, 0x80000047, 0x0, 0x18, 0x28, 0x3b, 0x8000004a, 0x0, 0x10, 0x1b, 0x27, 0x31, 0x80000043, 0x0, 0xa, 0x15, 0x2b, 0x80000042, 0x0, 0x22, 0x33, 0x41, 0x8000005c, 0x0, 0x12, 0x18, 0x28, 0x34, 0x3f, 0x8000004b, 0x0, 0x6, 0xb, 0x16, 0x1e, 0x3b, 0x8000004d, 0x0, 0x14, 0x26, 0x3b, 0x80000051, 0x0, 0x1e, 0x2b, 0x40, 0x8000004d, 0x0, 0xc, 0x80000018 };
    public byte[] DAT_7AA0 = new byte[108] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1d, 0x0, 0x5f, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x16, 0xf0, 0x59, 0x1b, 0x0, 0x0, 0x0, 0xe8, 0x3, 0x0, 0x0, 0x1, 0x1b, 0xf7, 0x33, 0xf, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3d, 0xff, 0x2, 0x9, 0x0, 0x7, 0xf9, 0x0, 0x0, 0x0, 0x78, 0x0, 0xfa, 0x0, 0x2, 0x7, 0xff, 0x5, 0x4, 0x0, 0x0, 0x0, 0x27, 0x1, 0xc3, 0x0, 0x3, 0x13, 0x0, 0x3f, 0xe, 0x0, 0x0, 0x0, 0xda, 0x2, 0xed, 0xfe, 0x3, 0x1b, 0x0, 0x30, 0xf4, 0x0, 0x0, 0x0, 0x36, 0x6, 0x42, 0xff, 0x4, 0x1d, 0xf8, 0x29, 0xea, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x1b, 0x0, 0x5c, 0xe9, 0x0 };
    public sbyte[] DAT_7B44 = new sbyte[4];
    public byte DAT_7B49;
    public byte DAT_7B4A;
    public byte DAT_7B4B;
    public byte DAT_7B4C;
    public byte DAT_7B4D;
    private FUN_7704[] PTR_FUN_7704; //0x7704 (ST1)
    private FUN_7710[] PTR_FUN_7710; //0x7710 (ST1)
    private UNK_771C[] PTR_DAT_771C; //0x771C (ST1)
    private uint[] DAT_77F8 = new uint[4] { 0x8011d314, 0x8011d324, 0x8011d33c, 0x8011d344 }; //0x77F8 (ST1)
    private byte[] DAT_7808 = new byte[4] { 3, 1, 0, 0 }; //0x7808 (ST1)
    private FUN_780C[] PTR_FUN_780C; //0x780C (ST1)
    private byte[] DAT_7828; //0x7828 (ST1)
    private FUN_7840[] PTR_FUN_7840; //0x7840 (ST1)
    private FUN_7864[] PTR_FUN_7864; //0x7864 (ST1)
    private short[] DAT_7874 = new short[] { -2320, -1230, -3900, -2610, -1230, -3900, -2900, -1230, -3900, -3190, -1230, -3900, -3480, -1230, -3900, -4390, -1075, 2600, -2290, -2580, -2870, -3160 };
    private FUN_78A0[] PTR_FUN_78A0; //0x78A0 (ST1)
    private FUN_78B0[] PTR_FUN_78B0; //0x78B0 (ST1)
    private FUN_78BC[] PTR_FUN_78BC; //0x78BC (ST1)
    private FUN_78E0[] PTR_FUN_78E0; //0x78E0 (ST1)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_7704 = new FUN_7704[3]
            {
                FUN_2BC,
                FUN_31C,
                FUN_60068
            };
            PTR_FUN_7710 = new FUN_7710[3]
            {
                FUN_398,
                FUN_448,
                FUN_60068
            };
            PTR_DAT_771C = new UNK_771C[]
            {

            };
            PTR_FUN_780C = new FUN_780C[4]
            {
                FUN_4B4,
                FUN_5F8,
                FUN_71C,
                FUN_60068
            };
            PTR_FUN_7840 = new FUN_7840[4]
            {
                FUN_818,
                FUN_88C,
                FUN_AA0,
                FUN_60068
            };
            PTR_FUN_7864 = new FUN_7864[4]
            {
                FUN_1360,
                FUN_1738,
                FUN_1948,
                FUN_60068
            };
            PTR_FUN_78A0 = new FUN_78A0[4]
            {
                FUN_1B54,
                FUN_1E2C,
                FUN_1FCC,
                FUN_60068
            };
            PTR_FUN_78B0 = new FUN_78B0[3]
            {
                FUN_23F0,
                FUN_24A8,
                FUN_60068
            };
            PTR_FUN_78BC = new FUN_78BC[3]
            {
                FUN_2828,
                FUN_28B4,
                FUN_60068
            };
            PTR_FUN_78E0 = new FUN_78E0[3]
            {
                FUN_2930,
                FUN_29B8,
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

    //FUN_F4 (ST1)
    public override void Initialize()
    {
        bool bVar2;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();
        DAT_74A4 = Resources.Load<TrgScriptableObject>("DATA/ST1/ST1_01");
        PTR_FUN_B58BC = DAT_7624;
        PTR_FUN_B58C0 = DAT_7680;
        PTR_FUN_C2570 = DAT_76A8;
        PTR_FUN_C1CF8 = DAT_76C8;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_7594[uVar3];
        GameManager.instance.DAT_46 = 1;
        GameManager.instance.DAT_B0 = DAT_7230;

        for (int i = 0; i < DAT_74A4.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
            puVar5 = DAT_74A4.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 1);
        bVar2 = InventoryManager.FUN_4A87C(0, 0x22);

        if (!bVar2)
        {
            bVar2 = InventoryManager.FUN_4A87C(0, 0x23);

            if (!bVar2)
                LevelManager.instance.DAT_9EEC[2].DAT_03 |= 2;
        }

        bVar2 = InventoryManager.FUN_4A87C(0, 0x1e);

        if (!bVar2)
            LevelManager.instance.DAT_9EEC[1].DAT_03 |= 2;
    }

    //FUN_2BC (ST1)
    private void FUN_2BC(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010ee50));
        param1.DAT_56 = 103;
        param1.DAT_54 = 0x7ef0;
        param1.DAT_50.a |= 2;
        param1.DAT_3C++;
        param1.flags |= 2;
    }

    //FUN_31C (ST1)
    private void FUN_31C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_398 (ST1)
    private void FUN_398(CriParticle param1)
    {
        byte bVar1;
        ushort uVar2;
        uint[] local_20;

        local_20 = new uint[4];
        local_20[0] = ST1.instance.DAT_04[0];
        local_20[1] = ST1.instance.DAT_04[1];
        local_20[2] = ST1.instance.DAT_04[2];
        local_20[3] = ST1.instance.DAT_04[3];
        bVar1 = param1.DAT_2F;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(local_20[bVar1]));
        param1.DAT_56 = 37;
        param1.DAT_54 = 0x7f3c;

        if (bVar1 == 0)
            uVar2 = 12;
        else
            uVar2 = 8;

        param1.DAT_60 = uVar2;
        param1.DAT_62 = uVar2;
        param1.flags |= 2;
        param1.DAT_3C++;
    }

    //FUN_448 (ST1)
    private void FUN_448(CriParticle param1)
    {
        param1.FUN_606D8();
    }

    //FUN_4B4 (ST1)
    private void FUN_4B4(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;
        int iVar4;
        Vector3Int local_38;
        Vector3Int local_40;
        Matrix3x3 auStack48;

        iVar4 = param1.DAT_2F;
        bVar1 = DAT_7808[PTR_DAT_771C[iVar4].DAT_03];
        param1.DAT_54 = 0x7efa;
        param1.DAT_56 = (ushort)(bVar1 << 5 | 5);
        sVar2 = (sbyte)PTR_DAT_771C[iVar4].DAT_02;
        param1.DAT_50.a |= 2;
        param1.DAT_62 = (ushort)(short)sVar2;
        param1.DAT_60 = (ushort)(short)sVar2;
        bVar3 = PTR_DAT_771C[iVar4].DAT_01;
        param1.DAT_50.r = bVar3;
        param1.DAT_50.g = bVar3;
        param1.DAT_50.b = bVar3;
        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_40 = new Vector3Int(0, 0, PTR_DAT_771C[iVar4].DAT_04);
        local_40 = Utilities.ApplyMatrixSV(ref auStack48, ref local_40);
        param1.DAT_40.x = local_40.x;
        param1.DAT_40.y = PTR_DAT_771C[iVar4].DAT_06;
        param1.DAT_70.y = 0x10;
        param1.DAT_40.z = local_40.z;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_77F8[PTR_DAT_771C[iVar4].DAT_00]));
        param1.vr = new Vector3Int(0, 0, 0);
        param1.DAT_3C++;
    }

    //FUN_5F8 (ST1)
    private void FUN_5F8(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        int iVar3;

        if (0 < param1.screen.y)
        {
            param1.DAT_3C++;
            param1.DAT_60 >>= 1;
            iVar3 = param1.DAT_40.x << 0x10;
            param1.DAT_62 >>= 1;
            param1.DAT_40.x = (iVar3 >> 0x10) - (iVar3 >> 0x1f) >> 1;
            param1.screen.y = 0;
            iVar3 = param1.DAT_40.z << 0x10;
            sVar1 = PTR_DAT_771C[param1.DAT_2F].DAT_06;
            param1.DAT_40.z = (iVar3 >> 0x10) - (iVar3 >> 0x1f) >> 1;
            param1.DAT_40.y = sVar1;
        }

        sVar2 = PTR_DAT_771C[param1.DAT_2F].DAT_08;
        param1.DAT_40.y += param1.DAT_70.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.vr.z = param1.vr.z - sVar2 & 0xfff;
        param1.screen.y += param1.DAT_40.y;
        param1.FUN_606D8();
    }

    //FUN_71C (ST1)
    private void FUN_71C(CriParticle param1)
    {
        short sVar1;

        if (0 < param1.screen.y)
            param1.DAT_3C++;

        sVar1 = PTR_DAT_771C[param1.DAT_2F].DAT_08;
        param1.DAT_40.y += param1.DAT_70.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.vr.z = param1.vr.z - sVar1 & 0xfff;
        param1.screen.y += param1.DAT_40.y;
        param1.FUN_606D8();
    }

    //FUN_818 (ST1)
    private void FUN_818(CriParticle param1)
    {
        uint uVar2;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        uVar2 = 0;

        do
        {
            param1.PTR_6C[uVar2] = 0;
            uVar2++;
        } while (uVar2 < 8);

        param1.DAT_68 = 0;
        param1.DAT_69 = 0;
        param1.DAT_6A = 0;
        param1.DAT_3C++;
    }

    //FUN_88C (ST1)
    private void FUN_88C(CriParticle param1)
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

                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_9A4;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_9B0;
        }

        LAB_9A4:
        param1.DAT_69 = 1;

        LAB_9B0:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 147);

            if ((sbyte)param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.PTR_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_AA0 (ST1)
    private void FUN_AA0(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.PTR_6C[uVar1] != DAT_7828[param1.DAT_2F * 4 + uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 149);
                return;
            }

            bVar2++;
            uVar1 = (uint)bVar2;
        } while (bVar2 < 4);

        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_1360 (ST1)
    private void FUN_1360(CriParticle param1)
    {
        byte bVar3;
        int piVar4;
        int piVar5;
        bool bVar6;
        int iVar6;
        bool bVar7;
        int iVar7;
        int puVar8;
        CriStatic oVar9;
        CriStatic oVar10;
        byte[] local_38 = new byte[20];
        uint[] local_48 = new uint[4];
        CriStatic[] local_60 = new CriStatic[5];
        CriStatic[] local_78 = new CriStatic[5];

        iVar7 = 0;
        oVar10 = null;
        System.Array.Copy(DAT_14, local_48, 4);
        System.Array.Copy(DAT_18, local_38, 20);
        System.Array.Copy(SceneManager.instance.staticObjects, local_78, 5);
        oVar9 = SceneManager.instance.staticObjects[5];
        bVar6 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar6)
        {
            bVar6 = InventoryManager.FUN_4A87C(3, 0x21);

            if (!bVar6)
            {
                bVar6 = InventoryManager.FUN_4A87C(3, 0x22);

                if (bVar6)
                    iVar7 = 3;
            }
            else
            {
                bVar6 = InventoryManager.FUN_4A87C(0, 0x76);

                if (!bVar6)
                {
                    bVar6 = InventoryManager.FUN_4A87C(3, 0x21);

                    if (bVar6)
                        iVar7 = 1;
                }
                else
                    iVar7 = 2;
            }
        }
        else
            iVar7 = 0;

        bVar6 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar6)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            piVar4 = 0;

            do
            {
                local_78[piVar4].DAT_78 = local_38[piVar4 + iVar7 * 5];
                local_78[piVar4].DAT_79 = (byte)piVar4;
                piVar4++;
            } while (piVar4 < 5);
        }

        piVar4 = 0;

        do
        {
            piVar5 = 0;

            do
            {
                if (local_78[piVar5].DAT_78 == piVar4)
                {
                    local_60[piVar4] = local_78[piVar5];
                    break;
                }

                piVar5++;
            } while (piVar5 < 5);

            piVar4++;
        } while (piVar4 < 5);

        iVar6 = 0;
        puVar8 = 0;

        do
        {
            bVar7 = InventoryManager.FUN_4A87C(3, 0x3d);

            if (bVar7)
            {
                iVar6 = 3;
                break;
            }

            bVar7 = InventoryManager.FUN_4A87C(2, local_48[puVar8]);

            if (bVar7) break;

            iVar6++;
            puVar8++;
        } while (iVar6 < 4);

        if (iVar6 == 1)
        {
            bVar3 = 2;
            local_60[0] = local_60[1];
            local_60[3] = local_60[2];
            local_60[0].DAT_78 = bVar3;
            local_60[3].DAT_78 = (byte)iVar6;
            local_60[1] = local_60[3];
        }
        else
        {
            if (1 < iVar6)
            {
                if (iVar6 == 2)
                {
                    bVar3 = 3;
                    local_60[0] = local_60[2];
                }
                else
                {
                    bVar3 = 4;
                    local_60[0] = local_60[3];
                    local_60[3] = local_60[4];

                    if (iVar6 != 3)
                    {
                        param1.PTR_68[0] = oVar9;
                        goto LAB_1638;
                    }
                }

                local_60[0].DAT_78 = bVar3;
                local_60[3].DAT_78 = (byte)iVar6;
                local_60[1] = local_60[3];
                goto LAB_1634;
            }

            if (iVar6 != 0)
            {
                param1.PTR_68[0] = oVar9;
                goto LAB_1638;
            }

            local_60[0].DAT_78 = 1;
            local_60[1].DAT_78 = 0;
        }

        LAB_1634:
        param1.PTR_68[0] = local_60[0];
        oVar9 = local_60[0];
        oVar10 = local_60[1];
        LAB_1638:
        param1.PTR_68[1] = oVar10;

        if (oVar10 != null)
        {
            param1.DAT_70.x = (oVar9.screen.x + oVar10.screen.x) / 2;
            param1.DAT_70.y = (oVar9.screen.z + oVar10.screen.z) / 2;
            oVar9.VDAT_74.x = oVar9.screen.x - param1.DAT_70.x;
            oVar9.VDAT_74.y = oVar9.screen.z - param1.DAT_70.y;
            oVar10.VDAT_74.x = oVar10.screen.x - param1.DAT_70.x;
            oVar10.VDAT_74.y = oVar10.screen.z - param1.DAT_70.y;
            oVar9.DAT_4A = 970;
            oVar10.DAT_4A = 969;
            param1.DAT_74 = 0;
            param1.DAT_75 = 0;
            param1.DAT_3C++;
            InventoryManager.FUN_4A7E8(3, 0x3e, false);
            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            //FUN_1D988
        }
        else
        {
            param1.DAT_70.x = oVar9.screen.x / 2;
            param1.DAT_70.y = oVar9.screen.z / 2;
            oVar9.VDAT_74.x = oVar9.screen.x - param1.DAT_70.x;
            oVar9.VDAT_74.y = oVar9.screen.z - param1.DAT_70.y;
            oVar10.VDAT_74.x = -param1.DAT_70.x;
            oVar10.VDAT_74.y = -param1.DAT_70.y;
            oVar9.DAT_4A = 970;
            oVar10.DAT_4A = 969;
            param1.DAT_74 = 0;
            param1.DAT_75 = 0;
            param1.DAT_3C++;
            InventoryManager.FUN_4A7E8(3, 0x3e, false);
            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            //FUN_1D988
        }
    }

    //FUN_1738 (ST1)
    private void FUN_1738(CriParticle param1)
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

    //FUN_1948 (ST1)
    private void FUN_1948(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        int iVar5;
        uint uVar5;
        bool bVar5;
        int piVar6;
        CriStatic[] local_30 = new CriStatic[5];

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        piVar6 = 0;

        do
        {
            local_30[piVar6] = SceneManager.instance.staticObjects[piVar6];
            piVar6++;
        } while (piVar6 < 5);

        oVar3 = local_30[3];
        oVar4 = local_30[4];
        uVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, uVar5 + 0x24, false);
            uVar5++;
        } while (uVar5 < 4);

        if (oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, oVar4.DAT_78 + 0x24U, true);

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
                goto LAB_1AE0;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_1AE0;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_1AE0:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_1B54 (ST1)
    private void FUN_1B54(CriParticle param1)
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
        byte[] local_30 = new byte[24];

        iVar8 = 0;
        piVar9 = 0;
        System.Array.Copy(DAT_38, local_30, 24);
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

                    param1.SDAT_78 = 0;
                }
            }
            else
                iVar8 = 1;
        }
        else
        {
            iVar8 = 0;
            param1.SDAT_78 = 3;
        }

        bVar4 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            piVar5 = 0;

            do
            {
                oVar6 = local_48[piVar5];
                bVar2 = local_30[piVar5 + iVar8 * 5];
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

    //FUN_1E2C (ST1)
    private void FUN_1E2C(CriParticle param1)
    {
        short sVar1;
        sbyte sVar2;
        CriStatic oVar3;
        CriStatic oVar4;

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        oVar4 = (CriStatic)param1.PTR_68[param1.SDAT_78];
        oVar3 = SceneManager.instance.staticObjects[param1.SDAT_78 + 5];
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar4, 145);

            //if (oVar4.DAT_79 != 4)
              //  ; //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);
        oVar4.screen.y = sVar1;

        if (-0x433 < sVar1)
        {
            oVar3 = SceneManager.instance.staticObjects[param1.SDAT_78 + 9];
            oVar3.flags |= 2;
            oVar4.screen.y = -0x433;
            GameManager.instance.FUN_5C860(145);

            if (oVar4.DAT_79 != 4)
                GameManager.instance.FUN_5C94C(oVar3, 146);

            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            InventoryManager.FUN_4A7E8(3, 0x2d, true);
            param1.SDAT_78++;
            param1.DAT_7A = 0;

            if (3 < param1.SDAT_78)
            {
                param1.DAT_3C += 2;
                InventoryManager.FUN_4A7E8(3, 0x3e, true);
            }
        }
    }

    //FUN_1FCC (ST1)
    private void FUN_1FCC(CriParticle param1)
    {
        sbyte sVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        CriStatic oVar4;
        CriParticle oVar5;
        CriStatic oVar6;
        CriStatic oVar7;

        oVar6 = (CriStatic)param1.PTR_68[param1.SDAT_78];
        oVar7 = SceneManager.instance.staticObjects[param1.SDAT_78];
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
                    oVar5.tags = 0x12;
                    oVar5.flags |= 2;
                    oVar5.screen.x = DAT_7874[param1.SDAT_78 * 3];
                    oVar5.screen.y = DAT_7874[param1.SDAT_78 * 3 + 1];
                    oVar5.screen.z = DAT_7874[param1.SDAT_78 * 3 + 2];
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
                //  ; //FUN_1D988
        }

        sVar3 = (short)(oVar7.vr.z + 0x23);
        oVar7.vr.z = sVar3;

        if (0x400 < sVar3)
            oVar7.vr.z = 0x400;

        if ((oVar6.flags & 2) != 0)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x2d);

            if (!bVar4)
                param1.flags &= 0xfffffffd;
            else
                FUN_22A4(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-0x433 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.SDAT_78];
            oVar4.flags |= 2;
            oVar6.screen.y = -0x433;
            GameManager.instance.FUN_5C860(145);

            if (oVar6.DAT_79 != 4)
                GameManager.instance.FUN_5C94C(oVar4, 146);

            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            InventoryManager.FUN_4A7E8(3, 0x2d, true);
            param1.SDAT_78++;
            param1.DAT_7A = 0;

            if (3 < param1.SDAT_78)
            {
                param1.DAT_3C++;
                InventoryManager.FUN_4A7E8(3, 0x3e, true);
            }
        }
    }

    //FUN_22A4 (ST1)
    private void FUN_22A4(CriParticle param1)
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

                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80115450));
                param1.flags |= 2;
                param1.screen.x = DAT_7874[param1.SDAT_78] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80115448));
            param1.flags |= 2;
            param1.screen.x = DAT_7874[param1.SDAT_78];
        }

        param1.DAT_7B++;
    }

    //FUN_23F0 (ST1)
    private void FUN_23F0(CriParticle param1)
    {
        CriSkinned oVar2;
        Matrix3x3 auStack_38;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        param1.PTR_68[0] = oVar2;
        auStack_38 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack_38);
        local_18 = new Vector3Int(0, 0, 150);
        param1.VDAT_6C = Utilities.ApplyMatrixSV(ref auStack_38, ref local_18);
        param1.VDAT_6C.x += oVar2.screen.x;
        param1.VDAT_6C.y = oVar2.screen.y - 1000;
        param1.VDAT_6C.z += oVar2.screen.z;
        param1.DAT_3C++;
    }

    //FUN_24A8 (ST1)
    private void FUN_24A8(CriParticle param1)
    {
        bool bVar1;
        Vector3Int local_18;

        local_18 = new Vector3Int();
        local_18.x = param1.VDAT_6C.x;
        local_18.y = param1.PTR_68[0].screen.y - 1000;
        local_18.z = param1.VDAT_6C.z;
        param1.VDAT_6C.y = -2800;
        bVar1 = InventoryManager.FUN_4A87C(2, 0xd);

        if (!bVar1)
            param1.DAT_3C++;

        FUN_2528(param1.VDAT_6C, local_18);
    }

    //FUN_2528 (ST1)
    private void FUN_2528(Vector3Int param1, Vector3Int param2)
    {
        CriCamera cVar1;
        Vector3Int local_60;
        CriTransform local_58;

        local_58 = new CriTransform();
        local_58.rotation.V22 = 0x1000;
        local_58.rotation.V11 = 0x1000;
        local_58.rotation.V00 = 0x1000;
        local_58.rotation.V21 = 0;
        local_58.rotation.V20 = 0;
        local_58.rotation.V12 = 0;
        local_58.rotation.V10 = 0;
        local_58.rotation.V02 = 0;
        local_58.rotation.V01 = 0;
        GameManager.instance.DAT_30 = 0x4016282e;
        cVar1 = SceneManager.instance.cCamera;
        local_60 = new Vector3Int();
        local_60.x = param1.x - cVar1.DAT_30.x;
        local_60.y = param1.y - cVar1.DAT_30.y;
        local_60.z = param1.z - cVar1.DAT_30.z;
        local_58.position = Utilities.ApplyMatrixSV(ref cVar1.cTransform.rotation, ref local_60);
        local_58.position.x += cVar1.DAT_38;
        local_58.position.y += cVar1.DAT_3A;
        local_58.position.z += cVar1.DAT_3C;
        Utilities.SetRotMatrix(ref cVar1.cTransform.rotation);
        Utilities.SetTransMatrix(ref local_58);
        //RotTransPers
        local_60.x = param2.x - cVar1.DAT_30.x;
        local_60.y = param2.y - cVar1.DAT_30.y;
        local_60.z = param2.z - cVar1.DAT_30.z;
        local_58.position = Utilities.ApplyMatrixSV(ref cVar1.cTransform.rotation, ref local_60);
        local_58.position.x += cVar1.DAT_38;
        local_58.position.y += cVar1.DAT_3A;
        local_58.position.z += cVar1.DAT_3C;
        Utilities.SetRotMatrix(ref cVar1.cTransform.rotation);
        Utilities.SetTransMatrix(ref local_58);
        //RotTransPers
        //...
    }

    //FUN_2828 (ST1)
    private void FUN_2828(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3f;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.vr.y = 0x400;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80115458));
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;
        param1.DAT_3C++;
    }

    //FUN_28B4 (ST1)
    private void FUN_28B4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_2930 (ST1)
    private void FUN_2930(CriParticle param1)
    {
        Tod2ScriptableObject tVar1;

        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8(tVar1 = (Tod2ScriptableObject)Utilities.GetRamObject(0x800ef8c8));
        param1.DAT_69 = 1;
        param1.DAT_68 = tVar1.FRAMES[0].DAT_04;
        param1.DAT_3C++;
    }

    //FUN_29B8 (ST1)
    private void FUN_29B8(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;
        Tod2ScriptableObject tVar4;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            tVar4 = (Tod2ScriptableObject)Utilities.GetRamObject(0x800ef8c8);

            if (tVar4.FRAMES[param1.DAT_69].DAT_00 == 0 && tVar4.FRAMES[param1.DAT_69].DAT_01 == 0 &&
                tVar4.FRAMES[param1.DAT_69].DAT_02 == 0 && tVar4.FRAMES[param1.DAT_69].DAT_03 == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8(tVar4, param1.DAT_69);
            }

            bVar1 = tVar4.FRAMES[param1.DAT_69].DAT_04;
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;
            param1.DAT_68 = bVar1;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_6A9C (ST1)
    public void FUN_6A9C()
    {
        CriPlayer oVar1;
        CriPlayer puVar2;
        uint uVar4;

        uVar4 = 0;

        do
        {
            puVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[uVar4];

            if ((puVar2.flags & 1) != 0 && puVar2.DAT_3C != 3 && puVar2.DAT_3C != 5)
            {
                oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(puVar2);

                if (oVar1 == null)
                    puVar2.DAT_1C5 = 1;
                else
                {
                    if (oVar1.DAT_1C5 != 1)
                        puVar2.DAT_1C5 = 1;
                }

                puVar2.DAT_208 &= 0xfff3ffff;
            }

            uVar4++;
        } while (uVar4 < 10);
    }

    //FUN_2DD8 (ST1)
    public static void FUN_2DD8(CriInteract param1)
    {
        param1.FUN_2DD8();
    }

    //FUN_51A8 (ST1)
    public static void FUN_51A8(CriInteract param1)
    {
        param1.FUN_51A8();
    }

    //FUN_66C4 (ST1)
    public static void FUN_66C4(CriInteract param1)
    {
        param1.FUN_66C4();
    }

    //FUN_6B74 (ST1)
    public static void FUN_6B74(CriInteract param1)
    {
        param1.FUN_6B74();
    }

    //FUN_71F4 (ST1)
    public static void FUN_71F4(CriInteract param1)
    {
        param1.FUN_71F4();
    }

    //FUN_270 (ST1)
    public static void FUN_270(CriParticle param1)
    {
        instance.PTR_FUN_7704[param1.DAT_3C](param1);
        param1.FUN_630EC();
    }

    //FUN_35C (ST1)
    public static void FUN_35C(CriParticle param1)
    {
        instance.PTR_FUN_7710[param1.DAT_3C](param1);
    }

    //FUN_468 (ST1)
    public static void FUN_468(CriParticle param1)
    {
        instance.PTR_FUN_780C[param1.DAT_3C](param1);
        param1.FUN_630EC();
    }

    //FUN_7CC (ST1)
    public static void FUN_7CC(CriParticle param1)
    {
        instance.PTR_FUN_7840[param1.DAT_3C](param1);
        //FUN_B50
    }

    //FUN_1324 (ST1)
    public static void FUN_1324(CriParticle param1)
    {
        instance.PTR_FUN_7864[param1.DAT_3C](param1);
    }

    //FUN_1B18 (ST1)
    public static void FUN_1B18(CriParticle param1)
    {
        instance.PTR_FUN_78A0[param1.DAT_3C](param1);
    }

    //FUN_23B4 (ST1)
    public static void FUN_23B4(CriParticle param1)
    {
        instance.PTR_FUN_78B0[param1.DAT_3C](param1);
    }

    //FUN_27EC (ST1)
    public static void FUN_27EC(CriParticle param1)
    {
        instance.PTR_FUN_78BC[param1.DAT_3C](param1);
    }

    //FUN_28F4 (ST1)
    public static void FUN_28F4(CriParticle param1)
    {
        instance.PTR_FUN_78E0[param1.DAT_3C](param1);
    }

    //FUN_6C74 (ST1)
    public static void FUN_6C74(CriStatic param1)
    {
        param1.FUN_6C74();
    }
}
