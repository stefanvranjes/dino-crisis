using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Burst;
using static Types.TypesClass;

public struct CriBoneIndex
{
    public int next;
    public int prev;
    public byte DAT_42;

    public CriBoneIndex(int p1, int p2, byte p3)
    {
        next = p1;
        prev = p2;
        DAT_42 = p3;
    }
}

public struct CriBoneColor
{
    public Matrix3x3 lightMatrix;
    public Matrix3x3 colorMatrix;

    public CriBoneColor(Matrix3x3 m1, Matrix3x3 m2)
    {
        lightMatrix = m1;
        colorMatrix = m2;
    }
}

public class CriBone : CriObject
{
    public int boneId;
    public CriObject next; //0x34
    public CriObject prev; //0x38
    public int nextId;
    public int prevId;
    public Tmd3ScriptableObject cMesh; //0x3C
    public byte DAT_42; //0x42
    public bool DAT_43; //0x43
    public Vector3Int DAT_44; //0x44
    public Vector3Int DAT_4C; //0x4C
    public Vector3Int[] DAT_54; //0x54
    public Matrix3x3 lightMatrix; //0x6C
    public Matrix3x3 colorMatrix; //0x8C

    private Mesh mesh;
    private int subMeshCount;
    private NativeArray<MyVertex> vertexBuffer;
    private NativeArray<ushort> indexBuffer;
    private NativeArray<int> indicies;
    private NativeArray<int3> vertexData;
    public Material[] materials;

