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
    private delegate void FUN_161E0(CriPlayer p); //0x161E0 (ST9)
    private delegate void FUN_161F0(CriPlayer p); //0x161F0 (ST9)
    private delegate void FUN_16204(CriPlayer p); //0x16204 (ST9)
    private delegate void FUN_16218(CriPlayer p); //0x16218 (ST9)
    private CapsuleCollider[] DAT_15F90; //0x15F90 (ST9)
    public short[] DAT_160CC = new short[] { -0x100 -0x510 -0x4b0 -0x3a0 -0x4b0 -0x3a0 }; //0x160CC (ST9)
    public Vector3Int[] DAT_160D8; //0x160D8 (ST9)
    private short[] DAT_160EC = new short[] { -0x3000, -0x19a0, -0x2900, -0x2c80, 0x980, -0x3980, 0x2780, -0x2c80, 0x2d80, 0xf00, 0x2500, 0x2c00, -0x1400, 0x3680, -0x2c00, 0x2800, -0x3b10, 0x3000, -0x1700, 0x3000, -0x2600, 0x1ff0, -0x3b00, 0xf00, -0x39a0, 0x1310, -0x2700, 0x2210, -0x28a0, -0x4000, -0x3b50, -0x30e0, -0x2a10, -0x1f00, -0x1900, -0x2e00, -0xd00, -0x4080, -0x2a00, -0x4100, -0x1b50, -0x2d00, 0x3a00, -0x3000, 0x2500, -0x4200, -0xf00, -0x4100, 0x2500, -0x2200, 0x3900, -0xe00, 0x3900, -0x3200, 0x1300, -0x3200, 0x2600, 0x41f0, 0x38f0, 0x4200, 0x38f0, -0x1100, 0x2600, -0x2200, 0x600, 0x4250, 0x2800, 0x4200, 0x2800, 0x1c00, 0x1a00, 0x2d00, -0x3c00, 0x4200, 0x7f0, 0x4200, 0x1c00, 0x2e00, -0x3b00, 0x2e00 };
    private FUN_161E0[] PTR_FUN_161E0; //0x161E0 (ST9)
    private FUN_161F0[] PTR_FUN_161F0; //0x161F0 (ST9)
    private FUN_16204[] PTR_FUN_16204; //0x16204 (ST9)
    private FUN_16218[] PTR_FUN_16218; //0x16218 (ST9)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_161E0 = new FUN_161E0[]
            {

            };
            PTR_FUN_161F0 = new FUN_161F0[5]
            {
                FUN_2748,
                FUN_1F3C,
                FUN_1F3C,
                FUN_1F3C,
                FUN_2A6C
            };
            PTR_FUN_16204 = new FUN_16204[]
            {
                FUN_2870
            };
            PTR_FUN_16218 = new FUN_16218[]
            {
                FUN_60C
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
        puVar1 = param1.PDAT_1F4;

        if (puVar1 != null)
        {
            param1.PDAT_1F4 = null;
            puVar1.DAT_3C++;
        }

        FUN_1F44();
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

    //FUN_2870 (ST9)
    private void FUN_2870(CriPlayer param1)
    {

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

    //FUN_3084 (ST9)
    private void FUN_3084(CriPlayer param1)
    {
        FUN_25F4(param1);

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

        //...

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
                    param1.PDAT_1F4.DAT_3C++;
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
        //...

        LAB_33EC:
        if (param1.DAT_3C == 4 || (param1.DAT_1C0 & 2) != 0)
            uVar3 = param1.flags & 0xfffffffb;
        else
            uVar3 = param1.flags | 4;

        param1.flags = uVar3;
    }

    //FUN_1AF8 (ST9)
    public static void FUN_1AF8(CriPlayer param1)
    {

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
