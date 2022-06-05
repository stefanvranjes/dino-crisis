using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    public ScnScriptableObject scn;
    public DatabaseScriptableObject database;
    public SceneColliderScriptableObject sceneCollision; //0x154
    public CriSkinned[] DAT_27C; //gp+27ch...gp+1c9ch
    public CriBone[] DAT_1C9C; //gp+1c9ch...gp+5fcch
    public CriObject[] DAT_5FCC; //gp+5fcch...gp+7cdch
    public CriStatic[] DAT_7CDC; //gp+7cdch...gp+8ffch

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
        DAT_27C = new CriSkinned[11];
        DAT_1C9C = new CriBone[100];
        DAT_5FCC = new CriObject[60];
        DAT_7CDC = new CriStatic[40];

        for (int i = 0; i < scn.staticObjs.Count; i++)
        {
            FUN_570A0(scn.staticObjs[i]);
        }

        for (int i = 0; i < 40; i++)
        {
            GameObject obj = new GameObject();
            DAT_1C9C[i] = obj.AddComponent<CriBone>();
        }

        FUN_47BE0();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FUN_47BE0()
    {
        CriPlayer oVar3;

        GameManager.instance.DAT_55 = 0;
        GameManager.instance.DAT_21 = 6;
        GameManager.instance.DAT_28++;
        //FUN_6E6C8

        if (GameManager.instance.DAT_9AA1 != GameManager.instance.DAT_9ADD)
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

    private void FUN_570A0(_STATIC_OBJ_DATA data)
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
    }

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

    public bool FUN_64210(ref Vector3Int param1, byte param2, uint param3)
    {
        byte bVar1;
        bool bVar2;
        bool bVar3;
        ColliderSegment oVar4;
        FloorCollider puVar5;
        uint uVar7;
        short local_28;

        if (param2 < 0x10)
        {
            if (param2 < 0)
                param2 = 0;

            oVar4 = sceneCollision.SEGMENTS[param2 << 0x18 >> 0x14];
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
                        }
                    }
                }
            }
        }
    }
}
