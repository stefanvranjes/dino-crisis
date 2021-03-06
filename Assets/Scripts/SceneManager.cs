using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    public ScnScriptableObject scn; //gp+268h
    public DatabaseScriptableObject database;
    public byte[] DAT_AC; //gp+ach
    public CriCamera cCamera; //gp+b4h
    public SceneColliderScriptableObject sceneCollision; //gp+154h
    public LightScriptableObject lightSource;
    public SceneCameraScriptableObject motions; //gp+164h, gp+160h -> motions.Length
    public Trigger[] triggers; //gp+1e8h
    public byte DAT_270; //gp+270h
    public CriSkinned[] DAT_27C; //gp+27ch...gp+1c9ch
    public CriBone[] DAT_1C9C; //gp+1c9ch...gp+5fcch
    public CriObject[] DAT_5FCC; //gp+5fcch...gp+7cdch
    public CriStatic[] DAT_7CDC; //gp+7cdch...gp+8ffch
    public CriTrigger[] DAT_9EEC; //gp+9eech...gp+9fdch
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
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.sceneManager = this;
        triggers = new Trigger[32];
        DAT_27C = new CriSkinned[11];
        DAT_1C9C = new CriBone[100];
        DAT_5FCC = new CriObject[60];
        DAT_7CDC = new CriStatic[40];
        DAT_9EEC = new CriTrigger[10];
        DAT_D7C0 = new CriScene[10];

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

        for (int i = 0; i < 40; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriStatic (Instance)";
            DAT_7CDC[i] = obj.AddComponent<CriStatic>();
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

        FUN_47BE0();
    }

    // Update is called once per frame
    void Update()
    {
        
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

        GameManager.instance.DAT_55 = 0;
        GameManager.instance.DAT_21 = 6;
        GameManager.instance.DAT_28++;
        //FUN_6E6C8

        if ((byte)(GameManager.instance.DAT_9AA0 >> 8) != (byte)(GameManager.instance.DAT_9ADC >> 8))
        {
            //FUN_1802C
        }

        //FUN_1802C
        //FUN_601A4
        //FUN_5DDD0
        GameObject obj = new GameObject();
        oVar3 = obj.AddComponent<CriPlayer>();
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
                        GameManager.instance.DAT_1f80002c = oVar4.screen;
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
            Utilities.RotMatrix_gte(ref param1.vr, ref GameManager.instance.DAT_1f800034);
            GameManager.instance.DAT_1f80002c.x = psVar11.pos.x;
            GameManager.instance.DAT_1f80002c.z = psVar11.pos.z;
            GameManager.instance.DAT_1f80002c.y = 0;
            GameManager.instance.DAT_1f80002c = Utilities.ApplyMatrixSV
                (ref GameManager.instance.DAT_1f800034, ref GameManager.instance.DAT_1f80002c);
            local_70 = new Hit();
            local_70.DAT_00 = new Vector2Int[3];
            local_70.DAT_0C = new Vector2Int[4];
            local_80 = new Vector2Int[4];
            auStack144 = new Vector3Int();

            if (psVar11.bone == -1)
                local_70.DAT_00[1] = new Vector2Int
                    (param1.screen.x + GameManager.instance.DAT_1f80002c.x, param1.screen.z);
            else
            {
                oVar6 = (CriBone)Utilities.FUN_601C8(param1.skeleton, psVar11.bone);
                local_70.DAT_00[1] = new Vector2Int
                    (oVar6.screen.x + GameManager.instance.DAT_1f80002c.x, oVar6.screen.z);
            }

            local_70.DAT_00[1].y += GameManager.instance.DAT_1f80002c.z;
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
