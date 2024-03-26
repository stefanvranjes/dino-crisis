using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriInteract : MonoBehaviour
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public byte DAT_04;
    public byte DAT_05;
    public byte DAT_06;
    public short DAT_08;
    public byte BDAT_08;
    public CriSkinned PDAT_08;
    public bool DAT_09;
    public short DAT_0A;
    public sbyte BDAT_0A;
    public sbyte DAT_0B;
    public short DAT_0C;
    public byte BDAT_0C;
    public byte DAT_0D;
    public short DAT_0E;
    public byte BDAT_0E;
    public byte DAT_0F;
    public Vector3Int VDAT_10;
    public byte DAT_10;
    public byte DAT_11;
    public sbyte DAT_12;
    public sbyte DAT_13;
    public sbyte DAT_14;
    public ushort DAT_16;
    public byte DAT_17;
    public CriBone PTR_18;
    public byte DAT_18;
    public byte DAT_19;
    public CriObject DAT_1C;
    public CriSkinned DAT_20;
    private delegate void FUN_54(); //0x54 (ST1)
    private delegate void FUN_7984(); //0x7984 (ST1)
    private delegate void FUN_7A8C(); //0x7A8C (ST1)
    private delegate void FUN_7B14(); //0x7B14 (ST1)
    private delegate void FUN_7B28(); //0x7B28 (ST1)
    private delegate void FUN_99208();
    private delegate void FUN_99214();
    private delegate void FUN_99224(CriStatic o);
    private delegate void FUN_99250();
    private delegate void FUN_99260();
    private delegate void FUN_9926C();
    private delegate void FUN_99278();
    private delegate void FUN_99284();
    private FUN_54[] PTR_FUN_54; //0x54 (ST1)
    private FUN_7984[] PTR_FUN_7984; //0x7984 (ST1)
    private FUN_7A8C[] PTR_FUN_7A8C; //0x7A8C (ST1)
    private FUN_7B14[] PTR_FUN_7B14; //0x7B14 (ST1)
    private FUN_7B28[] PTR_FUN_7B28; //0x7B28 (ST1)
    private FUN_99208[] PTR_FUN_99208;
    private FUN_99214[] PTR_FUN_99214;
    private static byte[] DAT_99220 = new byte[2] { 217, 218 };
    private FUN_99224[] PTR_FUN_99224;
    private static uint[] DAT_99244 = new uint[3] { 0x8017d000, 0x8017e000, 0x8017f000 };
    private FUN_99250[] PTR_FUN_99250;
    private FUN_99260[] PTR_FUN_99260;
    private FUN_9926C[] PTR_FUN_9926C;
    private FUN_99278[] PTR_FUN_99278;
    private FUN_99284[] PTR_FUN_99284;

    void Awake()
    {
        PTR_FUN_54 = new FUN_54[6]
        {
            FUN_3018,
            FUN_30A8,
            FUN_3138,
            FUN_31C8,
            FUN_2F84,
            FUN_3270
        };
        PTR_FUN_7984 = new FUN_7984[7]
        {
            FUN_2E74,
            FUN_2F24,
            FUN_3378,
            FUN_33DC,
            FUN_34D0,
            FUN_3500,
            FUN_5FF98
        };
        PTR_FUN_7A8C = new FUN_7A8C[7]
        {
            FUN_51E4,
            FUN_52C8,
            FUN_54D8,
            FUN_55CC,
            FUN_56B4,
            FUN_570C,
            FUN_5FF98
        };
        PTR_FUN_7B14 = new FUN_7B14[3]
        {
            FUN_6700,
            FUN_6718,
            FUN_5FF98
        };
        PTR_FUN_7B28 = new FUN_7B28[5]
        {
            FUN_7084,
            FUN_7090,
            FUN_70E0,
            FUN_71EC,
            FUN_5FF98
        };
        PTR_FUN_99208 = new FUN_99208[3]
        {
            FUN_20B48,
            FUN_20B78,
            FUN_5FF98
        };
        PTR_FUN_99214 = new FUN_99214[3]
        {
            FUN_20BB4,
            FUN_20C94,
            FUN_215E0
        };
        PTR_FUN_99224 = new FUN_99224[2]
        {
            FUN_21890,
            FUN_2193C
        };
        PTR_FUN_99250 = new FUN_99250[4]
        {
            FUN_21F08,
            FUN_21FB8,
            FUN_220B4,
            FUN_5FF98
        };
        PTR_FUN_99260 = new FUN_99260[3]
        {
            FUN_221B4,
            FUN_221DC,
            FUN_5FF98
        };
        PTR_FUN_9926C = new FUN_9926C[3]
        {
            FUN_222E8,
            FUN_22314,
            FUN_5FF98
        };
        PTR_FUN_99278 = new FUN_99278[3]
        {
            FUN_224A0,
            FUN_224C8,
            FUN_5FF98
        };
        PTR_FUN_99284 = new FUN_99284[7]
        {
            FUN_2271C, 
            FUN_2278C, 
            FUN_227FC, 
            FUN_22B50, 
            FUN_22CB4, 
            FUN_22E98, 
            FUN_5FF98
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetValues()
    {
        DAT_00 = 0;
        DAT_01 = 0;
        DAT_02 = 0;
        DAT_03 = 0;
        DAT_04 = 0;
        DAT_05 = 0;
        DAT_06 = 0;
        DAT_08 = 0;
        BDAT_08 = 0;
        PDAT_08 = null;
        DAT_09 = false;
        DAT_0A = 0;
        BDAT_0A = 0;
        DAT_0B = 0;
        DAT_0C = 0;
        BDAT_0C = 0;
        DAT_0D = 0;
        DAT_0E = 0;
        BDAT_0E = 0;
        DAT_0F = 0;
        VDAT_10 = Vector3Int.zero;
        DAT_10 = 0;
        DAT_11 = 0;
        DAT_12 = 0;
        DAT_13 = 0;
        DAT_14 = 0;
        DAT_16 = 0;
        DAT_17 = 0;
        PTR_18 = null;
        DAT_18 = 0;
        DAT_19 = 0;
        DAT_1C = null;
        DAT_20 = null;
    }

    public void FUN_20A98()
    {
        return;
    }

    public void FUN_20AA0()
    {
        return;
    }

    public void FUN_20AA8()
    {
        bool bVar1;
        CriStatic oVar2;

        oVar2 = SceneManager.instance.DAT_7CDC[DAT_04];
        bVar1 = InventoryManager.FUN_4A87C(2, 2);

        if (!bVar1)
            oVar2.vr.y = oVar2.vr.y + 0x40 & 0xfff;
    }

    public void FUN_20B0C()
    {
        PTR_FUN_99208[DAT_03]();
    }

    private void FUN_20B48()
    {
        DAT_03++;
        //FUN_601A4
    }

    private void FUN_20B78()
    {
        PTR_FUN_99214[DAT_04]();
    }

    private void FUN_20BB4()
    {
        bool bVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;

        uVar3 = 0;
        uVar4 = DAT_02;

        do
        {
            bVar1 = InventoryManager.FUN_4A87C(11, uVar4);
            uVar3++;

            if (!bVar1)
            {
                GameManager.instance.FUN_5C94C(null, 214);
                DAT_03++;
                InventoryManager.FUN_4A7E8(2, 10, true);
                iVar2 = DialogManager.instance.FUN_1CC54(32);
                DialogManager.instance.FUN_1E2D8(DialogManager.DAT_98628, iVar2, 0, 0xffff);
                return;
            }

            uVar4 += 7;
        } while (uVar3 < 2);

        GameManager.instance.FUN_5C94C(null, 212);
        DAT_04++;
        GameManager.instance.DAT_38 = 0x7f;
        iVar2 = InventoryManager.instance.FUN_67BF8(5);
        DAT_18 = (byte)iVar2; //write int instead byte??
    }

    private void FUN_20C94()
    {
        uint uVar3;

        uVar3 = InventoryManager.instance.FUN_67C30();

        if ((uVar3 & 0x8000) == 0)
        {
            if ((uVar3 & 0x2000) == 0)
            {
                if ((uVar3 & 0x1000) == 0)
                {
                    if ((uVar3 & 0x4000) == 0)
                    {
                        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                        {
                            if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                            {
                                if (DAT_14 == 0 && DAT_13 == 9)
                                {
                                    //...
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void FUN_215E0()
    {
        bool bVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;

        bVar1 = InventoryManager.FUN_4A87C(2, 9);

        if (!bVar1)
            GameManager.instance.FUN_5C94C(null, 214);
        else
        {
            GameManager.instance.FUN_5C94C(null, 213);
            iVar2 = DialogManager.instance.FUN_1CC54(31);
            DialogManager.instance.FUN_1E2D8(DialogManager.DAT_98628, iVar2, 0, 0xffff);
            uVar4 = DAT_02;
            uVar3 = 0;

            do
            {
                InventoryManager.FUN_4A7E8(11, uVar4, false);
                uVar3++;
                uVar4 += 7;
            } while (uVar3 < 2);
        }

        DAT_03++;
        GameManager.instance.DAT_38 = 0;
        InventoryManager.instance.FUN_67BF8(DAT_18); //read int instead byte??
        InventoryManager.instance.FUN_674E8(0xe, 0xe);
    }

    public void FUN_21758()
    {
        bool bVar1;
        bool bVar2;
        CriStatic oVar3;

        oVar3 = SceneManager.instance.DAT_7CDC[DAT_04];

        if (DAT_03 == 0)
        {
            DAT_03++;
            bVar1 = InventoryManager.FUN_4A87C(0, DAT_05);
            DAT_09 = bVar1;
            PTR_FUN_99224[bVar1 ? 1 : 0](oVar3);
        }
        else
        {
            if (DAT_03 == 1)
            {
                bVar2 = InventoryManager.FUN_4A87C(0, DAT_05);
                BDAT_0A = (sbyte)(bVar2 ? 1 : 0);

                if (DAT_09 != bVar2)
                {
                    GameManager.instance.FUN_5C94C(oVar3, DAT_99220[BDAT_0A]);
                    DAT_0B = BDAT_0A;
                }

                DAT_09 = BDAT_0A != 0;
                PTR_FUN_99224[BDAT_0A](oVar3);
                FUN_219AC();
                DAT_0B = -1;
            }
        }
    }

    private void FUN_21890(CriStatic param1)
    {
        byte bVar1;
        uint uVar2;
        CriStatic oVar3;

        oVar3 = SceneManager.instance.DAT_7CDC[System.Array.IndexOf(SceneManager.instance.DAT_7CDC, param1) + 1];
        SceneManager.instance.FUN_8133C(DAT_06, 0x8000, 0);
        SceneManager.instance.FUN_8133C(DAT_06, 0x2000, 1);
        bVar1 = (byte)(BDAT_08 + 1);
        BDAT_08 = bVar1;

        if ((bVar1 & 1) == 0)
        {
            param1.flags &= 0xfffffffd;
            uVar2 = oVar3.flags | 2;
        }
        else
        {
            param1.flags |= 2;
            uVar2 = oVar3.flags & 0xfffffffd;
        }

        oVar3.flags = uVar2;
    }

    private void FUN_2193C(CriStatic param1)
    {
        CriStatic oVar1;

        oVar1 = SceneManager.instance.DAT_7CDC[System.Array.IndexOf(SceneManager.instance.DAT_7CDC, param1) + 1];
        SceneManager.instance.FUN_8133C(DAT_06, 0x8000, 1);
        SceneManager.instance.FUN_8133C(DAT_06, 0x2000, 0);
        param1.flags &= 0xfffffffd;
        oVar1.flags &= 0xfffffffd;
    }

    private void FUN_219AC()
    {
        uint uVar1;
        sbyte sVar3;
        int iVar4;
        CriPlayer oVar5;
        CriStatic oVar6;
        uint uVar8;

        uVar8 = 0;
        oVar6 = SceneManager.instance.DAT_7CDC[DAT_04];

        do
        {
            //...
            uVar1 = GameManager.instance.FUN_835F4(oVar6);

            if ((uVar1 & 0xff) != 0xff)
            {
                oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[uVar1 & 0xff];
                iVar4 = (int)uVar1 >> 0x10;

                if (oVar5.tags == 0)
                    oVar5.FUN_21CCC(oVar6, iVar4);

                sVar3 = oVar5.tags;

                if (sVar3 == 2)
                    oVar5.FUN_21C18(oVar6, (short)iVar4, this);

                if (sVar3 == 8 && GameManager.instance.DAT_9AA0 != 0x606) //tmp
                    oVar5.FUN_21B0C(oVar6, (short)iVar4, this);
            }

            //...
            uVar8++;
            oVar6 = SceneManager.instance.DAT_7CDC[DAT_04 + uVar8];
        } while (uVar8 < 2);
    }

    public void FUN_21ECC()
    {
        PTR_FUN_99250[DAT_03]();
    }

    private void FUN_21F08()
    {
        byte bVar1;
        CriSkinned oVar2;
        CriStatic oVar3;
        TmdScriptableObject puVar4;

        oVar2 = SceneManager.instance.DAT_27C[10];
        bVar1 = DAT_02;
        oVar3 = SceneManager.instance.DAT_7CDC[DAT_04];
        oVar3.flags = 1;
        oVar3.DAT_40 = null;
        oVar3.screen = new Vector3Int(oVar2.screen.x, oVar2.screen.y - 0x640, oVar2.screen.z);
        puVar4 = (TmdScriptableObject)Utilities.GetRamObject(DAT_99244[(bVar1 >> 4) - 1]);
        oVar3.cCollider = null;
        oVar2.vr = new Vector3Int(0, 0, 0);
        oVar3.flags |= 2;
        oVar3.cMesh = puVar4;
        DAT_08 = 0;
        DAT_0A = -250;
        DAT_0C = 0;
        DAT_0E = 0;
        DAT_03++;
    }

    private void FUN_21FB8()
    {
        bool bVar1;
        CriStatic oVar2;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.DAT_7CDC[DAT_04];
        local_18 = oVar2.screen;
        oVar2.vr.x += 0x200;
        DAT_0A += 0x20;
        oVar2.screen.x += DAT_08;
        oVar2.screen.y += DAT_0A;
        oVar2.screen.z += DAT_0C;
        bVar1 = SceneManager.instance.FUN_836F0(ref oVar2.screen, local_18) != 0;

        if (bVar1)
        {
            GameManager.instance.FUN_5C94C(oVar2, 19);
            DAT_0A = 0x280;
            oVar2.vr = new Vector3Int(0, 0, 0x400);
            DAT_03++;
        }
    }

    private void FUN_220B4()
    {
        short sVar1;
        CriStatic oVar2;

        oVar2 = SceneManager.instance.DAT_7CDC[DAT_04];
        oVar2.vr.y += DAT_0A;
        sVar1 = DAT_0A;
        DAT_0A = (short)(sVar1 - 0x20);

        if (sVar1 == 0x20)
        {
            //FUN_1A6B8
            oVar2.cCollider = null;
            DAT_03++;
        }

        oVar2.screen.x += DAT_08;
        oVar2.screen.z += DAT_0C;
    }

    public void FUN_22178()
    {
        PTR_FUN_99260[DAT_03]();
    }

    private void FUN_221B4()
    {
        DAT_0A = 0;
        DAT_03 = 1;
        FUN_221DC();
    }

    private void FUN_221DC()
    {
        //...
    }

    public void FUN_222AC()
    {
        PTR_FUN_9926C[DAT_03]();
    }

    private void FUN_222E8()
    {
        DAT_08 = 0;
        DAT_03++;
        FUN_22314();
    }

    private void FUN_22314()
    {
        //...
    }

    public void FUN_22464()
    {
        PTR_FUN_99278[DAT_03]();
    }

    private void FUN_224A0()
    {
        DAT_08 = 0;
        DAT_03 = 1;
        FUN_224C8();
    }

    private void FUN_224C8()
    {
        //...
    }

    public void FUN_2268C()
    {
        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            PTR_FUN_99284[DAT_03]();

            if ((PTR_18.flags & 6) == 0)
                DAT_1C.flags &= 0xfffffffd;
        }
    }

    private void FUN_2271C()
    {
        int iVar1;

        iVar1 = (int)GameManager.FUN_64650();
        DAT_03++;
        DAT_08 = (short)(iVar1 + (iVar1 / 90) * -90 + 300);
    }

    private void FUN_2278C()
    {
        ushort uVar1;
        CriSkinned oVar2;

        uVar1 = (ushort)(DAT_08 - 1);
        DAT_08 = (short)uVar1;

        if (uVar1 << 0x10 < 1)
        {
            oVar2 = DAT_20;
            oVar2.DAT_19A &= (ushort)~(1 << (DAT_19 + DAT_18 * 4 & 0x1f));
            oVar2.DAT_199--;
            DAT_03++;
        }
    }

    private void FUN_227FC()
    {
        CriStatic oVar2;
        CriObject oVar4;
        CriSkinned oVar6;
        Vector3Int local_28;

        LevelManager.instance.DAT_C2590 = DAT_1C;
        oVar6 = DAT_20;
        oVar2 = (CriStatic)LevelManager.instance.DAT_C2590;
        local_28 = oVar2.screen;
        local_28 = Utilities.ApplyMatrixSV(ref oVar2.DAT_40.cTransform.rotation, ref local_28);
        oVar2.screen.x = oVar2.DAT_40.screen.x + local_28.x;
        oVar2.screen.y = oVar2.DAT_40.screen.y + local_28.y;
        oVar2.screen.z = oVar2.DAT_40.screen.z + local_28.z;
        LevelManager.instance.DAT_C2594 = 0;
        LevelManager.instance.DAT_C2598 = new Vector3Int(0, 0, 0);

        do
        {
            oVar4 = Utilities.FUN_601C8(oVar6.skeleton, LevelManager.instance.DAT_C2594);
            LevelManager.instance.DAT_C2598.x = LevelManager.instance.DAT_C2598.x + oVar4.vr.x & 0xfff;
            LevelManager.instance.DAT_C2598.y = LevelManager.instance.DAT_C2598.y + oVar4.vr.y & 0xfff;
            LevelManager.instance.DAT_C2598.z = LevelManager.instance.DAT_C2598.z + oVar4.vr.z & 0xfff;
            LevelManager.instance.DAT_C2594++;
        } while (LevelManager.instance.DAT_C2594 <= DAT_16);

        oVar2.DAT_40 = null;
        oVar2.vr.x = LevelManager.instance.DAT_C2598.x + oVar2.vr.x & 0xfff;
        oVar2.vr.y = LevelManager.instance.DAT_C2598.y + oVar2.vr.y & 0xfff;
        oVar2.vr.z = LevelManager.instance.DAT_C2598.z + oVar2.vr.z & 0xfff;
        DAT_0C = 40;
        DAT_0E = 20;

        if ((oVar2.screen.x & 0x800) == 0)
            VDAT_10.x = -((oVar2.screen.x / 5) * 0x10000 >> 0x10);
        else
            VDAT_10.x = (0x1000 - oVar2.screen.x) / 5;

        if ((oVar2.screen.y & 0x800) == 0)
            VDAT_10.y = -((oVar2.screen.y / 5) * 0x10000 >> 0x10);
        else
            VDAT_10.y = (0x1000 - oVar2.screen.y) / 5;

        if ((oVar2.screen.z & 0x800) == 0)
            VDAT_10.z = -((oVar2.screen.z / 5) * 0x10000 >> 0x10);
        else
            VDAT_10.z = (0x1000 - oVar2.screen.z) / 5;

        DAT_0A = 4;
        DAT_03++;
    }

    private void FUN_22B50()
    {
        ushort uVar1;
        ushort uVar2;
        uint uVar3;
        short sVar4;
        CriSkinned oVar5;

        oVar5 = (CriSkinned)DAT_1C;

        if (-1 < DAT_0A)
        {
            oVar5.vr.x = oVar5.vr.x + VDAT_10.x & 0xfff;
            oVar5.vr.y = oVar5.vr.y + VDAT_10.y & 0xfff;
            oVar5.vr.z = oVar5.vr.z + VDAT_10.z & 0xfff;
            uVar1 = (ushort)(DAT_0A - 1);
            DAT_0A = (short)uVar1;

            if (uVar1 << 0x10 < 0)
                oVar5.vr = new Vector3Int(0, 0, 0);
        }

        oVar5.DAT_34 = oVar5.screen;
        sVar4 = (short)(DAT_0C + DAT_0E);
        DAT_0C = sVar4;
        oVar5.screen.y += sVar4;
        uVar3 = SceneManager.instance.FUN_83534(ref oVar5.screen, oVar5.DAT_34);

        if ((uVar3 & 2) != 0)
        {
            oVar5.screen.x = oVar5.DAT_34.x;
            oVar5.screen.z = oVar5.DAT_34.z;
        }

        if ((uVar3 & 1) != 0 || -1 < oVar5.screen.y)
        {
            DAT_0A = 0;
            uVar1 = (ushort)GameManager.FUN_64650();
            uVar2 = (ushort)GameManager.FUN_64650();
            DAT_08 = (short)((uVar1 & 1) * 0x100 + (uVar2 & 1));
            DAT_03++;
        }
    }

    private void FUN_22CB4()
    {
        ushort uVar1;
        short sVar2;
        uint uVar3;
        CriSkinned oVar4;

        oVar4 = (CriSkinned)DAT_1C;
        oVar4.DAT_34 = oVar4.screen;
        uVar1 = (ushort)DAT_0A;
        DAT_0A = (short)(uVar1 + 1);
        sVar2 = Utilities.DAT_992A0[(uVar1 << 0x10) >> 0xf];
        DAT_0C = sVar2;
        oVar4.screen.y += sVar2;

        if ((DAT_08 & 0x100) != 0)
        {
            oVar4.screen.x += 50;
            oVar4.vr.z = oVar4.vr.z + 0x66 & 0xfff;
        }

        if ((DAT_08 & 1) != 0)
        {
            oVar4.screen.z += 50;
            oVar4.vr.x = oVar4.vr.x + 0x66 & 0xfff;
        }

        if (DAT_08 == 0)
        {
            oVar4.vr.z = oVar4.vr.z + 0x66 & 0xfff;
            oVar4.vr.x = oVar4.vr.x + 0x66 & 0xfff;
        }

        uVar3 = SceneManager.instance.FUN_83534(ref oVar4.screen, oVar4.DAT_34);

        if ((uVar3 & 2) != 0)
        {
            oVar4.screen.x = oVar4.DAT_34.x;
            oVar4.screen.z = oVar4.DAT_34.z;
        }

        if (9 < DAT_0A)
        {
            oVar4.screen.y = 0;
            SceneManager.instance.FUN_83534(ref oVar4.screen, oVar4.DAT_34);

            if ((DAT_08 & 0x100) != 0)
                oVar4.vr.z = 0x400;

            if ((DAT_08 & 1) != 0)
                oVar4.vr.x = 0x400;

            if (DAT_08 == 0)
            {
                oVar4.vr.z = 0x400;
                oVar4.vr.x = 0x400;
            }

            DAT_0A = 30;
            DAT_03++;
        }
    }

    private void FUN_22E98()
    {
        ushort uVar1;

        uVar1 = (ushort)(DAT_0A - 1);
        DAT_0A = (short)uVar1;

        if (uVar1 << 0x10 < 1)
        {
            DAT_1C.FUN_5FF00();
            DAT_03++;
        }
    }

    public void FUN_5FF98()
    {
        DAT_00 = 0;
    }

    //FUN_2DD8 (ST1)
    public void FUN_2DD8()
    {
        byte bVar1;

        bVar1 = (byte)(DAT_14 + 3);
        DAT_14 = (sbyte)bVar1;

        if (99U < bVar1)
        {
            DAT_14 = 0;
            DAT_13 = (sbyte)bVar1;

            if (59U < bVar1)
            {
                DAT_13 = 0;
                DAT_12++;
            }
        }

        PTR_FUN_7984[DAT_03]();
        //FUN_3540
    }

    //FUN_2E74 (ST1)
    private void FUN_2E74()
    {
        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_26504(0, -0x1140, -0x778, 0x200);
        DAT_08 = 10000;
        BDAT_0A = -20;
        DAT_0B = 40;
        BDAT_0C = 4;
        BDAT_0E = 100;
        DAT_0D = 0;
        DAT_0F = 0;
        DAT_10 = 0;
        DAT_11 = 12;
        DAT_12 = 0;
        DAT_13 = 0;
        DAT_14 = 0;
        InventoryManager.FUN_4A7E8(2, 0xb, false);
        DAT_18 = 0;
        DAT_17 = 0;
        DAT_0D = 0;
        DAT_03++;
    }

    //FUN_2F24 (ST1)
    private void FUN_2F24()
    {
        ushort uVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xf000) != 0)
            GameManager.instance.FUN_5C94C(null, 145);

        if (5U < BDAT_0C)
        {
            if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
            {
                uVar1 = (ushort)(DAT_08 - 100);
                DAT_08 = (short)uVar1;

                if (uVar1 < 7000U)
                    DAT_08 = 7000;
            }

            if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
            {
                uVar1 = (ushort)(DAT_08 + 100);
                DAT_08 = (short)uVar1;

                if (10000 < uVar1)
                    DAT_08 = 10000;
            }

            return;
        }

        PTR_FUN_54[BDAT_0C]();
    }

    //FUN_2F84 (ST1)
    private void FUN_2F84()
    {
        ushort uVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            BDAT_0C = 0;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            DAT_03 = 2;
            GameManager.instance.FUN_5C94C(null, 146);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar1 = (ushort)(DAT_08 - 100);
            DAT_08 = (short)uVar1;

            if (uVar1 < 7000U)
                DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar1 = (ushort)(DAT_08 + 100);
            DAT_08 = (short)uVar1;

            if (10000U < uVar1)
                DAT_08 = 10000;
        }
    }

    //FUN_3018 (ST1)
    private void FUN_3018()
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x10a0) != 0)
        {
            sVar1 = (sbyte)(BDAT_0A + 1);
            BDAT_0A = sVar1;

            if (40 < sVar1)
                BDAT_0A = 40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(DAT_08 - 100);
            DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(DAT_08 + 100);
            DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                DAT_08 = 10000;
        }
    }

    //FUN_30A8 (ST1)
    private void FUN_30A8()
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x80a0) != 0)
        {
            sVar1 = (sbyte)(DAT_0B - 1);
            DAT_0B = sVar1;

            if (sVar1 < -40)
                DAT_0B = -40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            BDAT_0C = 0;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            BDAT_0C = 3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(DAT_08 - 100);
            DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(DAT_08 + 100);
            DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                DAT_08 = 10000;
        }
    }

    //FUN_3138 (ST1)
    private void FUN_3138()
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x20a0) != 0)
        {
            sVar1 = (sbyte)(DAT_0B + 1);
            DAT_0B = sVar1;

            if (40 < sVar1)
                DAT_0B = 40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            BDAT_0C = 0;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            BDAT_0C = 3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(DAT_08 - 100);
            DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(DAT_08 + 100);
            DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                DAT_08 = 10000;
        }
    }

    //FUN_31C8 (ST1)
    private void FUN_31C8()
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x20a0) != 0)
        {
            sVar1 = (sbyte)(BDAT_0A + 1);
            BDAT_0A = sVar1;

            if (sVar1 < -40)
                BDAT_0A = -40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(DAT_08 - 100);
            DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(DAT_08 + 100);
            DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                DAT_08 = 10000;
        }
    }

    //FUN_3270 (ST1)
    private void FUN_3270()
    {
        ushort uVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            BDAT_0C = 3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
            DAT_03 = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar1 = (ushort)(DAT_08 - 100);
            DAT_08 = (short)uVar1;

            if (uVar1 < 7000U)
                DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar1 = (ushort)(DAT_08 + 100);
            DAT_08 = (short)uVar1;

            if (10000U < uVar1)
                DAT_08 = 10000;
        }
    }

    //FUN_3378 (ST1)
    private void FUN_3378()
    {
        DAT_10 += 4;
        DAT_11--;

        if (99U < DAT_10)
        {
            DAT_10 = 100;
            DAT_03 = 3;
            DAT_11 = 12;
            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_33DC (ST1)
    private void FUN_33DC()
    {
        CriCamera oVar2;
        byte bVar3;
        CriParticle oVar4;

        oVar2 = SceneManager.instance.cCamera;
        bVar3 = (byte)(DAT_0D + 1);
        DAT_0D = bVar3;

        if (18U < bVar3)
        {
            DAT_0D = 0;
            DAT_03 = 4;

            if ((byte)BDAT_0A - 13U < 4 && (byte)DAT_0B - 3U < 4)
                InventoryManager.FUN_4A7E8(2, 9, true);

            oVar4 = SceneManager.instance.FUN_5FFA0();

            if (oVar4 != null)
            {
                GameManager.instance.FUN_5C94C(null, 148);
                oVar4.tags = 21;
                oVar4.DAT_2F = 2;
                oVar4.DAT_4C = null;
                oVar4.screen = oVar2.DAT_30;
                oVar4.DAT_62 = 10;
                oVar4.DAT_60 = 10;
                oVar4.DAT_68 = 0xff;
                oVar4.DAT_69 = 10;
                oVar4.DAT_6A = 10;
                oVar4.DAT_6B = 0;
            }
        }
    }

    //FUN_34D0 (ST1)
    private void FUN_34D0()
    {
        byte bVar1;

        bVar1 = (byte)(DAT_10 - 10);
        DAT_10 = bVar1;

        if (bVar1 < 11U)
        {
            DAT_10 = 0;
            DAT_03 = 1;
        }
    }

    //FUN_3500 (ST1)
    private void FUN_3500()
    {
        InventoryManager.FUN_4A7E8(2, 0xb, true);
        DAT_03++;
    }

    //FUN_51A8 (ST1)
    public void FUN_51A8()
    {
        PTR_FUN_7A8C[DAT_03]();
    }

    //FUN_51E4 (ST1)
    private void FUN_51E4()
    {
        sbyte sVar1;
        sbyte[] puVar2;
        bool bVar3;
        uint uVar4;
        uint uVar5;

        InventoryManager.FUN_4A7E8(2, 0xa, false);
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        InventoryManager.FUN_4A7E8(2, 0xb, false);
        DAT_08 = 0;
        DAT_0A = 0;
        DAT_0C = 0;
        puVar2 = ST1.instance.DAT_7B44;
        uVar4 = 0;

        do
        {
            puVar2[uVar4] = -1;
            uVar5 = uVar4 + 1;
            uVar4 = uVar5;
        } while (uVar5 < 5);

        ST1.instance.DAT_7B4B = 0;
        ST1.instance.DAT_7B4A = 0;
        ST1.instance.DAT_7B49 = 0;
        ST1.instance.DAT_7B4D = 0;
        ST1.instance.DAT_7B4C = 0;
        bVar3 = InventoryManager.FUN_4A87C(3, 0x20);
        sVar1 = 3;

        if (!bVar3)
            sVar1 = 1;

        DAT_03 = sVar1;
    }

    //FUN_52C8 (ST1)
    private void FUN_52C8()
    {
        short sVar1;

        //...

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (DAT_08 == 4)
                DAT_08 = 0;
            else
                DAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            sVar1 = (short)(DAT_08 - 1);

            if (DAT_08 == 0)
                sVar1 = 4;

            DAT_08 = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            sVar1 = (short)(DAT_0A - 1);

            if (DAT_0A == 0)
                sVar1 = 1;

            DAT_0A = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (DAT_0A == 1)
                DAT_0A = 0;
            else
                DAT_0A++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            ST1.instance.DAT_7B44[ST1.instance.DAT_7B49] = (sbyte)((byte)DAT_08 + DAT_0A * 5);

            if (ST1.instance.DAT_7B49 == 4)
                DAT_03 = 2;

            ST1.instance.DAT_7B49++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (ST1.instance.DAT_7B49 == 0)
            {
                InventoryManager.FUN_4A7E8(2, 0xb, true);
                DAT_03 = 5;
            }
            else
            {
                ST1.instance.DAT_7B44[ST1.instance.DAT_7B49] = -1;
                ST1.instance.DAT_7B49--;
            }

            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_54D8 (ST1)
    private void FUN_54D8()
    {
        bool bVar1;

        if (30 < ST1.instance.DAT_7B4A) goto LAB_5598;

        if (ST1.instance.DAT_7B4A == 0)
        {
            InventoryManager.FUN_4A7E8(3, 0x22, false);
            InventoryManager.FUN_4A7E8(3, 0x23, false);
            InventoryManager.FUN_4A7E8(3, 0x24, false);

            if (DAT_02 == 0)
            {
                //...
            }
            else
            {
                if (DAT_02 != 1) goto LAB_557C;

                //...
            }

            //...
        }

        LAB_557C:
        //...
        ST1.instance.DAT_7B4A++;
        LAB_5598:
        bVar1 = InventoryManager.FUN_4A87C(3, 0x21);

        if (bVar1)
        {
            DAT_03 = 3;
            ST1.instance.DAT_7B4A = 0;
        }
    }

    //FUN_55CC (ST1)
    private void FUN_55CC()
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;

        if (DAT_0C == 0)
        {
            bVar3 = InventoryManager.FUN_4A87C(3, 0x24);

            if (bVar3)
                InventoryManager.FUN_4A7E8(2, 0xa, true);
            else
            {
                bVar3 = InventoryManager.FUN_4A87C(3, 0x23);

                if (bVar3)
                    InventoryManager.FUN_4A7E8(2, 0xa, true);
            }
        }

        //...
        sVar2 = (short)(DAT_0C + 1);
        DAT_0C = sVar2;

        if (sVar2 == 150)
        {
            bVar3 = InventoryManager.FUN_4A87C(2, 0xa);
            sVar1 = 5;

            if (!bVar3)
                sVar1 = 4;

            DAT_03 = sVar1;

            if (DAT_0C == 150)
            {
                bVar3 = InventoryManager.FUN_4A87C(2, 0xa);

                if (!bVar3)
                    iVar4 = 148;
                else
                    iVar4 = 149;

                GameManager.instance.FUN_5C94C(null, iVar4);
            }
        }
    }

    //FUN_56B4 (ST1)
    private void FUN_56B4()
    {
        //...

        if (29 < ST1.instance.DAT_7B4A)
        {
            DAT_03 = 5;
            ST1.instance.DAT_7B4A = 0;
        }

        ST1.instance.DAT_7B4A++;
    }

    //FUN_570C (ST1)
    private void FUN_570C()
    {
        DAT_03 = 5;
    }

    //FUN_66C4 (ST1)
    public void FUN_66C4()
    {
        PTR_FUN_7B14[DAT_03]();
    }

    //FUN_6700 (ST1)
    private void FUN_6700()
    {
        DAT_0A = 0;
        DAT_08 = 0;
        DAT_03++;
    }

    //FUN_6718 (ST1)
    private void FUN_6718()
    {
        ushort uVar2;
        sbyte sVar3;
        int iVar4;
        CriParticle oVar5;
        uint uVar6;

        uVar6 = (ushort)DAT_0A;

        if (DAT_0A < 9)
        {
            do
            {
                iVar4 = (int)uVar6 * 12;

                if (ST1.instance.DAT_7AA0[iVar4 + 6] != DAT_08) break;

                oVar5 = SceneManager.instance.FUN_5FFA0();

                if (oVar5 != null)
                {
                    oVar5.tags = 20;
                    oVar5.DAT_2F = (byte)(ST1.instance.DAT_7AA0[iVar4 + 7] | 0x80);
                    oVar5.DAT_4C = SceneManager.instance.DAT_7CDC[DAT_04];
                    oVar5.DAT_40.x = ST1.instance.DAT_7AA0[iVar4 + 8] << 0x18 >> 0x17;
                    oVar5.DAT_40.y = ST1.instance.DAT_7AA0[iVar4 + 9] << 0x18 >> 0x17;
                    oVar5.DAT_40.z = ST1.instance.DAT_7AA0[iVar4 + 10] << 0x18 >> 0x17;
                    oVar5.DAT_6C = 0x80;
                }

                uVar6 = (ushort)DAT_0A + 1U;
                DAT_0A = (short)uVar6;
            } while ((short)uVar6 < 9);
        }

        //...
        uVar2 = (ushort)DAT_08;
        DAT_08 = (short)(uVar2 + 1);

        if (5 < DAT_08)
        {
            DAT_0A = 0;
            DAT_08 = 0;
        }

        sVar3 = (sbyte)(DAT_05 - 1);
        DAT_05 = (byte)sVar3;

        if (sVar3 == 0)
        {
            DAT_03++;
            ST1.instance.FUN_6A9C();
        }
    }

    //FUN_6B74 (ST1)
    public void FUN_6B74()
    {
        CriTrigger tVar1;

        tVar1 = SceneManager.instance.DAT_9EEC[DAT_04];
        tVar1.DAT_01 = DAT_05;
        tVar1.DAT_0E = 0;
        tVar1.DAT_10 = 0;
        tVar1.DAT_12 = 0;
        tVar1.DAT_14 = false;
        InventoryManager.FUN_4A7E8(5, tVar1.DAT_02, false);
        FUN_5FF98();
    }

    //FUN_7084 (ST1)
    private void FUN_7084()
    {
        DAT_03 = 1;
    }

    //FUN_7090 (ST1)
    private void FUN_7090()
    {
        CriSkinned oVar1;
        uint uVar2;

        uVar2 = 0;

        do
        {
            oVar1 = SceneManager.instance.DAT_27C[uVar2];

            if (oVar1.tags == 2)
            {
                PDAT_08 = oVar1;
                DAT_03 = 2;
                return;
            }
        } while (uVar2 < 10);
    }

    //FUN_70E0 (ST1)
    private void FUN_70E0()
    {
        //...
    }

    //FUN_71EC (ST1)
    private void FUN_71EC()
    {
        return;
    }

    //FUN_71F4 (ST1)
    public void FUN_71F4()
    {
        PTR_FUN_7B28[DAT_03]();
    }
}
