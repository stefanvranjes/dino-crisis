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

    //FUN_252C (ST4)
    public static void FUN_252C(CriPlayer param1)
    {
        param1.FUN_252C();
    }

    //FUN_346C (ST4)
    public static void FUN_346C(CriParticle param1)
    {
        return;
    }

    //FUN_3648 (ST4)
    public static void FUN_3648(CriParticle param1)
    {
        return;
    }

    //FUN_3760 (ST4)
    public static void FUN_3760(CriParticle param1)
    {
        return;
    }

    //FUN_3828 (ST4)
    public static void FUN_3828(CriParticle param1)
    {
        return;
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
