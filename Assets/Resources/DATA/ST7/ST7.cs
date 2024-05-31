using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST7 : LevelManager
{
    public static new ST7 instance;

    private uint[] DAT_04 = new uint[] { 4, 5, 6, 7 };
    private byte[] DAT_14 = new byte[] { 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
    private byte[] DAT_28 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
    public uint[] DAT_11528 = new uint[151] { 0, 0xa, 0x11, 0x22, 0x31, 0x36, 0x80000046, 0x0, 0x16, 0x3a, 0x80000060, 0x0, 0x8, 0x17, 0x36, 0x8000005b, 0x0, 0xa, 0x18, 0x26, 0x2e, 0x36, 0x80000044, 0x0, 0x16, 0x80000046, 0x0, 0xc, 0x10, 0x1d, 0x21, 0x32, 0x3b, 0x80000044, 0x0, 0x6, 0x9, 0x22, 0x2e, 0x33, 0x80000047, 0x0, 0x1f, 0x24, 0x39, 0x8000004e, 0x0, 0x15, 0x1b, 0x20, 0x29, 0x36, 0x80000060, 0x0, 0x8, 0x16, 0x36, 0x80000047, 0x0, 0xe, 0x2f, 0x33, 0x80000040, 0x0, 0xd, 0x24, 0x32, 0x38, 0x80000045, 0x0, 0x7, 0xc, 0x12, 0x21, 0x27, 0x30, 0x39, 0x80000041, 0x0, 0x7, 0xf, 0x30, 0x80000042, 0x0, 0x12, 0x1a, 0x25, 0x39, 0x80000052, 0x0, 0x8, 0xb, 0x12, 0x18, 0x24, 0x30, 0x80000048, 0x0, 0x6, 0x17, 0x2b, 0x80000040, 0x0, 0x6, 0x2a, 0x31, 0x80000040, 0x0, 0xf, 0x24, 0x36, 0x8000003e, 0x0, 0x13, 0x2b, 0x8000004c, 0x0, 0x26, 0x37, 0x80000046, 0x0, 0x12, 0x26, 0x35, 0x8000004e, 0x0, 0x20, 0x27, 0x3b, 0x8000004a, 0x0, 0x10, 0x30, 0x3c, 0x80000050, 0x0, 0x8, 0x18, 0x29, 0x35, 0x3b, 0x80000047, 0x0, 0x12, 0x34, 0x80000044, 0x0, 0x1b, 0x25, 0x34, 0x80000043 };
    public TrgScriptableObject DAT_11784; //0x11784 (ST6)
    public byte[] DAT_11874 = new byte[48] { 29, 7, 10, 10, 27, 15, 13, 0, 32, 25, 20, 18, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 };
    public FUN_B58BC[] DAT_118A4 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08, 
                                                     null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, FUN_464F8, 
                                                     FUN_27C, FUN_BC8, FUN_13BC, FUN_1C58, FUN_1D60, FUN_21E0, FUN_1F14, 
                                                     FUN_2048 };
    public FUN_B58C0[] DAT_118FC = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, FUN_623C, null, null, 
                                                     null, null };
    public FUN_C2570[] DAT_11924 = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, null, 
                                                     FUN_7F808 };
    public FUN_C1CF8[] DAT_11944 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC, 
                                                     FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C, 
                                                     FUN_2650, FUN_2AC8, FUN_3300, FUN_39E8, FUN_3A24, null, 
                                                     FUN_3D54, FUN_672C, FUN_94FC, FUN_BED4, FUN_E5B4, FUN_E830, 
                                                     FUN_E86C, FUN_10844 };
    private delegate void FUN_119D4(CriParticle p); //0x119D4 (ST7)
    private delegate void FUN_119E4(CriParticle p); //0x119E4 (ST7)
    private delegate void FUN_11A20(CriParticle p); //0x11A20 (ST7)
    private delegate void FUN_11A30(CriParticle p); //0x11A30 (ST7)
    private delegate void FUN_11A54(CriParticle p); //0x11A54 (ST7)
    private delegate void FUN_11A60(CriParticle p); //0x11A60 (ST7)
    private delegate void FUN_11A98(CriParticle p); //0x11A98 (ST7)
    private delegate void FUN_11AC8(CriParticle p); //0x11AC8 (ST7)
    private FUN_119D4[] PTR_FUN_119D4; //0x119D4 (ST7)
    private FUN_119E4[] PTR_FUN_119E4; //0x119E4 (ST7)
    private short[] DAT_119F4 = new short[] { -2320, -1230, -3900, -2610, -1230, -3900, -2900, -1230, -3900, -3190, -1230, -3900, -3480, -1230, -3900, -4390, -1075, 2600 };
    private short[] DAT_11A18 = new short[] { -2290, -2580, -2870, -3160 };
    private FUN_11A20[] PTR_FUN_11A20; //0x11A20 (ST7)
    private FUN_11A30[] PTR_FUN_11A30; //0x11A30 (ST7)
    private uint[] DAT_11A3C = new uint[] { 0x80118a38, 0, 0x80118a40 }; //0x11A3C (ST7)
    private byte[] DAT_11A40 = new byte[] { 1, 1, 1 }; //0x11A40 (ST7)
    private FUN_11A54[] PTR_FUN_11A54; //0x11A54 (ST7)
    private FUN_11A60[] PTR_FUN_11A60; //0x11A60 (ST7)
    private uint[] DAT_11A6C = new uint[] { 0x8011d168, 0x8011d178, 0x8011d180, 0x8011d188, 0x8011d190, 0x8011d1a0, 0x8011d1a8, 0x8011d1b0, 0x8011d1b8, 0x8011d1c0, 0x8011d1f0 }; //0x11A6C (ST7)
    private FUN_11A98[] PTR_FUN_11A98; //0x11A98 (ST7)
    private uint[] DAT_11AA8 = new uint[] { 0x8010eef0, 0x8010f028, 0x8010f040, 0x8010f058, 0x8010f068, 0x8010f078, 0x8010ef38, 0x8010efb0 };
    private FUN_11AC8[] PTR_FUN_11AC8; //0x11AC8 (ST7)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_119D4 = new FUN_119D4[4]
            {
                FUN_2C8,
                FUN_33C,
                FUN_550,
                FUN_60068
            };
            PTR_FUN_119E4 = new FUN_119E4[4]
            {
                FUN_C04,
                FUN_FDC,
                FUN_11EC,
                FUN_60068
            };
            PTR_FUN_11A20 = new FUN_11A20[4]
            {
                FUN_13F8,
                FUN_16D0,
                FUN_1870,
                FUN_60068
            };
            PTR_FUN_11A30 = new FUN_11A30[3]
            {
                FUN_1C94,
                FUN_1D20,
                FUN_60068
            };
            PTR_FUN_11A54 = new FUN_11A54[3]
            {
                FUN_1D9C,
                FUN_1E24,
                FUN_60068
            };
            PTR_FUN_11A60 = new FUN_11A60[3]
            {
                FUN_1F74,
                FUN_1FD0,
                FUN_60068
            };
            PTR_FUN_11A98 = new FUN_11A98[3]
            {
                FUN_20A8,
                FUN_2150,
                FUN_60068
            };
            PTR_FUN_11AC8 = new FUN_11AC8[3]
            {
                FUN_221C,
                FUN_2314,
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

    //FUN_134 (ST7)
    public override void Initialize()
    {
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_118A4;
        PTR_FUN_B58C0 = DAT_118FC;
        PTR_FUN_C2570 = DAT_11924;
        PTR_FUN_C1CF8 = DAT_11944;
        SceneManager.instance.DAT_AC = DAT_11874;
        SceneManager.instance.DAT_B0 = DAT_11528;
        GameManager.instance.DAT_46 = 7;

        for (int i = 0; i < DAT_11784.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_11784.TRIGGERS[i];
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

    //FUN_2C8 (ST7)
    private void FUN_2C8(CriParticle param1)
    {
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        //...
        param1.DAT_68 = 0;
        param1.DAT_69 = 0;
        param1.DAT_6A = 0;
        param1.DAT_3C++;
    }

    //FUN_33C (ST7)
    private void FUN_33C(CriParticle param1)
    {
        sbyte sVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                if (param1.DAT_6A < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 145);
                    param1.DAT_6A++;
                }

                if (param1.DAT_6A != 3) goto LAB_460;

                goto LAB_454;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if ((sbyte)param1.DAT_6A == 3) goto LAB_454;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_460;

                goto LAB_454;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_460;

                goto LAB_454;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_460;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_460;
        }

        LAB_454:
        param1.DAT_69 = 1;
        
        LAB_460:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            //...
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
                InventoryManager.FUN_4A7E8(2, 0xb, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            //...
        }
    }

    //FUN_550 (ST7)
    private void FUN_550(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        param1.DAT_3C++;
        //...
        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_C04 (ST7)
    private void FUN_C04(CriParticle param1)
    {
        byte bVar1;
        int piVar2;
        int piVar3;
        int iVar4;
        bool bVar4;
        int iVar5;
        bool bVar5;
        int puVar6;
        CriStatic oVar7;
        CriStatic oVar8;
        CriStatic[] local_78;
        CriStatic[] local_60;
        uint[] local_48;
        byte[] local_38;

        iVar5 = 0;
        oVar8 = null;
        iVar4 = 0;
        piVar2 = 0;
        local_78 = new CriStatic[5];
        local_60 = new CriStatic[5];
        local_48 = new uint[4];
        local_38 = new byte[20];
        System.Array.Copy(DAT_04, local_48, 4);
        System.Array.Copy(DAT_14, local_38, 20);

        do
        {
            local_78[piVar2] = SceneManager.instance.DAT_7CDC[iVar4];
            piVar2++;
            iVar4++;
        } while (iVar4 < 5);

        oVar7 = SceneManager.instance.DAT_7CDC[5];
        bVar4 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar4)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

            if (!bVar4)
            {
                bVar4 = InventoryManager.FUN_4A87C(3, 0x22);

                if (bVar4)
                    iVar5 = 3;
            }
            else
            {
                bVar4 = InventoryManager.FUN_4A87C(0, 0x76);

                if (!bVar4)
                {
                    bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

                    if (bVar4)
                        iVar5 = 1;
                }
                else
                    iVar5 = 2;
            }
        }
        else
            iVar5 = 0;

        bVar4 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            iVar4 = 0;
            piVar2 = 0;

            do
            {
                local_78[piVar2].DAT_78 = local_38[iVar4 + iVar5 * 5];
                local_78[piVar2].DAT_79 = (byte)iVar4;
                iVar4++;
                piVar2++;
            } while (iVar4 < 5);
        }

        iVar4 = 0;
        piVar2 = 0;

        do
        {
            iVar5 = 0;
            piVar3 = 0;

            do
            {
                iVar5++;

                if (local_78[piVar3].DAT_78 == iVar4)
                {
                    local_60[piVar2] = local_78[piVar3];
                    break;
                }

                piVar3++;
            } while (iVar5 < 5);

            iVar4++;
            piVar2++;
        } while (iVar4 < 5);

        iVar4 = 0;
        puVar6 = 0;

        do
        {
            bVar5 = InventoryManager.FUN_4A87C(3, 0x3d);

            if (bVar5)
            {
                iVar4 = 3;
                break;
            }

            bVar5 = InventoryManager.FUN_4A87C(2, local_48[puVar6]);

            if (bVar5) break;

            iVar4++;
            puVar6++;
        } while (iVar4 < 4);

        if (iVar4 == 1)
        {
            bVar1 = 2;
            local_60[0] = local_60[1];
            local_60[3] = local_60[2];
            local_60[0].DAT_78 = bVar1;
            local_60[3].DAT_78 = (byte)iVar4;
            local_60[1] = local_60[3];
        }
        else
        {
            if (1 < iVar4)
            {
                if (iVar4 == 2)
                {
                    bVar1 = 3;
                    local_60[0] = local_60[2];
                }
                else
                {
                    bVar1 = 4;
                    local_60[0] = local_60[3];
                    local_60[3] = local_60[4];

                    if (bVar1 != 3)
                    {
                        param1.PTR_68[0] = oVar7;
                        goto LAB_EDC;
                    }
                }

                local_60[0].DAT_78 = bVar1;
                local_60[3].DAT_78 = (byte)iVar4;
                local_60[1] = local_60[3];
                goto LAB_ED8;
            }

            if (iVar4 != 0)
            {
                param1.PTR_68[0] = oVar7;
                goto LAB_EDC;
            }

            local_60[0].DAT_78 = 1;
            local_60[1].DAT_78 = 0;
        }

        LAB_ED8:
        param1.PTR_68[0] = local_60[0];
        oVar7 = local_60[0];
        oVar8 = local_60[1];
        LAB_EDC:
        param1.PTR_68[1] = oVar8;
        param1.DAT_70.x = (oVar7.screen.x + oVar8.screen.x) / 2;
        param1.DAT_70.y = (oVar7.screen.z + oVar8.screen.z) / 2;
        oVar7.VDAT_74.x = oVar7.screen.x - param1.DAT_70.x;
        oVar7.VDAT_74.y = oVar7.screen.z - param1.DAT_70.y;
        oVar8.VDAT_74.x = oVar8.screen.x - param1.DAT_70.x;
        oVar8.VDAT_74.y = oVar8.screen.z - param1.DAT_70.y;
        oVar7.DAT_4A = 970;
        oVar8.DAT_4A = 969;
        param1.DAT_74 = 0;
        param1.DAT_75 = 0;
        param1.DAT_3C++;
        InventoryManager.FUN_4A7E8(3, 0x3e, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, true);
        //FUN_1D988
    }

    //FUN_FDC (ST7)
    private void FUN_FDC(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic oVar5;
        Vector3Int local_38;
        Vector3Int local_30;
        Vector3Int local_28;
        Matrix3x3 auStack88;

        oVar4 = param1.PTR_68[0];
        oVar5 = param1.PTR_68[1];
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
        auStack88 = new Matrix3x3();
        Utilities.RotMatrix(ref local_28, ref auStack88);
        local_38 = new Vector3Int(oVar4.VDAT_74.x, oVar4.screen.y, oVar4.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack88, ref local_38);
        oVar4.screen.x = local_30.x + param1.DAT_70.x;
        oVar4.screen.z = local_30.z + param1.DAT_70.y;
        local_38 = new Vector3Int(oVar5.VDAT_74.x, oVar5.screen.y, oVar5.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack88, ref local_38);
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

    //FUN_11EC (ST7)
    private void FUN_11EC(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        bool bVar5;
        int iVar5;
        int piVar6;
        int iVar7;
        CriStatic[] local_30;

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        iVar7 = 0;
        piVar6 = 0;
        local_30 = new CriStatic[5];

        do
        {
            local_30[piVar6] = SceneManager.instance.DAT_7CDC[iVar7];
            piVar6++;
            iVar7++;
        } while (iVar7 < 5);

        oVar4 = local_30[4];
        oVar3 = local_30[3];
        iVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, (uint)iVar5 + 0x24, false);
            iVar5++;
        } while (iVar5 < 4);

        if (oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, (uint)(int)(sbyte)oVar4.DAT_78 + 0x24, true);

        if (GameManager.instance.DAT_9AA0 == 0x601 && oVar4.DAT_78 == 4)
        {
            bVar5 = InventoryManager.FUN_4A87C(0, 181);

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
                goto LAB_1384;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_1384;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_1384:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_13F8 (ST7)
    private void FUN_13F8(CriParticle param1)
    {
        int iVar2;
        bool bVar2;
        int piVar3;
        int iVar4;
        sbyte sVar5;
        int iVar6;
        int piVar7;
        CriStatic[] local_48;
        byte[] local_30;

        iVar6 = 0;
        piVar7 = 0;
        iVar4 = 0;
        piVar3 = 0;
        local_48 = new CriStatic[5];
        local_30 = new byte[25];
        System.Array.Copy(DAT_28, local_30, 25);
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.screen.x = -1350;
        param1.screen.z = -3800;
        param1.DAT_50.a |= 2;
        param1.flags &= 0xfffffffd;

        do
        {
            local_48[piVar3] = SceneManager.instance.DAT_7CDC[iVar4];
            piVar3++;
            iVar4++;
        } while (iVar4 < 5);

        bVar2 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (!bVar2)
        {
            bVar2 = InventoryManager.FUN_4A87C(3, 0x20);

            if (!bVar2)
            {
                bVar2 = InventoryManager.FUN_4A87C(3, 0x21);

                if (!bVar2)
                {
                    bVar2 = InventoryManager.FUN_4A87C(3, 0x22);

                    if (bVar2)
                        iVar6 = 4;
                }
                else
                {
                    bVar2 = InventoryManager.FUN_4A87C(0, 0x76);

                    if (!bVar2)
                    {
                        bVar2 = InventoryManager.FUN_4A87C(3, 0x21);

                        if (bVar2)
                            iVar6 = 2;
                    }
                    else
                        iVar6 = 3;

                    param1.SDAT_78 = 0;
                }
            }
            else
                iVar6 = 1;
        }
        else
        {
            iVar6 = 0;
            param1.SDAT_78 = 3;
        }

        bVar2 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar2)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            iVar2 = 0;
            piVar3 = 0;

            do
            {
                local_48[piVar3].DAT_79 = (byte)iVar2;
                local_48[piVar3].DAT_78 = local_30[iVar2 + iVar6 * 5];
                iVar2++;
                piVar3++;
            } while (iVar2 < 5);
        }

        iVar2 = 0;

        do
        {
            iVar4 = 0;
            piVar3 = 0;

            do
            {
                iVar4++;

                if (local_48[piVar3].DAT_78 == iVar2)
                {
                    param1.PTR_68[piVar7] = local_48[piVar3];
                    break;
                }

                piVar3++;
            } while (iVar4 < 5);

            iVar2++;
            piVar7++;

            if (3 < iVar2)
            {
                InventoryManager.FUN_4A7E8(3, 0x3e, false);
                InventoryManager.FUN_4A7E8(3, 0x2c, true);
                InventoryManager.FUN_4A7E8(3, 0x2d, true);
                sVar5 = (sbyte)(iVar6 + 1);

                if (iVar6 == 4)
                    sVar5 = 1;
                else
                {
                    if (2 < iVar6 + 1)
                        sVar5 = 2;
                }

                param1.DAT_3C += (byte)sVar5;
                param1.DAT_7A = 0;
                param1.DAT_7B = 0;
                return;
            }
        } while (true);
    }

    //FUN_16D0 (ST7)
    private void FUN_16D0(CriParticle param1)
    {
        short sVar1;
        sbyte sVar2;
        CriStatic oVar3;
        CriStatic oVar4;

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        oVar4 = param1.PTR_68[param1.SDAT_78];
        oVar3 = SceneManager.instance.DAT_7CDC[param1.SDAT_78 + 5];
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar4, 145);

            if (oVar4.DAT_79 != 4)
                ; //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);
        oVar4.screen.y = sVar1;

        if (-0x433 < sVar1)
        {
            oVar3 = SceneManager.instance.DAT_7CDC[param1.SDAT_78 + 9];
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

    //FUN_1870 (ST7)
    private void FUN_1870(CriParticle param1)
    {
        sbyte sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriStatic oVar4;
        CriParticle oVar5;
        CriStatic oVar6;
        CriStatic oVar7;

        oVar6 = param1.PTR_68[param1.SDAT_78];
        oVar7 = SceneManager.instance.DAT_7CDC[param1.SDAT_78 + 5];
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
                    oVar5.screen.x = DAT_119F4[param1.SDAT_78 * 3];
                    oVar5.screen.y = DAT_119F4[param1.SDAT_78 * 3 + 1];
                    oVar5.screen.z = DAT_119F4[param1.SDAT_78 * 3 + 2];
                    oVar5.DAT_4C = null;
                } while (iVar4 < 2);
            }
        }

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar6, 145);

            if (oVar6.DAT_79 != 4)
                ; //FUN_1D988
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
                FUN_1B48(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-0x433 < sVar3)
        {
            oVar4 = SceneManager.instance.DAT_7CDC[param1.SDAT_78 + 9];
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

    //FUN_1B48 (ST7)
    private void FUN_1B48(CriParticle param1)
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
                param1.screen.x = DAT_11A18[param1.SDAT_78] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a48));
            param1.flags |= 2;
            param1.screen.x = DAT_11A18[param1.SDAT_78];
        }

        param1.DAT_7B++;
    }

    //FUN_1C94 (ST7)
    private void FUN_1C94(CriParticle param1)
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

    //FUN_1D20 (ST7)
    private void FUN_1D20(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_1D9C (ST7)
    private void FUN_1D9C(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11A3C[0]));
        param1.DAT_69 = 1;
        param1.DAT_68 = DAT_11A40[0];
        param1.DAT_3C++;
    }

    //FUN_1E24 (ST7)
    private void FUN_1E24(CriParticle param1)
    {
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if (DAT_11A3C[param1.DAT_69] == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11A3C[param1.DAT_69]));
            }

            param1.DAT_68 = DAT_11A40[param1.DAT_69];
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_1F74 (ST7)
    private void FUN_1F74(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x801223cc));
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f33;
        param1.DAT_3C = 1;
        param1.DAT_50.a |= 2;
        param1.flags |= 2;
    }

    //FUN_1FD0 (ST7)
    private void FUN_1FD0(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_68;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_20A8 (ST7)
    private void FUN_20A8(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11A6C[param1.DAT_2F]));
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

    //FUN_2150 (ST7)
    private void FUN_2150(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_6B;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_221C (ST7)
    private void FUN_221C(CriParticle param1)
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
        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11AA8[param1.DAT_2F]));

        if (iVar2 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_2314 (ST7)
    private void FUN_2314(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_27C (ST7)
    public static void FUN_27C(CriParticle param1)
    {
        instance.PTR_FUN_119D4[param1.DAT_3C](param1);
        //FUN_600
    }

    //FUN_BC8 (ST7)
    public static void FUN_BC8(CriParticle param1)
    {
        instance.PTR_FUN_119E4[param1.DAT_3C](param1);
    }

    //FUN_13BC (ST7)
    public static void FUN_13BC(CriParticle param1)
    {
        instance.PTR_FUN_11A20[param1.DAT_3C](param1);
    }

    //FUN_1C58 (ST7)
    public static void FUN_1C58(CriParticle param1)
    {
        instance.PTR_FUN_11A30[param1.DAT_3C](param1);
    }

    //FUN_1D60 (ST7)
    public static void FUN_1D60(CriParticle param1)
    {
        instance.PTR_FUN_11A54[param1.DAT_3C](param1);
    }

    //FUN_21E0 (ST7)
    public static void FUN_21E0(CriParticle param1)
    {
        instance.PTR_FUN_11AC8[param1.DAT_3C](param1);
    }

    //FUN_1F14 (ST7)
    public static void FUN_1F14(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11A60[param1.DAT_3C](param1);
    }

    //FUN_2048 (ST7)
    public static void FUN_2048(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11A98[param1.DAT_3C](param1);
    }

    //FUN_2650 (ST7)
    public static void FUN_2650(CriInteract param1)
    {

    }

    //FUN_2AC8 (ST7)
    public static void FUN_2AC8(CriInteract param1)
    {

    }

    //FUN_3300 (ST7)
    public static void FUN_3300(CriInteract param1)
    {

    }

    //FUN_39E8 (ST7)
    public static void FUN_39E8(CriInteract param1)
    {

    }

    //FUN_3A24 (ST7)
    public static void FUN_3A24(CriInteract param1)
    {

    }

    //FUN_3D54 (ST7)
    public static void FUN_3D54(CriInteract param1)
    {

    }

    //FUN_623C (ST7)
    public static void FUN_623C(CriPlayer param1)
    {

    }

    //FUN_672C (ST7)
    public static void FUN_672C(CriInteract param1)
    {

    }

    //FUN_94FC (ST7)
    public static void FUN_94FC(CriInteract param1)
    {

    }

    //FUN_BED4 (ST7)
    public static void FUN_BED4(CriInteract param1)
    {

    }

    //FUN_E5B4 (ST7)
    public static void FUN_E5B4(CriInteract param1)
    {

    }

    //FUN_E830 (ST7)
    public static void FUN_E830(CriInteract param1)
    {

    }

    //FUN_E86C (ST7)
    public static void FUN_E86C(CriInteract param1)
    {

    }

    //FUN_10844 (ST7)
    public static void FUN_10844(CriInteract param1)
    {

    }
}
