using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_12A20
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public int DAT_0C;
}

public struct UNK_12FF0
{
    public uint DAT_00;
    public ushort DAT_04;
}

public class ST4 : LevelManager
{
    public static new ST4 instance;

    public FUN_B58BC[] DAT_1279C = new FUN_B58BC[20] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                       FUN_45B08, null, FUN_46A1C, FUN_346C, null, null, 
                                                       FUN_45D38, FUN_45E70, null, null, null, FUN_3648, 
                                                       FUN_46814, FUN_3760, FUN_3828 };
    public FUN_B58C0[] DAT_127EC = new FUN_B58C0[8] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_252C, null, 
                                                      FUN_10E38, null, FUN_3AB8 };
    public FUN_C2570[] DAT_1280C = new FUN_C2570[8] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, 
                                                      null, null, FUN_7F808 };
    public FUN_C1CF8[] DAT_1282C = new FUN_C1CF8[25] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, 
                                                       FUN_21ECC, FUN_22178, null, null, null, FUN_222AC, 
                                                       FUN_22464, FUN_2268C, null, null, null, null, null, null, 
                                                       FUN_123F8, FUN_11328, FUN_1167C, FUN_11854, FUN_12140, FUN_123BC };
    public byte[][] DAT_1270C = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 12, 27, 15, 13, 13, 32, 25, 20, 20, 33, 30, 27, 24, 34, 31, 0, 27, 35, 0, 0, 0, 22, 0, 28, 28, 23, 0, 29, 29, 16, 0, 30, 30, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 10, 27, 0, 0, 0, 32, 25, 20, 20, 33, 30, 26, 24, 34, 31, 27, 27, 35, 0, 0, 0, 22, 0, 28, 28, 23, 0, 29, 29, 16, 0, 30, 30, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 10, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 6, 0, 0, 35, 0, 0, 0, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 16, 11, 11, 24, 31, 31, 31, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_1261C; //0x1261C (ST4)
    public uint[] DAT_12520 = new uint[63] { 0x0, 0x9, 0x80000016, 0x0, 0xc, 0x80000017, 0x0, 0x80000014, 0x0, 0x7, 0xd, 0x80000015, 0x0, 0xb, 0x80000016, 0x0, 0x9, 0x80000011, 0x0, 0x9, 0x80000013, 0x0, 0x4, 0x80000017, 0x0, 0xc, 0x80000014, 0x0, 0x80000023, 0x0, 0x80000010, 0x0, 0x80000013, 0x0, 0xc, 0x80000018, 0x0, 0x9, 0x80000015, 0x0, 0x80000015, 0x0, 0xe, 0x8000001d, 0x0, 0x5, 0xe, 0x8000001d, 0x0, 0xa, 0x80000013, 0x0, 0x80000013, 0x0, 0x80000010, 0x0, 0x7, 0x80000013, 0x0, 0x7, 0x80000014, 0x0, 0x8000000f };
    public CapsuleCollider[] DAT_12890 = new CapsuleCollider[] { }; //0x12890 (ST4)
    public short[] DAT_1295C = new short[] { }; //0x1295C (ST4)
    private UNK_12A20[] PTR_DAT_12A20; //0x12A20 (ST4)
    private delegate void FUN_12DE0(CriPlayer p); //0x12DE0 (ST4)
    private FUN_12DE0[] PTR_FUN_12DE0; //0x12DE0 (ST4)
    private short[] DAT_12DEC = new short[] { }; //0x12E08 (ST4)
    public delegate void FUN_12F38(CriPlayer p); //0x12F38 (ST4)
    private delegate void FUN_12F7C(CriPlayer p1, CriPlayer p2); //0x12F7C (ST4)
    private delegate void FUN_12FB8(CriPlayer p1, CriPlayer p2); //0x12FB8 (ST4)
    private delegate void FUN_12FCC(CriPlayer p); //0x12FCC (ST4)
    private delegate void FUN_12FDC(CriPlayer p); //0x12FDC (ST4)
    private delegate void FUN_12FE8(CriPlayer p); //0x12FE8 (ST4)
    public FUN_12F38[] PTR_FUN_12F38; //0x12F38 (ST4)
    private int[] DAT_12F4C = new int[7] { 25, 28, 26, 29, 27, 30, 23 }; //0x12F4C (ST4)
    private FUN_12F7C[] PTR_FUN_12F7C; //0x12F7C (ST4)
    private int[] DAT_12F98 = new int[6] { 33, 35, 34, 36, 24, 37 }; //0x12F98 (ST4)
    private FUN_12FB8[] PTR_FUN_12FB8; //0x12FB8 (ST4)
    private FUN_12FCC[] PTR_FUN_12FCC; //0x12FCC (ST4)
    private int[] DAT_12FD4 = new int[2] { 38, 39 }; //0x12FD4 (ST4)
    private FUN_12FDC[] PTR_FUN_12FDC; //0x12FDC (ST4)
    private FUN_12FE8[] PTR_FUN_12FE8; //0x12FE8 (ST4)
    public UNK_12FF0[] PTR_DAT_12FF0; //0x12FF0 (ST4)
    public uint[] DAT_13034 = new uint[5] { 0x8010abbc, 0x8010abc4, 0x8010abcc, 0x8010abd4, 0x8010abdc };
    public uint[] DAT_13060 = new uint[3] { 0x8010eb80, 0x8010eb98, 0x8010ebb0 };
    public sbyte[] DAT_1306C = new sbyte[4] { -4, -2, 2, 4 };

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_12DE0 = new FUN_12DE0[3]
            {
                FUN_6CC,
                FUN_764,
                FUN_794
            };
            PTR_FUN_12F38 = new FUN_12F38[]
            {
                FUN_9AC, 
                FUN_2498
            };
            PTR_FUN_12F7C = new FUN_12F7C[7]
            {
                FUN_2A44,
                FUN_2ABC,
                FUN_2B7C,
                FUN_2C14,
                FUN_2C14,
                FUN_2C14,
                FUN_2CB8
            };
            PTR_FUN_12FB8 = new FUN_12FB8[5]
            {
                FUN_2D3C,
                FUN_2DDC,
                FUN_2EA4,
                FUN_2FDC,
                FUN_307C
            };
            PTR_FUN_12FCC = new FUN_12FCC[2]
            {
                FUN_2CFC,
                FUN_30C0
            };
            PTR_FUN_12FDC = new FUN_12FDC[2]
            {
                FUN_3144,
                FUN_31A4
            };
            PTR_FUN_12FE8 = new FUN_12FE8[2]
            {
                FUN_313C,
                FUN_3238
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

    //FUN_1C (ST4)
    public override void Initialize()
    {
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_1279C;
        PTR_FUN_B58C0 = DAT_127EC;
        PTR_FUN_C2570 = DAT_1280C;
        PTR_FUN_C1CF8 = DAT_1282C;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_1270C[uVar3];
        SceneManager.instance.DAT_B0 = DAT_12520;
        GameManager.instance.DAT_46 = 4;

        for (int i = 0; i < DAT_1261C.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_1261C.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 4);
    }

    //FUN_460 (ST4)
    public void FUN_460(CriPlayer param1)
    {
        ushort uVar1;
        byte bVar2;
        CriParticle oVar3;
        CriObject oVar4;

        if (param1.DAT_1DA == PTR_DAT_12A20[param1.DAT_1D9].DAT_00)
        {
            oVar3 = SceneManager.instance.FUN_5FFA0();

            if (oVar3 != null)
            {
                oVar3.tags = PTR_DAT_12A20[param1.DAT_1D9].DAT_01;
                oVar3.DAT_2F = PTR_DAT_12A20[param1.DAT_1D9].DAT_02;
                oVar4 = Utilities.FUN_601C8(param1.skeleton, 3);
                oVar3.DAT_4C = oVar4;
                oVar3.screen = PTR_DAT_12A20[param1.DAT_1D9].DAT_04;
                uVar1 = PTR_DAT_12A20[param1.DAT_1D9].DAT_0A;
                oVar3.DAT_62 = uVar1;
                oVar3.DAT_60 = uVar1;
                oVar3.IDAT_6C = PTR_DAT_12A20[param1.DAT_1D9].DAT_0C;
            }

            bVar2 = (byte)(param1.DAT_1D9 + 1);
            param1.DAT_1D9 = bVar2;

            if (2 < bVar2)
            {
                param1.DAT_1C0 &= 0xbfffffff;
                param1.DAT_1D9 = 0;
            }
        }

        param1.DAT_1DA++;
    }

    //FUN_584 (ST4)
    private void FUN_584(CriPlayer param1)
    {
        short sVar1;
        CriObject oVar2;
        ushort uVar3;

        uVar3 = (ushort)(param1.SDAT_1FA + 0x400 & 0xfff);

        if (uVar3 < 0xc01)
        {
            if (uVar3 < 0x801)
                uVar3 = (ushort)Utilities.FUN_51D40(param1.SDAT_1FA, (short)param1.DAT_19E, param1.DAT_167);
            else
                uVar3 = param1.DAT_167;
        }
        else
            uVar3 = (ushort)-param1.DAT_167;

        sVar1 = Utilities.FUN_51D40(param1.SDAT_1F8, (short)param1.DAT_19C, param1.DAT_166);
        uVar3 = (ushort)(param1.DAT_19E + uVar3 & 0xfff);
        param1.DAT_19E = uVar3;
        param1.DAT_19C = (ushort)(param1.DAT_19C + sVar1 & 0xfff);

        if (uVar3 < 0x801)
        {
            if (0x200 < uVar3)
                param1.DAT_19E = 0x200;
        }
        else
        {
            if (uVar3 < 0xe00)
                param1.DAT_19E = 0xe00;
        }

        uVar3 = param1.DAT_19C;

        if (uVar3 < 0x801)
        {
            if (0x100 < uVar3)
                param1.DAT_19C = 0x100;
        }
        else
        {
            if (uVar3 < 0xf00)
                param1.DAT_19C = 0xf00;
        }

        oVar2 = Utilities.FUN_601C8(param1.skeleton, 2);
        oVar2.vr.x = param1.DAT_19C & 0xfff;
        oVar2.vr.y = param1.DAT_19E & 0xfff;
    }

    //FUN_6CC (ST4)
    private void FUN_6CC(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriObject oVar3;
        CriSkinned oVar4;

        oVar4 = param1.DAT_154;
        oVar3 = Utilities.FUN_601C8(param1.skeleton, 2);
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
        param1.SDAT_1FA = sVar1;
        sVar2 = (short)Utilities.FUN_61654(oVar3.screen, oVar4.screen, sVar1);
        param1.SDAT_1F8 = sVar2;
        param1.SDAT_1FA = (short)(param1.SDAT_1FA - param1.vr.y & 0xfff);
        FUN_584(param1);
    }

    //FUN_764 (ST4)
    private void FUN_764(CriPlayer param1)
    {
        if (param1.DAT_19C != 0)
            param1.DAT_19C = 0;

        if (param1.DAT_19E != 0)
            param1.DAT_19E = 0;
    }

    //FUN_794 (ST4)
    private void FUN_794(CriPlayer param1)
    {
        CriObject oVar1;

        oVar1 = Utilities.FUN_601C8(param1.skeleton, 2);
        param1.SDAT_1F8 = (short)oVar1.vr.x;
        param1.SDAT_1FA = (short)oVar1.vr.y;
        FUN_584(param1);
    }

    //FUN_7E8 (ST4)
    public void FUN_7E8(CriPlayer param1)
    {
        PTR_FUN_12DE0[param1.DAT_164](param1);
    }

    //FUN_824 (ST4)
    public void FUN_824(CriPlayer param1)
    {
        CriCamera cVar1;
        ushort uVar2;

        cVar1 = SceneManager.instance.cCamera;
        uVar2 = (ushort)(param1.UDAT_1D2 >> 8 & 0x7f);
        cVar1.DAT_38 += (short)(DAT_12DEC[(param1.UDAT_1D2 & 0xff) + 14] * uVar2);
        cVar1.DAT_3A += (short)(DAT_12DEC[param1.UDAT_1D2] * uVar2);
        uVar2 = (ushort)(param1.UDAT_1D2 + 1);
        param1.UDAT_1D2 = uVar2;

        if (13 < (uVar2 & 0xff))
            param1.UDAT_1D2 = 0;
    }

    //FUN_930 (ST4)
    private void FUN_930(CriPlayer param1)
    {
        param1.DAT_3D = 8;
        param1.DAT_3E = 0;
        param1.DAT_40.z = 0;
        param1.DAT_164 = 1;
    }

    //FUN_9AC (ST4)
    private void FUN_9AC(CriPlayer param1)
    {
        ushort uVar2;
        CriObject oVar3;

        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_175 = 2;
        param1.DAT_3C++;
        param1.FUN_609C8(0, 1, 0);
        param1.DAT_3D = 4;
        param1.PTR_120 = DAT_12890;
        param1.DAT_120 = 0;
        param1.PTR_130 = DAT_12890;
        param1.DAT_130 = 16;
        param1.FUN_77784(1, DAT_12890[16].radius);
        param1.DAT_164 = 0;
        param1.DAT_19E = 0;
        param1.DAT_19C = 0;
        param1.DAT_166 = 10;
        param1.DAT_167 = 10;
        param1.FUN_66404(0, 0x4000, 0x7fff);
        param1.DAT_140 |= 1;
        uVar2 = 0xb22;

        if (GameManager.instance.DAT_A2D2 == 0)
            uVar2 = 0x41a;

        param1.DAT_1D0 = uVar2;
        param1.DAT_1C0 = 0;
        param1.DAT_1DF = 0;
        oVar3 = Utilities.FUN_601C8(param1.skeleton, 4);
        param1.PTR_1CC = oVar3;
        param1.DAT_1E7 = true;
        param1.BDAT_1E8 = false;
        param1.DAT_1DB = 0;
        param1.IDAT_1C4 = 0;
        GameManager.instance.PTR_FUN_148 = FUN_3100;
        GameManager.instance.PTR_FUN_14C = FUN_3274;
        param1.DAT_12E = 2;
        param1.PTR_124 = DAT_12890;
        param1.DAT_124 = 12;
        param1.DAT_154 = SceneManager.instance.DAT_27C[10];
        param1.DAT_12F = 4;
    }

    //FUN_B1C (ST4)
    private void FUN_B1C(CriPlayer param1)
    {
        short sVar1;
        ushort uVar2;
        ushort uVar3;

        if ((param1.DAT_11E & 0x80) == 0)
            return;

        param1.DAT_11E &= 0x7f;
        uVar3 = (ushort)(param1.DAT_1A1 & 0xf);
        uVar2 = (ushort)(param1.DAT_1A0 >> 4 & 0xf);

        if (uVar2 == 2)
        {
            if (uVar3 == 7)
                sVar1 = (short)(param1.health - 67);
            else
                sVar1 = (short)(param1.health - 50);
        }
        else
        {
            if (uVar2 < 3)
            {
                if (uVar2 != 1) goto LAB_BDC;

                if (uVar3 < 6 && 1 < uVar3)
                    return;

                sVar1 = (short)(param1.health - 100);
            }
            else
            {
                if (uVar2 != 3) goto LAB_BDC;

                sVar1 = (short)(param1.health - 350);
            }
        }

        param1.health = sVar1;

        LAB_BDC:
        if (param1.health < 1)
        {
            param1.health = 1;
            param1.DAT_1C0 |= 1;
        }

        if ((param1.DAT_1C0 & 0x40000000) == 0)
        {
            param1.DAT_1C0 |= 0x40000000;
            param1.DAT_1D9 = 0;
            param1.DAT_1DA = 0;
        }

        if (param1.DAT_3D != 3 && param1.DAT_3D == 2)
        {
            param1.DAT_3D = 3;
            param1.DAT_11C = 0;
            param1.DAT_3E = 0;
        }
    }

    //FUN_2498 (ST4)
    private void FUN_2498(CriPlayer param1)
    {
        uint uVar1;
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        FUN_B1C(param1);
        uVar1 = Utilities.FUN_631AC(param1.PTR_1CC.screen, oVar2.screen);
        param1.UDAT_1C8 = uVar1;
        //...
    }

    //FUN_2768 (ST4)
    private void FUN_2768(CriPlayer param1, CriPlayer param2)
    {
        param1.DAT_3C = 1;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_152 = 0;
        param1.DAT_11E &= 0x7f;
        param1.DAT_12C &= 0xffbf;
        param1.DAT_140 &= 0xfffd;
        param1.DAT_98 = param1.DAT_1E0;
    }

    //FUN_27AC (ST4)
    public void FUN_27AC(CriPlayer param1, CriPlayer param2, uint param3)
    {
        bool bVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        int iVar5;
        CriObject oVar5;
        Vector3Int local_40;
        Matrix3x3 auStack56;

        uVar4 = param3 & 0xff;
        param1.DAT_3C = 5;
        param1.DAT_3D = 1;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        iVar5 = 0;

        if (uVar4 < 8)
        {
            if (uVar4 < 5)
            {
                if (uVar4 != 0)
                {
                    if (uVar4 < 3 || uVar4 == 4)
                    {
                        iVar5 = (int)((param3 & 0xfe) + ((param3 & 0xff) >> 7));
                        auStack56 = new Matrix3x3();
                        Utilities.RotMatrix_gte(ref param2.vr, ref auStack56);
                        local_40 = Utilities.ApplyMatrixSV(ref auStack56, ref DAT_12890[iVar5].pos);
                        oVar5 = Utilities.FUN_601C8(param2.skeleton, DAT_12890[iVar5].bone);
                        local_40.x += oVar5.screen.x;
                        local_40.y += oVar5.screen.y;
                        local_40.z += oVar5.screen.z;
                        sVar2 = param1.FUN_64804(local_40);
                        iVar5 = 3;
                        param2.DAT_1DD = (byte)((sVar2 + 0x400 & 0xfff) < 0x800 ? 1 : 0);
                    }

                    goto LAB_2980;
                }
            }
            else
            {
                sVar2 = param1.FUN_64804(param2.screen);
                bVar1 = (sVar2 + 0x400 & 0xfff) < 0x800;
                param2.DAT_1DD = (byte)(bVar1 ? 1 : 0);

                if (bVar1)
                    sVar3 = (short)(param2.UDAT_1E0 + 0x800 & 0xfff);
                else
                    sVar3 = (short)param2.UDAT_1E0;

                param1.vr.y = sVar3;
            }

            iVar5 = 0;
        }
        else
        {
            if (uVar4 == 8)
            {
                sVar2 = param1.FUN_64804(param2.screen);
                param2.DAT_1DD = (byte)((sVar2 + 0x400 & 0xfff) < 0x800 ? 1 : 0);
                iVar5 = 1;
            }
            else
            {
                if (uVar4 == 100)
                {
                    param1.DAT_3C = 5;
                    param1.DAT_3D = 0;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_152 = 1;
                    param1.vr.y = param2.vr.y;
                    param2.FUN_656EC();
                    iVar5 = 2;
                }
                else
                    iVar5 = 0;
            }
        }

        LAB_2980:
        param1.DAT_154 = param2;
        param1.DAT_11E |= 0x80;
        param1.DAT_1E0 = param1.DAT_98;
        param1.DAT_98 = param2.DAT_98;
        param1.health -= DAT_1295C[iVar5];
        param1.FUN_4FE30();

        if (param1.health < 1)
            param1.health = 0;

        //FUN_1D988
    }

    //FUN_2A44 (ST4)
    private void FUN_2A44(CriPlayer param1, CriPlayer param2)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12F4C[param2.DAT_1DB], 0, 0);
        param1.DAT_12C |= 0x40;
        param1.FUN_65714();
        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_2ABC (ST4)
    private void FUN_2ABC(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;

        param1.FUN_65714();
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_12F4C[param2.DAT_1DB], 0, 0);
            param1.DAT_40 = new Vector3Int(0, 0, 400);
            sVar1 = 0x400;

            if (param2.DAT_1DB == 0)
                sVar1 = -0x400;

            param1.vr.y += sVar1;
            param1.DAT_152 = 0;
            param1.screen.y += 0x1f7;
            param1.DAT_140 &= 0x7fff;
        }
    }

    //FUN_2B7C (ST4)
    private void FUN_2B7C(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;

        sVar1 = (short)(param1.DAT_40.z - 15);
        param1.DAT_40.z = sVar1;

        if ((sVar1 << 0x10) < 0)
            param1.DAT_40.z = 0;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_12F4C[param2.DAT_1DB], 0, 0);
        }
    }

    //FUN_2C14 (ST4)
    private void FUN_2C14(CriPlayer param1, CriPlayer param2)
    {
        byte bVar1;
        bool bVar2;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_40.z = 0;

            if (param1.health == 0)
                FUN_930(param2);
            else
            {
                bVar1 = param1.DAT_3E;
                param1.DAT_3E = (byte)(bVar1 + 1);
                param1.FUN_609C8(DAT_12F4C[bVar1 * 2], (byte)DAT_12F4C[(bVar1 << 3 | 4) / 4], 0);
            }
        }
    }

    //FUN_2CB8 (ST4)
    private void FUN_2CB8(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            FUN_2768(param1, param2);
    }

    //FUN_2CFC (ST4)
    private void FUN_2CFC(CriPlayer param1)
    {
        PTR_FUN_12F7C[param1.DAT_3E](param1, (CriPlayer)param1.DAT_154);
    }

    //FUN_2D3C (ST4)
    private void FUN_2D3C(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;

        param1.DAT_12C |= 0x40;
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12F98[param2.DAT_1DD], 0, 0);
        sVar1 = 250;

        if (param2.DAT_1DD != 0)
            sVar1 = -250;

        param1.DAT_40.z = sVar1;
        GameManager.instance.FUN_5C94C(param1, 3);
        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_2DDC (ST4)
    private void FUN_2DDC(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;

        if (param2.DAT_1DD == 0)
        {
            sVar1 = (short)(param1.DAT_40.z - 10);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2E38;
            }
        }
        else
        {
            sVar1 = (short)(param1.DAT_40.z + 10);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2E38;
            }
        }

        sVar1 = 0;
        LAB_2E38:
        param1.DAT_40.z = sVar1;
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_12F98[param2.DAT_1DD + 2], 0, 0);
            param1.DAT_112 = 30;
        }
    }

    //FUN_2EA4 (ST4)
    private void FUN_2EA4(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;

        if (param1.frame.DAT_01 == 3)
            GameManager.instance.FUN_5C94C(param1, 5);

        if (param2.DAT_1DD == 0)
        {
            sVar1 = (short)(param1.DAT_40.z - 4);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2F20;
            }
        }
        else
        {
            sVar1 = (short)(param1.DAT_40.z + 4);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2F20;
            }
        }

        sVar1 = 0;
        LAB_2F20:
        param1.DAT_40.z = sVar1;
        param1.FUN_60AB4();
        sVar1 = param1.DAT_112;
        param1.DAT_112 = (short)(sVar1 - 1);

        if (sVar1 == 1)
        {
            param1.DAT_40.z = 0;

            if (param1.health == 0)
                FUN_930(param2);
            else
            {
                param1.DAT_3E++;
                param1.FUN_609C8(DAT_12F98[param2.DAT_1DD + 4], 0, 0);

                if (param2.DAT_1DD != 0)
                    param1.DAT_5C |= 8;
            }
        }
    }

    //FUN_2FDC (ST4)
    private void FUN_2FDC(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            if (param2.DAT_1DD == 0)
            {
                param1.DAT_3E++;
                param1.FUN_609C8(DAT_12F98[param2.DAT_1DD + 6], 6, 0);
            }
            else
                FUN_2768(param1, param2);
        }
    }

    //FUN_307C (ST4)
    private void FUN_307C(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            FUN_2768(param1, param2);
    }

    //FUN_30C0 (ST4)
    private void FUN_30C0(CriPlayer param1)
    {
        PTR_FUN_12FB8[param1.DAT_3E](param1, (CriPlayer)param1.DAT_154);
    }

    //FUN_3100 (ST4)
    private void FUN_3100(CriPlayer param1)
    {
        PTR_FUN_12FCC[param1.DAT_3D](param1);
    }

    //FUN_313C (ST4)
    private void FUN_313C(CriPlayer param1)
    {
        return;
    }

    //FUN_3144 (ST4)
    private void FUN_3144(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12FD4[((CriPlayer)param1.DAT_154).BDAT_1EC], 0, 0);
        param1.FUN_65714();
    }

    //FUN_31A4 (ST4)
    private void FUN_31A4(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.FUN_65714();
    }

    //FUN_3238 (ST4)
    private void FUN_3238(CriPlayer param1)
    {
        PTR_FUN_12FDC[param1.DAT_3E](param1);
    }

    //FUN_3274 (ST4)
    private void FUN_3274(CriPlayer param1)
    {
        PTR_FUN_12FE8[param1.DAT_3D](param1);
    }

    //FUN_3608 (ST4)
    public byte FUN_3608(CriParticle param1)
    {
        byte bVar1;
        byte bVar2;

        bVar1 = param1.DAT_2F;
        bVar2 = (byte)(bVar1 >> 4 & 7);
        param1.DAT_2F = bVar2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (bVar2 < 5)
        {
            param1.DAT_40.y = 10;
            param1.DAT_68 = 9;
        }

        return (byte)(bVar1 & 0xf);
    }

    //FUN_252C (ST4)
    public static void FUN_252C(CriPlayer param1)
    {
        param1.FUN_252C();
    }

    //FUN_346C (ST4)
    public static void FUN_346C(CriParticle param1)
    {
        param1.FUN_346C();
    }

    //FUN_3648 (ST4)
    public static void FUN_3648(CriParticle param1)
    {
        param1.FUN_3648();
    }

    //FUN_3760 (ST4)
    public static void FUN_3760(CriParticle param1)
    {
        param1.FUN_3760();
    }

    //FUN_3828 (ST4)
    public static void FUN_3828(CriParticle param1)
    {
        param1.FUN_3828();
    }

    //FUN_3AB8 (ST4)
    public static void FUN_3AB8(CriPlayer param1)
    {
        return;
    }

    //FUN_10E38 (ST4)
    public static void FUN_10E38(CriPlayer param1)
    {
        return;
    }

    //FUN_11328 (ST4)
    public static void FUN_11328(CriInteract param1)
    {
        return;
    }

    //FUN_1167C (ST4)
    public static void FUN_1167C(CriInteract param1)
    {
        return;
    }

    //FUN_11854 (ST4)
    public static void FUN_11854(CriInteract param1)
    {
        return;
    }

    //FUN_12140 (ST4)
    public static void FUN_12140(CriInteract param1)
    {
        return;
    }

    //FUN_123BC (ST4)
    public static void FUN_123BC(CriInteract param1)
    {
        return;
    }

    //FUN_123F8 (ST4)
    public static void FUN_123F8(CriInteract param1)
    {
        return;
    }
}
