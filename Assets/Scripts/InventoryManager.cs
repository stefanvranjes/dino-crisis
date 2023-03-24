using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public bool DAT_C6101;
    public bool DAT_C6103;
    public byte DAT_C6104;
    public byte DAT_C6108;
    public byte DAT_C6109;
    public ushort DAT_C610C;
    public ushort DAT_C610E;
    public ushort DAT_C6110;
    public ushort DAT_C612E;
    public uint DAT_C61F8;
    public byte DAT_C61FC;
    public byte DAT_C61FE;
    public byte DAT_C61FF;
    public byte[] DAT_C6280;
    public byte DAT_C6290;
    public ushort[] DAT_C6298;
    public delegate void FUN_A60D0();
    public FUN_A60D0[] PTR_FUN_A60D0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DAT_C6280 = new byte[16];
            DAT_C6298 = new ushort[12];
            PTR_FUN_A60D0 = new FUN_A60D0[3]
            {
                FUN_667BC,
                FUN_66994,
                FUN_66B94
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
        DAT_C6101 = true;
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
        return;
    }

    private void FUN_66B94()
    {
        return;
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
            if ((LevelManager.instance.DAT_B5898 >> (int)(uVar3 & 31) & 1) == 0)
                DAT_C6280[pbVar2] = 0;
            else
                DAT_C6280[pbVar2]++;

            uVar1 = LevelManager.instance.DAT_B58B8;

            if ((uint)DAT_C6290 <= DAT_C6280[pbVar2])
            {
                DAT_C6280[pbVar2] = (byte)(DAT_C6290 >> 1);
                uVar1 = LevelManager.instance.DAT_B5898;
            }

            uVar4 |= uVar1 & 1U << (int)(uVar3 & 31);
            uVar3++;
            pbVar2++;
        } while (uVar3 < 16);

        return uVar4;
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
}
