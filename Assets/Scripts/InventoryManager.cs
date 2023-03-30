using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryText
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
}

[System.Serializable]
public class InventoryWindow
{
    public bool DAT_00;
    public sbyte DAT_01;
    public bool DAT_02;
    public byte DAT_03;
    public int DAT_04;
    public int DAT_08;
    public short DAT_0C;
    public short DAT_0E;
    public short DAT_10;
    public short DAT_12;
    public short DAT_14;
    public short DAT_16;
    public short DAT_18;
    public short DAT_1A;
    public InventoryText[] DAT_38;
    public byte DAT_50;
}

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public static uint[] DAT_C1500 = new uint[8];
    public static uint[] DAT_B7A60 = new uint[1]; //unsure
    public static uint[] DAT_B7A5C = new uint[1];
    public static uint[] DAT_C15C8 = new uint[2];
    public static uint[] DAT_C1560 = new uint[8];
    public static uint[] DAT_C1580 = new uint[8];
    public static uint[] DAT_B7AA4 = new uint[8]; //unsure
    public static uint[] DAT_C1520 = new uint[8];
    public static uint[] DAT_C1540 = new uint[8];
    public static uint[] DAT_C15A0 = new uint[2];
    public static uint[] DAT_C0C80 = new uint[8]; //unsure
    public static uint[] DAT_C15A8 = new uint[8];
    public static uint[] DAT_C15D0 = new uint[8]; //unsure
    public static uint[][] PTR_DAT_9CD18 = new uint[13][]
    {
        DAT_C1500, DAT_B7A60, DAT_B7A5C,
        DAT_C15C8, DAT_C1560, DAT_C1580,
        DAT_B7AA4, DAT_C1520, DAT_C1540,
        DAT_C15A0, DAT_C0C80, DAT_C15A8,
        DAT_C15D0
    };
    public static uint[] DAT_9CD1C = new uint[13]
    {
        0x100, 0x20, 0x20,
        0x40, 0x100, 0x100,
        0x100, 0x100, 0x100,
        0x40, 0x20, 0x100,
        0x80
    };
    public byte DAT_C6100;
    public byte DAT_C6101;
    public byte DAT_C6102;
    public bool DAT_C6103;
    public byte DAT_C6104;
    public bool DAT_C6107;
    public byte DAT_C6108;
    public byte DAT_C6109;
    public ushort DAT_C610A;
    public ushort DAT_C610C;
    public ushort DAT_C610E;
    public ushort DAT_C6110;
    public ushort DAT_C612E;
    public InventoryWindow[] DAT_C6130;
    public byte DAT_C618B;
    public uint DAT_C61F8;
    public byte DAT_C61FC;
    public byte DAT_C61FE;
    public byte DAT_C61FF;
    public ushort[] DAT_C6210;
    public byte[] DAT_C6280;
    public byte DAT_C6290;
    public int DAT_C6294;
    public ushort[] DAT_C6298;
    public delegate void FUN_A60D0();
    public delegate void FUN_A60DC();
    public delegate void FUN_A614C();
    public FUN_A60D0[] PTR_FUN_A60D0;
    public FUN_A60DC[] PTR_FUN_A60DC;
    public FUN_A614C[] PTR_FUN_A614C;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DAT_C6130 = new InventoryWindow[2];
            DAT_C6280 = new byte[16];
            DAT_C6298 = new ushort[12];
            PTR_FUN_A60D0 = new FUN_A60D0[3]
            {
                FUN_667BC,
                FUN_66994,
                FUN_66B94
            };
            PTR_FUN_A60DC = new FUN_A60DC[6]
            {
                FUN_6B08C,
                FUN_68598,
                FUN_6CF38,
                FUN_7007C,
                FUN_7007C,
                FUN_6E898
            };
            PTR_FUN_A614C = new FUN_A614C[3]
            {
                FUN_6B14C,
                FUN_6B2F0,
                FUN_6B32C
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

    public static void FUN_1BBCC()
    {
        FUN_4A7E8(2, 0xe, false);
        FUN_4A7E8(1, 0, false);
        FUN_4A7E8(1, 1, false);
        FUN_4A7E8(1, 2, false);
        FUN_4A7E8(1, 3, false);
        FUN_4A7E8(1, 6, false);
        FUN_4A7E8(1, 7, false);
        FUN_4A7E8(1, 10, false);
        FUN_4A7E8(1, 0xb, false);
        FUN_4A7E8(1, 0xc, false);
        FUN_4A7E8(1, 0xd, false);
        FUN_4A7E8(1, 0xe, false);
    }

    public static void FUN_4A7E8(int param1, uint param2, bool param3)
    {
        uint puVar1;

        puVar1 = param2 >> 5;

        if (!param3)
        {
            PTR_DAT_9CD18[param1][puVar1] &= ~(1U << (int)(param2 & 0x1f));
            return;
        }
        
        PTR_DAT_9CD18[param1][puVar1] |= 1U << (int)(param2 & 0x1f);

        if (param1 == 1 && param2 == 2)
        {
            InputManager.controllers[0].DAT_B58B8 = 0;
            GameManager.DAT_1f80000a = 0;
            GameManager.DAT_1f800008 = 0;
            InputManager.controllers[0].DAT_B5898 = 0;
        }
    }

    public static bool FUN_4A87C(int param1, uint param2)
    {
        return (PTR_DAT_9CD18[param1][param2 >> 5] & 1U << (int)(param2 & 0x1f)) != 0;
    }

    private void FUN_667BC()
    {
        byte bVar1;
        CriPlayer oVar2;
        byte bVar3;
        byte[] local_18 = new byte[3];

        //ResetValues();
        GameManager.instance.DAT_2A++;
        //FUN_674E8
        FUN_67BF8(10);
        DAT_C61F8 = DAT_B7A60[0];
        FUN_4A7E8(1, 2, false);
        //FUN_1CC7C
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = oVar2.DAT_240;
        DAT_C6108 = bVar1;
        DAT_C6109 = bVar1;
        DAT_C610C = (ushort)((uint)oVar2.DAT_244[0] >> 8);
        DAT_C610E = (ushort)((uint)oVar2.DAT_244[1] >> 8);
        DAT_C6110 = (ushort)((uint)oVar2.DAT_244[2] >> 8);

        if (GameManager.instance.DAT_39 == 4) goto LAB_66978;

        DAT_C6100 = GameManager.instance.DAT_39;
        bVar1 = (byte)GameManager.instance.DAT_2E;
        DAT_C61FE = 60;
        DAT_C6101 = 1;
        DAT_C61FC = bVar1;
        bVar3 = GameManager.instance.DAT_39;

        if (bVar3 == 1)
        {
            DAT_C6103 = false;
            DAT_C6104 = 3;
            bVar3 = (byte)(DAT_C61FF | 1);
        }
        else
        {
            if (bVar3 < 2)
            {
                if (bVar3 == 0)
                {
                    DAT_C61FF |= 1;

                    if ((byte)GameManager.instance.DAT_2E - 16U < 20)
                    {
                        local_18[1] = (byte)(GameManager.instance.DAT_2E >> 8);
                        local_18[0] = (byte)GameManager.instance.DAT_2E;
                        local_18[2] = FUN_6FCA8(local_18[0]);
                        DialogManager.instance.FUN_68188(local_18);
                    }

                    DAT_C6104 = 3;
                }

                goto LAB_66978;
            }

            if (bVar3 != 2) goto LAB_66978;

            bVar3 = (byte)(DAT_C61FF | 2);
        }

        DAT_C61FF = bVar3;
        LAB_66978:
        FUN_6AC20();
    }

    private void FUN_66994()
    {
        ushort uVar1;

        DAT_C6294 = 3;

        if (DAT_C6101 == 0)
        {
            uVar1 = DAT_C612E;

            if ((uVar1 & 0x1000) == 0)
            {
                if ((uVar1 & 0x4000) == 0)
                {
                    if ((uVar1 & 0xa0) == 0)
                    {
                        if ((uVar1 & 0x40) != 0)
                        {
                            GameManager.instance.FUN_5C94C(null, 1);
                            GameManager.instance.DAT_2A = 2;
                        }
                    }
                    else
                    {
                        if (DAT_C6100 != 2) //tmp
                        {
                            GameManager.instance.FUN_5C94C(null, 2);
                            //ResetValues
                            DAT_C6107 = false;
                            DAT_C6101++;

                            if (DAT_C6100 == 4)
                                GameManager.instance.DAT_2A = 2;
                        }
                        else
                            GameManager.instance.FUN_5C94C(null, 1);
                    }
                }
                else
                {
                    if (DAT_C6100 < 4U)
                    {
                        DAT_C6100++;
                        GameManager.instance.FUN_5C94C(null, 0);
                    }
                }
            }
            else
            {
                if (DAT_C6100 != 0)
                {
                    DAT_C6100--;
                    GameManager.instance.FUN_5C94C(null, 0);
                }
            }

            DAT_C610A = (ushort)(DAT_C6100 + 0x10a);

            if (DAT_C6100 == 2)
                DAT_C610A = 0x10f;

            //FUN_67AD8
        }
        else
        {
            if (DAT_C6101 != 1) goto LAB_66B58;
            else
            {
                //...

                if (1U < DAT_C6100) goto LAB_66B58;
            }
        }

        //FUN_67F08
        
        LAB_66B58:
        if ((DAT_C612E & 0x10) != 0)
        {
            GameManager.instance.DAT_2A = 2;
            GameManager.instance.FUN_5C94C(null, 1);
        }
    }

    private void FUN_66B94()
    {
        CriPlayer oVar2;

        //FUN_1CC7C
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_C6109 != DAT_C6108)
            oVar2.DAT_240 = DAT_C6108;

        oVar2.FUN_4FE90(DAT_C6108);
        oVar2.DAT_3C = 1;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.FUN_53984(0, 1, 0);
        FUN_6AC20();
        FUN_4A7E8(2, 0xf, false);
        DAT_B7A60[0] = DAT_C61F8;
        GameManager.instance.DAT_28 = 3;
        GameManager.instance.DAT_2E = 0;
        GameManager.instance.DAT_2C = 0;
        GameManager.instance.DAT_2A = 0;
        FUN_4A7E8(2, 8, false);
        //ResetValues
    }

    private byte FUN_67BF8(byte param1)
    {
        byte bVar1;
        int puVar2;
        uint uVar3;
        uint uVar4;

        bVar1 = DAT_C6290;
        puVar2 = 0;
        uVar3 = 0;
        DAT_C6290 = param1;

        do
        {
            DAT_C6280[puVar2] = 0;
            uVar4 = uVar3 + 1;
            puVar2 = (int)uVar3 + 1;
            uVar3 = uVar4;
        } while (uVar4 < 16);

        return bVar1;
    }

    public uint FUN_67C30()
    {
        ushort uVar1;
        int pbVar2;
        uint uVar3;
        uint uVar4;

        uVar4 = 0;
        uVar3 = 0;
        pbVar2 = 0;

        do
        {
            if ((InputManager.controllers[0].DAT_B5898 >> (int)(uVar3 & 31) & 1) == 0)
                DAT_C6280[pbVar2] = 0;
            else
                DAT_C6280[pbVar2]++;

            uVar1 = InputManager.controllers[0].DAT_B58B8;

            if ((uint)DAT_C6290 <= DAT_C6280[pbVar2])
            {
                DAT_C6280[pbVar2] = (byte)(DAT_C6290 >> 1);
                uVar1 = InputManager.controllers[0].DAT_B5898;
            }

            uVar4 |= uVar1 & 1U << (int)(uVar3 & 31);
            uVar3++;
            pbVar2++;
        } while (uVar3 < 16);

        return uVar4;
    }

    private void FUN_68598()
    {
        return;
    }

    public ushort FUN_6AB5C(uint param1)
    {
        if (param1 != 0xff)
            return DAT_C6298[param1 - 16];

        return 0;
    }

    private void FUN_6AC20()
    {
        int pbVar1;
        int iVar2;

        DAT_C6298 = new ushort[12];
        iVar2 = GameManager.instance.DAT_9ADE;
        pbVar1 = 0;

        while (--iVar2 != -1)
        {
            if (GameManager.instance.DAT_9EAC[pbVar1] - 16U < 11)
                DAT_C6298[GameManager.instance.DAT_9EAC[pbVar1] - 16] += 
                    GameManager.instance.DAT_9EAC[pbVar1 + 1];

            pbVar1 += 4;
        }

        ((CriPlayer)SceneManager.instance.DAT_27C[10]).FUN_50CC8();
    }

    private void FUN_6B08C()
    {
        //FUN_6AF38

        if (DAT_C618B == 0)
            PTR_FUN_A614C[DAT_C6102]();

        FUN_6CDD8(DAT_C6130, 0);
        FUN_6BFDC(DAT_C6130, 0);
    }

    private void FUN_6B14C()
    {
        return;
    }

    private void FUN_6B2F0()
    {
        return;
    }

    private void FUN_6B32C()
    {
        return;
    }

    private void FUN_6BFDC(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        short sVar2;
        ushort[] uVar3;
        int iVar4;
        InventoryText pbVar5;
        int iVar7;
        int iVar8;
        int iVar9;
        uint uVar10;

        uVar10 = 0;
        iVar9 = -53;
        iVar8 = -59;
        iVar7 = param1[param2].DAT_0E;
        sVar2 = param1[param2].DAT_12;
        DAT_C6294 = param1[param2].DAT_50;

        do
        {
            pbVar5 = param1[param2].DAT_38[uVar10];

            if (pbVar5.DAT_01 != 0)
            {
                iVar4 = sVar2 + iVar8;
                bVar1 = pbVar5.DAT_00;
                iVar8 += 26;
                //FUN_67904
                uVar3 = FUN_71350(pbVar5);
                //...
                iVar9 += 26;
            }

            uVar10++;
        } while (uVar10 < 5);
    }

    private void FUN_6CDD8(InventoryWindow[] param1, int param2)
    {
        sbyte sVar1;
        byte bVar2;
        int iVar3;
        int iVar4;
        InventoryWindow pcVar5;

        if (param2 < 2)
        {
            do
            {
                pcVar5 = param1[param2];

                if (pcVar5.DAT_00)
                {
                    if (!pcVar5.DAT_02)
                    {
                        pcVar5.DAT_0C += (short)pcVar5.DAT_04;
                        sVar1 = pcVar5.DAT_01;
                        pcVar5.DAT_01 = (sbyte)(sVar1 - 1);
                        pcVar5.DAT_10 += (short)pcVar5.DAT_08;

                        if ((sbyte)(sVar1 - 1) == 0)
                        {
                            DAT_C618B--;
                            pcVar5.DAT_00 = false;
                            pcVar5.DAT_0C = pcVar5.DAT_14;
                            pcVar5.DAT_0E = pcVar5.DAT_16;
                            pcVar5.DAT_10 = pcVar5.DAT_18;
                            pcVar5.DAT_12 = pcVar5.DAT_1A;
                        }
                    }
                    else
                    {
                        if (pcVar5.DAT_02)
                        {
                            bVar2 = (byte)(pcVar5.DAT_03 + 1 & 31);
                            pcVar5.DAT_03 = bVar2;
                            iVar3 = Utilities.ccos(bVar2 << 7);
                            iVar4 = Utilities.csin(pcVar5.DAT_03 << 7);
                            sVar1 = pcVar5.DAT_01;
                            pcVar5.DAT_0E = (short)((iVar3 >> 8) + 0x88);
                            pcVar5.DAT_12 = (short)((iVar4 >> 7) + 0xac);
                            pcVar5.DAT_01 = (sbyte)(sVar1 - 1);

                            if ((sbyte)(sVar1 - 1) == 0)
                            {
                                DAT_C618B--;
                                pcVar5.DAT_00 = false;
                            }
                        }
                    }
                }

                param2++;
            } while (param2 < 2);
        }
    }

    private void FUN_6CF38()
    {
        return;
    }

    private void FUN_6E898()
    {
        return;
    }

    public void FUN_6FAF0()
    {
        int iVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;

        uVar5 = 0;

        if (GameManager.instance.DAT_9ADE != 1)
        {
            iVar4 = 0;

            do
            {
                if (GameManager.instance.DAT_9EAC[iVar4 + 1] == 0)
                {
                    uVar3 = uVar5 + 1;

                    if (uVar3 < GameManager.instance.DAT_9ADE)
                    {
                        do
                        {
                            iVar2 = (int)uVar3 * 4;

                            if (GameManager.instance.DAT_9EAC[iVar2 + 1] != 0)
                            {
                                GameManager.instance.DAT_9EAC[iVar4] = GameManager.instance.DAT_9EAC[iVar2];
                                GameManager.instance.DAT_9EAC[uVar3 * 4 + 1] = 0;
                                break;
                            }

                            uVar3++;
                        } while (uVar3 < GameManager.instance.DAT_9ADE);
                    }
                }

                uVar5++;
                iVar4 += 4;
            } while (uVar5 < GameManager.instance.DAT_9ADE - 1U);
        }
    }

    private byte FUN_6FCA8(int param1)
    {
        switch (param1)
        {
            case 18:
            case 27:
                return 1;
            case 19:
            case 28:
                return 4;
            case 20:
            case 29:
                return 7;
            case 21:
            case 31:
                return 29;
            default:
                return 1;
            case 30:
                return 10;
        }
    }

    private void FUN_7007C()
    {
        return;
    }

    private ushort[] FUN_71350(InventoryText param1)
    {
        int iVar1;
        uint uVar2;
        ushort uVar3;
        int iVar4;
        uint uVar5;
        int iVar6;

        uVar5 = param1.DAT_02;
        iVar1 = param1.DAT_00 * 6;

        switch (param1.DAT_00)
        {
            case 18:
            case 19:
            case 27:
            case 28:
            case 29:
                uVar5--;
                iVar6 = (int)(uVar5 - (((uint)((ulong)uVar5 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar5 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
            case 20:
                uVar2 = uVar5 - 1;

                if (9 < uVar5)
                    uVar2 = 8;

                iVar6 = (int)(uVar2 - (((uint)((ulong)uVar2 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar2 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
            case 30:
                uVar2 = uVar5 - 1;

                if (12 < uVar5)
                    uVar2 = 11;

                iVar6 = (int)(uVar2 - (((uint)((ulong)uVar2 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar2 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
        }

        uVar3 = DialogManager.DAT_A593C[2 + iVar1];
        iVar4 = 0;
        LAB_71474:
        return DialogManager.instance.FUN_67350(uVar3, iVar4);
    }
}