    protected override void Awake()
    {
        DAT_54 = new Vector3Int[3];
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        if (cMesh != null)
        {
            Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[0], gameObject.layer, Camera.main, 0);
        }
    }

    public override void ResetValues()
    {
        base.ResetValues();
        next = null;
        prev = null;
        cMesh = null;
        DAT_42 = 0;
        DAT_43 = false;
        DAT_44 = Vector3Int.zero;
        DAT_4C = Vector3Int.zero;
        DAT_54 = new Vector3Int[3];
        lightMatrix = new Matrix3x3();
        colorMatrix = new Matrix3x3();
    }

    public void MeshData()
    {
        subMeshCount = 6;
        indexBuffer = new NativeArray<ushort>(
            (cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 6) * subMeshCount, Allocator.Persistent
        );

        vertexBuffer = new NativeArray<MyVertex>(
            cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 4, Allocator.Persistent
        );

        indicies = new NativeArray<int>(
            subMeshCount, Allocator.Persistent
        );

        for (int i = 0; i < cMesh.TRI_COUNT; i++)
        {
            int tri = i * 3;
            vertexData[tri] = new int3(cMesh.NRMLS[tri].x, cMesh.NRMLS[tri].y, cMesh.NRMLS[tri].z);
            vertexData[tri + 1] = new int3(cMesh.NRMLS[tri + 1].x, cMesh.NRMLS[tri + 1].y, cMesh.NRMLS[tri + 1].z);
            vertexData[tri + 2] = new int3(cMesh.NRMLS[tri + 2].x, cMesh.NRMLS[tri + 2].y, cMesh.NRMLS[tri + 2].z);
            vertexBuffer[tri] = new MyVertex(cMesh.VERTS[tri], new float4(1, 1, 1, 1), cMesh.UVS[tri], cMesh.UVS2[i]);
            vertexBuffer[tri + 1] = new MyVertex(cMesh.VERTS[tri + 1], new float4(1, 1, 1, 1), cMesh.UVS[tri + 1], cMesh.UVS2[i]);
            vertexBuffer[tri + 2] = new MyVertex(cMesh.VERTS[tri + 2], new float4(1, 1, 1, 1), cMesh.UVS[tri + 2], cMesh.UVS2[i]);
            int sm = indicies[0];
            indexBuffer[sm] = (ushort)cMesh.TRIS[tri];
            indexBuffer[sm + 1] = (ushort)cMesh.TRIS[tri + 1];
            indexBuffer[sm + 2] = (ushort)cMesh.TRIS[tri + 2];
            indicies[0] += 3;
        }

        for (int i = cMesh.QUAD_COUNT - 1, j = cMesh.TRI_COUNT; i >= 0; i--)
        {
            int quad = j * 3 + i * 4;
            int tri = i * 6;
            vertexData[quad] = new int3(cMesh.NRMLS[quad].x, cMesh.NRMLS[quad].y, cMesh.NRMLS[quad].z);
            vertexData[quad + 1] = new int3(cMesh.NRMLS[quad + 1].x, cMesh.NRMLS[quad + 1].y, cMesh.NRMLS[quad + 1].z);
            vertexData[quad + 2] = new int3(cMesh.NRMLS[quad + 2].x, cMesh.NRMLS[quad + 2].y, cMesh.NRMLS[quad + 2].z);
            vertexData[quad + 3] = new int3(cMesh.NRMLS[quad + 3].x, cMesh.NRMLS[quad + 3].y, cMesh.NRMLS[quad + 3].z);
            vertexBuffer[quad] = new MyVertex(cMesh.VERTS[quad], new float4(1, 1, 1, 1), cMesh.UVS[quad], cMesh.UVS2[i + j]);
            vertexBuffer[quad + 1] = new MyVertex(cMesh.VERTS[quad + 1], new float4(1, 1, 1, 1), cMesh.UVS[quad + 1], cMesh.UVS2[i + j]);
            vertexBuffer[quad + 2] = new MyVertex(cMesh.VERTS[quad + 2], new float4(1, 1, 1, 1), cMesh.UVS[quad + 2], cMesh.UVS2[i + j]);
            vertexBuffer[quad + 3] = new MyVertex(cMesh.VERTS[quad + 3], new float4(1, 1, 1, 1), cMesh.UVS[quad + 3], cMesh.UVS2[i + j]);
            int sm = indicies[0];
            indexBuffer[sm] = (ushort)cMesh.QUADS[tri];
            indexBuffer[sm + 1] = (ushort)(cMesh.QUADS[tri + 1]);
            indexBuffer[sm + 2] = (ushort)(cMesh.QUADS[tri + 2]);
            indexBuffer[sm + 3] = (ushort)(cMesh.QUADS[tri + 3]);
            indexBuffer[sm + 4] = (ushort)(cMesh.QUADS[tri + 4]);
            indexBuffer[sm + 5] = (ushort)(cMesh.QUADS[tri + 5]);
            indicies[0] += 6;
        }

        mesh.SetVertexBufferData(vertexBuffer, 0, 0, cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 4);
        mesh.SetIndexBufferData(indexBuffer, 0, 0, cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 6);
        mesh.SetSubMesh(0, new SubMeshDescriptor(0, indicies[0]));
        mesh.RecalculateBounds();
    }

    //FUN_7503C
    public void MeshJob(Tmd3ScriptableObject param1)
    {
        BoneMeshJob job = new BoneMeshJob
        {
            vertexBuffer = vertexBuffer,
            vertexData = vertexData,
            rotationMatrix = Coprocessor.rotationMatrix,
            colorCode = Coprocessor.colorCode,
            lightMatrix = Coprocessor.lightMatrix,
            lightColorMatrix = Coprocessor.lightColorMatrix,
            backgroundColor = Coprocessor.backgroundColor,
            triCount = param1.TRI_COUNT,
            quadCount = param1.QUAD_COUNT
        };
        JobHandle handle = job.Schedule();
        JobManager.instance.AddJob(handle);
    }

    public void BoneTransform()
    {
        transform.position = new Vector3
            (cTransform.position.x / 16f, 
            cTransform.position.y / -16f, 
            cTransform.position.z / 16f);
        transform.localRotation = cTransform.rotation.Matrix2Quaternion;
        transform.localEulerAngles = new Vector3
            (-transform.eulerAngles.x, transform.eulerAngles.y, -transform.eulerAngles.z);
    }
}

[BurstCompile]
public struct BoneMeshJob : IJob
{
    [WriteOnly] public NativeArray<MyVertex> vertexBuffer;
    [ReadOnly] public NativeArray<int3> vertexData;
    public Cop2RT rotationMatrix;
    public Cop2ClrCode colorCode;
    public Cop2LLM lightMatrix;
    public Cop2LCM lightColorMatrix;
    public Cop2BC backgroundColor;
    public int triCount;
    public int quadCount;

