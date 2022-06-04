using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

public delegate void FUN_148(CriPlayer p);
public delegate void FUN_14C(CriPlayer p);

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static SceneManager sceneManager;

    private static ushort DAT_B58BA;

    public ushort DAT_1f800008;
    public ushort DAT_1f80000a;
    public ushort DAT_1f800024;
    public ushort DAT_1f800026;
    public ushort DAT_1f800028;
    public ushort DAT_1f80002a;
    public Vector3Int DAT_1f80002c;
    public Matrix3x3 DAT_1f800034;
    public Vector3Int DAT_1f800380;
    public Vector3Int DAT_1f800388;
    public Vector3Int DAT_1f800390;
    public List<Vector3Int> todUncomp;
    public byte DAT_21; //gp+21h
    public ushort DAT_28; //gp+28h
    public byte DAT_38; //gp+38h
    public byte DAT_40; //gp+40h
    public Vector3Int playerSpawnPos; //gp+4ch
    public short playerSpawnRotY; //gp+52h
    public byte DAT_55; //gp+55h
    public CriObject DAT_B4; //gp+b4h
    public FUN_148 PTR_FUN_148; //gp+148h
    public FUN_14C PTR_FUN_14C; //gp+14ch
    public byte DAT_9AA0; //gp+9aa0h
    public byte DAT_9AA1; //gp+9aa1h
    public _DIFFICULTY difficulty; //gp+9aa8h
    public byte DAT_9ADD; //gp+9addh
    public short playerHealth; //gp+a0f0h
    public short DAT_A0F2; //gp+a0f2h
    public uint DAT_A0F4; //gp+a0f4h
    public ushort[] DAT_A0F8; //gp+a0f8h
    public byte DAT_A100; //gp+a100h
    public byte DAT_A2CF; //gp+a2cfh
    public bool DAT_A2D0; //gp+a2d0h
    public byte DAT_A2D3; //gp+a2d3h
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
    public List<Vector3> skinnedVertices; //0x800C6F90
    public List<Color> skinnedColors; //0x800C75D0
    public List<CriSkinned> skinnedList; //0x800C7C10
    public bool disableColors;
    public Material[] materials;

    private delegate sbyte FUN_AA4D0(CriPlayer p, CriStatic o);
    private FUN_AA4D0[] PTR_FUN_AA4D0;

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

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DAT_A0F8 = new ushort[3];
        PTR_FUN_AA4D0 = new FUN_AA4D0[3]
        {
            FUN_82834,
            FUN_82BD8,
            FUN_82834
        };
    }

    private void Start()
    {
        skinnedVertices = new List<Vector3>();
        skinnedColors = new List<Color>();
        skinnedList = new List<CriSkinned>();
        todUncomp = new List<Vector3Int>();
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
        FUN_7302C();
    }

    private void FUN_81720(CriStatic param1, Vector2Int[] param2)
    {
        int iVar3;
        ColliderScriptableObject psVar4;
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
        bool bVar1;
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
        Vector2Int[] local_58;
        short local_2c;
        Matrix3x3 MStack128;
        Vector2Int[] auStack76;

        bVar4 = 0;
        local_88 = new Vector3Int(0, param1.vr.y, 0);
        MStack128 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref local_88, ref MStack128);
        v0 = param1.DAT_120;
        bVar1 = param1.DAT_12E;
        auStack76 = new Vector2Int[4];
        FUN_81720(param2, auStack76);
        local_60 = new short[4];
        FUN_82730(local_60, auStack76);
        sVar3 = (sbyte)((bVar1 ? 1 : 0) - 1);
        local_58 = new Vector2Int[3];

        if (bVar1)
        {
            do
            {
                local_88 = Utilities.ApplyMatrixSV(ref MStack128, ref param1.PTR_120[v0].pos);

                if (param1.PTR_120[v0].bone == -1)
                {
                    local_58[1].x = param1.screen.z + local_88.z;
                    local_58[0].x = param1.DAT_34.z + local_88.z;
                    uVar2 = (ushort)param1.screen.y;
                }
                else
                {
                    oVar7 = (CriBone)Utilities.FUN_601C8(param1.skeleton, param1.PTR_120[v0].bone);
                    local_58[0].x = oVar7.DAT_4C.x + local_88.x;
                    local_58[0].y = oVar7.DAT_4C.z + local_88.z;
                    local_58[1].x = oVar7.screen.x + local_88.x;
                    local_58[1].y = oVar7.screen.z + local_88.z;
                    uVar2 = (ushort)oVar7.screen.y;
                }

                uVar8 = (ushort)local_88.y;
                uVar9 = (ushort)param1.PTR_120[v0].radius;

                if (((uint)((local_58[1].x + (int)uVar9) - local_60[0]) < (ushort)local_60[2] + uVar9 * 2 &&
                    (uint)((local_58[1].y + (int)uVar9) - local_60[1]) < (ushort)local_60[3] + uVar9 * 2) ||
                    FUN_841E8(auStack76, local_58, ref local_88) != 0)
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
            param1.screen.x += local_58[2].x;
            param1.screen.z += local_58[2].y;
            param1.DAT_14C.x += local_58[2].x;
            param1.DAT_14C.z = local_58[2].y;

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
        ColliderScriptableObject psVar5;
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

            if (param1.DAT_120 != 0)
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

    private sbyte FUN_839D0(Vector2Int[] param1)
    {

    }

    private bool FUN_84008(Vector2Int[] param1, Vector2Int[] param2, ref Vector3Int param3)
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

    private sbyte FUN_841E8(Vector2Int[] param1, Vector2Int[] param2, ref Vector3Int param3)
    {
        bool bVar1;
        uint uVar3;
        byte bVar4;
        Vector2Int[] local_48;
        Vector3Int local_40;
        Vector3Int local_30;
        Vector3Int local_20;

        bVar4 = 0;
        uVar3 = 0;
        local_48 = new Vector2Int[2];
        local_20 = new Vector3Int();
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
                    param3.y = local_20.z;
                    return (sbyte)(bVar4 + 1);
                }
            }

            bVar4++;
            uVar3 = bVar4;
        } while (bVar4 < 4);

        return 0;
    }

    public void FUN_7302C()
    {
        //FUN_72F78
        FUN_72C2C();

        if ((DAT_38 & 2) == 0)
            FUN_73EB8();

        if ((DAT_38 & 1) == 0)
            FUN_731E8();
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

        Coprocessor.rotationMatrix.rt11 = DAT_B4.cTransform.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = DAT_B4.cTransform.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = DAT_B4.cTransform.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = DAT_B4.cTransform.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = DAT_B4.cTransform.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = DAT_B4.cTransform.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = DAT_B4.cTransform.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = DAT_B4.cTransform.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = DAT_B4.cTransform.rotation.V22;
        DAT_B4.cTransform.position.x = DAT_B4.screen.x;
        DAT_B4.cTransform.position.y = DAT_B4.screen.y;
        DAT_B4.cTransform.position.z = DAT_B4.screen.z;
        Coprocessor.translationVector._trx = DAT_B4.cTransform.position.x;
        Coprocessor.translationVector._try = DAT_B4.cTransform.position.y;
        Coprocessor.translationVector._trz = DAT_B4.cTransform.position.z;
        DAT_1f80002c = DAT_B4.vr;

        for (int i = 0; i < sceneManager.DAT_27C.Length; i++)
        {

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

        uVar1 = DAT_B58BA * 3U;
        uVar2 = DAT_B58BA + ((uVar1 & 0xffff) >> 8) & 0xff;
        DAT_B58BA = (ushort)(uVar2 | uVar1 & 0xff00U);
        return uVar2;
    }
}
