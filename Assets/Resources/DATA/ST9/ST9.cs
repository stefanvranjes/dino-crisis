using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST9 : LevelManager
{
    public static new ST9 instance;

    public uint[] DAT_159A0 = new uint[] { 0, 0xd, 0x1b, 0x23, 0x2b, 0x39, 0x43, 0x80000057, 0x0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x1e, 0x21, 0x29, 0x3a, 0x80000065, 0x0, 0xc, 0x13, 0x29, 0x2e, 0x3c, 0x40, 0x44, 0x4c, 0x8000005a, 0x0, 0xf, 0x1e, 0x26, 0x2c, 0x3e, 0x4a, 0x80000059, 0x0, 0xe, 0x1a, 0x1d, 0x22, 0x2c, 0x31, 0x3f, 0x43, 0x48, 0x4c, 0x80000059, 0x0, 0x14, 0x20, 0x28, 0x3c, 0x50, 0x80000066, 0x0, 0x17, 0x1f, 0x24, 0x26, 0x33, 0x36, 0x45, 0x4b, 0x80000056, 0x0, 0xf, 0x14, 0x1d, 0x29, 0x2e, 0x33, 0x38, 0x44, 0x4f, 0x80000052, 0x0, 0xb, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x4f, 0x80000059, 0x0, 0x10, 0x15, 0x25, 0x37, 0x3d, 0x45, 0x4c, 0x80000056, 0x0, 0x4, 0x7, 0xd, 0x11, 0x1c, 0x2f, 0x38, 0x44, 0x80000051, 0x0, 0xe, 0x1f, 0x33, 0x42, 0x4c, 0x80000059, 0x0, 0x5, 0x13, 0x1c, 0x28, 0x33, 0x47, 0x50, 0x8000005d, 0x0, 0x5, 0xf, 0x17, 0x21, 0x2d, 0x36, 0x46, 0x80000051, 0x0, 0x6, 0xe, 0x1d, 0x22, 0x2d, 0x3d, 0x43, 0x80000055, 0x0, 0x5, 0xd, 0x15, 0x24, 0x2b, 0x35, 0x45, 0x80000052, 0x0, 0x7, 0x27, 0x3a, 0x80000056, 0x0, 0x13, 0x31, 0x42, 0x8000005e, 0x0, 0x11, 0x2b, 0x3c, 0x4f, 0x80000060, 0x0, 0xe, 0x20, 0x3d, 0x4e, 0x80000063, 0x0, 0x11, 0x21, 0x29, 0x35, 0x3e, 0x80000054, 0x0, 0x8, 0x27, 0x37, 0x80000046 };
    public TrgScriptableObject DAT_15D40; //0x15D40 (ST9)
    public byte[] DAT_15E30 = new byte[] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 };
    public FUN_B58BC[] DAT_15E60 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08, 
                                                     null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, null, null, 
                                                     FUN_CC84, FUN_D478, FUN_DD14, FUN_DE1C, FUN_C864, FUN_CA8C, FUN_DFD0, 
                                                     FUN_E1D8, FUN_E338, FUN_E4C4, FUN_E664, FUN_E80C, FUN_EA84 };
    public FUN_B58C0[] DAT_15ED0 = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_1AF8, null, null, null, null, FUN_3ABC };
    public FUN_C2570[] DAT_15EF4 = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, FUN_15590,
                                                     FUN_7F808, null, null, null, FUN_15508 };
    public FUN_C1CF8[] DAT_15F24 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC, 
                                                     FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C, 
                                                     null, null, null, FUN_EAC0, FUN_11F34, FUN_11F70, FUN_142A8, 
                                                     FUN_F0D0, FUN_143D0, FUN_12C54, FUN_14B2C, FUN_14DD0, 
                                                     FUN_152D8, FUN_15314 };
    private delegate void FUN_16044(CriPlayer p); //0x16044 (ST9)
    private delegate void FUN_16050(CriPlayer p); //0x16050 (ST9)
    private delegate void FUN_16060(CriPlayer p); //0x16060 (ST9)
    private delegate void FUN_16068(CriPlayer p); //0x16068 (ST9)
    private delegate void FUN_16080(CriPlayer p); //0x16080 (ST9)
    private delegate void FUN_16088(CriPlayer p); //0x16088 (ST9)
    private delegate void FUN_16098(CriPlayer p); //0x16098 (ST9)
    private delegate void FUN_160A0(CriPlayer p); //0x160A0 (ST9)
    private delegate void FUN_160B4(CriPlayer p); //0x160B4 (ST9)
    private delegate void FUN_161B8(CriPlayer p); //0x161B8 (ST9)
    private delegate void FUN_161D0(CriPlayer p); //0x161D0 (ST9)
    private delegate void FUN_161D8(CriPlayer p); //0x161D8 (ST9)
    private delegate void FUN_161E0(CriPlayer p); //0x161E0 (ST9)
    private delegate void FUN_161E8(CriPlayer p); //0x161E8 (ST9)
    private delegate void FUN_161F0(CriPlayer p); //0x161F0 (ST9)
    private delegate void FUN_16204(CriPlayer p); //0x16204 (ST9)
    private delegate void FUN_16218(CriPlayer p); //0x16218 (ST9)
    private delegate void FUN_16244(CriPlayer p); //0x16244 (ST9)
    private CapsuleCollider[] DAT_15F90; //0x15F90 (ST9)
    private short[] DAT_15FCC = new short[] { -0x1500, 0x1500 };
    private short[] DAT_15FD0 = new short[] { 0, 0x800 };
    private byte[] DAT_15FD4 = new byte[] { 5, 6, 6, 6, 3, 4, 4, 4, 2, 4, 4, 4 };
    private byte[] DAT_15FE0 = new byte[] { 57, 58, 50, 51, 54, 59, 148, 149 }; //0x15FE0 (ST9)
    private short[] DAT_16000 = new short[] { 4, -4, 0x20, -0x20, 0x20, -0x20, 0x10, -0x10, 8, -8, 2, -2, 1, -1 };
    private short[] DAT_1601C = new short[] { 4, -4, 0x10, -0x10, 0x10, -0x10, 8, -8, 4, -4, 1, -1, 1, -1, 4, -0x400 };
    private FUN_16044[] PTR_FUN_16044; //0x16044 (ST9)
    private FUN_16050[] PTR_FUN_16050; //0x16050 (ST9)
    private FUN_16060[] PTR_FUN_16060; //0x16060 (ST9)
    private FUN_16068[] PTR_FUN_16068; //0x16068 (ST9)
    private int[] DAT_16078 = new int[] { 4, 7 }; //0x16078 (ST9)
    private FUN_16080[] PTR_FUN_16080; //0x16080 (ST9)
    private FUN_16088[] PTR_FUN_16088; //0x16088 (ST9)
    private FUN_16098[] PTR_FUN_16098; //0x16098 (ST9)
    private FUN_160A0[] PTR_FUN_160A0; //0x160A0 (ST9)
    private FUN_160B4[] PTR_FUN_160B4; //0x160B4 (ST9)
    public short[] DAT_160CC = new short[] { -0x100 -0x510 -0x4b0 -0x3a0 -0x4b0 -0x3a0 }; //0x160CC (ST9)
    public Vector3Int[] DAT_160D8; //0x160D8 (ST9)
    private short[] DAT_160EC = new short[] { -0x3000, -0x19a0, -0x2900, -0x2c80, 0x980, -0x3980, 0x2780, -0x2c80, 0x2d80, 0xf00, 0x2500, 0x2c00, -0x1400, 0x3680, -0x2c00, 0x2800 };
    private Vector2Int[][] DAT_1610C; //0x1610C (ST9)
    private short[] DAT_1618C = new short[] { 0x200, 0x0, 0xe00, 0xc00, 0xa00, 0x800, 0x600, 0x400 }; //0x1618C (ST9)
    private uint[] DAT_161A8 = new uint[] { 0x801243d8, 0x80125088, 0x80127ef8 }; //0x161A8 (ST9)
    private byte[] DAT_161B4 = new byte[] { 48, 51, 49 }; //0x161B4 (ST9)
    private FUN_161B8[] PTR_FUN_161B8; //0x161B8 (ST9)
    private FUN_161D0[] PTR_FUN_161D0; //0x161D0 (ST9)
    private FUN_161D8[] PTR_FUN_161D8; //0x161D8 (ST9)
    private FUN_161E0[] PTR_FUN_161E0; //0x161E0 (ST9)
    private FUN_161E8[] PTR_FUN_161E8; //0x161E8 (ST9)
    private FUN_161F0[] PTR_FUN_161F0; //0x161F0 (ST9)
    private FUN_16204[] PTR_FUN_16204; //0x16204 (ST9)
    private FUN_16218[] PTR_FUN_16218; //0x16218 (ST9)
    private FUN_16244[] PTR_FUN_16244; //0x16244 (ST9)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_16044 = new FUN_16044[3]
            {
                FUN_460,
                FUN_4F8,
                FUN_528
            };
            PTR_FUN_16050 = new FUN_16050[4]
            {
                FUN_A28,
                FUN_AE4,
                FUN_BA8,
                FUN_C18
            };
            PTR_FUN_16060 = new FUN_16060[2]
            {
                FUN_DDC,
                FUN_E7C
            };
            PTR_FUN_16068 = new FUN_16068[4]
            {
                FUN_1040,
                FUN_108C,
                FUN_1284,
                FUN_138C
            };
            PTR_FUN_16080 = new FUN_16080[2]
            {
                FUN_14B4,
                FUN_1578
            };
            PTR_FUN_16088 = new FUN_16088[4]
            {
                FUN_DA0,
                FUN_1478,
                FUN_1714,
                FUN_F5C
            };
            PTR_FUN_16098 = new FUN_16098[]
            {

            };
            PTR_FUN_160A0 = new FUN_160A0[]
            {
                FUN_60C,
                FUN_1750, 
                FUN_72C, 
                FUN_734
            };
            PTR_FUN_160B4 = new FUN_160B4[]
            {
                FUN_30F0
            };
            PTR_FUN_161B8 = new FUN_161B8[6]
            {
                FUN_2244,
                FUN_2288,
                FUN_2288,
                FUN_2288,
                FUN_2340,
                FUN_23A4
            };
            PTR_FUN_161D0 = new FUN_161D0[2]
            {
                FUN_2450, 
                FUN_249C
            };
            PTR_FUN_161D8 = new FUN_161D8[2]
            {
                FUN_2500, 
                FUN_254C
            };
            PTR_FUN_161E0 = new FUN_161E0[2]
            {
                FUN_27D8, 
                FUN_2814
            };
            PTR_FUN_161E8 = new FUN_161E8[2]
            {
                FUN_2B68,
                FUN_2C70
            };
            PTR_FUN_161F0 = new FUN_161F0[5]
            {
                FUN_2748,
                FUN_1F3C,
                FUN_1F3C,
                FUN_1F3C,
                FUN_2A6C
            };
            PTR_FUN_16204 = new FUN_16204[5]
            {
                FUN_2870, 
                FUN_2D90, 
                FUN_2E40, 
                FUN_F5C, 
                FUN_2D54
            };
            PTR_FUN_16218 = new FUN_16218[5]
            {
                FUN_60C, 
                FUN_3084, 
                FUN_72C, 
                FUN_734, 
                FUN_25A4
            };
            PTR_FUN_16244 = new FUN_16244[3]
            {
                FUN_375C,
                FUN_37AC,
                FUN_3824
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

    //FUN_134 (ST9)
    public override void Initialize()
    {
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_15E60;
        PTR_FUN_B58C0 = DAT_15ED0;
        PTR_FUN_C2570 = DAT_15EF4;
        PTR_FUN_C1CF8 = DAT_15F24;
        SceneManager.instance.DAT_AC = DAT_15E30;
        SceneManager.instance.DAT_B0 = DAT_159A0;
        GameManager.instance.DAT_46 = 9;

        for (int i = 0; i < DAT_15D40.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_15D40.TRIGGERS[i];
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

    //FUN_20C (ST9)
    private void FUN_20C(CriPlayer param1)
    {
        CriCamera cVar1;
        short sVar2;

        cVar1 = SceneManager.instance.cCamera;
        sVar2 = (short)(param1.UDAT_1D2 >> 8 & 0x7f);
        cVar1.DAT_38 += (short)(DAT_1601C[param1.UDAT_1D2 & 0xff] * sVar2);
        cVar1.DAT_3A += (short)(DAT_16000[param1.UDAT_1D2] * sVar2);
        sVar2 = (short)(param1.UDAT_1D2 + 1);
        param1.UDAT_1D2 = (ushort)sVar2;

        if (13 < (sVar2 & 0xff))
            param1.UDAT_1D2 = 0;
    }

    //FUN_2AC (ST9)
    private void FUN_2AC(CriPlayer param1)
    {
        byte bVar1;

        bVar1 = param1.frame.DAT_02;

        if (bVar1 != 0)
        {
            GameManager.FUN_64650();
            param1.UDAT_1D2 = 0x8100;
            GameManager.instance.FUN_5C94C(param1, DAT_15FE0[bVar1 >> 1]);
        }
    }

    //FUN_318 (ST9)
    private void FUN_318(CriPlayer param1)
    {
        short sVar1;
        CriBone oVar2;
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
        else if (uVar3 < 0xe00)
            param1.DAT_19E = 0xe00;

        uVar3 = param1.DAT_19C;

        if (uVar3 < 0x801)
        {
            if (0x100 < uVar3)
                param1.DAT_19C = 0x100;
        }
        else if (uVar3 < 0xf00)
            param1.DAT_19C = 0xf00;

        oVar2 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
        oVar2.vr.x = param1.DAT_19C & 0xfff;
        oVar2.vr.y = param1.DAT_19E & 0xfff;
    }

    //FUN_460 (ST9)
    private void FUN_460(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriBone oVar3;

        oVar3 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_154.screen);
        param1.SDAT_1FA = sVar1;
        sVar2 = (short)Utilities.FUN_61654(oVar3.screen, param1.DAT_154.screen, sVar1);
        param1.SDAT_1F8 = sVar2;
        param1.SDAT_1FA = (short)(param1.SDAT_1FA - param1.vr.y & 0xfff);
        FUN_318(param1);
    }

    //FUN_4F8 (ST9)
    private void FUN_4F8(CriPlayer param1)
    {
        if (param1.DAT_19C != 0)
            param1.DAT_19C = 0;

        if (param1.DAT_19E != 0)
            param1.DAT_19E = 0;
    }

    //FUN_528 (ST9)
    private void FUN_528(CriPlayer param1)
    {
        CriBone oVar1;

        oVar1 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
        param1.SDAT_1F8 = (short)oVar1.vr.x;
        param1.SDAT_1FA = (short)oVar1.vr.y;
        FUN_318(param1);
    }

    //FUN_57C (ST9)
    private void FUN_57C(CriPlayer param1)
    {
        PTR_FUN_16044[param1.DAT_164](param1);
    }

    //FUN_5B8 (ST9)
    private void FUN_5B8(CriPlayer param1)
    {
        if (param1.DAT_2F != 4 || (!InventoryManager.FUN_4A87C(3, 0x3f) && !InventoryManager.FUN_4A87C(3, 0x3e)))
            InventoryManager.FUN_4A7E8(3, 0x22, true);
    }

    //FUN_60C (ST9)
    private void FUN_60C(CriPlayer param1)
    {
        CriSkinned oVar1;

        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.DAT_175 = 2;
        param1.PTR_120 = DAT_15F90;
        param1.DAT_120 = 0;
        param1.DAT_167 = 5;
        param1.DAT_166 = 10;
        param1.DAT_164 = 0;
        param1.DAT_3C++;

        if (param1.DAT_2F == 2)
        {
            param1.PTR_130 = DAT_15F90;
            param1.DAT_130 = 3;
            param1.FUN_77784(1, DAT_15F90[3].radius);
            param1.DAT_12E = 3;
            param1.DAT_164 = 1;
        }
        else
        {
            param1.PTR_130 = null;
            param1.DAT_130 = 0;
            param1.DAT_164 = 0;
            param1.DAT_12E = 1;
        }

        if (param1.DAT_2F != 4)
            param1.FUN_66404(0, 0x4000, 0x7fff);

        param1.FUN_609C8(0, 1, 0);
        oVar1 = SceneManager.instance.DAT_27C[10];
        param1.IDAT_1C4 = 0;
        param1.DAT_11C = 0;
        param1.DAT_154 = oVar1;
        oVar1.DAT_14C = new Vector3Int(0x18, 0x27bd, 0x8010); //0x1CC0
        param1.PTR_124 = DAT_15F90;
        param1.DAT_124 = 0;
        param1.DAT_12F = 3;
    }

    //FUN_72C (ST9)
    private void FUN_72C(CriPlayer param1)
    {
        return;
    }

    //FUN_734 (ST9)
    private void FUN_734(CriPlayer param1)
    {
        return;
    }

    //FUN_73C (ST9)
    private void FUN_73C(CriPlayer param1)
    {
        byte bVar1;
        bool bVar2;
        int iVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;

        if ((param1.DAT_11E & 0x80) == 0)
            return;

        param1.DAT_11E &= 0x7f;

        if (param1.DAT_3C == 4)
            return;

        bVar2 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar2)
            return;

        bVar1 = (byte)(param1.DAT_1A0 >> 4);

        if (bVar1 == 3)
            param1.DAT_1ED++;

        if (param1.DAT_3D == 2)
            return;

        if (bVar1 == 2)
        {
            //...
            goto LAB_944;
        }

        if (bVar1 < 3)
        {
            if (bVar1 == 1)
            {
                //...
            }

            goto LAB_944;
        }

        iVar4 = 0;

        if (bVar1 != 3) goto LAB_944;

        oVar5.DAT_1C0 &= 0xffffffbf;

        if (param1.DAT_2F == 4)
        {
            if (GameManager.instance.DAT_922C == 2)
            {
                param1.DAT_3A = 1;
                param1.DAT_11E++;
            }
            else
                param1.DAT_3A = 0;
        }
        else
        {
            if (param1.DAT_3D != 1 || param1.frame.DAT_01 < 10 || param1.DAT_3E == 2)
                param1.DAT_3A = 0;
            else
            {
                param1.DAT_3A = 1;
                param1.DAT_1EE++;
            }
        }

        //...
        param1.DAT_3D = 2;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;

        LAB_944:;
        //...
    }

    //FUN_974 (ST9)
    private void FUN_974(CriPlayer param1)
    {
        bool bVar1;
        int iVar1;
        uint uVar2;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            if ((param1.DAT_1C0 & 2) == 0)
            {
                iVar1 = (int)GameManager.FUN_64650();

                if ((iVar1 >> 4 & 1) == 0)
                    return;

                param1.FUN_609C8(3, 1, param1.DAT_1F1);
                uVar2 = param1.DAT_1C0 | 2;
            }
            else
            {
                param1.FUN_609C8(0, 1, param1.DAT_1F1);
                uVar2 = param1.DAT_1C0 & 0xfffffffd;
            }

            param1.DAT_1C0 = uVar2;
        }
    }

    //FUN_A28 (ST9)
    private void FUN_A28(CriPlayer param1)
    {
        int iVar1;
        CriCamera cVar1;

        cVar1 = SceneManager.instance.cCamera;

        if (param1.DAT_2F == 4)
            param1.DAT_1F1 = 10;
        else
        {
            param1.DAT_1F1 = 0;
            cVar1.DAT_83 = 2;
        }

        param1.DAT_3E++;
        iVar1 = (int)GameManager.FUN_64650();

        if ((iVar1 >> 4 & 1) == 0)
            param1.FUN_609C8(0, 1, param1.DAT_1F1);
        else
        {
            param1.FUN_609C8(3, 1, param1.DAT_1F1);
            param1.DAT_1C0 |= 2;
        }

        param1.DAT_40.z = 0x78;
    }

    //FUN_AE4 (ST9)
    private void FUN_AE4(CriPlayer param1)
    {
        uint uVar1;

        FUN_974(param1);

        if (param1.DAT_2F == 4)
        {
            if (param1.screen.z < -0x1521)
                param1.DAT_3E++;
        }
        else if (-0x1c00 < param1.screen.z)
        {
            param1.DAT_3E += 2;
            SceneManager.instance.cCamera.DAT_83 = 3;
            uVar1 = GameManager.FUN_64650();

            if ((0x84 >> (int)(uVar1 & 7) & 1) != 0)
                param1.DAT_1C0 |= 4;

            param1.DAT_112 = 30;
        }
    }

    //FUN_BA8 (ST9)
    private void FUN_BA8(CriPlayer param1)
    {
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        FUN_974(param1);

        if (param1.screen.z - oVar2.screen.z < 0x1500)
        {
            param1.DAT_3E++;
            param1.DAT_112 = 30;
            param1.screen.z += 0x1500;
        }
    }

    //FUN_C18 (ST9)
    private void FUN_C18(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;
        CriSkinned oVar6;

        oVar6 = param1.DAT_154;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar6.screen);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 5, sVar1);
        param1.vr.y += sVar2;
        bVar3 = param1.FUN_60AB4();

        if (bVar3 && (param1.DAT_1C0 & 2) != 0)
        {
            param1.FUN_609C8(0, 1, param1.DAT_1F1);
            param1.DAT_1C0 &= 0xfffffffd;
        }

        iVar4 = oVar6.screen.z - param1.screen.z;

        if (iVar4 < 0)
            iVar4 = param1.screen.z - oVar6.screen.z;

        if (iVar4 < 0x1500)
        {
            param1.DAT_1C0 |= 8;
            param1.screen.z = oVar6.screen.z + DAT_15FCC[param1.DAT_2F - 3];

            if ((param1.DAT_1C0 & 4) != 0)
            {
                param1.DAT_1C0 &= 0xfffffffb;
                param1.DAT_112 = 0;
            }
        }

        if (param1.DAT_112 == 0)
        {
            if (bVar3)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_40.z = 0;
                param1.DAT_1C0 &= 0xfffffffd;
            }
        }
        else
            param1.DAT_112--;
    }

    //FUN_DA0 (ST9)
    private void FUN_DA0(CriPlayer param1)
    {
        PTR_FUN_16050[param1.DAT_3E](param1);
    }

    //FUN_DDC (ST9)
    private void FUN_DDC(CriPlayer param1)
    {
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;

        if (param1.DAT_2F == 4)
            param1.screen.y = -0xd7c;

        param1.DAT_164 = 1;
        param1.DAT_3E++;
        param1.FUN_609C8(8, 0, 0);
        param1.FUN_656EC();
        oVar2.DAT_3C = 6;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.DAT_98 = param1.DAT_98;
        oVar2.DAT_152 = 1;
        oVar2.vr.y = param1.vr.y;
        param1.DAT_152 = 1;
        param1.PTR_120 = null;
        param1.DAT_120 = 0;
        GameManager.instance.FUN_5DC54();
    }

    //FUN_E7C (ST9)
    private void FUN_E7C(CriPlayer param1)
    {
        byte bVar1;
        int iVar2;

        param1.FUN_60AB4();
        param1.FUN_65714();
        bVar1 = param1.frame.DAT_03;

        if (bVar1 == 0)
            return;

        if (bVar1 == 2)
        {
            GameManager.instance.FUN_5C94C(param1, 50);
            iVar2 = 56;
        }
        else
        {
            if (2 < bVar1)
            {
                if (bVar1 == 3)
                    iVar2 = 57;
                else
                {
                    if (bVar1 != 4)
                        return;

                    iVar2 = 58;
                }

                GameManager.instance.FUN_5C94C(param1, iVar2);
                return;
            }

            if (bVar1 != 1)
                return;

            GameManager.instance.FUN_5C94C(param1, 49);
            iVar2 = 55;
        }

        GameManager.instance.FUN_5C94C(param1, iVar2);
        //FUN_1D988
    }

    //FUN_F5C (ST9)
    private void FUN_F5C(CriPlayer param1)
    {
        PTR_FUN_16060[param1.DAT_3E](param1);
    }

    //FUN_F98 (ST9)
    private void FUN_F98(CriPlayer param1)
    {
        CriCamera cVar1;

        cVar1 = SceneManager.instance.cCamera;
        InventoryManager.FUN_4A7E8(3, 0x20, true);
        param1.DAT_3D = 3;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_40.z = 0;
        param1.DAT_154.DAT_154 = param1;
        param1.DAT_164 = 1;
        cVar1.DAT_70 = 1;
        cVar1.PTR_FUN_8C = cVar1.FUN_1E08;

        if (param1.DAT_2F == 3)
            SceneManager.instance.DAT_7CDC[8].flags &= 0xfffffffd;

        //FUN_1D988
    }

    //FUN_1040 (ST9)
    private void FUN_1040(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(6, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_108C (ST9)
    private void FUN_108C(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        bool bVar5;
        CriSkinned oVar5;

        oVar5 = param1.DAT_154;
        param1.screen.z = oVar5.screen.z + DAT_15FCC[param1.DAT_2F - 3];

        if (param1.frame.DAT_01 < 25)
        {
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar5.screen);
            sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 10, sVar1);
            param1.vr.y += sVar2;
        }

        if (param1.frame.DAT_01 < 30)
        {
            if (param1.DAT_2F == 4)
                param1.screen.y -= 0x20;
        }
        else
        {
            param1.PTR_120 = DAT_15F90;
            param1.DAT_120 = 4;
            bVar3 = SceneManager.instance.FUN_802B8(param1, false, 1);

            if (bVar3)
            {
                FUN_F98(param1);
                return;
            }

            param1.PTR_120 = null;
            param1.DAT_120 = 0;
        }

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(5, 0, 0);
            param1.DAT_40.z = -40;
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_1DF++;
        }

        if (param1.DAT_2F == 4 && param1.frame.DAT_01 == 20 && oVar5.DAT_3C == 1 && oVar5.DAT_3D == 5)
        {
            bVar5 = InventoryManager.FUN_4A87C(3, 0);

            if (!bVar5)
            {
                bVar5 = InventoryManager.FUN_4A87C(3, 1);

                if (!bVar5) goto LAB_1248;

                uVar4 = 0x3e;
            }
            else
                uVar4 = 0x3f;

            InventoryManager.FUN_4A7E8(3, uVar4, true);
        }

        LAB_1248:
        if (param1.frame.DAT_01 == 33)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_1284 (ST9)
    private void FUN_1284(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;
        uint uVar3;

        sVar1 = (short)Utilities.FUN_64838(param1.vr.y, 10, DAT_15FD0[param1.DAT_2F - 3]);
        param1.vr.y += sVar1;

        if (param1.DAT_2F == 4 && param1.frame.DAT_01 < 30)
            param1.screen.y += 0x20;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            if (param1.DAT_2F == 3)
            {
                uVar3 = GameManager.FUN_64650();

                if ((0x43 >> (int)(uVar3 & 7) & 1) != 0)
                {
                    param1.DAT_3E = 0;
                    param1.DAT_40.z = 0;
                }
                else
                {
                    param1.DAT_3F = 0;
                    param1.DAT_3E++;
                    param1.FUN_609C8(0, 0, 0);
                    param1.DAT_40.z = 0x78;
                }
            }
        }
    }

    //FUN_138C (ST9)
    private void FUN_138C(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        int iVar3;
        bool bVar3;
        CriSkinned oVar4;

        oVar4 = param1.DAT_154;

        if (param1.DAT_2F == 3 && param1.DAT_40.z == 0)
        {
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
            sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 10, sVar1);
            param1.vr.y += sVar2;
        }

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3E = 0;
            param1.DAT_40.z = 0;
        }

        iVar3 = param1.screen.z - oVar4.screen.z;

        if (iVar3 < 0)
            iVar3 = oVar4.screen.z - param1.screen.z;

        if (iVar3 < 0x1500)
            param1.screen.z = oVar4.screen.z + DAT_15FCC[param1.DAT_2F - 3];
    }

    //FUN_1478 (ST9)
    private void FUN_1478(CriPlayer param1)
    {
        PTR_FUN_16068[param1.DAT_3E](param1);
    }

    //FUN_14B4 (ST9)
    private void FUN_14B4(CriPlayer param1)
    {
        short sVar1;

        param1.DAT_3E++;
        param1.DAT_40.z = 0;
        param1.FUN_609C8(DAT_16078[param1.DAT_3A], 0, 0);
        sVar1 = -60;

        if (param1.DAT_3A == 0)
        {
            if (param1.DAT_2F != 4) goto LAB_1528;

            sVar1 = 60;
        }

        param1.DAT_40.z = sVar1;
        LAB_1528:
        param1.vr.y = DAT_15FD0[param1.DAT_2F - 3];
        GameManager.instance.FUN_5C94C(param1, DAT_15FE0[param1.DAT_3A]);
        param1.DAT_164 = 2;
    }

    //FUN_1578 (ST9)
    private void FUN_1578(CriPlayer param1)
    {
        bool bVar2;
        CriCamera cVar2;
        uint uVar3;
        CriSkinned oVar4;

        cVar2 = SceneManager.instance.cCamera;
        oVar4 = param1.DAT_154;

        if (param1.DAT_2F == 3)
        {
            if (0x1600 < oVar4.screen.z - param1.screen.z)
                param1.DAT_1C0 &= 0xfffffff7;

            if (param1.screen.z < -0x1c00)
            {
                cVar2.DAT_83 = 2;

                if (cVar2.DAT_68 == 8 && cVar2.DAT_6A == 8)
                {
                    cVar2.DAT_48 = new Vector3Int(0x247, -0xac6, 0x1b80);
                    cVar2.DAT_40 = new Vector3Int(-0x2f7, -0xf66, oVar4.screen.z);
                }

                cVar2.DAT_26 = 20;
                cVar2.DAT_36 = 20;
            }
        }

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3D = 0;

            if (param1.DAT_2F == 3 && param1.DAT_3A == 0)
            {
                uVar3 = GameManager.FUN_64650();

                if ((0x36 >> (int)(uVar3 & 7) & 1) != 0 && (param1.DAT_1C0 & 8) != 0)
                    param1.DAT_3D = 1;
            }

            param1.DAT_3E = 0;
            param1.DAT_1C0 &= 0xfffffffd;
        }

        if (param1.DAT_2F == 4)
        {
            param1.screen.y += 0x20;

            if (-0xd7c < param1.screen.y)
                param1.screen.y = -0xd7c;
        }
    }

    //FUN_1714 (ST9)
    private void FUN_1714(CriPlayer param1)
    {
        PTR_FUN_16080[param1.DAT_3E](param1);
    }

    //FUN_1750 (ST9)
    private void FUN_1750(CriPlayer param1)
    {
        PTR_FUN_16088[param1.DAT_3D](param1);

        if (param1.DAT_3D != 1 && param1.frame.DAT_02 != 0)
            GameManager.instance.FUN_5C94C(param1, DAT_15FE0[param1.frame.DAT_02]);
    }

    //FUN_17D4 (ST9)
    private void FUN_17D4(CriPlayer param1)
    {

    }

    //FUN_1814 (ST9)
    private void FUN_1814(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        uint uVar3;
        CriPlayer oVar4;
        Vector3Int local_18;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            if (param1.DAT_3C == 0 || (param1.DAT_18E & 0x80) == 0)
            {
                param1.DAT_34 = param1.screen;
                FUN_73C(param1);
                PTR_FUN_160A0[param1.DAT_3C](param1);
                param1.DAT_21A &= 0xfff;

                if (param1.DAT_3C != 4)
                {
                    local_18 = new Vector3Int(0, DAT_15FD0[param1.DAT_2F - 3], 0);
                    Utilities.RotMatrix_gte(ref local_18, ref param1.cTransform.rotation);
                }

                param1.FUN_62F3C(ref param1.DAT_40);

                if (param1.DAT_2F == 4)
                {
                    bVar2 = InventoryManager.FUN_4A87C(3, 0x3a);

                    if (bVar2)
                        FUN_3874(param1);
                }

                if (param1.IDAT_1C4 != 0)
                    param1.IDAT_1C4--;

                FUN_57C(param1);
                uVar3 = GameManager.instance.DAT_A2D2;

                if (DAT_15FD4[uVar3] <= param1.DAT_1ED ||
                    DAT_15FD4[uVar3 + 4] <= (byte)param1.DAT_1EE ||
                    DAT_15FD4[uVar3 + 8] <= param1.DAT_1DF)
                    FUN_5B8(param1);

                if (param1.DAT_3D == 0)
                {
                    if ((param1.DAT_1C0 & 2) != 0 && 0x20 < param1.frame.DAT_01)
                    {
                        param1.PTR_120 = DAT_15F90;
                        param1.DAT_120 = 4;
                        bVar2 = SceneManager.instance.FUN_802B8(param1, false, 1);

                        if (bVar2)
                        {
                            oVar4 = (CriPlayer)param1.DAT_154;
                            iVar2 = Utilities.FUN_615EC(oVar4.screen, param1.screen);
                            oVar4.FUN_539F8(1, 300, ((iVar2 - oVar4.vr.y & 0xfff) + 0x200 & 0xfff) >> 10);
                            sVar1 = (short)(oVar4.health - 250);
                            oVar4.health = sVar1;

                            if (sVar1 < 100)
                                oVar4.health = 100;

                            //FUN_1D988
                            oVar4.DAT_177 = 30;
                        }

                        param1.PTR_120 = null;
                        param1.DAT_120 = 0;
                    }
                }
                else
                    param1.FUN_66208();
            }

            if (param1.DAT_3C == 4)
                uVar3 = param1.flags & 0xfffffffb;
            else
                uVar3 = param1.flags | 4;

            param1.flags = uVar3;
        }
    }

    //FUN_1F3C (ST9)
    private void FUN_1F3C(CriPlayer param1)
    {
        return;
    }

    //FUN_1F44 (ST9)
    private void FUN_1F44()
    {
        CriParticle puVar1;
        uint uVar2;

        uVar2 = 0;

        do
        {
            puVar1 = SceneManager.instance.DAT_5FCC[uVar2];

            if (puVar1.tags == 12 || puVar1.tags == 3)
            {
                puVar1.flags &= 0xfffffffd;
                puVar1.FUN_60068();
            }

            uVar2++;
        } while (uVar2 < SceneManager.instance.DAT_5FCC.Length);
    }

    //FUN_1FF0 (ST9)
    private void FUN_1FF0(CriPlayer param1)
    {
        CriPlayer puVar1;
        CriCamera cVar2;

        cVar2 = SceneManager.instance.cCamera;
        param1.DAT_3D = 3;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_40.z = 0;
        param1.DAT_1C0 &= 0xfffffffd;
        param1.DAT_154.DAT_154 = param1;
        cVar2.PTR_FUN_8C = cVar2.FUN_1E08;
        cVar2.DAT_8A = 0;
        SceneManager.instance.DAT_7CDC[4].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[5].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[6].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[7].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[8].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[9].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[10].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[11].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[12].flags &= 0xfffffffd;
        SceneManager.instance.DAT_7CDC[13].flags &= 0xfffffffd;
        //FUN_1D988
        puVar1 = (CriPlayer)param1.PDAT_1F4;

        if (puVar1 != null)
        {
            param1.PDAT_1F4 = null;
            puVar1.DAT_3C++;
        }

        FUN_1F44();
    }

    //FUN_2110 (ST9)
    private void FUN_2110(CriPlayer param1)
    {
        sbyte sVar1;
        CriBone oVar2;
        uint uVar3;
        Vector3Int local_18;

        Utilities.RotMatrix_gte(ref param1.vr, ref param1.cTransform.rotation);
        local_18 = new Vector3Int(param1.PTR_130[param1.DAT_130].pos.x, 0, param1.PTR_130[param1.DAT_130].pos.y);
        local_18 = Utilities.ApplyMatrixSV(ref param1.cTransform.rotation, ref local_18);
        sVar1 = param1.PTR_130[param1.DAT_130].bone;

        if (sVar1 == -1)
        {
            local_18.x += param1.screen.x;
            local_18.z += param1.screen.z;
        }
        else
        {
            oVar2 = Utilities.FUN_601C8(param1.skeleton, sVar1) as CriBone;
            local_18.x += oVar2.screen.x;
            local_18.z += oVar2.screen.z;
        }

        sVar1 = GameManager.instance.FUN_7732C((ushort)local_18.x, (ushort)local_18.z, 0);
        uVar3 = (uint)(sVar1 + 1 & 7);
        param1.DAT_1EB = (byte)uVar3;
        param1.DAT_158.x = DAT_160EC[uVar3 * 2];
        param1.DAT_158.z = DAT_160EC[uVar3 * 2 + 1];
    }

    //FUN_2244 (ST9)
    private void FUN_2244(CriPlayer param1)
    {
        param1.DAT_164 = 1;
        param1.DAT_3F++;
        param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80121a0c), 0, 0, 0);
    }

    //FUN_2288 (ST9)
    private void FUN_2288(CriPlayer param1)
    {
        bool bVar1;
        uint uVar2;

        uVar2 = param1.frame.DAT_03;

        if (uVar2 != 0)
        {
            if (uVar2 == 0x32)
                GameManager.instance.FUN_2984C(0x801a);
            else
                GameManager.instance.FUN_5C94C(param1, DAT_161B4[uVar2 - 1]);
        }

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(DAT_161A8[param1.DAT_3F - 1]), 0, 0, 0);
            param1.DAT_3F++;
        }
    }

    //FUN_2340 (ST9)
    private void FUN_2340(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
        {
            param1.DAT_3F++;
            param1.FUN_609C8(1, 0, 0);
        }
    }

    //FUN_23A4 (ST9)
    private void FUN_23A4(CriPlayer param1)
    {
        bool bVar1;

        if (param1.frame.DAT_01 == 9)
            GameManager.instance.FUN_5C94C(param1, 57);

        if (param1.frame.DAT_01 == 60)
            GameManager.instance.FUN_5C94C(param1, 51);

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            FUN_2110(param1);
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
            param1.DAT_164 = 0;
            param1.FUN_609C8(0, 1, 10);
        }
    }

    //FUN_2450 (ST9)
    private void FUN_2450(CriPlayer param1)
    {
        PTR_FUN_161B8[param1.DAT_3F](param1);
        FUN_2AC(param1);
    }

    //FUN_249C (ST9)
    private void FUN_249C(CriPlayer param1)
    {
        bool bVar1;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F++;
            FUN_2110(param1);
            param1.DAT_164 = 1;
            param1.flags |= 2;
        }

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_164 = 0;
        }
    }

    //FUN_2500 (ST9)
    private void FUN_2500(CriPlayer param1)
    {
        PTR_FUN_161D0[param1.DAT_3E](param1);
        param1.FUN_65890();
    }

    //FUN_254C (ST9)
    private void FUN_254C(CriPlayer param1)
    {
        bool bVar1;

        param1.DAT_175 = 0xff;
        param1.DAT_140 |= 0x8000;
        param1.FUN_60AB4();
        bVar1 = InventoryManager.FUN_4A87C(3, 0x30);

        if (bVar1)
            param1.FUN_65890();
    }

    //FUN_25A4 (ST9)
    private void FUN_25A4(CriPlayer param1)
    {
        param1.DAT_164 = 1;
        param1.DAT_140 &= 0x7fff;
        PTR_FUN_161D8[param1.DAT_18E](param1);
    }

    //FUN_25F4 (ST9)
    private void FUN_25F4(CriPlayer param1)
    {
        uint uVar1;
        ushort uVar2;
        ushort uVar3;
        int iVar5;

        if ((param1.DAT_11E & 0x80) != 0)
        {
            param1.DAT_11E &= 0x7f;

            if (param1.DAT_3C != 4)
            {
                uVar3 = (ushort)(param1.DAT_1A0 >> 4 & 0xf);
                uVar2 = (ushort)(param1.DAT_1A1 & 0xf);

                if (uVar3 == 2)
                {
                    uVar1 = GameManager.FUN_64650();
                    //...
                    iVar5 = 1;
                }
                else if (uVar3 < 3)
                {
                    if (uVar3 == 1)
                    {
                        if (uVar2 < 6 && 1 < uVar2)
                            return;

                        uVar1 = GameManager.FUN_64650();
                        //...
                        iVar5 = 4;
                    }
                }
                else if (uVar3 == 3 && param1.DAT_3D == 1)
                {
                    //...
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    ((CriPlayer)param1.DAT_154).DAT_1C0 &= 0xffffffbf;
                    iVar5 = 8;
                    param1.DAT_11C++;
                }

                //FUN_65D1C
            }
        }
    }

    //FUN_2748 (ST9)
    private void FUN_2748(CriPlayer param1)
    {
        bool bVar1;
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        bVar1 = InventoryManager.FUN_4A87C(2, 2);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(3, 0x22);

            if (!bVar1)
            {
                GameManager.instance.FUN_774CC(param1, oVar2.screen);

                if (param1.DAT_148 < 23 && param1.IDAT_1C4 == 0)
                {
                    param1.DAT_3D = 4;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
            }
        }
    }
     
    //FUN_27D8 (ST9)
    private void FUN_27D8(CriPlayer param1)
    {
        param1.DAT_164 = 0;
        param1.DAT_3E++;
        param1.FUN_609C8(0, 1, 0);
    }

    //FUN_2814 (ST9)
    private void FUN_2814(CriPlayer param1)
    {
        short sVar1;
        short sVar2;

        FUN_2AC(param1);
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 20, sVar1);
        param1.vr.y += sVar2;
        param1.FUN_60AB4();
        param1.FUN_65890();
    }

    //FUN_2870 (ST9)
    private void FUN_2870(CriPlayer param1)
    {
        PTR_FUN_161E0[param1.DAT_3E](param1);
    }

    //FUN_28AC (ST9)
    private void FUN_28AC(CriPlayer param1, sbyte param2)
    {
        CriCamera cVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        uint uVar6;
        CriSkinned oVar7;
        uint uVar8;
        Vector3Int local_50;
        Matrix3x3 auStack_48;

        cVar1 = SceneManager.instance.cCamera;
        uVar4 = 0;
        oVar7 = param1.DAT_154;
        uVar8 = param1.DAT_1D4 & 0xfU;

        do
        {
            bVar3 = GameManager.instance.FUN_768C8(oVar7.screen, DAT_1610C[(uVar4 & 0xff) * 8]);
            uVar6 = uVar4;

            if (bVar3) break;

            uVar4++;
            uVar6 = 0;
        } while ((uVar4 & 0xff) < 8);

        if (param2 == 0)
            cVar1.DAT_8A = 0;
        else
        {
            if (uVar8 != (uVar6 & 0xff))
                param1.DAT_1C0 |= 0x20;

            if ((param1.DAT_1C0 & 0x20) != 0 && cVar1.DAT_8A == 0)
            {
                cVar1.DAT_8A = 3;
                param1.DAT_1C0 &= 0xffffffdf;
            }
        }

        param1.SDAT_1D4 = (short)(uVar6 & 0xff | (ushort)(uVar8 << 8));
        local_50 = new Vector3Int(0, DAT_1618C[uVar6 & 0xff], 0);
        auStack_48 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref local_50, ref auStack_48);
        local_50.y = 0;
        local_50.x = 0x157c;
        local_50 = Utilities.ApplyMatrixSV(ref auStack_48, ref local_50);
        param1.screen.x = oVar7.screen.x + local_50.x;
        param1.screen.z = oVar7.screen.z + local_50.z;
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, oVar7.screen);
        param1.vr.y = sVar2;
    }

    //FUN_2A6C (ST9)
    private void FUN_2A6C(CriPlayer param1)
    {
        CriCamera cVar1;
        short sVar2;
        CriPlayer oVar3;

        cVar1 = SceneManager.instance.cCamera;
        oVar3 = (CriPlayer)param1.DAT_154;

        if ((param1.DAT_1C0 & 1) == 0)
        {
            if (param1.frame.DAT_01 == 0x4b)
                FUN_1FF0(param1);
        }
        else if (param1.DAT_3F == 0)
        {
            param1.DAT_3F = 1;
            cVar1.DAT_4E = 6;
        }
        else
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            cVar1.PTR_FUN_8C = cVar1.FUN_1CFC;
            cVar1.DAT_8A = 0;
            param1.FUN_609C8(6, 0, 0);
            param1.DAT_40.z = 0;
            sVar2 = (short)Utilities.FUN_615EC(oVar3.screen, param1.screen);
            oVar3.vr.y = sVar2;
            param1.PTR_120 = DAT_15F90;
            param1.DAT_120 = 0;
            oVar3.DAT_1C0 |= 0x40;
            param1.DAT_140 &= 0x7fff;
        }
    }

    //FUN_2B68 (ST9)
    private void FUN_2B68(CriPlayer param1)
    {
        CriCamera cVar1;
        CriParticle pVar2;

        cVar1 = SceneManager.instance.cCamera;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F = 1;
            param1.DAT_164 = 1;
            param1.DAT_40 = new Vector3Int(0, 0, 0);
            param1.DAT_140 |= 0x8000;
            cVar1.DAT_70 = 1;
            cVar1.PTR_FUN_8C = cVar1.FUN_3440;
            param1.FUN_609C8(2, 0, 0);
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_1C0 = param1.DAT_1C0 & 0xfffffffe | 10;
            param1.flags &= 0xfffffffd;
            param1.DAT_1DA = 8;
            FUN_28AC(param1, 0);
        }
        else
        {
            param1.DAT_3F = 0;
            param1.DAT_3E++;
            cVar1.DAT_4E = 6;
            pVar2 = SceneManager.instance.FUN_5FFA0();

            if (pVar2 != null)
            {
                pVar2.tags = 27;
                param1.PDAT_1F4 = pVar2;
            }
        }
    }

    //FUN_2C70 (ST9)
    private void FUN_2C70(CriPlayer param1)
    {
        CriPlayer oVar1;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F++;
            GameManager.instance.FUN_5C94C(param1, 60);
        }

        oVar1 = (CriPlayer)param1.DAT_154;
        FUN_28AC(param1, 1);
        param1.FUN_60AB4();
        FUN_2AC(param1);

        if (param1.frame.DAT_01 == 51)
            GameManager.instance.FUN_5C94C(param1, 48);

        if (param1.frame.DAT_01 == 71)
            GameManager.instance.FUN_5C94C(param1, 50);

        if (oVar1.DAT_3C == 1 && oVar1.DAT_3D == 6 && oVar1.DAT_3E == 1 && oVar1.DAT_241 == 0)
            param1.DAT_1C0 |= 1;
    }

    //FUN_2D54 (ST9)
    private void FUN_2D54(CriPlayer param1)
    {
        PTR_FUN_161E8[param1.DAT_3E](param1);
    }

    //FUN_2D90 (ST9)
    private void FUN_2D90(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.DAT_164 = 2;
            param1.DAT_1C0 &= 0xfffffffd;
        }
        else if (param1.DAT_3E != 1) goto LAB_2E04;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            FUN_1FF0(param1);
        }

        LAB_2E04:
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_154.screen);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 20, sVar1);
        param1.vr.y += sVar2;
    }

    //FUN_2E40 (ST9)
    private void FUN_2E40(CriPlayer param1)
    {
        sbyte sVar1;
        short sVar3;
        uint uVar4;
        uint uVar5;
        bool bVar6;
        CriPlayer oVar6;
        CriBone oVar7;
        Vector3Int local_20;

        oVar6 = (CriPlayer)param1.PDAT_1F4;

        if (oVar6 != null)
        {
            oVar6.DAT_3C++;
            param1.PDAT_1F4 = null;
        }

        local_20 = new Vector3Int(param1.PTR_130[param1.DAT_130].pos.x, 0, param1.PTR_130[param1.DAT_130].pos.z);
        local_20 = Utilities.ApplyMatrixSV(ref param1.cTransform.rotation, ref local_20);
        sVar1 = param1.PTR_130[param1.DAT_130].bone;

        if (sVar1 == -1)
        {
            local_20.x += param1.screen.x;
            local_20.z += param1.screen.z;
        }
        else
        {
            oVar7 = Utilities.FUN_601C8(param1.skeleton, sVar1) as CriBone;
            local_20.x += oVar7.screen.x;
            local_20.z += oVar7.screen.z;
        }

        uVar4 = (uint)GameManager.instance.FUN_7732C((ushort)local_20.x, (ushort)local_20.z, 0);

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.FUN_609C8(7, 0, 0);
            SceneManager.instance.FUN_26EBC(0, 0);
            param1.DAT_164 = 0;
        }
        else if (param1.DAT_3E == 1)
        {
            bVar6 = param1.FUN_60AB4();

            if (bVar6)
            {
                uVar5 = uVar4 + 1 & 7;
                param1.DAT_1EB = (byte)uVar5;
                param1.DAT_158.x = DAT_160EC[uVar5 * 2];
                param1.DAT_158.z = DAT_160EC[uVar5 * 2 + 1];
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_1C0 &= 0xfffffff7;
            }
        }

        param1.FUN_65890();
        FUN_2AC(param1);

        if (param1.frame.DAT_03 != 0)
            GameManager.instance.FUN_5C94C(param1, 54);

        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, 20, DAT_1618C[uVar4 & 0xff] + 0x800 & 0xfff);
        param1.vr.y += sVar3;
    }

    //FUN_3084 (ST9)
    private void FUN_3084(CriPlayer param1)
    {
        FUN_25F4(param1);
        PTR_FUN_161F0[param1.DAT_3D](param1);
        PTR_FUN_16204[param1.DAT_3D](param1);
    }

    //FUN_30F0 (ST9)
    private void FUN_30F0(CriPlayer param1)
    {
        sbyte sVar1;
        bool bVar2;
        CriBone oVar2;
        uint uVar3;
        Vector3Int local_18;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0 || param1.DAT_3C != 0 && (param1.DAT_18E & 0x80) != 0)
            goto LAB_33EC;

        param1.DAT_34 = param1.screen;

        if (param1.DAT_3C != 0)
        {
            local_18 = new Vector3Int(param1.PTR_130[param1.DAT_130].pos.x, 0, param1.PTR_130[param1.DAT_130].pos.z);
            local_18 = Utilities.ApplyMatrixSV(ref param1.cTransform.rotation, ref local_18);
            sVar1 = param1.PTR_130[param1.DAT_130].bone;

            if (sVar1 == -1)
            {
                local_18.x += param1.screen.x;
                local_18.z += param1.screen.z;
            }
            else
            {
                oVar2 = Utilities.FUN_601C8(param1.skeleton, sVar1) as CriBone;
                local_18.x += oVar2.screen.x;
                local_18.z += oVar2.screen.z;
            }

            uVar3 = (uint)(int)GameManager.instance.FUN_7732C((ushort)local_18.x, (ushort)local_18.z, 0);

            if ((uVar3 & 0xff) == param1.DAT_1EB)
            {
                uVar3 = param1.DAT_1EB + 1U & 7;
                param1.DAT_1EB = (byte)uVar3;
                param1.DAT_158.x = DAT_160EC[uVar3];
                param1.DAT_158.z = DAT_160EC[uVar3 + 1];
            }

            GameManager.instance.FUN_774CC(param1, param1.DAT_158);
        }

        PTR_FUN_16218[param1.DAT_3C](param1);

        if ((param1.DAT_1C0 & 4) == 0)
        {
            //FUN_81544
            bVar2 = false; //tmp

            if (bVar2)
            {
                InventoryManager.FUN_4A7E8(3, 0x21, true);
                param1.DAT_1C0 |= 4;

                if (param1.PDAT_1F4 != null)
                {
                    ((CriSkinned)param1.PDAT_1F4).DAT_3C++;
                    param1.PDAT_1F4 = null;
                }
            }
        }

        if (param1.DAT_3D != 4 && param1.DAT_3D != 1)
        {
            if (GameManager.instance.DAT_A2D2 == 0)
            {
                if (2 < (ushort)param1.DAT_11C)
                {
                    //FUN_81544
                    bVar2 = false; //tmp

                    if (bVar2)
                        InventoryManager.FUN_4A7E8(3, 0x22, true);
                }
            }
            else if (4 < (ushort)param1.DAT_11C)
            {
                //FUN_81544
                bVar2 = false; //tmp

                if (bVar2)
                    InventoryManager.FUN_4A7E8(3, 0x22, true);
            }
        }

        //FUN_81544
        bVar2 = false; //tmp

        if (bVar2)
            InventoryManager.FUN_4A7E8(3, 0x23, true);

        param1.vr.y &= 0xfff;
        SceneManager.instance.FUN_802B8(param1, true, 1);
        param1.FUN_62F3C(ref param1.DAT_40);

        if (param1.IDAT_1C4 != 0)
            param1.IDAT_1C4--;

        SceneManager.instance.FUN_80A14(param1);
        FUN_57C(param1);

        LAB_33EC:
        if (param1.DAT_3C == 4 || (param1.DAT_1C0 & 2) != 0)
            uVar3 = param1.flags & 0xfffffffb;
        else
            uVar3 = param1.flags | 4;

        param1.flags = uVar3;
    }

    //FUN_375C (ST9)
    private void FUN_375C(CriPlayer param1)
    {
        if (param1.screen.z < -0x1521)
        {
            GameManager.instance.DAT_922C = 1;
            InventoryManager.FUN_4A7E8(3, 0x3b, true);
        }
    }

    //FUN_37AC (ST9)
    private void FUN_37AC(CriPlayer param1)
    {
        if (param1.screen.z < -0x37bd)
        {
            GameManager.instance.DAT_922C = 2;
            InventoryManager.FUN_4A7E8(3, 0x3b, true);
        }
        else if (-0x1521 < param1.screen.y)
            GameManager.instance.DAT_922C = 0;
    }

    //FUN_3824 (ST9)
    private void FUN_3824(CriPlayer param1)
    {
        if (-0x37bd < param1.screen.z)
        {
            GameManager.instance.DAT_922C = 1;
            InventoryManager.FUN_4A7E8(3, 0x3b, true);
        }
    }

    //FUN_3874 (ST9)
    private void FUN_3874(CriPlayer param1)
    {
        PTR_FUN_16244[GameManager.instance.DAT_922C](param1);
    }

    //FUN_1AF8 (ST9)
    public static void FUN_1AF8(CriPlayer param1)
    {
        instance.PTR_FUN_160B4[param1.DAT_2F - 2](param1);

        if ((param1.UDAT_1D2 & 0x8000) != 0)
            instance.FUN_20C(param1);
    }

    //FUN_3ABC (ST9)
    public static void FUN_3ABC(CriPlayer param1)
    {

    }

    //FUN_CC84 (ST9)
    public static void FUN_CC84(CriParticle param1)
    {

    }

    //FUN_D478 (ST9)
    public static void FUN_D478(CriParticle param1)
    {

    }

    //FUN_DD14 (ST9)
    public static void FUN_DD14(CriParticle param1)
    {

    }

    //FUN_DE1C (ST9)
    public static void FUN_DE1C(CriParticle param1)
    {

    }

    //FUN_C864 (ST9)
    public static void FUN_C864(CriParticle param1)
    {

    }

    //FUN_CA8C (ST9)
    public static void FUN_CA8C(CriParticle param1)
    {

    }

    //FUN_DFD0 (ST9)
    public static void FUN_DFD0(CriParticle param1)
    {

    }

    //FUN_E1D8 (ST9)
    public static void FUN_E1D8(CriParticle param1)
    {

    }

    //FUN_E338 (ST9)
    public static void FUN_E338(CriParticle param1)
    {

    }

    //FUN_E4C4 (ST9)
    public static void FUN_E4C4(CriParticle param1)
    {

    }

    //FUN_E664 (ST9)
    public static void FUN_E664(CriParticle param1)
    {

    }

    //FUN_E80C (ST9)
    public static void FUN_E80C(CriParticle param1)
    {

    }

    //FUN_EA84 (ST9)
    public static void FUN_EA84(CriParticle param1)
    {

    }

    //FUN_EAC0 (ST9)
    public static void FUN_EAC0(CriInteract param1)
    {

    }

    //FUN_F0D0 (ST9)
    public static void FUN_F0D0(CriInteract param1)
    {

    }

    //FUN_11F34 (ST9)
    public static void FUN_11F34(CriInteract param1)
    {

    }

    //FUN_11F70 (ST9)
    public static void FUN_11F70(CriInteract param1)
    {

    }

    //FUN_12C54 (ST9)
    public static void FUN_12C54(CriInteract param1)
    {

    }

    //FUN_142A8 (ST9)
    public static void FUN_142A8(CriInteract param1)
    {

    }

    //FUN_143D0 (ST9)
    public static void FUN_143D0(CriInteract param1)
    {

    }

    //FUN_14B2C (ST9)
    public static void FUN_14B2C(CriInteract param1)
    {

    }

    //FUN_14DD0 (ST9)
    public static void FUN_14DD0(CriInteract param1)
    {

    }

    //FUN_152D8 (ST9)
    public static void FUN_152D8(CriInteract param1)
    {

    }

    //FUN_15314 (ST9)
    public static void FUN_15314(CriInteract param1)
    {

    }

    //FUN_15508 (ST9)
    public static void FUN_15508(CriStatic param1)
    {

    }

    //FUN_15590 (ST9)
    public static void FUN_15590(CriStatic param1)
    {

    }
}