    public void Execute()
    {
        Cop2Vector0 vector0;
        Cop2Vector1 vector1;
        Cop2Vector2 vector2;
        Cop2Accumulator accumulator = new Cop2Accumulator();
        Cop2Maths mathsAccumulator = new Cop2Maths();
        Cop2ClrFIFO colorFIFO = new Cop2ClrFIFO();
        int iVar4;
        int iVar8;
        int iVar9;
        int iVar10;
        int3 DAT_1f800380;
        int3 DAT_1f800388;
        int3 DAT_1f800390;

        iVar10 = 0;

        while (-1 < --triCount)
        {
            float3 v1 = vertexBuffer[iVar10].vertex;
            float3 v2 = vertexBuffer[iVar10 + 1].vertex;
            float3 v3 = vertexBuffer[iVar10 + 2].vertex;
            float2 t1 = vertexBuffer[iVar10].uv;
            float2 t2 = vertexBuffer[iVar10 + 1].uv;
            float2 t3 = vertexBuffer[iVar10 + 2].uv;
            float3 p1 = vertexBuffer[iVar10].uv2;
            float3 p2 = vertexBuffer[iVar10 + 1].uv2;
            float3 p3 = vertexBuffer[iVar10 + 2].uv2;
            vector0.vx0 = (short)vertexData[iVar10].x;
            vector0.vy0 = (short)vertexData[iVar10].y;
            vector0.vz0 = (short)vertexData[iVar10].z;
            vector1.vx1 = (short)vertexData[iVar10 + 1].x;
            vector1.vy1 = (short)vertexData[iVar10 + 1].y;
            vector1.vz1 = (short)vertexData[iVar10 + 1].z;
            vector2.vx2 = (short)vertexData[iVar10 + 2].x;
            vector2.vy2 = (short)vertexData[iVar10 + 2].y;
            vector2.vz2 = (short)vertexData[iVar10 + 2].z;
            MVMVA_rotation_vector0_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector0);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800380 = new int3(iVar4, iVar8, iVar9);
            MVMVA_rotation_vector1_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector1);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800388 = new int3(iVar4, iVar8, iVar9);
            MVMVA_rotation_vector2_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector2);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800390 = new int3(iVar4, iVar8, iVar9);
            vector0.vx0 = (short)DAT_1f800380.x;
            vector0.vy0 = (short)DAT_1f800380.y;
            vector0.vz0 = (short)DAT_1f800380.z;
            vector1.vx1 = (short)DAT_1f800388.x;
            vector1.vy1 = (short)DAT_1f800388.y;
            vector1.vz1 = (short)DAT_1f800388.z;
            vector2.vx2 = (short)DAT_1f800390.x;
            vector2.vy2 = (short)DAT_1f800390.y;
            vector2.vz2 = (short)DAT_1f800390.z;
            NCCT_shift_lm(ref mathsAccumulator, ref accumulator, ref vector0, ref vector1, ref vector2, ref colorFIFO);
            float4 c1 = new float4(colorFIFO.r0, colorFIFO.g0, colorFIFO.b0, colorFIFO.cd0) / 255;
            float4 c2 = new float4(colorFIFO.r1, colorFIFO.g1, colorFIFO.b1, colorFIFO.cd1) / 255;
            float4 c3 = new float4(colorFIFO.r2, colorFIFO.g2, colorFIFO.b2, colorFIFO.cd2) / 255;
            vertexBuffer[iVar10] = new MyVertex(v1, c1, t1, p1);
            vertexBuffer[iVar10 + 1] = new MyVertex(v2, c2, t2, p2);
            vertexBuffer[iVar10 + 2] = new MyVertex(v3, c3, t3, p3);
            iVar10 += 3;
        }

        iVar10 = triCount;

        while (-1 < --quadCount)
        {
            float3 v1 = vertexBuffer[iVar10].vertex;
            float3 v2 = vertexBuffer[iVar10 + 1].vertex;
            float3 v3 = vertexBuffer[iVar10 + 2].vertex;
            float3 v4 = vertexBuffer[iVar10 + 3].vertex;
            float2 t1 = vertexBuffer[iVar10].uv;
            float2 t2 = vertexBuffer[iVar10 + 1].uv;
            float2 t3 = vertexBuffer[iVar10 + 2].uv;
            float2 t4 = vertexBuffer[iVar10 + 3].uv;
            float3 p1 = vertexBuffer[iVar10].uv2;
            float3 p2 = vertexBuffer[iVar10 + 1].uv2;
            float3 p3 = vertexBuffer[iVar10 + 2].uv2;
            float3 p4 = vertexBuffer[iVar10 + 3].uv2;
            vector0.vx0 = (short)vertexData[iVar10].x;
            vector0.vy0 = (short)vertexData[iVar10].y;
            vector0.vz0 = (short)vertexData[iVar10].z;
            vector1.vx1 = (short)vertexData[iVar10 + 1].x;
            vector1.vy1 = (short)vertexData[iVar10 + 1].y;
            vector1.vz1 = (short)vertexData[iVar10 + 1].z;
            vector2.vx2 = (short)vertexData[iVar10 + 2].x;
            vector2.vy2 = (short)vertexData[iVar10 + 2].y;
            vector2.vz2 = (short)vertexData[iVar10 + 2].z;
            MVMVA_rotation_vector0_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector0);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800380 = new int3(iVar4, iVar8, iVar9);
            MVMVA_rotation_vector1_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector1);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800388 = new int3(iVar4, iVar8, iVar9);
            MVMVA_rotation_vector2_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector2);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800390 = new int3(iVar4, iVar8, iVar9);
            vector0.vx0 = (short)DAT_1f800380.x;
            vector0.vy0 = (short)DAT_1f800380.y;
            vector0.vz0 = (short)DAT_1f800380.z;
            vector1.vx1 = (short)DAT_1f800388.x;
            vector1.vy1 = (short)DAT_1f800388.y;
            vector1.vz1 = (short)DAT_1f800388.z;
            vector2.vx2 = (short)DAT_1f800390.x;
            vector2.vy2 = (short)DAT_1f800390.y;
            vector2.vz2 = (short)DAT_1f800390.z;
            NCCT_shift_lm(ref mathsAccumulator, ref accumulator, ref vector0, ref vector1, ref vector2, ref colorFIFO);
            float4 c1 = new float4(colorFIFO.r0, colorFIFO.g0, colorFIFO.b0, colorFIFO.cd0) / 255;
            float4 c2 = new float4(colorFIFO.r1, colorFIFO.g1, colorFIFO.b1, colorFIFO.cd1) / 255;
            float4 c3 = new float4(colorFIFO.r2, colorFIFO.g2, colorFIFO.b2, colorFIFO.cd2) / 255;
            vector0.vx0 = (short)vertexData[iVar10 + 3].x;
            vector0.vy0 = (short)vertexData[iVar10 + 3].y;
            vector0.vz0 = (short)vertexData[iVar10 + 3].z;
            MVMVA_rotation_vector0_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector0);
            iVar4 = accumulator.ir1;
            iVar8 = accumulator.ir2;
            iVar9 = accumulator.ir3;
            DAT_1f800380 = new int3(iVar4, iVar8, iVar9);
            vector0.vx0 = (short)DAT_1f800380.x;
            vector0.vy0 = (short)DAT_1f800380.y;
            vector0.vz0 = (short)DAT_1f800380.z;
            //DAT_1f800028++;
            NCCS_shift_lm(ref mathsAccumulator, ref accumulator, ref vector0, ref colorFIFO);
            float4 c4 = new float4(colorFIFO.r2, colorFIFO.g2, colorFIFO.b2, colorFIFO.cd2) / 255;
            iVar10 += 4;
        }
    }

    void MVMVA_rotation_vector0_shift(ref Cop2RT rotationMatrix, ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2Vector0 vector0)
    {
        short Vx = 0;
        short Vy = 0;
        short Vz = 0;

        Vx = vector0.vx0;
        Vy = vector0.vy0;
        Vz = vector0.vz0;

        MultMatVec_RT(ref mathsAccumulator, ref accumulator, ref rotationMatrix, Vx, Vy, Vz, 12, false);
    }

    void MVMVA_rotation_vector1_shift(ref Cop2RT rotationMatrix, ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2Vector1 vector1)
    {
        short Vx = 0;
        short Vy = 0;
        short Vz = 0;

        Vx = vector1.vx1;
        Vy = vector1.vy1;
        Vz = vector1.vz1;

        MultMatVec_RT(ref mathsAccumulator, ref accumulator, ref rotationMatrix, Vx, Vy, Vz, 12, false);
    }

    void MVMVA_rotation_vector2_shift(ref Cop2RT rotationMatrix, ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2Vector2 vector2)
    {
        short Vx = 0;
        short Vy = 0;
        short Vz = 0;

        Vx = vector2.vx2;
        Vy = vector2.vy2;
        Vz = vector2.vz2;

        MultMatVec_RT(ref mathsAccumulator, ref accumulator, ref rotationMatrix, Vx, Vy, Vz, 12, false);
    }

    void MultMatVec_RT(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2RT M, short Vx, short Vy, short Vz, byte shift, bool lm)
    {
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator,
            SignExtendMACResult(SignExtendMACResult((M.rt11 * Vx), 1) + (M.rt12 * Vy), 1) + (M.rt13 * Vz), 1, shift, lm);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator,
            SignExtendMACResult(SignExtendMACResult((M.rt21 * Vx), 2) + (M.rt22 * Vy), 2) + (M.rt23 * Vz), 2, shift, lm);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator,
            SignExtendMACResult(SignExtendMACResult((M.rt31 * Vx), 3) + (M.rt32 * Vy), 3) + (M.rt33 * Vz), 3, shift, lm);
    }

    void MultMatVec_LCM_BK(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2LCM M, ref Cop2BC T, short Vx, short Vy, short Vz, byte shift, bool lm)
    {
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator,
            SignExtendMACResult(SignExtendMACResult(((long)T._rbk << 12) + (M.lr1 * Vx), 1) +
            (M.lr2 * Vy), 1) + (M.lr3 * Vz), 1, shift, lm);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator,
            SignExtendMACResult(SignExtendMACResult(((long)T._gbk << 12) + (M.lg1 * Vx), 2) +
            (M.lg2 * Vy), 2) + (M.lg3 * Vz), 2, shift, lm);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator,
            SignExtendMACResult(SignExtendMACResult(((long)T._bbk << 12) + (M.lb1 * Vx), 3) +
            (M.lb2 * Vy), 3) + (M.lb3 * Vz), 3, shift, lm);
    }

    void MultMatVec_LLM(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2LLM M, short Vx, short Vy, short Vz, byte shift, bool lm)
    {
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, SignExtendMACResult(((long)M.l11 * Vx) + ((long)M.l12 * Vy), 1) +
                                    ((long)M.l13 * Vz), 1, shift, lm);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, SignExtendMACResult(((long)M.l21 * Vx) + ((long)M.l22 * Vy), 2) +
                                    ((long)M.l23 * Vz), 2, shift, lm);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, SignExtendMACResult(((long)M.l31 * Vx) + ((long)M.l32 * Vy), 3) +
                                    ((long)M.l33 * Vz), 3, shift, lm);
    }

    long SignExtendMACResult(long value, int index)
    {
        return SignExtend64(value, index == 0 ? 31 : 44);
    }

    void TruncateAndSetMACAndIR(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, long value, int index, byte shift, bool lm)
    {
        value >>= shift;

        int value32 = (int)value;
        if (index == 0)
            mathsAccumulator.mac0 = value32;
        else if (index == 1)
            mathsAccumulator.mac1 = value32;
        else if (index == 2)
            mathsAccumulator.mac2 = value32;
        else
            mathsAccumulator.mac3 = value32;

        TruncateAndSetIR(ref accumulator, value32, index, lm);
    }

    void TruncateAndSetIR(ref Cop2Accumulator accumulator, int value, int index, bool lm)
    {
        int IR0_MIN_VALUE = 0x0000;
        int IR0_MAX_VALUE = 0x1000;
        int IR123_MIN_VALUE = -(INT64_C(1) << 15);
        int IR123_MAX_VALUE = (INT64_C(1) << 15) - 1;
        int MIN_VALUE = (index == 0) ? IR0_MIN_VALUE : IR123_MIN_VALUE;
        int MAX_VALUE = (index == 0) ? IR0_MAX_VALUE : IR123_MAX_VALUE;
        int actualMinValue = lm ? 0 : MIN_VALUE;

        if (value < actualMinValue)
            value = actualMinValue;
        else if (value > MAX_VALUE)
            value = MAX_VALUE;

        switch (index)
        {
            case 0:
                accumulator.ir0 = (short)value;
                break;
            case 1:
                accumulator.ir1 = (short)value;
                break;
            case 2:
                accumulator.ir2 = (short)value;
                break;
            default:
                accumulator.ir3 = (short)value;
                break;
        }
    }

    void NCCS_shift_lm(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2Vector0 vector0, ref Cop2ClrFIFO colorFIFO)
    {
        MultMatVec_LLM(ref mathsAccumulator, ref accumulator, ref lightMatrix, vector0.vx0, vector0.vy0, vector0.vz0, 12, true);

        MultMatVec_LCM_BK(ref mathsAccumulator, ref accumulator, ref lightColorMatrix, ref backgroundColor, accumulator.ir1, accumulator.ir2, accumulator.ir3, 12, true);

        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.r * accumulator.ir1) << 4, 1, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.g * accumulator.ir2) << 4, 2, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.b * accumulator.ir3) << 4, 3, 12, true);

        PushRGBFromMAC(ref mathsAccumulator, ref colorCode, ref colorFIFO);
    }

    void NCCT_shift_lm(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2Vector0 vector0, ref Cop2Vector1 vector1, ref Cop2Vector2 vector2, ref Cop2ClrFIFO colorFIFO)
    {
        MultMatVec_LLM(ref mathsAccumulator, ref accumulator, ref lightMatrix, vector0.vx0, vector0.vy0, vector0.vz0, 12, true);
        MultMatVec_LCM_BK(ref mathsAccumulator, ref accumulator, ref lightColorMatrix, ref backgroundColor, accumulator.ir1, accumulator.ir2, accumulator.ir3, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.r * accumulator.ir1) << 4, 1, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.g * accumulator.ir2) << 4, 2, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.b * accumulator.ir3) << 4, 3, 12, true);
        PushRGBFromMAC(ref mathsAccumulator, ref colorCode, ref colorFIFO);

        MultMatVec_LLM(ref mathsAccumulator, ref accumulator, ref lightMatrix, vector1.vx1, vector1.vy1, vector1.vz1, 12, true);
        MultMatVec_LCM_BK(ref mathsAccumulator, ref accumulator, ref lightColorMatrix, ref backgroundColor, accumulator.ir1, accumulator.ir2, accumulator.ir3, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.r * accumulator.ir1) << 4, 1, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.g * accumulator.ir2) << 4, 2, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.b * accumulator.ir3) << 4, 3, 12, true);
        PushRGBFromMAC(ref mathsAccumulator, ref colorCode, ref colorFIFO);

        MultMatVec_LLM(ref mathsAccumulator, ref accumulator, ref lightMatrix, vector2.vx2, vector2.vy2, vector2.vz2, 12, true);
        MultMatVec_LCM_BK(ref mathsAccumulator, ref accumulator, ref lightColorMatrix, ref backgroundColor, accumulator.ir1, accumulator.ir2, accumulator.ir3, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.r * accumulator.ir1) << 4, 1, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.g * accumulator.ir2) << 4, 2, 12, true);
        TruncateAndSetMACAndIR(ref mathsAccumulator, ref accumulator, (long)((int)(uint)colorCode.b * accumulator.ir3) << 4, 3, 12, true);
        PushRGBFromMAC(ref mathsAccumulator, ref colorCode, ref colorFIFO);
    }

    void PushRGBFromMAC(ref Cop2Maths mathsAccumulator, ref Cop2ClrCode colorCode, ref Cop2ClrFIFO colorFIFO)
    {
        uint r = TruncateRGB((int)(uint)(mathsAccumulator.mac1 >> 4), 0);
        uint g = TruncateRGB((int)(uint)(mathsAccumulator.mac2 >> 4), 1);
        uint b = TruncateRGB((int)(uint)(mathsAccumulator.mac3 >> 4), 2);
        uint c = colorCode.code;

        colorFIFO.r0 = colorFIFO.r1;
        colorFIFO.g0 = colorFIFO.g1;
        colorFIFO.b0 = colorFIFO.b1;
        colorFIFO.cd0 = colorFIFO.cd1;

        colorFIFO.r1 = colorFIFO.r2;
        colorFIFO.g1 = colorFIFO.g2;
        colorFIFO.b1 = colorFIFO.b2;
        colorFIFO.cd1 = colorFIFO.cd2;

        colorFIFO.r2 = (byte)r;
        colorFIFO.g2 = (byte)g;
        colorFIFO.b2 = (byte)b;
        colorFIFO.cd2 = (byte)c;
    }

    uint TruncateRGB(int value, int index)
    {
        if (value < 0 || value > 0xFF)
        {
            return (value < 0) ? 0U : 0xFF;
        }

        return (uint)value;
    }
}