using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _DIFFICULTY
{
    Normal, 
    Easy
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static SceneManager sceneManager;

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
    public byte DAT_21; //gp+21h
    public ushort DAT_28; //gp+28h
    public byte DAT_38; //gp+38h
    public byte DAT_40; //gp+40h
    public Vector3Int playerSpawnPos; //gp+4ch
    public short playerSpawnRotY; //gp+52h
    public byte DAT_55; //gp+55h
    public CriObject DAT_B4; //gp+b4h
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
    public List<Vector3> skinnedVertices; //0x800C6F90
    public List<Color> skinnedColors; //0x800C75D0
    public List<CriSkinned> skinnedList; //0x800C7C10
    public bool disableColors;
    public Material[] materials;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        skinnedVertices = new List<Vector3>();
        skinnedColors = new List<Color>();
        skinnedList = new List<CriSkinned>();
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

    public void FUN_7302C()
    {
        //FUN_72F78
        FUN_72C2C();

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
                        Coprocessor.lightMatrix.l11 = puVar10.DAT_6C.V00;
                        Coprocessor.lightMatrix.l12 = puVar10.DAT_6C.V01;
                        Coprocessor.lightMatrix.l13 = puVar10.DAT_6C.V02;
                        Coprocessor.lightMatrix.l21 = puVar10.DAT_6C.V10;
                        Coprocessor.lightMatrix.l22 = puVar10.DAT_6C.V11;
                        Coprocessor.lightMatrix.l23 = puVar10.DAT_6C.V12;
                        Coprocessor.lightMatrix.l31 = puVar10.DAT_6C.V20;
                        Coprocessor.lightMatrix.l32 = puVar10.DAT_6C.V21;
                        Coprocessor.lightMatrix.l33 = puVar10.DAT_6C.V22;
                        Coprocessor.lightColorMatrix.lr1 = puVar10.DAT_8C.V00;
                        Coprocessor.lightColorMatrix.lr2 = puVar10.DAT_8C.V01;
                        Coprocessor.lightColorMatrix.lr3 = puVar10.DAT_8C.V02;
                        Coprocessor.lightColorMatrix.lg1 = puVar10.DAT_8C.V10;
                        Coprocessor.lightColorMatrix.lg2 = puVar10.DAT_8C.V11;
                        Coprocessor.lightColorMatrix.lg3 = puVar10.DAT_8C.V12;
                        Coprocessor.lightColorMatrix.lb1 = puVar10.DAT_8C.V20;
                        Coprocessor.lightColorMatrix.lb2 = puVar10.DAT_8C.V21;
                        Coprocessor.lightColorMatrix.lb3 = puVar10.DAT_8C.V22;
                        puVar6 = puVar10.DAT_38;
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

                        if (puVar10.cMesh2 != null)
                            puVar10.FUN_7503C(puVar10.cMesh2);

                        puVar10 = (CriBone)puVar10.DAT_34;
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

            if ((pbVar3.flags & 2) != 0)
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
                skinnedList.Add(SceneManager.instance.DAT_27C[pbVar4]);
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
}
