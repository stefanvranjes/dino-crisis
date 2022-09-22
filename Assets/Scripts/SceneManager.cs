using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;
    public static short DAT_994DC = 0x10;
    public static short DAT_994DE = 0x19;
    public static short DAT_994E0 = 0x100;
    public static short DAT_994E2 = 0x180;
    public static short DAT_994E4 = 0;
    public static short DAT_994E6 = 0;
    public static short DAT_994E8 = 0;
    public static short DAT_994EA = 0;

    public ScnScriptableObject scn; //gp+268h
    public DatabaseScriptableObject database;
    public ushort DAT_A4; //gp+a4h
    public byte[] DAT_AC; //gp+ach
    public CriCamera cCamera; //gp+b4h
    public WaypointScriptableObject waypoints; //gp+150h
    public SceneColliderScriptableObject sceneCollision; //gp+154h
    public LightScriptableObject lightSource; //gp+15ch
    public SceneCameraScriptableObject motions; //gp+164h, gp+160h -> motions.Length
    public Trigger[] triggers; //gp+1e8h
    public byte DAT_270; //gp+270h
    public CriSkinned[] DAT_27C; //gp+27ch...gp+1c9ch
    public CriBone[] DAT_1C9C; //gp+1c9ch...gp+5fcch
    public CriParticle[] DAT_5FCC; //gp+5fcch...gp+7cdch
    public CriStatic[] DAT_7CDC; //gp+7cdch...gp+8ffch
    public CriUnknown[] DAT_8FFC; //gp+8ffch...gp+9164h
    public CriTrigger[] DAT_9EEC; //gp+9eech...gp+9fdch
    public Trigger6[] DAT_9FE0; //gp+9fe0...gp+a09ch
    public CriCamera DAT_C3230;
    public short DAT_C3358;
    public ushort DAT_C3360;
    public int DAT_C51B8;
    public int DAT_C51BC;
    public int DAT_C51C0;
    public int DAT_C51C4;
    public int DAT_C51C8;
    public int DAT_C51CC;
    public int DAT_C51D0;
    public int DAT_C51D4;
    public byte DAT_C51D8;
    public CriScene[] DAT_D7C0; //gp+d7c0h...gp+dea0h (0x800C51E0)

    private delegate bool FUN_9E96C(Vector4Int v4, WallCollider c, ref Vector2Int v2);

    private FUN_9E96C[] PTR_FUN_9E96C;

    private byte[] DAT_AA44C = new byte[]
    {
        1, 2, 2, 1, 0, 0, 0, 0, 1, 2, 1, 1, 1, 0, 1, 1, 1, 1, 2, 1, 1, 1, 0, 1, 1, 2, 1, 0
    };
    private byte[] DAT_AA468 = new byte[]
    {
        2, 2, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 2, 1, 1, 2, 1, 1, 1, 0, 1, 1, 2, 1, 0, 1
    };
    private byte[] DAT_AA484 = new byte[]
    {
        4, 1, 3, 3, 3, 3, 4, 0
    };
    private sbyte[] DAT_AA48C = new sbyte[]
    {
        0, -1, 0, -1, 0, -1, -1
    };
    private sbyte[] DAT_AA493 = new sbyte[]
    {
        0, -1, -1, 0, 0, -1, -1
    };
    private sbyte[] DAT_AA49A = new sbyte[]
    {
        0, 1, 0, 0, 0, 0, 1, 0, 0, 0
    };

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        PTR_FUN_9E96C = new FUN_9E96C[7]
        {
            FUN_65138,
            FUN_651D8,
            FUN_6521C,
            FUN_652AC,
            FUN_6533C,
            FUN_653CC,
            FUN_6545C
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.sceneManager = this;
        triggers = new Trigger[32];
        DAT_27C = new CriSkinned[11];
        DAT_1C9C = new CriBone[100];
        DAT_5FCC = new CriParticle[60];
        DAT_7CDC = new CriStatic[40];
        DAT_8FFC = new CriUnknown[10];
        DAT_9EEC = new CriTrigger[10];
        DAT_D7C0 = new CriScene[10];

        FUN_47BE0();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FUN_1A3A0()
    {
        bool bVar1;
        CriParticle oVar2;
        ushort uVar3;
        uint uVar6;
        Trigger6 psVar7;
        Vector3Int local_28;

        uVar6 = 0;

        do
        {
            triggers[uVar6] = null;
        } while (uVar6 < 32);

        uVar6 = 0;

        do
        {
            psVar7 = DAT_9FE0[uVar6];

            if (psVar7.DAT_11 != 0)
            {
                bVar1 = false;

                if (psVar7.DAT_28 == 0x30a)
                    bVar1 = GameManager.instance.DAT_9AA0 == 0x30d;

                if (psVar7.DAT_28 == 0x30d && GameManager.instance.DAT_9AA0 == 0x30a)
                    bVar1 = true;

                uVar3 = psVar7.DAT_28;

                if (uVar3 == 0x503)
                {
                    if (GameManager.instance.DAT_9AA0 == 0x511)
                        bVar1 = true;

                    uVar3 = psVar7.DAT_28;
                }

                if (uVar3 == 0x511 && GameManager.instance.DAT_9AA0 == 0x503)
                    bVar1 = true;

                if (psVar7.DAT_28 == GameManager.instance.DAT_9AA0)
                    bVar1 = true;

                if (bVar1)
                {
                    triggers[uVar6] = psVar7;
                    local_28 = new Vector3Int();
                    local_28.x = psVar7.DAT_00[0].x + 500;
                    local_28.y = psVar7.DAT_12 * -0x1a9;
                    local_28.z = psVar7.DAT_00[0].y - 500;
                    oVar2 = FUN_5FFA0();
                    oVar2.tags = 1;
                    oVar2.DAT_54 = 0x7df4;
                    oVar2.DAT_56 = 0x1e;
                    oVar2.DAT_50.a |= 2;
                    oVar2.screen.x = local_28.x;
                    oVar2.screen.y = local_28.y - 500;
                    oVar2.DAT_60 = 10;
                    oVar2.DAT_62 = 20;
                    oVar2.DAT_2F = 2;
                    oVar2.screen.z = local_28.z;
                    //FUN_606A8
                    psVar7.FUN_1A638(DAT_7CDC[uVar6 + 32], local_28);
                }
            }

            uVar6++;
        } while (uVar6 < 4);
    }

    public void FUN_1A8AC()
    {
        bool bVar3;
        CriPlayer oVar4;
        byte bVar5;
        bool bVar6;
        Trigger tVar6;
        uint uVar7;
        bool bVar8;
        Vector3Int psVar9;
        byte bVar10;
        Vector3Int local_20;

        bVar3 = false;
        oVar4 = (CriPlayer)DAT_27C[10];

        if (!GameManager.instance.DAT_6D && 
            (GameManager.instance.DAT_40 & 0x20) == 0 && 
            oVar4.DAT_11E == 0)
        {
            bVar6 = InventoryManager.FUN_4A87C(2, 0xe);

            if (!bVar6)
            {
                local_20 = new Vector3Int(0, 0, 400);
                Utilities.RotMatrix(ref oVar4.vr, ref oVar4.cTransform.rotation);
                local_20 = Utilities.ApplyMatrixSV(ref oVar4.cTransform.rotation, ref local_20);
                bVar10 = 0;
                local_20.x += oVar4.screen.x;
                local_20.y += oVar4.screen.y;
                local_20.z += oVar4.screen.z;
                uVar7 = 0;

                do
                {
                    tVar6 = triggers[uVar7];

                    if (tVar6 != null && tVar6.DAT_13 &&
                        tVar6.DAT_12 == oVar4.DAT_48)
                    {
                        psVar9 = local_20;

                        if ((tVar6.DAT_11 & 1) == 0)
                            psVar9 = oVar4.screen;

                        bVar8 = GameManager.instance.FUN_768C8(psVar9, tVar6.DAT_00);

                        if (bVar8)
                            bVar3 = true;

                        if (bVar3)
                        {
                            bVar3 = false;

                            if ((tVar6.DAT_11 & 2) == 0)
                            {
                                bVar5 = tVar6.DAT_10;

                                if (bVar5 != 4 || 3 < bVar10)
                                {
                                    if (bVar5 != 2)
                                        oVar4.DAT_34 = oVar4.screen;

                                    bVar8 = DialogManager.instance.PTR_FUN_99028[tVar6.DAT_10](tVar6);

                                    if (!bVar8) break;
                                }
                                else
                                {
                                    bVar8 = InventoryManager.FUN_4A87C(1, 2);

                                    if (!bVar8)
                                    {
                                        bVar5 = tVar6.DAT_10;

                                        if (bVar5 != 2)
                                            oVar4.DAT_34 = oVar4.screen;

                                        bVar8 = DialogManager.instance.PTR_FUN_99028[tVar6.DAT_10](tVar6);

                                        if (!bVar8) break;
                                    }
                                }
                            }
                            else
                            {
                                bVar8 = InventoryManager.FUN_4A87C(2, 8);

                                if (bVar8)
                                {
                                    InventoryManager.FUN_4A7E8(2, 8, false);
                                    bVar5 = tVar6.DAT_10;

                                    if (bVar5 != 2)
                                        oVar4.DAT_34 = oVar4.screen;

                                    bVar8 = DialogManager.instance.PTR_FUN_99028[tVar6.DAT_10](tVar6);

                                    if (!bVar8) break;
                                }
                            }
                        }
                    }

                    bVar10++;
                    uVar7 = bVar10;
                } while (bVar10 < 0x20);

                InventoryManager.FUN_4A7E8(2, 8, false);
                InventoryManager.FUN_4A7E8(2, 0x10, false);
            }
            else
                DialogManager.instance.PTR_FUN_99058
                    [DialogManager.instance.DAT_B138C](DialogManager.instance.DAT_B1388);
        }
    }

    public void FUN_1AFC4(Trigger2 param1)
    {
        short sVar1;
        uint uVar2;
        ushort uVar3;
        uint uVar5;

        uVar2 = 0x113;

        if (param1.DAT_18 == 0x309 && 
            GameManager.instance.DAT_9AA0 == 0x113)
        {
            uVar5 = uVar2;
        }
        else
        {
            uVar3 = param1.DAT_18;

            if (uVar3 == 0x604)
            {
                uVar2 = 0x113;

                if (GameManager.instance.DAT_9AA0 == 0x113)
                {
                    uVar5 = uVar2;
                    goto LAB_1B0D8;
                }
                else if (GameManager.instance.DAT_9AA0 == 0x309)
                {
                    uVar2 = 0x309;
                    uVar5 = uVar2;
                    goto LAB_1B0D8;
                }

                uVar3 = param1.DAT_18;
            }

            if (uVar3 == 0x309)
            {
                uVar2 = 0x50b;

                if (GameManager.instance.DAT_9AA0 == 0x50b)
                {
                    uVar5 = uVar2;
                    goto LAB_1B0D8;
                }
            }

            uVar3 = param1.DAT_18;

            if (uVar3 == 0x604)
            {
                uVar2 = 0x50b;

                if (GameManager.instance.DAT_9AA0 == 0x50b)
                {
                    uVar5 = uVar2;
                    goto LAB_1B0D8;
                }

                uVar3 = param1.DAT_18;
            }

            uVar5 = 0;

            if (uVar3 == 0x309)
            {
                uVar2 = 0x604;

                if (GameManager.instance.DAT_9AA0 == 0x604)
                {
                    uVar5 = uVar2;
                    goto LAB_1B0D8;
                }
            }
        }

        LAB_1B0D8:
        FUN_597FC();
        GameManager.instance.FUN_61374();

        if (uVar5 == 0x309)
        {
            GameManager.instance.DAT_98B4 = 0x5cb;
            GameManager.instance.DAT_98B8 = -0x8ac;
            sVar1 = 0x8da;
        }
        else
        {
            if (uVar5 < 0x30a)
            {
                if (uVar5 != 0x113) goto LAB_1B1D4;

                GameManager.instance.DAT_98B4 = 0xdaa;
                GameManager.instance.DAT_98B8 = -0xa27;
                sVar1 = 0x7d0;
            }
            else
            {
                if (uVar5 == 0x50b)
                {
                    GameManager.instance.DAT_98B4 = -0xfd7;
                    GameManager.instance.DAT_98B8 = -0x13ab;
                    sVar1 = 0x7fc;
                }
                else
                {
                    if (uVar5 != 0x604) goto LAB_1B1D4;

                    GameManager.instance.DAT_98B4 = -0xf75;
                    GameManager.instance.DAT_98B8 = 0xd55;
                    sVar1 = 0x891;
                }
            }
        }

        GameManager.instance.DAT_98BA = sVar1;
        LAB_1B1D4:
        GameManager.instance.DAT_9ADC = GameManager.instance.DAT_9AA0;
        GameManager.instance.DAT_9AA0 = param1.DAT_18;
        GameManager.instance.DAT_47 = param1.DAT_22;
        GameManager.instance.playerSpawnPos = param1.DAT_1A;
        GameManager.instance.playerSpawnRotY = param1.DAT_20;

        if (GameManager.instance.DAT_56 == 0)
        {
            sVar1 = 6;

            if (param1.DAT_25)
                sVar1 = 7;

            GameManager.instance.DAT_28 = sVar1;
        }
        else
        {
            GameManager.instance.DAT_56 = 0;
            GameManager.instance.DAT_28 = 6;
        }

        uVar2 = 0;
        GameManager.instance.DAT_2A = 0;
        GameManager.instance.DAT_2C = 0;
        GameManager.instance.DAT_2E = 0;

        do
        {
            triggers[uVar2] = null;
            uVar2++;
        } while (uVar2 < 32);
    }

    public LightSource FUN_55790(int param1)
    {
        return lightSource.DAT_24[param1];
    }

    public void FUN_55700()
    {
        bool bVar1;
        CriScene oVar2;

        oVar2 = DAT_D7C0[9];
        do
        {
            bVar1 = oVar2.PTR_FUN_9E540[oVar2.PTR_58[0].CONTAINERS[oVar2.DAT_58[0]].DAT_00]();
        } while (!bVar1);
    }

    public void FUN_55580(sbyte param1, int param2)
    {
        int iVar1;
        _SCENE_OBJ_DATA oVar3;

        iVar1 = param1;
        DAT_D7C0[iVar1].DAT_05 = 1;
        oVar3 = scn.GetData((param2 << 16) >> 14);
        DAT_D7C0[iVar1].DAT_AC = 1;
        DAT_D7C0[iVar1].PTR_58[0] = oVar3;
        DAT_D7C0[iVar1].DAT_58[0] = 0;
    }

    private void FUN_55548()
    {
        for (int i = 0; i < DAT_D7C0.Length; i++)
            DAT_D7C0[i].ResetValues();

        FUN_55580(0, 0);
    }

    private void FUN_553EC()
    {
        DAT_A4 = GameManager.instance.DAT_9E0A0
            [(byte)(GameManager.instance.DAT_9AA0 >> 8)].scenes
            [(byte)GameManager.instance.DAT_9AA0].DAT_08;
    }

    public void FUN_555E8()
    {
        byte bVar1;
        ushort uVar2;
        bool bVar3;
        CriScene psVar5;
        uint uVar6;

        if ((GameManager.instance.DAT_40 & 0x80) == 0)
        {
            DAT_C51D0 = Utilities.Rand();
            uVar6 = 0;
            do
            {
                psVar5 = DAT_D7C0[uVar6];
                bVar1 = psVar5.DAT_05;

                if (bVar1 == 2)
                {
                    uVar2 = psVar5.DAT_00;
                    psVar5.DAT_00 = (ushort)(uVar2 - 1);

                    if (uVar2 == 1)
                    {
                        psVar5.DAT_05 = 1;

                        do
                        {
                            //...
                            bVar3 = true; //tmp
                        } while (!bVar3);
                    }
                }
                else
                {
                    if (bVar1 < 3 && bVar1 == 1)
                    {
                        do
                        {
                            //...
                            bVar3 = true; //tmp
                        } while (!bVar3);
                    }
                }

                uVar6++;
            } while (uVar6 < 10);

            InventoryManager.FUN_4A7E8(2, 0x15, false);
        }
    }

    public uint FUN_566B0()
    {
        uint uVar1;
        CriScene mVar2;

        uVar1 = 1;
        do
        {
            mVar2 = DAT_D7C0[uVar1];

            if (mVar2.DAT_05 == 0)
                return uVar1;

            uVar1++;
        } while (uVar1 < 10);

        return 8;
    }

    public CriTrigger FUN_596E8(uint param1)
    {
        bool bVar1;
        int iVar1;
        int iVar2;
        uint uVar3;
        CriTrigger oVar4;
        uint uVar5;
        uint uVar6;
        CriTrigger oVar7;

        uVar6 = 0xffffffff;
        oVar7 = null;
        uVar5 = 0;

        do
        {
            oVar4 = DAT_9EEC[uVar5];

            if (oVar4.DAT_01 == param1)
            {
                bVar1 = InventoryManager.FUN_4A87C(4, oVar4.DAT_02);

                if (!bVar1 && (oVar4.DAT_03 & 1) == 0)
                {
                    iVar1 = oVar4.DAT_04.x - GameManager.instance.DAT_9FDC.x;

                    if (iVar1 < 0)
                        iVar1 = -iVar1;

                    iVar2 = oVar4.DAT_04.z - GameManager.instance.DAT_9FDC.y;

                    if (iVar2 < 0)
                        iVar2 = -iVar2;

                    uVar3 = (uint)(iVar1 * iVar1 + iVar2 * iVar2);

                    if (uVar3 < uVar6)
                    {
                        uVar6 = uVar3;
                        oVar7 = oVar4;
                    }
                }
            }

            uVar5++;
        } while (uVar5 < 10);

        return oVar7;
    }

    private void FUN_597FC()
    {
        int iVar1;
        uint uVar2;
        int iVar3;
        CriTrigger oVar4;
        CriSkinned psVar5;
        uint uVar6;

        uVar6 = 0;

        if (uVar6 < 10)
        {
            do
            {
                psVar5 = DAT_27C[uVar6];

                if ((psVar5.flags & 1) != 0 && -1 < psVar5.DAT_198)
                {
                    oVar4 = DAT_9EEC[psVar5.DAT_198];
                    oVar4.DAT_01 = (byte)GameManager.instance.DAT_9AA0;
                    oVar4.DAT_04 = psVar5.screen;
                    oVar4.DAT_0A = psVar5.health;
                    oVar4.DAT_0C = (short)psVar5.vr.y;
                    oVar4.DAT_0E = psVar5.DAT_194;
                    oVar4.DAT_10 = psVar5.DAT_196;
                    oVar4.DAT_12 = psVar5.DAT_19A;
                    oVar4.DAT_14 = psVar5.DAT_1A6;
                    iVar3 = DAT_27C[10].screen.x - psVar5.screen.x;

                    if (iVar3 < 0)
                        iVar3 = psVar5.screen.x - DAT_27C[10].screen.x;

                    iVar1 = DAT_27C[10].screen.z - psVar5.screen.z;

                    if (iVar1 < 0)
                        iVar1 = psVar5.screen.z - DAT_27C[10].screen.z;

                    uVar2 = (uint)Utilities.SquareRoot0(iVar3 * iVar3 + iVar1 * iVar1);

                    if (0x7ffe < uVar2)
                        uVar2 = 0x7ffe;

                    oVar4.DAT_16 = (ushort)uVar2;
                }

                uVar6++;
            } while (uVar6 < 10);
        }
    }

    public int FUN_59C74(uint param1)
    {
        bool bVar1;
        CriTrigger puVar2;
        uint uVar3;
        int iVar4;

        iVar4 = 0;
        uVar3 = 0;
        
        if (uVar3 < DAT_9EEC.Length)
        {
            do
            {
                puVar2 = DAT_9EEC[uVar3];

                if (puVar2.DAT_01 == param1)
                {
                    bVar1 = InventoryManager.FUN_4A87C(4, puVar2.DAT_02);

                    if (!bVar1)
                        iVar4++;
                }

                uVar3++;
            } while (uVar3 < DAT_9EEC.Length);
        }

        return iVar4;
    }

    public CriStatic FUN_5FE78()
    {
        int iVar1;
        CriStatic puVar2;
        int iVar3;

        iVar1 = 35;
        iVar3 = 31;

        do
        {
            puVar2 = DAT_7CDC[iVar3];
            iVar1--;

            if ((puVar2.flags & 1) == 0)
            {
                puVar2.ResetValues();
                puVar2.flags = 1;
                return puVar2;
            }

            iVar3--;
        } while (iVar1 != -1);

        return null;
    }

    public CriUnknown FUN_5FF08()
    {
        int iVar1;
        CriUnknown pbVar2;
        int iVar3;

        iVar3 = 10;
        iVar1 = ~GameManager.instance.DAT_9235 + 10;

        while (true)
        {
            if (iVar1 == -1)
                return null;

            iVar1--;
            pbVar2 = DAT_8FFC[iVar3];

            if ((pbVar2.DAT_00 & 1) == 0) break;

            iVar3--;
        }

        pbVar2.ResetValues();
        pbVar2.DAT_00 = 1;
        return pbVar2;
    }

    public CriParticle FUN_5FFA0()
    {
        int iVar1;
        CriParticle puVar2;
        int iVar3;

        iVar1 = ~GameManager.instance.DAT_9234 + 0x3c;
        iVar3 = DAT_5FCC.Length - 1;

        if (iVar1 != -1)
        {
            do
            {
                puVar2 = DAT_5FCC[iVar3];
                iVar1--;

                if ((puVar2.flags & 1) == 0)
                {
                    puVar2.ResetValues();
                    puVar2.flags = 1;
                    puVar2.DAT_50 = new Color32(0x80, 0x80, 0x80, 0x2c);
                    return puVar2;
                }

                iVar3--;
            } while (iVar1 != -1);
        }

        return null;
    }

    public void FUN_2E22C(CriPlayer param1)
    {
        CriPlayer oVar1;

        oVar1 = FUN_65B30(param1) as CriPlayer;

        if (oVar1 == null || (oVar1.DAT_208 & 0x2000000) == 0)
            param1.DAT_1C5 = 1;
        else
        {
            oVar1.DAT_1C5 = 1;
            param1.DAT_1C5 = 0;
        }
    }

    public void FUN_2E7D0(CriSkinned param1)
    {
        ushort uVar1;
        short sVar2;
        int iVar3;
        CriParticle oVar3;
        CriObject oVar4;
        uint uVar5;
        int iVar6;
        byte[] puVar7;

        sVar2 = param1.FUN_64804(DAT_27C[10].screen);

        if ((ushort)(sVar2 - 0x200) < 0xa00U)
        {
            if ((ushort)(sVar2 - 0x200) < 0x400U)
            {
                iVar3 = (int)GameManager.FUN_64650();
                uVar5 = (uint)(iVar3 % 5);
                puVar7 = Utilities.DAT_9B144;
            }
            else
            {
                if ((ushort)(sVar2 - 0x600) < 0x400)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    uVar5 = (uint)(iVar3 % 3);
                    puVar7 = Utilities.DAT_9B154;
                }
                else
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    uVar5 = (uint)(iVar3 % 5);
                    puVar7 = Utilities.DAT_9B14C;
                }
            }

            uVar5 = puVar7[uVar5 & 0xff];
        }
        else
        {
            iVar3 = (int)GameManager.FUN_64650();
            uVar5 = (uint)(iVar3 % 5 & 0xff);
        }

        iVar6 = (int)uVar5;
        oVar3 = FUN_5FFA0();

        if (oVar3 != null)
        {
            oVar3.tags = Utilities.DAT_9B084[iVar6].DAT_01;
            oVar3.DAT_2F = Utilities.DAT_9B084[iVar6].DAT_02;
            oVar4 = Utilities.FUN_601C8(param1.skeleton, Utilities.DAT_9B084[iVar6].DAT_03);
            oVar3.DAT_4C = oVar4;
            oVar3.screen = Utilities.DAT_9B084[iVar6].DAT_04;
            uVar1 = Utilities.DAT_9B084[iVar6].DAT_0A;
            oVar3.DAT_60 = uVar1;
            oVar3.DAT_62 = uVar1;
            oVar3.DAT_6C = (byte)Utilities.DAT_9B084[iVar6].DAT_0C; //0x6c should be int?
        }
    }

    public void FUN_2EBF8(CriSkinned param1)
    {
        CriParticle oVar2;

        oVar2 = FUN_5FFA0();

        if (oVar2 != null)
        {
            oVar2.tags = 0;
            oVar2.DAT_3C = 3;
            oVar2.DAT_2F = 0;
            oVar2.screen = param1.screen;
            oVar2.DAT_68 = 120;
            oVar2.DAT_62 = 0;
            oVar2.DAT_60 = 0;
            oVar2.DAT_69 = 76;
        }
    }

    private void FUN_290E0()
    {
        ushort uVar1;
        bool bVar2;
        ushort uVar3;
        short sVar4;
        short sVar5;
        short sVar6;
        short sVar7;

        bVar2 = InventoryManager.FUN_4A87C(0, 0xdf);

        if (bVar2)
        {
            uVar1 = GameManager.instance.DAT_9AA0;

            if (uVar1 == 0x508)
            {
                sVar7 = 0x574;
                uVar3 = 0x8f;
                sVar4 = 5;
                sVar5 = 5;
                sVar6 = 0x2c1;
            }
            else
            {
                if (uVar1 == 0x509)
                {
                    sVar7 = 0x574;
                    uVar3 = 0x8f;
                    sVar4 = 0xf;
                    sVar5 = 0xf;
                    sVar6 = 0x2c1;
                }
                else
                {
                    if (uVar1 == 0x50a)
                    {
                        sVar7 = 0x574;
                        uVar3 = 0x8f;
                        sVar4 = 0xf;
                        sVar5 = 0xf;
                        sVar6 = 0x57d;
                    }
                    else
                    {
                        if (uVar1 == 0x50b)
                        {
                            sVar7 = 0x574;
                            uVar3 = 0x8f;
                            sVar4 = 5;
                            sVar5 = 5;
                            sVar6 = 0x2c1;
                        }
                        else
                        {
                            if (uVar1 == 0x50c)
                            {
                                sVar7 = 0x574;
                                uVar3 = 0x8f;
                                sVar4 = 5;
                                sVar5 = 5;
                                sVar6 = 0x2c1;
                            }
                            else
                            {
                                if (uVar1 == 0x50d)
                                {
                                    sVar7 = 0x574;
                                    uVar3 = 0x8f;
                                    sVar4 = 5;
                                    sVar5 = 5;
                                    sVar6 = 0x3ed;
                                }
                                else
                                {
                                    if (uVar1 == 0x50e)
                                    {
                                        sVar7 = 0x574;
                                        uVar3 = 0x8f;
                                        sVar4 = 5;
                                        sVar5 = 5;
                                        sVar6 = 0x3ed;
                                    }
                                    else
                                    {
                                        if (uVar1 == 0x50f)
                                        {
                                            sVar7 = 0x574;
                                            uVar3 = 0x8f;
                                            sVar4 = 5;
                                            sVar5 = 5;
                                            sVar6 = 0x2c1;
                                        }
                                        else
                                        {
                                            uVar3 = 0;

                                            if (uVar1 == 0x510)
                                            {
                                                sVar7 = 0x574;
                                                uVar3 = 0x8f;
                                                sVar4 = 5;
                                                sVar5 = 5;
                                                sVar6 = 0x3ed;
                                            }
                                            else
                                            {
                                                sVar7 = 0;
                                                sVar4 = 0;
                                                sVar5 = 0;
                                                sVar6 = 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            FUN_29280(uVar3, sVar4, sVar5, sVar6, sVar7);
        }
    }

    private void FUN_29280(ushort param1, short param2, short param3, short param4, short param5)
    {
        bool bVar1;

        if ((param1 & 1) != 0)
            DAT_994DC = param2;

        if ((param1 & 2) != 0)
            DAT_994DE = param3;

        if ((param1 & 4) != 0)
            DAT_994E0 = param4;

        if ((param1 & 8) != 0)
            DAT_994E2 = param5;

        if ((param1 & 0x10) != 0)
            DAT_994E4 = 0;

        if ((param1 & 0x20) != 0)
            DAT_994E6 = 0;

        bVar1 = (param1 & 0x80) == 0;

        if (bVar1)
            InventoryManager.FUN_4A7E8(0, 0xe4, false);
        else
            InventoryManager.FUN_4A7E8(0, 0xe4, true);

        InventoryManager.FUN_4A7E8(2, 0x1f, !bVar1);
        DAT_994EA = 0;
    }

    public void FUN_27A1C(Vector3Int param1, Vector3Int param2)
    {
        CriPlayer oVar1;
        CriCamera oVar2;
        uint uVar3;

        oVar1 = (CriPlayer)DAT_27C[10];
        oVar2 = cCamera;

        if (cCamera.DAT_5B == 0)
        {
            cCamera.DAT_6B = false;
            oVar2.DAT_5B++;
        }
        else
        {
            if (cCamera.DAT_5B == 1 && cCamera.DAT_8B != 2
                && cCamera.DAT_8A != 2 && cCamera.DAT_90 == 0 && cCamera.DAT_92 == 0)
            {
                if ((oVar1.DAT_1C0 & 1) == 0)
                {
                    if (!cCamera.DAT_6B) goto LAB_27B30;

                    cCamera.DAT_92 = 30;
                }
                else
                {
                    if (!cCamera.DAT_6B)
                        cCamera.DAT_6B = true;

                    uVar3 = Utilities.FUN_2630C(param1, oVar2.DAT_7C);

                    if (100 < uVar3)
                    {
                        oVar2.DAT_92 = 30;
                        oVar2.DAT_90 = 30;
                        oVar2.DAT_6B = false;
                    }

                    uVar3 = Utilities.FUN_2630C(param2, oVar2.DAT_84);

                    if (uVar3 < 101) goto LAB_27B30;

                    oVar2.DAT_92 = 30;
                }

                oVar2.DAT_90 = 30;
                oVar2.DAT_6B = false;
            }
        }

        LAB_27B30:
        oVar2.DAT_40 = param1;
        oVar2.DAT_48 = param2;

        if (!oVar2.DAT_6B)
        {
            oVar2.DAT_7C = oVar2.DAT_40;
            oVar2.DAT_84 = oVar2.DAT_48;
        }
    }

    public void FUN_26EBC(byte param1, byte param2)
    {
        byte bVar1;
        CameraMotion oVar5;
        CriCamera oVar6;

        oVar6 = cCamera;
        bVar1 = cCamera.DAT_72;
        cCamera.DAT_70 = param1;
        cCamera.DAT_71 = param2;
        cCamera.DAT_56 = 0;
        cCamera.DAT_52 = 0;
        cCamera.DAT_2E = 0;
        cCamera.DAT_3E = 0;
        cCamera.DAT_58 = 0;
        cCamera.DAT_73 = 0;
        cCamera.DAT_68 = 0;
        cCamera.DAT_8A = 0;
        cCamera.DAT_8B = 0;
        cCamera.DAT_92 = 0;
        cCamera.DAT_90 = 0;
        cCamera.DAT_72 = (byte)(bVar1 & 0xfe);

        if (param1 == 0)
        {
            cCamera.motion = motions.MOTIONS[cCamera.DAT_6A];
            oVar6.FUN_26B18(motions.MOTIONS);

            if (param2 == 0)
            {
                cCamera.DAT_8A = 0;
                cCamera.DAT_8B = 0;
            }
            else
            {
                cCamera.DAT_8A = 2;
                cCamera.DAT_8B = 2;
            }

            oVar5 = motions.MOTIONS[cCamera.DAT_6A];
            cCamera.motion = oVar5;
            cCamera.DAT_68 = oVar5.DAT_02;
            cCamera.DAT_73 = 0;
            cCamera.DAT_72 &= 0xfe;
            cCamera.DAT_69 = oVar5.DAT_00;
            FUN_55580(9, oVar5.DAT_02);
            FUN_55700();
        }
        else
            cCamera.motion = CriCamera.DAT_99498;

        InventoryManager.FUN_4A7E8(2, 0x14, false);
    }

    public void FUN_26E6C()
    {
        DAT_C3230.cTransform.rotation = cCamera.cTransform.rotation;
        DAT_C3230.cTransform.position = cCamera.cTransform.position;
        DAT_C3230.screen = cCamera.screen;
        DAT_C3230.DAT_26 = cCamera.DAT_26;
        DAT_C3230.vr = cCamera.vr;
        DAT_C3230.DAT_2E = cCamera.DAT_2E;
        DAT_C3230.DAT_30 = cCamera.DAT_30;
        DAT_C3230.DAT_36 = cCamera.DAT_36;
        DAT_C3230.DAT_38 = cCamera.DAT_38;
        DAT_C3230.DAT_38 = cCamera.DAT_38;
        DAT_C3230.DAT_3A = cCamera.DAT_3A;
        DAT_C3230.DAT_3C = cCamera.DAT_3C;
        DAT_C3230.DAT_3E = cCamera.DAT_3E;
        DAT_C3230.DAT_40 = cCamera.DAT_40;
        DAT_C3230.DAT_46 = cCamera.DAT_46;
        DAT_C3230.DAT_48 = cCamera.DAT_48;
        DAT_C3230.DAT_50 = cCamera.DAT_50;
        DAT_C3230.DAT_52 = cCamera.DAT_52;
        DAT_C3230.DAT_54 = cCamera.DAT_54;
        DAT_C3230.DAT_56 = cCamera.DAT_56;
        DAT_C3230.DAT_58 = cCamera.DAT_58;
        DAT_C3230.DAT_59 = cCamera.DAT_59;
        DAT_C3230.DAT_5A = cCamera.DAT_5A;
        DAT_C3230.DAT_5B = cCamera.DAT_5B;
        DAT_C3230.DAT_64 = cCamera.DAT_64;
        DAT_C3230.DAT_68 = cCamera.DAT_68;
        DAT_C3230.DAT_69 = cCamera.DAT_69;
        DAT_C3230.DAT_6A = cCamera.DAT_6A;
        DAT_C3230.DAT_6B = cCamera.DAT_6B;
        DAT_C3230.DAT_70 = cCamera.DAT_70;
        DAT_C3230.DAT_71 = cCamera.DAT_71;
        DAT_C3230.DAT_72 = cCamera.DAT_72;
        DAT_C3230.DAT_73 = cCamera.DAT_73;
        DAT_C3230.DAT_74 = cCamera.DAT_74;
        DAT_C3230.DAT_76 = cCamera.DAT_76;
        DAT_C3230.DAT_78 = cCamera.DAT_78;
        DAT_C3230.DAT_7C = cCamera.DAT_7C;
        DAT_C3230.DAT_82 = cCamera.DAT_82;
        DAT_C3230.DAT_83 = cCamera.DAT_83;
        DAT_C3230.DAT_84 = cCamera.DAT_84;
        DAT_C3230.DAT_8A = cCamera.DAT_8A;
        DAT_C3230.DAT_8B = cCamera.DAT_8B;
        DAT_C3230.DAT_90 = cCamera.DAT_90;
        DAT_C3230.DAT_92 = cCamera.DAT_92;
    }

    public void FUN_26E1C()
    {
        cCamera.cTransform.rotation = DAT_C3230.cTransform.rotation;
        cCamera.cTransform.position = DAT_C3230.cTransform.position;
        cCamera.screen = DAT_C3230.screen;
        cCamera.DAT_26 = DAT_C3230.DAT_26;
        cCamera.vr = DAT_C3230.vr;
        cCamera.DAT_2E = DAT_C3230.DAT_2E;
        cCamera.DAT_30 = DAT_C3230.DAT_30;
        cCamera.DAT_36 = DAT_C3230.DAT_36;
        cCamera.DAT_38 = DAT_C3230.DAT_38;
        cCamera.DAT_38 = DAT_C3230.DAT_38;
        cCamera.DAT_3A = DAT_C3230.DAT_3A;
        cCamera.DAT_3C = DAT_C3230.DAT_3C;
        cCamera.DAT_3E = DAT_C3230.DAT_3E;
        cCamera.DAT_40 = DAT_C3230.DAT_40;
        cCamera.DAT_46 = DAT_C3230.DAT_46;
        cCamera.DAT_48 = DAT_C3230.DAT_48;
        cCamera.DAT_50 = DAT_C3230.DAT_50;
        cCamera.DAT_52 = DAT_C3230.DAT_52;
        cCamera.DAT_54 = DAT_C3230.DAT_54;
        cCamera.DAT_56 = DAT_C3230.DAT_56;
        cCamera.DAT_58 = DAT_C3230.DAT_58;
        cCamera.DAT_59 = DAT_C3230.DAT_59;
        cCamera.DAT_5A = DAT_C3230.DAT_5A;
        cCamera.DAT_5B = DAT_C3230.DAT_5B;
        cCamera.DAT_64 = DAT_C3230.DAT_64;
        cCamera.DAT_68 = DAT_C3230.DAT_68;
        cCamera.DAT_69 = DAT_C3230.DAT_69;
        cCamera.DAT_6A = DAT_C3230.DAT_6A;
        cCamera.DAT_6B = DAT_C3230.DAT_6B;
        cCamera.DAT_70 = DAT_C3230.DAT_70;
        cCamera.DAT_71 = DAT_C3230.DAT_71;
        cCamera.DAT_72 = DAT_C3230.DAT_72;
        cCamera.DAT_73 = DAT_C3230.DAT_73;
        cCamera.DAT_74 = DAT_C3230.DAT_74;
        cCamera.DAT_76 = DAT_C3230.DAT_76;
        cCamera.DAT_78 = DAT_C3230.DAT_78;
        cCamera.DAT_7C = DAT_C3230.DAT_7C;
        cCamera.DAT_82 = DAT_C3230.DAT_82;
        cCamera.DAT_83 = DAT_C3230.DAT_83;
        cCamera.DAT_84 = DAT_C3230.DAT_84;
        cCamera.DAT_8A = DAT_C3230.DAT_8A;
        cCamera.DAT_8B = DAT_C3230.DAT_8B;
        cCamera.DAT_90 = DAT_C3230.DAT_90;
        cCamera.DAT_92 = DAT_C3230.DAT_92;
    }

    public void FUN_264C4(short param1, short param2, short param3, short param4)
    {
        cCamera.DAT_40 = new Vector3Int(param2, param3, param4);

        if (param1 == 0)
        {
            cCamera.DAT_30 = new Vector3Int(param2, param3, param4);
            cCamera.DAT_7C = new Vector3Int(param2, param3, param4);
        }
    }

    public void FUN_26504(short param1, short param2, short param3, short param4)
    {
        cCamera.DAT_48 = new Vector3Int(param2, param3, param4);

        if (param1 == 0)
        {
            cCamera.screen = new Vector3Int(param2, param3, param4);
            cCamera.DAT_84 = new Vector3Int(param2, param3, param4);
        }
    }

    public void FUN_269C8(Vector3Int param1, Vector3Int param2)
    {
        CriCamera oVar1;
        short sVar2;
        ushort uVar3;

        oVar1 = cCamera;
        sVar2 = (short)(cCamera.DAT_26 + cCamera.DAT_2E);
        cCamera.DAT_26 = sVar2;

        if (10000 < sVar2)
            oVar1.DAT_26 = 10000;

        if (oVar1.DAT_26 < 10)
            oVar1.DAT_26 = 10;

        FUN_2669C(ref oVar1.screen, param2, oVar1.DAT_26, ref oVar1.DAT_54,
                  oVar1.DAT_56, ref oVar1.DAT_8A, ref oVar1.DAT_90);
        sVar2 = (short)(oVar1.DAT_36 + oVar1.DAT_3E);
        oVar1.DAT_36 = sVar2;

        if (10000 < sVar2)
            oVar1.DAT_36 = 10000;

        if (oVar1.DAT_36 < 10)
            oVar1.DAT_36 = 10;

        FUN_2669C(ref oVar1.DAT_30, param1, oVar1.DAT_36, ref oVar1.DAT_50,
                  oVar1.DAT_52, ref oVar1.DAT_8B, ref oVar1.DAT_92);
        uVar3 = (ushort)Utilities.FUN_2630C(oVar1.DAT_30, oVar1.screen);
        oVar1.DAT_3C = uVar3;
        oVar1.vr = Utilities.FUN_263CC(oVar1.DAT_30, oVar1.screen);
    }

    private void FUN_2669C(ref Vector3Int param1, Vector3Int param2, short param3, 
        ref short param4, short param5, ref byte param6, ref short param7)
    {
        byte bVar1;
        short sVar2;
        uint uVar3;
        uint uVar4;
        Matrix3x3 MStack80;
        Vector3Int local_30;

        uVar3 = Utilities.FUN_2630C(param1, param2);

        if (param7 != 0)
        {
            sVar2 = (short)(param7 - 1);

            if (uVar3 == 0)
            {
                param7 = 0;
                param1 = param2;
                return;
            }

            param7 = sVar2;

            if (sVar2 < 1)
            {
                param1 = param2;
                return;
            }

            local_30 = Utilities.FUN_263CC(param2, param1);
            MStack80 = new Matrix3x3();
            Utilities.RotMatrixYXZ(ref local_30, ref MStack80);
            local_30.z = (short)(uVar3 >> 1) + (short)((uVar3 >> 1) / 30) * (30 - sVar2);
            goto LAB_26954;
        }

        bVar1 = param6;

        if (bVar1 == 1)
        {
            param3 = 80;
            uVar4 = (uint)(int)param3;
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    param1 = param2;
                    return;
                }

                uVar4 = (uint)(int)param3;
            }
            else
            {
                if (bVar1 == 2)
                {
                    uVar4 = (uint)(int)param3;
                    goto LAB_2687C;
                }

                if (bVar1 == 3)
                {
                    local_30 = Utilities.FUN_263CC(param2, param1);
                    MStack80 = new Matrix3x3();
                    Utilities.RotMatrixYXZ(ref local_30, ref MStack80);
                    local_30.z = (short)(uVar3 >> 2);
                    goto LAB_26954;
                }

                uVar4 = (uint)(int)param3;
            }
        }

        LAB_2687C:
        if (uVar3 < uVar4)
        {
            param1 = param2;
            param6 = 0;
            return;
        }

        local_30 = Utilities.FUN_263CC(param2, param1);

        if (param5 != 0)
        {
            local_30.y = Utilities.FUN_265E8(param1, param2, param4, (ushort)param5);
            local_30.y = param4 + local_30.y;
            param4 = (short)local_30.y;
        }

        MStack80 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref local_30, ref MStack80);

        if (param6 == 1)
        {
            if (uVar4 == 0)
                return; //trap(0x1c00)

            local_30.z = param3 + (short)(uVar3 / uVar4);
        }
        else
        {
            if (param6 == 2)
                local_30.z = param3;
        }

        LAB_26954:
        local_30.y = 0;
        local_30.x = 0;
        local_30 = Utilities.ApplyMatrixSV(ref MStack80, ref local_30);
        param1.x += local_30.x;
        param1.y += local_30.y;
        param1.z += local_30.z;
    }

    private void FUN_261E0()
    {
        byte bVar1;
        CameraMotion mVar3;

        //irelevant stuff...
        cCamera.DAT_58 = 0;
        cCamera.DAT_68 = 0;
        cCamera.DAT_83 = 0;
        cCamera.DAT_8A = 0;
        cCamera.DAT_8B = 0;
        cCamera.DAT_70 = 0;
        cCamera.FUN_26B18(motions.MOTIONS);
        cCamera.DAT_73 = 0;
        cCamera.DAT_72 &= 0xfe;
        mVar3 = motions.MOTIONS[cCamera.DAT_6A];
        cCamera.motion = mVar3;
        bVar1 = cCamera.motion.DAT_00;
        cCamera.DAT_38 = 0;
        cCamera.DAT_3A = 0;
        cCamera.DAT_69 = bVar1;
        FUN_55580(9, cCamera.DAT_68);
        InventoryManager.FUN_4A7E8(2, 20, false);
    }

    public void FUN_23068(byte param1, byte param2)
    {
        CriUnknown pcVar1;
        CriUnknown pbVar2;
        int pbVar3;
        int iVar4;
        CriSkinned oVar4;

        iVar4 = 9;
        pbVar3 = 0;

        do
        {
            pcVar1 = DAT_8FFC[pbVar3];
            pbVar2 = pcVar1;

            if ((pcVar1.DAT_00 & 1) != 0 && pcVar1.DAT_01 == 12 &&
                pcVar1.DAT_18 == param1 && pcVar1.DAT_19 == param2)
                break;

            iVar4--;
            pbVar3++;
        } while (iVar4 != -1);

        oVar4 = pbVar2.DAT_20;
        oVar4.DAT_19A &= (ushort)~(1 << (pbVar2.DAT_19 + pbVar2.DAT_18 * 4 & 0x1f));
        oVar4.DAT_199--;
        pcVar1.DAT_03 = 2;
    }

    public void FUN_22F9C()
    {
        CriUnknown pbVar1;
        int pbVar2;
        int iVar3;
        short sVar4;
        CriUnknown pbVar5;

        iVar3 = 9;
        pbVar2 = 0;
        pbVar1 = DAT_8FFC[pbVar2];
        pbVar5 = pbVar1;

        do
        {
            sVar4 = pbVar1.DAT_08;

            if ((pbVar1.DAT_00 & 1) != 0 && pbVar1.DAT_01 == 12 && pbVar1.DAT_03 < 2)
            {
                if (pbVar1.DAT_08 < sVar4)
                {
                    pbVar5 = pbVar1;
                    sVar4 = pbVar1.DAT_08;
                }
            }

            pbVar2++;
            iVar3--;
            pbVar1 = DAT_8FFC[pbVar2];
        } while (iVar3 != -1);

        pbVar5.DAT_20.DAT_19A &= (ushort)~(1 << (pbVar5.DAT_19 + pbVar5.DAT_18 * 4 & 0x1f));
        pbVar5.DAT_03 = 2;
    }

    public byte FUN_47864()
    {
        byte bVar1;
        uint uVar2;
        int puVar3;
        int iVar4;

        bVar1 = (byte)GameManager.FUN_64650();
        puVar3 = 0;

        if (GameManager.instance.DAT_9AAA < 4U)
        {
            iVar4 = 2;

            if (2U < GameManager.instance.DAT_9AAA)
                iVar4 = 1;
        }
        else
            iVar4 = 0;

        uVar2 = 0;

        while(DAT_AC[puVar3 + iVar4 + 1] == 0 || DAT_AC[puVar3 + iVar4 + 1] < (bVar1 & 0x1fU))
        {
            uVar2++;
            puVar3 += 4;

            if (11 < uVar2)
                return 0;
        }

        return DAT_AC[puVar3];
    }

    public void FUN_47BE0()
    {
        CriPlayer oVar3;
        CriTrigger pbVar4;
        uint uVar5;

        GameManager.instance.DAT_55 = 0;
        GameManager.instance.DAT_21 = 6;
        GameManager.instance.DAT_28++;
        GameManager.instance.FUN_6E6C8();

        if ((byte)(GameManager.instance.DAT_9AA0 >> 8) != (byte)(GameManager.instance.DAT_9ADC >> 8))
        {
            //FUN_1802C
        }

        for (int i = 0; i < 11; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriSkinned (Instance)";
            DAT_27C[i] = obj.AddComponent<CriPlayer>();
        }

        for (int i = 0; i < 100; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriBone (Instance)";
            DAT_1C9C[i] = obj.AddComponent<CriBone>();
        }

        for (int i = 0; i < 60; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriParticle (Instance)";
            DAT_5FCC[i] = obj.AddComponent<CriParticle>();
        }

        for (int i = 0; i < 40; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriStatic (Instance)";
            DAT_7CDC[i] = obj.AddComponent<CriStatic>();
        }

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriUnknown (Instance)";
            DAT_8FFC[i] = obj.AddComponent<CriUnknown>();
        }

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriTrigger (Instance)";
            DAT_9EEC[i] = obj.AddComponent<CriTrigger>();
        }

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriScene (Instance)";
            DAT_D7C0[i] = obj.AddComponent<CriScene>();
        }

        //FUN_601A4
        //FUN_5DDD0
        GameObject obj2 = new GameObject();
        oVar3 = obj2.AddComponent<CriPlayer>();
        DAT_27C[10] = oVar3;
        oVar3.screen = GameManager.instance.playerSpawnPos;
        oVar3.DAT_34 = GameManager.instance.playerSpawnPos;
        oVar3.vr.y = GameManager.instance.playerSpawnRotY;
        oVar3.DAT_48 = (sbyte)-(oVar3.screen.y / 0x1a9);
        oVar3.FUN_4CFDC();
        oVar3.materials = new Material[255];
        Tmd2ScriptableObject tmd = oVar3.cSkin;
        Material mat1 = new Material(GameManager.instance.materials[0x34]);
        Material mat2 = new Material(GameManager.instance.materials[0x3C]);
        mat1.mainTexture = tmd.TEX_2D;
        mat1.SetTexture("_Tex8", tmd.TEX8_2D);
        mat1.SetTexture("_CLUT", tmd.CLUT_2D);
        oVar3.materials[0x34] = mat1;
        mat2.mainTexture = tmd.TEX_2D;
        mat2.SetTexture("_Tex8", tmd.TEX8_2D);
        mat2.SetTexture("_CLUT", tmd.CLUT_2D);
        oVar3.materials[0x3C] = mat2;
        //...
        uVar5 = 0;

        if (uVar5 < DAT_9EEC.Length)
        {
            do
            {
                pbVar4 = DAT_9EEC[uVar5];
                uVar5++;
                pbVar4.DAT_03 &= 2;
            } while (uVar5 < DAT_9EEC.Length);
        }

        GameManager.instance.DAT_3C = 0;
        FUN_553EC();
        FUN_55548();
        FUN_1A3A0();
        FUN_4AEA0();
        FUN_261E0();
        GameManager.instance.DAT_23 = true;
        GameManager.instance.FUN_46C0C(0, 20, 1);
        GameManager.instance.DAT_2A = 0;

        if ((byte)(GameManager.instance.DAT_9AA0 >> 8) == 4 &&
            (byte)GameManager.instance.DAT_9AA0 == 9)
            GameManager.instance.DAT_28 = 9;

        FUN_290E0();
    }

    public void FUN_4A784(int param1, int param2, short param3, short param4, 
        short param5, short param6, short param7, short param8)
    {
        CriSkinned oVar1;

        oVar1 = DAT_27C[param2];

        switch (param1)
        {
            case 0:
                oVar1.DAT_EC.x = param6;
                oVar1.DAT_F2.x = param7;
                oVar1.DAT_F8.x = param8;
                break;
            case 1:
                oVar1.DAT_EC.y = param6;
                oVar1.DAT_F2.y = param7;
                oVar1.DAT_F8.y = param8;
                break;
            case 2:
                oVar1.DAT_EC.z = param6;
                oVar1.DAT_EC.z = param7;
                oVar1.DAT_EC.z = param8;
                break;
        }

        oVar1.DAT_B4[param1] = new Vector3Int(param3, param4, param5);
    }

    private void FUN_4AEA0()
    {
        LightScriptableObject lVar1;

        lVar1 = lightSource;
        Utilities.SetBackColor(lVar1.DAT_08.r, lVar1.DAT_08.g, lVar1.DAT_08.b);
        Utilities.SetFarColor(0, 0, 0);
        Utilities.SetFogNearFar(6000, 30000, 320);
    }

    public void FUN_4AEFC()
    {
        CriBone oVar4;
        int iVar5;
        CriSkinned piVar6;
        uint uVar7;

        uVar7 = 0;

        if (uVar7 < 11)
        {
            do
            {
                piVar6 = DAT_27C[uVar7];

                if (piVar6 != null && (piVar6.flags & 2) != 0)
                {
                    iVar5 = piVar6.boneCount;
                    oVar4 = piVar6.skeleton;

                    while (--iVar5 != -1)
                    {
                        GameManager.DAT_1f80002c = oVar4.screen;
                        GameManager.instance.FUN_4A8B8(lightSource, ref oVar4.colorMatrix, oVar4.DAT_54);
                        Coprocessor.rotationMatrix.rt11 = cCamera.cTransform.rotation.V00;
                        Coprocessor.rotationMatrix.rt12 = cCamera.cTransform.rotation.V01;
                        Coprocessor.rotationMatrix.rt13 = cCamera.cTransform.rotation.V02;
                        Coprocessor.rotationMatrix.rt21 = cCamera.cTransform.rotation.V10;
                        Coprocessor.rotationMatrix.rt22 = cCamera.cTransform.rotation.V11;
                        Coprocessor.rotationMatrix.rt23 = cCamera.cTransform.rotation.V12;
                        Coprocessor.rotationMatrix.rt31 = cCamera.cTransform.rotation.V20;
                        Coprocessor.rotationMatrix.rt32 = cCamera.cTransform.rotation.V21;
                        Coprocessor.rotationMatrix.rt33 = cCamera.cTransform.rotation.V22;
                        Coprocessor.vector0.vx0 = (short)oVar4.DAT_54[0].x;
                        Coprocessor.vector0.vy0 = (short)oVar4.DAT_54[0].y;
                        Coprocessor.vector0.vz0 = (short)oVar4.DAT_54[0].z;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        oVar4.lightMatrix.V00 = Coprocessor.accumulator.ir1;
                        oVar4.lightMatrix.V01 = Coprocessor.accumulator.ir2;
                        oVar4.lightMatrix.V02 = Coprocessor.accumulator.ir3;
                        Coprocessor.vector0.vx0 = (short)oVar4.DAT_54[1].x;
                        Coprocessor.vector0.vy0 = (short)oVar4.DAT_54[1].y;
                        Coprocessor.vector0.vz0 = (short)oVar4.DAT_54[1].z;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        oVar4.lightMatrix.V10 = Coprocessor.accumulator.ir1;
                        oVar4.lightMatrix.V11 = Coprocessor.accumulator.ir2;
                        oVar4.lightMatrix.V12 = Coprocessor.accumulator.ir3;
                        Coprocessor.vector0.vx0 = (short)oVar4.DAT_54[2].x;
                        Coprocessor.vector0.vy0 = (short)oVar4.DAT_54[2].y;
                        Coprocessor.vector0.vz0 = (short)oVar4.DAT_54[2].z;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        oVar4.lightMatrix.V20 = Coprocessor.accumulator.ir1;
                        oVar4.lightMatrix.V21 = Coprocessor.accumulator.ir2;
                        oVar4.lightMatrix.V22 = Coprocessor.accumulator.ir3;
                        oVar4 = (CriBone)oVar4.next;
                    }
                }

                uVar7++;
            } while (uVar7 < 11);
        }
    }

    public void FUN_57488(Trigger6 param1, int param2)
    {
        bool bVar1;
        CriStatic oVar1;
        Trigger tVar2;
        Vector3Int local_18;

        if (param1.DAT_1C == 0)
        {
            FUN_57540();
        }
        else
        {
            if (param1.DAT_18 == 0xff)
            {
                if ((GameManager.instance.DAT_A090[param1.DAT_1C] & 0x80) == 0) //???
                {
                    bVar1 = InventoryManager.FUN_4A87C(8, param1.DAT_1C);

                    if (!bVar1)
                    {
                        FUN_57540();
                        return;
                    }

                    tVar2 = triggers[param2];
                }
                else
                    tVar2 = triggers[param2];
            }
            else
            {
                bVar1 = InventoryManager.FUN_4A87C(7, param1.DAT_1C);

                if (!bVar1)
                {
                    FUN_57540();
                    return;
                }

                tVar2 = triggers[param2];
            }

            tVar2.DAT_13 = false;
        }

        void FUN_57540()
        {
            local_18 = new Vector3Int();
            local_18.y = 0;
            local_18.x = param1.DAT_00[2].x + ((param1.DAT_00[0].x - param1.DAT_00[2].x) / 2);
            local_18.z = param1.DAT_00[2].y + ((param1.DAT_00[0].y - param1.DAT_00[2].y) / 2);

            if (param1.DAT_1E != 0xff)
            {
                oVar1 = DAT_7CDC[param1.DAT_1E];
                param1.FUN_1A638(oVar1, local_18);

                if (param1.DAT_24 != 0)
                {
                    oVar1.DAT_2F = 1;
                    oVar1.flags &= 0xfffffffd;
                }
            }
        }
    }

    /*private void FUN_570A0(_STATIC_OBJ_DATA data)
    {
        CriStatic oVar1;

        GameObject obj = new GameObject();
        oVar1 = obj.AddComponent<CriStatic>();
        DAT_7CDC[data.DAT_01] = oVar1;
        oVar1.flags = 3;
        oVar1.DAT_2E = data.DAT_02;
        oVar1.DAT_48 = data.DAT_03;
        oVar1.DAT_4A = data.DAT_04;
        oVar1.cMesh = data.DAT_08;
        oVar1.screen = data.DAT_0C;
        oVar1.vr = data.DAT_12;
        oVar1.materials = new Material[255];
        TmdScriptableObject tmd = oVar1.cMesh;

        if (tmd != null)
        {
            for (int i = 0; i < tmd.CMDS.Length; i++)
            {
                if (oVar1.materials[tmd.CMDS[i]] == null)
                {
                    Material mat = new Material(GameManager.instance.materials[tmd.CMDS[i]]);
                    mat.mainTexture = tmd.TEX_2D;
                    mat.SetTexture("_Tex8", tmd.TEX8_2D);
                    mat.SetTexture("_CLUT", tmd.CLUT_2D);
                    oVar1.materials[tmd.CMDS[i]] = mat;
                }
            }
        }
    }*/

    public CriBone FUN_601F0()
    {
        int iVar1;
        CriBone puVar2;
        int iVar3;

        iVar1 = 99;
        iVar3 = 0;

        do
        {
            iVar1--;
            puVar2 = DAT_1C9C[iVar3];

            if (puVar2 != null && (puVar2.flags & 1) == 0)
            {
                puVar2.ResetValues();
                puVar2.flags = 3;
                puVar2.DAT_43 = false;
                return puVar2;
            }

            iVar3++;
        } while (iVar1 != -1);

        return null;
    }

    private bool FUN_632D0(Vector3Int param1, Vector4Int param2)
    {
        long lVar1;

        lVar1 = (int)Utilities.FUN_63160(param1, (Vector3Int)param2);
        lVar1 = Utilities.SquareRoot0(lVar1);
        return lVar1 <= param2.w;
    }

    private short FUN_63308(short param1, short param2, int param3, uint param4, ushort param5, ushort param6)
    {
        short sVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        int iVar5;

        uVar3 = param5;
        iVar4 = (param1 - param3) * (int)uVar3;
        uVar2 = param6;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar4 == -0x80000000)
            return 0; //trap(0x1800)

        iVar5 = (param2 - param3) * (int)uVar3;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar5 == -0x80000000)
            return 0; //trap(0x1800)

        iVar4 = param3 + iVar4 / (int)uVar2;
        sVar1 = (short)iVar4;

        if (uVar3 != 0)
        {
            iVar4 = (((param3 + iVar5 / (int)uVar2) * 0x10000 >> 0x10) - (iVar4 * 0x10000 >> 0x10)) * 
                (int)(param4 & 0xffff);

            if (uVar3 == 0)
                return 0; //trap(0x1c00)

            if (uVar3 == 0xffffffff && iVar4 == -0x80000000)
                return 0; //trap(0x1800)

            sVar1 += (short)(iVar4 / (int)uVar3);
        }

        return sVar1;
    }

    private short FUN_63420(short param1, int param2, short param3, uint param4, ushort param5, ushort param6)
    {
        short sVar1;
        uint uVar2;
        int iVar3;
        int iVar4;

        param4 &= 0xffff;
        iVar3 = (param3 - param2) * (int)param4;
        uVar2 = param6;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar3 == -0x80000000)
            return 0; //trap(0x1800)

        iVar4 = (param1 - param2) * (int)param4;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar4 == -0x80000000)
            return 0; //trap(0x1800)

        iVar3 = param2 + iVar3 / (int)uVar2;
        sVar1 = (short)iVar3;

        if (param4 != 0)
        {
            iVar3 = param5 * (((param2 + iVar4 / (int)uVar2) * 0x10000 >> 0x10) - (iVar3 * 0x10000 >> 0x10));

            if (param4 == 0)
                return 0; //trap(0x1c00)

            if (param4 == 0xffffffff && iVar3 == -0x80000000)
                return 0; //trap(0x1800)

            sVar1 += (short)(iVar3 / (int)param4);
        }

        return sVar1;
    }

    private short FUN_63538(int param1, short param2, short param3, uint param4, ushort param5, ushort param6)
    {
        short sVar1;
        uint uVar2;
        int iVar3;
        int iVar4;

        param4 &= 0xffff;
        iVar3 = (param2 - param1) * (int)param4;
        uVar2 = param6;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar3 == -0x80000000)
            return 0; //trap(0x1800)

        iVar4 = (param3 - param1) * (int)param4;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar4 == -0x80000000)
            return 0; //trap(0x1800)

        iVar3 = param1 + iVar3 / (int)uVar2;
        sVar1 = (short)iVar3;

        if (param4 != 0)
        {
            iVar3 = param5 * (((param1 + iVar4 / (int)uVar2) * 0x10000) >> 0x10) - (iVar3 * 0x10000 >> 0x10);

            if (param4 == 0)
                return 0; //trap(0x1c00)

            if (param4 == 0xffffffff && iVar3 == -0x80000000)
                return 0; //trap(0x1800)

            sVar1 += (short)(iVar3 / (int)param4);
        }

        return sVar1;
    }

    private short FUN_63650(short param1, int param2, short param3, uint param4, ushort param5, ushort param6)
    {
        short sVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        int iVar5;

        uVar3 = param5;
        iVar4 = (param1 - param2) * (int)uVar3;
        uVar2 = param6;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar4 == -0x80000000)
            return 0; //trap(0x1800)

        iVar5 = (param3 - param2) * (int)uVar3;

        if (uVar2 == 0)
            return 0; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar5 == -0x80000000)
            return 0; //trap(0x1800)

        iVar4 = param2 + iVar4 / (int)uVar2;
        sVar1 = (short)iVar4;

        if (uVar3 != 0)
        {
            iVar4 = (((param2 + iVar5 / (int)uVar2) * 0x10000 >> 0x10) - (iVar4 * 0x10000 >> 0x10)) * 
                (int)(param4 & 0xffff);

            if (uVar3 == 0)
                return 0; //trap(0x1c00)

            if (uVar3 == 0xffffffff && iVar4 == -0x80000000)
                return 0; //trap(0x1800)

            sVar1 += (short)(iVar4 / (int)uVar3);
        }

        return sVar1;
    }

    public bool FUN_63768(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        short sVar1;
        bool bVar2;
        bool bVar3;
        uint uVar4;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4];
        local_20[0].x = param1.DAT_04[0].x;
        local_20[0].y = param1.DAT_04[0].y + param1.DAT_04[1].y;
        local_20[1].x = param1.DAT_04[0].x + param1.DAT_04[1].x;
        local_20[1].y = param1.DAT_04[0].y + param1.DAT_04[1].y;
        local_20[2].x = param1.DAT_04[0].x + param1.DAT_04[1].x;
        local_20[2].y = param1.DAT_04[0].y;
        local_20[3].x = param1.DAT_04[0].x;
        local_20[3].y = param1.DAT_04[0].y;
        bVar2 = GameManager.instance.FUN_768C8(param2, local_20);
        bVar3 = false;

        if (bVar2)
        {
            uVar4 = (uint)(param2.x - local_20[3].x);

            if ((int)(uVar4 * 0x10000) < 0)
            {
                sVar1 = FUN_63308((short)param1.DAT_04[2].x, (short)param1.DAT_04[2].y, param1.DAT_04[3].x,
                                  uVar4 & 0xffff, (ushort)(param2.z - local_20[3].y), 
                                  (ushort)(local_20[0].y - local_20[3].y));
                param3 = sVar1;
            }
            else
            {
                sVar1 = FUN_63420((short)param1.DAT_04[2].y, param1.DAT_04[3].x, (short)param1.DAT_04[3].y,
                                  uVar4 & 0xffff, (ushort)(param2.z - local_20[3].y),
                                  (ushort)(local_20[2].x - local_20[3].x));
                param3 = sVar1;
            }

            bVar3 = true;
        }

        return bVar3;
    }

    public bool FUN_638E0(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        bool bVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        uint uVar5;
        Vector4Int local_18;

        local_18 = new Vector4Int();
        local_18.x = param1.DAT_04[0].x;
        local_18.y = 0;
        local_18.z = param1.DAT_04[0].y;
        local_18.w = param1.DAT_04[1].x;
        bVar1 = FUN_632D0(param2, local_18);
        bVar3 = false;

        if (bVar1)
        {
            uVar5 = (uint)(param2.x - (param1.DAT_04[0].x - param1.DAT_04[1].x));
            uVar4 = (uint)(param2.z - (param1.DAT_04[0].y - param1.DAT_04[1].y));

            if ((int)(uVar4 * 0x10000) < (int)(uVar5 * 0x10000))
            {
                sVar2 = FUN_63420((short)param1.DAT_04[2].y, param1.DAT_04[3].x,
                                  (short)param1.DAT_04[3].y, uVar5 & 0xffff, (ushort)(uVar4 & 0xffff),
                                  (ushort)((param1.DAT_04[1].x & 0x7fff) << 1));
                param3 = sVar2;
            }
            else
            {
                sVar2 = FUN_63308((short)param1.DAT_04[2].x, (short)param1.DAT_04[2].y,
                                  param1.DAT_04[3].x, uVar5 & 0xffff, (ushort)(uVar4 & 0xffff),
                                  (ushort)((param1.DAT_04[1].x & 0x7fff) << 1));
                param3 = sVar2;
            }

            bVar3 = true;
        }

        return bVar3;
    }

    public bool FUN_63A1C(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        short sVar1;
        bool bVar2;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4];
        local_20[0].x = param1.DAT_04[0].x;
        local_20[0].y = param1.DAT_04[0].y;
        local_20[1].x = param1.DAT_04[0].x + param1.DAT_04[1].x;
        local_20[1].y = param1.DAT_04[0].y;
        local_20[2].x = param1.DAT_04[0].x;
        local_20[2].y = param1.DAT_04[0].y - param1.DAT_04[1].y;
        local_20[3] = local_20[2];
        bVar2 = GameManager.instance.FUN_768C8(param2, local_20);

        if (bVar2)
        {
            sVar1 = FUN_63308((short)param1.DAT_04[2].x, (short)param1.DAT_04[2].y, param1.DAT_04[3].x,
                              (uint)(param2.x - local_20[3].x), (ushort)(param2.z - local_20[3].y),
                              (ushort)(local_20[0].y - local_20[3].y));
            param3 = sVar1;
        }

        return bVar2;
    }

    public bool FUN_63B04(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        short sVar1;
        bool bVar2;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4];
        local_20[0].x = param1.DAT_04[0].x;
        local_20[0].y = param1.DAT_04[0].y + param1.DAT_04[1].y;
        local_20[1].x = param1.DAT_04[0].x;
        local_20[1].y = param1.DAT_04[0].y;
        local_20[2].x = param1.DAT_04[0].x - param1.DAT_04[1].x;
        local_20[2].y = param1.DAT_04[0].y;
        local_20[3] = local_20[2];
        bVar2 = GameManager.instance.FUN_768C8(param2, local_20);

        if (bVar2)
        {
            sVar1 = FUN_63420((short)param1.DAT_04[2].x, param1.DAT_04[2].y, (short)param1.DAT_04[3].x,
                              (uint)(param2.x - local_20[3].x), (ushort)(param2.z - local_20[3].y),
                              (ushort)(local_20[1].x - local_20[2].x));
            param3 = sVar1;
        }

        return bVar2;
    }

    public bool FUN_63BF0(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        short sVar1;
        bool bVar2;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4];
        local_20[0].x = param1.DAT_04[0].x;
        local_20[0].y = param1.DAT_04[0].y + param1.DAT_04[1].y;
        local_20[1].x = param1.DAT_04[0].x + param1.DAT_04[1].x;
        local_20[1].y = param1.DAT_04[0].y;
        local_20[2].x = param1.DAT_04[0].x;
        local_20[2].y = param1.DAT_04[0].y;
        local_20[3] = local_20[2];
        bVar2 = GameManager.instance.FUN_768C8(param2, local_20);

        if (bVar2)
        {
            sVar1 = FUN_63650((short)param1.DAT_04[2].x, param1.DAT_04[2].y, (short)param1.DAT_04[3].x,
                              (uint)(param2.x - local_20[2].x), (ushort)(param2.z - local_20[2].y),
                              (ushort)(local_20[0].y - local_20[2].y));
            param3 = sVar1;
        }

        return bVar2;
    }

    public bool FUN_63CD8(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        short sVar1;
        bool bVar2;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4];
        local_20[0].x = param1.DAT_04[0].x - param1.DAT_04[1].x;
        local_20[0].y = param1.DAT_04[0].y;
        local_20[1].x = param1.DAT_04[0].x;
        local_20[1].y = param1.DAT_04[0].y;
        local_20[2].x = param1.DAT_04[0].x;
        local_20[2].y = param1.DAT_04[0].y - param1.DAT_04[1].y;
        local_20[3] = local_20[2];
        bVar2 = GameManager.instance.FUN_768C8(param2, local_20);

        if (bVar2)
        {
            sVar1 = FUN_63538(param1.DAT_04[2].x, (short)param1.DAT_04[2].y, (short)param1.DAT_04[3].x,
                              (uint)(param2.x - local_20[0].x), (ushort)(param2.z - local_20[3].y),
                              (ushort)(local_20[1].x - local_20[0].x));
            param3 = sVar1;
        }

        return bVar2;
    }

    public bool FUN_63DC4(FloorCollider param1, Vector3Int param2, ref short param3)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar3;
        bool bVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        int iVar9;
        int iVar10;
        int iVar11;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4];
        local_20[0].x = param1.DAT_04[0].x - param1.DAT_04[1].x;
        local_20[0].y = param1.DAT_04[0].y;
        local_20[1].x = param1.DAT_04[0].x;
        local_20[1].y = param1.DAT_04[0].y + param1.DAT_04[1].y;
        local_20[2].x = param1.DAT_04[0].x + param1.DAT_04[1].x;
        local_20[2].y = param1.DAT_04[0].y;
        local_20[3].x = param1.DAT_04[0].x;
        local_20[3].y = param1.DAT_04[0].y - param1.DAT_04[1].y;
        bVar3 = GameManager.instance.FUN_768C8(param2, local_20);
        bVar4 = false;

        if (bVar3)
        {
            iVar3 = param1.DAT_04[3].y;
            iVar9 = param1.DAT_04[2].x;
            uVar8 = (ushort)param1.DAT_04[1].x;
            iVar10 = (iVar3 - iVar9) * (int)uVar8;

            if (uVar8 == 0)
                return false; //trap(0x1c00)

            if ((int)uVar8 << 1 == -1 && iVar10 == -0x80000000)
                return false; //trap(0x1800)

            sVar1 = (short)param1.DAT_04[2].y;
            uVar6 = (ushort)param1.DAT_04[1].y;
            iVar11 = (sVar1 - param1.DAT_04[3].x) * (int)uVar6;

            if (uVar6 == 0)
                return false; //trap(0x1c00)

            if ((int)uVar6 << 1 == -1 && iVar11 == -0x80000000)
                return false; //trap(0x1800)

            iVar10 = iVar9 + iVar10 / (int)(uVar8 << 1);
            iVar11 = (((((ushort)param1.DAT_04[3].x + iVar11 / (int)(uVar6 << 1)) * 0x10000) >> 
                     0x10) - (iVar10 * 0x10000 >> 0x10)) * (int)uVar8;

            if (uVar6 == 0)
                return false; //trap(0x1c00)

            if (uVar6 == 0xffffffff && iVar11 == -0x80000000)
                return false; //trap(0x1800)

            uVar7 = (uint)(param2.x - local_20[0].x);
            uVar5 = (uint)(param2.z - local_20[3].y);
            iVar10 = iVar10 + iVar11 / (int)uVar6;

            if ((int)(uVar7 * 0x10000) >> 0x10 < (int)uVar8)
            {
                if ((int)(uVar5 * 0x10000) >> 0x10 < (int)uVar6)
                {
                    sVar2 = FUN_63538(iVar9, (short)(iVar10 * 0x10000 >> 0x10), (short)iVar3,
                                      uVar7 & 0xffff, (ushort)(uVar5 & 0xffff), (ushort)param1.DAT_04[1].x);
                    param3 = sVar2;
                }
                else
                {
                    sVar2 = FUN_63420(sVar1, param1.DAT_04[2].x, (short)(iVar10 * 0x10000 >> 0x10),
                                      uVar7 & 0xffff, (ushort)(uVar5 - uVar6 & 0xffff), (ushort)param1.DAT_04[1].x);
                    param3 = sVar2;
                }
            }
            else
            {
                if ((int)(uVar5 * 0x10000) >> 0x10 < (int)uVar6)
                {
                    sVar2 = FUN_63308((short)(iVar10 * 0x10000 >> 0x10), (short)param1.DAT_04[3].x, iVar3,
                                      uVar7 - uVar8 & 0xffff, (ushort)(uVar5 & 0xffff), (ushort)param1.DAT_04[1].y);
                    param3 = sVar2;
                }
                else
                {
                    sVar2 = FUN_63650(sVar1, iVar10 * 0x10000 >> 0x10, (short)param1.DAT_04[3].x,
                                      uVar7 - uVar8 & 0xffff, (ushort)(uVar5 - uVar6 & 0xffff), (ushort)param1.DAT_04[1].y);
                    param3 = sVar2;
                }
            }

            bVar4 = true;
        }

        return bVar4;
    }

    public bool FUN_64210(ref Vector3Int param1, byte param2, uint param3)
    {
        byte bVar1;
        bool bVar2;
        bool bVar3;
        FloorSegment oVar4;
        FloorCollider puVar5;
        uint uVar7;
        short local_28;

        if (param2 < 0x10)
        {
            if (param2 < 0)
                param2 = 0;

            oVar4 = sceneCollision.FLOOR_SEGMENT;
            bVar1 = oVar4.FLOOR_COUNT;
            uVar7 = 0;
            local_28 = 0;

            if (oVar4.FLOOR_COUNT != 0)
            {
                do
                {
                    puVar5 = oVar4.FLOOR_COLLIDERS[uVar7];

                    if ((puVar5.DAT_01 == 0 || (param3 & 2) == 0) && puVar5.DAT_04[1].x != 0 &&
                        puVar5.DAT_04[1].y != 0 && (puVar5.DAT_01 & 0x80) == 0)
                    {
                        switch (puVar5.DAT_00)
                        {
                            case 0:
                                bVar3 = FUN_63768(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                            case 1:
                                bVar3 = FUN_638E0(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                            case 2:
                                bVar3 = FUN_63A1C(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                            case 3:
                                bVar3 = FUN_63B04(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                            case 4:
                                bVar3 = FUN_63BF0(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                            case 5:
                                bVar3 = FUN_63CD8(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                            case 6:
                                bVar3 = FUN_63DC4(puVar5, param1, ref local_28);

                                if (bVar3)
                                {
                                    bVar2 = param1.y < local_28;

                                    if (!bVar2)
                                    {
                                        param1.y = local_28;
                                        return true;
                                    }
                                }

                                break;
                        }
                    }

                    uVar7++;
                } while (uVar7 < bVar1);
            }
        }

        return false;
    }

    public FloorCollider FUN_645C8(uint param1, uint param2)
    {
        return sceneCollision.FLOOR_SEGMENT.FLOOR_COLLIDERS[param2 & 0xff];
    }

    public sbyte FUN_64D20(CriSkinned param1, Vector3Int param2, ref Vector2Int param3)
    {
        byte bVar1;
        bool bVar2;
        uint uVar3;
        uint uVar4;
        int iVar5;
        WallSegment wVar5;
        uint uVar8;
        WallCollider pbVar7;
        uint uVar9;
        uint uVar10;
        Vector4Int local_40;
        Vector3Int local_38;
        Vector2Int local_30;

        local_40 = new Vector4Int(param1.screen.x, param1.screen.z, param2.x, param2.z);
        local_38 = new Vector3Int();
        local_30 = new Vector2Int();
        uVar10 = 0;
        uVar8 = 0xffff;
        uVar9 = 0;
        bVar1 = sceneCollision.WALL_SEGMENTS[0].WALL_COUNT;
        
        if (bVar1 != 0)
        {
            do
            {
                pbVar7 = sceneCollision.WALL_SEGMENTS[0].WALL_COLLIDERS[uVar9];

                if ((pbVar7.flags & 0x8000) == 0)
                {
                    if (pbVar7.DAT_03 == 0)
                    {
                        bVar2 = PTR_FUN_9E96C[pbVar7.DAT_00](local_40, pbVar7, ref local_30);

                        if (bVar2)
                        {
                            local_38.x = local_30.x;
                            local_38.y = 0;
                            local_38.z = local_30.y;
                            uVar3 = Utilities.FUN_631AC(param1.screen, local_38);

                            if (uVar3 < uVar8)
                            {
                                param3.x = local_30.x;
                                uVar10 = 0xff;
                                param3.y = local_30.y;
                                uVar8 = uVar3;
                            }
                        }
                    }
                    else
                    {
                        if (pbVar7.DAT_02 <= (uint)(byte)param1.DAT_48 && (uint)(byte)param1.DAT_48 < pbVar7.DAT_03)
                        {
                            bVar2 = PTR_FUN_9E96C[pbVar7.DAT_00](local_40, pbVar7, ref local_30);

                            if (bVar2)
                            {
                                local_38.x = local_30.x;
                                local_38.y = 0;
                                local_38.z = local_30.y;
                                uVar3 = Utilities.FUN_631AC(param1.screen, local_38);

                                if (uVar3 < uVar8)
                                {
                                    param3 = local_30;

                                    if (pbVar7.DAT_02 < (uint)(byte)param1.DAT_48)
                                        iVar5 = pbVar7.DAT_03 - (byte)param1.DAT_48;
                                    else
                                        iVar5 = pbVar7.DAT_03 - pbVar7.DAT_02;

                                    uVar8 = uVar3;
                                    uVar10 = 0xff;

                                    if ((iVar5 + 1) * 0x1000000 >> 0x18 < 6)
                                        uVar10 = (uint)(iVar5 + 1);
                                }
                            }
                        }
                    }
                }

                uVar9++;
            } while (uVar9 < bVar1);
        }

        uVar9 = 0;
        wVar5 = sceneCollision.WALL_SEGMENTS[param1.DAT_48 + 1];
        uVar3 = wVar5.WALL_COUNT;

        if (uVar3 != 0)
        {
            do
            {
                pbVar7 = wVar5.WALL_COLLIDERS[uVar9];

                if ((pbVar7.flags & 0x8000) == 0)
                {
                    if (pbVar7.DAT_03 == 0)
                    {
                        bVar2 = PTR_FUN_9E96C[pbVar7.DAT_00](local_40, pbVar7, ref local_30);

                        if (bVar2)
                        {
                            local_38.x = local_30.x;
                            local_38.y = 0;
                            local_38.z = local_30.y;
                            uVar4 = Utilities.FUN_631AC(param1.screen, local_38);

                            if (uVar4 < uVar8)
                            {
                                param3.x = local_30.x;
                                uVar10 = 1;
                                param3.y = local_30.y;
                                uVar8 = uVar4;
                            }
                        }
                    }
                    else
                    {
                        if (pbVar7.DAT_02 <= (uint)(byte)param1.DAT_48 && (uint)(byte)param1.DAT_48 < pbVar7.DAT_03)
                        {
                            bVar2 = PTR_FUN_9E96C[pbVar7.DAT_00](local_40, pbVar7, ref local_30);

                            if (bVar2)
                            {
                                local_38.x = local_30.x;
                                local_38.y = 0;
                                local_38.z = local_30.y;
                                uVar4 = Utilities.FUN_631AC(param1.screen, local_38);

                                if (uVar4 < uVar8)
                                {
                                    param3 = local_30;

                                    if (pbVar7.DAT_02 < (uint)(byte)param1.DAT_48)
                                        iVar5 = pbVar7.DAT_03 - (byte)param1.DAT_48;
                                    else
                                        iVar5 = pbVar7.DAT_03 - pbVar7.DAT_02;

                                    uVar8 = uVar4;
                                    uVar10 = 0xff;

                                    if ((iVar5 + 1) * 0x1000000 >> 0x18 < 6)
                                        uVar10 = (uint)(iVar5 + 1);
                                }
                            }
                        }
                    }
                }

                uVar9++;
            } while (uVar9 < uVar3);
        }

        return (sbyte)uVar10;
    }

    private bool FUN_65138(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector2Int[] local_18;

        local_18 = new Vector2Int[4];
        local_18[0].x = param2.DAT_04.x;
        local_18[0].y = param2.DAT_04.y + param2.DAT_08.y;
        local_18[1].x = param2.DAT_04.x + param2.DAT_08.x;
        local_18[1].y = param2.DAT_04.y + param2.DAT_08.y;
        local_18[2].x = param2.DAT_04.x;
        local_18[2].y = param2.DAT_04.y;
        local_18[3].x = param2.DAT_04.x + param2.DAT_08.x;
        local_18[3].y = param2.DAT_04.y;
        return Utilities.FUN_62D20(local_18, param1, ref param3) != 0;
    }

    private bool FUN_651D8(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector4Int local_10;

        local_10 = new Vector4Int(param2.DAT_04.x, 0, param2.DAT_04.y, param2.DAT_08.x);
        return Utilities.FUN_61BC0(param1, local_10, ref param3);
    }

    private bool FUN_6521C(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector2Int[] local_28;

        local_28 = new Vector2Int[4];
        local_28[0].x = param2.DAT_04.x;
        local_28[0].y = param2.DAT_04.y;
        local_28[1].x = param2.DAT_04.x + param2.DAT_08.x;
        local_28[1].y = param2.DAT_04.y;
        local_28[3].x = param2.DAT_04.x;
        local_28[3].y = param2.DAT_04.y - param2.DAT_08.y;
        local_28[2] = local_28[0];
        return Utilities.FUN_62AB0(local_28, param1, ref param3) != 0;
    }

    private bool FUN_652AC(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector2Int[] local_28;

        local_28 = new Vector2Int[4];
        local_28[0].x = param2.DAT_04.x - param2.DAT_08.x;
        local_28[0].y = param2.DAT_04.y;
        local_28[1].x = param2.DAT_04.x;
        local_28[1].y = param2.DAT_04.y;
        local_28[2].x = param2.DAT_04.x;
        local_28[2].y = param2.DAT_04.y + param2.DAT_08.y;
        local_28[3] = local_28[1];
        return Utilities.FUN_62AB0(local_28, param1, ref param3) != 0;
    }

    private bool FUN_6533C(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector2Int[] local_28;

        local_28 = new Vector2Int[4];
        local_28[0].x = param2.DAT_04.x;
        local_28[0].y = param2.DAT_04.y;
        local_28[1].x = param2.DAT_04.x + param2.DAT_08.x;
        local_28[1].y = param2.DAT_04.y;
        local_28[2].x = param2.DAT_04.x;
        local_28[2].y = param2.DAT_04.y + param2.DAT_08.y;
        local_28[3] = local_28[0];
        return Utilities.FUN_62AB0(local_28, param1, ref param3) != 0;
    }

    private bool FUN_653CC(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector2Int[] local_28;

        local_28 = new Vector2Int[4];
        local_28[0].x = param2.DAT_04.x;
        local_28[0].y = param2.DAT_04.y;
        local_28[2].x = param2.DAT_04.x - param2.DAT_08.x;
        local_28[2].y = param2.DAT_04.y;
        local_28[1].x = param2.DAT_04.x;
        local_28[1].y = param2.DAT_04.y - param2.DAT_08.y;
        local_28[3] = local_28[0];
        return Utilities.FUN_62AB0(local_28, param1, ref param3) != 0;
    }

    private bool FUN_6545C(Vector4Int param1, WallCollider param2, ref Vector2Int param3)
    {
        Vector2Int[] local_18;

        local_18 = new Vector2Int[4];
        local_18[0].x = param2.DAT_04.x + param2.DAT_08.x;
        local_18[0].y = param2.DAT_04.y;
        local_18[1].x = param2.DAT_04.x;
        local_18[1].y = param2.DAT_04.y - param2.DAT_08.y;
        local_18[2].x = param2.DAT_04.x;
        local_18[2].y = param2.DAT_04.y + param2.DAT_08.y;
        local_18[3].x = param2.DAT_04.x - param2.DAT_08.x;
        local_18[3].y = param2.DAT_04.y;
        return Utilities.FUN_62D20(local_18, param1, ref param3) != 0;
    }

    public CriSkinned FUN_65B30(CriSkinned param1)
    {
        CriSkinned psVar1;
        int iVar2;
        int iVar3;

        iVar3 = 10;
        iVar2 = 0;
        psVar1 = DAT_27C[iVar2];

        while((psVar1.flags & 1) == 0 || psVar1.tags != param1.tags || 
            param1 == psVar1 || psVar1.health < 1)
        {
            iVar3--;
            iVar2++;
            psVar1 = DAT_27C[iVar2];

            if (iVar3 == -1)
                return null;
        }

        return psVar1;
    }

    public uint FUN_65FD8(CriSkinned param1)
    {
        int iVar1;
        int iVar2;

        iVar2 = 9;
        iVar1 = 0;

        do
        {
            if (DAT_27C[iVar1] == param1)
                return 10 - (uint)iVar2 & 0xff;

            iVar2--;
            iVar1++;
        } while (iVar2 != -1);

        return 0;
    }

    public bool FUN_80030(CriSkinned param1, bool param2, byte param3)
    {
        byte bVar2;
        uint uVar3;
        CriSkinned pcVar4;
        uint uVar5;
        uint uVar6;
        bool bVar7;
        bool bVar8;

        uVar5 = 0;
        param1.DAT_128 = 0;
        param1.DAT_12A = 0;
        param1.DAT_12B = 0;
        param1.FUN_66208();
        bVar7 = false;
        bVar8 = bVar7;

        if (param1.PTR_120 != null && param1.DAT_177 == 0)
        {
            uVar6 = 10;

            if (param1 == DAT_27C[uVar6])
            {
                if ((param1.DAT_12C & 0x40) == 0)
                {
                    uVar6 = 0;
                    bVar8 = bVar7;

                    if (uVar6 < Array.IndexOf(DAT_27C, param1))
                    {
                        do
                        {
                            pcVar4 = DAT_27C[uVar5];

                            if ((pcVar4.flags & 1) != 0 && (pcVar4.DAT_12C & 0x10) == 0 &&
                                pcVar4.DAT_177 == 0)
                            {
                                bVar2 = GameManager.instance.FUN_7FB78(param1, pcVar4, param2, param3);
                                param1.DAT_12A = bVar2;

                                if (bVar2 != 0)
                                {
                                    bVar8 = true;
                                    param1.DAT_128 |= (ushort)(1 << (int)(uVar5 & 0x1f));
                                }
                            }

                            uVar5++;
                            uVar6++;
                        } while (uVar5 < 10);
                    }
                }
            }
            else
            {
                if ((param1.DAT_12C & 0x40) == 0)
                {
                    uVar3 = 0;

                    if (uVar3 < uVar6)
                    {
                        do
                        {
                            pcVar4 = DAT_27C[uVar5];

                            if ((pcVar4.flags & 1) != 0 && param1 != DAT_27C[uVar3] &&
                                (pcVar4.DAT_12C & 0x40) == 0 && pcVar4.DAT_177 == 0)
                            {
                                bVar2 = GameManager.instance.FUN_7FB78(param1, pcVar4, param2, param3);
                                param1.DAT_12A = bVar2;

                                if (bVar2 != 0)
                                {
                                    bVar7 = true;
                                    param1.DAT_128 |= (ushort)(1 << (int)(uVar5 & 0x1f));
                                }
                            }

                            uVar5++;
                            uVar3++;
                        } while (uVar5 < 10);
                    }

                    bVar8 = bVar7;

                    if ((param1.DAT_12C & 0x10) == 0 && (DAT_27C[10].DAT_12C & 0x40) == 0 && 
                        DAT_27C[10].DAT_177 == 0)
                    {
                        bVar2 = GameManager.instance.FUN_7FB78(param1, DAT_27C[uVar6], param2, param3);
                        param1.DAT_12B = bVar2;

                        if (bVar2 != 0)
                        {
                            bVar8 = true;
                            param1.DAT_128 |= 0x400;
                        }
                    }
                }
            }
        }

        return bVar8;
    }

    private bool FUN_8037C(WallCollider param1, Hit param2)
    {
        bool bVar1;
        Vector4Int local_18;
        Vector4Int local_10;

        local_10 = new Vector4Int();
        local_10.x = param1.DAT_04.x;
        local_10.z = param1.DAT_04.y;
        local_10.w = param1.DAT_08.x;
        local_18 = new Vector4Int();
        local_18.x = param2.DAT_00[1].x;
        local_18.z = param2.DAT_00[1].y;
        local_18.w = (short)param2.DAT_2C;
        bVar1 = GameManager.instance.FUN_844FC(local_18, local_10, ref local_10);

        if (bVar1)
        {
            param2.DAT_00[2].x = local_10.x;
            param2.DAT_00[2].y = local_10.z;
        }

        return bVar1;
    }

    public bool FUN_81014(Vector3Int param1, Vector3Int param2, byte param3, bool param4)
    {
        short sVar1;
        bool bVar2;
        uint uVar4;
        int iVar6;
        WallSegment wVar6;
        int iVar8;
        WallSegment wVar8;
        uint uVar9;
        int pbVar10;
        WallCollider pbVar11;
        WallCollider[][] local_68;
        int[] local_60;
        Vector2Int[] local_58;
        Vector4Int local_50;
        short[] local_40;
        short[] local_38;
        Vector4Int auStack72;

        local_50 = new Vector4Int();
        local_58 = new Vector2Int[2];
        local_58[0] = new Vector2Int(param1.x, param1.z);
        local_58[1] = new Vector2Int(param2.x, param2.z);
        local_40 = new short[2];
        local_38 = new short[2];
        local_60 = new int[2];
        local_68 = new WallCollider[2][];
        wVar6 = sceneCollision.WALL_SEGMENTS[0];
        local_60[0] = wVar6.WALL_COUNT;
        local_68[1] = wVar6.WALL_COLLIDERS;
        local_68[0] = local_68[1];

        if (param3 < 0x10)
        {
            wVar8 = sceneCollision.WALL_SEGMENTS[((uint)param3 >> 4) + 1];
            local_60[1] = wVar8.WALL_COUNT;
            local_68[1] = wVar6.WALL_COLLIDERS;
        }
        else
            local_60[1] = 0;

        iVar6 = 0;

        do
        {
            uVar4 = (uint)(local_60[iVar6] - 1);
            local_60[iVar6] = (int)uVar4;

            if (uVar4 != 0xffffffff)
            {
                pbVar10 = 0;

                do
                {
                    pbVar11 = local_68[iVar6][pbVar10];

                    if ((pbVar11.flags & 0x2000) != 0)
                    {
                        iVar8 = -1;

                        do
                        {
                            sVar1 = (short)iVar8;
                            iVar8++;
                            local_40[iVar8] = (short)(pbVar11.DAT_04.x + pbVar11.DAT_08.x * sVar1);
                            local_38[iVar8] = (short)(pbVar11.DAT_04.y + pbVar11.DAT_08.y * sVar1);
                        } while (iVar8 < 2);

                        uVar4 = DAT_AA484[pbVar11.DAT_00];

                        while (uVar4 != 0)
                        {
                            uVar9 = uVar4 - 1;

                            if (pbVar11.DAT_00 == 1)
                            {
                                local_50.x = pbVar11.DAT_04.x;
                                local_50.z = pbVar11.DAT_04.y;
                                local_50.w = pbVar11.DAT_08.x;
                                bVar2 = GameManager.instance.FUN_84338(local_58, local_50);
                            }
                            else
                            {
                                local_50.x = local_40[DAT_AA44C[pbVar11.DAT_00 * 4 + uVar9]];
                                local_50.y = local_38[DAT_AA468[pbVar11.DAT_00 * 4 + uVar9]];
                                local_50.z = local_40[DAT_AA44C[pbVar11.DAT_00 * 4 + (uVar4 & 3)]];
                                local_50.w = local_38[DAT_AA468[pbVar11.DAT_00 * 4 + (uVar4 & 3)]];
                                auStack72 = new Vector4Int();
                                bVar2 = GameManager.instance.FUN_84008(local_58, 
                                    new Vector2Int[2] { new Vector2Int(local_50.x, local_50.y), new Vector2Int(local_50.z, local_50.w) }, 
                                    ref auStack72);
                            }

                            uVar4 = uVar9;

                            if (bVar2)
                            {
                                if (param4 && (pbVar11.flags & 0x4000) != 0)
                                    return false;

                                if (param3 == 0xff)
                                    return true;

                                if (pbVar11.DAT_03 == 0 || (uint)(param3 & 0xf) < pbVar11.DAT_03)
                                    return true;
                            }
                        }
                    }

                    pbVar10++;
                    uVar4 = (uint)(local_60[iVar6] - 1);
                    local_60[iVar6] = (int)uVar4;
                } while (uVar4 != 0xffffffff);
            }

            iVar6++;

            if (1 < iVar6)
                return false;
        } while (true);
    }

    /*public bool FUN_80D48(Vector3Int param1, Vector3Int param2, uint param3)
    {
        uint[] local_68;
        Vector2Int[] local_60;

        local_60 = new Vector2Int[2];
        local_60[0].x = param1.x;
        local_60[0].y = param1.z;
        local_60[1].x = param2.x;
        local_60[1].y = param2.z;
        local_68 = new uint[2];
        return false;
    }*/

    public bool FUN_80A14(CriSkinned param1)
    {
        return FUN_80500(param1, 0);
    }

    private sbyte FUN_80404(Hit param1, WallCollider param2, byte param3) 
    {
        sbyte sVar1;
        Vector2Int[] local_20;

        param1.DAT_2F = DAT_AA484[param2.DAT_00];

        if (param2.DAT_00 == 1)
            sVar1 = (sbyte)(FUN_8037C(param2, param1) ? 1 : 0);
        else
        {
            param1.DAT_2E = param2.DAT_00;
            local_20 = new Vector2Int[4];
            GameManager.instance.FUN_813F0(local_20, param2);
            param1.DAT_0C[0] = local_20[0];
            param1.DAT_0C[1] = local_20[1];
            param1.DAT_0C[2] = local_20[2];
            param1.DAT_0C[3] = local_20[3];
            sVar1 = GameManager.instance.FUN_839D0(param1);
        }

        if (sVar1 != 0 && param3 == 0)
        {
            param1.DAT_00[1].x += param1.DAT_00[2].x;
            param1.DAT_00[1].y += param1.DAT_00[2].y;
        }

        return sVar1;
    }

    private bool FUN_80500(CriSkinned param1, byte param2)
    {
        short sVar1;
        short sVar2;
        sbyte sVar3;
        uint uVar4;
        int iVar5;
        WallSegment oVar5;
        int iVar6;
        CriBone oVar6;
        WallCollider pbVar7;
        WallCollider[] pbVar8;
        int iVar9;
        int iVar10;
        WallSegment oVar10;
        CapsuleCollider psVar11;
        int iVar12;
        WallCollider[][] local_a8;
        byte local_a0;
        short local_9c;
        short local_9a;
        ushort local_98;
        ushort local_96;
        Vector3Int auStack144;
        uint[] local_88;
        Vector2Int[] local_80;
        Hit local_70;
        byte local_38;
        bool local_30;

        local_30 = false;
        param1.DAT_142 = 0;
        
        if ((param1.DAT_140 & 0x8000) == 0 && param1.PTR_130 != null)
        {
            param1.DAT_142 = 0;
            oVar5 = sceneCollision.WALL_SEGMENTS[0];
            local_88 = new uint[2];
            local_88[0] = oVar5.WALL_COUNT;
            uVar4 = (byte)param1.DAT_48 + 1U & 0xffU;
            local_a8 = new WallCollider[2][];
            local_a8[0] = oVar5.WALL_COLLIDERS;

            if (uVar4 < 0x10)
            {
                if (sceneCollision.WALL_SEGMENTS.Length < uVar4)
                {
                    oVar10 = sceneCollision.WALL_SEGMENTS[uVar4];
                    local_88[1] = oVar10.WALL_COUNT;
                    local_a8[1] = oVar10.WALL_COLLIDERS;
                }
                else
                {
                    local_88[1] = 0;
                    local_a8[1] = null;
                }
            }
            else
            {
                local_88[1] = 0;
                local_a8[1] = local_a8[0];
            }

            psVar11 = param1.PTR_130[param1.DAT_130];
            local_38 = param2;
            Utilities.RotMatrix_gte(ref param1.vr, ref GameManager.DAT_1f800034);
            GameManager.DAT_1f80002c.x = psVar11.pos.x;
            GameManager.DAT_1f80002c.z = psVar11.pos.z;
            GameManager.DAT_1f80002c.y = 0;
            GameManager.DAT_1f80002c = Utilities.ApplyMatrixSV
                (ref GameManager.DAT_1f800034, ref GameManager.DAT_1f80002c);
            local_70 = new Hit();
            local_70.DAT_00 = new Vector2Int[3];
            local_70.DAT_0C = new Vector2Int[4];
            local_80 = new Vector2Int[4];
            auStack144 = new Vector3Int();

            if (psVar11.bone == -1)
                local_70.DAT_00[1] = new Vector2Int
                    (param1.screen.x + GameManager.DAT_1f80002c.x, param1.screen.z);
            else
            {
                oVar6 = (CriBone)Utilities.FUN_601C8(param1.skeleton, psVar11.bone);
                local_70.DAT_00[1] = new Vector2Int
                    (oVar6.screen.x + GameManager.DAT_1f80002c.x, oVar6.screen.z);
            }

            local_70.DAT_00[1].y += GameManager.DAT_1f80002c.z;
            local_70.DAT_00[0] = param1.DAT_13C;
            iVar10 = 0;
            local_70.DAT_2C = psVar11.radius;
            local_70.DAT_32 = 0;
            local_70.DAT_34 = (CriPlayer)param1;

            do
            {
                iVar9 = (int)local_88[iVar10];
                pbVar8 = local_a8[iVar10];

                if (iVar9 != 0 && pbVar8 != null)
                {
                    iVar12 = 0;

                    do
                    {
                        pbVar7 = pbVar8[iVar12];
                        iVar9--;

                        if ((param1.DAT_140 & pbVar7.flags & 1) == 0 &&
                            ((pbVar7.flags & 0x1000) == 0 || param1.tags != 0) &&
                            ((pbVar7.flags & 0x800) == 0 || param1.tags == 0) &&
                            (pbVar7.flags & 0x8000) == 0)
                        {
                            local_a0 = pbVar7.DAT_00;
                            iVar5 = pbVar7.DAT_04.x +
                                    pbVar7.DAT_08.x * DAT_AA48C[pbVar7.DAT_00];
                            local_9c = (short)iVar5;
                            iVar6 = pbVar7.DAT_04.y +
                                    pbVar7.DAT_08.y * DAT_AA493[pbVar7.DAT_00];
                            local_9a = (short)iVar6;
                            local_98 = (ushort)(pbVar7.DAT_08.x << (DAT_AA49A[pbVar7.DAT_00] & 0x1f));
                            local_80[1].x = local_9c + (short)local_98;
                            local_80[0].x = local_9c;
                            local_96 = (ushort)(pbVar7.DAT_08.y << (DAT_AA49A[pbVar7.DAT_00] & 0x1f));
                            local_80[1].y = local_9a + (short)local_96;
                            local_80[0].y = local_80[1].y;
                            local_80[2].x = local_80[1].x;
                            local_80[2].y = local_9a;
                            local_80[3].x = local_9c;
                            local_80[3].y = local_9a;

                            if (((uint)((local_70.DAT_00[1].x + local_70.DAT_2C) - (iVar5 * 0x10000 >> 0x10)) <
                                local_98 + psVar11.radius * 2U &&
                                (uint)((local_70.DAT_00[1].y + local_70.DAT_2C) - (iVar6 * 0x10000 >> 0x10)) <
                                local_96 + psVar11.radius * 2U) ||
                                GameManager.instance.FUN_841E8(local_80, local_70.DAT_00, ref auStack144) != 0)
                            {
                                sVar2 = (short)local_70.DAT_00[1].y;
                                sVar1 = (short)local_70.DAT_00[1].x;
                                local_70.DAT_30 = pbVar7.flags;
                                sVar3 = 0;

                                if (pbVar7.DAT_03 == 0)
                                    sVar3 = FUN_80404(local_70, pbVar7, local_38);
                                else
                                {
                                    if (pbVar7.DAT_02 <= (uint)(byte)param1.DAT_48 &&
                                        (uint)(byte)param1.DAT_48 <= pbVar7.DAT_03)
                                        sVar3 = FUN_80404(local_70, pbVar7, local_38);
                                }

                                if (sVar3 != 0)
                                {
                                    param1.DAT_142 = sVar3;
                                    param1.DAT_134 = pbVar7;

                                    if ((param1.DAT_140 & 0x100) == 0)
                                    {
                                        param1.DAT_14C.x += local_70.DAT_00[1].x - sVar1;
                                        param1.screen.x += local_70.DAT_00[1].x - sVar1;
                                        param1.DAT_14C.z += local_70.DAT_00[1].y - sVar2;
                                        param1.screen.z += local_70.DAT_00[1].y - sVar2;
                                    }

                                    local_30 = true;
                                }
                            }
                        }

                        iVar12++;
                    } while (iVar9 != 0);
                }

                iVar10++;
            } while (iVar10 < 2);

            param1.DAT_13C = local_70.DAT_00[1];

            if (local_30)
            {
                if (((ushort)param1.DAT_152 & 1) != 0)
                {
                    param1.DAT_154.DAT_14C.x = param1.DAT_14C.x;
                    param1.DAT_154.DAT_14C.z = param1.DAT_14C.z;
                    param1.FUN_65714();
                    param1.DAT_154.FUN_65714();
                }

                param1.FUN_66208();
            }
        }
        else
        {
            local_30 = false;
            param1.DAT_13C.x = param1.screen.x;
            param1.DAT_13C.y = param1.screen.z;
        }

        return local_30;
    }

    public void FUN_8133C(uint param1, ushort param2, byte param3)
    {
        WallCollider wVar1;

        wVar1 = sceneCollision.WALL_SEGMENTS[0].WALL_COLLIDERS[param1 & 0xff];

        if (param3 != 0)
        {
            wVar1.flags |= param2;
            return;
        }

        wVar1.flags &= (ushort)~param2;
    }

    public void FUN_81390(uint param1, byte param2, byte param3)
    {
        FloorCollider fVar1;

        fVar1 = sceneCollision.FLOOR_SEGMENT.FLOOR_COLLIDERS[param1 & 0xff];

        if (param3 != 0)
        {
            fVar1.DAT_01 |= param2;
            return;
        }

        fVar1.DAT_01 &= (byte)~param2;
    }
}
