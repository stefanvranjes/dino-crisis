using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST6 : LevelManager
{
    public static new ST6 instance;

    public uint[] DAT_15A78 = new uint[232] { 0, 0xd, 0x1b, 0x23, 0x2b, 0x39, 0x43, 0x80000057, 0x0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x1e, 0x21, 0x29, 0x3a, 0x80000065, 0x0, 0xc, 0x13, 0x29, 0x2e, 0x3c, 0x40, 0x44, 0x4c, 0x8000005a, 0x0, 0xf, 0x1e, 0x26, 0x2c, 0x3e, 0x4a, 0x80000059, 0x0, 0xe, 0x1a, 0x1d, 0x22, 0x2c, 0x31, 0x3f, 0x43, 0x48, 0x4c, 0x80000059, 0x0, 0x14, 0x20, 0x28, 0x3c, 0x50, 0x80000066, 0x0, 0x17, 0x1f, 0x24, 0x26, 0x33, 0x36, 0x45, 0x4b, 0x80000056, 0x0, 0xf, 0x14, 0x1d, 0x29, 0x2e, 0x33, 0x38, 0x44, 0x4f, 0x80000052, 0x0, 0xb, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x4f, 0x80000059, 0x0, 0x10, 0x15, 0x25, 0x37, 0x3d, 0x45, 0x4c, 0x80000056, 0x0, 0x4, 0x7, 0xd, 0x11, 0x1c, 0x2f, 0x38, 0x44, 0x80000051, 0x0, 0xe, 0x1f, 0x33, 0x42, 0x4c, 0x80000059, 0x0, 0x5, 0x13, 0x1c, 0x28, 0x33, 0x47, 0x50, 0x8000005d, 0x0, 0x5, 0xf, 0x17, 0x21, 0x2d, 0x36, 0x46, 0x80000051, 0x0, 0x6, 0xe, 0x1d, 0x22, 0x2d, 0x3d, 0x43, 0x80000055, 0x0, 0x5, 0xd, 0x15, 0x24, 0x2b, 0x35, 0x45, 0x80000052, 0x0, 0x7, 0x27, 0x3a, 0x80000056, 0x0, 0x13, 0x31, 0x42, 0x8000005e, 0x0, 0x11, 0x2b, 0x3c, 0x4f, 0x80000060, 0x0, 0xe, 0x20, 0x3d, 0x4e, 0x80000063, 0x0, 0x11, 0x21, 0x29, 0x35, 0x3e, 0x80000054, 0x0, 0x8, 0x27, 0x37, 0x80000046 };
    public TrgScriptableObject DAT_15E18; //0x15E18 (ST6)
    public TrgScriptableObject DAT_15F08; //0x15F08 (ST6)
    public byte[][] DAT_15FF8 = new byte[3][]
    {
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 }
    };
    public FUN_B58BC[] DAT_16088 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758,
                                                     FUN_45B08, null, FUN_45480, null, null, null, FUN_45D38,
                                                     FUN_45E70, null, null, FUN_CD5C, FUN_D550, FUN_DDEC,
                                                     FUN_DEF4, FUN_C904, FUN_CB2C, FUN_E0A8, FUN_E2B0,
                                                     FUN_E410, FUN_E59C, FUN_E73C, FUN_E8E4, FUN_EB5C };
    public FUN_B58C0[] DAT_160F8 = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_1B98, null, null,
                                                     null, null, FUN_3B5C };
    public FUN_C2570[] DAT_1611C = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null,
                                                     FUN_15668, FUN_7F808, null, null, null, FUN_155E0 };
    public FUN_C1CF8[] DAT_1614C = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC,
                                                     FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C,
                                                     null, null, null, FUN_EB98, FUN_1200C, FUN_12048, FUN_14380,
                                                     FUN_F1A8, FUN_144A8, FUN_12D2C, FUN_14C04, FUN_14EA8,
                                                     FUN_153B0, FUN_153EC };
    private CapsuleCollider[] DAT_161E8; //0x161E8 (ST6)
    private short[] DAT_161F8 = new short[2] { 0, 0x800 };
    private short[] DAT_16228 = new short[14] { 4, -4, 20, -20, 20, -20, 10, -10, 8, -8, 2, -2, 1, -1 };
    private short[] DAT_16244 = new short[16] { 4, -4, 10, -10, 10, -10, 8, -8, 4, -4, 1, -1, 1, -1, 4, -400 };
    private delegate void FUN_162DC(CriPlayer p); //0x162DC (ST6)
    private delegate void FUN_16BB0(CriPlayer p); //0x16BB0 (ST6)
    private delegate void FUN_16BCC(CriPlayer p); //0x16BCC (ST6)
    private FUN_162DC[] PTR_FUN_162DC; //0x162DC (ST6)
    private Vector3Int DAT_16314 = new Vector3Int(-0x3000, -0x19A0, -0x2900); //0x16314
    private short[] DAT_16560 = new short[] { 0, 1, 0, 1, 0, 1, 0, 1, 175, 50, 200, 50, 225, 75, 225, 75, 125, 25, 150, 25, 150, 25, 250, 50, 800, 200, 800, 200, 800, 200, 800, 200, 150, 25, 175, 25, 175, 25, 250, 50, 227, 50, 260, 50, 292, 75, 292, 75 };
    private short[] DAT_165C0 = new short[] { 0, 1, 0, 1, 0, 1, 0, 1, 100, 25, 125, 25, 150, 50, 150, 50, 60, 20, 80, 20, 80, 20, 150, 50, 400, 100, 400, 100, 400, 200, 400, 200, 80, 20, 100, 20, 100, 20, 150, 50, 130, 25, 162, 25, 195, 50, 195, 50, 4, -1021, -1017, -16381, 0, 0, 5, -1021, -1012, -16381, -32765, 0, 0, -206, -101, -101, -101, -100, -99, -97, -94, -91, -87, -84, -78, -73, -67, -60, -53, -53, -58, -64, -68, -71, -74, -76, -78, -77, -78, -76, -75, -72, -68, -65, -59, -54, -47, -24, 8, 26, 34, 30, 0, 200, 115, 113, 111, 108, 105, 104, 101, 98, 97, 94, 93, 90, 88, 86, 86, 88, 88, 89, 89, 87, 87, 85, 82, 80, 77, 72, 68, 64, 57, 52, 46, 38, 31, 8, -22, -39, -44, -35 };
    private FUN_16BB0[] PTR_FUN_16BB0; //0x16BB0 (ST6)
    private FUN_16BCC[] PTR_FUN_16BCC; //0x16BCC (ST6)
    private UNK_9B314[] PTR_DAT_16D20; //0x16D20 (ST6)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_162DC = new FUN_162DC[6]
            {
                FUN_3190,
                FUN_18B4,
                FUN_18B4,
                FUN_1C04,
                FUN_1C84,
                FUN_1CFC
            };
            PTR_FUN_16BB0 = new FUN_16BB0[]
            {

            };
            PTR_FUN_16BCC=new FUN_16BCC[]
            {
                FUN_9E40, 
                FUN_A2D0, 
                FUN_A7E4, 
                FUN_A838, 
                FUN_A870, 
                FUN_A8A8
            }
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

    //FUN_10C (ST6)
    public override void Initialize()
    {
        bool bVar1;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_16088;
        PTR_FUN_B58C0 = DAT_160F8;
        PTR_FUN_C2570 = DAT_1611C;
        PTR_FUN_C1CF8 = DAT_1614C;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_15FF8[uVar3];
        SceneManager.instance.DAT_B0 = DAT_15A78;
        GameManager.instance.DAT_46 = 6;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xe2);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_15E18.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_15E18.TRIGGERS[i];
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
            for (int i = 0; i < DAT_15F08.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_15F08.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 6);
    }

    //FUN_2AC (ST6)
    private void FUN_2AC(CriPlayer param1)
    {
        CriCamera cVar1;
        ushort uVar2;

        cVar1 = SceneManager.instance.cCamera;
        uVar2 = (ushort)(param1.UDAT_1D2 >> 8 & 0x7f);
        cVar1.DAT_38 = (short)(DAT_16244[param1.UDAT_1D2 & 0xff] * uVar2);
        cVar1.DAT_3A = (short)(DAT_16228[param1.UDAT_1D2 & 0xff] * uVar2);
        uVar2 = (ushort)(param1.UDAT_1D2 + 1);
        param1.UDAT_1D2 = uVar2;

        if (13 < (uVar2 & 0xffU))
            param1.UDAT_1D2 = 0;
    }

    //FUN_658 (ST6)
    private void FUN_658(CriPlayer param1)
    {
        if (param1.DAT_2F != 4 || (!InventoryManager.FUN_4A87C(3, 0x3f) && !InventoryManager.FUN_4A87C(3, 0x3e)))
            InventoryManager.FUN_4A7E8(3, 0x22, true);
    }

    //FUN_7DC (ST6)
    private void FUN_7DC(CriPlayer param1)
    {
        byte bVar1;
        bool bVar2;
        CriSkinned oVar5;

        oVar5 = param1.DAT_154;

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

        //...
    }

    //FUN_18B4 (ST6)
    private void FUN_18B4(CriPlayer param1)
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
                param1.cTransform.position = param1.screen;
                FUN_7DC(param1);
                //...
                param1.vr.y &= 0xfff;

                if (param1.DAT_3C != 4)
                {
                    local_18 = new Vector3Int(0, DAT_161F8[param1.DAT_2F - 3], 0);
                    Utilities.RotMatrix_gte(ref local_18, ref param1.cTransform.rotation);
                }

                param1.FUN_62F3C(ref param1.DAT_40);
                //...

                if (param1.DAT_3D == 0)
                {
                    if ((param1.DAT_1C0 & 2) != 0 && 0x20 < param1.frame.DAT_01)
                    {
                        param1.PTR_120 = DAT_161E8;
                        param1.DAT_120 = 0;
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

    //FUN_1C04 (ST6)
    private void FUN_1C04(CriPlayer param1)
    {
        param1.DAT_3D++;
        param1.FUN_609C8(9, 0, 0);
        param1.FUN_65714();
        param1.PTR_120 = null;
        param1.DAT_120 = 0;
        param1.PTR_130 = null;
        param1.DAT_130 = 0;
        param1.DAT_1C0 &= 0xfffffffe;
        param1.DAT_140 |= 0x8000;
        param1.DAT_12C |= 8;
        param1.FUN_66418();
    }

    //FUN_1C84 (ST6)
    private void FUN_1C84(CriPlayer param1)
    {
        CriSkinned oVar1;

        oVar1 = param1.DAT_154;
        param1.FUN_60AB4();
        param1.FUN_65714();

        if (oVar1.frame.DAT_03 == 100)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_1CFC (ST6)
    private void FUN_1CFC(CriPlayer param1)
    {
        short sVar1;

        param1.FUN_65714();
        sVar1 = param1.DAT_112;
        param1.DAT_112 = (short)(sVar1 - 1);

        if (sVar1 == 1)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_3190 (ST6)
    private void FUN_3190(CriPlayer param1)
    {
        sbyte sVar1;
        bool bVar2;
        CriBone oVar2;
        uint uVar3;
        byte bVar4;
        SceneColliderScriptableObject oVar5;
        Vector3Int local_18;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0 || param1.DAT_3C != 0 &&
            (param1.DAT_18E & 0x80) != 0) goto LAB_348C;

        param1.DAT_34 = param1.screen;

        if (param1.DAT_3C != 0)
        {
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
                oVar2 = (CriBone)Utilities.FUN_601C8(param1.skeleton, sVar1);
                local_18.x += oVar2.screen.x;
                local_18.z += oVar2.screen.z;
            }

            uVar3 = (uint)(int)GameManager.instance.FUN_7732C((ushort)local_18.x, (ushort)local_18.z, 0);

            if ((uVar3 & 0xff) == param1.DAT_1EB)
            {
                uVar3 = param1.DAT_1EB + 1U & 7;
                param1.DAT_1EB = (byte)uVar3;
                param1.DAT_158.x = DAT_16314.x;
                param1.DAT_158.z = DAT_16314.z;
            }

            GameManager.instance.FUN_774CC(param1, param1.DAT_158);
        }

        //...

        param1.vr.y &= 0xfff;
        SceneManager.instance.FUN_802B8(param1, true, 1);
        param1.FUN_62F3C(ref param1.DAT_40);

        if (param1.IDAT_1C4 != 0)
            param1.IDAT_1C4--;

        SceneManager.instance.FUN_80A14(param1);
        //FUN_61C

        LAB_348C:
        if (param1.DAT_3C == 4 || (param1.DAT_1C0 & 2) != 0)
            uVar3 = param1.flags & 0xfffffffb;
        else
            uVar3 = param1.flags | 4;

        param1.flags = uVar3;
    }

    //FUN_4100 (ST6)
    private void FUN_4100(CriPlayer param1)
    {
        return;
    }

    //FUN_94E4 (ST6)
    private void FUN_94E4(CriPlayer param1)
    {
        if ((param1.DAT_11E & 0x80) == 0)
            param1.BDAT_1EC = 0;
        else
        {
            if ((param1.DAT_18E & 4) != 0)
                param1.DAT_18E &= 0xfb;

            param1.BDAT_1EC = 1;
            param1.DAT_11E &= 0x7b;

        }
    }

    //FUN_9E00 (ST6)
    private void FUN_9E00(CriPlayer param1)
    {

    }

    //FUN_9E40 (ST6)
    private void FUN_9E40(CriPlayer param1)
    {
        short sVar2;
        int iVar3;
        int iVar4;
        short[] aVar5;
        ushort uVar6;
        short sVar7;
        int iVar8;
        int iVar9;
        int psVar10;
        short sVar11;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar4 = (int)GameManager.FUN_64650();
            param1.DAT_1C0 &= 0xfb;
            uVar6 = (ushort)(param1.DAT_1A0 & 0xf);

            if (uVar6 == 1)
                iVar9 = 5;
            else
            {
                iVar9 = 1;

                if (uVar6 == 3)
                    iVar9 = 5;
            }

            iVar9 *= 0x10;
            //...
            aVar5 = DAT_165C0; //tmp
            psVar10 = 0; //tmp

            if (param1.health < 1)
                return;

            sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar11 == 5 || sVar11 == 0x205 || (sVar11 == 0x601 && param1.DAT_60 - 26 < 12) || 
                sVar11 == 0x304 || sVar11 == 2 || param1.DAT_3C == 3)
            {
                iVar3 = (int)GameManager.FUN_64650();
                iVar8 = (ushort)aVar5[psVar10 + 5];
                sVar11 = (short)(iVar3 % iVar9);

                if (iVar8 == 0)
                    return; //trap(0x1c00)

                if (iVar8 == -1 && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar2 = aVar5[psVar10 + 4];
                sVar7 = param1.health;
                param1.DAT_1C5 = 0;
                param1.DAT_11C = (short)(sVar2 + sVar11);
                param1.health = (short)(sVar7 - (sVar2 + sVar11));
            }
            else
            {
                if (sVar11 == 0x105)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    iVar8 = aVar5[psVar10 + 5];

                    if (iVar8 == 0)
                        return; //trap(0x1c00)

                    if (iVar8 == -1 && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    sVar11 = aVar5[psVar10 + 4];
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C5 = 4;
                    param1.DAT_196 = 0;
                    sVar11 += (short)(iVar3 % iVar9);
                    param1.DAT_11C = sVar11;
                    param1.health -= sVar11;
                }
                else
                {
                    if (param1.DAT_3C != 4)
                    {
                        if (param1.UDAT_1DC < ((iVar3 % 10) * 100 & 0xffff) + 0x1194)
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            iVar8 = aVar5[psVar10 + 5];
                            sVar11 = (short)(iVar3 % iVar8);

                            if (iVar8 == 0)
                                return; //trap(0x1c00)

                            if (iVar8 == -1 && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = aVar5[psVar10 + 4];
                            sVar7 = param1.health;
                            param1.DAT_1C5 = 2;
                        }
                        else
                        {
                            if ((((uint)iVar4 % 0x14) * 100 & 0xffff) + 0x1194 <= param1.UDAT_1DC)
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                iVar8 = aVar5[psVar10 + 1];
                                sVar11 = (short)(iVar3 % iVar8);

                                if (iVar8 == 0)
                                    return; //trap(0x1c00)

                                if (iVar8 == -1 && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                sVar2 = aVar5[psVar10];
                                sVar7 = param1.health;
                                param1.DAT_1C5 = 0;
                                param1.DAT_11C = (short)(sVar2 + sVar11);
                                param1.health = (short)(sVar7 - (sVar2 + sVar11));
                                goto LAB_A1A0;
                            }
                            else
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                iVar8 = aVar5[psVar10 + 3];
                                sVar11 = (short)(iVar3 % iVar8);

                                if (iVar8 == 0)
                                    return; //trap(0x1c00)

                                if (iVar8 == -1 && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                sVar2 = aVar5[psVar10 + 2];
                                sVar7 = param1.health;
                                param1.DAT_1C5 = 2;
                            }

                            param1.DAT_11C = (short)(sVar2 + sVar11);
                            param1.health = (short)(sVar7 - (sVar2 + sVar11));
                            goto LAB_A1A0;
                        }

                        param1.DAT_1C5 = 0;
                    }
                }

                LAB_A1A0:
                if (param1.health < 1)
                {
                    InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                    if (param1.DAT_1C5 == 0)
                    {
                        if (param1.DAT_3C == 3)
                            return;

                        if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                            return;
                    }
                }

                sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar11 == 0x202 || (sVar11 == 5 && 0x3d < param1.DAT_60) || 
                    sVar11 == 0x205 && param1.DAT_60 < 0x17)
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 == 0) goto LAB_A2AC;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B4DC(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_A2AC:
        FUN_BC9C(param1);
    }

    //FUN_A2D0 (ST6)
    private void FUN_A2D0(CriPlayer param1)
    {
        short sVar2;
        int iVar3;
        int iVar4;
        short[] aVar5;
        ushort uVar6;
        short sVar7;
        int iVar8;
        int iVar9;
        int psVar10;
        short sVar11;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar4 = (int)GameManager.FUN_64650();
            param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfb);
            uVar6 = (ushort)(param1.DAT_1A0 & 0xf);

            if (uVar6 == 1)
                iVar9 = 5;
            else
            {
                iVar9 = 1;

                if (uVar6 == 3)
                    iVar9 = 5;
            }

            //...
            aVar5 = DAT_16560; //tmp
            psVar10 = 0; //tmp

            if (param1.health < 1)
                return;

            sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar11 == 5 || sVar11 == 0x205 || (sVar11 == 0x601 && param1.DAT_60 - 0x1a < 12) || 
                sVar11 == 0x304 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
            {
                iVar3 = (int)GameManager.FUN_64650();
                iVar8 = aVar5[psVar10 + 5];
                sVar11 = (short)(iVar3 % iVar8);

                if (iVar8 == 0)
                    return; //trap(0x1c00)

                if (iVar8 == -1 && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar7 = aVar5[psVar10 + 4];
                sVar2 = param1.health;
                param1.DAT_1C5 = 0;
                sVar7 = (short)(sVar7 + sVar11 + 100);
                param1.DAT_11C = sVar7;
                param1.health = (short)(sVar2 - sVar7);
            }
            else
            {
                if (sVar11 == 0x105)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    iVar8 = aVar5[psVar10 + 5];
                    sVar11 = (short)(iVar3 % iVar8);

                    if (iVar8 == 0)
                        return; //trap(0x1c00)

                    if (iVar8 == -1 && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    sVar7 = aVar5[psVar10 + 4];
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C5 = 4;
                    sVar2 = param1.health;
                    param1.DAT_196 = 0;
                    sVar7 = (short)(sVar7 + sVar11 + 100);
                    param1.DAT_11C = sVar7;
                    param1.health = (short)(sVar2 - sVar7);
                    goto LAB_A624;
                }

                if (param1.DAT_3C != 4)
                {
                    if (param1.UDAT_1DC < (((uint)iVar3 % 10) * 100 & 0xffff) + 0x157c)
                    {
                        iVar3 = (int)GameManager.FUN_64650();
                        iVar8 = aVar5[psVar10 + 5];
                        sVar11 = (short)(iVar3 % iVar8);

                        if (iVar8 == 0)
                            return; //trap(0x1c00)

                        if (iVar8 == -1 && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar7 = aVar5[psVar10 + 4];
                        sVar2 = param1.health;
                        param1.DAT_1C5 = 2;
                    }
                    else
                    {
                        if ((((uint)iVar4 % 0x14) * 100 & 0xffff) + 6000 <= param1.UDAT_1DC)
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            iVar8 = aVar5[psVar10 + 1];
                            sVar11 = (short)(iVar3 % iVar8);

                            if (iVar8 == 0)
                                return; //trap(0x1c00)

                            if (iVar8 == -1 && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar7 = aVar5[psVar10];
                            sVar2 = param1.health;
                            param1.DAT_1C5 = 0;
                            sVar7 = (short)(sVar7 + sVar11 + 100);
                            param1.DAT_11C = sVar7;
                            param1.health = (short)(sVar2 - sVar7);
                            goto LAB_A624;
                        }

                        iVar3 = (int)GameManager.FUN_64650();
                        iVar8 = aVar5[psVar10 + 3];
                        sVar11 = (short)(iVar3 % iVar8);

                        if (iVar8 == 0)
                            return; //trap(0x1c00)

                        if (iVar8 == -1 && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar7 = aVar5[psVar10 + 2];
                        sVar2 = param1.health;
                        param1.DAT_1C5 = 2;
                    }

                    sVar7 = (short)(sVar7 + sVar11 + 100);
                    param1.DAT_11C = sVar7;
                    param1.health = (short)(sVar2 - sVar7);
                    goto LAB_A624;
                }

                param1.DAT_1C5 = 0;
            }

            LAB_A624:
            if (param1.health < 1)
            {
                InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                if (param1.DAT_1C5 == 0)
                {
                    if (param1.DAT_3C == 3)
                        return;

                    if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                        return;
                }

                sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar11 == 0x202 || sVar11 == 5 &&
                    0x3d < param1.DAT_60 || (sVar11 == 0x205 && param1.DAT_60 < 0x17))
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 == 0) goto LAB_A730;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B4DC(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_A730:
        FUN_BC9C(param1);
    }

    //FUN_A754 (ST6)
    private void FUN_A754(CriPlayer param1)
    {
        if (param1.DAT_3C - 2 < 3)
            param1.DAT_1C5 = 0;
        else
        {
            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            param1.DAT_3C = 2;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_1C5 = 2;
            param1.DAT_1C0 |= 2;
            FUN_B4DC(param1);
        }

        param1.BDAT_1C0 |= 4;
        FUN_B598(param1);
    }

    //FUN_A7E4 (ST6)
    private void FUN_A7E4(CriPlayer param1)
    {
        byte bVar1;

        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 0;
            bVar1 = (byte)(param1.DAT_1C7 + 1);
            param1.DAT_1C7 = (sbyte)bVar1;

            if (1 < bVar1)
                param1.DAT_194 = 1;

            FUN_A754(param1);
        }
    }

    //FUN_A838 (ST6)
    private void FUN_A838(CriPlayer param1)
    {
        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 1;
            param1.DAT_194 = 1;
            FUN_A754(param1);
        }
    }

    //FUN_A870 (ST6)
    private void FUN_A870(CriPlayer param1)
    {
        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 2;
            param1.DAT_194 = 1;
            FUN_A754(param1);
        }
    }

    //FUN_A8A8 (ST6)
    private void FUN_A8A8(CriPlayer param1)
    {
        short sVar2;

        if ((param1.DAT_11E & 1) == 0 && 0 < param1.health)
        {
            if (param1.DAT_3C != 4 || (param1.DAT_3C == 4 && param1.DAT_3D == 3))
                param1.health = -1;

            sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);
            param1.DAT_1C6 = 3;
            param1.DAT_1C0 |= 4;

            if (sVar2 == 5 || param1.DAT_3C == 4 || sVar2 == 0x205 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
                param1.DAT_1C5 = 0;
            else
            {
                if (sVar2 == 0x105)
                {
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_196 = 0;
                    param1.DAT_1C5 = 4;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.health < 1)
            {
                InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                if (param1.DAT_1C5 == 0)
                {
                    if (param1.DAT_3C == 0)
                        return;

                    if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                        return;
                }

                sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar2 == 0x202 || (sVar2 == 5 && 0x3d < param1.DAT_60) ||
                    sVar2 == 0x205 && param1.DAT_60 < 0x17)
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 != 0)
            {
                if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                    FUN_B46C(param1);

                if (param1.DAT_1C5 == 2)
                {
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C0 |= 2;
                }

                FUN_B4DC(param1);
            }
        }

        FUN_B598(param1);
    }

    //FUN_AAF0 (ST6)
    private void FUN_AAF0(CriPlayer param1)
    {

    }

    //FUN_B46C (ST6)
    private void FUN_B46C(CriPlayer param1)
    {
        short sVar1;

        sVar1 = 0x28;

        if ((param1.DAT_1C0 & 8) == 0)
            sVar1 = -0x28;

        param1.vr.y = param1.vr.y + sVar1 * (short)param1.DAT_60 & 0xfff;
    }

    //FUN_B4DC (ST6)
    private void FUN_B4DC(CriPlayer param1)
    {
        CriPlayer oVar1;
        CriPlayer oVar2;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar2 = oVar1.DAT_1DC;
        
        if (oVar1.DAT_3C == 5 && oVar1.DAT_3D == 8 && oVar2 == param1)
        {
            if (2 < oVar1.DAT_3E)
                SceneManager.instance.FUN_26E6C();

            oVar1.DAT_3E = 5;
            oVar1.FUN_6103C(47, 0, 16, 0);
            oVar1.DAT_60 = 0x10;
            oVar1.DAT_18D = true;
            oVar2.DAT_18D = true;
            oVar1.DAT_152 = 0;
            oVar2.DAT_152 = 0;
            oVar1.DAT_11E &= 0xf7;
        }
    }

    //FUN_B598 (ST6)
    private void FUN_B598(CriPlayer param1)
    {
        bool bVar1;
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        uint uVar7;
        int iVar8;

        sVar3 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if ((ushort)(sVar3 - 0x200) < 0xc00)
        {
            iVar8 = 1;

            if (0x3ff < (short)(sVar3 - 0x200))
            {
                iVar8 = 3;

                if ((ushort)(sVar3 - 0x600) < 0x400)
                    iVar8 = 2;
            }
        }
        else
            iVar8 = 0;

        iVar4 = (int)GameManager.FUN_64650();
        iVar6 = iVar4;

        if (iVar4 < 0)
            iVar6 = iVar4 + 3;

        uVar7 = (uint)(iVar4 + (iVar6 >> 2) * -4);
        sVar1 = (sbyte)Utilities.FUN_22EF4(param1, uVar7 + (uint)iVar8 * 4 & 0xff);
        uVar5 = uVar7;

        if (sVar1 != 0)
        {
            uVar5 = Utilities.FUN_22F08(param1, (uint)iVar8);

            if ((uVar5 & 0xff) == 0xff)
            {
                SceneManager.instance.FUN_23068((byte)iVar8, (byte)uVar7);
                uVar5 = uVar7;
            }
        }

        bVar1 = FUN_B708(param1, (uint)iVar8, uVar5 & 0xff);

        if (bVar1)
        {
            bVar2 = (byte)(param1.DAT_199 + 1);
            param1.DAT_199 = bVar2;
            param1.DAT_19A |= (ushort)(1 << (int)(uVar5 + (uint)iVar8 * 4 & 0x1f));

            if (4 < bVar2)
            {
                param1.DAT_199 = 4;
                SceneManager.instance.FUN_22F9C();
            }
        }
    }

    //FUN_B708 (ST6)
    private bool FUN_B708(CriPlayer param1, uint param2, uint param3)
    {
        return param1.FUN_65D78(ref PTR_DAT_16D20[(param2 & 0xff) * 4 + (param3 & 0xff)], (byte)(param2 & 0xff), (byte)(param3 & 0xff));
    }

    //FUN_B748 (ST6)
    private void FUN_B748(CriPlayer param1)
    {
        sbyte sVar1;
        short sVar2;

        sVar2 = param1.DAT_194;

        if (0 < param1.DAT_194)
        {
            sVar1 = (sbyte)param1.DAT_3C;

            if (sVar1 != 3 && sVar1 != 4)
            {
                param1.DAT_194 = (short)(sVar2 - 1);

                if (sVar2 == 1)
                {
                    if (sVar1 == 2)
                        param1.DAT_194 = 1;
                    else
                    {
                        param1.DAT_194 = 0;
                        param1.DAT_3C = 5;
                        param1.DAT_3D = 0;
                        param1.DAT_3E = 0;
                        param1.DAT_3F = 0;
                        param1.FUN_65D0C(0, 30);
                    }
                }
            }
        }
    }

    //FUN_BC9C (ST6)
    private void FUN_BC9C(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;
        int iVar3;
        int iVar4;

        sVar1 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);
        iVar4 = 9;

        if ((ushort)(sVar1 - 0xa00) < 0x400)
        {
            uVar2 = param1.DAT_1CB;
        }
        else
        {
            iVar4 = 7;

            if ((ushort)(sVar1 - 0x200) < 0x400)
            {
                uVar2 = param1.DAT_1CB;
            }
            else
            {
                if ((ushort)(sVar1 - 0x200) < 0xc00)
                {
                    uVar2 = param1.DAT_1CB;
                }
                else
                {
                    iVar4 = 7;
                    uVar2 = param1.DAT_1CB;
                }
            }
        }

        //FUN_65D1C
    }

    //FUN_C140 (ST6)
    private void FUN_C140(CriPlayer param1)
    {
        if ((param1.DAT_1C9 & 1) != 0 && !GameManager.instance.DAT_6D)
        {
            param1.DAT_1C9 &= 0xfe;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_CD5C (ST6)
    public static void FUN_CD5C(CriParticle param1)
    {
        return;
    }

    //FUN_D550 (ST6)
    public static void FUN_D550(CriParticle param1)
    {
        return;
    }

    //FUN_DDEC (ST6)
    public static void FUN_DDEC(CriParticle param1)
    {
        return;
    }

    //FUN_DEF4 (ST6)
    public static void FUN_DEF4(CriParticle param1)
    {
        return;
    }

    //FUN_C904 (ST6)
    public static void FUN_C904(CriParticle param1)
    {
        return;
    }

    //FUN_CB2C (ST6)
    public static void FUN_CB2C(CriParticle param1)
    {
        return;
    }

    //FUN_E0A8 (ST6)
    public static void FUN_E0A8(CriParticle param1)
    {
        return;
    }

    //FUN_E2B0 (ST6)
    public static void FUN_E2B0(CriParticle param1)
    {
        return;
    }

    //FUN_E410 (ST6)
    public static void FUN_E410(CriParticle param1)
    {
        return;
    }

    //FUN_E59C (ST6)
    public static void FUN_E59C(CriParticle param1)
    {
        return;
    }

    //FUN_E73C (ST6)
    public static void FUN_E73C(CriParticle param1)
    {
        return;
    }

    //FUN_E8E4 (ST6)
    public static void FUN_E8E4(CriParticle param1)
    {
        return;
    }

    //FUN_EB5C (ST6)
    public static void FUN_EB5C(CriParticle param1)
    {
        return;
    }

    //FUN_1B98 (ST6)
    public static void FUN_1B98(CriPlayer param1)
    {
        instance.PTR_FUN_162DC[param1.DAT_2F - 2](param1);

        if ((param1.UDAT_1D2 & 0x8000) != 0)
            instance.FUN_2AC(param1);
    }

    //FUN_3B5C (ST6)
    public static void FUN_3B5C(CriPlayer param1)
    {
        sbyte sVar1;
        ushort uVar3;
        uint uVar4;
        CriPlayer oVar5;
        Vector3Int vVar6;

        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if (param1.DAT_3C != 0)
        {
            if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            {
                param1.FUN_66208();
                return;
            }

            if ((param1.DAT_18E & 0x80) != 0)
            {
                param1.FUN_66208();
                goto LAB_3D84;
            }
        }

        if (param1.DAT_3C == 1 && param1.DAT_3D == 1)
            vVar6 = (Vector3Int)param1.VDAT_1E4;
        else
            vVar6 = param1.screen;

        sVar1 = GameManager.instance.FUN_774CC(param1, vVar6);
        param1.DAT_1C2 = (byte)sVar1;

        if ((sbyte)param1.DAT_1C2 == -1)
        {
            GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
            sVar1 = GameManager.instance.FUN_774CC(param1, (Vector3Int)param1.VDAT_1E4);
        }

        param1.cTransform.position = param1.screen;
        uVar4 = Utilities.FUN_631AC(param1.screen, oVar5.screen);
        param1.UDAT_1DC = uVar4;

        if (param1.DAT_177 != 0)
            param1.DAT_177--;

        instance.FUN_C140(param1);
        instance.FUN_B748(param1);
        uVar3 = (ushort)(param1.UDAT_1D2 - 1);

        if (0 < param1.UDAT_1D2)
        {
            param1.UDAT_1D2 = uVar3;

            if (uVar3 << 0x10 < 0)
                param1.UDAT_1D2 = 0;
        }



        LAB_3D84:
        param1.FUN_6449C(param1.DAT_140);
        param1.DAT_48 = (sbyte)-(param1.screen.y / 0x1a9);
    }

    //FUN_15668 (ST6)
    public static void FUN_15668(CriStatic param1)
    {
        return;
    }

    //FUN_155E0 (ST6)
    public static void FUN_155E0(CriStatic param1)
    {
        return;
    }

    //FUN_EB98 (ST6)
    public static void FUN_EB98(CriInteract param1)
    {
        return;
    }

    //FUN_1200C (ST6)
    public static void FUN_1200C(CriInteract param1)
    {
        return;
    }

    //FUN_12048 (ST6)
    public static void FUN_12048(CriInteract param1)
    {
        return;
    }

    //FUN_14380 (ST6)
    public static void FUN_14380(CriInteract param1)
    {
        return;
    }

    //FUN_F1A8 (ST6)
    public static void FUN_F1A8(CriInteract param1)
    {
        return;
    }

    //FUN_144A8 (ST6)
    public static void FUN_144A8(CriInteract param1)
    {
        return;
    }

    //FUN_12D2C (ST6)
    public static void FUN_12D2C(CriInteract param1)
    {
        return;
    }

    //FUN_14C04 (ST6)
    public static void FUN_14C04(CriInteract param1)
    {
        return;
    }

    //FUN_14EA8 (ST6)
    public static void FUN_14EA8(CriInteract param1)
    {
        return;
    }

    //FUN_153B0 (ST6)
    public static void FUN_153B0(CriInteract param1)
    {
        return;
    }

    //FUN_153EC (ST6)
    public static void FUN_153EC(CriInteract param1)
    {
        return;
    }
}
