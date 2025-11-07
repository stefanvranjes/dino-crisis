using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_PARTICLE_10
{
    public Vector3Int DAT_00; //0x00
    public byte DAT_06; //0x06
    public byte DAT_07; //0x07
    public Vector3Int DAT_08; //0x08
    public sbyte DAT_0E; //0x0E
    public byte DAT_0F; //0x0F
    public short DAT_10; //0x10
    public byte DAT_12; //0x12
    public byte DAT_13; //0x13
    public byte DAT_14; //0x14
    public byte DAT_15; //0x15
}

public struct UNK_PARTICLE_10_2
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public byte DAT_02; //0x02
    public Vector3Int DAT_04; //0x04
    public byte DAT_0A; //0x0A
    public Vector3Int DAT_0C; //0x0C
    public byte DAT_12; //0x12
    public byte DAT_13; //0x13
    public byte DAT_14; //0x14
    public byte DAT_15; //0x15
    public byte DAT_16; //0x16
}

public class CriInteract : MonoBehaviour
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public byte DAT_04;
    public byte DAT_05;
    public byte DAT_06;
    public byte DAT_07;
    public short DAT_08;
    public byte BDAT_08;
    public CriObject PDAT_08;
    public byte[] PTR_08;
    public bool DAT_09;
    public byte BDAT_09;
    public short DAT_0A;
    public sbyte BDAT_0A;
    public sbyte DAT_0B;
    public short DAT_0C;
    public byte BDAT_0C;
    public Vector3Int VDAT_0C;
    public uint UDAT_0C;
    public CriObject PDAT_0C;
    public Tmd2ScriptableObject TDAT_0C;
    public byte[] PTR_0C;
    public FUN_0C PTR_FUN_0C;
    public byte DAT_0D;
    public short DAT_0E;
    public byte BDAT_0E;
    public Vector3Int VDAT_0E;
    public byte DAT_0F;
    public byte[] ADAT_10;
    public int IDAT_10;
    public CriObject PDAT_10;
    public Vector3Int VDAT_10;
    public TodScriptableObject[] TDAT_10;
    public short SDAT_10;
    public UNK_PARTICLE_10[] DAT_10_2;
    public UNK_PARTICLE_10_2[] DAT_10_3;
    public byte DAT_10;
    public byte DAT_11;
    public short SDAT_12;
    public sbyte DAT_12;
    public sbyte DAT_13;
    public CriObject PDAT_14;
    public Vector4Int[] VDAT_14;
    public int IDAT_14;
    public sbyte DAT_14;
    public short SDAT_14;
    public sbyte DAT_15;
    public short DAT_16;
    public byte BDAT_16;
    public sbyte DAT_17;
    public CriBone PTR_18;
    public byte DAT_18;
    public short SDAT_18;
    public uint UDAT_18;
    public byte DAT_19;
    public byte DAT_1A;
    public short SDAT_1A;
    public byte DAT_1B;
    public CriObject DAT_1C;
    public CriSkinned DAT_20;
    public delegate void FUN_0C();
    private delegate void FUN_99208();
    private delegate void FUN_99214();
    private delegate void FUN_99224(CriStatic o);
    private delegate void FUN_99250();
    private delegate void FUN_99260();
    private delegate void FUN_9926C();
    private delegate void FUN_99278();
    private delegate void FUN_99284();
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
        PTR_08 = null;
        DAT_09 = false;
        DAT_0A = 0;
        BDAT_0A = 0;
        DAT_0B = 0;
        DAT_0C = 0;
        BDAT_0C = 0;
        VDAT_0C = Vector3Int.zero;
        PDAT_0C = null;
        TDAT_0C = null;
        PTR_0C = null;
        UDAT_0C = 0;
        DAT_0D = 0;
        DAT_0E = 0;
        BDAT_0E = 0;
        VDAT_0E = Vector3Int.zero;
        DAT_0F = 0;
        ADAT_10 = null;
        IDAT_10 = 0;
        PDAT_10 = null;
        VDAT_10 = Vector3Int.zero;
        TDAT_10 = null;
        SDAT_10 = 0;
        DAT_10_2 = null;
        DAT_10_3 = null;
        DAT_10 = 0;
        DAT_11 = 0;
        SDAT_12 = 0;
        DAT_12 = 0;
        DAT_13 = 0;
        DAT_14 = 0;
        PDAT_14 = null;
        VDAT_14 = null;
        IDAT_14 = 0;
        SDAT_14 = 0;
        DAT_15 = 0;
        DAT_16 = 0;
        BDAT_16 = 0;
        DAT_17 = 0;
        PTR_18 = null;
        DAT_18 = 0;
        SDAT_18 = 0;
        DAT_19 = 0;
        DAT_1A = 0;
        SDAT_1A = 0;
        DAT_1B = 0;
        DAT_1C = null;
        DAT_20 = null;
    }

    public void SET_OFFSET_08(int i, byte value)
    {
        switch (i)
        {
            case 0:
                BDAT_08 = value;
                break;
            case 1:
                BDAT_09 = value;
                break;
            case 2:
                BDAT_0A = (sbyte)value;
                break;
            case 3:
                DAT_0B = (sbyte)value;
                break;
            case 4:
                BDAT_0C = value;
                break;
            case 5:
                DAT_0D = value;
                break;
            case 6:
                BDAT_0E = value;
                break;
            case 7:
                DAT_0F = value;
                break;
            case 8:
                DAT_10 = value;
                break;
            case 9:
                DAT_11 = value;
                break;
            case 10:
                DAT_12 = (sbyte)value;
                break;
            case 11:
                DAT_13 = (sbyte)value;
                break;
            case 12:
                DAT_14 = (sbyte)value;
                break;
            case 13:
                DAT_15 = (sbyte)value;
                break;
            case 14:
                BDAT_16 = value;
                break;
            case 15:
                DAT_17 = (sbyte)value;
                break;
            case 16:
                DAT_18 = value;
                break;
            case 17:
                DAT_19 = value;
                break;
            case 18:
                DAT_1A = value;
                break;
            case 19:
                DAT_1B = value;
                break;
        }
    }

    public void SET_OFFSET_08_2(int i, short value)
    {
        switch (i)
        {
            case 0:
                DAT_08 = value;
                break;
            case 1:
                DAT_0A = value;
                break;
            case 2:
                DAT_0C = value;
                break;
            case 3:
                DAT_0E = value;
                break;
            case 4:
                SDAT_10 = value;
                break;
            case 5:
                SDAT_12 = value;
                break;
            case 6:
                SDAT_14 = value;
                break;
            case 7:
                DAT_16 = value;
                break;
            case 8:
                SDAT_18 = value;
                break;
            case 9:
                SDAT_1A = value;
                break;
        }
    }

    public byte GET_OFFSET_08(int i)
    {
        switch (i)
        {
            case 0:
                return BDAT_08;
            case 1:
                return BDAT_09;
            case 2:
                return (byte)BDAT_0A;
            case 3:
                return (byte)DAT_0B;
            case 4:
                return BDAT_0C;
            case 5:
                return DAT_0D;
            case 6:
                return BDAT_0E;
            case 7:
                return DAT_0F;
            case 8:
                return DAT_10;
            case 9:
                return DAT_11;
            case 10:
                return (byte)DAT_12;
            case 11:
                return (byte)DAT_13;
            case 12:
                return (byte)DAT_14;
            case 13:
                return (byte)DAT_15;
            case 14:
                return BDAT_16;
            case 15:
                return (byte)DAT_17;
            case 16:
                return DAT_18;
            case 17:
                return DAT_19;
            case 18:
                return DAT_1A;
            case 19:
                return DAT_1B;
            default:
                return 0;
        }
    }

    public short GET_OFFSET_08_2(int i)
    {
        switch (i)
        {
            case 0:
                return DAT_08;
            case 1:
                return DAT_0A;
            case 2:
                return DAT_0C;
            case 3:
                return DAT_0E;
            case 4:
                return SDAT_10;
            case 5:
                return SDAT_12;
            case 6:
                return SDAT_14;
            case 7:
                return DAT_16;
            case 8:
                return SDAT_18;
            case 9:
                return SDAT_1A;
            default:
                return 0;
        }
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

        oVar2 = SceneManager.instance.staticObjects[DAT_04];
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

        oVar3 = SceneManager.instance.staticObjects[DAT_04];

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

        oVar3 = SceneManager.instance.staticObjects[System.Array.IndexOf(SceneManager.instance.staticObjects, param1) + 1];
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

        oVar1 = SceneManager.instance.staticObjects[System.Array.IndexOf(SceneManager.instance.staticObjects, param1) + 1];
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
        oVar6 = SceneManager.instance.staticObjects[DAT_04];

        do
        {
            //...
            uVar1 = GameManager.instance.FUN_835F4(oVar6);

            if ((uVar1 & 0xff) != 0xff)
            {
                oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[uVar1 & 0xff];
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
            oVar6 = SceneManager.instance.staticObjects[DAT_04 + uVar8];
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

        oVar2 = SceneManager.instance.skinnedObjects[10];
        bVar1 = DAT_02;
        oVar3 = SceneManager.instance.staticObjects[DAT_04];
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

        oVar2 = SceneManager.instance.staticObjects[DAT_04];
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

        oVar2 = SceneManager.instance.staticObjects[DAT_04];
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
        } while (LevelManager.instance.DAT_C2594 <= (ushort)DAT_16);

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
}
