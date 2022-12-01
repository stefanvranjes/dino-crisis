using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public enum _DIFFICULTY
{
    Normal, 
    Easy
}

public struct CapsuleCollider
{
    public Vector3Int pos; //0x00
    public ushort radius; //0x06
    public ushort height; //0x08
    public sbyte bone; //0x0A
    public byte flags; //0x0B
}

public struct UNK_9B084
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public int DAT_0C;
}

public struct UNK_9B314
{
    public ushort bone; //0x00
    public Vector3Int screen; //0x02
    public Vector3Int vr; //0x08
}

public class Hit
{
    public Vector2Int[] DAT_00; //0x00
    public Vector2Int[] DAT_0C; //0x0C
    public ushort DAT_2C; //0x2c
    public byte DAT_2E; //0x2E
    public byte DAT_2F; //0x2F
    public ushort DAT_30; //0x30
    public byte DAT_32; //0x32
    public CriPlayer DAT_34; //0x34
}

[System.Serializable]
public class LoadScriptContainer
{
    public ushort DAT_02; //0x02
    public string scriptName; //0x08
    public List<LoadSceneContainer> scenes; //0x0C
}

[System.Serializable]
public class LoadSceneContainer
{
    public ushort DAT_02; //0x02
    public byte DAT_08; //0x08
}

[System.Serializable]
public class LoadDoorContainer
{
    public RamScriptableObject ram;
    public TmdScriptableObject DAT_00; //0x00
    public TmdScriptableObject DAT_04; //0x04 ???
    public UnityEvent DAT_08; //0x08
    public short DAT_0C; //0x0C
    public Vector3Int DAT_0E; //0x0E
    public Vector3Int DAT_14; //0x14
    public Vector3Int DAT_1A; //0x1A
    public string DAT_20; //0x20
}

public class CoroutineLoader
{
    public short DAT_00; //0x00
    public short DAT_02; //0x02
    public short DAT_04; //0x04
    public short DAT_06; //0x06
    public short DAT_08; //0x08
    public ushort DAT_0A; //0x0A
    public byte DAT_0C; //0x0C
    public sbyte DAT_0D; //0x0D
    public sbyte DAT_0F; //0x0F
    public LoadSceneContainer DAT_10; //0x10
    public Vector3Int DAT_14; //0x14
    public bool exit;
}

