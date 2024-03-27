using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST5 : LevelManager
{
    public static new ST5 instance;

    public uint[] DAT_11A90 = new uint[205] { 0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x11, 0x1a, 0x25, 0x29, 0x34, 0x49, 0x8000005c, 0x0, 0xf, 0x25, 0x30, 0x80000052, 0x0, 0x14, 0x1f, 0x28, 0x36, 0x47, 0x80000056, 0x0, 0x11, 0x1c, 0x2e, 0x41, 0x80000057, 0x0, 0xc, 0x1c, 0x2e, 0x41, 0x80000054, 0x0, 0x12, 0x29, 0x3a, 0x80000053, 0x0, 0xa, 0x10, 0x23, 0x2a, 0x3d, 0x80000055, 0x0, 0x10, 0x19, 0x20, 0x31, 0x3d, 0x80000057, 0x0, 0x23, 0x2c, 0x3f, 0x4f, 0x8000006e, 0x0, 0x4, 0x1b, 0x26, 0x49, 0x8000005a, 0x0, 0x14, 0x32, 0x4c, 0x80000060, 0x0, 0x8, 0x14, 0x23, 0x26, 0x2f, 0x3b, 0x46, 0x80000063, 0x0, 0x24, 0x31, 0x8000005a, 0x0, 0x11, 0x17, 0x22, 0x38, 0x3c, 0x41, 0x80000053, 0x0, 0x8, 0x1b, 0x1f, 0x36, 0x3e, 0x4e, 0x8000005f, 0x0, 0x3, 0x13, 0x23, 0x2a, 0x39, 0x44, 0x80000053, 0x0, 0xc, 0x1f, 0x29, 0x3a, 0x46, 0x80000055, 0x0, 0x7, 0x15, 0x20, 0x28, 0x39, 0x40, 0x46, 0x80000057, 0x0, 0x8, 0xb, 0xf, 0x12, 0x1f, 0x32, 0x36, 0x44, 0x48, 0x80000051, 0x0, 0xa, 0xf, 0x1a, 0x2b, 0x36, 0x3f, 0x80000056, 0x0, 0xa, 0x18, 0x29, 0x30, 0x3b, 0x8000005f, 0x0, 0xe, 0x80000023 };
    public TrgScriptableObject DAT_11DC4; //0x11DC4 (ST5)
    public TrgScriptableObject DAT_11EB4; //0x11EB4 (ST5)
    public byte[][] DAT_11FA4 = new byte[3][]
    {
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 10, 5, 1, 22, 0, 0, 0, 23, 0, 0, 0, 16, 20, 11, 6, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 }
    };
    public FUN_C1CF8[] DAT_120D0 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_20A98,
                                                     FUN_21758, FUN_21ECC, FUN_22178, null, FUN_184C,
                                                     null, FUN_222AC, FUN_22464, FUN_2268C, null, null, null,
                                                     FUN_B54, FUN_2D68, FUN_1810, FUN_34FC, FUN_3070,
                                                     null, FUN_88D0, FUN_62CC, FUN_ACB8, FUN_E4DC,
                                                     FUN_F824, FUN_62CC, FUN_ACB8 };
    private delegate void FUN_122C8(CriInteract i); //0x122C8 (ST5)
    private delegate void FUN_122E8(CriInteract i); //0x122E8 (ST5)
    private delegate void FUN_1237C(CriInteract i); //0x1237C (ST5)
    private FUN_122C8[] PTR_FUN_122C8; //0x122C8 (ST5)
    private FUN_122E8[] PTR_FUN_122E8; //0x122E8 (ST5)
    private FUN_1237C[] PTR_FUN_1237C; //0x1237C (ST5)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_122C8 = new FUN_122C8[7]
            {
                FUN_BA8,
                FUN_E44,
                FUN_FD4,
                FUN_D8C,
                FUN_5FF98,
                FUN_E44,
                FUN_10E8
            };
            PTR_FUN_122E8 = new FUN_122E8[5]
            {
                FUN_1164,
                FUN_11F4,
                FUN_13EC,
                FUN_14A4,
                FUN_5FF98
            };
            PTR_FUN_1237C = new FUN_1237C[7]
            {
                FUN_1888,
                FUN_196C,
                FUN_1B7C,
                FUN_1C70,
                FUN_1D58,
                FUN_1DB0,
                FUN_5FF98
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

    //FUN_134 (ST5)
    public override void Initialize()
    {
        bool bVar1;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_C1CF8 = DAT_120D0;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_11FA4[uVar3];
        SceneManager.instance.DAT_B0 = DAT_11A90;
        GameManager.instance.DAT_46 = 5;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xe1);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_11DC4.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_11EB4.TRIGGERS[i];
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
            for (int i = 0; i < DAT_11EB4.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_11EB4.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 5);
        bVar1 = InventoryManager.FUN_4A87C(0, 0xf);

        if (!bVar1)
        {
            SceneManager.instance.DAT_9EEC[3].DAT_03 |= 2;
            SceneManager.instance.DAT_9EEC[4].DAT_03 |= 2;
        }
    }

    //FUN_BA8 (ST5)
    private void FUN_BA8(CriInteract param1)
    {
        byte bVar1;
        ushort uVar2;
        ushort uVar3;
        CriPlayer oVar4;
        byte bVar5;
        uint uVar6;
        short sVar7;
        uint uVar8;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = oVar4.DAT_1D7;
        param1.BDAT_08 = bVar1;

        if ((oVar4.DAT_1C0 & 8) != 0)
        {
            bVar5 = (byte)(bVar1 - 1);
            param1.BDAT_08 = bVar5;

            if ((bVar5 << 0x18) < 0)
                param1.BDAT_08 = 0;
        }

        if (oVar4.DAT_3D == 5)
        {
            if (param1.BDAT_08 == 0)
                uVar6 = (uint)(oVar4.frameNum * 0x16);
            else
                uVar6 = (uint)(oVar4.frameNum << 5);
        }
        else
        {
            if (oVar4.DAT_3D != 1)
            {
                param1.DAT_16 = 0;
                goto LAB_C98;
            }

            if (param1.DAT_08 == 0)
            {
                if (param1.BDAT_08 == 0)
                    uVar6 = (uint)(oVar4.frameNum * 0x16);
                else
                    uVar6 = (uint)(oVar4.frameNum << 5);
            }

            uVar6 = (uint)(oVar4.frameNum << 5);
        }

        uVar8 = oVar4.frameCount + 1U & 0xff;

        if (uVar8 == 0)
            return; // trap(0x1c00)

        param1.DAT_16 = (ushort)(uVar6 / uVar8);
        LAB_C98:
        uVar2 = oVar4.DAT_140;
        oVar4.DAT_3C = 4;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        oVar4.DAT_152 = 2;
        uVar3 = oVar4.DAT_12C;
        oVar4.DAT_40.z = 0;
        oVar4.DAT_140 = (ushort)(uVar2 | 0x8000);
        bVar5 = oVar4.DAT_174;
        oVar4.DAT_12C = (ushort)(uVar3 | 0x10);
        oVar4.DAT_174 = (byte)(bVar5 & 0x7f);
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(2, 18, true);
        param1.DAT_0A = param1.DAT_07;
        param1.DAT_07 = 0x80;
        param1.DAT_03 = (sbyte)(param1.DAT_02 + 1);

        if (param1.DAT_02 == 0)
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * -0x1a9);
        else
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * 0x1a9);

        param1.DAT_0C = sVar7;
    }

    //FUN_D8C (ST5)
    private void FUN_D8C(CriInteract param1)
    {
        byte bVar1;
        CriPlayer oVar4;
        short sVar2;
        ushort uVar3;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar4.DAT_3C = 1;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        sVar2 = param1.DAT_0C;
        oVar4.DAT_140 &= 0x7fff;
        uVar3 = oVar4.DAT_12C;
        oVar4.DAT_152 = 0;
        oVar4.screen.y = sVar2;
        bVar1 = oVar4.DAT_174;
        oVar4.DAT_12C = (ushort)(uVar3 & 0xffef);
        oVar4.DAT_174 = (byte)(bVar1 | 0x80);
        InventoryManager.FUN_4A7E8(1, 2, false);
        InventoryManager.FUN_4A7E8(2, 18, false);
        oVar4.FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(oVar4.DAT_220), 1, 10, oVar4.DAT_220);
        param1.DAT_03++;
    }

    //FUN_E44 (ST5)
    private void FUN_E44(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        auStack56 = new Matrix3x3();
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018da38), 1, (byte)param1.DAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -19;
        }
        else 
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e8b8), 1, (byte)param1.DAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -13;
        }

        param1.DAT_0A = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_FD4 (ST5)
    private void FUN_FD4(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        auStack56 = new Matrix3x3();
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e178), 1, (byte)param1.DAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018f340), 1, (byte)param1.DAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 13;
        }

        param1.DAT_0A = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_10E8 (ST5)
    private void FUN_10E8(CriInteract param1)
    {
        CriPlayer oVar1;
        int iVar2;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1.screen.x += param1.VDAT_0E.x;
        oVar1.screen.y += param1.VDAT_0E.y;
        oVar1.screen.z += param1.VDAT_0E.z;
        iVar2 = (int)(param1.DAT_0A - param1.VDAT_0E.y);
        param1.DAT_0A = (short)iVar2;

        if (iVar2 * 0x10000 < 0)
            param1.DAT_03 = 3;
    }

    //FUN_1164 (ST5)
    private void FUN_1164(CriInteract param1)
    {
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        //...
        param1.BDAT_0A = 0;
        param1.DAT_09 = false;
        param1.DAT_03 = 1;
    }

    //FUN_11F4 (ST5)
    private void FUN_11F4(CriInteract param1)
    {
        byte bVar1;

        //FUN_E94E4

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (param1.BDAT_08 == 4)
                param1.BDAT_08 = 0;
            else
                param1.BDAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            bVar1 = (byte)(param1.BDAT_08 - 1);

            if (param1.BDAT_08 == 0)
                bVar1 = 4;

            param1.BDAT_08 = bVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            bVar1 = (byte)(param1.BDAT_09 - 1);

            if (param1.BDAT_09 == 0)
                bVar1 = 1;

            param1.BDAT_09 = bVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (param1.BDAT_09 == 1)
                param1.BDAT_09 = 0;
            else
                param1.BDAT_09++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            //...
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (param1.BDAT_0A == 0)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_03 = 4;
            }
            else
            {
                //...
            }
        }
    }

    //FUN_13EC (ST5)
    private void FUN_13EC(CriInteract param1)
    {
        bool bVar1;
        int iVar5;

        bVar1 = false;
        //...

        if (bVar1)
        {
            InventoryManager.FUN_4A7E8(2, 10, true);
            iVar5 = 149;
        }
        else
        {
            InventoryManager.FUN_4A7E8(2, 9, true);
            iVar5 = 148;
        }

        GameManager.instance.FUN_5C94C(null, iVar5);
        param1.DAT_03 = 3;
    }

    //FUN_14A4 (ST5)
    private void FUN_14A4(CriInteract param1)
    {
        bool bVar1;

        //FUN_E94A4
        bVar1 = InventoryManager.FUN_4A87C(3, 48);

        if (bVar1)
            param1.DAT_03 = 4;
    }

    //FUN_1888 (ST5)
    private void FUN_1888(CriInteract param1)
    {
        byte bVar1;
        bool bVar3;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 18, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = 0;
        //...
        bVar3 = InventoryManager.FUN_4A87C(3, 0x20);
        bVar1 = 3;

        if (!bVar3)
            bVar1 = 1;

        param1.DAT_03 = (sbyte)bVar1;
    }

    //FUN_196C (ST5)
    private void FUN_196C(CriInteract param1)
    {
        short sVar1;

        //FUN_E9DBC

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (param1.DAT_08 == 4)
                param1.DAT_08 = 0;
            else
                param1.DAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            //...
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            sVar1 = (short)(param1.DAT_0A - 1);

            if (param1.DAT_0A == 0)
                sVar1 = 1;

            param1.DAT_0A = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (param1.DAT_0A == 1)
                param1.DAT_0A = 0;
            else
                param1.DAT_0A++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        //...
    }

    //FUN_1B7C (ST5)
    private void FUN_1B7C(CriInteract param1)
    {
        //...
        return;
    }

    //FUN_1C70 (ST5)
    private void FUN_1C70(CriInteract param1)
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;

        if (param1.DAT_0C == 0)
        {
            bVar3 = InventoryManager.FUN_4A87C(3, 0x24);

            if (bVar3)
            {
                bVar3 = InventoryManager.FUN_4A87C(3, 0x23);

                if (bVar3)
                    InventoryManager.FUN_4A7E8(2, 10, true);
            }
        }

        //FUN_EA16C
        sVar2 = (short)(param1.DAT_0C + 1);
        param1.DAT_0C = sVar2;

        if (sVar2 == 150)
        {
            bVar3 = InventoryManager.FUN_4A87C(2, 10);
            sVar1 = 5;

            if (!bVar3)
                sVar1 = 4;

            param1.DAT_03 = sVar1;

            if (param1.DAT_0C == 150)
            {
                bVar3 = InventoryManager.FUN_4A87C(2, 10);

                if (!bVar3)
                    iVar4 = 148;
                else
                    iVar4 = 149;

                GameManager.instance.FUN_5C94C(null, iVar4);
            }
        }
    }

    //FUN_1D58 (ST5)
    private void FUN_1D58(CriInteract param1)
    {
        //...
        return;
    }

    //FUN_1DB0 (ST5)
    private void FUN_1DB0(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    private void FUN_5FF98(CriInteract param1)
    {
        param1.FUN_5FF98();
    }

    //FUN_B54 (ST5)
    public static void FUN_B54(CriInteract param1)
    {
        ((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_1C0 &= 0xfffffffe;
        instance.PTR_FUN_122C8[param1.DAT_03](param1);
    }

    //FUN_1810 (ST5)
    public static void FUN_1810(CriInteract param1)
    {
        instance.PTR_FUN_122E8[param1.DAT_03](param1);
    }

    //FUN_184C (ST5)
    public static void FUN_184C(CriInteract param1)
    {
        return;
    }

    //FUN_2D68 (ST5)
    public static void FUN_2D68(CriInteract param1)
    {
        return;
    }

    //FUN_3070 (ST5)
    public static void FUN_3070(CriInteract param1)
    {
        return;
    }

    //FUN_34FC (ST5)
    public static void FUN_34FC(CriInteract param1)
    {
        return;
    }

    //FUN_62CC (ST5)
    public static void FUN_62CC(CriInteract param1)
    {
        return;
    }

    //FUN_88D0 (ST5)
    public static void FUN_88D0(CriInteract param1)
    {
        return;
    }

    //FUN_ACB8 (ST5)
    public static void FUN_ACB8(CriInteract param1)
    {
        return;
    }

    //FUN_E4DC (ST5)
    public static void FUN_E4DC(CriInteract param1)
    {
        return;
    }

    //FUN_F824 (ST5)
    public static void FUN_F824(CriInteract param1)
    {
        return;
    }
}
