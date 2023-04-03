using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryRect
{
    public bool DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
    public short DAT_04;
    public short DAT_06;
    public short DAT_08;
    public short DAT_0A;
    public short DAT_0C;
    public short DAT_0E;
    public short DAT_10;
    public short DAT_12;
    public short DAT_14;
    public short DAT_16;
    public short DAT_18;
    public short DAT_1A;
}

[System.Serializable]
public class InventoryText
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
}

[System.Serializable]
public class InventoryWindow
{
    public InventoryRect[] rect; //0x00
    public InventoryText[] DAT_38;
    public byte DAT_4C;
    public sbyte DAT_4D;
    public byte DAT_4E;
    public byte DAT_4F;
    public byte DAT_50;
    public byte[] DAT_51;
    public byte DAT_56;
    public sbyte DAT_57;
    public byte DAT_58;
    public byte DAT_59;
    public byte DAT_5A;
    public byte DAT_5B;
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
    public byte DAT_C6106;
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
    public byte DAT_C61FD;
    public byte DAT_C61FE;
    public byte DAT_C61FF;
    public byte DAT_C6200;
    public byte DAT_C6201;
    public byte DAT_C6202;
    public ushort[] DAT_C6210;
    public byte[] DAT_C6280;
    public byte DAT_C6290;
    public int DAT_C6294;
    public ushort[] DAT_C6298;
    public delegate void FUN_A60D0();
    public delegate void FUN_A60DC();
    public delegate void FUN_A614C(InventoryWindow[] w, int i);
    public delegate void FUN_A6158(InventoryWindow[] w, int i);
    public delegate void FUN_A6160(InventoryWindow[] w, int i);
    public delegate bool FUN_A6174(ushort[] a, int i);
    public delegate void FUN_A617C(InventoryWindow[] w, int i);
    public FUN_A60D0[] PTR_FUN_A60D0;
    public FUN_A60DC[] PTR_FUN_A60DC;
    public FUN_A614C[] PTR_FUN_A614C;
    public FUN_A6158[] PTR_FUN_A6158;
    public FUN_A6160[] PTR_FUN_A6160;
    public FUN_A6174[] PTR_FUN_A6174;
    public FUN_A617C[] PTR_FUN_A617C;

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
            PTR_FUN_A6158 = new FUN_A6158[2]
            {
                FUN_6B46C,
                FUN_6C1A8
            };
            PTR_FUN_A6160 = new FUN_A6160[5]
            {
                FUN_6B4A8,
                FUN_6B4A8,
                FUN_6B6CC,
                FUN_6B9E0,
                FUN_6BA84
            };
            PTR_FUN_A6174 = new FUN_A6174[2]
            {
                FUN_6BC74,
                FUN_6BC7C
            };
            PTR_FUN_A617C = new FUN_A617C[5]
            {
                FUN_6C1E4,
                FUN_6C1E4,
                FUN_6C3EC,
                FUN_6C75C,
                FUN_6C800
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

    private void FUN_6A9F4()
    {
        byte bVar1;
        int iVar2;
        ushort[] aVar2;
        int iVar3;
        int iVar4;

        iVar3 = DAT_C61FC * 6;

        if ((DAT_C61FF & 1) != 0)
        {
            DAT_C610A = 0;
            iVar3 = DAT_C61FC * 6;
            aVar2 = DialogManager.instance.FUN_67350(377, DialogManager.DAT_A593C[iVar3 + 2]);
            //FUN_6750C
        }

        if (DAT_C61FE != 0)
            DAT_C61FE--;

        bVar1 = DAT_C61FD;

        if (bVar1 == 1)
        {
            DAT_C61FD = 2;
            //FUN_2A17C
            return;
        }

        if (bVar1 < 2)
        {
            if (bVar1 == 0)
            {
                //...
                DAT_C61FD++;
                return;
            }
        }
        else
        {
            if (bVar1 == 2)
            {
                //...
                DAT_C61FD++;
                return;
            }
        }

        iVar4 = 0;
        iVar2 = 80;

        if (DAT_C6100 == 3)
        {
            iVar4 = 30;
            iVar2 = 110;
        }

        //...
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
            PTR_FUN_A614C[DAT_C6102](DAT_C6130, 0);

        FUN_6CDD8(DAT_C6130, 0);
        FUN_6BFDC(DAT_C6130, 0);
        FUN_6BDD4(DAT_C6130, 0);
        FUN_6CA4C(DAT_C6130, 0);
        FUN_6C840(DAT_C6130, 0);
    }

    private void FUN_6B14C(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        InventoryRect rVar2;
        InventoryRect rVar3;
        InventoryRect rVar4;
        uint uVar5;

        DAT_C6102++;
        FUN_6B3C8(param1, param2);
        FUN_6C110(param1, param2);
        param1[param2].DAT_50 = 2;
        param1[param2].DAT_5A = 3;
        rVar2 = param1[param2].rect[1];
        rVar3 = rVar2;
        rVar4 = param1[param2].rect[0];

        if ((DAT_C61FF & 1) == 0)
        {
            uVar1 = 0;
            uVar5 = 1;

            if (param1[param2].DAT_56 != 0 && param1[param2].DAT_4C == 0)
            {
                uVar1 = 1;
                DAT_C6103 = true;
                uVar5 = 0;
                param1[param2].DAT_50 = 3;
                param1[param2].DAT_5A = 2;
                rVar3 = param1[param2].rect[0];
                rVar4 = rVar2;
            }

            rVar4.DAT_0C = 0;
            rVar4.DAT_0E = 147;
            rVar4.DAT_10 = 0;
            rVar4.DAT_12 = -6;
            FUN_6CD1C(param1[param2], uVar1, 10, 0x930000, 0xc20000);
            rVar3.DAT_0C = 0;
            rVar3.DAT_0E = 124;
            rVar3.DAT_10 = 0;
            rVar3.DAT_12 = 349;
            FUN_6CD1C(param1[param2], uVar5, 10, 0x7c0000, 0x950000);
        }
        else
        {
            if (42U < DAT_C61FC)
            {
                DAT_C6103 = true;
                param1[param2].DAT_50 = 3;
                param1[param2].DAT_5A = 2;
                rVar3 = param1[param2].rect[0];
                rVar4 = rVar2;
            }

            rVar4.DAT_0C = 0;
            rVar4.DAT_0E = 147;
            rVar4.DAT_10 = 0;
            rVar4.DAT_12 = 694;
            rVar3.DAT_0C = 0;
            rVar3.DAT_0E = 124;
            rVar3.DAT_10 = 0;
            rVar3.DAT_12 = -151;
        }

        rVar4.DAT_03 = 4;
        rVar3.DAT_03 = 20;

        if (param1[param2].DAT_59 == 0 && param1[param2].DAT_4F == 0)
            DAT_C6102 = 2;
    }

    private void FUN_6B2F0(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A6158[DAT_C6103 ? 1 : 0](param1, param2);
    }

    private void FUN_6B32C(InventoryWindow[] param1, int param2)
    {
        return;
    }

    private void FUN_6B3C8(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        int iVar2;

        uVar1 = 0;
        iVar2 = 0;

        while (uVar1 < GameManager.instance.DAT_9ADE * 4)
        {
            if (GameManager.instance.DAT_9EAC[uVar1] != 0)
                iVar2++;

            uVar1 += 4;
        }

        param1[param2].DAT_4F = (byte)iVar2;

        if (iVar2 == 0)
            param1[param2].DAT_4D = -1;
        else
            param1[param2].DAT_4D = 0;

        param1[param2].DAT_4E = 0;

        if (iVar2 == 0)
            DAT_C6103 = true;

        FUN_6BB40(param1, param2);
    }

    private void FUN_6B46C(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A6160[DAT_C6104](param1, param2);
    }

    private void FUN_6B4A8(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        sbyte sVar3;
        bool bVar4;

        uVar2 = DAT_C612E;

        if ((uVar2 & 0x1000) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                if ((uVar2 & 0xa0) == 0)
                {
                    if ((uVar2 & 0x40) == 0)
                    {
                        if ((uVar2 & 0x2000) == 0)
                        {
                            if ((uVar2 & 0x8000) == 0 || param1[param2].DAT_4D < 1) goto LAB_6B67C;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar3 = (sbyte)(param1[param2].DAT_4D - 1);
                        }
                        else
                        {
                            if ((param1[param2].DAT_4F + 4) / 5 - 1 <= param1[param2].DAT_4D) goto LAB_6B67C;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar3 = (sbyte)(param1[param2].DAT_4D + 1);
                        }

                        param1[param2].DAT_4D = sVar3;
                        FUN_6BB40(param1, param2);
                        param1[param2].DAT_4E = 0;
                    }
                    else
                    {
                        DAT_C6104 = 0;
                        DAT_C6103 = false;
                        DAT_C6102 = 0;
                        DAT_C6101--;
                        GameManager.instance.FUN_5C94C(null, 1);
                    }
                }
                else
                {
                    DAT_C6104 = 2;
                    DAT_C6106 = 0;
                    GameManager.instance.FUN_5C94C(null, 2);
                }

                goto LAB_6B67C;
            }

            sVar3 = (sbyte)(param1[param2].DAT_4E + 1);

            if (param1[param2].DAT_4C - 1 <= param1[param2].DAT_4E) goto LAB_6B67C;
        }
        else
        {
            sVar3 = (sbyte)(param1[param2].DAT_4E - 1);

            if (param1[param2].DAT_4E == 0)
            {
                bVar4 = FUN_6BC28();

                if (bVar4)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6103 = true;
                    bVar1 = param1[param2].DAT_50;
                    param1[param2].DAT_58 = 0;
                    param1[param2].DAT_50 = param1[param2].DAT_5A;
                    param1[param2].DAT_5A = bVar1;
                    FUN_6CD1C(param1[param2], 0x10000, 0x10, 0x930000, 0xc20000);
                    FUN_6CD1C(param1[param2], 0x10001, 0x10, 0x7c0000, 0x950000);
                }

                goto LAB_6B67C;
            }
        }

