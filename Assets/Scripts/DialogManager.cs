using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public ushort[] DAT_B12C0;
    public Trigger DAT_B1388;
    public byte DAT_B138C;
    public byte DAT_B138D;
    public byte DAT_B138E;
    public byte DAT_B138F;
    public byte DAT_B1390;
    public byte DAT_B1391;
    public byte DAT_B1392;
    public byte DAT_B1393;
    public int DAT_B1440;
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
    public sbyte DAT_B147F;
    public sbyte DAT_B1480;
    public sbyte DAT_B1481;
    public byte DAT_B1482;
    public sbyte DAT_B1483;
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
    public delegate bool FUN_99028(Trigger t);
    public delegate void FUN_99058(Trigger t);
    public FUN_99028[] PTR_FUN_99028;
    public FUN_99058[] PTR_FUN_99058;

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
            PTR_FUN_99058 = new FUN_99058[8]
            {
                FUN_1BD1C,
                FUN_1BD58,
                FUN_1C040,
                FUN_1C3B0,
                FUN_1C580,
                FUN_1C888,
                FUN_1CA74,
                FUN_1CBA4
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

    public void FUN_1BAB4(byte param1, Trigger param2)
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

    public void FUN_1DE48()
    {
        //FUN_1DED0
        PTR_B146C = null;
        PTR_B1470 = null;
        DAT_B1478 = 0;
        DAT_B147A = 0;
        DAT_B147E = 0;
        DAT_B147F = 0;
        DAT_B1480 = 0;
        DAT_B1481 = 0;
        DAT_B1482 = 0;
        DAT_B1483 = 0;
        DAT_B1484 = 0;
        DAT_B1485 = 0;
        DAT_B1487 = 0;
        DAT_B1488 = 0;
        DAT_B1489 = 0;
        DAT_B148A = 40;
        DAT_B148B = 0;
        DAT_B148C = 0;
    }

    public void FUN_1E2D8(ushort[] param1, int param2, byte param3, ushort param4)
    {
        byte bVar1;

        DAT_B147A = (ushort)InventoryManager.DAT_B7A60[0];
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
            DAT_B1474++;
        }

        DAT_B1484 = 1;
        DAT_B1470 = DAT_B1474;
        PTR_B1470 = PTR_B1474;
        DAT_B146C = DAT_B1474;
        PTR_B146C = PTR_B1474;
        InventoryManager.DAT_B7A60[0] |= DAT_B1478;
        InventoryManager.FUN_4A7E8(2, 0, true);
    }

    public void FUN_1E44C()
    {
        if ((DAT_B1482 & 2) == 0)
        {
            if (PTR_B1470 != null)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0xe0) != 0 &&
                    (DAT_B1482 & 1) == 0 && (DAT_B147C & 4) == 0)
                {
                    DAT_B1480 = 0;
                    DAT_B147F = 0;
                    DAT_B1481 = 0;
                    DAT_B147C |= 3;
                }

                DAT_B1481--;

                if (DAT_B1481 == -1)
                {
                    while (true)
                    {
                        if ((PTR_B146C[DAT_B146C] & 0x8000) == 0)
                            FUN_1E774();
                        else
                            FUN_1E55C();

                        DAT_B146C++;

                        if (DAT_B147F != 0) break;

                        DAT_B147C &= 0xfffe;
                    }
                }
            }
        }
        else
            ; //FUN_1F6B0
    }

    private void FUN_1E55C()
    {
        byte bVar1;
        ushort uVar2;
        byte bVar4;
        uint uVar5;

        uVar2 = PTR_B146C[DAT_B146C];

        if ((uVar2 & 0x1000) != 0)
        {
            //FUN_1DED0
            DAT_B1484 = 0;
            DAT_B1485 = 0;
        }

        if ((uVar2 & 0xff) == 0)
            DAT_B147F = 0;
        else
            DAT_B147F = DAT_B1480;

        //...
        bVar1 = DAT_B1484;
        bVar4 = (byte)(bVar1 + 1);
        DAT_B1484 = bVar4;

        if (bVar4 == 41)
            DAT_B1484 = bVar1;

        if ((uVar2 & 0x2800) != 0)
        {
            if (GameManager.instance.DAT_28 == 6 || 
                (DAT_B1482 == 0 && (DAT_B147C & 0x14) == 0 && (DAT_B147C & 1) == 0))
            {
                DAT_B147F = 1;
                DAT_B1481 = 0;
                DAT_B146C--;
            }
            else
            {
                //FUN_1DED0
                uVar5 = InventoryManager.DAT_B7A60[0] & (uint)~DAT_B1478;
                InventoryManager.DAT_B7A60[0] = uVar5;
                InventoryManager.DAT_B7A60[0] = uVar5 | DAT_B147A;
                DAT_B147F = 1;
                DAT_B1485 = 0;
                DAT_B1484 = 0;
                DAT_B148C = 0;
                DAT_B148B = 0;
                DAT_B1488 = 0;
                DAT_B147E = 0;
                DAT_B1483 = 0;
                DAT_B1482 = 0;
                DAT_B147C = 0;
                DAT_B1478 = 0;
                DAT_B1480 = 0;
                DAT_B147A = 0;
                PTR_B146C = null;
                DAT_B146C = 0;
                PTR_B1470 = null;
                DAT_B1470 = 0;
                InventoryManager.FUN_4A7E8(2, 0, false);
                InventoryManager.FUN_4A7E8(2, 0x11, true);
                //...
            }
        }

        if ((uVar2 & 0x4000) != 0)
        {
            DAT_B1484 = 1;
            DAT_B1485++;
        }

        DAT_B147C &= 0xffef;
        DAT_B1481 = DAT_B147F;
    }

    private void FUN_1E774()
    {
        ushort uVar1;
        sbyte sVar2;

        uVar1 = PTR_B146C[DAT_B146C];
        DAT_B1481 = 0;

        if ((uVar1 & 0x4000) == 0)
        {
            sVar2 = (sbyte)uVar1;

            if ((uVar1 & 0x2000) == 0)
            {
                if ((uVar1 & 0x1000) == 0)
                {
                    if ((uVar1 & 0x800) != 0)
                    {
                        if ((DAT_B147C & 4) == 0)
                        {
                            DAT_B147F = 1;
                            DAT_B146C--;
                            DAT_B147C |= 4;
                        }
                        else
                            ; //FUN_1E928
                    }
                }
                else
                {
                    DAT_B1480 = sVar2;
                    DAT_B147F = sVar2;
                    DAT_B1481 = sVar2;
                }
            }
            else
                DAT_B1483 = sVar2;

            if ((uVar1 & 0x100) != 0 && DAT_B1482 == 0)
            {
                uVar1 = DAT_B147C;

                if ((uVar1 & 2) == 0 || (uVar1 & 1) == 0)
                {
                    if (15U < DAT_B147E)
                    {
                        if ((DAT_B147C & 8) == 0)
                        {
                            //...
                            DAT_B147E = 7;
                        }
                        else
                        {
                            //...
                            DAT_B147E = 0;
                        }

                        DAT_B147C ^= 8;
                    }

                    DAT_B147F = 1;
                    DAT_B1481 = 0;
                    DAT_B146C--;
                    DAT_B147E++;
                    DAT_B1484--;
                }
                else
                    DAT_B147C = (ushort)(uVar1 & 0xfff5 | 0x10);
            }
        }
        else
            FUN_1E900();
    }

    private void FUN_1E900()
    {
        DAT_B148C = (byte)PTR_B146C[DAT_B146C];
    }

    private bool FUN_1AB50(Trigger param1)
    {
        bool bVar1;
        int iVar2;
        byte bVar3;
        int iVar4;
        Trigger2 tVar5;

        tVar5 = (Trigger2)param1;
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        bVar3 = tVar5.DAT_24;

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

                if (bVar3 < (uint)tVar5.DAT_24)
                {
                    FUN_1BAB4(0, param1);
                    //sound
                    FUN_1BCA4(DAT_98628, 1190);
                    DAT_B12C0[41] = (ushort)(DAT_98628
                        [DAT_98594[1]] - (tVar5.DAT_24 - 6 << 1));
                    FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                    DAT_B1390++;
                    return false;
                }

                InventoryManager.FUN_4A7E8(9, tVar5.DAT_23, true);
                //sound
                FUN_1BAB4(7, param1);
                return false;
            }

            if (bVar3 == 1)
            {
                bVar1 = InventoryManager.FUN_4A87C(9, tVar5.DAT_23);

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
                    bVar1 = InventoryManager.FUN_4A87C(9, tVar5.DAT_23);

                    if (!bVar1)
                    {
                        InventoryManager.FUN_4A7E8(9, tVar5.DAT_23, true);
                        iVar2 = FUN_1CC54(12);
                        FUN_1E2D8(DAT_98628, iVar2, 0, 0xffff);
                        //sound
                        return false;
                    }

                    goto LAB_1AFA0;
                }

                if (bVar3 == 3)
                {
                    bVar1 = InventoryManager.FUN_4A87C(9, tVar5.DAT_23);

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

        bVar1 = InventoryManager.FUN_4A87C(9, tVar5.DAT_23);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(11, tVar5.DAT_24);

            if (!bVar1)
            {
                FUN_1BAB4(0, param1);
                //sound
                FUN_1BCA4(DAT_98628, 44);
                iVar2 = FUN_67988(tVar5.DAT_24);
                FUN_1BCA4(DAT_9F0EC, iVar2);
                iVar4 = 60;
            }
            else
            {
                InventoryManager.FUN_4A7E8(9, tVar5.DAT_23, true);
                InventoryManager.FUN_4A7E8(11, tVar5.DAT_24, false);
                FUN_1BAB4(0, param1);
                //sound
                FUN_1BCA4(DAT_98628, 23);
                iVar2 = FUN_67988(tVar5.DAT_24);
                FUN_1BCA4(DAT_9F0EC, iVar2);
                iVar4 = 4;
            }

            FUN_1BCA4(DAT_98628, iVar4);
            FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
            return false;
        }

        LAB_1AFA0:
        SceneManager.instance.FUN_1AFC4(tVar5);
        return false;
    }

    private bool FUN_1B2A8(Trigger param1)
    {
        InventoryManager.FUN_4A7E8(1, 11, true);
        SceneManager.instance.DAT_27C[10].DAT_3C = 1;
        //FUN_1E2D8
        return false;
    }

    private bool FUN_1B304(Trigger param1)
    {
        Trigger4 tVar1;

        tVar1 = (Trigger4)param1;
        InventoryManager.FUN_4A7E8(tVar1.DAT_18, tVar1.DAT_19, tVar1.DAT_1A);
        return true;
    }

    private bool FUN_1B334(Trigger param1)
    {
        Trigger5 tVar1;

        tVar1 = (Trigger5)param1;
        SceneManager.instance.FUN_55580((sbyte)tVar1.DAT_18, tVar1.DAT_1A);
        return false;
    }

    private bool FUN_1B360(Trigger param1)
    {
        byte bVar1;
        ushort uVar2;
        bool bVar3;
        uint uVar4;
        Trigger6 tVar5;

        tVar5 = (Trigger6)param1;
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        DAT_B138E = (byte)tVar5.DAT_18;
        bVar3 = true;

        if ((tVar5.DAT_18 << 8) == 0xff)
        {
            uVar4 = tVar5.DAT_1C - 0xbdU & 0xffffU;

            if ((GameManager.instance.DAT_A090[uVar4] & 0x40) == 0)
            {
                bVar1 = SceneManager.instance.FUN_47864();
                GameManager.instance.DAT_A090[uVar4] |= (byte)(bVar1 | 0x40);
            }

            DAT_B138E = (byte)(GameManager.instance.DAT_A090[uVar4] & 0x3f);
            uVar2 = FUN_47808(DAT_B138E);
            tVar5.DAT_1A = uVar2;
        }

        if (tVar5.DAT_24 == 0 || (SceneManager.instance.DAT_7CDC[tVar5.DAT_1E].flags & 2) != 0)
        {
            if (tVar5.DAT_1F == 0)
            {
                FUN_1B4CC(tVar5);
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

    private bool FUN_1B7C8(Trigger param1)
    {
        Trigger7 tVar1;

        tVar1 = (Trigger7)param1;
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        param1.DAT_13 = false;
        ((CriPlayer)SceneManager.instance.DAT_27C[10]).FUN_5397C(tVar1.DAT_18);
        //sound
        return false;
    }

    private bool FUN_1B820(Trigger param1)
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

    private bool FUN_1B8B8(Trigger param1)
    {
        Trigger9 tVar1;

        tVar1 = (Trigger9)param1;
        InventoryManager.FUN_4A7E8(1, 0xb, true);

        if (tVar1.DAT_28 == 0xff)
            InventoryManager.FUN_4A7E8(tVar1.DAT_28, tVar1.DAT_29, true);

        //FUN_1F0C4
        return false;
    }

    private bool FUN_1B93C(Trigger param1)
    {
        Trigger10 tVar1;

        tVar1 = (Trigger10)param1;
        InventoryManager.FUN_4A7E8(1, 0xb, true);

        if (!tVar1.DAT_19 || InventoryManager.FUN_4A87C(9, tVar1.DAT_18 + 0x2fU))
        {
            GameManager.instance.DAT_2E = tVar1.DAT_18;
            GameManager.instance.DAT_39 = 5;
            InventoryManager.FUN_4A7E8(1, 0xb, false);
            InventoryManager.FUN_4A7E8(2, 0xf, true);
        }
        else
            FUN_1BAB4(1, param1);

        return false;
    }

    private bool FUN_1B9DC(Trigger param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        return false;
    }

    private bool FUN_1BA04(Trigger param1)
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

    private bool FUN_1BA74(Trigger param1)
    {
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        FUN_1BAB4(4, param1);
        return false;
    }

    private void FUN_1BD1C(Trigger param1)
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(2, 0);

        if (!bVar1)
            InventoryManager.FUN_1BBCC();
    }

    private void FUN_1BD58(Trigger param1)
    {
        int iVar2;
        bool bVar2;
        int puVar3;
        Trigger10 tVar4;

        tVar4 = (Trigger10)param1;

        switch (DAT_B1390)
        {
            case 0:
                if (tVar4.DAT_18 < 8U)
                    iVar2 = 153;
                else
                {
                    if (tVar4.DAT_18 < 13U)
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

                if (tVar4.DAT_19)
                {
                    puVar3 = 322;
                    goto LAB_1BFD8;
                }

                FUN_1BCA4(DAT_98628, 369);
                DAT_B12C0[11] = (ushort)(DAT_98628[DAT_98594[0]] + (tVar4.DAT_19 ? 1 : 0) * 2);
                goto LAB_1BFE0;
            case 2:
                bVar2 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar2)
                    return;

                if ((uint)(tVar4.DAT_19 ? 1 : 0) <= GameManager.instance.DAT_A0E0)
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
                    InventoryManager.FUN_4A7E8(9, tVar4.DAT_18, true);
                    GameManager.instance.DAT_A0E0 -= (ushort)(tVar4.DAT_19 ? 1 : 0);

                    if (GameManager.instance.DAT_A0E0 == 0)
                        InventoryManager.FUN_4A7E8(11, 0x2b, false);

                    GameManager.instance.DAT_2E = tVar4.DAT_18;
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

    private void FUN_1C040(Trigger param1)
    {
        CriPlayer oVar1;
        bool bVar1;
        Trigger12 tVar2;

        tVar2 = (Trigger12)param1;
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        switch (DAT_B1390)
        {
            case 0:
                InventoryManager.FUN_4A7E8(1, 0, false);
                InventoryManager.FUN_4A7E8(1, 1, true);
                oVar1.DAT_3C = 4;
                oVar1.DAT_3D = 0;
                oVar1.DAT_3E = 0;
                oVar1.DAT_3F = 0;
                oVar1.DAT_40 = new Vector3Int(0, 0, 0);
                oVar1.FUN_6103C((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 0, 0, 10);
                DAT_B1391 = 30;
                goto LAB_1C360;
            case 1:
                DAT_B1391--;

                if (DAT_B1391 == 0)
                {
                    if (GameManager.instance.DAT_9ADF == 0)
                    {
                        FUN_1BCA4(DAT_98628, 477);
                        FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                        GameManager.instance.DAT_9ADF = tVar2.DAT_18;
                        InventoryManager.FUN_4A7E8(11, 0x41, false);
                        InventoryManager.FUN_4A7E8(11, 0x42, true);
                        DAT_B1390 = 2;
                    }
                    else
                    {
                        FUN_1BCA4(DAT_98628, 516);
                        FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                        DAT_B1390 = 3;
                    }
                }

                break;
            case 2:
                bVar1 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar1)
                    return;

                goto LAB_1C28C;
            case 3:
                bVar1 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar1)
                    return;

                InventoryManager.FUN_4A7E8(11, 0x41, false);
                InventoryManager.FUN_4A7E8(11, 0x42, true);
                bVar1 = InventoryManager.FUN_4A87C(2, 4);

                if (bVar1)
                {
                    //sound
                    DAT_B1390++;
                    GameManager.instance.DAT_9ADF = tVar2.DAT_18;
                }

                bVar1 = InventoryManager.FUN_4A87C(2, 5);

                if (!bVar1)
                    return;

                LAB_1C28C:
                DAT_B1390 = 6;
                break;
            case 4:
                DAT_B138D = 0;
                FUN_1BCA4(DAT_98628, 477);
                FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                goto LAB_1C2E8;
            case 5:
                bVar1 = InventoryManager.FUN_4A87C(2, 0);

                if (bVar1)
                    return;

                LAB_1C2E8:
                DAT_B1390++;
                break;
            case 6:
                InventoryManager.FUN_4A7E8(1, 0, false);
                InventoryManager.FUN_4A7E8(1, 1, true);
                oVar1.DAT_3C = 4;
                oVar1.DAT_3D = 0;
                oVar1.DAT_3E = 0;
                oVar1.DAT_3F = 0;
                oVar1.DAT_40 = new Vector3Int(0, 0, 0);
                oVar1.FUN_6103C((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 2, 0x18, 10);
                DAT_B1391 = 25;
                LAB_1C360:
                DAT_B1390++;
                break;
            case 7:
                DAT_B1391--;

                if (DAT_B1391 == 0)
                {
                    oVar1.DAT_3C = 1;
                    oVar1.DAT_3D = 0;
                    oVar1.DAT_3E = 0;
                    oVar1.DAT_3F = 0;
                    InventoryManager.FUN_1BBCC();
                }

                break;
        }
    }

    private void FUN_1C3B0(Trigger param1)
    {
        int iVar1;
        bool bVar2;
        CriPlayer oVar2;
        Trigger6 tVar3;

        tVar3 = (Trigger6)param1;
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_B1390 == 1)
        {
            bVar2 = InventoryManager.FUN_4A87C(2, 0);

            if (!bVar2)
            {
                if ((tVar3.DAT_1F & 0x80) == 0)
                    InventoryManager.FUN_1BBCC();
                else
                {
                    InventoryManager.FUN_4A7E8(2, 0xe, true);
                    DAT_B1390 = 2;
                }
            }
        }
        else
        {
            if (DAT_B1390 < 2)
            {
                if (DAT_B1390 != 0)
                    return;

                FUN_1BCA4(DAT_98628, 602);
                iVar1 = FUN_67988(DAT_B138E);
                FUN_1BCA4(DAT_9F0EC, iVar1);
                FUN_1BCA4(DAT_98628, 4);
                FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
            }
            else
            {
                if (DAT_B1390 != 2)
                {
                    if (DAT_B1390 != 3)
                        return;

                    DAT_B1391--;

                    if (DAT_B1391 != 0)
                        return;

                    InventoryManager.FUN_1BBCC();
                    oVar2.DAT_3C = 1;
                    oVar2.DAT_3D = 0;
                    oVar2.DAT_3E = 0;
                    oVar2.DAT_3F = 0;
                    return;
                }

                InventoryManager.FUN_4A7E8(1, 0, false);
                InventoryManager.FUN_4A7E8(1, 1, true);
                oVar2.FUN_6103C((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 2, 25, 10);
                DAT_B1391 = 30;
            }

            DAT_B1390++;
        }
    }

    private void FUN_1C580(Trigger param1)
    {
        int iVar1;
        uint uVar2;
        int iVar3;
        bool bVar3;
        byte bVar4;
        Trigger13 tVar5;

        bVar4 = 0;
        tVar5 = (Trigger13)param1;

        if (DAT_B1390 == 1)
        {
            bVar3 = InventoryManager.FUN_4A87C(2, 0);

            if (bVar3)
                return;

            bVar3 = InventoryManager.FUN_4A87C(2, 4);

            if (!bVar3)
            {
                InventoryManager.FUN_1BBCC();
                return;
            }

            //sound
            iVar3 = 897;
            DAT_B138D = 0;
        }
        else
        {
            if (1 < DAT_B1390)
            {
                if (DAT_B1390 == 2)
                {
                    bVar3 = InventoryManager.FUN_4A87C(2, 0);

                    if (bVar3)
                        return;
                }
                else
                {
                    if (DAT_B1390 != 3)
                        return;

                    bVar3 = InventoryManager.FUN_4A87C(2, 0);

                    if (bVar3)
                        return;

                    bVar3 = InventoryManager.FUN_4A87C(2, 4);

                    if (bVar3)
                    {
                        //sound
                        bVar3 = InventoryManager.FUN_4A87C(tVar5.DAT_18, tVar5.DAT_19);

                        if (!bVar3)
                        {
                            iVar1 = tVar5.DAT_18;
                            uVar2 = tVar5.DAT_19;
                        }
                        else
                        {
                            iVar1 = tVar5.DAT_18;
                            uVar2 = tVar5.DAT_19;
                        }

                        InventoryManager.FUN_4A7E8(iVar1, uVar2, !bVar3);
                    }
                }

                InventoryManager.FUN_1BBCC();
                return;
            }

            if (DAT_B1390 != 0)
                return;

            bVar3 = InventoryManager.FUN_4A87C(0, tVar5.DAT_1B);

            if (bVar3)
            {
                if (tVar5.DAT_1A == 0)
                {
                    FUN_1BCA4(DAT_98628, 867);
                    FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                }
                else
                {
                    bVar3 = InventoryManager.FUN_4A87C(11, 0x38);

                    if (bVar3)
                        bVar4 = 6;

                    bVar3 = InventoryManager.FUN_4A87C(11, 0x39);

                    if (bVar3)
                        bVar4 = 7;

                    bVar3 = InventoryManager.FUN_4A87C(11, 0x3a);

                    if (bVar3)
                        bVar4 = 8;

                    if (bVar4 < tVar5.DAT_1A)
                    {
                        //sound
                        FUN_1BCA4(DAT_98628, 1110);
                        DAT_B12C0[41] = (ushort)(DAT_98628[DAT_98594[1]] - (tVar5.DAT_1A - 6 * 2));
                        FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                        DAT_B1390 = 2;
                        return;
                    }

                    FUN_1BCA4(DAT_98628, 867);
                    FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
                    //sound
                }

                DAT_B1390 = 3;
                return;
            }

            iVar3 = 867;
        }

        FUN_1BCA4(DAT_98628, iVar3);
        FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
        DAT_B1390++;
    }

    private void FUN_1C888(Trigger param1)
    {
        int iVar1;
        bool bVar2;
        CriPlayer oVar2;
        Trigger6 tVar3;

        tVar3 = (Trigger6)param1;
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_B1390 == 1)
        {
            bVar2 = InventoryManager.FUN_4A87C(2, 0);

            if (!bVar2)
            {
                bVar2 = InventoryManager.FUN_4A87C(2, 4);

                if (!bVar2)
                {
                    if ((tVar3.DAT_1F & 0x80) == 0)
                        InventoryManager.FUN_1BBCC();
                    else
                        DAT_B1390 = 2;
                }
                else
                {
                    InventoryManager.FUN_1BBCC();
                    FUN_1B550(tVar3);
                }
            }
        }
        else
        {
            if (DAT_B1390 < 2)
            {
                if (DAT_B1390 != 0)
                    return;

                FUN_1BCA4(DAT_98628, 966);
                iVar1 = FUN_67988(DAT_B138E);
                FUN_1BCA4(DAT_9F0EC, iVar1);
                FUN_1BCA4(DAT_98628, 6);
                FUN_1E2D8(DAT_B12C0, 0, 0, 0xffff);
            }
            else
            {
                if (DAT_B1390 != 2)
                {
                    if (DAT_B1390 != 3)
                        return;

                    DAT_B1391--;

                    if (DAT_B1391 != 0)
                        return;

                    InventoryManager.FUN_1BBCC();
                    oVar2.DAT_3C = 1;
                    oVar2.DAT_3D = 0;
                    oVar2.DAT_3E = 0;
                    oVar2.DAT_3F = 0;
                    return;
                }

                InventoryManager.FUN_4A7E8(1, 0, false);
                InventoryManager.FUN_4A7E8(1, 1, true);
                oVar2.FUN_6103C((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 2, 25, 10);
                DAT_B1391 = 30;
            }

            DAT_B1390++;
        }
    }

    private void FUN_1CA74(Trigger param1)
    {
        CriPlayer oVar1;
        Trigger6 tVar2;

        tVar2 = (Trigger6)param1;
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_B1390 == 1)
        {
            oVar1.DAT_3C = 4;
            oVar1.DAT_3D = 0;
            oVar1.DAT_3E = 0;
            oVar1.DAT_3F = 0;
            oVar1.DAT_40 = new Vector3Int(0, 0, 0);
            oVar1.FUN_6103C((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 0, 0, 10);
            DAT_B1391 = 30;
            DAT_B1390++;
        }
        else
        {
            if (DAT_B1390 < 2)
            {
                if (DAT_B1390 == 0)
                {
                    InventoryManager.FUN_4A7E8(1, 0, false);
                    InventoryManager.FUN_4A7E8(1, 1, true);

                    if ((tVar2.DAT_1F & 0x80) != 0)
                        DAT_B1390 = 1;
                }
            }
            else
            {
                if (DAT_B1390 == 2)
                {
                    DAT_B1391--;

                    if (DAT_B1391 == 0)
                    {
                        InventoryManager.FUN_1BBCC();
                        FUN_1B4CC(tVar2);
                    }
                }
            }
        }
    }

    private void FUN_1CBA4(Trigger param1)
    {
        Trigger2 tVar1;

        tVar1 = (Trigger2)param1;

        if (DAT_B1390 == 0)
        {
            InventoryManager.FUN_4A7E8(1, 0, false);
            InventoryManager.FUN_4A7E8(1, 3, false);
            DAT_B1391 = 30;
            DAT_B1390++;
        }
        else
        {
            if (DAT_B1390 == 1)
            {
                DAT_B1391--;

                if (DAT_B1391 == 0)
                {
                    InventoryManager.FUN_1BBCC();
                    SceneManager.instance.FUN_1AFC4(tVar1);
                }
            }
        }
    }

    private void FUN_1B4CC(Trigger6 param1)
    {
        int iVar1;
        byte bVar2;
        byte[] local_10;

        if (DAT_B138E < 43U && 15U < DAT_B138E)
        {
            local_10 = new byte[3];
            local_10[0] = DAT_B138E;
            local_10[1] = (byte)param1.DAT_1A;
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

    private void FUN_1B550(Trigger6 param1)
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
                    GameManager.instance.DAT_9EE8 += (byte)param1.DAT_1A;
                    break;
                case 0x21:
                    GameManager.instance.DAT_9EE9 += (byte)param1.DAT_1A;
                    break;
                case 0x22:
                    GameManager.instance.DAT_9EEA += (byte)param1.DAT_1A;
                    break;
                case 0x23:
                    GameManager.instance.DAT_9EEB += (byte)param1.DAT_1A;
                    break;
                case 0x2b:
                    GameManager.instance.DAT_A0E0 += param1.DAT_1A;
                    break;
            }

            GameManager.instance.DAT_39 = 0;
        }

        param1.DAT_13 = false;

        if (param1.DAT_1A == 0xff)
            iVar1 = 8;
        else
            iVar1 = 7;

        InventoryManager.FUN_4A7E8(iVar1, param1.DAT_1C, true);
        InventoryManager.FUN_4A7E8(11, DAT_B138E, true);
        GameManager.instance.DAT_2E = (short)(DAT_B138E | param1.DAT_1A << 8);
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
