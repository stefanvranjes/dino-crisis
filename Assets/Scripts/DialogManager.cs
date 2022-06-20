using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public ushort[] DAT_B12C0;
    public TriggerScriptableObject DAT_B1388;
    public byte DAT_B138C;
    public byte DAT_B138D;
    public byte DAT_B138E;
    public byte DAT_B138F;
    public byte DAT_B1390;
    public byte DAT_B1391;
    public byte DAT_B1392;
    public byte DAT_B1393;
    public ushort[] PTR_B146C;
    public int DAT_B146C;
    public ushort[] PTR_B1470;
    public int DAT_B1470;
    public ushort[] PTR_B1474;
    public int DAT_B1474;
    public ushort DAT_B1478;
    public ushort DAT_B147A;
    public ushort DAT_B147C;
    public byte DAT_B147E;
    public byte DAT_B147F;
    public byte DAT_B1480;
    public byte DAT_B1481;
    public byte DAT_B1482;
    public byte DAT_B1483;
    public byte DAT_B1484;
    public byte DAT_B1485;
    public byte DAT_B1486;
    public byte DAT_B1487;
    public byte DAT_B1488;
    public byte DAT_B1489;
    public byte DAT_B148A;
    public byte DAT_B148B;
    public byte DAT_B148C;
    public static DialogManager instance;
    public static int[] DAT_98594;
    public static ushort[] DAT_98628;
    public static int[] DAT_9E9C0;
    public static ushort[] DAT_9F0EC;
    public static ushort[] DAT_A593C;
    public delegate bool FUN_99028(TriggerScriptableObject t);
    public FUN_99028[] PTR_FUN_99028;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            PTR_FUN_99028 = new FUN_99028[12]
            {
                FUN_1AB50,
                FUN_1B2A8,
                FUN_1B304,
                FUN_1B334,
                FUN_1B360,
                FUN_1B7C8,
                FUN_1B820,
                FUN_1B8B8,
                FUN_1B93C,
                FUN_1B9DC,
                FUN_1BA04,
                FUN_1BA74
            };
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FUN_1BAB4(byte param1, TriggerScriptableObject param2)
    {
        DAT_B1388 = param2;
        DAT_B138C = param1;
        InventoryManager.FUN_4A7E8(2, 0xe, true);
        DAT_B138D = 0;
        DAT_B138F = 0;
        DAT_B1390 = 0;
        DAT_B1391 = 0;
        DAT_B1392 = 0;
        DAT_B1393 = 0;
        InventoryManager.FUN_4A7E8(1, 0, true);
        InventoryManager.FUN_4A7E8(1, 1, true);
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(1, 3, true);
        InventoryManager.FUN_4A7E8(1, 6, true);
        InventoryManager.FUN_4A7E8(1, 7, true);
        InventoryManager.FUN_4A7E8(1, 0xa, true);
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        InventoryManager.FUN_4A7E8(1, 0xc, true);
        InventoryManager.FUN_4A7E8(1, 0xd, true);
        InventoryManager.FUN_4A7E8(1, 0xe, true);
    }

    public void FUN_1BCA4(ushort[] param1, int param2)
    {
        ushort uVar1;
        byte bVar2;

        uVar1 = param1[param2];
        bVar2 = DAT_B138D;

        while (uVar1 != 0xa000)
        {
            DAT_B138D = (byte)(bVar2 + 1);
            uVar1 = param1[param2];
            param2++;
            DAT_B12C0[bVar2] = uVar1;
            uVar1 = param1[param2];
            bVar2 = DAT_B138D;
        }

        DAT_B138D = bVar2;
        DAT_B12C0[bVar2] = 0xa000;
    }

    public int FUN_1CC54(int param1)
    {
        return DAT_98594[param1];
    }

    public void FUN_1E2D8(ushort[] param1, int param2, byte param3, ushort param4)
    {
        byte bVar1;

        DAT_B147A = (ushort)GameManager.instance.DAT_40;
        DAT_B147E = 30;
        DAT_B1489 = 0;
        DAT_B148C = 0;
        DAT_B148B = 0;
        DAT_B1488 = 0;
        DAT_B1485 = 0;
        DAT_B1483 = 0;
        DAT_B1480 = 0;
        DAT_B147F = 0;
        DAT_B147C = 0;
        DAT_B148A = 40;
        PTR_B1474 = param1;
        DAT_B1474 = param2;
        DAT_B1478 = param4;
        bVar1 = (byte)(InventoryManager.FUN_4A87C(2, 0xc) ? 1 : 0);
        DAT_B1482 = (byte)(param3 | bVar1);
        DAT_B1481 = 1;
        InventoryManager.FUN_4A7E8(2, 4, false);
        InventoryManager.FUN_4A7E8(2, 5, false);
        InventoryManager.FUN_4A7E8(2, 6, false);
        InventoryManager.FUN_4A7E8(2, 7, false);
        InventoryManager.FUN_4A7E8(2, 0x18, false);

        if ((param3 & 2) == 0)
        {
            DAT_B148C = 25;
            DAT_B1486 = 2;
            DAT_B1487 = 12;
        }
        else
        {
            DAT_B148C = 40;
            DAT_B1486 = 1;
            DAT_B1487 = 2;
            DAT_B1474 += 2;
        }

        DAT_B1484 = 1;
        DAT_B1470 = DAT_B1474;
        PTR_B1470 = PTR_B1474;
        DAT_B146C = DAT_B1474;
        PTR_B146C = PTR_B1474;
        GameManager.instance.DAT_40 |= DAT_B1478;
        InventoryManager.FUN_4A7E8(2, 0, true);
    }

    private bool FUN_1AB50(TriggerScriptableObject param1)
    {
        bool bVar1;
        int iVar2;
        byte bVar3;
        int iVar4;

        InventoryManager.FUN_4A7E8(1, 0xb, true);
        bVar3 = param1.BDAT_24;

        if (bVar3 < 9)
        {
            if (5 < bVar3)
            {
                bVar3 = 0;
                bVar1 = InventoryManager.FUN_4A87C(11, 0x38);

                if (bVar1)
                    bVar3 = 6;

                bVar1 = InventoryManager.FUN_4A87C(11, 0x39);

                if (bVar1)
                    bVar3 = 7;

                bVar1 = InventoryManager.FUN_4A87C(11, 0x3a);

                if (bVar1)
                    bVar3 = 8;

                if (bVar3 < (uint)param1.BDAT_24)
                {
                    FUN_1BAB4(0, param1);
                    //sound
                    FUN_1BCA4(DAT_98628, 1190);
                    DAT_B12C0[41] = (ushort)(DAT_98628
                        [DAT_98594[1]] - (param1.BDAT_24 - 6 << 1));
                    FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                    DAT_B1390++;
                    return false;
                }

                InventoryManager.FUN_4A7E8(9, param1.DAT_23, true);
                //sound
                FUN_1BAB4(7, param1);
                return false;
            }

            if (bVar3 == 1)
            {
                bVar1 = InventoryManager.FUN_4A87C(9, param1.DAT_23);

                if (!bVar1)
                {
                    FUN_1BAB4(0, param1);
                    //sound
                    iVar2 = FUN_1CC54(11);
                    FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                    return false;
                }

                goto LAB_1AFA0;
            }

            if (bVar3 < 2)
            {
                if (bVar3 == 0) goto LAB_1AFA0;
            }
            else
            {
                if (bVar3 == 2)
                {
                    bVar1 = InventoryManager.FUN_4A87C(9, param1.DAT_23);

                    if (!bVar1)
                    {
                        InventoryManager.FUN_4A7E8(9, param1.DAT_23, true);
                        iVar2 = FUN_1CC54(12);
                        FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                        //sound
                        return false;
                    }

                    goto LAB_1AFA0;
                }

                if (bVar3 == 3)
                {
                    bVar1 = InventoryManager.FUN_4A87C(9, param1.DAT_23);

                    if (!bVar1)
                    {
                        FUN_1BAB4(0, param1);
                        //sound
                        iVar2 = FUN_1CC54(23);
                        FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                        return false;
                    }

                    goto LAB_1AFA0;
                }
            }
        }
        else
        {
            if (bVar3 == 254)
            {
                FUN_1BAB4(0, param1);
                iVar2 = FUN_1CC54(26);
                FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                return false;
            }

            if (bVar3 < 0xff)
            {
                if (bVar3 == 0xfd)
                {
                    FUN_1BAB4(0, param1);
                    //sound
                    iVar2 = FUN_1CC54(25);
                    FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                    return false;
                }
            }
            else
            {
                if (bVar3 == 0xff)
                {
                    FUN_1BAB4(0, param1);
                    //sound
                    iVar2 = FUN_1CC54(24);
                    FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                    return false;
                }
            }
        }

        bVar1 = InventoryManager.FUN_4A87C(9, param1.DAT_23);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(11, param1.BDAT_24);

            if (!bVar1)
            {
                FUN_1BAB4(0, param1);
                //sound
                FUN_1BCA4(DAT_98628, 44);
                iVar2 = FUN_67988(param1.BDAT_24);
                FUN_1BCA4(DAT_9F0EC, iVar2);
                iVar4 = 60;
            }
            else
            {
                InventoryManager.FUN_4A7E8(9, param1.DAT_23, true);
                InventoryManager.FUN_4A7E8(11, param1.BDAT_24, false);
                FUN_1BAB4(0, param1);
                //sound
                FUN_1BCA4(DAT_98628, 23);
                iVar2 = FUN_67988(param1.BDAT_24);
                FUN_1BCA4(DAT_9F0EC, iVar2);
                iVar4 = 4;
            }

            FUN_1BCA4(DAT_98628, iVar4);
            FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
            return false;
        }

        LAB_1AFA0:
        //FUN_1AFC4
        return false;
    }

    private bool FUN_1B2A8(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(1, 11, true);
        SceneManager.instance.DAT_27C[10].DAT_3C = 1;
        //FUN_1E2D8
        return false;
    }

    private bool FUN_1B304(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(param1.DAT_18, param1.DAT_19, param1.DAT_1A == 0 ? false : true);
        return true;
    }

    private bool FUN_1B334(TriggerScriptableObject param1)
    {
        //FUN_55580
        return false;
    }

    private bool FUN_1B360(TriggerScriptableObject param1)
    {
        byte bVar1;
        ushort uVar2;
        bool bVar3;
        uint uVar4;

        InventoryManager.FUN_4A7E8(1, 0xb, true);
        DAT_B138E = param1.DAT_18;
        bVar3 = true;

        if ((param1.DAT_18 | param1.DAT_19 << 8) == 0xff)
        {
            uVar4 = param1.DAT_1C - 0xbdU & 0xffffU;

            if ((GameManager.instance.DAT_A090[uVar4] & 0x40) == 0)
            {
                bVar1 = SceneManager.instance.FUN_47864();
                GameManager.instance.DAT_A090[uVar4] |= (byte)(bVar1 | 0x40);
            }

            DAT_B138E = (byte)(GameManager.instance.DAT_A090[uVar4] & 0x3f);
            uVar2 = FUN_47808(DAT_B138E);
            param1.DAT_1A = (byte)uVar2;
            param1.DAT_1B = (byte)(uVar2 >> 8);
        }

        if (param1.IDAT_24 == 0 || (SceneManager.instance.DAT_7CDC[param1.DAT_1E].flags & 2) != 0)
        {
            if (param1.DAT_1F == 0)
            {
                FUN_1B4CC(param1);
                bVar3 = false;
            }
            else
            {
                FUN_1BAB4(6, param1);
                bVar3 = false;
            }
        }

        return bVar3;
    }

    private bool FUN_1B7C8(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        param1.DAT_13 = false;
        ((CriPlayer)SceneManager.instance.DAT_27C[10]).FUN_5397C(param1.DAT_18);
        //sound
        return false;
    }

    private bool FUN_1B820(TriggerScriptableObject param1)
    {
        int iVar2;
        CriPlayer oVar4;

        InventoryManager.FUN_4A7E8(1, 0xb, true);
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (oVar4.DAT_177 == 0)
        {
            oVar4.DAT_177 = 40;
            iVar2 = Utilities.FUN_615EC(oVar4.screen, oVar4.DAT_34);
            oVar4.FUN_53A2C(0, (uint)(((iVar2 - oVar4.vr.y & 0xfff) + 0xa00) >> 10 & 3));
        }

        return false;
    }

    private bool FUN_1B8B8(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);

        if (param1.DAT_28 == 0xff)
            InventoryManager.FUN_4A7E8(param1.DAT_28, param1.DAT_29, true);

        //FUN_1F0C4
        return false;
    }

    private bool FUN_1B93C(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);

        if (param1.DAT_19 == 0 || InventoryManager.FUN_4A87C(9, param1.DAT_18 + 0x2fU))
        {
            GameManager.instance.DAT_2E = param1.DAT_18;
            GameManager.instance.DAT_39 = 5;
            InventoryManager.FUN_4A7E8(1, 0xb, false);
            InventoryManager.FUN_4A7E8(2, 0xf, true);
        }
        else
            FUN_1BAB4(1, param1);

        return false;
    }

    private bool FUN_1B9DC(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        return false;
    }

    private bool FUN_1BA04(TriggerScriptableObject param1)
    {
        bool bVar1;
        bool bVar2;

        InventoryManager.FUN_4A7E8(6, 0x41, true);
        bVar1 = InventoryManager.FUN_4A87C(2, 0x10);
        bVar2 = true;

        if (bVar1 && GameManager.instance.DAT_20 == 0x41)
        {
            FUN_1BAB4(2, param1);
            bVar2 = false;
        }

        return bVar2;
    }

    private bool FUN_1BA74(TriggerScriptableObject param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        FUN_1BAB4(4, param1);
        return false;
    }

    private void FUN_1BD1C(TriggerScriptableObject param1)
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(2, 0);

        if (!bVar1)
            InventoryManager.FUN_1BBCC();
    }

    private void FUN_1BD58(TriggerScriptableObject param1)
    {
        int iVar2;
        bool bVar2;
        int puVar3;

        switch (DAT_B1390)
        {
            case 0:
                if (param1.DAT_18 < 8U)
                    iVar2 = 153;
                else
                {
                    if (param1.DAT_18 < 13U)
                        iVar2 = 199;
                    else
                        iVar2 = 256;
                }

                puVar3 = iVar2;
                goto LAB_1BFD8;
            case 1:
                bVar2 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar2)
                    return;

                DAT_B138D = 0;

                if (param1.DAT_19 == 1)
                {
                    puVar3 = 322;
                    goto LAB_1BFD8;
                }

                FUN_1BCA4(DAT_98628, 369);
                DAT_B12C0[11] = (ushort)(DAT_98628[DAT_98594[0]] + param1.DAT_19 * 2);
                goto LAB_1BFE0;
            case 2:
                bVar2 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar2)
                    return;

                if ((uint)param1.DAT_19 <= GameManager.instance.DAT_A0E0)
                {
                    DAT_B1390 = 3;
                    return;
                }

                DAT_B1390 = 5;
                return;
            case 3:
                iVar2 = 418;
                break;
            case 4:
                bVar2 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar2)
                    return;

                bVar2 = InventoryManager.FUN_4A87C(2, 4);

                if (bVar2)
                {
                    InventoryManager.FUN_1BBCC();
                    InventoryManager.FUN_4A7E8(9, param1.DAT_18, true);
                    GameManager.instance.DAT_A0E0 -= param1.DAT_19;

                    if (GameManager.instance.DAT_A0E0 == 0)
                        InventoryManager.FUN_4A7E8(11, 0x2b, false);

                    GameManager.instance.DAT_2E = param1.DAT_18;
                    GameManager.instance.DAT_39 = 5;
                    InventoryManager.FUN_4A7E8(1, 0xb, false);
                    InventoryManager.FUN_4A7E8(2, 0xf, true);
                }

                bVar2 = InventoryManager.FUN_4A87C(2, 5);

                if (!bVar2)
                    return;

                goto LAB_1C020;
            case 5:
                iVar2 = 445;
                break;
            case 6:
                bVar2 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar2)
                    return;

                LAB_1C020:
                InventoryManager.FUN_1BBCC();
                goto default;
            default:
                return;
        }

        DAT_B138D = 0;
        puVar3 = iVar2;
        LAB_1BFD8:
        FUN_1BCA4(DAT_98628, puVar3);
        LAB_1BFE0:
        FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
        DAT_B1390++;
    }

    private void FUN_1B4CC(TriggerScriptableObject param1)
    {
        int iVar1;
        byte bVar2;
        byte[] local_10;

        if (DAT_B138E < 43U && 15U < DAT_B138E)
        {
            local_10 = new byte[3];
            local_10[0] = DAT_B138E;
            local_10[1] = param1.DAT_1A;
            local_10[2] = FUN_6FCA8(DAT_B138E);
            iVar1 = (int)FUN_68028(local_10);
            bVar2 = 5;

            if (iVar1 != 0)
                bVar2 = 3;

            FUN_1BAB4(bVar2, param1);
        }
        else
            FUN_1B550(param1);
    }

    private void FUN_1B550(TriggerScriptableObject param1)
    {
        int iVar1;
        CriObject oVar2;
        byte bVar4;

        if (DAT_B138E < 0x10U)
            GameManager.instance.DAT_39 = 1;
        else
        {
            switch (DAT_B138E)
            {
                case 0x20:
                    GameManager.instance.DAT_9EE8 += param1.DAT_1A;
                    break;
                case 0x21:
                    GameManager.instance.DAT_9EE9 += param1.DAT_1A;
                    break;
                case 0x22:
                    GameManager.instance.DAT_9EEA += param1.DAT_1A;
                    break;
                case 0x23:
                    GameManager.instance.DAT_9EEB += param1.DAT_1A;
                    break;
                case 0x2b:
                    GameManager.instance.DAT_A0E0 += (ushort)(param1.DAT_1A | param1.DAT_1B << 8);
                    break;
            }

            GameManager.instance.DAT_39 = 0;
        }

        param1.DAT_13 = false;

        if ((ushort)(param1.DAT_18 | param1.DAT_19 << 8) == 0xff)
            iVar1 = 8;
        else
            iVar1 = 7;

        InventoryManager.FUN_4A7E8(iVar1, param1.DAT_1C, true);
        InventoryManager.FUN_4A7E8(11, DAT_B138E, true);
        GameManager.instance.DAT_2E = (ushort)(DAT_B138E | (param1.DAT_1A | param1.DAT_1B << 8) << 8);
        InventoryManager.FUN_4A7E8(1, 0xb, false);
        InventoryManager.FUN_4A7E8(2, 0xf, true);

        if (param1.DAT_1E != 0xff)
            SceneManager.instance.DAT_7CDC[param1.DAT_1E].ResetValues();

        //...
    }

    public int FUN_67988(int param1)
    {
        return DAT_9E9C0[DAT_A593C[param1 * 6 + 2]];
    }

    private uint FUN_68028(byte[] param1)
    {
        byte bVar1;
        byte bVar2;
        byte bVar3;
        byte bVar4;
        uint uVar5;
        int pbVar6;
        uint uVar7;
        int iVar8;
        int pbVar9;
        uint uVar10;
        byte[] local_58;

        local_58 = new byte[64];
        pbVar9 = 0;
        uVar10 = param1[1];
        bVar1 = param1[2];
        bVar2 = param1[0];
        bVar3 = GameManager.instance.DAT_9ADE;
        Array.Copy(GameManager.instance.DAT_9EAC, local_58, bVar3 * 4);
        uVar7 = 0;

        if (uVar10 != 0)
        {
            iVar8 = bVar2 * 6;
            pbVar6 = 1;

            do
            {
                if (bVar3 <= uVar7)
                    return uVar10;

                uVar5 = local_58[pbVar6];

                if (uVar5 == 0)
                {
                    bVar4 = (byte)(DAT_A593C[iVar8] >> 8);

                    if (bVar4 < uVar10)
                    {
                        local_58[pbVar9] = bVar2;
                        local_58[pbVar6 + 1] = bVar1;
                        uVar10 -= bVar4;
                        local_58[pbVar6] = (byte)(DAT_A593C[iVar8] >> 8);
                    }
                    else
                    {
                        local_58[pbVar6] = (byte)uVar10;
                        uVar10 = 0;
                        local_58[pbVar9] = bVar2;
                        local_58[pbVar6 + 1] = bVar1;
                    }
                }
                else
                {
                    if (local_58[pbVar9] == bVar2 && local_58[pbVar6 + 1] == bVar1 &&
                        uVar10 < (byte)(DAT_A593C[iVar8] >> 8))
                    {
                        bVar4 = (byte)(DAT_A593C[iVar8] >> 8);

                        if (bVar4 < uVar10 + uVar5)
                        {
                            uVar10 -= bVar4 - uVar5;
                            local_58[pbVar6] = bVar4;
                        }
                        else
                        {
                            local_58[pbVar6] = (byte)(uVar10 + uVar5);
                            uVar10 = 0;
                        }
                    }
                }

                pbVar6 += 4;
                pbVar9 += 4;
                uVar7++;
            } while (uVar10 != 0);
        }

        return uVar10;
    }

    private static ushort FUN_47808(int param1)
    {
        ushort uVar1;

        uVar1 = 1;

        switch (param1)
        {
            case 0x10:
            case 0x11:
                uVar1 = 5;
                break;
            case 0x16:
                uVar1 = 0x11;
                break;
            case 0x17:
                uVar1 = 0xf;
                break;
            case 0x18:
            case 0x19:
                uVar1 = 3;
                break;
            case 0x1b:
            case 0x1d:
            case 0x20:
            case 0x21:
            case 0x22:
            case 0x23:
            case 0x2b:
                uVar1 = 1;
                break;
        }

        return uVar1;
    }

    public static byte FUN_6FCA8(int param1)
    {
        switch (param1)
        {
            case 0x12:
            case 0x1b:
                return 1;
            case 0x13:
            case 0x1c:
                return 4;
            case 0x14:
            case 0x1d:
                return 7;
            case 0x15:
            case 0x1f:
                return 0x1d;
            default:
                return 1;
            case 0x1e:
                return 10;
        }
    }
}