public delegate void FUN_148(CriPlayer p);
public delegate void FUN_14C(CriPlayer p);

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static SceneManager sceneManager;

    public static ushort DAT_1f800008;
    public static ushort DAT_1f80000a;
    public static ushort DAT_1f800024;
    public static ushort DAT_1f800026;
    public static ushort DAT_1f800028;
    public static ushort DAT_1f80002a;
    public static Vector3Int DAT_1f80002c;
    public static Vector3Int DAT_1f800034_2;
    public static Matrix3x3 DAT_1f800034;
    public static Vector3Int DAT_1f800044;
    public static Matrix3x3 DAT_1f80004c;
    public static Vector3Int DAT_1f800380;
    public static Vector3Int DAT_1f800388;
    public static Vector3Int DAT_1f800390;
    public List<Vector3Int> todUncomp;
    public LightSource DAT_0C; //gp+0ch
    public byte DAT_20; //gp+20h
    public byte DAT_21; //gp+21h
    public bool DAT_23; //gp+23h
    public short DAT_28; //gp+28h
    public short DAT_2A; //gp+2ah
    public short DAT_2C; //gp+2ch
    public short DAT_2E; //gp+2eh
    public byte DAT_38; //gp+38h
    public byte DAT_39; //gp+39h
    public byte DAT_3B; //gp+3bh
    public bool DAT_46; //gp+46h
    public byte DAT_47; //gp+47h
    public Vector3Int playerSpawnPos; //gp+4ch
    public short playerSpawnRotY; //gp+52h
    public byte DAT_55; //gp+55h
    public byte DAT_56; //gp+56h
    public uint DAT_64; //gp+64h
    public uint DAT_68; //gp+68h
    public byte DAT_6C; //gp+6ch
    public bool DAT_6D; //gp+6dh
    public byte DAT_6E; //gp+6eh
    public byte DAT_6F; //gp+6fh
    public int DAT_78; //gp+78h
    public ushort DAT_7C; //gp+7ch
    public FUN_148 PTR_FUN_148; //gp+148h
    public FUN_14C PTR_FUN_14C; //gp+14ch
    public byte DAT_922C; //gp+922ch
    public CriPlayer DAT_9230; //gp+9230h
    public byte DAT_9234; //gp+9234h
    public byte DAT_9235; //gp+9235h
    public short DAT_98B4; //gp+98b4h
    public short DAT_98B8; //gp+98b8h
    public short DAT_98BA; //gp+98bah
    public ushort DAT_9AA0; //gp+9aa0h
    public byte DAT_9AA2; //gp+9aa2h
    public int DAT_9AA4; //gp+9aa4h
    public _DIFFICULTY difficulty; //gp+9aa8h
    public byte DAT_9AA9; //gp+9aa9h
    public byte DAT_9AAA; //gp+9aaah
    public byte DAT_9AAB; //gp+9aabh
    public byte[] DAT_9AB4; //gp+9ab4h
    public ushort DAT_9ADC; //gp+9adch
    public byte DAT_9ADE; //gp+9adeh
    public byte DAT_9ADF; //gp+9adfh
    public byte[] DAT_9EAC; //gp+9each
    public byte DAT_9EE8; //gp+9ee8h
    public byte DAT_9EE9; //gp+9ee9h
    public byte DAT_9EEA; //gp+9eeah
    public byte DAT_9EEB; //gp+9eebh
    public Vector2Int DAT_9FDC; //gp+9fdch
    public byte[] DAT_A090; //gp+a090h
    public ushort DAT_A0E0; //gp+a0e0h
    public ushort DAT_A0E2; //gp+a0e2h
    public short DAT_A0E8; //gp+a0e8h
    public sbyte DAT_A0EA; //gp+a0eah
    public short DAT_A0EC; //gp+a0ech
    public short DAT_A0EE; //gp+a0eeh
    public short playerHealth; //gp+a0f0h
    public ushort DAT_A0F2; //gp+a0f2h
    public uint DAT_A0F4; //gp+a0f4h
    public ushort[] DAT_A0F8; //gp+a0f8h
    public byte DAT_A100; //gp+a100h
    public byte DAT_A2CF; //gp+a2cfh
    public bool DAT_A2D0; //gp+a2d0h
    public bool DAT_A2D1; //gp+a2d1h
    public bool DAT_A2D2; //gp+a2d2h
    public byte DAT_A2D3; //gp+a2d3h
    public byte DAT_A2D4; //gp+a2d4h
    public Packet[] DAT_C3380;
    public Frame[] DAT_C3384;
    public Packet DAT_C3388;
    public Frame[] DAT_C338C;
    public ushort DAT_C3390;
    public Packet[] DAT_C33A0;
    public Frame[] DAT_C33A4;
    public Packet DAT_C33A8;
    public Frame[] DAT_C33AC;
    public ushort DAT_C33B0;
    public List<LoadScriptContainer> DAT_9E0A0;
    public List<ushort> DAT_AA2A0;
    public List<int> sceneIds;
    public List<LoadDoorContainer> DAT_A89A0;
    public List<Vector3> skinnedVertices; //0x800C6F90
    public List<Color> skinnedColors; //0x800C75D0
    public List<CriSkinned> skinnedList; //0x800C7C10
    public bool DAT_C7CF0; //0x800C7CF0
    public Vector3Int DAT_C7CF8; //0x800C7CF8
    public Vector3Int DAT_C7D00; //0x800C7D00
    public byte DAT_C7D08; //0x800C7D08
    public bool DAT_C7D0A; //0x800C7D0A
    public Vector3Int DAT_C7D10; //0x800C7D10
    public Vector3Int DAT_C7D18; //0x800C7D18
    public byte DAT_C7D20; //0x800C7D20
    public CoroutineLoader loader; //0x800C7D30
    public bool DAT_C7D4C; //0x800C7D4C
    public bool gameStarted;
    public bool disableColors;
    public Material[] materials;
    private bool pauseMain;
    private List<CriSkinned> tmpSkinned;
    private List<CriBone> tmpBones;

    private delegate void FUN_9CBF0();
    private delegate void FUN_9CC28();
    private delegate sbyte FUN_AA4D0(CriPlayer p, CriStatic o);
    private delegate void FUN_AA3E0(CoroutineLoader c);

    private FUN_9CBF0[] PTR_FUN_9CBF0;
    private FUN_9CC28[] PTR_FUN_9CC28;
    private FUN_AA4D0[] PTR_FUN_AA4D0;
    private FUN_AA3E0[] PTR_FUN_AA3E0;

    private byte DAT_AA3EC;
    private byte[] DAT_AA44C = new byte[]
    {
        1, 2, 2, 1, 0, 0, 0, 0, 1, 2, 1, 1, 1, 0,
        1, 1, 1, 1, 2, 1, 1, 1, 0, 1, 1, 2, 1, 0
    };
    private byte[] DAT_AA468 = new byte[]
    {
        2, 2, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1,
        2, 1, 1, 2, 1, 1, 1, 0, 1, 1, 2, 1, 0, 1
    };
    private short[] DAT_AA4A4 = new short[]
    {
        -1, 1, 1, -1
    };
    private short[] DAT_AA4AC = new short[]
    {
        1, 1, -1, -1
    };
    private sbyte[] DAT_AA4B4 = new sbyte[]
    {
        0, 1, 2, 3, 4, 0, 2, 3, 4, 1, 0, 3, 4, 1, 2, 0, 4, 1, 2, 3
    };
    private ushort[] DAT_AA4C8 = new ushort[]
    {
        0x800, 0xc00, 0, 0x400
    };
    private byte[] DAT_AA4EB = new byte[]
    {
        128, 1, 2, 0, 3
    };
    private byte[] DAT_AA4F0 = new byte[]
    {
        0, 0, 0, 1, 0, 0, 2, 0, 80, 115, 17, 0, 0, 0, 69, 0
    };

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DAT_9AB4 = new byte[8];
        DAT_A090 = new byte[256];
        DAT_A0F8 = new ushort[4];
        PTR_FUN_9CBF0 = new FUN_9CBF0[14]
        {
            FUN_47950,
            FUN_47B34,
            FUN_47BE0,
            FUN_47DE4,
            null,
            null,
            FUN_48964,
            null,
            null,
            null,
            null,
            null,
            null,
            null
        };
        PTR_FUN_9CC28 = new FUN_9CC28[2]
        {
            FUN_489A8,
            FUN_48A54
        };
        PTR_FUN_AA4D0 = new FUN_AA4D0[3]
        {
            FUN_82834,
            FUN_82BD8,
            FUN_82834
        };
        PTR_FUN_AA3E0 = new FUN_AA3E0[3]
        {
            FUN_7A030,
            FUN_7A460,
            FUN_7A604
        };
        DAT_AA3EC = 0;
    }

    private void Start()
    {
        skinnedVertices = new List<Vector3>();
        skinnedColors = new List<Color>();
        skinnedList = new List<CriSkinned>();
        todUncomp = new List<Vector3Int>();
        tmpSkinned = new List<CriSkinned>();
        tmpBones = new List<CriBone>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);

        if (Input.GetKeyDown(KeyCode.C))
            disableColors = !disableColors;

        Shader.SetGlobalFloat("_ColorIntensity", !disableColors ? 1.0f : 0.0f);
    }

    private void FixedUpdate()
    {
        if (gameStarted && !pauseMain)
            FUN_47900();
    }

    public void FUN_46C0C(int param1, uint param2, byte param3)
    {
        if (param1 == 0)
            DAT_68 = 0x10000000;
        else
        {
            if (param1 == 1)
                DAT_68 = 0;
        }

        if (param2 == 0)
            return; //trap(0x1c00)

        DAT_6D = true;
        DAT_6E = (byte)(param2 - 1);
        DAT_6C = (byte)param1;
        DAT_6F = param3;
        DAT_64 = 0x1000000 / param2;
    }

    private void FUN_475E4(int param1)
    {
        uint uVar2;

        uVar2 = (uint)(DAT_9AA4 + param1);
        DAT_9AA4 = (int)uVar2;

        if (0x14996c4 < uVar2)
            uVar2 = 0x14996c4;

        DAT_9AA4 = (int)uVar2;
    }

    private void FUN_47900()
    {
        PTR_FUN_9CBF0[DAT_28]();
    }

    private void FUN_47950()
    {
        if (!SceneManager.sceneLoaded)
            FUN_55198(); //not in the original code
        else
        {
            //FUN_1802C
            DAT_28++;
            //...
            FUN_61240();
            InventoryManager.FUN_4A7E8(4, 0, true);
            InventoryManager.FUN_4A7E8(9, 0, true);
            DialogManager.instance.FUN_1DE48();
            FUN_61374();
        }
    }

    private void FUN_47B34()
    {
        DAT_28++;
        SceneManager.instance.FUN_261BC();

        if ((DAT_46 ? 1 : 0) != DAT_9AA0 >> 8)
        {
            //FUN_55198 - originally here
            LevelManager.instance.Initialize();
        }
    }

    private void FUN_47BE0()
    {
        CriPlayer oVar3;
        CriTrigger pbVar4;
        uint uVar5;

        DAT_55 = 0;
        DAT_21 = 6;
        DAT_28++;
        FUN_6E6C8();

        if ((byte)(DAT_9AA0 >> 8) != (byte)(DAT_9ADC >> 8))
        {
            //FUN_1802C
        }

        for (int i = 0; i < 10; i++)
            SceneManager.instance.DAT_27C[i].ResetValues();

        for (int i = 0; i < 100; i++)
            SceneManager.instance.DAT_1C9C[i].ResetValues();

        for (int i = 0; i < 60; i++)
            SceneManager.instance.DAT_5FCC[i].ResetValues();

        for (int i = 0; i < 40; i++)
            SceneManager.instance.DAT_7CDC[i].ResetValues();

        for (int i = 0; i < 10; i++)
            SceneManager.instance.DAT_8FFC[i].ResetValues();

        for (int i = 0; i < 10; i++)
            SceneManager.instance.DAT_9EEC[i].ResetValues();

        for (int i = 0; i < 10; i++)
            SceneManager.instance.DAT_D7C0[i].ResetValues();

        //FUN_601A4
        //FUN_5DDD0
        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar3.screen = playerSpawnPos;
        oVar3.DAT_34 = playerSpawnPos;
        oVar3.vr.y = playerSpawnRotY;
        oVar3.DAT_48 = (sbyte)-(oVar3.screen.y / 0x1a9);
        oVar3.FUN_4CFDC();
        oVar3.materials = new Material[255];
        Tmd2ScriptableObject tmd = oVar3.cSkin;
        Material mat1 = new Material(materials[0x34]);
        Material mat2 = new Material(materials[0x3C]);
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

        if (uVar5 < SceneManager.instance.DAT_9EEC.Length)
        {
            do
            {
                pbVar4 = SceneManager.instance.DAT_9EEC[uVar5];
                uVar5++;
                pbVar4.DAT_03 &= 2;
            } while (uVar5 < SceneManager.instance.DAT_9EEC.Length);
        }

        InventoryManager.DAT_B7A5C[0] = 0;
        SceneManager.instance.FUN_553EC();
        SceneManager.instance.FUN_55548();
        SceneManager.instance.FUN_1A3A0();
        SceneManager.instance.FUN_4AEA0();
        SceneManager.instance.FUN_261E0();
        DAT_23 = true;
        FUN_46C0C(0, 20, 1);
        DAT_2A = 0;

        if ((byte)(DAT_9AA0 >> 8) == 4 && (byte)DAT_9AA0 == 9)
            DAT_28 = 9;

        SceneManager.instance.FUN_290E0();
        DAT_6D = false; //tmp
    }

    private void FUN_47DE4()
    {
        bool bVar3;

        //FUN_47438
        InventoryManager.FUN_4A7E8(1, 11, true);

        if (!DAT_6D)
        {
            if ((DAT_1f80000a & 0x800) != 0)
            {
                bVar3 = InventoryManager.FUN_4A87C(1, 2);

                if (!bVar3)
                {
                    bVar3 = InventoryManager.FUN_4A87C(2, 0x1d);
                    InventoryManager.FUN_4A7E8(2, 0x1d, bVar3 == false);
                }
            }

            if (!DAT_6D)
            {
                bVar3 = InventoryManager.FUN_4A87C(1, 2);

                if (!bVar3 && (InputManager.controllers[0].DAT_C2556 & 4) != 0)
                    InventoryManager.FUN_4A7E8(2, 0x1d, true);

                if (!DAT_6D)
                {
                    bVar3 = InventoryManager.FUN_4A87C(2, 0x1d);

                    if (!bVar3 && (DAT_1f80000a & 0x100) != 0)
                        DAT_28 = 8;
                }
            }
        }

        //FUN_18000
        bVar3 = InventoryManager.FUN_4A87C(2, 0x1d);

        if (!bVar3)
        {
            FUN_475E4(2);
            FUN_4A4FC();
        }
        else
        {
            //...
        }

        FUN_7302C();
        //FUN_18014

        if (!DAT_6D)
        {
            bVar3 = InventoryManager.FUN_4A87C(1, 11);

            if (!bVar3)
            {
                bVar3 = InventoryManager.FUN_4A87C(2, 15);

                if (!bVar3 && (DAT_1f80000a & 0x10) != 0)
                {
                    InventoryManager.FUN_4A7E8(2, 15, true);
                    DAT_39 = 4;
                }

                bVar3 = InventoryManager.FUN_4A87C(2, 15);

                if (bVar3)
                {
                    DAT_28 = 5;
                    //sound
                }
            }
        }

        if (SceneManager.instance.DAT_27C[10].DAT_3C == 7)
            DAT_28 = 4;

        //...
    }

    private void FUN_48964()
    {
        PTR_FUN_9CC28[DAT_2A]();
    }

    private void FUN_489A8()
    {
        CriPlayer oVar1;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_2C == 0)
        {
            DAT_9FDC = new Vector2Int(oVar1.screen.x, oVar1.screen.z);
            DAT_2C++;
            StartCoroutine(FUN_79FC8());
        }
        else
        {
            if (DAT_2C != 1)
                return;
        }

        //unnecessery stuff...
        SceneManager.instance.cCamera.FUN_27210();
        FUN_7302C();
    }

    private void FUN_48A54()
    {
        DAT_28 = 2;
        DAT_2A = 0;
        DAT_2C = 0;
        DAT_2E = 0;
    }

    private void FUN_4A3C4()
    {
        CriPlayer pbVar1;
        int iVar2;
        int iVar3;

        iVar3 = 10;
        iVar2 = 0;

        do
        {
            pbVar1 = (CriPlayer)SceneManager.instance.DAT_27C[iVar2];

            if ((pbVar1.flags & 1) != 0)
                LevelManager.instance.PTR_FUN_B58C0[pbVar1.tags](pbVar1);

            iVar3--;
            iVar2++;
        } while (iVar3 != -1);
    }

    public void FUN_4A4FC()
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(2, 0x14);

        if (!bVar1)
        {
            //...
            SceneManager.instance.FUN_555E8();
            //...
            LevelManager.instance.FUN_4A3C4();
            //...
            SceneManager.instance.FUN_1A8AC();

            if (DAT_28 == 6)
                return;

            DialogManager.instance.FUN_1E44C();
            //...
        }

        SceneManager.instance.cCamera.FUN_27210();
        InventoryManager.FUN_4A7E8(2, 0x10, false);
        bVar1 = InventoryManager.FUN_4A87C(1, 6);

        if (!bVar1)
            SceneManager.instance.FUN_4AEFC();
    }

    public void FUN_4A8B8(LightScriptableObject param1, ref Matrix3x3 param2, Vector3Int[] param3)
    {
        bool bVar1;
        uint puVar2;
        uint uVar3;

        param2.V00 = 0;
        param2.V01 = 0;
        param2.V02 = 0;
        param2.V10 = 0;
        param2.V11 = 0;
        param2.V12 = 0;
        param2.V20 = 0;
        param2.V21 = 0;
        param2.V22 = 0;
        //...
        puVar2 = 0;
        
        if ((param1.DAT_06 & 1) == 0)
        {
            uVar3 = param1.DAT_00;

            while (uVar3 != 0)
            {
                uVar3--;

                if (param1.DAT_24[puVar2].DAT_03 != 0)
                {
                    bVar1 = FUN_4AAD8(param1.DAT_24[puVar2], 0, ref param2, param3);

                    if (bVar1)
                    {
                        puVar2 += uVar3 + 1;
                        break;
                    }
                }

                puVar2++;
            }
        }
        else
        {
            param3[0] = param1.DAT_0C;
            param2.V00 = (short)(param1.DAT_18 << 7);
            param2.V10 = (short)(param1.DAT_19 << 7);
            param2.V20 = (short)(param1.DAT_1A << 7);
        }

        if ((param1.DAT_06 & 2) == 0)
        {
            uVar3 = param1.DAT_02;

            while (uVar3 != 0)
            {
                uVar3--;

                if (param1.DAT_24[puVar2].DAT_03 == 0 ||
                    !FUN_4AAD8(param1.DAT_24[puVar2], 1, ref param2, param3))
                    puVar2++;
            }
        }
        else
        {
            param3[0] = param1.DAT_12;
            param2.V01 = (short)(param1.DAT_1E << 7);
            param2.V11 = (short)(param1.DAT_1F << 7);
            param2.V21 = (short)(param1.DAT_20 << 7);
        }

        if ((DAT_0C.DAT_03 & 1) != 0)
            FUN_4AAD8(DAT_0C, 2, ref param2, param3);
    }

    public bool FUN_4AAD8(LightSource param1, int param2, ref Matrix3x3 param3, Vector3Int[] param4)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        bool bVar4;
        short sVar6;
        int iVar7;
        int iVar10;
        short sVar13;
        int iVar14;
        int iVar15;
        uint uVar17;
        uint uVar18;

        DAT_1f800044 = param1.DAT_04;
        iVar10 = DAT_1f800044.z;
        iVar15 = DAT_1f80002c.z;
        sVar6 = (short)DAT_1f800044.x;
        sVar13 = (short)DAT_1f80002c.x;
        iVar1 = sVar6 - sVar13;
        iVar7 = DAT_1f800044.y;
        iVar14 = DAT_1f80002c.y;
        iVar2 = iVar7 - iVar14;
        iVar3 = iVar10 - iVar15;
        uVar17 = (uint)(int)param1.DAT_0A;
        bVar4 = false;

        if ((uint)(iVar1 * iVar1 + iVar2 * iVar2 + iVar3 * iVar3) <= uVar17 * uVar17)
        {
            param3.SetValue16(param2, param1.DAT_00 << 7);
            param3.SetValue16(param2 + 3, param1.DAT_01 << 7);
            param3.SetValue16(param2 + 6, param1.DAT_02 << 7);
            iVar1 = sVar13 - sVar6;
            iVar14 -= iVar7;
            iVar15 -= iVar10;
            iVar1 = (int)Utilities.FUN_4AE0C(iVar1 * iVar1 + iVar14 * iVar14 + iVar15 * iVar15);
            DAT_1f800034_2 = Utilities.FUN_4ACF0(DAT_1f800044, DAT_1f80002c);
            Utilities.RotMatrixYXZ_gte(ref DAT_1f800034_2, ref DAT_1f80004c);
            Coprocessor.rotationMatrix.rt11 = DAT_1f80004c.V00;
            Coprocessor.rotationMatrix.rt12 = DAT_1f80004c.V01;
            Coprocessor.rotationMatrix.rt13 = DAT_1f80004c.V02;
            Coprocessor.rotationMatrix.rt21 = DAT_1f80004c.V10;
            Coprocessor.rotationMatrix.rt22 = DAT_1f80004c.V11;
            Coprocessor.rotationMatrix.rt23 = DAT_1f80004c.V12;
            Coprocessor.rotationMatrix.rt31 = DAT_1f80004c.V20;
            Coprocessor.rotationMatrix.rt32 = DAT_1f80004c.V21;
            Coprocessor.rotationMatrix.rt33 = DAT_1f80004c.V22;
            Coprocessor.vector0.vx0 = 0;
            Coprocessor.vector0.vy0 = 0;
            Coprocessor.vector0.vz0 = param1.DAT_0E;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            DAT_1f800034_2.x = Coprocessor.accumulator.ir1;
            DAT_1f800034_2.y = Coprocessor.accumulator.ir2;
            DAT_1f800034_2.z = Coprocessor.accumulator.ir3;
            uVar18 = (uint)(iVar1 << 12) / uVar17;

            if (uVar17 == 0)
                return false; //trap(0x1c00)

            Coprocessor.accumulator.ir0 = (short)(0x1000 - uVar18);
            Coprocessor.accumulator.ir1 = (short)(DAT_1f800034_2.x & 0xffff);
            Coprocessor.accumulator.ir2 = (short)(DAT_1f800034_2.y & 0xffff);
            Coprocessor.accumulator.ir3 = (short)(DAT_1f800034_2.z & 0xffff);
            Coprocessor.ExecuteGPF(12, false);
            Coprocessor.accumulator.ir0 = (short)uVar18;
            Coprocessor.accumulator.ir1 = 0;
            Coprocessor.accumulator.ir2 = 0;
            Coprocessor.accumulator.ir3 = 0;
            Coprocessor.ExecuteGPL(12, false);
            param4[param2] = new Vector3Int
                (Coprocessor.accumulator.ir1, 
                Coprocessor.accumulator.ir2, 
                Coprocessor.accumulator.ir3);
            bVar4 = true;
        }

        return bVar4;
    }

    private void FUN_55198()
    {
        DontDestroyOnLoad(gameObject);
        gameObject.AddComponent(Utilities.scriptComponents[DAT_9E0A0[DAT_9AA0 >> 8].scriptName]);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIds[DAT_9E0A0[DAT_9AA0 >> 8].DAT_02], LoadSceneMode.Single);
    }

    public void FUN_40C60(CriPlayer param1)
    {
        if ((param1.DAT_1DE & 1) != 0 && !DAT_6D)
        {
            param1.DAT_1DE &= 0xfe;
            DAT_28 = 4;
        }
    }

    private void FUN_61240()
    {
        CriPlayer oVar1;
        short sVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_9AB4[0] = 2;
        DAT_9AB4[1] = 1;
        DAT_9AB4[2] = 3;
        DAT_9AB4[3] = 0;
        DAT_9AB4[4] = 3;
        sVar3 = 1200;
        DAT_9AB4[5] = 2;

        if (difficulty != _DIFFICULTY.Normal)
            sVar3 = 2400;

        oVar1.health = sVar3;
        oVar1.DAT_240 = 0x20;
        oVar1.DAT_244[1] = 0x6ff;
        oVar1.DAT_244[0] = 0xffff;
        oVar1.DAT_244[2] = 0xffff;
        oVar1.screen.x = 0x1cf0;
        oVar1.screen.y = 0;
        oVar1.screen.z = 0xebe0;
        oVar1.vr.y = 0;
        DAT_9AAA = 5;
        //FUN_5B214

        if (DAT_9AA9 == 0)
        {
            DAT_9AAB = 0;
            DAT_A2D4 = 0;
        }

        DAT_9AA9 = 0;
    }

    public void FUN_61374()
    {
        CriPlayer oVar1;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_A0E8 = (short)oVar1.screen.x;
        DAT_A0EC = (short)oVar1.screen.z;
        DAT_A0EE = (short)oVar1.vr.y;
        playerHealth = oVar1.health;
        DAT_A0EA = oVar1.DAT_48;
        DAT_A0F4 = oVar1.DAT_1C0;
        DAT_A0F2 = oVar1.DAT_1E8;
        DAT_A100 = oVar1.DAT_240;
        DAT_A0F8[0] = oVar1.DAT_244[0];
        DAT_A0F8[1] = oVar1.DAT_244[1];
        DAT_A0F8[2] = oVar1.DAT_244[2];
        DAT_A0F8[3] = oVar1.DAT_244[3];
        //copying...
    }

    public void FUN_65C7C(CriPlayer param1)
    {
        DAT_922C |= 2;
        DAT_9230 = param1;
    }

    public void FUN_65CB0(CriPlayer param1)
    {
        if (param1 == DAT_9230)
        {
            DAT_922C &= 0xfd;
            DAT_9230 = null;
        }
    }

    public void FUN_6E6C8()
    {
        int puVar1;
        uint uVar3;
        int iVar4;
        byte[] local_10;

        local_10 = new byte[6] { 0x15, 7, 0xf, 0xe, 0x12, 0x16 };
        uVar3 = 0;

        if ((byte)(DAT_9AA0 >> 8) < 7U)
        {
            iVar4 = 0;

            if ((byte)(DAT_9AA0 >> 8) != 1)
            {
                puVar1 = 0;

                do
                {
                    uVar3++;
                    iVar4 += local_10[puVar1];
                    puVar1 = (int)uVar3;
                } while (uVar3 < (byte)(DAT_9AA0 >> 8) - 1);
            }

            iVar4 += (byte)DAT_9AA0;

            if (DAT_47 != 0x12)
            {
                if (iVar4 != 0x5a || InventoryManager.FUN_4A87C(0, 0x82))
                    InventoryManager.FUN_4A7E8(12, (uint)iVar4, true);

                if ((byte)(DAT_9AA0 >> 8) == (byte)(DAT_A0E2 >> 8) && 
                    (byte)DAT_9AA0 == (byte)DAT_A0E2)
                    DAT_A0E2 = 0;
            }
        }
    }

    public Vector2Int[] FUN_813F0(Vector2Int[] param1, WallCollider param2)
    {
        sbyte sVar1;
        int iVar3;
        short[] local_20;
        Vector2Int[] local_10;

        iVar3 = -1;
        local_20 = new short[8];

        do
        {
            sVar1 = (sbyte)iVar3;
            local_20[sVar1 + 1] = (short)(param2.DAT_04.x + param2.DAT_08.x * sVar1);
            iVar3++;
            local_20[sVar1 + 5] = (short)(param2.DAT_04.y + param2.DAT_08.y * sVar1);
        } while (iVar3 * 0x1000000 >> 0x18 < 2);

        local_10 = new Vector2Int[4];
        iVar3 = 0;

        do
        {
            sVar1 = (sbyte)iVar3;
            iVar3++;
            local_10[sVar1].x = local_20[DAT_AA44C[sVar1 + param2.DAT_00 * 4]];
            local_10[sVar1].y = local_20[DAT_AA468[sVar1 + param2.DAT_00 * 4] + 4];
        } while (iVar3 * 0x1000000 >> 0x18 < 4);

        param1[0] = local_10[0];
        param1[1] = local_10[1];
        param1[2] = local_10[2];
        param1[3] = local_10[3];
        return param1;
    }

    private void FUN_81720(CriStatic param1, Vector2Int[] param2)
    {
        int iVar3;
        BoxCollider psVar4;
        Matrix3x3 MStack64;
        Vector3Int local_48;

        MStack64 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref param1.vr, ref MStack64);
        iVar3 = 0;
        psVar4 = param1.cCollider;
        local_48 = new Vector3Int();
        local_48.y = 0;

        do
        {
            local_48.x = psVar4.DAT_00.x * DAT_AA4A4[iVar3];
            local_48.z = psVar4.DAT_00.z * DAT_AA4AC[iVar3];
            local_48 = Utilities.ApplyMatrixSV(ref MStack64, ref local_48);
            param2[iVar3].x = param1.screen.x + local_48.x;
            param2[iVar3].y = param1.screen.z + local_48.z;
            iVar3++;
        } while (iVar3 < 4);
    }

    private short[] FUN_82730(short[] param1, Vector2Int[] param2)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        int puVar9;
        uint uVar10;
        byte bVar11;

        puVar9 = 1;
        bVar11 = 0;
        uVar5 = (ushort)param2[0].x;
        uVar6 = (ushort)param2[0].y;
        uVar7 = (ushort)param2[0].x;
        uVar10 = (ushort)param2[0].y;

        do
        {
            uVar1 = (uint)param2[puVar9].x;
            uVar3 = uVar1;

            if ((short)uVar5 < (int)uVar1)
            {
                uVar1 = (uint)param2[puVar9].x;
                uVar3 = uVar5;
            }

            if ((int)uVar1 < (short)uVar7)
                uVar1 = uVar7;

            uVar2 = (uint)param2[puVar9].y;
            uVar4 = uVar2;

            if ((short)uVar6 < (int)uVar2)
            {
                uVar2 = (uint)param2[puVar9].y;
                uVar4 = uVar6;
            }

            if ((int)uVar2 < (short)uVar10)
                uVar2 = uVar10;

            bVar11++;
            puVar9++;
            uVar5 = uVar3;
            uVar6 = uVar4;
            uVar7 = uVar1;
            uVar10 = uVar2;
        } while (bVar11 < 3);

        param1[0] = (short)uVar3;
        param1[1] = (short)uVar4;
        param1[2] = (short)((short)uVar1 - (short)uVar3);
        param1[3] = (short)((short)uVar2 - (short)uVar4);
        return param1;
    }

    private sbyte FUN_82834(CriPlayer param1, CriStatic param2)
    {
        sbyte sVar1;
        ushort uVar2;
        sbyte sVar3;
        byte bVar4;
        sbyte sVar5;
        short sVar6;
        int iVar7;
        CriBone oVar7;
        uint uVar8;
        uint uVar9;
        int v0;
        Vector3Int local_88;
        short[] local_60;
        Hit local_58;
        Matrix3x3 MStack128;

        bVar4 = 0;
        local_88 = new Vector3Int(0, param1.vr.y, 0);
        MStack128 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref local_88, ref MStack128);
        v0 = param1.DAT_120;
        sVar1 = param1.DAT_12E;
        local_58 = new Hit();
        local_58.DAT_0C = new Vector2Int[4];
        FUN_81720(param2, local_58.DAT_0C);
        local_60 = new short[4];
        FUN_82730(local_60, local_58.DAT_0C);
        sVar3 = (sbyte)(sVar1 - 1);
        local_58.DAT_00 = new Vector2Int[3];

        if (sVar1 != 0)
        {
            do
            {
                local_88 = Utilities.ApplyMatrixSV(ref MStack128, ref param1.PTR_120[v0].pos);

                if (param1.PTR_120[v0].bone == -1)
                {
                    local_58.DAT_00[1].x = param1.screen.z + local_88.z;
                    local_58.DAT_00[0].x = param1.DAT_34.z + local_88.z;
                    uVar2 = (ushort)param1.screen.y;
                }
                else
                {
                    oVar7 = (CriBone)Utilities.FUN_601C8(param1.skeleton, param1.PTR_120[v0].bone);
                    local_58.DAT_00[0].x = oVar7.DAT_4C.x + local_88.x;
                    local_58.DAT_00[0].y = oVar7.DAT_4C.z + local_88.z;
                    local_58.DAT_00[1].x = oVar7.screen.x + local_88.x;
                    local_58.DAT_00[1].y = oVar7.screen.z + local_88.z;
                    uVar2 = (ushort)oVar7.screen.y;
                }

                uVar8 = (ushort)local_88.y;
                uVar9 = (ushort)param1.PTR_120[v0].radius;

                if (((uint)((local_58.DAT_00[1].x + (int)uVar9) - local_60[0]) < (ushort)local_60[2] + uVar9 * 2 &&
                    (uint)((local_58.DAT_00[1].y + (int)uVar9) - local_60[1]) < (ushort)local_60[3] + uVar9 * 2) ||
                    FUN_841E8(local_58.DAT_0C, local_58.DAT_00, ref local_88) != 0)
                {
                    if (param2.cCollider.DAT_00.y < 0)
                        sVar6 = (short)(param2.screen.y - param2.cCollider.DAT_00.y);
                    else
                        sVar6 = (short)param2.screen.y;

                    iVar7 = ((int)((uVar2 + uVar8) * 0x10000) >> 0x10) - sVar6;

                    if (iVar7 < 0)
                    {
                        uVar8 = (uint)param2.cCollider.DAT_00.y;

                        if ((int)uVar8 < 0)
                            uVar8 = (uint)-(int)uVar8;
                    }
                    else
                        uVar8 = param1.PTR_120[v0].height;

                    if (iVar7 < 0)
                        iVar7 = -iVar7;

                    if (iVar7 < (int)uVar8)
                    {
                        bVar4 = (byte)FUN_839D0(local_58);

                        if (bVar4 != 0)
                            sVar3 = 0;
                    }
                }

                sVar3--;
                v0++;
            } while (sVar3 != -1);
        }

        if (bVar4 != 0)
        {
            param1.screen.x += local_58.DAT_00[2].x;
            param1.screen.z += local_58.DAT_00[2].y;
            param1.DAT_14C.x += local_58.DAT_00[2].x;
            param1.DAT_14C.z = local_58.DAT_00[2].y;

            if ((param1.DAT_152 & 1) != 0)
            {
                param1.DAT_154.DAT_14C.x = param1.DAT_14C.x;
                param1.DAT_154.DAT_14C.z = param1.DAT_14C.z;
                param1.FUN_65714();
                param1.DAT_154.FUN_65714();
            }

            param1.FUN_66208();
        }

        sVar5 = -1;

        if (bVar4 != 0xff)
            sVar5 = DAT_AA4B4[bVar4 + ((ushort)param2.vr.y << 0x10 >> 0x1a) * 5];

        return sVar5;
    }

    public sbyte FUN_82BD8(CriPlayer param1, CriStatic param2)
    {
        byte bVar1;
        bool bVar2;
        CriBone oVar2;
        int v0;
        Vector4Int local_50;
        Vector4Int local_48;
        Vector3Int local_40;
        Vector2Int local_38;
        Matrix3x3 MStack48;

        local_50 = new Vector4Int();
        local_50.x = param2.screen.x;
        local_50.y = param2.screen.y;
        local_50.z = param2.screen.z;
        local_50.w = (short)param2.cCollider.DAT_00.y;
        v0 = param1.DAT_120;
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref param1.vr, ref MStack48);

        while (true)
        {
            local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref param1.PTR_120[v0].pos);
            local_48 = new Vector4Int();

            if (param1.PTR_120[v0].bone == -1)
            {
                local_48.x = param1.screen.x + local_40.x;
                local_48.y = param1.screen.y + local_40.y;
                local_48.z = param1.screen.z;
            }
            else
            {
                oVar2 = (CriBone)Utilities.FUN_601C8(param1.skeleton, param1.PTR_120[v0].bone);
                local_48.x = oVar2.screen.x + local_40.x;
                local_48.y = oVar2.screen.y + local_40.y;
                local_48.z = oVar2.screen.x;
            }

            local_48.z += local_40.z;
            local_38 = new Vector2Int();
            bVar2 = Utilities.FUN_61FDC(local_50, local_48, ref local_38);

            if (bVar2) break;

            bVar1 = param1.PTR_120[v0].flags;

            if ((bVar1 & 0x80) != 0)
                return 0;

            v0++;
        }

        param1.screen.x = local_38.x;
        param1.screen.z = local_38.y;
        return 1;
    }

    public bool FUN_82EFC(CriPlayer param1, ref CriStatic param2, ref byte param3)
    {
        byte bVar1;
        short sVar2;
        bool bVar3;
        int iVar4;
        BoxCollider psVar5;
        uint uVar6;
        int iVar7;
        uint uVar8;
        byte bVar9;
        int iVar10;
        CriStatic oVar10;
        short[] local_128;
        byte[] local_e0;
        CriStatic[] local_b8;

        if ((param1.DAT_12C & 8) == 0)
        {
            bVar9 = 0;

            if (param1.PTR_120 != null)
            {
                local_128 = new short[36];
                local_e0 = new byte[40];
                local_b8 = new CriStatic[36];

                for (int i = 0; i < SceneManager.instance.DAT_7CDC.Length; i++)
                {
                    oVar10 = SceneManager.instance.DAT_7CDC[i];

                    if ((oVar10.flags & 1) != 0)
                    {
                        psVar5 = oVar10.cCollider;

                        if (psVar5 != null && 
                            psVar5.DAT_00.x != 0 && psVar5.DAT_00.y != 0 && psVar5.DAT_00.z != 0)
                        {
                            bVar1 = (byte)PTR_FUN_AA4D0[psVar5.DAT_06](param1, oVar10);
                            uVar6 = bVar1;

                            if (uVar6 != 0 && uVar6 != 0xff)
                            {
                                uVar8 = bVar9;
                                local_b8[uVar8] = oVar10;
                                local_e0[uVar8] = bVar1;
                                bVar9++;
                                sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 0x800, DAT_AA4C8[uVar6 - 1]);
                                local_128[uVar8] = sVar2;
                            }
                        }
                    }
                }

                bVar1 = (byte)(bVar9 - 1);

                if (bVar9 != 0)
                {
                    iVar7 = 0x1000;

                    if (bVar1 != 0xff)
                    {
                        iVar10 = 0x10000000;
                        bVar9 = bVar1;

                        do
                        {
                            iVar4 = local_128[bVar9];

                            if (iVar4 < 0)
                                iVar4 = -iVar4;

                            if (iVar4 < iVar10 >> 0x10)
                            {
                                iVar7 = local_128[bVar9];
                                bVar1 = bVar9;

                                if (iVar7 < 0)
                                    iVar7 = -iVar7;
                            }

                            bVar9--;
                            iVar10 = iVar7 << 0x10;
                        } while (bVar9 != 0xff);
                    }

                    param3 = local_e0[bVar1];
                    bVar3 = true;
                    param2 = local_b8[bVar1];
                }
            }
        }

        bVar3 = false;
        return bVar3;
    }

    public uint FUN_8383C(uint param1)
    {
        uint uVar1;
        uint uVar2;

        uVar2 = 0;

        if ((param1 & 0xff) != 0)
        {
            uVar1 = param1 & 1;

            do
            {
                uVar2 += uVar1;
                param1 = (param1 & 0xff) >> 1;
                uVar1 = param1 & 1;
            } while (param1 != 0);
        }

        return uVar2 & 0xff;
    }

    private uint FUN_83868(Hit param1, Vector2Int param2)
    {
        uint uVar3;
        uint uVar6;
        Vector3Int local_40;
        Vector3Int local_30;

        uVar6 = 0;
        uVar3 = 0;

        if (param1.DAT_2F != 0)
        {
            do
            {
                if ((param1.DAT_30 >> (int)(uVar3 + 4 & 0x1f) & 1) == 0)
                {
                    local_40 = new Vector3Int();
                    local_30 = new Vector3Int();
                    local_40.x = param2.x - param1.DAT_0C[uVar3].x >> 1;
                    local_40.z = param2.y - param1.DAT_0C[uVar3].y >> 1;
                    local_30.x = param1.DAT_0C[(uVar3 * 2 + 2 & 6) * 2 / 4].x - param1.DAT_0C[uVar3].x >> 1;
                    local_30.y = 0;
                    local_40.y = 0;
                    local_30.z = param1.DAT_0C[(uVar3 * 2 + 3 & 7) * 2 / 4].y - param1.DAT_0C[uVar3].y >> 1;
                    local_30 = Utilities.OuterProduct0(ref local_40, ref local_30);

                    if (-1 < local_30.y)
                        uVar6 = uVar6 | 1U << (int)(uVar3 & 0x1f);
                }

                uVar3++;
            } while ((int)uVar3 < param1.DAT_2F);
        }

        return uVar6 & 0xff;
    }

    public sbyte FUN_839D0(Hit param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar2;
        short sVar3;
        uint uVar4;
        uint uVar5;
        int iVar6;
        long lVar7;
        int iVar8;
        int puVar10;
        short sVar12;
        uint uVar13;
        uint uVar14;
        int iVar17;
        Vector4Int local_a0;
        Vector4Int local_98;
        Vector4Int local_90;
        Matrix3x3 MStack136;
        Vector2Int[] local_68;
        ushort local_60;
        ushort local_58;
        Vector4Int local_50;
        sbyte local_48;
        bool local_40;
        int local_3c;
        int local_38;
        int local_34;
        int local_30;
        Vector3Int temp;

        local_38 = 0;
        local_3c = 0;
        local_48 = 0;
        local_50 = new Vector4Int();
        local_50.x = param1.DAT_00[0].x;
        iVar17 = 0;
        local_50.z = param1.DAT_00[0].y;
        uVar13 = 0;
        local_60 = (ushort)param1.DAT_00[1].x;
        local_58 = (ushort)param1.DAT_00[1].y;
        local_50.y = (short)local_60;
        local_50.w = (short)local_58;
        uVar4 = FUN_83868(param1, param1.DAT_00[0]);

        if ((uVar4 & 0xff) == 0)
        {
            param1.DAT_00[2].x = param1.DAT_00[1].x - param1.DAT_00[0].x;
            param1.DAT_00[2].y = param1.DAT_00[1].y - param1.DAT_00[0].y;
            return -1;
        }

        sVar2 = (sbyte)FUN_8383C(uVar4 & 0xff);
        uVar5 = uVar4 & 0xff;

        if (sVar2 == 2)
        {
            uVar5 = 0;
            uVar14 = 1;
            puVar10 = 0;
            local_a0 = new Vector4Int();
            local_a0.x = param1.DAT_00[1].x;
            local_a0.z = param1.DAT_00[1].y;
            local_a0.w = param1.DAT_2C;
            local_40 = FUN_768C8((Vector3Int)local_a0, param1.DAT_0C);
            local_68 = new Vector2Int[2];

            do
            {
                if (((int)(uVar4 & 0xff) >> (int)(uVar5 & 0x1f) & 1) != 0)
                {
                    local_68[0] = param1.DAT_0C[uVar5];
                    local_68[1] = param1.DAT_0C[uVar14 & 3];

                    if (!local_40)
                        bVar2 = FUN_84338(local_68, local_a0);
                    else
                        bVar2 = FUN_84008(param1.DAT_00, local_68, ref local_a0);

                    if (!bVar2)
                        uVar4 = uVar4 & ~(1U << (int)(uVar5 & 0x1f));
                }

                uVar14++;
                uVar5++;
            } while ((int)uVar5 < 4);

            sVar2 = (sbyte)FUN_8383C(uVar4 & 0xff);
            uVar5 = uVar4 & 0xff;

            if (sVar2 == 2)
            {
                uVar4 = FUN_83868(param1, param1.DAT_00[1]);
                sVar2 = (sbyte)FUN_8383C(uVar4 & 0xff);
                uVar5 = uVar4 & 0xff;

                if (sVar2 == 2)
                {
                    bVar1 = param1.DAT_2E;

                    if (bVar1 < 6)
                    {
                        if (bVar1 == 0)
                            bVar1 = DAT_AA4EB[(uVar4 & 0xff) / 3];
                        else
                            bVar1 = DAT_AA4F0[uVar4 & 0xff];

                        puVar10 += bVar1;
                    }
                    else
                    {
                        if (bVar1 == 6)
                        {
                            bVar1 = DAT_AA4EB[(uVar4 & 0xff) / 3];
                            puVar10 += bVar1;
                        }
                    }

                    local_a0.x = param1.DAT_0C[puVar10].x;
                    iVar17 = ((local_60 - (ushort)local_a0.x) * 0x10000) >> 0x10;
                    local_a0.y = param1.DAT_0C[puVar10].y;
                    iVar6 = ((local_58 - (ushort)local_a0.y) * 0x10000) >> 0x10;
                    local_a0.z = (short)local_60;
                    local_a0.w = (short)local_58;
                    uVar4 = (uint)Utilities.SquareRoot0(iVar17 * iVar17 + iVar6 * iVar6);
                    local_a0.y = Utilities.FUN_61620(local_a0);

                    if (!local_40)
                    {
                        if (param1.DAT_2C < uVar4)
                            return 0;

                        sVar12 = (short)(param1.DAT_2C - uVar4 + 5);
                    }
                    else
                        sVar12 = (short)(uVar4 + 5 + param1.DAT_2C);

                    local_a0.z = 0;
                    local_a0.x = 0;
                    MStack136 = new Matrix3x3();
                    temp = (Vector3Int)local_a0;
                    Utilities.RotMatrix_gte(ref temp, ref MStack136);
                    local_a0.y = 0;
                    local_a0.x = 0;
                    local_a0.z = sVar12;
                    temp = (Vector3Int)local_a0;
                    temp = Utilities.ApplyMatrixSV(ref MStack136, ref temp);
                    local_a0.x = temp.x;
                    local_a0.y = temp.y;
                    local_a0.z = temp.z;
                    param1.DAT_00[2].x = local_a0.x;
                    local_48 = -2;
                    goto LAB_83FD4;
                }
            }
        }

        if (uVar5 == 0)
            return 0;

        local_90 = new Vector4Int();
        local_98 = new Vector4Int();
        local_98.x = local_50.x;
        local_98.y = local_50.z;
        local_98.z = local_50.y;
        local_98.w = local_50.w;
        uVar5 = 0;

        if (param1.DAT_2F != 0)
        {
            local_34 = (short)local_60;
            local_30 = (short)local_58;

            do
            {
                if (((int)(uVar4 & 0xff) >> (int)(uVar5 & 0x1f) & 1) != 0)
                {
                    local_90.x = param1.DAT_0C[uVar5].x;
                    local_90.y = param1.DAT_0C[uVar5].y;
                    local_90.z = param1.DAT_0C[(uVar5 * 2 + 2 & 7) / 2].x;
                    local_90.w = param1.DAT_0C[(uVar5 * 2 + 3 & 7) / 2].y;
                    iVar17 = local_90.w - local_90.y + 1;
                    local_3c = local_90.x - local_90.z + 1;
                    local_38 = local_90.z * local_90.y - local_90.x * local_90.w;
                    lVar7 = Utilities.SquareRoot0(iVar17 * iVar17 + local_3c * local_3c);
                    local_48 = (sbyte)uVar5;
                    iVar8 = iVar17 * local_34 + local_3c * local_30 + local_38;

                    if (iVar8 < 0)
                        iVar8 = -iVar8;

                    if (lVar7 == 0)
                        return 0; //trap(0x1c00)

                    if (lVar7 == -1 && iVar8 == -0x80000000)
                        return 0; //trap(0x1800)

                    uVar13 = (uint)(iVar8 / (int)lVar7);
                }

                uVar5++;
            } while ((int)uVar5 < param1.DAT_2F);
        }

        if (iVar17 * (short)local_60 + local_3c * (short)local_58 + local_38 < 0)
        {
            if (param1.DAT_2C < uVar13)
                return 0;

            sVar12 = (short)(param1.DAT_2C - uVar13 + 5);
        }
        else
            sVar12 = (short)(uVar13 + 5 + param1.DAT_2C);

        local_a0 = new Vector4Int();
        local_a0.z = 0;
        local_a0.x = 0;
        sVar3 = (short)Utilities.FUN_61620(local_90);
        local_a0.y = sVar3 - 0x400 & 0xfff;
        MStack136 = new Matrix3x3();
        temp = (Vector3Int)local_a0;
        Utilities.RotMatrix_gte(ref temp, ref MStack136);
        local_a0.y = 0;
        local_a0.x = 0;
        local_a0.z = sVar12;
        temp = (Vector3Int)local_a0;
        temp = Utilities.ApplyMatrixSV(ref MStack136, ref temp);
        local_a0.x = temp.x;
        local_a0.y = temp.y;
        local_a0.z = temp.z;
        param1.DAT_00[2].x = local_a0.x;
        local_48++;
        LAB_83FD4:
        param1.DAT_00[2].y = local_a0.z;
        return local_48;
    }

    public bool FUN_84008(Vector2Int[] param1, Vector2Int[] param2, ref Vector4Int param3)
    {
        short sVar1;
        short sVar2;
        int iVar3;
        int iVar4;
        bool bVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        int iVar10;

        iVar10 = param1[1].x - param1[0].x;
        iVar9 = param2[1].y - param2[0].y;
        iVar8 = param1[1].y - param1[0].y;
        iVar3 = param2[1].x - param2[0].x;
        sVar1 = (short)param1[1].y;
        sVar2 = (short)param1[0].y;
        iVar7 = iVar10 * iVar9 - iVar8 * iVar3;
        iVar6 = param1[0].y - param2[0].y;

        if (iVar7 == 0)
            bVar5 = false;
        else
        {
            bVar5 = false;
            iVar4 = param1[0].x - param2[0].x;
            iVar3 = iVar6 * iVar3 - iVar4 * iVar9;
            iVar6 = iVar6 * iVar10 - iVar4 * iVar8;

            if (((0 < iVar7 && -1 < iVar3 && iVar3 <= iVar7) ||
                (iVar7 < 0 && iVar7 <= iVar3 && iVar3 < 1)) &&
                ((0 < iVar7 && -1 < iVar6 && iVar6 <= iVar7) ||
                (iVar7 < 0 && iVar7 <= iVar6 && iVar6 < 1)))
            {
                if (iVar7 == 0)
                    return false; //trap(0x1c00)

                if (iVar7 == -1 && iVar3 * 100 == -0x80000000)
                    return false; //trap(0x1800)

                iVar6 = (iVar3 * 100) / iVar7;
                bVar5 = true;
                param3.x = param1[0].x + (((param1[1].x - param1[0].x) * iVar6) / 100);
                param3.z = sVar2 + (((sVar1 - sVar2) * iVar6) / 100);
            }
        }

        return bVar5;
    }

    public sbyte FUN_841E8(Vector2Int[] param1, Vector2Int[] param2, ref Vector3Int param3)
    {
        bool bVar1;
        uint uVar3;
        byte bVar4;
        Vector2Int[] local_48;
        Vector3Int local_40;
        Vector3Int local_30;
        Vector4Int local_20;

        bVar4 = 0;
        uVar3 = 0;
        local_48 = new Vector2Int[2];
        local_20 = new Vector4Int();
        local_40 = new Vector3Int();
        local_30 = new Vector3Int();

        do
        {
            local_48[0] = param1[uVar3];
            local_48[1] = param1[(uVar3 * 2 + 2 & 7) * 2 / 4];
            bVar1 = FUN_84008(param2, local_48, ref local_20);

            if (bVar1)
            {
                local_40.x = param2[0].x - local_48[0].x;
                local_30.z = local_48[1].y - local_48[0].y;
                local_30.y = 0;
                local_40.y = 0;
                local_30.x = local_48[1].x - local_48[0].x;
                local_40.z = param2[0].y - local_48[0].y;
                local_30 = Utilities.OuterProduct0(ref local_40, ref local_30);

                if (-1 < local_30.y)
                {
                    param3.x = local_20.x;
                    param3.z = local_20.z;
                    return (sbyte)(bVar4 + 1);
                }
            }

            bVar4++;
            uVar3 = bVar4;
        } while (bVar4 < 4U);

        return 0;
    }

    public bool FUN_84338(Vector2Int[] param1, Vector4Int param2)
    {
        short sVar1;
        bool bVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        Vector3Int local_28;
        Vector3Int local_18;

        iVar5 = param2.x - param1[0].x;
        iVar4 = param2.z - param1[0].y;
        uVar6 = (uint)(param2.w * param2.w);
        bVar2 = true;

        if (uVar6 < (uint)(iVar5 * iVar5 + iVar4 * iVar4))
        {
            iVar5 = param2.x - param1[1].x;
            iVar4 = param2.z - param1[1].y;
            local_18 = new Vector3Int();
            local_18.x = param1[1].x - param1[0].x;

            if (uVar6 < (uint)(iVar5 * iVar5 + iVar4 * iVar4))
            {
                local_18.y = 0;
                local_18.z = param1[1].y - param1[0].y;
                local_28 = new Vector3Int();
                local_28.x = param2.x - param1[0].x;
                local_28.y = 0;
                local_28.z = param2.z - param1[0].y;

                if ((local_28.x * local_18.x + local_28.z * local_18.z ^
                    (param2.x - param1[1].x) * local_18.x +
                    (param2.z - param1[1].y) * local_18.z) < 0)
                {
                    iVar4 = local_18.x;

                    if (local_18.x < 0)
                        iVar4 = -local_18.x;

                    iVar5 = local_18.z;

                    if (local_18.z < 0)
                        iVar5 = -local_18.z;

                    lVar3 = Utilities.SquareRoot0(iVar4 * iVar4 + iVar5 * iVar5);
                    sVar1 = (short)param2.w;
                    local_28 = Utilities.OuterProduct0(ref local_28, ref local_18);

                    if (local_28.y < 0)
                        local_28.y = -local_28.y;

                    if ((uint)local_28.y <= (uint)(lVar3 * sVar1))
                        return true;
                }

                bVar2 = false;
            }
            else
                bVar2 = true;
        }

        return bVar2;
    }

    public bool FUN_844FC(Vector4Int param1, Vector4Int param2, ref Vector4Int param3)
    {
        short sVar1;
        short sVar2;
        long lVar3;
        bool bVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        int iVar8;

        iVar8 = param1.x - param2.x;
        iVar7 = param1.z - param2.z;
        sVar1 = (short)param1.w;
        sVar2 = (short)param2.w;
        lVar3 = Utilities.SquareRoot0(iVar8 * iVar8 + iVar7 * iVar7);
        iVar6 = (sVar1 + sVar2) - (int)lVar3;

        if (iVar6 < 1)
            bVar4 = false;
        else
        {
            iVar5 = (int)(lVar3 + 1);

            if (iVar5 == 0)
                return false; //trap(0x1c00)

            if (iVar5 == -1 && iVar8 * iVar6 == -0x80000000)
                return false; //trap(0x1800)

            if (iVar5 == 0)
                return false; //trap(0x1c00)

            if (iVar5 == -1 && iVar7 * iVar6 == -0x80000000)
                return false; //trap(0x1800)

            bVar4 = true;
            param3.x = iVar8 * iVar6 / iVar5;
            param3.z = iVar7 * iVar6 / iVar5;
        }

        return bVar4;
    }

    public void FUN_7669C(CriTrigger[] param1, int param2)
    {
        bool bVar1;
        uint uVar2;
        CriTrigger pcVar3;
        int pcVar4;
        uint uVar5;

        pcVar4 = param2 - 1;
        uVar5 = 0;

        if (DAT_9AB4[pcVar4] != 0)
        {
            do
            {
                if (9 < uVar5)
                    return;

                pcVar3 = param1[uVar5];

                if (pcVar3.DAT_02 != 0)
                {
                    bVar1 = InventoryManager.FUN_4A87C(4, pcVar3.DAT_02);

                    if (bVar1)
                    {
                        uVar2 = FUN_64650();

                        if ((uVar2 & 1) != 0)
                        {
                            InventoryManager.FUN_4A7E8(4, pcVar3.DAT_02, false);
                            DAT_9AB4[pcVar4]--;
                        }
                    }
                }

                uVar5++;
            } while (DAT_9AB4[pcVar4] != 0);
        }
    }

    public void FUN_767A8()
    {
        CriParticle oVar1;

        oVar1 = SceneManager.instance.FUN_5FFA0();
        oVar1.DAT_65 = 0x80;
        oVar1.tags = 1;
        oVar1.DAT_54 = 0x7df4;
        oVar1.DAT_56 = 0x1e;
        oVar1.DAT_50.a = 0x1e;
        oVar1.screen = new Vector3Int(0xa0, 0xdc, 1);
        oVar1.flags |= 2;
        //FUN_606A8
        DAT_7C = 1;
        DAT_78 = 0;
    }

    public int FUN_7683C()
    {
        DAT_7C = 0;
        return DAT_78;
    }

    public bool FUN_768C8(Vector3Int param1, Vector2Int[] param2)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;

        iVar6 = param2[0].x;
        iVar4 = param2[0].y;
        iVar5 = param1.z - iVar4;
        iVar3 = param1.x - iVar6;

        if ((param2[1].x - iVar6) * iVar5 <= (param2[1].y - iVar4) * iVar3 && 
            (param2[3].y - iVar4) * iVar3 <= (param2[3].x - iVar6) * iVar5)
        {
            iVar2 = param2[2].y - iVar4;
            iVar1 = param2[2].x - iVar6;

            if ((param2[1].y - iVar4 - iVar2) * (iVar3 - iVar1) <=
                (param2[1].x - iVar6 - iVar1) * (iVar5 - iVar2) &&
                (param2[3].x - iVar6 - iVar1) * (iVar5 - iVar2) <=
                (param2[3].y - iVar4 - iVar2) * (iVar3 - iVar1))
                return true;
        }

        return false;
    }

    private uint FUN_769B0(CriSkinned param1, WaypointContainer param2, sbyte[] param3, Vector2Int param4, Vector3Int param5)
    {
        byte bVar1;
        uint uVar2;
        bool bVar3;
        bool bVar4;
        int iVar4;
        long lVar5;
        ushort uVar6;
        int psVar7;
        int iVar8;
        ushort uVar9;
        int puVar10;
        uint uVar11;
        int iVar12;
        uint uVar13;
        int iVar14;
        int iVar15;
        Vector3Int local_180;
        Vector3Int local_178;
        Vector2Int[] local_170;
        Vector2Int[] local_168;
        ushort[] local_158;
        byte[] local_98;
        byte[] local_88;
        byte local_70;
        byte local_68;
        ushort local_60;
        ushort local_58;
        int local_50;
        short local_48;
        short local_40;
        short local_38;
        short local_36;
        byte local_30;
        Vector4Int auStack352;

        local_50 = 0x7fffffff;
        local_36 = 0;
        local_38 = 0;
        local_30 = 0;
        local_40 = 0;
        local_48 = 0;
        local_70 = (byte)param3[1];
        iVar12 = (byte)param3[1] * 24;
        uVar11 = param2.OFF_02[iVar12 + 20];
        local_68 = (byte)param3[0];
        uVar6 = (ushort)param4.x;
        local_60 = uVar6;
        uVar9 = (ushort)param4.y;
        uVar13 = 0;
        local_58 = uVar9;
        local_98 = new byte[16];
        local_88 = new byte[16];

        if (uVar11 != 0)
        {
            do
            {
                if ((uVar11 & 1) != 0)
                {
                    psVar7 = param2.OFF_02[iVar12 + (uVar13 & 0xff) / 2 + 4];
                    psVar7 = ((uVar13 & 0xff) % 2 == 0 ? psVar7 & 0xff : psVar7 >> 8) * 4;
                    iVar8 = (short)param2.OFF_04[psVar7] - (short)uVar6;
                    iVar4 = (short)param2.OFF_04[psVar7 + 1] - (short)uVar9;
                    lVar5 = Utilities.SquareRoot0(iVar8 * iVar8 + iVar4 * iVar4);
                    local_98[uVar13 & 0xff] = (byte)(lVar5 >> 8);
                }

                uVar11 >>= 1;
                uVar13++;
            } while (uVar11 != 0);
        }

        iVar12 = local_68 * 24;
        uVar11 = param2.OFF_02[iVar12 + 20];
        uVar13 = 0;

        while (uVar11 != 0)
        {
            if ((uVar11 & 1) != 0)
            {
                psVar7 = param2.OFF_02[iVar12 + (uVar13 & 0xff) / 2 + 4];
                psVar7 = ((uVar13 & 0xff) % 2 == 0 ? psVar7 & 0xff : psVar7 >> 8) * 4;
                iVar8 = (short)param2.OFF_04[psVar7] - param5.x;
                iVar4 = (short)param2.OFF_04[psVar7 + 1] - param5.z;
                lVar5 = Utilities.SquareRoot0(iVar8 * iVar8 + iVar4 * iVar4);
                local_88[uVar13 & 0xff] = (byte)(lVar5 >> 8);
            }

            uVar11 >>= 1;
            uVar13++;
        }

        local_158 = new ushort[16];
        local_158[3] = (ushort)(1 << (local_68 & 0x1f));
        local_158[2] = param2.OFF_02[iVar12 + 20];
        local_158[0] = (ushort)param5.x;
        local_158[4] = 0;
        local_158[5] = (ushort)(local_68 | 0xff00);
        local_158[1] = (ushort)param5.z;
        uVar11 = local_68;
        puVar10 = 0;

        while(local_158[2] != 0 || puVar10 != 0)
        {
            iVar12 = 0;

            if ((uVar11 & 0xff) == local_70)
            {
                iVar12 = local_98[(byte)local_158[puVar10 - 1]] + local_158[puVar10 + 4];

                if (iVar12 < local_50)
                {
                    local_50 = iVar12;
                    local_158[puVar10 + 6] = local_60;
                    local_158[puVar10 + 7] = local_58;
                    local_48 = (short)local_158[6];
                    local_40 = (short)local_158[7];
                    local_30 = (byte)(local_158[11] >> 8);
                    local_38 = (short)local_158[12];
                    local_36 = (short)local_158[13];
                }
            }

            if (local_158[puVar10 + 2] == 0 || iVar12 != 0)
            {
                puVar10 -= 6;
                uVar11 = (byte)local_158[puVar10 + 5];
            }
            else
            {
                uVar13 = 0;

                if ((local_158[puVar10 + 2] & 1) == 0)
                {
                    uVar2 = 0;

                    do
                    {
                        uVar13 = uVar2;
                        uVar2 = uVar13 + 1;
                    } while ((local_158[puVar10 + 2] >> (int)(uVar13 & 0x1f) & 1) == 0);
                }

                local_158[puVar10 + 2] &= (ushort)~(1 << (int)(uVar13 & 0x1f));

                if ((uVar11 & 0xff) == local_68)
                    local_158[puVar10 + 10] = local_88[uVar13 & 0xff];
                else
                {
                    iVar12 = (int)(uVar11 & 0xff) * 24;
                    iVar14 = param2.OFF_02[iVar12 + local_158[puVar10 - 1] / 2 + 12];
                    iVar14 = (byte)(local_158[puVar10 - 1] % 2 == 0 ? iVar14 : iVar14 >> 8);
                    iVar15 = param2.OFF_02[iVar12 + (uVar13 & 0xff) / 2 + 12];
                    iVar15 = (byte)((uVar13 & 0xff) % 2 == 0 ? iVar15 : iVar15 >> 8);
                    local_158[puVar10 + 10] = param2.OFF_06[param2.OFF_02[iVar12 + 21] +
                        (iVar14 * (byte)param2.OFF_02[iVar12 + 22] & 0xff) + iVar15];
                }

                iVar12 = (int)(uVar13 & 0xff) * 24;
                local_158[puVar10 + 10] += local_158[puVar10 + 4];
                uVar6 = (ushort)(local_158[puVar10 + 3] | (1 << (int)(uVar13 & 0x1f)));
                local_158[puVar10 + 9] = uVar6;
                local_158[puVar10 + 8] = (ushort)(param2.OFF_02[iVar12 + 20] & ~uVar6);
                iVar14 = param2.OFF_02[iVar12 + (uVar11 & 0xff) / 2 + 4];
                bVar1 = (byte)((uVar11 & 0xff) % 2 == 0 ? iVar14 : iVar14 >> 8);
                local_158[puVar10 + 11] = (ushort)((byte)uVar13 | (bVar1 & 0xff00));
                local_158[puVar10 + 6] = param2.OFF_04[bVar1 * 4];
                uVar6 = param2.OFF_04[bVar1 * 4 + 1];
                local_158[puVar10 + 7] = uVar6;
                uVar11 = uVar13;
                puVar10 += 6;
            }
        }

        if (local_50 == 0x7fffffff)
            return 0xffff00ff;

        local_180 = new Vector3Int(local_38, 0, local_36);
        local_178 = FUN_77128(param5, local_180, param1.DAT_146);
        iVar14 = local_30 * 4;
        iVar12 = param2.OFF_04[iVar14 + 2] - param1.DAT_146;

        if (iVar12 < 0)
            iVar12 = 100;

        local_170 = new Vector2Int[2];
        local_168 = new Vector2Int[2];
        local_170[1].y = iVar12;

        if ((byte)param2.OFF_04[iVar14 + 3] == 0)
        {
            local_170[0].x = local_48 + local_170[1].y;
            local_170[1].x = local_48 - local_170[1].y;
            local_170[0].y = local_40;
            local_170[1].y = local_40;
        }
        else
        {
            local_170[0].x = local_48;
            local_170[1].x = local_48;
            local_170[0].y = local_40 + local_170[1].y;
            local_170[1].y = local_40 - local_170[1].y;
        }

        local_168[0].x = param5.x + local_178.x;
        local_168[1].y = local_180.z;
        local_168[0].y = param5.y + local_178.z;
        local_168[1].x = local_180.x;
        auStack352 = new Vector4Int();
        bVar4 = FUN_84008(local_170, local_168, ref auStack352);

        if (bVar4)
        {
            local_168[0].x += local_178.x * -2;
            local_168[0].y += local_178.z * -2;
            bVar4 = FUN_84008(local_170, local_168, ref auStack352);

            if (bVar4)
            {
                param1.DAT_10C.x = local_38;
                goto LAB_770C0;
            }
        }
        
        if ((byte)param2.OFF_04[iVar14 + 3] == 0)
        {
            if ((uint)(local_170[0].x - param5.x) < (uint)(iVar12 << 1))
            {
                param1.DAT_10C.z = local_40;
                param1.DAT_10C.x = param1.screen.x;
                return (uint)(local_50 << 0x10 | 1);
            }
        }
        else
        {
            if ((uint)(local_170[0].y - param5.z) < (uint)(iVar12 << 1))
            {
                param1.DAT_10C.x = local_48;
                param1.DAT_10C.z = param1.screen.z;
                return (uint)(local_50 << 0x10 | 1);
            }
        }

        local_180.x = local_48;
        local_180.z = local_40;
        local_178 = FUN_77128(param5, local_180, param1.DAT_146);
        bVar1 = local_68;
        uVar6 = (ushort)-local_178.x;
        uVar9 = (ushort)-local_178.z;
        bVar3 = FUN_773F0((short)(((param5.x + local_178.x) * 0x10000) >> 0x10),
                          (short)(((param5.z + local_178.z) * 0x10000) >> 0x10),
                          (byte)param1.DAT_48, local_68);

        if (!bVar3)
        {
            param1.DAT_10C.x = local_48 + (short)uVar6;
            param1.DAT_10C.z = local_40 + (short)uVar9;
            return (uint)(local_50 << 0x10 | 1);
        }
        else
        {
            bVar3 = FUN_773F0((short)(((param5.x - local_178.x) * 0x10000) >> 0x10),
                              (short)(((param5.z - local_178.z) * 0x10000) >> 0x10),
                              (byte)param1.DAT_48, bVar1);
            uVar6 = (ushort)local_178.x;
            uVar9 = (ushort)local_178.z;

            if (!bVar3)
            {
                param1.DAT_10C.x = local_48 + (short)uVar6;
                param1.DAT_10C.z = local_40 + (short)uVar9;
                return (uint)(local_50 << 0x10 | 1);
            }
        }

        param1.DAT_10C.x = local_48;
        local_36 = local_40;
        LAB_770C0:
        param1.DAT_10C.z = local_36;
        return (uint)(local_50 << 0x10 | 1);
    }

    private Vector3Int FUN_77128(Vector3Int param1, Vector3Int param2, int param3)
    {
        long lVar1;
        int iVar2;
        int iVar3;
        int iVar4;

        iVar4 = param2.z - param1.z >> 1;
        iVar3 = param2.x - param1.x >> 1;
        lVar1 = Utilities.SquareRoot0(iVar4 * iVar4 + iVar3 * iVar3);
        iVar2 = (int)lVar1 + 1;

        if (iVar2 == 0)
            return Vector3Int.zero; //trap(0x1c00)

        if (iVar2 == -1 && iVar4 << 8 == -0x80000000)
            return Vector3Int.zero; //trap(0x1800)

        if (iVar2 == 0)
            return Vector3Int.zero; //trap(0x1c00)

        if (iVar2 == -1 && iVar3 << 8 == -0x80000000)
            return Vector3Int.zero; //trap(0x1800)

        return new Vector3Int(((iVar4 << 8) / iVar2) * param3 >> 8, 0,
                              ((iVar3 << 8) / iVar2) * param3 >> 8);
    }

    public sbyte FUN_77238(uint param1, ref Vector4Int param2)
    {
        ushort uVar1;
        short sVar2;
        uint uVar3;
        int iVar4;
        int psVar5;
        uint uVar6;
        WaypointContainer pbVar7;

        if (SceneManager.instance.waypoints == null)
            uVar3 = 0xff;
        else
        {
            pbVar7 = SceneManager.instance.waypoints.WAYPOINTS[param1 & 0xff];
            uVar6 = pbVar7.DAT_00;
            uVar3 = 0xff;

            if (uVar6 != 0)
            {
                iVar4 = (int)FUN_64650();

                if (uVar6 == 0)
                    return -1; //trap(0x1c00)

                if (uVar6 == 0xffffffff && iVar4 == -0x80000000)
                    return -1; //trap(0x1800)

                uVar3 = (uint)(iVar4 % (int)uVar6 & 0xff);
                psVar5 = (int)(uVar3 * 24);
                uVar1 = pbVar7.OFF_02[psVar5 + 2];
                sVar2 = (short)pbVar7.OFF_02[psVar5];
                param2.y = 0;
                param2.x = sVar2 + (short)((uint)uVar1 >> 1);
                uVar1 = pbVar7.OFF_02[psVar5 + 3];
                sVar2 = (short)pbVar7.OFF_02[psVar5 + 1];
                param2.w = (iVar4 % (int)uVar6) & 0xff;
                param2.z = sVar2 + (short)((uint)uVar1 >> 1);
            }
        }

        return (sbyte)uVar3;
    } 

    public sbyte FUN_7732C(ushort param1, ushort param2, uint param3)
    {
        WaypointContainer pbVar1;
        int puVar2;
        int psVar3;
        uint uVar4;

        if (SceneManager.instance.waypoints != null)
        {
            pbVar1 = SceneManager.instance.waypoints.WAYPOINTS[param3 & 0xff];
            uVar4 = pbVar1.DAT_00;

            if (uVar4 != 0)
            {
                psVar3 = (int)(uVar4 * 24);
                puVar2 = psVar3 - 24;

                do
                {
                    psVar3 -= 24;
                    uVar4--;

                    if ((uint)(pbVar1.OFF_02[psVar3] + pbVar1.OFF_02[puVar2 - 1] - param1) < pbVar1.OFF_02[puVar2 - 1] &&
                        (uint)(pbVar1.OFF_02[puVar2 - 2] + pbVar1.OFF_02[puVar2] - param2) < pbVar1.OFF_02[puVar2])
                        return (sbyte)(uVar4 & 0xff);

                    puVar2 -= 24;
                } while ((uVar4 & 0xffff) != 0);
            }
        }

        return -1;
    }

    private bool FUN_773F0(short param1, short param2, uint param3, uint param4)
    {
        bool bVar1;
        WaypointContainer wVar2;
        int psVar3;

        wVar2 = SceneManager.instance.waypoints.WAYPOINTS[param3 & 0xff];
        psVar3 = (int)(param4 & 0xff) * 24;
        bVar1 = false;

        if ((uint)(wVar2.OFF_02[psVar3] + wVar2.OFF_02[psVar3 + 2] - param1) < wVar2.OFF_02[psVar3 + 2])
        {
            bVar1 = true;

            if (wVar2.OFF_02[psVar3 + 3] <= (uint)(wVar2.OFF_02[psVar3 + 1] + wVar2.OFF_02[psVar3 + 3] - param2))
                bVar1 = false;
        }

        return bVar1;
    }

    public sbyte FUN_774CC(CriSkinned param1, Vector3Int param2)
    {
        ushort uVar1;
        ushort uVar2;
        CriBone oVar3;
        long lVar4;
        uint uVar5;
        CapsuleCollider psVar6;
        WaypointContainer pcVar7;
        Vector3Int local_30;
        Vector3Int local_28;
        sbyte[] local_20;
        Vector2Int local_1c;
        Matrix3x3 MStack80;

        uVar1 = param1.DAT_144;

        if ((uVar1 & 0x8000) != 0)
        {
            if ((uVar1 & 0x1f) == 0)
            {
                pcVar7 = SceneManager.instance.waypoints.WAYPOINTS[param1.DAT_48];

                if (pcVar7.DAT_00 == 0)
                    return -1;

                psVar6 = param1.PTR_130[param1.DAT_130];
                local_28 = new Vector3Int();

                if (param1.PTR_130 == null)
                {
                    local_28.x = param1.screen.x;
                    local_28.z = param1.screen.z;
                }
                else
                {
                    local_30 = new Vector3Int(0, param1.vr.y, 0);
                    MStack80 = new Matrix3x3();
                    Utilities.RotMatrix(ref local_30, ref MStack80);
                    local_30 = new Vector3Int(psVar6.pos.x, 0, psVar6.pos.z);
                    local_30 = Utilities.ApplyMatrixSV(ref MStack80, ref local_30);

                    if (psVar6.bone == -1)
                    {
                        local_28.x = param1.screen.x + local_30.x;
                        local_28.z = param1.screen.z + local_30.z;
                    }
                    else
                    {
                        oVar3 = (CriBone)Utilities.FUN_601C8(param1.skeleton, psVar6.bone);
                        local_28.x = oVar3.screen.x + local_30.x;
                        local_28.z = oVar3.screen.z + local_30.z;
                    }
                }

                local_20 = new sbyte[2];
                local_20[0] = FUN_7732C((ushort)local_28.x, (ushort)local_28.z, (byte)param1.DAT_48);
                local_20[1] = FUN_7732C((ushort)param2.x, (ushort)param2.z, (byte)param1.DAT_48);

                if (local_20[0] != -1 && local_20[1] != -1)
                {
                    if (local_20[0] == local_20[1])
                    {
                        param1.DAT_10C.x = param2.x;
                        param1.DAT_10C.z = param2.z;
                        lVar4 = Utilities.SquareRoot0(param2.x - local_28.x * param2.x - local_28.x +
                                                      param2.z - local_28.z * param2.z - local_28.z);
                        uVar5 = 0;
                        uVar2 = (ushort)(lVar4 >> 0x10);
                    }
                    else
                    {
                        local_1c = new Vector2Int(param2.x, param2.z);
                        uVar5 = FUN_769B0(param1, pcVar7, local_20, local_1c, local_28);
                        uVar2 = (ushort)(uVar5 >> 0x10);
                    }

                    param1.DAT_148 = uVar2;
                    param1.DAT_144 |= (ushort)(param1.DAT_144 >> 10 & 0x1f);
                    return (sbyte)(uVar5 & 0xff);
                }
            }
            else
                param1.DAT_144 = (ushort)(uVar1 - 1);
        }

        return -2;
    }

    public byte FUN_7FB78(CriSkinned param1, CriSkinned param2, bool param3, byte param4)
    {
        short sVar1;
        ushort uVar2;
        ushort uVar3;
        short sVar4;
        int iVar5;
        CriObject oVar5;
        int iVar6;
        CriObject oVar6;
        long lVar7;
        int iVar8;
        int iVar9;
        int iVar10;
        CapsuleCollider pSVar11;
        CapsuleCollider pSVar12;
        int iVar13;
        Vector3Int v0;
        short local_b8;
        short local_b6;
        short local_a8;
        short local_a6;
        Vector3Int local_58;
        bool local_50;
        byte local_4f;
        byte local_48;
        byte local_40;
        sbyte local_38;
        Vector3Int local_30;
        uint local_2c;
        byte local_28;
        Matrix3x3 MStack152;
        Matrix3x3 MStack120;

        if (param1.PTR_120 != null)
        {
            if (param2.PTR_120 == null)
                return 0;

            iVar5 = param1.screen.x - param2.screen.x;

            if (iVar5 < 0)
                iVar5 = param2.screen.x - param1.screen.x;

            if (10000 < iVar5)
                return 0;

            iVar5 = param1.screen.z - param2.screen.z;

            if (iVar5 < 0)
                iVar5 = param2.screen.z - param1.screen.z;

            if (iVar5 <= 10000)
            {
                local_50 = param3;
                local_4f = param4;
                MStack152 = new Matrix3x3();
                MStack120 = new Matrix3x3();
                Utilities.RotMatrix_gte(ref param1.vr, ref MStack152);
                Utilities.RotMatrix_gte(ref param2.vr, ref MStack120);
                local_40 = 0;
                local_48 = 0;

                if (local_4f == 0)
                    return 0;

                do
                {
                    local_38 = param2.DAT_12E;
                    pSVar12 = param1.PTR_120[param1.DAT_120 + local_48];
                    local_30 = pSVar12.pos;
                    local_58 = Utilities.ApplyMatrixSV(ref MStack152, ref local_30);
                    oVar5 = null;

                    if (pSVar12.bone != -1)
                        oVar5 = Utilities.FUN_601C8(param1.skeleton, pSVar12.bone);

                    local_38--;

                    if (local_38 != -1)
                    {
                        local_2c = local_48;
                        local_28 = 0;

                        do
                        {
                            pSVar11 = param2.PTR_120[param2.DAT_120 + local_28];
                            v0 = pSVar11.pos;

                            if (oVar5 == null)
                            {
                                local_b8 = (short)param1.screen.x;
                                local_b6 = (short)param1.screen.y;
                                sVar4 = (short)param1.screen.z;
                            }
                            else
                            {
                                local_b8 = (short)oVar5.screen.x;
                                local_b6 = (short)oVar5.screen.y;
                                sVar4 = (short)oVar5.screen.z;
                            }

                            local_b6 += (short)local_58.y;
                            local_b8 += (short)local_58.x;
                            sVar4 += (short)local_58.z;
                            local_58 = Utilities.ApplyMatrixSV(ref MStack120, ref v0);

                            if (pSVar11.bone == -1)
                            {
                                local_a8 = (short)(param2.screen.x + local_58.x);
                                local_a6 = (short)(param2.screen.y + local_58.y);
                                sVar1 = (short)param2.screen.z;
                            }
                            else
                            {
                                oVar6 = Utilities.FUN_601C8(param2.skeleton, pSVar11.bone);
                                local_a8 = (short)(oVar6.screen.x + local_58.x);
                                local_a6 = (short)(oVar6.screen.y + local_58.y);
                                sVar1 = (short)oVar6.screen.z;
                            }

                            iVar9 = local_b8 - local_a8;
                            iVar10 = sVar4 - (short)(sVar1 + local_58.z);
                            uVar2 = pSVar12.radius;
                            uVar3 = pSVar11.radius;
                            lVar7 = Utilities.SquareRoot0(iVar9 * iVar9 + iVar10 * iVar10);
                            iVar6 = (int)(uVar2 + uVar3 - lVar7);

                            if (0 < iVar6)
                            {
                                iVar8 = local_b6 - local_a6;

                                if (iVar8 < 0)
                                    uVar2 = pSVar11.height;
                                else
                                    uVar2 = pSVar12.height;

                                if (iVar8 < 0)
                                    iVar8 = -iVar8;

                                if (iVar8 < uVar2)
                                {
                                    iVar8 = (int)(lVar7 + 1);
                                    local_40 |= (byte)(1 << (int)(local_2c & 0x1f));

                                    if (iVar8 == 0)
                                        return 0; //trap(0x1c00)

                                    if (iVar8 == -1 && iVar9 * iVar6 == -0x80000000)
                                        return 0; //trap(0x1800)

                                    iVar13 = (iVar9 * iVar6) / iVar8;

                                    if (param2.screen.x != param2.DAT_34.x)
                                    {
                                        if (iVar13 < 0)
                                        {
                                            if (iVar13 < -100)
                                                iVar13 = -100;
                                        }
                                        else
                                        {
                                            if (100 < iVar13)
                                                iVar13 = 100;
                                        }
                                    }

                                    if (iVar8 == 0)
                                        return 0; //trap(0x1c00)

                                    if (iVar8 == -1 && iVar10 * iVar6 == -0x80000000)
                                        return 0; //trap(0x1800)

                                    iVar9 = (iVar10 * iVar6) / iVar8;

                                    if (param2.screen.z != param2.DAT_34.z)
                                    {
                                        if (iVar9 < 0)
                                        {
                                            if (iVar9 < -100)
                                                iVar9 = -100;
                                        }
                                        else
                                        {
                                            if (100 < iVar9)
                                                iVar9 = 100;
                                        }
                                    }

                                    if (local_50 && (param1.DAT_12C & 0x100) == 0)
                                    {
                                        param1.screen.x += iVar13;
                                        param1.screen.z += iVar9;
                                        param1.FUN_66208();
                                    }
                                }
                            }

                            local_38--;
                            local_28++;
                        } while (local_38 != -1);
                    }

                    local_48++;
                } while (local_48 < local_4f);

                return local_40;
            }
        }

        return 0;
    }

    private IEnumerator FUN_79FC8()
    {
        loader = new CoroutineLoader();

        do
        {
            if (SceneManager.sceneLoaded)
            {
                PTR_FUN_AA3E0[loader.DAT_00](loader);
                loader.DAT_0F++;
            }

            yield return null;
        }while (!loader.exit);

        loader.exit = false;
        yield return null;
    }

    private void FUN_7A030(CoroutineLoader param1)
    {
        short sVar1;
        sbyte sVar3;
        byte bVar4;
        uint uVar5;
        bool bVar6;
        CriStatic oVar6;
        CriPlayer pVar6;
        LoadDoorContainer dVar7;

        uVar5 = DAT_47;
        pVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar6 = SceneManager.instance.DAT_7CDC[0];
        dVar7 = DAT_A89A0[(int)uVar5];
        sVar1 = param1.DAT_02;

        if (sVar1 != 1)
        {
            if (1 < sVar1)
            {
                if (sVar1 == 2)
                {
                    if (DAT_6D)
                        return;

                    Destroy(SceneManager.instance.DAT_27C[10].gameObject);
                    UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(tmpSkinned[0].gameObject,
                        UnityEngine.SceneManagement.SceneManager.GetActiveScene());
                    SceneManager.instance.DAT_27C[10] = tmpSkinned[0];

                    for (int i = 0; i < tmpBones.Count; i++)
                    {
                        Destroy(SceneManager.instance.DAT_1C9C[i].gameObject);
                        UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(tmpBones[i].gameObject,
                            UnityEngine.SceneManagement.SceneManager.GetActiveScene());
                        SceneManager.instance.DAT_1C9C[i] = tmpBones[i];
                    }

                    pVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
                    bVar6 = InventoryManager.FUN_4A87C(2, 0xd);

                    if (bVar6)
                    {
                        sVar3 = (sbyte)(param1.DAT_0D - 1);
                        param1.DAT_0D = sVar3;

                        if (sVar3 != -1)
                            return;
                    }

                    param1.DAT_0D = 0;
                    DAT_21 = 4;
                    //...
                    param1.DAT_14 = new Vector3Int(0x80, 0x80, 0x80);
                    InventoryManager.FUN_4A7E8(2, 0xd, false);
                    param1.DAT_02++;
                    //unecessery stuff...

                    if (dVar7.DAT_00 != null)
                    {
                        oVar6.flags = 3;
                        oVar6.DAT_48 = 2;
                        oVar6.DAT_2E = 0;
                        oVar6.DAT_4A = 1000;
                        oVar6.vr = new Vector3Int(0, 0, 0);
                        oVar6.screen = new Vector3Int(0, 0, 0);
                        oVar6.cCollider = null;
                        oVar6.cMesh = dVar7.DAT_00;
                        oVar6.SetMaterials();
                    }

                    SceneManager.instance.FUN_26EBC(2, 0);
                    SceneManager.instance.FUN_264C4(0, (short)dVar7.DAT_0E.x, (short)dVar7.DAT_0E.y, (short)dVar7.DAT_0E.z);
                    SceneManager.instance.FUN_26504(0, (short)dVar7.DAT_14.x, (short)dVar7.DAT_14.y, (short)dVar7.DAT_14.z);
                    pVar6.screen = dVar7.DAT_1A;
                    pVar6.DAT_12C |= 0x10;
                    pVar6.flags |= 2;
                    pVar6.DAT_3C = 4;
                    pVar6.DAT_3D = 0;
                    pVar6.DAT_3E = 0;
                    pVar6.DAT_3F = 0;
                    pVar6.DAT_140 |= 0x8000;
                    pVar6.vr = new Vector3Int(0, 0, 0);
                    pVar6.DAT_40 = new Vector3Int(0, 0, 0);
                    pVar6.DAT_174 &= 0x7f;
                    param1.DAT_0C = pVar6.DAT_1D7;
                    bVar4 = (byte)(pVar6.DAT_1D7 - 1);
                    pauseMain = false;

                    if ((pVar6.DAT_1C0 & 8) == 0)
                        return;

                    param1.DAT_0C = bVar4;

                    if (-1 < bVar4 << 0x18)
                        return;

                    param1.DAT_0C = 0;
                    return;
                }

                if (sVar1 != 3)
                    return;

                param1.DAT_02 = 0;
                param1.DAT_06 = 0;
                param1.DAT_00++;

                if (dVar7.DAT_04 == null)
                    return;

                oVar6 = SceneManager.instance.DAT_7CDC[1];
                oVar6.flags = 3;
                oVar6.DAT_2E = 0;
                oVar6.DAT_48 = 2;
                oVar6.DAT_4A = 1000;
                oVar6.cMesh = dVar7.DAT_04;
                oVar6.cCollider = null;
                oVar6.vr = new Vector3Int(0, 0, 0);
                oVar6.screen = new Vector3Int(dVar7.DAT_0C, 0, 0);
                oVar6.SetMaterials();
                return;
            }

            if (sVar1 != 0)
                return;

            param1.DAT_02++;
            bVar6 = InventoryManager.FUN_4A87C(2, 2);

            if (bVar6)
                InventoryManager.FUN_4A7E8(2, 2, false);

            bVar6 = InventoryManager.FUN_4A87C(2, 0xd);

            if (!bVar6)
                FUN_46C0C(1, 30, 1);
            else
                param1.DAT_0D = 30;

            //FUN_5DED4

            if (DAT_AA2A0[DAT_47] == 0) goto LAB_7A174;

            DAT_6D = false; //tmp
            pauseMain = true;
            SceneManager.sceneLoaded = false;
            tmpSkinned.Clear();
            tmpBones.Clear();
            tmpSkinned.Add(SceneManager.instance.DAT_27C[10]);
            DontDestroyOnLoad(tmpSkinned[0].gameObject);

            for (int i = 0; i < SceneManager.instance.DAT_1C9C.Length; i++)
            {
                tmpBones.Add(SceneManager.instance.DAT_1C9C[i]);
                DontDestroyOnLoad(tmpBones[i].gameObject);
            }

            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIds[DAT_AA2A0[DAT_47]], LoadSceneMode.Single);
        }

        //...
        LAB_7A174:
        param1.DAT_02++;
    }

    private void FUN_7A460(CoroutineLoader param1)
    {
        short sVar1;
        uint uVar4;
        CriPlayer oVar5;

        sVar1 = param1.DAT_02;

        if (sVar1 == 1)
        {
            FUN_46C0C(1, 20, 1);
            sVar1 = param1.DAT_02;
        }
        else
        {
            if (sVar1 < 2)
            {
                if (sVar1 == 0)
                {
                    DAT_A89A0[DAT_47].DAT_08.Invoke();
                    uVar4 = DAT_47;

                    if (uVar4 != 18 && uVar4 != 26 && 3 < uVar4 - 32)
                    {
                        //...
                    }
                }

                goto LAB_7A5E4;
            }

            if (sVar1 != 2)
            {
                if (sVar1 == 3 && !DAT_6D)
                {
                    param1.DAT_02 = 0;
                    param1.DAT_00++;
                    //oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
                    //oVar5.FUN_609C8((TodScriptableObject)oVar5.REFS[oVar5.DAT_220], 1, 0);
                    //oVar5.FUN_60AB4();
                }

                goto LAB_7A5E4;
            }

            if ((param1.DAT_0A & 2U) == 0) goto LAB_7A5E4;

            sVar1 = param1.DAT_02;
            param1.DAT_04 = 0;
        }

        param1.DAT_02 = (short)(sVar1 + 1);
        LAB_7A5E4:
        FUN_7A670(param1);
    }

    private void FUN_7A604(CoroutineLoader param1)
    {
        if (param1.DAT_08 == 3)
            ; //sound

        InventoryManager.DAT_B7A60[0] = 0;
        DAT_2A++;
        //FUN_5543C - unnecessery
        DialogManager.instance.FUN_1DE48();
        //...
        param1.exit = true;
    }

    private void FUN_7A670(CoroutineLoader param1)
    {
        byte bVar1;
        LoadScriptContainer puVar2;
        LoadSceneContainer puVar3;

        switch(param1.DAT_06)
        {
            case 0:
                if (!DAT_6D)
                    return;

                if (param1.DAT_0F < 61)
                    return;

                if (DAT_9AA0 >> 8 == DAT_9ADC >> 8)
                {
                    param1.DAT_06 = 4;
                    return;
                }

                goto LAB_7A814;
            case 1:
                //...
                puVar2 = DAT_9E0A0[DAT_9AA0 >> 8];
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIds[puVar2.DAT_02], LoadSceneMode.Single);
                goto LAB_7A814;
            case 2:
                param1.DAT_06++;
                goto case 3;
            case 3:
                //...
                LevelManager.instance.Initialize();
                goto LAB_7A814;
            case 4:
                bVar1 = (byte)DAT_9AA0;
                puVar2 = DAT_9E0A0[DAT_9AA0 >> 8];
                param1.DAT_06++;
                param1.DAT_10 = puVar2.scenes[bVar1];
                goto case 5;
            case 5:
                //...
                puVar3 = param1.DAT_10;
                break;
            case 6:
                //...
                param1.DAT_06++;
                param1.DAT_0A |= 2;
                pauseMain = false;
                DAT_6D = false; //tmp
                return;
            default:
                return;
        }

        pauseMain = true;
        SceneManager.sceneLoaded = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIds[puVar3.DAT_02], LoadSceneMode.Single);
        LAB_7A814:
        param1.DAT_06++;
    }

    public void FUN_7AB80()
    {
        CriPlayer oVar2;
        uint uVar3;
        int iVar4;
        LoadDoorContainer dVar4;
        CriStatic oVar6;
        short sVar5;
        CriStatic oVar7;

        CoroutineLoader param1 = loader;
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        dVar4 = DAT_A89A0[DAT_47];
        sVar5 = param1.DAT_04;
        oVar7 = SceneManager.instance.DAT_7CDC[1];

        if (sVar5 == 1)
        {
            if (!DAT_6D)
            {
                param1.DAT_04++;
                //sound
            }
        }
        else
        {
            if (sVar5 < 2)
            {
                if (sVar5 == 0)
                {
                    uVar3 = (uint)Utilities.Rand();

                    if ((uVar3 & 1) != 0)
                        SceneManager.instance.FUN_26504(0, (short)dVar4.DAT_0E.x, (short)dVar4.DAT_0E.y, (short)dVar4.DAT_0E.z);

                    oVar2.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801890dc], 1, 0);
                    oVar2.FUN_60AB4();
                    param1.DAT_08 = 1;
                    param1.DAT_04++;
                    FUN_46C0C(0, 20, 1);
                    oVar6 = SceneManager.instance.DAT_7CDC[0];
                    oVar6.vr.y = -0x400;
                    oVar6 = SceneManager.instance.DAT_7CDC[1];
                    oVar6.screen.x = oVar2.screen.x;
                    oVar6.screen.z = oVar2.screen.z;
                    oVar6.vr.y = 0x800;
                    oVar6.DAT_48 = 1;
                }
            }
            else
            {
                if (sVar5 == 2)
                {
                    oVar2.FUN_60AB4();
                    iVar4 = oVar2.screen.y - ((short)oVar2.DAT_60 + 50);
                    oVar2.screen.y = (short)iVar4;

                    if (iVar4 * 0x10000 >> 0x10 < -2999)
                        param1.DAT_02++;
                }
            }
        }

        sVar5 = -0x514;

        if (-0x514 < oVar2.screen.y)
            sVar5 = (short)oVar2.screen.y;

        oVar7.screen.y = oVar2.screen.y;
        SceneManager.instance.FUN_264C4(0, (short)oVar2.screen.x, (short)(sVar5 - 0x400), (short)oVar2.screen.z);
    }

    public void FUN_7AD80()
    {
        CriStatic oVar1;
        int iVar2;
        uint uVar3;
        bool bVar4;
        LoadDoorContainer dVar4;
        CriPlayer oVar5;

        CoroutineLoader param1 = loader;
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        dVar4 = DAT_A89A0[DAT_47];

        switch (param1.DAT_04)
        {
            case 0:
                uVar3 = (uint)Utilities.Rand();

                if ((uVar3 & 1) != 0)
                    SceneManager.instance.FUN_26504(0, (short)dVar4.DAT_0E.x, (short)dVar4.DAT_0E.y, (short)dVar4.DAT_0E.z);

                oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801890dc], 1, 0);
                oVar5.FUN_60AB4();
                param1.DAT_08 = 1;
                param1.DAT_04++;
                FUN_46C0C(0, 20, 1);
                oVar1 = SceneManager.instance.DAT_7CDC[0];
                oVar1.vr.y = -0x400;
                oVar1 = SceneManager.instance.DAT_7CDC[1];
                oVar1.screen.x = oVar5.screen.x;
                oVar1.screen.z = oVar5.screen.z;
                oVar1.vr.y = 0x800;
                oVar1.DAT_48 = 1;
                goto LAB_7ADF0;
            case 1:
                if (DAT_6D) goto LAB_7ADF0;

                //sound
                break;
            case 2:
                oVar5.FUN_60AB4();
                iVar2 = oVar5.screen.y + (short)oVar5.DAT_60 + 50;
                oVar5.screen.y = iVar2;

                if (iVar2 << 0x10 < 0) goto LAB_7ADF0;

                break;
            case 3:
                bVar4 = oVar5.FUN_60AB4();

                if (!bVar4) goto LAB_7ADF0;

                oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018ca70], 0, 0);
                break;
            case 4:
                bVar4 = oVar5.FUN_60AB4();

                if (oVar5.DAT_60 == 24)
                {
                    //...
                }

                if (bVar4)
                    param1.DAT_02++;

                goto default;
            default:
                goto LAB_7ADF0;
        }

        param1.DAT_04++;
        LAB_7ADF0:
        oVar1 = SceneManager.instance.DAT_7CDC[1];
        oVar1.screen.y = oVar5.screen.y;
        SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, (short)(oVar5.screen.y - 0x400), (short)oVar5.screen.z);
    }

    private void FUN_7AFB8(CoroutineLoader param1, short param2, bool param3, short param4)
    {
        sbyte sVar1;
        short sVar2;
        int iVar3;
        CriPlayer oVar4;
        CriStatic oVar5;

        oVar5 = SceneManager.instance.DAT_7CDC[0];
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                oVar4.FUN_609C8((TodScriptableObject)oVar4.REFS[oVar4.DAT_220], 1, 0);
                oVar4.FUN_60AB4();
                FUN_46C0C(0, 20, 1);
                sVar2 = param1.DAT_04;
                param1.DAT_08 = 3;
                goto LAB_7B14C;
            case 1:
                if (DAT_6D)
                    return;

                break;
            case 2:
                oVar4.FUN_60AB4();
                sVar1 = (sbyte)(param1.DAT_0D + 1);
                param1.DAT_0D = sVar1;

                if (sVar1 < 31)
                    return;

                //sound
                break;
            case 3:
                oVar4.FUN_60AB4();
                iVar3 = oVar5.screen.x + param2;
                oVar5.screen.x = iVar3;

                if (!param3)
                {
                    if (iVar3 < param4)
                        return;
                }
                else
                {
                    if (-param4 < iVar3)
                        return;
                }

                break;
            case 4:
                oVar4.FUN_609C8((TodScriptableObject)oVar4.REFS[oVar4.DAT_220 + 1], 1, 10);
                break;
            case 5:
                oVar4.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar2 = (short)(oVar4.screen.z + 54);
                else
                    sVar2 = (short)(oVar4.screen.z + 46);

                oVar4.screen.z = sVar2;

                if (500 < oVar4.screen.z)
                    param1.DAT_02++;

                goto default;
            default:
                return;
        }

        sVar2 = param1.DAT_04;
        LAB_7B14C:
        param1.DAT_04 = (short)(sVar2 + 1);
    }

    public void FUN_7B1D4()
    {
        FUN_7AFB8(loader, -50, true, 1500);
    }

    public void FUN_7B1FC()
    {
        FUN_7AFB8(loader, 50, false, 1500);
    }

    public void FUN_7B224()
    {
        CriStatic oVar1;
        sbyte sVar2;
        short sVar4;
        uint uVar5;
        CriPlayer oVar6;
        CriBone oVar7;

        CoroutineLoader param1 = loader;
        oVar1 = SceneManager.instance.DAT_7CDC[0];
        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                oVar6.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80191fcc], 0x20, 0);
                oVar6.FUN_60AB4();
                FUN_46C0C(0, 20, 1);
                param1.DAT_08 = 4;
                param1.DAT_14 = new Vector3Int(0, 0, 0);
                param1.DAT_04++;
                goto LAB_7B278;
            case 1:
                if (DAT_6D) goto LAB_7B278;

                break;
            case 2:
                oVar6.FUN_60AB4();
                sVar2 = (sbyte)(param1.DAT_0D + 1);
                param1.DAT_0D = sVar2;

                if (sVar2 < 31) goto LAB_7B278;

                //sound
                break;
            case 3:
                oVar6.FUN_60AB4();
                sVar4 = (short)(oVar1.screen.x - 50);
                oVar1.screen.x = sVar4;

                if (-1000 < sVar4) goto LAB_7B278;

                break;
            case 4:
                oVar6.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80192664], 9, 10);
                break;
            case 5:
                oVar6.FUN_60AB4();
                oVar6.screen.z += 27;

                if ((oVar6.frames[oVar6.frameNum].DAT_03 & 3) != 0)
                {
                    uVar5 = 244;

                    if ((oVar6.DAT_1C0 & 2) != 0)
                        uVar5 = 245;

                    //sound
                    oVar6.DAT_1C0 ^= 2;
                }

                sVar4 = (short)oVar6.screen.z;

                if (0 < sVar4)
                    param1.DAT_04++;

                if (-500 < sVar4)
                {
                    //...
                    param1.DAT_14.x += 8;
                    param1.DAT_14.y += 8;
                    param1.DAT_14.z += 8;

                    if (0x80 < param1.DAT_14.x)
                        param1.DAT_14 = new Vector3Int(0x80, 0x80, 0x80);
                }

                goto LAB_7B278;
            case 6:
                //...
                oVar6.FUN_60AB4();
                oVar6.screen.z += 27;

                if ((oVar6.frames[oVar6.frameNum].DAT_03 & 3) != 0)
                {
                    uVar5 = 244;

                    if ((oVar6.DAT_1C0 & 2) != 0)
                        uVar5 = 245;

                    //sound
                    oVar6.DAT_1C0 ^= 2;
                }

                if (oVar6.screen.z < 2001)
                {
                    if (1300 < oVar6.screen.z)
                    {
                        param1.DAT_14.x -= 0x10;
                        param1.DAT_14.y -= 0x10;
                        param1.DAT_14.z -= 0x10;

                        if (param1.DAT_14.x < 0)
                            param1.DAT_14 = new Vector3Int(0, 0, 0);
                    }
                }
                else
                    param1.DAT_02++;

                goto default;
            default:
                goto LAB_7B278;
        }

        param1.DAT_04++;
        LAB_7B278:
        oVar7 = (CriBone)Utilities.FUN_601C8(oVar6.skeleton, 7);
        sVar4 = (short)(((oVar7.screen.y + 200) * 0x10000) >> 0x10);
        SceneManager.instance.FUN_26504(0, (short)oVar6.screen.x, sVar4, (short)(oVar6.screen.z + 100));
        SceneManager.instance.FUN_264C4(0, (short)oVar6.screen.x, sVar4, (short)(oVar6.screen.z + 1000));
    }

    public void FUN_7B634()
    {
        bool bVar1;
        CriStatic oVar2;
        short sVar3;
        uint uVar4;
        CriPlayer oVar5;
        int[] local_20;

        CoroutineLoader param1 = loader;
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        local_20 = new int[4] { 9, 23, 14, 15 };

        switch (param1.DAT_04)
        {
            case 0:
                bVar1 = param1.DAT_0C == 0;

                if (bVar1)
                    oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80187a7c], 0, 0);
                else
                    oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018a990], 0, 0);

                DAT_C7D4C = !bVar1;
                oVar5.FUN_60AB4();
                param1.DAT_04++;

                if (DAT_9AA0 >> 8 == DAT_9ADC >> 8)
                {
                    param1.DAT_08 = 3;
                    oVar2 = SceneManager.instance.DAT_7CDC[1];

                    if (DAT_47 == 73)
                        oVar2.flags = 0;
                }
                else
                {
                    param1.DAT_08 = 4;
                    SceneManager.instance.FUN_26504(0, -0x3b0, -0xbe0, -0x700);
                    oVar2 = SceneManager.instance.DAT_7CDC[1];
                    oVar2.flags = 0;
                    oVar2 = SceneManager.instance.DAT_7CDC[0];
                    oVar2.DAT_48 = 2;
                    oVar2.DAT_4A = 1000;
                }

                FUN_46C0C(0, 20, 1);
                DAT_6D = false; //tmp
                return;
            case 1:
                if (DAT_6D)
                    return;

                break;
            case 2:
                oVar5.FUN_60AB4();

                if (oVar5.DAT_60 < local_20[(DAT_C7D4C ? 1 : 0) * 2])
                    return;

                //sound
                break;
            case 3:
                oVar5.FUN_60AB4();
                oVar2 = SceneManager.instance.DAT_7CDC[0];
                sVar3 = (short)(oVar2.vr.y + local_20[(DAT_C7D4C ? 1 : 0) * 2 + 1]);
                oVar2.vr.y = sVar3;

                if (sVar3 < 690)
                    return;

                if (param1.DAT_08 == 3) goto LAB_7BA80;

                break;
            case 4:
                oVar2 = SceneManager.instance.DAT_7CDC[0];
                oVar2.flags = 3;
                oVar2 = SceneManager.instance.DAT_7CDC[1];
                oVar2.vr.y = 0xab2;
                SceneManager.instance.FUN_26504(0, 0x900, -0x3e0, 0x780);
                oVar5.FUN_609C8((TodScriptableObject)oVar5.REFS[oVar5.DAT_220 + 1], 1, 0);
                param1.DAT_04++;
                goto case 5;
            case 5:
                oVar5.FUN_60AB4();
                oVar2 = SceneManager.instance.DAT_7CDC[1];
                oVar2.vr.y += local_20[(DAT_C7D4C ? 1 : 0) * 2 + 1];

                if (param1.DAT_0C == 0)
                    sVar3 = (short)(oVar5.screen.z + 0x36);
                else
                    sVar3 = (short)(oVar5.screen.z + 0x2e);

                oVar5.screen.z = sVar3;

                if ((oVar5.frames[oVar5.frameNum].DAT_03 & 3) != 0)
                {
                    uVar4 = 0xf4;

                    if ((oVar5.DAT_1C0 & 2) != 0)
                        uVar4 = 0xf5;

                    //sound
                    oVar5.DAT_1C0 ^= 2;
                }

                SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, (short)(oVar5.screen.y - 0x5dc), (short)oVar5.screen.z);

                if (oVar5.screen.z < 1)
                    return;

                break;
            case 6:
                oVar5.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar3 = (short)(oVar5.screen.z + 0x36);
                else
                    sVar3 = (short)(oVar5.screen.z + 0x2e);

                oVar5.screen.z = sVar3;

                if ((oVar5.frames[oVar5.frameNum].DAT_03 & 3) != 0)
                {
                    uVar4 = 0xf4;

                    if ((oVar5.DAT_1C0 & 2) != 0)
                        uVar4 = 0xf5;

                    //sound
                    oVar5.DAT_1C0 ^= 2;
                }

                if (oVar5.screen.z < 500)
                    SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, (short)(oVar5.screen.y - 0x5dc), (short)oVar5.screen.z);

                oVar2 = SceneManager.instance.DAT_7CDC[1];
                sVar3 = (short)(oVar2.vr.y - 0x2e);
                oVar2.vr.y = sVar3;

                if (0x7ff < sVar3)
                    return;

                //sound
                LAB_7BA80:
                param1.DAT_02++;
                goto default;
            default:
                return;
        }

        param1.DAT_04++;
    }

    public void FUN_7BAB0()
    {
        bool bVar1;
        CriStatic oVar2;
        byte bVar3;
        short sVar4;
        short sVar5;
        uint uVar6;
        CriPlayer oVar7;
        int[] local_28;

        CoroutineLoader param1 = loader;
        local_28 = new int[4] { 9, 23, 14, 15 };
        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                bVar1 = param1.DAT_0C == 0;

                if (bVar1)
                    oVar7.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801885ac], 0, 0);
                else
                    oVar7.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018ba00], 0, 0);

                DAT_C7D4C = !bVar1;
                oVar7.FUN_60AB4();
                param1.DAT_04++;

                if (DAT_9AA0 >> 8 == DAT_9ADC >> 8)
                {
                    param1.DAT_08 = 3;
                    oVar2 = SceneManager.instance.DAT_7CDC[1];

                    if (DAT_47 == 72)
                        oVar2.flags = 0;
                }
                else
                {
                    param1.DAT_08 = 4;
                    SceneManager.instance.FUN_264C4(0, -0x3c0, -0x400, -0x500);
                    SceneManager.instance.FUN_26504(0, 0x240, -0x6c0, 0xc00);
                    oVar2 = SceneManager.instance.DAT_7CDC[0];
                    oVar2.flags = 0;
                    oVar2 = SceneManager.instance.DAT_7CDC[1];
                    oVar2.vr.y = 0x800;
                    oVar2.DAT_4A = 10;
                }

                FUN_46C0C(0, 20, 1);
                DAT_6D = false; //tmp
                break;
            case 1:
                if (DAT_6D)
                    return;

                bVar3 = (byte)(param1.DAT_0D + 1);
                param1.DAT_0D = (sbyte)bVar3;

                if (bVar3 < 31U)
                    return;

                sVar4 = param1.DAT_04;
                param1.DAT_0D = 0;
                param1.DAT_04 = (short)(sVar4 + 1);
                break;
            case 2:
                oVar7.FUN_60AB4();

                if (oVar7.DAT_60 < local_28[(DAT_C7D4C ? 1 : 0) * 2])
                    return;

                //sound
                sVar4 = param1.DAT_04;
                param1.DAT_04 = (short)(sVar4 + 1);
                break;
            case 3:
                oVar7.FUN_60AB4();
                oVar2 = SceneManager.instance.DAT_7CDC[0];

                if (param1.DAT_08 == 3)
                {
                    sVar4 = (short)(oVar2.vr.y + local_28[(DAT_C7D4C ? 1 : 0) * 2 + 1]);
                    oVar2.vr.y = sVar4;

                    if (sVar4 < 0x2b3)
                        return;

                    goto LAB_7BF48;
                }

                oVar2 = SceneManager.instance.DAT_7CDC[1];
                sVar4 = (short)(oVar2.vr.y + local_28[(DAT_C7D4C ? 1 : 0) * 2 + 1]);
                oVar2.vr.y = sVar4;
                bVar1 = sVar4 < 0xab3;
                goto LAB_7BE80;
            case 4:
                oVar2 = SceneManager.instance.DAT_7CDC[1];
                oVar2.flags = 0;
                oVar2 = SceneManager.instance.DAT_7CDC[0];
                oVar2.flags = 0;
                oVar2.vr.y = 0x2b2;
                SceneManager.instance.FUN_264C4(0, -0x3c0, -0x600, 0);
                SceneManager.instance.FUN_26504(0, -0x930, -0x810, -0x900);
                oVar7.screen.z = 0x200;
                oVar7.FUN_609C8((TodScriptableObject)oVar7.REFS[oVar7.DAT_220 + 1], 1, 0);
                param1.DAT_04++;
                goto case 5;
            case 5:
                oVar7.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar4 = (short)(oVar7.screen.z + 54);
                else
                    sVar4 = (short)(oVar7.screen.z + 46);

                oVar7.screen.z = sVar4;

                if ((oVar7.frames[oVar7.frameNum].DAT_03 & 3) != 0)
                {
                    uVar6 = 244;

                    if ((oVar7.DAT_1C0 & 2) != 0)
                        uVar6 = 245;

                    //sound
                    oVar7.DAT_1C0 ^= 2;
                }

                oVar2 = SceneManager.instance.DAT_7CDC[0];
                sVar4 = (short)(oVar2.vr.y + local_28[(DAT_C7D4C ? 1 : 0) * 2 + 1]);
                oVar2.vr.y = sVar4;
                bVar1 = sVar4 < 0x401;
                
                LAB_7BE80:
                if (!bVar1)
                {
                    sVar4 = param1.DAT_04;
                    param1.DAT_04 = (short)(sVar4 + 1);
                }

                break;
            case 6:
                oVar7.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar4 = (short)(oVar7.screen.z + 54);
                else
                    sVar4 = (short)(oVar7.screen.z + 46);

                oVar7.screen.z = sVar4;

                if ((oVar7.frames[oVar7.frameNum].DAT_03 & 3) != 0)
                {
                    uVar6 = 244;

                    if ((oVar7.DAT_1C0 & 2) != 0)
                        uVar6 = 245;

                    //sound
                    oVar7.DAT_1C0 ^= 2;
                }

                oVar2 = SceneManager.instance.DAT_7CDC[0];
                sVar5 = (short)(oVar2.vr.y - 46);
                oVar2.vr.y = sVar5;

                if (-1 < sVar5 << 0x10)
                    return;

                //sound
                LAB_7BF48:
                param1.DAT_02++;
                break;
        }
    }

    public void FUN_7BF78()
    {
        bool bVar1;
        short sVar2;
        CriStatic oVar3;
        sbyte sVar4;
        int iVar5;
        CriPlayer oVar5;
        int[] local_28;

        CoroutineLoader param1 = loader;
        oVar3 = SceneManager.instance.DAT_7CDC[0];
        local_28 = new int[4] { 9, 23, 14, 15 };
        sVar2 = param1.DAT_04;
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar2 == 1)
        {
            if (DAT_6D)
                return;

            sVar4 = (sbyte)(param1.DAT_0D + 1);
            param1.DAT_0D = sVar4;

            if (sVar4 < 31)
                return;
        }
        else
        {
            if (sVar2 < 2)
            {
                if (sVar2 != 0)
                    return;

                bVar1 = param1.DAT_0C == 0;
                param1.DAT_08 = 3;

                if (bVar1)
                    oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801885ac], 0, 0);
                else
                    oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018ba00], 0, 0);

                DAT_C7D4C = !bVar1;
                oVar5.FUN_60AB4();
                param1.DAT_04++;
                FUN_46C0C(0, 20, 1);
                return;
            }

            if (sVar2 != 2)
            {
                if (sVar2 != 3)
                    return;

                oVar5.FUN_60AB4();
                iVar5 = oVar3.vr.y - local_28[(DAT_C7D4C ? 1 : 0) * 2 + 1];
                oVar3.vr.y = iVar5;

                if (-691 < iVar5 * 0x10000 >> 0x10)
                    return;

                param1.DAT_02++;
                return;
            }

            oVar5.FUN_60AB4();

            if (oVar5.DAT_60 < local_28[(DAT_C7D4C ? 1 : 0) * 2])
                return;

            //sound
        }

        param1.DAT_04++;
    }

    private void FUN_7C190(CoroutineLoader param1, short param2, int param3)
    {
        sbyte sVar1;
        short sVar2;
        short sVar3;
        CriPlayer oVar4;
        CriStatic oVar5;

        oVar5 = SceneManager.instance.DAT_7CDC[0];
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                oVar4.FUN_609C8((TodScriptableObject)oVar4.REFS[oVar4.DAT_220], 1, 0);
                oVar4.FUN_60AB4();
                param1.DAT_04++;
                sVar2 = 4;

                if (DAT_9AA0 >> 8 == DAT_9ADC >> 8)
                    sVar2 = 3;

                param1.DAT_08 = sVar2;
                FUN_46C0C(0, 20, 1);
                break;
            case 1:
                if (DAT_6D)
                    return;

                goto LAB_7C338;
            case 2:
                oVar4.FUN_60AB4();
                sVar1 = (sbyte)(param1.DAT_0D + 1);
                param1.DAT_0D = sVar1;

                if (sVar1 < 31)
                    return;

                sVar3 = param1.DAT_04;
                param1.DAT_0D = 0;
                goto LAB_7C340;
            case 3:
                oVar4.FUN_60AB4();

                if (oVar4.DAT_60 < 9U)
                    return;

                //sound
                goto LAB_7C338;
            case 4:
                oVar4.FUN_60AB4();
                oVar5.screen.x -= param2;
                SceneManager.instance.DAT_7CDC[1].screen.x += param2;

                if (-param3 < oVar5.screen.x)
                    return;

                LAB_7C338:
                sVar3 = param1.DAT_04;
                LAB_7C340:
                param1.DAT_04 = (short)(sVar3 + 1);
                break;
            case 5:
                oVar4.FUN_609C8((TodScriptableObject)oVar4.REFS[oVar4.DAT_220 + 1], 1, 10);
                param1.DAT_04++;
                oVar5.DAT_4A = 10;
                SceneManager.instance.DAT_7CDC[1].DAT_4A = 10;
                break;
            case 6:
                oVar4.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar3 = (short)(oVar4.screen.z + 54);
                else
                    sVar3 = (short)(oVar4.screen.z + 46);

                oVar4.screen.z = sVar3;

                if (oVar4.screen.z < 1)
                    return;

                if (param1.DAT_08 != 3)
                {
                    param1.DAT_04++;
                    //sound
                    return;
                }

                if (oVar4.screen.z < 501)
                    return;

                goto LAB_7C470;
            case 7:
                oVar4.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar3 = (short)(oVar4.screen.z + 54);
                else
                    sVar3 = (short)(oVar4.screen.z + 46);

                oVar4.screen.z = sVar3;
                oVar5.screen.x += param2;
                SceneManager.instance.DAT_7CDC[1].screen.x -= param2;

                if (oVar5.screen.x < 0)
                    return;

                LAB_7C470:
                param1.DAT_02++;
                break;
        }
    }

    public void FUN_7C4A4()
    {
        FUN_7C190(loader, 70, 2100);
    }

    public void FUN_7C4C8()
    {
        FUN_7C190(loader, 50, 910);
    }

    public void FUN_7C4EC()
    {
        FUN_7C190(loader, 100, 800);
    }

    public void FUN_7C510()
    {
        short sVar1;
        CriStatic oVar2;
        uint uVar4;
        CriPlayer oVar5;
        CriBone oVar6;

        CoroutineLoader param1 = loader;
        oVar2 = SceneManager.instance.DAT_7CDC[0];
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80191fcc], 0x20, 0);
                oVar5.FUN_60AB4();
                param1.DAT_08 = 4;
                param1.DAT_04++;
                FUN_46C0C(0, 20, 1);
                goto LAB_7C8CC;
            case 1:
                if (DAT_6D) break;

                goto LAB_7C650;
            case 2:
                oVar5.FUN_60AB4();

                if (oVar5.DAT_60 < 9U) break;

                //sound
                goto LAB_7C650;
            case 3:
                oVar5.FUN_60AB4();
                oVar2.screen.x -= 50;
                SceneManager.instance.DAT_7CDC[1].screen.x += 50;

                if (-910 < oVar2.screen.x) break;

                LAB_7C650:
                param1.DAT_04++;
                break;
            case 4:
                oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80192664], 9, 10);
                param1.DAT_04++;
                oVar2.DAT_4A = 10;
                SceneManager.instance.DAT_7CDC[1].DAT_4A = 10;
                break;
            case 5:
                oVar5.FUN_60AB4();
                oVar5.screen.z += 27;

                if ((oVar5.frames[oVar5.frameNum].DAT_03 & 3) != 0)
                {
                    uVar4 = 244;

                    if ((oVar5.DAT_1C0 & 2) != 0)
                        uVar4 = 245;

                    //sound
                    oVar5.DAT_1C0 ^= 2;
                }

                sVar1 = (short)oVar5.screen.z;

                if (0 < sVar1)
                    param1.DAT_04++;

                if (-500 < sVar1)
                {
                    //...
                    param1.DAT_14.x += 8;
                    param1.DAT_14.y += 8;
                    param1.DAT_14.z += 8;

                    if (0x80 < param1.DAT_14.x)
                        param1.DAT_14 = new Vector3Int(0x80, 0x80, 0x80);
                }

                break;
            case 6:
                //...
                oVar5.FUN_60AB4();
                oVar5.screen.z += 27;

                if ((oVar5.frames[oVar5.frameNum].DAT_03 & 3) != 0)
                {
                    uVar4 = 244;

                    if ((oVar5.DAT_1C0 & 2) != 0)
                        uVar4 = 245;

                    //sound
                    oVar5.DAT_1C0 ^= 2;
                }

                if (2000 < oVar5.screen.z)
                {
                    param1.DAT_02++;
                    break;
                }

                if (oVar5.screen.z < 1301) break;

                param1.DAT_14.x -= 0x10;
                param1.DAT_14.y -= 0x10;
                param1.DAT_14.z -= 0x10;

                if (-1 < param1.DAT_14.x) break;

                LAB_7C8CC:
                param1.DAT_14 = new Vector3Int(0, 0, 0);
                break;
        }

        oVar6 = (CriBone)Utilities.FUN_601C8(oVar5.skeleton, 7);
        sVar1 = (short)(((oVar6.screen.y + 200) * 0x10000) >> 0x10);
        SceneManager.instance.FUN_26504(0, (short)oVar5.screen.x, sVar1, (short)(oVar5.screen.z + 100));
        SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, sVar1, (short)(oVar5.screen.z + 1000));
    }

    public void FUN_7C940()
    {
        CriStatic oVar1;
        short sVar2;
        CriPlayer oVar3;

        CoroutineLoader param1 = loader;
        oVar1 = SceneManager.instance.DAT_7CDC[0];
        sVar2 = param1.DAT_04;
        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar2 == 1)
        {
            if (!DAT_6D)
            {
                param1.DAT_04++;
                oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220 + 1], 1, 10);
                oVar1.DAT_4A = 10;
                SceneManager.instance.DAT_7CDC[1].DAT_4A = 10;
            }
        }
        else
        {
            if (sVar2 < 2)
            {
                if (sVar2 == 0)
                {
                    oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220], 1, 0);
                    oVar3.FUN_60AB4();
                    param1.DAT_08 = 4;
                    param1.DAT_04++;
                    oVar1.screen.x = -910;
                    oVar1.DAT_4A = 10;
                    SceneManager.instance.DAT_7CDC[1].screen.x = 910;
                    SceneManager.instance.DAT_7CDC[1].DAT_4A = 10;
                    FUN_46C0C(0, 20, 1);
                }
            }
            else
            {
                if (sVar2 == 2)
                {
                    oVar3.FUN_60AB4();

                    if (param1.DAT_0C == 0)
                        sVar2 = (short)(oVar3.screen.z + 54);
                    else
                        sVar2 = (short)(oVar3.screen.z + 46);

                    oVar3.screen.z = sVar2;

                    if (0 < oVar3.screen.z)
                    {
                        //sound
                        param1.DAT_04++;
                    }
                }
                else
                {
                    if (sVar2 == 3)
                    {
                        oVar3.FUN_60AB4();

                        if (param1.DAT_0C == 0)
                            sVar2 = (short)(oVar3.screen.z + 54);
                        else
                            sVar2 = (short)(oVar3.screen.z + 46);

                        oVar3.screen.z = sVar2;
                        oVar1.screen.x += 70;
                        SceneManager.instance.DAT_7CDC[1].screen.x -= 70;

                        if (-1 < oVar1.screen.x)
                            param1.DAT_02++;
                    }
                }
            }
        }
    }

    public void FUN_7CB50()
    {
        sbyte sVar1;
        short sVar2;
        CriPlayer oVar3;
        CriStatic oVar4;

        CoroutineLoader param1 = loader;
        oVar4 = SceneManager.instance.DAT_7CDC[0];
        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220], 1, 0);
                oVar3.FUN_60AB4();
                param1.DAT_08 = 3;
                param1.DAT_04++;
                FUN_46C0C(0, 20, 1);
                break;
            case 1:
                if (DAT_6D)
                    return;

                goto LAB_7CCC8;
            case 2:
                oVar3.FUN_60AB4();
                sVar1 = (sbyte)(param1.DAT_0D + 1);
                param1.DAT_0D = sVar1;

                if (sVar1 < 31)
                    return;

                sVar2 = param1.DAT_04;
                param1.DAT_0D = 0;
                goto LAB_7CCD0;
            case 3:
                oVar3.FUN_60AB4();

                if (oVar3.DAT_60 < 9U)
                    return;

                //sound
                goto LAB_7CCC8;
            case 4:
                oVar3.FUN_60AB4();
                oVar4.screen.y -= 100;

                if (SceneManager.instance.DAT_7CDC[1].screen.y < 1000)
                    SceneManager.instance.DAT_7CDC[1].screen.y += 100;

                if (-1501 < oVar4.screen.y)
                    return;

                LAB_7CCC8:
                sVar2 = param1.DAT_04;
                LAB_7CCD0:
                param1.DAT_04 = (short)(sVar2 + 1);
                break;
            case 5:
                oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220 + 1], 1, 10);
                param1.DAT_04++;
                oVar4.DAT_4A = 10;
                SceneManager.instance.DAT_7CDC[1].DAT_4A = 10;
                break;
            case 6:
                oVar3.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar2 = (short)(oVar3.screen.z + 54);
                else
                    sVar2 = (short)(oVar3.screen.z + 46);

                oVar3.screen.z = sVar2;

                if (500 < oVar3.screen.z)
                    param1.DAT_02++;

                break;
        }
    }

    private void FUN_7CD88(CoroutineLoader param1, int param2, int param3, bool param4)
    {
        sbyte sVar1;
        short sVar2;
        int iVar3;
        CriPlayer oVar3;
        CriStatic oVar4;

        oVar4 = SceneManager.instance.DAT_7CDC[0];
        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        switch (param1.DAT_04)
        {
            case 0:
                oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220], 1, 0);
                oVar3.FUN_60AB4();
                param1.DAT_08 = 3;
                param1.DAT_04++;
                FUN_46C0C(0, 20, 1);
                return;
            case 1:
                if (DAT_6D)
                    return;

                break;
            case 2:
                oVar3.FUN_60AB4();
                sVar1 = (sbyte)(param1.DAT_0D + 1);
                param1.DAT_0D = sVar1;

                if (sVar1 < 31)
                    return;

                //sound
                sVar2 = param1.DAT_04;
                param1.DAT_0D = 0;
                goto LAB_7CEFC;
            case 3:
                oVar3.FUN_60AB4();
                param2 = oVar4.screen.y - param2;
                oVar4.screen.y = param2;
                iVar3 = param2 * 0x10000 >> 0x10;

                if (-4000 < iVar3)
                {
                    if (param3 < iVar3)
                        return;

                    param1.DAT_04 += 2;
                    oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220 + 1], 1, 10);
                    return;
                }

                oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220 + 1], 1, 10);
                break;
            case 4:
                param2 = oVar4.screen.y - param2;
                oVar4.screen.y = param2;

                if (param2 * 0x10000 >> 0x10 <= param3)
                    param1.DAT_04++;

                goto case 5;
            case 5:
                oVar3.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar2 = (short)(oVar3.screen.z + 54);
                else
                    sVar2 = (short)(oVar3.screen.z + 46);

                oVar3.screen.z = sVar2;

                if (500 < oVar3.screen.z)
                {
                    param1.DAT_02++;

                    if (param4)
                        ; //FUN_5C860
                }

                goto default;
            default:
                return;
        }

        sVar2 = param1.DAT_04;
        LAB_7CEFC:
        param1.DAT_04 = (short)(sVar2 + 1);
    }

    public void FUN_7D008()
    {
        FUN_7CD88(loader, 30, -2500, true);
    }

    public void FUN_7D030()
    {
        FUN_7CD88(loader, 100, -2000, true);
    }

    public void FUN_7D058()
    {
        FUN_7CD88(loader, 30, -5000, true);
    }

    public void FUN_7D080()
    {
        CriStatic oVar1;
        short sVar2;
        short sVar3;
        CriPlayer oVar4;

        CoroutineLoader param1 = loader;
        oVar1 = SceneManager.instance.DAT_7CDC[0];
        sVar2 = param1.DAT_04;
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar2 == 1)
        {
            if (DAT_6D)
                return;

            oVar4.FUN_609C8((TodScriptableObject)oVar4.REFS[oVar4.DAT_220 + 1], 1, 10);
        }
        else
        {
            if (sVar2 < 2)
            {
                if (sVar2 != 0)
                    return;

                oVar4.FUN_609C8((TodScriptableObject)oVar4.REFS[oVar4.DAT_220], 1, 0);
                oVar4.FUN_60AB4();
                param1.DAT_08 = 4;
                param1.DAT_04++;
                oVar1.screen.y = -2000;
                oVar1.DAT_4A = 10;
                FUN_46C0C(0, 20, 1);
                return;
            }

            if (sVar2 != 2)
            {
                if (sVar2 != 3)
                    return;

                oVar4.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar2 = (short)(oVar4.screen.z + 54);
                else
                    sVar2 = (short)(oVar4.screen.z + 46);

                oVar4.screen.z = sVar2;
                sVar3 = (short)(oVar1.screen.y + 100);
                oVar1.screen.y = sVar3;

                if (sVar3 << 0x10 < 0)
                    return;

                param1.DAT_02++;
                return;
            }

            oVar4.FUN_60AB4();

            if (param1.DAT_0C == 0)
                sVar2 = (short)(oVar4.screen.z + 54);
            else
                sVar2 = (short)(oVar4.screen.z + 46);

            oVar4.screen.z = sVar2;

            if (oVar4.screen.z < 1)
                return;

            //sound
        }

        param1.DAT_04++;
    }

    private void FUN_7D250(CoroutineLoader param1)
    {
        uint uVar2;
        uint uVar3;
        CriPlayer oVar4;
        Vector2Int[] local_20;

        local_20 = new Vector2Int[4]
        {
            new Vector2Int(21, 28), 
            new Vector2Int(20, 28), 
            new Vector2Int(14, 19), 
            new Vector2Int(14, 19)
        };
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar4.FUN_60AB4();

        if (param1.DAT_0C != 0)
        {
            if (oVar4.DAT_60 == 13)
                ; //sound
            else
            {
                if (oVar4.DAT_60 == 28)
                {
                    //sound
                    oVar4.screen.z -= 3;
                }
            }

            uVar2 = 3;

            if (oVar4.DAT_60 < 16U)
                uVar2 = 2;

            goto LAB_7D374;
        }

        if (oVar4.DAT_60 == 8)
        {
            uVar3 = 240;
            //sound
        }
        else
        {
            if (oVar4.DAT_60 == 19)
            {
                uVar3 = 241;
                //sound
            }
        }

        uVar2 = (oVar4.DAT_60 < 11U ? 1U : 0) ^ 1;
        LAB_7D374:
        oVar4.screen.y -= local_20[uVar2].x;
        oVar4.screen.z += local_20[uVar2].y;
    }

    private void FUN_7D3BC(CoroutineLoader param1, bool param2, int param3, bool param4)
    {
        sbyte sVar1;
        CriStatic oVar2;
        short sVar4;
        CriPlayer oVar5;
        int iVar5;
        uint uVar6;
        byte bVar7;
        uint puVar8;
        Vector3Int local_40;
        Matrix3x3 MStack56;

        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar2 = SceneManager.instance.DAT_7CDC[0];

        switch (param1.DAT_04)
        {
            case 0:
                param1.DAT_08 = 2;
                oVar2.DAT_48 = 1;
                param1.DAT_04++;

                if (!param2)
                {
                    if (param1.DAT_0C == 0)
                    {
                        oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80191fcc], 1, 0);
                        oVar5.FUN_60AB4();
                        puVar8 = 0x8018da38;
                    }
                    else
                    {
                        oVar5.FUN_609C8((TodScriptableObject)oVar5.REFS[oVar5.DAT_220], 1, 0);
                        oVar5.FUN_60AB4();
                        puVar8 = 0x8018e8b8;
                    }

                    bVar7 = 8;
                }
                else
                {
                    if (param1.DAT_0C == 0)
                    {
                        puVar8 = 0x8018da38;
                        bVar7 = 0;
                    }
                    else
                    {
                        puVar8 = 0x8018e8b8;
                        bVar7 = 0;
                    }
                }

                oVar5.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[puVar8], 1, bVar7);
                oVar5.FUN_60AB4();
                FUN_46C0C(0, 20, 1);
                DAT_C7CF8 = new Vector3Int(0, 0, -0xa00);
                DAT_C7D00 = new Vector3Int(0, 0x100, 0);
                iVar5 = Utilities.Rand();
                DAT_C7D08 = (byte)(iVar5 + (iVar5 / 15) * -15);
                uVar6 = (uint)Utilities.Rand();

                if ((uVar6 & 1) == 0)
                    DAT_C7CF0 = false;
                else
                    DAT_C7CF0 = true;

                break;
            case 1:
                goto LAB_7D414;
            case 2:
                FUN_7D250(param1);

                if (param3 <= oVar5.screen.y) break;

                if (!param4)
                {
                    sVar4 = (short)(param1.DAT_02 + 1);
                    goto LAB_7D7B8;
                }

                FUN_46C0C(1, 20, 1);
                goto LAB_7D414;
            case 3:
                FUN_7D250(param1);

                if (DAT_6D) break;

                sVar4 = param1.DAT_04;
                param1.DAT_14 = new Vector3Int(0, 0, 0);
                goto LAB_7D724;
            case 4:
                FUN_7D250(param1);
                //...
                param1.DAT_14.x += 8;
                param1.DAT_14.y += 8;
                param1.DAT_14.z += 8;

                if (0x80 < param1.DAT_14.x)
                {
                    param1.DAT_14 = new Vector3Int(0x80, 0x80, 0x80);
                    param1.DAT_04++;
                }

                break;
            case 5:
                FUN_7D250(param1);
                //...
                sVar1 = param1.DAT_0D;
                param1.DAT_0D = (sbyte)(sVar1 + 1);

                if ((byte)sVar1 < 61U) break;

                LAB_7D414:
                sVar4 = param1.DAT_04;
                LAB_7D724:
                param1.DAT_04 = (short)(sVar4 + 1);
                break;
            case 6:
                FUN_7D250(param1);
                //...
                param1.DAT_14.x -= 0x10;
                param1.DAT_14.y -= 0x10;
                param1.DAT_14.z -= 0x10;

                if (-1 < param1.DAT_14.x) break;

                param1.DAT_14 = new Vector3Int(0, 0, 0);
                sVar4 = (short)(param1.DAT_02 + 2);
                LAB_7D7B8:
                param1.DAT_02 = sVar4;
                break;
        }

        if (DAT_47 == 14)
            DAT_C7D00.y = DAT_C7D00.y - DAT_C7D08 & 0xfff;

        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref DAT_C7D00, ref MStack56);
        local_40 = Utilities.ApplyMatrixSV(ref MStack56, ref DAT_C7CF8);
        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, (short)(oVar5.screen.y - 0x400), (short)oVar5.screen.z);
        SceneManager.instance.FUN_26504(0, (short)(local_40.x + oVar5.screen.x), (short)(local_40.y + oVar5.screen.y - 0x700), (short)(local_40.z + oVar5.screen.z));
    }

    public void FUN_7D894()
    {
        FUN_7D3BC(loader, false, -2200, false);
    }

    public void FUN_7D8BC()
    {
        FUN_7D3BC(loader, false, -780, true);
    }

    public void FUN_7D8E4()
    {
        FUN_7D3BC(loader, true, -2200, false);
    }

    public void FUN_7D90C()
    {
        short sVar1;
        CriStatic oVar2;
        uint uVar3;
        int iVar4;
        uint puVar5;
        int iVar6;
        CriPlayer oVar6;
        Vector2Int[] local_20;
        Vector3Int local_48;
        Matrix3x3 MStack64;

        CoroutineLoader param1 = loader;
        local_20 = new Vector2Int[4]
        {
            new Vector2Int(21, 27),
            new Vector2Int(20, 28),
            new Vector2Int(14, 19),
            new Vector2Int(15, 19)
        };
        sVar1 = param1.DAT_04;
        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar1 == 1)
        {
            if (!DAT_6D)
                param1.DAT_04++;
        }
        else
        {
            if (sVar1 < 2)
            {
                if (sVar1 == 0)
                {
                    param1.DAT_08 = 2;
                    oVar2 = SceneManager.instance.DAT_7CDC[0];
                    oVar2.DAT_48 = 1;
                    param1.DAT_04++;

                    if (param1.DAT_0C == 0)
                    {
                        oVar6.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80191fcc], 1, 0);
                        oVar6.FUN_60AB4();
                        puVar5 = 0x8018e178;
                    }
                    else
                    {
                        oVar6.FUN_609C8((TodScriptableObject)oVar6.REFS[oVar6.DAT_220], 1, 0);
                        oVar6.FUN_60AB4();
                        puVar5 = 0x8018f340;
                    }

                    oVar6.FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[puVar5], 1, 8);
                    oVar6.FUN_60AB4();
                    FUN_46C0C(0, 20, 1);
                    DAT_C7D10 = new Vector3Int(0, 0, 0xa00);
                    DAT_C7D18 = new Vector3Int(0, 0x100, 0);
                    iVar6 = Utilities.Rand();
                    iVar4 = 12 >> (param1.DAT_0C & 0x1f);

                    if (iVar4 == 0)
                        return; //trap(0x1c00)

                    if (iVar4 == -1 && iVar6 == -0x80000000)
                        return; //trap(0x1800)

                    DAT_C7D20 = (byte)(iVar6 % iVar4);
                    uVar3 = (uint)Utilities.Rand();

                    if ((uVar3 & 1) == 0)
                        DAT_C7D0A = false;
                    else
                        DAT_C7D0A = true;
                }
            }
            else
            {
                if (sVar1 == 2)
                {
                    oVar6.FUN_60AB4();

                    if (param1.DAT_0C == 0)
                    {
                        if (oVar6.DAT_60 == 11)
                            ; //sound
                        else
                        {
                            if (oVar6.DAT_60 == 0)
                            {
                                //sound
                                oVar6.screen.z -= 3;
                            }
                        }

                        uVar3 = (oVar6.DAT_60 < 11U ? 1U : 0) ^ 1;
                    }
                    else
                    {
                        if (oVar6.DAT_60 == 16)
                        {
                            //sound
                            oVar6.screen.y -= 3;
                        }
                        else
                        {
                            if (oVar6.DAT_60 == 1)
                            {
                                //sound
                                oVar6.screen.y -= 2;
                                oVar6.screen.z -= 3;
                            }
                        }

                        uVar3 = 3;

                        if (oVar6.DAT_60 < 16U)
                            uVar3 = 2;
                    }

                    oVar6.screen.y += local_20[uVar3].x;
                    oVar6.screen.z += local_20[uVar3].y;

                    if (2399 < oVar6.screen.y)
                        param1.DAT_02++;
                }
            }
        }

        if (DAT_47 != 17)
            DAT_C7D18.y = DAT_C7D18.y + DAT_C7D20 & 0xfff;

        MStack64 = new Matrix3x3();
        Utilities.RotMatrix(ref DAT_C7D18, ref MStack64);
        local_48 = Utilities.ApplyMatrixSV(ref MStack64, ref DAT_C7D10);
        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_264C4(0, (short)oVar6.screen.x, (short)(oVar6.screen.y - 0x400), (short)oVar6.screen.z);
        SceneManager.instance.FUN_26504(0, (short)(local_48.x + oVar6.screen.x), (short)(local_48.y + oVar6.screen.y - 0x700), (short)(local_48.z + oVar6.screen.z));
    }

    public void FUN_7DD0C()
    {
        CriStatic oVar1;
        short sVar2;
        uint uVar3;
        LoadDoorContainer dVar4;
        CriPlayer oVar5;

        CoroutineLoader param1 = loader;
        oVar1 = SceneManager.instance.DAT_7CDC[0];
        dVar4 = DAT_A89A0[DAT_47];
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (param1.DAT_04 == 0)
        {
            uVar3 = (uint)Utilities.Rand();

            if ((uVar3 & 1) != 0)
                SceneManager.instance.FUN_26504(0, (short)dVar4.DAT_0E.x, (short)dVar4.DAT_0E.y, (short)dVar4.DAT_0E.z);

            oVar1.DAT_48 = 2;
            param1.DAT_08 = 5;
            param1.DAT_04++;

            if (param1.DAT_0C == 0)
            {
                oVar5.FUN_609C8((TodScriptableObject)dVar4.ram.objects[0x8015dd74], 1, 0);
                oVar5.screen.y = -0x240;
            }
            else
            {
                oVar5.FUN_609C8((TodScriptableObject)dVar4.ram.objects[0x8015eaf0], 1, 0);
                oVar5.screen.y = -0x210;
                SceneManager.instance.FUN_26504(0, (short)dVar4.DAT_0E.x, (short)dVar4.DAT_0E.y, (short)dVar4.DAT_0E.z);
            }

            oVar5.FUN_60AB4();
            FUN_46C0C(0, 20, 1);
        }
        else
        {
            if (param1.DAT_04 == 1)
            {
                oVar5.FUN_60AB4();

                if (param1.DAT_0C == 0)
                {
                    if (oVar5.DAT_60 - 16U < 20)
                        sVar2 = (short)(oVar5.screen.y - 16);
                    else
                        sVar2 = (short)(oVar5.screen.y - 15);

                    oVar5.screen.y = sVar2;

                    if (oVar5.DAT_60 == 15 || oVar5.DAT_60 == 35)
                        ; //sound
                }
                else
                {
                    if (oVar5.DAT_60 - 20U < 27)
                        sVar2 = (short)(oVar5.screen.y - 13);
                    else
                        sVar2 = (short)(oVar5.screen.y - 10);

                    oVar5.screen.y = sVar2;

                    if (oVar5.DAT_60 == 22 || oVar5.DAT_60 == 49)
                    {
                        //sound
                        oVar5.screen.y += 2;
                    }
                }

                if (oVar5.screen.y < -2000)
                    param1.DAT_02++;
            }
        }

        SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, (short)(oVar5.screen.y - 0x500), (short)(oVar5.screen.z));
    }

    public void FUN_7DF78()
    {
        CriStatic oVar1;
        short sVar2;
        uint uVar3;
        LoadDoorContainer dVar4;
        CriPlayer oVar5;

        CoroutineLoader param1 = loader;
        oVar1 = SceneManager.instance.DAT_7CDC[0];
        dVar4 = DAT_A89A0[DAT_47];
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (param1.DAT_04 == 0)
        {
            uVar3 = (uint)Utilities.Rand();

            if ((uVar3 & 1) != 0)
                SceneManager.instance.FUN_26504(0, (short)dVar4.DAT_0E.x, (short)dVar4.DAT_0E.y, (short)dVar4.DAT_0E.z);

            oVar1.DAT_48 = 2;
            param1.DAT_08 = 5;
            param1.DAT_04++;

            if (param1.DAT_0C == 0)
                oVar5.FUN_609C8((TodScriptableObject)dVar4.ram.objects[0x8015dd74], 1, 0);
            else
            {
                oVar5.FUN_609C8((TodScriptableObject)dVar4.ram.objects[0x8015eaf0], 1, 0);
                oVar5.screen.x = 80;
                SceneManager.instance.FUN_26504(0, (short)dVar4.DAT_0E.x, (short)dVar4.DAT_0E.y, (short)dVar4.DAT_0E.z);
            }

            oVar5.FUN_60AB4();
            FUN_46C0C(0, 20, 1);
        }
        else
        {
            if (param1.DAT_04 == 1)
            {
                oVar5.FUN_60AB4();

                if (param1.DAT_0C == 0)
                {
                    if (oVar5.DAT_60 - 16U < 20)
                        sVar2 = (short)(oVar5.screen.y + 16);
                    else
                        sVar2 = (short)(oVar5.screen.y + 15);

                    oVar5.screen.y = sVar2;

                    if (oVar5.DAT_60 == 15 || oVar5.DAT_60 == 35)
                        ; //sound
                }
                else
                {
                    if (oVar5.DAT_60 - 20U < 27)
                        sVar2 = (short)(oVar5.screen.y + 13);
                    else
                        sVar2 = (short)(oVar5.screen.y + 10);

                    oVar5.screen.y = sVar2;

                    if (oVar5.DAT_60 == 22 || oVar5.DAT_60 == 49)
                    {
                        //sound
                        oVar5.screen.y -= 2;
                    }
                }

                if (-450 < oVar5.screen.y)
                    param1.DAT_02++;
            }
        }

        SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, (short)(oVar5.screen.y - 0x600), (short)oVar5.screen.z);
    }

    private void FUN_7E1DC(CoroutineLoader param1, short param2, bool param3)
    {
        short sVar1;
        CriStatic oVar2;
        CriPlayer oVar3;

        sVar1 = param1.DAT_04;
        oVar2 = SceneManager.instance.DAT_7CDC[0];
        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar1 == 1)
        {
            if (!DAT_6D)
            {
                //sound
                param1.DAT_04++;
            }
        }
        else
        {
            if (sVar1 < 2)
            {
                if (sVar1 == 0)
                {
                    oVar3.FUN_609C8((TodScriptableObject)oVar3.REFS[oVar3.DAT_220], 1, 0);
                    oVar3.FUN_60AB4();
                    param1.DAT_08 = 6;
                    param1.DAT_04++;
                    FUN_46C0C(0, 20, 1);
                }
            }
            else
            {
                if (sVar1 == 2)
                {
                    oVar3.FUN_60AB4();
                    oVar2.screen.y += param2;
                    oVar3.screen.y += param2;

                    if (!param3)
                    {
                        if (2299 < oVar2.screen.y)
                            param1.DAT_02++;
                    }
                    else
                    {
                        if (oVar2.screen.y < -2299)
                        {
                            param1.DAT_02++;
                            //...
                        }
                    }
                }
            }
        }
    }

    public void FUN_7E380()
    {
        FUN_7E1DC(loader, -30, true);
    }

    public void FUN_7E3A4()
    {
        FUN_7E1DC(loader, 30, false);
    }

    private void FUN_7E3C8(CoroutineLoader param1, short param2, short param3, bool param4)
    {
        byte bVar1;
        short sVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic piVar5;
        int iVar6;
        CriPlayer oVar6;
        CriStatic[] local_28;

        sVar2 = param1.DAT_04;
        local_28 = new CriStatic[4]
        {
            SceneManager.instance.DAT_7CDC[0],
            SceneManager.instance.DAT_7CDC[1],
            SceneManager.instance.DAT_7CDC[2],
            SceneManager.instance.DAT_7CDC[3]
        };
        oVar4 = SceneManager.instance.DAT_7CDC[0];
        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar2 == 1)
        {
            if (!DAT_6D)
                param1.DAT_04++;
        }
        else
        {
            if (sVar2 < 2)
            {
                if (sVar2 == 0)
                {
                    oVar6.vr.y = 0x800;
                    oVar6.FUN_609C8((TodScriptableObject)oVar6.REFS[oVar6.DAT_220], 1, 0);
                    oVar6.FUN_60AB4();
                    iVar6 = 1;
                    param1.DAT_08 = 6;
                    param1.DAT_04++;
                    oVar4.DAT_48 = 3;
                    bVar1 = DAT_47;

                    do
                    {
                        piVar5 = local_28[iVar6];
                        piVar5.flags = 3;
                        piVar5.DAT_2E = 0;
                        piVar5.DAT_48 = 2;
                        piVar5.DAT_4A = 150;
                        piVar5.cMesh = DAT_A89A0[bVar1].DAT_04;
                        piVar5.vr = new Vector3Int(0, 0, 0);
                        piVar5.screen.z = 0;
                        piVar5.screen.x = 0;
                        piVar5.cCollider = null;
                        iVar6++;
                    } while (iVar6 < 4);

                    local_28[1].screen.y = -1000;
                    local_28[2].screen.y = -2000;
                    local_28[3].screen.y = -3000;
                    FUN_46C0C(0, 20, 1);
                }
            }
            else
            {
                if (sVar2 == 2)
                {
                    oVar6.FUN_60AB4();
                    iVar6 = 0;

                    do
                    {
                        piVar5 = local_28[iVar6];

                        if (!param4)
                        {
                            if (piVar5.screen.y < -3999)
                                piVar5.screen.y = param3;
                        }
                        else
                        {
                            if (-1 < piVar5.screen.y)
                                piVar5.screen.y = param3;
                        }

                        piVar5.screen.y += param2;
                        iVar6++;
                    } while (iVar6 < 4);

                    bVar3 = 100 < DAT_AA3EC;
                    DAT_AA3EC++;

                    if (bVar3)
                    {
                        DAT_AA3EC = 0;
                        param1.DAT_02++;
                    }
                }
            }
        }
    }

    public void FUN_7E674()
    {
        FUN_7E3C8(loader, 30, -4000, true);
    }

    public void FUN_7E69C()
    {
        FUN_7E3C8(loader, -30, 0, false);
    }

    public void FUN_7E6C4()
    {
        sbyte sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar5;
        CriStatic oVar6;
        CriPlayer oVar8;

        CoroutineLoader param1 = loader;
        sVar2 = param1.DAT_04;
        oVar3 = SceneManager.instance.DAT_7CDC[1];
        oVar5 = SceneManager.instance.DAT_7CDC[2];
        oVar6 = SceneManager.instance.DAT_7CDC[3];
        oVar8 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar2 == 1)
        {
            //...
            param1.DAT_14.x += 8;
            param1.DAT_14.y += 8;
            param1.DAT_14.z += 8;

            if (param1.DAT_14.x < 0x81)
                return;

            param1.DAT_14 = new Vector3Int(0x80, 0x80, 0x80);
            param1.DAT_04++;
            return;
        }

        if (sVar2 < 2)
        {
            if (sVar2 != 0)
                return;

            SceneManager.instance.DAT_7CDC[0].flags = 0;
            oVar3.flags = 0;
            param1.DAT_14 = new Vector3Int(0, 0, 0);
            //sound
        }
        else
        {
            if (sVar2 != 2)
            {
                if (sVar2 != 3)
                    return;

                //...
                param1.DAT_14.x -= 0x10;
                param1.DAT_14.y -= 0x10;
                param1.DAT_14.z -= 0x10;

                if (-1 < param1.DAT_14.x)
                    return;

                param1.DAT_14 = new Vector3Int(0, 0, 0);
                param1.DAT_02++;
                return;
            }

            //...
            sVar1 = param1.DAT_0D;
            param1.DAT_0D = (sbyte)(sVar1 + 1);

            if (sVar1 < 21)
                return;
        }

        param1.DAT_04++;
    }

    public void FUN_7E8D4()
    {
        CriStatic oVar1;
        short sVar2;
        short sVar3;
        TodScriptableObject puVar4;
        uint uVar5;
        CriPlayer oVar6;

        CoroutineLoader param1 = loader;
        sVar2 = param1.DAT_04;
        oVar1 = SceneManager.instance.DAT_7CDC[0];
        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar2 == 1)
        {
            if (DAT_6D)
                return;

            param1.DAT_04++;
            //sound
            return;
        }

        if (sVar2 < 2)
        {
            if (sVar2 != 0)
                return;

            oVar1.screen.y = -0x810;
            oVar1.DAT_48 = 1;
            param1.DAT_04++;

            if (param1.DAT_0C == 0)
                puVar4 = (TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80191fcc];
            else
                puVar4 = (TodScriptableObject)oVar6.REFS[oVar6.DAT_220];

            oVar6.FUN_609C8(puVar4, 1, 0);
            oVar6.FUN_60AB4();
            FUN_46C0C(0, 20, 1);
            return;
        }

        if (sVar2 == 2)
        {
            oVar6.FUN_60AB4();
            sVar2 = (short)(oVar1.vr.x + 0x20);
            oVar6.vr.x = sVar2;

            if (sVar2 < 0x201)
                return;

            param1.DAT_04++;

            if (param1.DAT_0C == 0)
                puVar4 = (TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018da38];
            else
                puVar4 = (TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018e8b8];

            oVar6.FUN_609C8(puVar4, 9, 10);
            return;
        }

        if (sVar2 != 3)
            return;

        oVar6.FUN_60AB4();

        if (param1.DAT_0C != 0)
        {
            if (oVar6.DAT_60 == 26)
                ; //sound
            else
            {
                if (oVar6.DAT_60 == 56)
                {
                    //sound
                    oVar6.screen.z -= 3;
                }
            }

            sVar2 = (short)(oVar6.screen.y - 6);
            sVar3 = (short)(oVar6.screen.z + 10);
            goto LAB_7EB00;
        }

        if (oVar6.DAT_60 == 16)
        {
            uVar5 = 244;
            //sound
        }
        else
        {
            if (oVar6.DAT_60 == 38)
            {
                uVar5 = 245;
                //sound
            }
        }

        sVar2 = (short)(oVar6.screen.y - 9);
        sVar3 = (short)(oVar6.screen.z + 14);
        LAB_7EB00:
        oVar6.screen.y = sVar2;
        oVar6.screen.z = sVar3;

        if (0x460 < oVar6.screen.z)
            param1.DAT_02++;
    }

    public void FUN_7EB44()
    {
        byte bVar1;
        sbyte sVar1;
        int iVar3;
        LoadDoorContainer dVar3;
        short sVar4;
        CriPlayer oVar5;
        uint uVar6;
        int iVar7;
        CriStatic piVar8;
        CriStatic[] local_58;

        CoroutineLoader param1 = loader;
        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        iVar7 = 0;
        local_58 = new CriStatic[16];
        bVar1 = DAT_47;
        dVar3 = DAT_A89A0[bVar1];

        do
        {
            local_58[iVar7] = SceneManager.instance.DAT_7CDC[iVar7];
            iVar7++;
        } while (iVar7 < 15);

        switch (param1.DAT_04)
        {
            case 0:
                oVar5.FUN_609C8((TodScriptableObject)oVar5.REFS[oVar5.DAT_220 + 4], 1, 0);
                oVar5.FUN_60AB4();
                SceneManager.instance.FUN_26504(0, (short)dVar3.DAT_0E.x, (short)dVar3.DAT_0E.y, (short)dVar3.DAT_0E.z);
                iVar3 = 1;
                sVar4 = -8000;
                local_58[0].screen.z = 20000;

                do
                {
                    piVar8 = local_58[iVar3];
                    piVar8.flags = 3;
                    piVar8.DAT_2E = 0;
                    piVar8.DAT_48 = 2;
                    piVar8.DAT_4A = 1000;
                    piVar8.cMesh = dVar3.DAT_04;
                    piVar8.screen = new Vector3Int(0, 0, sVar4);
                    piVar8.vr = new Vector3Int(0, 0, 0);
                    piVar8.cCollider = null;
                    sVar4 += 2000;
                    iVar3++;
                } while (iVar3 < 15);

                FUN_46C0C(0, 20, 1);
                sVar4 = (short)(param1.DAT_04 + 1);
                break;
            case 1:
                if (DAT_6D) goto LAB_7EBE4;

                sVar4 = (short)(param1.DAT_04 + 1);
                break;
            case 2:
                oVar5.FUN_60AB4();

                if (param1.DAT_0C == 0)
                    sVar4 = (short)(oVar5.screen.z + 130);
                else
                    sVar4 = (short)(oVar5.screen.z + 111);

                oVar5.screen.z = sVar4;

                if ((oVar5.frames[oVar5.frameNum].DAT_03 & 3) != 0)
                {
                    uVar6 = 244;

                    if ((oVar5.DAT_1C0 & 2) != 0)
                        uVar6 = 245;

                    //sound
                    oVar5.DAT_1C0 ^= 2;
                }

                if (oVar5.screen.z < 0x4901) goto LAB_7EBE4;

                oVar5.FUN_609C8((TodScriptableObject)oVar5.REFS[oVar5.DAT_220], 1, 20);
                goto LAB_7EDF4;
            case 3:
                oVar5.FUN_60AB4();
                sVar1 = param1.DAT_0D;
                param1.DAT_0D = (sbyte)(sVar1 + 1);

                if (sVar1 < 21) goto LAB_7EBE4;

                LAB_7EDF4:
                param1.DAT_0D = 0;
                sVar4 = (short)(param1.DAT_04 + 1);
                break;
            case 4:
                SceneManager.instance.FUN_264C4(0, 0, (short)((byte)param1.DAT_0D * -100 - 0x6f0), 0x4f00);
                SceneManager.instance.FUN_26504(0, -0x3c0, -0x590, 0x4000);
                sVar1 = param1.DAT_0D;
                param1.DAT_0D = (sbyte)(sVar1 + 1);

                if (sVar1 < 21)
                    return;

                param1.DAT_02++;
                return;
            default:
                goto LAB_7EBE4;
        }

        param1.DAT_04 = sVar4;
        LAB_7EBE4:
        SceneManager.instance.FUN_264C4(0, (short)oVar5.screen.x, -0x3d0, (short)oVar5.screen.z);
    }

    public void FUN_7EEB0()
    {
        short sVar1;
        uint uVar2;
        CriPlayer oVar4;

        CoroutineLoader param1 = loader;
        sVar1 = param1.DAT_04;
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (sVar1 == 1)
        {
            if (DAT_6D)
                return;

            param1.DAT_04++;
            return;
        }

        if (sVar1 < 2)
        {
            if (sVar1 != 0)
                return;

            oVar4.FUN_609C8((TodScriptableObject)DAT_A89A0[DAT_47].ram.objects[0x8015d000], 0, 0);
            oVar4.FUN_60AB4();
            uVar2 = 0;
        }
        else
        {
            if (sVar1 != 2)
            {
                if (sVar1 != 3)
                    return;

                oVar4.FUN_60AB4();

                if ((oVar4.frames[oVar4.frameNum].DAT_03 & 3) != 0)
                {
                    uVar2 = 244;

                    if ((oVar4.DAT_1C0 & 2) != 0)
                        uVar2 = 245;

                    //sound
                    oVar4.DAT_1C0 ^= 2;
                }

                if (DAT_6D)
                    return;

                param1.DAT_02 = 2;
                return;
            }

            oVar4.FUN_60AB4();

            if ((oVar4.frames[oVar4.frameNum].DAT_03 & 3) != 0)
            {
                uVar2 = 244;

                if ((oVar4.DAT_1C0 & 2) != 0)
                    uVar2 = 245;

                //sound
                oVar4.DAT_1C0 ^= 2;
            }

            if (oVar4.DAT_60 < 86U)
                return;

            uVar2 = 1;
        }

        FUN_46C0C((int)uVar2, 20, 1);
        param1.DAT_04++;
    }

    public void FUN_7302C()
    {
        CriSkinned oVar2;

        //FUN_72F78
        FUN_72C2C();

        if ((DAT_38 & 2) == 0)
            FUN_73EB8();

        if ((DAT_38 & 1) == 0)
            FUN_731E8();

        //...
        
        for (int i = 0; i < SceneManager.instance.DAT_27C.Length; i++)
        {
            oVar2 = SceneManager.instance.DAT_27C[i];

            if ((oVar2.flags & 1) != 0)
                oVar2.FUN_66208();
        }
    }

    private void FUN_73EB8()
    {
        CriObject puVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        CriBone puVar10;
        int iVar12;
        uint uVar13;
        Vector3Int[] puVar14;
        Vector3[] puVar15;
        CriSkinned oVar18;
        int iVar19;
        int iVar20;
        uint local_48;
        uint local_44;
        int local_2c;

        local_44 = FUN_73DDC();
        local_48 = 0;
        uVar13 = DAT_21;

        if (local_44 != 0)
        {
            local_2c = -1;

            do
            {
                oVar18 = skinnedList[(int)local_48];
                skinnedVertices = new List<Vector3>();
                skinnedColors = new List<Color>();
                puVar10 = oVar18.skeleton;
                puVar15 = oVar18.cSkin.VERTS;
                puVar14 = oVar18.cSkin.NRMLS;
                Coprocessor.colorCode.r = oVar18.tint.r;
                Coprocessor.colorCode.g = oVar18.tint.g;
                Coprocessor.colorCode.b = oVar18.tint.b;
                Coprocessor.colorCode.code = oVar18.tint.a;
                iVar12 = oVar18.boneCount - 1;

                if (iVar12 != local_2c)
                {
                    iVar20 = 0;

                    do
                    {
                        Coprocessor.lightMatrix.l11 = puVar10.lightMatrix.V00;
                        Coprocessor.lightMatrix.l12 = puVar10.lightMatrix.V01;
                        Coprocessor.lightMatrix.l13 = puVar10.lightMatrix.V02;
                        Coprocessor.lightMatrix.l21 = puVar10.lightMatrix.V10;
                        Coprocessor.lightMatrix.l22 = puVar10.lightMatrix.V11;
                        Coprocessor.lightMatrix.l23 = puVar10.lightMatrix.V12;
                        Coprocessor.lightMatrix.l31 = puVar10.lightMatrix.V20;
                        Coprocessor.lightMatrix.l32 = puVar10.lightMatrix.V21;
                        Coprocessor.lightMatrix.l33 = puVar10.lightMatrix.V22;
                        Coprocessor.lightColorMatrix.lr1 = puVar10.colorMatrix.V00;
                        Coprocessor.lightColorMatrix.lr2 = puVar10.colorMatrix.V01;
                        Coprocessor.lightColorMatrix.lr3 = puVar10.colorMatrix.V02;
                        Coprocessor.lightColorMatrix.lg1 = puVar10.colorMatrix.V10;
                        Coprocessor.lightColorMatrix.lg2 = puVar10.colorMatrix.V11;
                        Coprocessor.lightColorMatrix.lg3 = puVar10.colorMatrix.V12;
                        Coprocessor.lightColorMatrix.lb1 = puVar10.colorMatrix.V20;
                        Coprocessor.lightColorMatrix.lb2 = puVar10.colorMatrix.V21;
                        Coprocessor.lightColorMatrix.lb3 = puVar10.colorMatrix.V22;
                        puVar6 = puVar10.prev;
                        Coprocessor.rotationMatrix.rt11 = puVar6.cTransform.rotation.V00;
                        Coprocessor.rotationMatrix.rt12 = puVar6.cTransform.rotation.V01;
                        Coprocessor.rotationMatrix.rt13 = puVar6.cTransform.rotation.V02;
                        Coprocessor.rotationMatrix.rt21 = puVar6.cTransform.rotation.V10;
                        Coprocessor.rotationMatrix.rt22 = puVar6.cTransform.rotation.V11;
                        Coprocessor.rotationMatrix.rt23 = puVar6.cTransform.rotation.V12;
                        Coprocessor.rotationMatrix.rt31 = puVar6.cTransform.rotation.V20;
                        Coprocessor.rotationMatrix.rt32 = puVar6.cTransform.rotation.V21;
                        Coprocessor.rotationMatrix.rt33 = puVar6.cTransform.rotation.V22;
                        Coprocessor.vector0.vx0 = (short)puVar10.DAT_44.x;
                        Coprocessor.vector0.vy0 = (short)puVar10.DAT_44.y;
                        Coprocessor.vector0.vz0 = (short)puVar10.DAT_44.z;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        
                        puVar10.cTransform.position.x = Coprocessor.mathsAccumulator.mac1;
                        puVar10.cTransform.position.y = Coprocessor.mathsAccumulator.mac2;
                        puVar10.cTransform.position.z = Coprocessor.mathsAccumulator.mac3;
                        Coprocessor.accumulator.ir1 = puVar10.cTransform.rotation.V00;
                        Coprocessor.accumulator.ir2 = puVar10.cTransform.rotation.V10;
                        Coprocessor.accumulator.ir3 = puVar10.cTransform.rotation.V20;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        puVar10.cTransform.position.x += puVar6.cTransform.position.x;
                        iVar7 = Coprocessor.accumulator.ir1;
                        iVar8 = Coprocessor.accumulator.ir2;
                        iVar9 = Coprocessor.accumulator.ir3;
                        puVar10.cTransform.rotation.V00 = (short)iVar7;
                        puVar10.cTransform.rotation.V10 = (short)iVar8;
                        puVar10.cTransform.rotation.V20 = (short)iVar9;
                        Coprocessor.accumulator.ir1 = puVar10.cTransform.rotation.V01;
                        Coprocessor.accumulator.ir2 = puVar10.cTransform.rotation.V11;
                        Coprocessor.accumulator.ir3 = puVar10.cTransform.rotation.V21;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        puVar10.cTransform.position.y += puVar6.cTransform.position.y;
                        iVar7 = Coprocessor.accumulator.ir1;
                        iVar8 = Coprocessor.accumulator.ir2;
                        iVar9 = Coprocessor.accumulator.ir3;
                        puVar10.cTransform.rotation.V01 = (short)iVar7;
                        puVar10.cTransform.rotation.V11 = (short)iVar8;
                        puVar10.cTransform.rotation.V21 = (short)iVar9;
                        Coprocessor.accumulator.ir1 = puVar10.cTransform.rotation.V02;
                        Coprocessor.accumulator.ir2 = puVar10.cTransform.rotation.V12;
                        Coprocessor.accumulator.ir3 = puVar10.cTransform.rotation.V22;
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                        puVar10.cTransform.position.z += puVar6.cTransform.position.z;
                        iVar7 = Coprocessor.accumulator.ir1;
                        iVar8 = Coprocessor.accumulator.ir2;
                        iVar9 = Coprocessor.accumulator.ir3;
                        puVar10.cTransform.rotation.V02 = (short)iVar7;
                        puVar10.cTransform.rotation.V12 = (short)iVar8;
                        puVar10.cTransform.rotation.V22 = (short)iVar9;
                        Coprocessor.rotationMatrix.rt11 = puVar10.cTransform.rotation.V00;
                        Coprocessor.rotationMatrix.rt12 = puVar10.cTransform.rotation.V01;
                        Coprocessor.rotationMatrix.rt13 = puVar10.cTransform.rotation.V02;
                        Coprocessor.rotationMatrix.rt21 = puVar10.cTransform.rotation.V10;
                        Coprocessor.rotationMatrix.rt22 = puVar10.cTransform.rotation.V11;
                        Coprocessor.rotationMatrix.rt23 = puVar10.cTransform.rotation.V12;
                        Coprocessor.rotationMatrix.rt31 = puVar10.cTransform.rotation.V20;
                        Coprocessor.rotationMatrix.rt32 = puVar10.cTransform.rotation.V21;
                        Coprocessor.rotationMatrix.rt33 = puVar10.cTransform.rotation.V22;
                        Coprocessor.translationVector._trx = puVar10.cTransform.position.x;
                        Coprocessor.translationVector._try = puVar10.cTransform.position.y;
                        Coprocessor.translationVector._trz = puVar10.cTransform.position.z;
                        puVar10.BoneTransform();
                        Matrix4x4 m = puVar10.transform.localToWorldMatrix;
                        iVar19 = puVar10.DAT_42 - 1;

                        if (iVar19 != local_2c)
                        {
                            do
                            {
                                /*Coprocessor.vector0.vx0 = (short)puVar15[iVar20].x;
                                Coprocessor.vector0.vy0 = (short)puVar15[iVar20].y;
                                Coprocessor.vector0.vz0 = (short)puVar15[iVar20].z;
                                Coprocessor.vector1.vx1 = (short)puVar15[iVar20 + 1].x;
                                Coprocessor.vector1.vy1 = (short)puVar15[iVar20 + 1].y;
                                Coprocessor.vector1.vz1 = (short)puVar15[iVar20 + 1].z;
                                Coprocessor.vector2.vx2 = (short)puVar15[iVar20 + 2].x;
                                Coprocessor.vector2.vy2 = (short)puVar15[iVar20 + 2].y;
                                Coprocessor.vector2.vz2 = (short)puVar15[iVar20 + 2].z;
                                Coprocessor.ExecuteRTPT(12, false);*/
                                //setting screen coords...
                                skinnedVertices.Add(m.MultiplyPoint3x4(puVar15[iVar20]));
                                skinnedVertices.Add(m.MultiplyPoint3x4(puVar15[iVar20 + 1]));
                                skinnedVertices.Add(m.MultiplyPoint3x4(puVar15[iVar20 + 2]));
                                Coprocessor.vector0.vx0 = (short)puVar14[iVar20].x;
                                Coprocessor.vector0.vy0 = (short)puVar14[iVar20].y;
                                Coprocessor.vector0.vz0 = (short)puVar14[iVar20].z;
                                Coprocessor.vector1.vx1 = (short)puVar14[iVar20 + 1].x;
                                Coprocessor.vector1.vy1 = (short)puVar14[iVar20 + 1].y;
                                Coprocessor.vector1.vz1 = (short)puVar14[iVar20 + 1].z;
                                Coprocessor.vector2.vx2 = (short)puVar14[iVar20 + 2].x;
                                Coprocessor.vector2.vy2 = (short)puVar14[iVar20 + 2].y;
                                Coprocessor.vector2.vz2 = (short)puVar14[iVar20 + 2].z;
                                Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                                //modifying screen coords...
                                iVar7 = Coprocessor.accumulator.ir1;
                                iVar8 = Coprocessor.accumulator.ir2;
                                iVar9 = Coprocessor.accumulator.ir3;
                                DAT_1f800380 = new Vector3Int(iVar7, iVar8, iVar9);
                                Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V1, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                                //modifying screen coords...
                                iVar7 = Coprocessor.accumulator.ir1;
                                iVar8 = Coprocessor.accumulator.ir2;
                                iVar9 = Coprocessor.accumulator.ir3;
                                DAT_1f800388 = new Vector3Int(iVar7, iVar8, iVar9);
                                Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V2, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
                                //modifying screen coords...
                                iVar7 = Coprocessor.accumulator.ir1;
                                iVar8 = Coprocessor.accumulator.ir2;
                                iVar9 = Coprocessor.accumulator.ir3;
                                DAT_1f800390 = new Vector3Int(iVar7, iVar8, iVar9);
                                Coprocessor.vector0.vx0 = (short)DAT_1f800380.x;
                                Coprocessor.vector0.vy0 = (short)DAT_1f800380.y;
                                Coprocessor.vector0.vz0 = (short)DAT_1f800380.z;
                                Coprocessor.vector1.vx1 = (short)DAT_1f800388.x;
                                Coprocessor.vector1.vy1 = (short)DAT_1f800388.y;
                                Coprocessor.vector1.vz1 = (short)DAT_1f800388.z;
                                Coprocessor.vector2.vx2 = (short)DAT_1f800390.x;
                                Coprocessor.vector2.vy2 = (short)DAT_1f800390.y;
                                Coprocessor.vector2.vz2 = (short)DAT_1f800390.z;
                                Coprocessor.ExecuteNCCT(12, true);
                                //setting color rgb...
                                skinnedColors.Add(new Color32
                                    (Coprocessor.colorFIFO.r0, Coprocessor.colorFIFO.g0, Coprocessor.colorFIFO.b0, Coprocessor.colorFIFO.cd0));
                                skinnedColors.Add(new Color32
                                    (Coprocessor.colorFIFO.r1, Coprocessor.colorFIFO.g1, Coprocessor.colorFIFO.b1, Coprocessor.colorFIFO.cd1));
                                skinnedColors.Add(new Color32
                                    (Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2));
                                iVar19--;
                                iVar20 += 3;
                            } while (iVar19 != -1);
                        }

                        if (puVar10.cMesh != null)
                            puVar10.FUN_7503C(puVar10.cMesh);

                        puVar10 = (CriBone)puVar10.next;
                        iVar12--;
                    } while (iVar12 != local_2c);
                }

                local_48++;
                oVar18.FUN_7569C(oVar18.cSkin);
            } while (local_48 < local_44);
        }
    }

    private int FUN_73DB4(byte[] param1, int param2, int param3)
    {
        if ((uint)param1[param3] <= param1[param2])
            return param1[param2] != param1[param3] ? 1 : 0;

        return -1;
    }

    public int FUN_53B08(byte[] param1, int param2, int param3)
    {
        uint uVar1;
        uint uVar2;

        uVar1 = (uint)(param1[param2] | param1[param2 + 1] << 8 | param1[param2 + 2] << 0x10 | param1[param2 + 3] << 0x18);
        uVar2 = (uint)(param1[param3] | param1[param3 + 1] << 8 | param1[param3 + 2] << 0x10 | param1[param3 + 3] << 0x18);

        if (uVar2 <= uVar1)
            return uVar1 != uVar2 ? 1 : 0;

        return -1;
    }

    private uint FUN_73DDC()
    {
        byte bVar1;
        CriSkinned pbVar3;
        int pbVar4;
        uint uVar5;
        int piVar6;
        uint uVar7;
        byte[] local_20;

        uVar7 = 0;
        uVar5 = 0;
        local_20 = new byte[24];
        pbVar4 = 0;

        do
        {
            pbVar3 = SceneManager.instance.DAT_27C[uVar5];

            if (pbVar3 != null && (pbVar3.flags & 2) != 0)
            {
                bVar1 = pbVar3.DAT_1A5;
                uVar7++;
                local_20[pbVar4 + 1] = (byte)uVar5;
                local_20[pbVar4] = bVar1;
                pbVar4 += 2;
            }

            uVar5++;
        } while (uVar5 < 11);

        Utilities.QSort(local_20, 0, uVar7, 2, FUN_73DB4);
        skinnedList.Clear();
        uVar5 = 0;

        if (uVar7 != 0)
        {
            piVar6 = 0;

            do
            {
                pbVar4 = piVar6 + 1;
                piVar6 += 2;
                uVar5++;
                skinnedList.Add(SceneManager.instance.DAT_27C[local_20[pbVar4]]);
            } while (uVar5 < uVar7);
        }

        return uVar7;
    }

    private void FUN_731E8()
    {
        byte bVar1;
        TmdScriptableObject puVar4;
        CriStatic puVar10;

        for (int i = 0; i < sceneManager.DAT_7CDC.Length; i++)
        {
            puVar10 = sceneManager.DAT_7CDC[i] as CriStatic;

            if (puVar10 != null && (puVar10.flags & 3) == 3)
            {
                //if...
                Coprocessor.rotationMatrix.rt11 = puVar10.cTransform.rotation.V00;
                Coprocessor.rotationMatrix.rt12 = puVar10.cTransform.rotation.V01;
                Coprocessor.rotationMatrix.rt13 = puVar10.cTransform.rotation.V02;
                Coprocessor.rotationMatrix.rt21 = puVar10.cTransform.rotation.V10;
                Coprocessor.rotationMatrix.rt22 = puVar10.cTransform.rotation.V11;
                Coprocessor.rotationMatrix.rt23 = puVar10.cTransform.rotation.V12;
                Coprocessor.rotationMatrix.rt31 = puVar10.cTransform.rotation.V20;
                Coprocessor.rotationMatrix.rt32 = puVar10.cTransform.rotation.V21;
                Coprocessor.rotationMatrix.rt33 = puVar10.cTransform.rotation.V22;
                bVar1 = puVar10.DAT_48;
                puVar4 = puVar10.cMesh;
                puVar10.FUN_75BEC(puVar4, puVar4.TRI_COUNT);

                //if (bVar1 == 1)
                //{
                    puVar10.FUN_75F10(puVar4, puVar4.QUAD_COUNT);
                //}
                //else
                //{
                //...
                //}
            }
        }
    }

    private void FUN_72C2C()
    {
        CriObject puVar8;
        int iVar9;
        CriCamera oVar9;
        CriSkinned pMVar12;
        CriBone m;

        oVar9 = SceneManager.instance.cCamera;
        Coprocessor.rotationMatrix.rt11 = 4095;
        Coprocessor.rotationMatrix.rt12 = 0;
        Coprocessor.rotationMatrix.rt13 = 0;
        Coprocessor.rotationMatrix.rt21 = 0;
        Coprocessor.rotationMatrix.rt22 = 4095;
        Coprocessor.rotationMatrix.rt23 = 0;
        Coprocessor.rotationMatrix.rt31 = 0;
        Coprocessor.rotationMatrix.rt32 = 0;
        Coprocessor.rotationMatrix.rt33 = 4095;
        oVar9.cTransform.position.x = oVar9.screen.x;
        oVar9.cTransform.position.y = oVar9.screen.y;
        oVar9.cTransform.position.z = oVar9.screen.z;
        Coprocessor.translationVector._trx = 0;
        Coprocessor.translationVector._try = 0;
        Coprocessor.translationVector._trz = 0;
        DAT_1f80002c = new Vector3Int(0, 0, 0);

        for (int i = 0; i < sceneManager.DAT_27C.Length; i++)
        {
            pMVar12 = sceneManager.DAT_27C[i];

            if ((pMVar12.flags & 2) != 0)
            {
                if (!pMVar12.DAT_1A2)
                    Utilities.RotMatrix(ref pMVar12.vr, ref DAT_1f800034);
                else
                    Utilities.RotMatrixYXZ(ref pMVar12.vr, ref DAT_1f800034);

                FUN_72ADC(ref pMVar12.cTransform);
                Utilities.ScaleMatrix(ref pMVar12.cTransform.rotation, ref pMVar12.skinSize);
                m = pMVar12.skeleton;
                iVar9 = pMVar12.boneCount - 1;

                while (iVar9 != -1)
                {
                    if (!m.DAT_43)
                        Utilities.RotMatrix(ref m.vr, ref m.cTransform.rotation);
                    else
                        Utilities.RotMatrixYXZ(ref m.vr, ref m.cTransform.rotation);

                    iVar9--;
                    m.DAT_4C = m.screen;
                    m = m.next as CriBone;
                }
            }
        }

        for (int i = 0; i < sceneManager.DAT_7CDC.Length; i++)
        {
            puVar8 = sceneManager.DAT_7CDC[i];

            if (puVar8 != null && (puVar8.flags & 2) != 0)
            {
                Utilities.RotMatrix(ref puVar8.vr, ref DAT_1f800034);

                //if ()
                FUN_72ADC(ref puVar8.cTransform);
            }
        }

        for (int i = 0; i < sceneManager.DAT_5FCC.Length; i++)
        {

        }
    }

    private void FUN_72ADC(ref CriTransform param1)
    {
        int iVar1;
        int iVar2;
        int iVar3;

        Coprocessor.accumulator.ir1 = DAT_1f800034.V00;
        Coprocessor.accumulator.ir2 = DAT_1f800034.V10;
        Coprocessor.accumulator.ir3 = DAT_1f800034.V20;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        DAT_1f800034.V20 = (short)(param1.position.x - DAT_1f80002c.x);
        iVar1 = Coprocessor.accumulator.ir1;
        iVar2 = Coprocessor.accumulator.ir2;
        iVar3 = Coprocessor.accumulator.ir3;
        param1.rotation.V00 = (short)iVar1;
        param1.rotation.V10 = (short)iVar2;
        param1.rotation.V20 = (short)iVar3;
        Coprocessor.accumulator.ir1 = DAT_1f800034.V01;
        Coprocessor.accumulator.ir2 = DAT_1f800034.V11;
        Coprocessor.accumulator.ir3 = DAT_1f800034.V21;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        DAT_1f800034.V21 = (short)(param1.position.y - DAT_1f80002c.y);
        iVar1 = Coprocessor.accumulator.ir1;
        iVar2 = Coprocessor.accumulator.ir2;
        iVar3 = Coprocessor.accumulator.ir3;
        param1.rotation.V01 = (short)iVar1;
        param1.rotation.V11 = (short)iVar2;
        param1.rotation.V21 = (short)iVar3;
        Coprocessor.accumulator.ir1 = DAT_1f800034.V02;
        Coprocessor.accumulator.ir2 = DAT_1f800034.V12;
        Coprocessor.accumulator.ir3 = DAT_1f800034.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        DAT_1f800034.V22 = (short)(param1.position.z - DAT_1f80002c.z);
        iVar1 = Coprocessor.accumulator.ir1;
        iVar2 = Coprocessor.accumulator.ir2;
        iVar3 = Coprocessor.accumulator.ir3;
        param1.rotation.V02 = (short)iVar1;
        param1.rotation.V12 = (short)iVar2;
        param1.rotation.V22 = (short)iVar3;
        Coprocessor.vector0.vx0 = DAT_1f800034.V20;
        Coprocessor.vector0.vy0 = DAT_1f800034.V21;
        Coprocessor.vector0.vz0 = DAT_1f800034.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, false);
        iVar1 = Coprocessor.mathsAccumulator.mac1;
        param1.position.x = iVar1;
        iVar1 = Coprocessor.mathsAccumulator.mac2;
        param1.position.y = iVar1;
        iVar1 = Coprocessor.mathsAccumulator.mac3;
        param1.position.z = iVar1;
    }

    public int FUN_64C80()
    {
        uint uVar1;
        uint uVar2;
        int iVar3;

        iVar3 = 0;
        uVar2 = 0;
        uVar1 = DAT_1f80000a;

        do
        {
            if ((uVar1 & 1) != 0)
                iVar3++;

            uVar2++;
            uVar1 = (uint)(DAT_1f80000a >> (int)(uVar2 & 0x1f));
        } while (uVar2 < 8);

        uVar1 = 0;

        do
        {
            if ((DAT_1f80000a & 0x2000) != 0)
                iVar3++;

            uVar1++;
        } while (uVar1 < 4);

        return iVar3;
    }

    public int FUN_64CF0()
    {
        uint uVar1;
        uint uVar2;
        int iVar3;

        uVar2 = DAT_1f80000a;
        uVar1 = 0;
        iVar3 = 0;

        do
        {
            iVar3 += (int)(uVar2 & 1);
            uVar1++;
            uVar2 >>= 1;
        } while (uVar1 < 0x10);

        return iVar3;
    }

    public static void FUN_2B6F4(CriPlayer param1)
    {
        param1.FUN_2B6F4();
    }

    public static void FUN_2D6C8(CriPlayer param1)
    {
        param1.FUN_2D6C8();
    }

    public static uint FUN_64650()
    {
        uint uVar1;
        uint uVar2;

        uVar1 = LevelManager.instance.DAT_B58BA * 3U;
        uVar2 = LevelManager.instance.DAT_B58BA + ((uVar1 & 0xffff) >> 8) & 0xff;
        LevelManager.instance.DAT_B58BA = (ushort)(uVar2 | uVar1 & 0xff00U);
        return uVar2;
    }

    public static bool FUN_64C68()
    {
        return (DAT_1f80000a & 0xf0f0) != 0;
    }
}
