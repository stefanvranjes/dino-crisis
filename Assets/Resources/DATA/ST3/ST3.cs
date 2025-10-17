using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST3 : LevelManager
{
    public static new ST3 instance;

    private byte[] DAT_28 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4 };
    public FUN_B58BC[] DAT_11B40 = new FUN_B58BC[6] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08,
                                                      null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, FUN_464F8,
                                                      FUN_3A4, FUN_CF0 };
    public FUN_B58C0[] DAT_11B98 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 };
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
                FUN_14E4, 
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
    private void FUN_14E4(CriParticle param1)
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
}