        param1[param2].DAT_4E = (byte)sVar3;
        GameManager.instance.FUN_5C94C(null, 0);
        LAB_6B67C:
        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00 * 6 + 3];
    }

    private void FUN_6B6CC(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        int iVar2;
        bool bVar2;
        sbyte sVar3;
        byte bVar4;
        byte bVar5;
        sbyte sVar5;

        uVar1 = DAT_C612E;

        if ((uVar1 & 0x1000) == 0)
        {
            if ((uVar1 & 0x4000) == 0)
            {
                if ((uVar1 & 0x40) == 0)
                {
                    if ((uVar1 & 0xa0) == 0) goto LAB_6B9C0;

                    bVar4 = DAT_C6106;

                    if (bVar4 == 1)
                    {
                        GameManager.instance.FUN_5C94C(null, 2);
                        DAT_C6104 = 3;
                        bVar5 = param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00;
                        DAT_C61FE = 30;
                        DAT_C61FD = 0;
                        DAT_C61FC = bVar5;
                        FUN_6CD1C(param1[param2], 0, 10, 0x930000, 0x2b60000);
                        FUN_6CD1C(param1[param2], 1, 10, 0x7c0000, -0x6a0000);
                        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00 * 6 + 3];
                        goto LAB_6B9C0;
                    }

                    if (bVar4 < 2)
                    {
                        if (bVar4 == 0)
                        {
                            bVar2 = PTR_FUN_A6174[DialogManager.DAT_A593C[param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00 * 6] & 0xf]
                                    (DialogManager.DAT_A593C, param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00);

                            if (!bVar2)
                            {
                                GameManager.instance.FUN_5C94C(null, 1);
                                DAT_C610A = 0x17a;
                            }
                            else
                            {
                                DAT_C6104 = 0;
                                GameManager.instance.FUN_5C94C(null, 2);
                                iVar2 = FUN_6BAC4(param1, param2);
                                sVar3 = (sbyte)(GameManager.instance.DAT_9EAC[iVar2 + 1] - 1);
                                GameManager.instance.DAT_9EAC[iVar2 + 1] = (byte)sVar3;

                                if (sVar3 == 0)
                                {
                                    sVar3 = (sbyte)param1[param2].DAT_4C;
                                    param1[param2].DAT_4F--;
                                    bVar4 = (byte)(sVar3 - 1);
                                    param1[param2].DAT_4C = bVar4;

                                    if (bVar4 <= param1[param2].DAT_4E)
                                        param1[param2].DAT_4E = (byte)(sVar3 - 2);
                                }

                                if (param1[param2].DAT_4C == 0)
                                {
                                    param1[param2].DAT_4E = 0;
                                    param1[param2].DAT_4D--;
                                }

                                if (param1[param2].DAT_4F == 0)
                                {
                                    DAT_C6102 = 2;
                                    param1[param2].DAT_4D = 0;
                                }

                                FUN_6BB40(param1, param2);
                            }
                        }

                        goto LAB_6B9C0;
                    }

                    if (bVar4 != 2) goto LAB_6B9C0;
                    DAT_C6104 = 0;
                    //FUN_6FEAC
                    bVar2 = false; //tmp

                    if (bVar2)
                    {
                        GameManager.instance.FUN_5C94C(null, 2);
                        param1[param2].DAT_4D = 0;
                        FUN_6B3C8(param1, param2);
                        sVar5 = 0;

                        if (param1[param2].DAT_4C == 0)
                            sVar5 = -1;

                        param1[param2].DAT_4D = sVar5;
                        goto LAB_6B9C0;
                    }
                }
                else
                    DAT_C6104 = 0;

                GameManager.instance.FUN_5C94C(null, 1);
            }
            else
            {
                if (DAT_C6106 < 2)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6106++;
                }
            }
        }
        else
        {
            if (DAT_C6106 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                DAT_C6106--;
            }
        }

        LAB_6B9C0:;
        //FUN_66C68
    }

    private void FUN_6B9E0(InventoryWindow[] param1, int param2)
    {
        FUN_6A9F4();

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
            DAT_C61FF &= 0xfe;
            FUN_6CD1C(param1[param2], 0, 10, 0x930000, 0xc20000);
            FUN_6CD1C(param1[param2], 1, 10, 0x7c0000, 0x950000);
        }
    }

    private void FUN_6BA84(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
        }
    }

    private int FUN_6BAC4(InventoryWindow[] param1, int param2)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        int iVar4;

        iVar4 = 0;
        iVar2 = param1[param2].DAT_4D * 5;

        while (iVar2 != 0)
        {
            if (GameManager.instance.DAT_9EAC[iVar4 + 1] != 0)
                iVar2--;

            iVar4 += 4;
        }

        uVar3 = param1[param2].DAT_4E;

        while (uVar3 != 0)
        {
            iVar2 = iVar4 + 4;
            iVar1 = GameManager.instance.DAT_9EAC[iVar4 + 5];
            iVar4 = iVar2;

            if (iVar1 != 0)
                uVar3--;
        }

        return iVar4;
    }

    private void FUN_6BB40(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        int iVar2;
        int puVar3;
        InventoryText[] aVar4;

        param1[param2].DAT_38 = new InventoryText[5];

        for (int i = 0; i < 5; i++) 
            param1[param2].DAT_38[i] = new InventoryText();

        FUN_6FAF0();
        puVar3 = 0;
        iVar2 = param1[param2].DAT_4D * 5;
        uVar1 = GameManager.instance.DAT_9ADE;

        while (0 < iVar2)
        {
            if (GameManager.instance.DAT_9EAC[puVar3 + 1] != 0)
                iVar2--;

            puVar3 += 4;
            uVar1--;
        }

        iVar2 = 0;
        aVar4 = param1[param2].DAT_38;

        while (uVar1-- != 0 && iVar2 < 5)
        {
            if (GameManager.instance.DAT_9EAC[puVar3 + 1] != 0)
            {
                aVar4[iVar2].DAT_00 = GameManager.instance.DAT_9EAC[puVar3];
                iVar2++;
            }

            puVar3 += 4;
        }

        param1[param2].DAT_4C = (byte)iVar2;
    }

    private bool FUN_6BC28()
    {
        bool bVar1;
        uint uVar2;

        uVar2 = 0x2b;

        do
        {
            bVar1 = FUN_4A87C(11, uVar2);
            uVar2++;

            if (bVar1)
                return true;
        } while (uVar2 < 0x70);

        return false;
    }

    private bool FUN_6BC74(ushort[] param1, int param2)
    {
        return false;
    }

    private bool FUN_6BC7C(ushort[] param1, int param2)
    {
        byte bVar1;
        CriPlayer oVar2;
        int iVar2;
        uint uVar3;
        uint uVar4;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = (byte)param1[param2 + 1];

        if (bVar1 == 1)
        {
            uVar4 = (uint)(int)oVar2.maxHealth;

            if (oVar2.health < (short)uVar4)
            {
                iVar2 = 300;

                if (GameManager.instance.difficulty != _DIFFICULTY.Normal)
                    iVar2 = 600;

                uVar3 = (uint)(oVar2.health + iVar2);

                if (uVar4 < uVar3)
                    uVar3 = uVar4;

                oVar2.health = (short)uVar3;
                oVar2.FUN_4FE30();
                return true;
            }
        }
        else
        {
            if (1 < bVar1)
            {
                if (bVar1 == 2)
                {
                    if (oVar2.maxHealth <= oVar2.health)
                        return false;

                    oVar2.health = oVar2.maxHealth;
                }
                else
                {
                    if (bVar1 != 3)
                        return false;

                    if (oVar2.maxHealth <= oVar2.health && (oVar2.DAT_1C0 & 4) == 0)
                        return false;

                    oVar2.DAT_1C0 &= 0xfffffffb;
                    oVar2.health = oVar2.maxHealth;
                }

                oVar2.FUN_4FE30();
                return true;
            }

            if (bVar1 != 0)
                return false;

            if ((oVar2.DAT_1C0 & 4) != 0)
            {
                oVar2.DAT_1C0 &= 0xfffffffb;
                return true;
            }
        }

        return false;
    }

    private void FUN_6BDD4(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        short sVar2;
        uint uVar3;
        Vector3Int vVar3;
        int iVar4;
        int iVar5;

        DAT_C6294 = param1[param2].DAT_50;
        sVar1 = param1[param2].rect[0].DAT_0E;
        iVar4 = sVar1;
        sVar2 = param1[param2].rect[0].DAT_12;
        iVar5 = sVar2;

        if (5U < param1[param2].DAT_4F)
        {
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (0 < param1[param2].DAT_4D)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (param1[param2].DAT_4D + 1 < (param1[param2].DAT_4F + 4) / 5)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
        }

        //FUN_6ACDC
        uVar3 = 0;
        iVar5 -= 64;

        do
        {
            if (!DAT_C6103 && param1[param2].DAT_4E == uVar3)
            {
                //...
            }

            uVar3++;
            iVar5 += 26;
        } while (uVar3 < 5);

        //...
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
        iVar7 = param1[param2].rect[0].DAT_0E;
        sVar2 = param1[param2].rect[0].DAT_12;
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

    private void FUN_6C110(InventoryWindow[] param1, int param2)
    {
        bool bVar1;
        uint uVar2;
        int iVar3;

        FUN_6CC68(param1, param2);
        iVar3 = 0;
        uVar2 = 0x2b;

        do
        {
            bVar1 = FUN_4A87C(11, uVar2);

            if (bVar1)
                iVar3++;

            uVar2++;
        } while (uVar2 < 0x70);

        param1[param2].DAT_59 = (byte)iVar3;

        if (iVar3 == 0)
            param1[param2].DAT_57 = -1;
        else
            param1[param2].DAT_57 = 0;

        param1[param2].DAT_58 = 0;

        if (iVar3 == 0)
            DAT_C6103 = false;

        DAT_C610A = 0;
    }

    private void FUN_6C1A8(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A617C[DAT_C6104](param1, param2);
    }

    private void FUN_6C1E4(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        sbyte sVar3;
        int iVar4;

        uVar2 = DAT_C612E;

        if ((uVar2 & 0x1000) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                if ((uVar2 & 0xa0) == 0)
                {
                    iVar4 = 1;

                    if ((uVar2 & 0x40) == 0)
                    {
                        if ((uVar2 & 0x2000) == 0)
                        {
                            if ((uVar2 & 0x8000) == 0 || param1[param2].DAT_57 < 1) goto LAB_6C3A0;

                            sVar3 = (sbyte)(param1[param2].DAT_57 - 1);
                        }
                        else
                        {
                            if ((param1[param2].DAT_59 + 4) / 5 - 1 <= param1[param2].DAT_57) goto LAB_6C3A0;

                            sVar3 = (sbyte)(param1[param2].DAT_57 + 1);
                        }

                        param1[param2].DAT_57 = sVar3;
                        FUN_6CC68(param1, param2);
                        iVar4 = 0;
                        param1[param2].DAT_58 = 0;
                    }
                    else
                    {
                        DAT_C6104 = 0;
                        DAT_C6103 = false;
                        DAT_C6102 = 0;
                        DAT_C6101--;
                    }
                }
                else
                {
                    iVar4 = 2;
                    DAT_C6104 = 2;
                    DAT_C6106 = 0;
                }
            }
            else
            {
                if (param1[param2].DAT_56 - 1 <= param1[param2].DAT_58) goto LAB_6C3A0;

                param1[param2].DAT_58++;
                iVar4 = 0;
            }
        }
        else
        {
            if (param1[param2].DAT_58 == 0)
            {
                if (param1[param2].DAT_4F != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6103 = false;
                    bVar1 = param1[param2].DAT_5A;
                    param1[param2].DAT_4E = 0;
                    param1[param2].DAT_5A = param1[param2].DAT_50;
                    param1[param2].DAT_50 = bVar1;
                    FUN_6CD1C(param1[param2], 0x10000, 0x10, 0x930000, 0xc20000);
                    FUN_6CD1C(param1[param2], 0x10001, 0x10, 0x7c0000, 0x950000);
                }

                goto LAB_6C3A0;
            }

            param1[param2].DAT_58--;
            iVar4 = 0;
        }

        GameManager.instance.FUN_5C94C(null, iVar4);
        LAB_6C3A0:
        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_51[param1[param2].DAT_58] * 6 + 3];
    }

    private void FUN_6C3EC(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        byte bVar2;
        ushort uVar3;
        ushort uVar4;
        uint uVar5;
        uint uVar6;
        bool bVar7;
        int iVar8;
        bool bVar8;

        uVar3 = DAT_C612E;

        if ((uVar3 & 0x1000) == 0)
        {
            if ((uVar3 & 0x4000) == 0)
            {
                if ((uVar3 & 0x40) == 0)
                {
                    if ((uVar3 & 0xa0) != 0)
                    {
                        if (DAT_C6106 == 0)
                        {
                            bVar1 = param1[param2].DAT_51[param1[param2].DAT_58];
                            iVar8 = bVar1 * 6;

                            if ((byte)DialogManager.DAT_A593C[iVar8] == 0)
                            {
                                GameManager.instance.FUN_5C94C(null, 1);
                                uVar4 = 0x17b;
                            }
                            else
                            {
                                if ((byte)DialogManager.DAT_A593C[iVar8] != 1) goto LAB_6C738;

                                if (bVar1 == 88)
                                {
                                    GameManager.instance.FUN_5C94C(null, 2);
                                    DAT_C6100 = 2;
                                    DAT_C6104 = 0;
                                    DAT_C6103 = false;
                                    DAT_C6102 = 0;
                                    DAT_C61FF |= 6;
                                    bVar8 = FUN_4A87C(0, 6);

                                    if (!bVar8)
                                    {
                                        uVar5 = FUN_4A87C(0, 0xa3) ? 1U : 0;
                                        uVar6 = FUN_4A87C(0, 0xcd) ? 1U : 0;

                                        if ((uVar5 | uVar6) != 0)
                                        {
                                            bVar8 = FUN_4A87C(0, 0xa3);

                                            if (bVar8)
                                            {
                                                DAT_C6200 = 6;
                                                DAT_C6201 = 16;
                                                DAT_C6202 = 91;
                                                return;
                                            }

                                            DAT_C6200 = 6;
                                            DAT_C6201 = 13;
                                            DAT_C6202 = bVar1;
                                            return;
                                        }

                                        bVar8 = FUN_4A87C(0, 4);
                                    }
                                    else
                                    {
                                        bVar8 = FUN_4A87C(0, 0xdc);

                                        if (bVar8)
                                        {
                                            DAT_C6200 = 6;
                                            DAT_C6201 = 13;
                                            DAT_C6202 = bVar1;
                                            return;
                                        }

                                        bVar8 = FUN_4A87C(0, 4);
                                    }

                                    if (!bVar8)
                                    {
                                        DAT_C6200 = 5;
                                        DAT_C6201 = 3;
                                        DAT_C6202 = 60;
                                        return;
                                    }

                                    DAT_C6200 = 6;
                                    DAT_C6201 = 7;
                                    DAT_C6202 = 82;
                                    return;
                                }

                                bVar7 = FUN_4A87C(6, (byte)DialogManager.DAT_A593C[iVar8 + 1]);

                                if (bVar7)
                                {
                                    GameManager.instance.FUN_5C94C(null, 2);
                                    FUN_4A7E8(2, 0x10, true);
                                    GameManager.instance.DAT_2A = 2;
                                    GameManager.instance.DAT_20 = (byte)DialogManager.DAT_A593C[iVar8 + 1];
                                    FUN_4A7E8(11, (byte)DialogManager.DAT_A593C[iVar8 + 1], false);

                                    if ((byte)DialogManager.DAT_A593C[iVar8 + 1] - 65U < 2)
                                        DAT_C61F8 |= 0x5003;

                                    goto LAB_6C738;
                                }

                                GameManager.instance.FUN_5C94C(null, 1);
                                uVar4 = 0x17b;
                            }
                        }
                        else
                        {
                            GameManager.instance.FUN_5C94C(null, 2);
                            FUN_6CD1C(param1[param2], 0, 10, 0x7c0000, 0x2890000);
                            FUN_6CD1C(param1[param2], 1, 10, 0x930000, -0x6a0000);
                            DAT_C6104 = 3;
                            bVar2 = param1[param2].DAT_51[param1[param2].DAT_58];
                            DAT_C61FD = 0;
                            DAT_C61FE = 30;
                            DAT_C61FF = bVar2;
                            uVar4 = DialogManager.DAT_A593C[param1[param2].DAT_51[param1[param2].DAT_58] * 6 + 3];
                        }

                        DAT_C610A = uVar4;
                    }
                }
                else
                {
                    DAT_C6104 = 0;
                    GameManager.instance.FUN_5C94C(null, 1);
                }

                goto LAB_6C738;
            }

            if (DAT_C6106 == 0) goto LAB_6C738;

            DAT_C6106 = 0;
        }

        GameManager.instance.FUN_5C94C(null, 0);
        LAB_6C738:;
        //FUN_66C68
    }

    private void FUN_6C75C(InventoryWindow[] param1, int param2)
    {
        FUN_6A9F4();

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
            DAT_C61FF &= 0xfe;
            FUN_6CD1C(param1[param2], 0, 10, 0x7c0000, 0x950000);
            FUN_6CD1C(param1[param2], 1, 10, 0x930000, 0xc20000);
        }
    }

    private void FUN_6C800(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
        }
    }

    private void FUN_6C840(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        short sVar2;
        uint uVar3;
        Vector3Int vVar3;
        int iVar4;
        int iVar5;

        DAT_C6294 = param1[param2].DAT_5A;
        sVar1 = param1[param2].rect[1].DAT_0E;
        iVar4 = sVar1;
        sVar2 = param1[param2].rect[1].DAT_12;
        iVar5 = sVar2;

        if (5 < param1[param2].DAT_59)
        {
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (0 < param1[param2].DAT_57)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (param1[param2].DAT_57 + 1 < (param1[param2].DAT_59 + 4) / 5)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
        }

        //FUN_6ACDC
        uVar3 = 0;
        iVar5 -= 64;

        do
        {
            if (DAT_C6103 && param1[param2].DAT_58 == uVar3)
            {
                //...
            }

            uVar3++;
            iVar5 += 26;
        } while (uVar3 < 5);

        //...
    }

    private void FUN_6CA4C(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        int iVar8;
        int iVar9;

        DAT_C6294 = param1[param2].DAT_5A;
        iVar8 = param1[param2].rect[1].DAT_0E;
        bVar1 = param1[param2].DAT_56;
        iVar7 = param1[param2].rect[1].DAT_12;
        uVar6 = 0;

        if (bVar1 != 0)
        {
            iVar9 = -53;
            iVar5 = -59;

            do
            {
                iVar2 = param1[param2].DAT_51[uVar6] * 6;

                if ((byte)DialogManager.DAT_A593C[iVar2] == 0)
                    iVar3 = 9;
                else
                {
                    if ((byte)DialogManager.DAT_A593C[iVar2 + 1] == 0x2d)
                        iVar3 = 9;
                    else
                        iVar3 = 10;
                }

                //...

                switch (param1[param2].DAT_51[uVar6])
                {
                    case 32:
                        uVar4 = GameManager.instance.DAT_9EE8;
                        break;
                    case 33:
                        uVar4 = GameManager.instance.DAT_9EE9;
                        break;
                    case 34:
                        uVar4 = GameManager.instance.DAT_9EEA;
                        break;
                    case 35:
                        uVar4 = GameManager.instance.DAT_9EEB;
                        break;
                    default:
                        goto LAB_6CB64;
                    case 43:
                        uVar4 = GameManager.instance.DAT_A0E0;
                        break;
                }

                //...
                LAB_6CB64:
                iVar9 += 26;
                uVar6++;
                iVar5 += 26;
            } while (uVar6 < bVar1);
        }

        //FUN_67AD8
    }

    private void FUN_6CC68(InventoryWindow[] param1, int param2)
    {
        bool bVar1;
        int iVar2;
        uint uVar3;

        param1[param2].DAT_51 = new byte[5];
        iVar2 = param1[param2].DAT_57 * 5;
        uVar3 = 0x2b;

        while (0 < iVar2)
        {
            bVar1 = FUN_4A87C(11, uVar3);

            if (bVar1)
                iVar2--;

            uVar3++;
        }

        iVar2 = 0;

        do
        {
            if (0x6f < uVar3) break;

            bVar1 = FUN_4A87C(11, uVar3);

            if (bVar1)
            {
                param1[param2].DAT_51[iVar2] = (byte)uVar3;
                iVar2++;
            }

            uVar3++;
        } while (iVar2 < 5);

        param1[param2].DAT_56 = (byte)iVar2;
    }

    private void FUN_6CD1C(InventoryWindow param1, uint param2, int param3, int param4, int param5)
    {
        InventoryRect puVar1;

        param1.DAT_5B++;
        puVar1 = param1.rect[param2 & 0xffff];

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param4 - (puVar1.DAT_0E << 0x10 | (ushort)puVar1.DAT_0C) == -0x80000000)
            return; //trap(0x1800)

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param5 - (puVar1.DAT_12 << 0x10 | (ushort)puVar1.DAT_10) == -0x80000000)
            return; //trap(0x1800)

        puVar1.DAT_01 = (sbyte)param3;
        puVar1.DAT_02 = (byte)(param2 >> 0x10);
        puVar1.DAT_14 = (short)param4;
        puVar1.DAT_16 = (short)(param4 >> 0x10);
        puVar1.DAT_00 = true;
        puVar1.DAT_04 = (short)(((short)param4 - puVar1.DAT_0C) / param3);
        puVar1.DAT_06 = (short)(((short)(param4 >> 0x10) - puVar1.DAT_0E) / param3);
        puVar1.DAT_08 = (short)(((short)param5 - puVar1.DAT_10) / param3);
        puVar1.DAT_0A = (short)(((short)(param5 >> 0x10) - puVar1.DAT_12) / param3);
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

                if (pcVar5.rect[0].DAT_00)
                {
                    if (pcVar5.rect[0].DAT_02 == 0)
                    {
                        pcVar5.rect[0].DAT_0C += pcVar5.rect[0].DAT_04;
                        pcVar5.rect[0].DAT_0E += pcVar5.rect[0].DAT_06;
                        sVar1 = pcVar5.rect[0].DAT_01;
                        pcVar5.rect[0].DAT_01 = (sbyte)(sVar1 - 1);
                        pcVar5.rect[0].DAT_10 += pcVar5.rect[0].DAT_08;
                        pcVar5.rect[0].DAT_12 += pcVar5.rect[0].DAT_0A;

                        if ((sbyte)(sVar1 - 1) == 0)
                        {
                            DAT_C618B--;
                            pcVar5.rect[0].DAT_00 = false;
                            pcVar5.rect[0].DAT_0C = pcVar5.rect[0].DAT_14;
                            pcVar5.rect[0].DAT_0E = pcVar5.rect[0].DAT_16;
                            pcVar5.rect[0].DAT_10 = pcVar5.rect[0].DAT_18;
                            pcVar5.rect[0].DAT_12 = pcVar5.rect[0].DAT_1A;
                        }
                    }
                    else
                    {
                        if (pcVar5.rect[0].DAT_02 == 1)
                        {
                            bVar2 = (byte)(pcVar5.rect[0].DAT_03 + 1 & 31);
                            pcVar5.rect[0].DAT_03 = bVar2;
                            iVar3 = Utilities.ccos(bVar2 << 7);
                            iVar4 = Utilities.csin(pcVar5.rect[0].DAT_03 << 7);
                            sVar1 = pcVar5.rect[0].DAT_01;
                            pcVar5.rect[0].DAT_0E = (short)((iVar3 >> 8) + 0x88);
                            pcVar5.rect[0].DAT_12 = (short)((iVar4 >> 7) + 0xac);
                            pcVar5.rect[0].DAT_01 = (sbyte)(sVar1 - 1);

                            if ((sbyte)(sVar1 - 1) == 0)
                            {
                                DAT_C618B--;
                                pcVar5.rect[0].DAT_00 = false;
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
