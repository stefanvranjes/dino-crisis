using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriBone : CriObject
{
    public Tmd3ScriptableObject cMesh2; //0x3C
    public byte DAT_42; //0x42
    public bool DAT_43; //0x43
    public Vector3Int DAT_44; //0x44
    public Vector3Int DAT_4C; //0x4C
    public Matrix3x3 DAT_6C; //0x6C
    public Matrix3x3 DAT_8C; //0x8C

    private List<byte> commandList;
    private List<Vector3> vertexList;
    private List<Vector2> uvList;
    private List<Vector3> uv2List;
    private List<Color> colorList;
    private List<int> triangleList;
    public Material[] materials;

    protected override void Start()
    {
        base.Start();
        commandList = new List<byte>();
        vertexList = new List<Vector3>();
        uvList = new List<Vector2>();
        uv2List = new List<Vector3>();
        colorList = new List<Color>();
        triangleList = new List<int>();
    }

    protected override void Update()
    {
        return;
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_42 = 0;
        DAT_43 = false;
        DAT_44 = Vector3Int.zero;
        DAT_4C = Vector3Int.zero;
    }

    public void BoneTransform()
    {
        transform.position = new Vector3
            (cTransform.position.x / 16f, 
            cTransform.position.y / -16f, 
            cTransform.position.z / 16f);
        transform.rotation = cTransform.rotation.Matrix2Quaternion;
        transform.eulerAngles = new Vector3
            (-transform.eulerAngles.x, transform.eulerAngles.y, -transform.eulerAngles.z);
    }

    public void FUN_7503C(Tmd3ScriptableObject param1)
    {
        FUN_7542C(param1, param1.TRI_COUNT);
        FUN_750C4(param1, param1.QUAD_COUNT);
    }

    private void FUN_7542C(Tmd3ScriptableObject param1, int param2)
    {
        int iVar4;
        int iVar8;
        int iVar9;

        int vert = 0;
        int uv = 0;
        int uv2 = 0;
        int nrml = 0;
        int tri = 0;
        commandList.Clear();
        vertexList.Clear();
        uvList.Clear();
        uv2List.Clear();
        colorList.Clear();
        triangleList.Clear();

        while (-1 < --param2)
        {
            commandList.Add(0x34);
            vertexList.Add(param1.VERTS[vert]);
            vertexList.Add(param1.VERTS[vert + 1]);
            vertexList.Add(param1.VERTS[vert + 2]);
            uvList.Add(param1.UVS[uv]);
            uvList.Add(param1.UVS[uv + 1]);
            uvList.Add(param1.UVS[uv + 2]);
            uv2List.Add(param1.UVS2[uv2]);
            GameManager.instance.DAT_1f800026++;
            Coprocessor.vector0.vx0 = (short)param1.NRMLS[nrml].x;
            Coprocessor.vector0.vy0 = (short)param1.NRMLS[nrml].y;
            Coprocessor.vector0.vz0 = (short)param1.NRMLS[nrml].z;
            Coprocessor.vector1.vx1 = (short)param1.NRMLS[nrml + 1].x;
            Coprocessor.vector1.vy1 = (short)param1.NRMLS[nrml + 1].y;
            Coprocessor.vector1.vz1 = (short)param1.NRMLS[nrml + 1].z;
            Coprocessor.vector2.vx2 = (short)param1.NRMLS[nrml + 2].x;
            Coprocessor.vector2.vy2 = (short)param1.NRMLS[nrml + 2].y;
            Coprocessor.vector2.vz2 = (short)param1.NRMLS[nrml + 2].z;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800380 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V1, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800388 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V2, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800390 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.vector0.vx0 = (short)GameManager.instance.DAT_1f800380.x;
            Coprocessor.vector0.vy0 = (short)GameManager.instance.DAT_1f800380.y;
            Coprocessor.vector0.vz0 = (short)GameManager.instance.DAT_1f800380.z;
            Coprocessor.vector1.vx1 = (short)GameManager.instance.DAT_1f800388.x;
            Coprocessor.vector1.vy1 = (short)GameManager.instance.DAT_1f800388.y;
            Coprocessor.vector1.vz1 = (short)GameManager.instance.DAT_1f800388.z;
            Coprocessor.vector2.vx2 = (short)GameManager.instance.DAT_1f800390.x;
            Coprocessor.vector2.vy2 = (short)GameManager.instance.DAT_1f800390.y;
            Coprocessor.vector2.vz2 = (short)GameManager.instance.DAT_1f800390.z;
            Coprocessor.ExecuteNCCT(12, true);
            GameManager.instance.DAT_1f800024++;
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r0, Coprocessor.colorFIFO.g0, Coprocessor.colorFIFO.b0, Coprocessor.colorFIFO.cd0));
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r1, Coprocessor.colorFIFO.g1, Coprocessor.colorFIFO.b1, Coprocessor.colorFIFO.cd1));
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2));
            triangleList.Add(param1.TRIS[tri]);
            triangleList.Add(param1.TRIS[tri + 1]);
            triangleList.Add(param1.TRIS[tri + 2]);

            vert += 3;
            uv += 3;
            uv2++;
            nrml += 3;
            tri += 3;
        }
    }

    private void FUN_750C4(Tmd3ScriptableObject param1, int param2)
    {
        int iVar4;
        int iVar8;
        int iVar9;

        int begin = param1.TRI_COUNT;
        int vert = begin * 3;
        int uv = begin * 3;
        int uv2 = begin;
        int nrml = begin * 3;
        int tri = 0;

        while (-1 < --param2)
        {
            commandList.Add(0x3C);
            vertexList.Add(param1.VERTS[vert]);
            vertexList.Add(param1.VERTS[vert + 1]);
            vertexList.Add(param1.VERTS[vert + 2]);
            vertexList.Add(param1.VERTS[vert + 3]);
            uvList.Add(param1.UVS[uv]);
            uvList.Add(param1.UVS[uv + 1]);
            uvList.Add(param1.UVS[uv + 2]);
            uvList.Add(param1.UVS[uv + 3]);
            uv2List.Add(param1.UVS2[uv2]);
            GameManager.instance.DAT_1f80002a++;
            Coprocessor.vector0.vx0 = (short)param1.NRMLS[nrml].x;
            Coprocessor.vector0.vy0 = (short)param1.NRMLS[nrml].y;
            Coprocessor.vector0.vz0 = (short)param1.NRMLS[nrml].z;
            Coprocessor.vector1.vx1 = (short)param1.NRMLS[nrml + 1].x;
            Coprocessor.vector1.vy1 = (short)param1.NRMLS[nrml + 1].y;
            Coprocessor.vector1.vz1 = (short)param1.NRMLS[nrml + 1].z;
            Coprocessor.vector2.vx2 = (short)param1.NRMLS[nrml + 2].x;
            Coprocessor.vector2.vy2 = (short)param1.NRMLS[nrml + 2].y;
            Coprocessor.vector2.vz2 = (short)param1.NRMLS[nrml + 2].z;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800380 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V1, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800388 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V2, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800390 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.vector0.vx0 = (short)GameManager.instance.DAT_1f800380.x;
            Coprocessor.vector0.vy0 = (short)GameManager.instance.DAT_1f800380.y;
            Coprocessor.vector0.vz0 = (short)GameManager.instance.DAT_1f800380.z;
            Coprocessor.vector1.vx1 = (short)GameManager.instance.DAT_1f800388.x;
            Coprocessor.vector1.vy1 = (short)GameManager.instance.DAT_1f800388.y;
            Coprocessor.vector1.vz1 = (short)GameManager.instance.DAT_1f800388.z;
            Coprocessor.vector2.vx2 = (short)GameManager.instance.DAT_1f800390.x;
            Coprocessor.vector2.vy2 = (short)GameManager.instance.DAT_1f800390.y;
            Coprocessor.vector2.vz2 = (short)GameManager.instance.DAT_1f800390.z;
            Coprocessor.ExecuteNCCT(12, true);
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r0, Coprocessor.colorFIFO.g0, Coprocessor.colorFIFO.b0, Coprocessor.colorFIFO.cd0));
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r1, Coprocessor.colorFIFO.g1, Coprocessor.colorFIFO.b1, Coprocessor.colorFIFO.cd1));
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2));
            Coprocessor.vector0.vx0 = (short)param1.NRMLS[nrml + 3].x;
            Coprocessor.vector0.vy0 = (short)param1.NRMLS[nrml + 3].y;
            Coprocessor.vector0.vz0 = (short)param1.NRMLS[nrml + 3].z;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = Coprocessor.accumulator.ir1;
            iVar8 = Coprocessor.accumulator.ir2;
            iVar9 = Coprocessor.accumulator.ir3;
            GameManager.instance.DAT_1f800380 = new Vector3Int(iVar4, iVar8, iVar9);
            Coprocessor.vector0.vx0 = (short)GameManager.instance.DAT_1f800380.x;
            Coprocessor.vector0.vy0 = (short)GameManager.instance.DAT_1f800380.y;
            Coprocessor.vector0.vz0 = (short)GameManager.instance.DAT_1f800380.z;
            GameManager.instance.DAT_1f800028++;
            Coprocessor.ExecuteNCCS(12, true);
            colorList.Add(new Color32
                (Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2));
            triangleList.Add(param1.QUADS[tri]);
            triangleList.Add(param1.QUADS[tri + 1]);
            triangleList.Add(param1.QUADS[tri + 2]);
            triangleList.Add(param1.QUADS[tri + 3]);
            triangleList.Add(param1.QUADS[tri + 4]);
            triangleList.Add(param1.QUADS[tri + 5]);

            vert += 4;
            uv += 4;
            uv2++;
            nrml += 4;
            tri += 6;
        }
    }
}
