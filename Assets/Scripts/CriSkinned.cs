using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Jobs;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Burst;
using static Types.TypesClass;

public struct MyVertex2
{
    public float3 vertex;
    public float4 color;

    public MyVertex2(float3 p, float4 c)
    {
        vertex = p;
        color = c;
    }
}

public class CriSkinned : CriObject
{
    public Vector3Int DAT_34; //0x34
    public byte DAT_3A; //0x3A
    public byte DAT_3C; //0x3C
    public byte DAT_3D; //0x3D
    public byte DAT_3E; //0x3E
    public byte DAT_3F; //0x3F
    public Vector3Int DAT_40; //0x40
    public short DAT_46; //0x46
    public sbyte DAT_48; //0x48
    public CriBone skeleton; //0x4C
    public int boneCount; //0x50
    public Packet packet; //0x54
    public Frame[] frames; //0x58
    public byte DAT_5C; //0x5C
    public byte DAT_5D; //0x5D
    public byte DAT_5E; //0x5E
    public ushort DAT_60; //0x60
    public byte DAT_62; //0x62
    public Vector3Int DAT_64; //0x64
    public Packet[] packets; //0x70
    public Frame[] DAT_74; //0x74
    public byte frameCount; //0x78
    public byte frameNum; //0x79
    public Frame frame; //0x7C
    public TodScriptableObject[] DAT_98; //0x98
    public Tmd2ScriptableObject cSkin; //0x9C
    public Vector3Int skinSize; //0xA4
    public Color32 tint; //0xB0
    public Vector3Int[] DAT_B4; //0xB4
    public Vector3Int DAT_EC; //0xEC
    public Vector3Int DAT_F2; //0xF2
    public Vector3Int DAT_F8; //0xF8
    public Vector3Int DAT_10C; //0x10C
    public short DAT_112; //0x112
    public short health; //0x118
    public short maxHealth; //0x11A
    public short DAT_11C; //0x11C
    public byte DAT_11E; //0x11E
    public int DAT_120; //0x120
    public CapsuleCollider[] PTR_120;
    public int DAT_124; //0x124
    public CapsuleCollider[] PTR_124;
    public ushort DAT_128; //0x128
    public byte DAT_12A; //0x12A
    public byte DAT_12B; //0x12B
    public ushort DAT_12C; //0x12C
    public sbyte DAT_12E; //0x12E
    public byte DAT_12F; //0x12F
    public int DAT_130; //0x130
    public CapsuleCollider[] PTR_130;
    public WallCollider DAT_134; //0x134
    public Vector2Int DAT_13C; //0x13C
    public ushort DAT_140; //0x140
    public sbyte DAT_142; //0x142
    public ushort DAT_144; //0x144
    public ushort DAT_146; //0x146
    public ushort DAT_148; //0x148
    public Vector3Int DAT_14C; //0x14C
    public short DAT_152; //0x152
    public CriSkinned DAT_154; //0x154
    public Vector3Int DAT_158; //0x158
    public byte DAT_162; //0x162
    public byte DAT_163; //0x163
    public byte DAT_164; //0x164
    public byte DAT_165; //0x165
    public byte DAT_166; //0x166
    public byte DAT_167; //0x167
    public Vector3Int DAT_168; //0x168
    public Vector2Int shadowSize; //0x170
    public byte DAT_174; //0x174
    public byte DAT_175; //0x175
    public byte DAT_176; //0x176
    public byte DAT_177; //0x177
    public CriBone[] DAT_184; //0x184
    public byte DAT_18C; //0x18C
    public bool DAT_18D; //0x18D
    public byte DAT_18E; //0x18E
    public byte DAT_18F; //0x18F
    public int DAT_190; //0x190
    public Vector3Int[] PTR_190; //0x190
    public short DAT_194; //0x194
    public short DAT_196; //0x196
    public sbyte DAT_198; //0x198
    public byte DAT_199; //0x199
    public ushort DAT_19A; //0x19A
    public ushort DAT_19C; //0x19C
    public ushort DAT_19E; //0x19E
    public byte DAT_1A0; //0x1A0
    public byte DAT_1A1; //0x1A1
    public bool DAT_1A2; //0x1A2
    public byte DAT_1A3; //0x1A3
    public byte DAT_1A4; //0x1A4
    public byte DAT_1A5; //0x1A5
    public bool DAT_1A6; //0x1A6
    public byte DAT_1A7; //0x1A7
    public int[] REFS;
    public Transform shadow;
    public Material[] materials;

    private Mesh mesh;
    private int subMeshCount;
    private NativeArray<CriTransform> bonesTransform;
    protected NativeArray<int3> bonesPosition;
    private NativeArray<CriBoneIndex> bonesIndex;
    private NativeArray<CriBoneColor> bonesColor;
    private NativeArray<MyVertex> vertexBuffer;
    private NativeArray<ushort> indexBuffer;
    private NativeArray<int> indicies;
    private NativeArray<float3> vertexData;
    private NativeArray<int3> normalData;
    private NativeArray<ushort> indexData;
    private NativeArray<MyVertex2> skinnedData;

    protected override void Awake()
    {
        base.Awake();
        DAT_184 = new CriBone[2];
        DAT_B4 = new Vector3Int[3];
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();

        if ((GameManager.instance.DAT_38 & 2) == 0 && (flags & 2) != 0)
        {
            Graphics.DrawMesh(mesh, Matrix4x4.identity, materials[0], 0, Camera.main, 0);
        }

        if ((GameManager.instance.DAT_38 & 0x20) == 0 && (flags & 2) != 0 && (DAT_174 & 0x80) != 0)
        {
            Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[3], 6, RenderQueue.camera3, 1);
        }
    }

    private void OnDestroy()
    {
        bonesTransform.Dispose();
        bonesPosition.Dispose();
        bonesIndex.Dispose();
        bonesColor.Dispose();
        vertexBuffer.Dispose();
        indexBuffer.Dispose();
        indicies.Dispose();
        vertexData.Dispose();
        normalData.Dispose();
        skinnedData.Dispose();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_34 = Vector3Int.zero;
        DAT_3A = 0;
        DAT_3C = 0;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_40 = Vector3Int.zero;
        DAT_46 = 0;
        DAT_48 = 0;
        skeleton = null;
        boneCount = 0;
        packet = null;
        frames = null;
        DAT_5C = 0;
        DAT_5D = 0;
        DAT_5E = 0;
        DAT_60 = 0;
        DAT_62 = 0;
        DAT_64 = Vector3Int.zero;
        packets = null;
        DAT_74 = null;
        frameCount = 0;
        frameNum = 0;
        frame = null;
        DAT_98 = null;
        cSkin = null;
        skinSize = Vector3Int.zero;
        tint = Color.clear;
        DAT_B4 = new Vector3Int[3];
        DAT_EC = Vector3Int.zero;
        DAT_F2 = Vector3Int.zero;
        DAT_F8 = Vector3Int.zero;
        DAT_10C = Vector3Int.zero;
        DAT_112 = 0;
        health = 0;
        maxHealth = 0;
        DAT_11C = 0;
        DAT_11E = 0;
        DAT_120 = 0;
        PTR_120 = null;
        DAT_124 = 0;
        PTR_124 = null;
        DAT_128 = 0;
        DAT_12A = 0;
        DAT_12B = 0;
        DAT_12C = 0;
        DAT_12E = 0;
        DAT_12F = 0;
        DAT_130 = 0;
        PTR_130 = null;
        DAT_134 = null;
        DAT_13C = Vector2Int.zero;
        DAT_140 = 0;
        DAT_142 = 0;
        DAT_144 = 0;
        DAT_146 = 0;
        DAT_148 = 0;
        DAT_14C = Vector3Int.zero;
        DAT_152 = 0;
        DAT_154 = null;
        DAT_158 = Vector3Int.zero;
        DAT_162 = 0;
        DAT_163 = 0;
        DAT_164 = 0;
        DAT_165 = 0;
        DAT_166 = 0;
        DAT_167 = 0;
        DAT_168 = Vector3Int.zero;
        shadowSize = Vector2Int.zero;
        DAT_174 = 0;
        DAT_175 = 0;
        DAT_176 = 0;
        DAT_177 = 0;
        DAT_184[0] = null;
        DAT_184[1] = null;
        DAT_18C = 0;
        DAT_18D = false;
        DAT_18E = 0;
        DAT_18F = 0;
        DAT_190 = 0;
        PTR_190 = null;
        DAT_194 = 0;
        DAT_196 = 0;
        DAT_198 = 0;
        DAT_199 = 0;
        DAT_19A = 0;
        DAT_19C = 0;
        DAT_19E = 0;
        DAT_1A0 = 0;
        DAT_1A1 = 0;
        DAT_1A2 = false;
        DAT_1A3 = 0;
        DAT_1A4 = 0;
        DAT_1A5 = 0;
        DAT_1A6 = false;
        DAT_1A7 = 0;
        REFS = null;
    }

    public void SetMaterials()
    {
        materials = new Material[16];
        Tmd2ScriptableObject tmd = cSkin;
        Material mat1 = new Material(GameManager.instance.materials[0]);
        Material mat2 = new Material(GameManager.instance.materials[3]);
        mat1.mainTexture = tmd.TEX_2D;
        mat1.SetTexture("_Tex8", tmd.TEX8_2D);
        mat1.SetTexture("_CLUT", tmd.CLUT_2D);
        Tmd2ScriptableObject tmd2 = (Tmd2ScriptableObject)Utilities.GetRamObject(0x8018066c);
        mat2.mainTexture = tmd2.TEX_2D;
        mat2.SetTexture("_Tex8", tmd2.TEX8_2D);
        mat2.SetTexture("_CLUT", tmd2.CLUT_2D);
        materials[0] = mat1;
        materials[3] = mat2;
    }

    public void MeshData()
    {
        subMeshCount = 2;
        indexBuffer = new NativeArray<ushort>(
            cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 6, Allocator.Persistent
        );

        vertexBuffer = new NativeArray<MyVertex>(
            cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 4, Allocator.Persistent
        );

        indicies = new NativeArray<int>(
            2, Allocator.Persistent
        );

        vertexData = new NativeArray<float3>(
            cSkin.VERTS.Length, Allocator.Persistent
        );

        normalData = new NativeArray<int3>(
            cSkin.NRMLS.Length, Allocator.Persistent
        );

        indexData = new NativeArray<ushort>(
            cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6, Allocator.Persistent
        );

        skinnedData = new NativeArray<MyVertex2>(
            cSkin.VERTS.Length, Allocator.Persistent
        );

        mesh = new Mesh();
        mesh.subMeshCount = subMeshCount;
        mesh.SetVertexBufferParams(cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 4,
                                                 new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3),
                                                 new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Float32, 4),
                                                 new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 2),
                                                 new VertexAttributeDescriptor(VertexAttribute.TexCoord1, VertexAttributeFormat.Float32, 3));
        mesh.SetIndexBufferParams(cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 6, IndexFormat.UInt16);

        for (int i = 0; i < cSkin.TRI_COUNT; i++)
        {
            int tri = i * 3;
            vertexBuffer[tri] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[tri], cSkin.UVS2[i]);
            vertexBuffer[tri + 1] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[tri + 1], cSkin.UVS2[i]);
            vertexBuffer[tri + 2] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[tri + 2], cSkin.UVS2[i]);
            int sm = indicies[0];
            indexData[sm] = (ushort)cSkin.TRIS[tri];
            indexData[sm + 1] = (ushort)cSkin.TRIS[tri + 1];
            indexData[sm + 2] = (ushort)cSkin.TRIS[tri + 2];
            indicies[0] += 3;
            indexBuffer[sm] = (ushort)sm;
            indexBuffer[sm + 1] = (ushort)(sm + 1);
            indexBuffer[sm + 2] = (ushort)(sm + 2);
        }

        for (int i = 0, j = cSkin.TRI_COUNT; i < cSkin.QUAD_COUNT; i++)
        {
            int quad = j * 3 + i * 6;
            int uv = j * 3 + i * 4;
            int tri = i * 6;
            vertexBuffer[quad] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[uv], cSkin.UVS2[i + j]);
            vertexBuffer[quad + 1] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[uv + 1], cSkin.UVS2[i + j]);
            vertexBuffer[quad + 2] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[uv + 2], cSkin.UVS2[i + j]);
            vertexBuffer[quad + 3] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[uv + 3], cSkin.UVS2[i + j]);
            vertexBuffer[quad + 4] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[uv + 2], cSkin.UVS2[i + j]);
            vertexBuffer[quad + 5] = new MyVertex(float3.zero, new float4(1, 1, 1, 1), cSkin.UVS[uv + 1], cSkin.UVS2[i + j]);
            int sm = indicies[0];
            indexData[sm] = (ushort)cSkin.QUADS[tri];
            indexData[sm + 1] = (ushort)cSkin.QUADS[tri + 1];
            indexData[sm + 2] = (ushort)cSkin.QUADS[tri + 2];
            indexData[sm + 3] = (ushort)cSkin.QUADS[tri + 3];
            indexData[sm + 4] = (ushort)cSkin.QUADS[tri + 4];
            indexData[sm + 5] = (ushort)cSkin.QUADS[tri + 5];
            indicies[0] += 6;
            indexBuffer[sm] = (ushort)sm;
            indexBuffer[sm + 1] = (ushort)(sm + 1);
            indexBuffer[sm + 2] = (ushort)(sm + 2);
            indexBuffer[sm + 3] = (ushort)(sm + 3);
            indexBuffer[sm + 4] = (ushort)(sm + 4);
            indexBuffer[sm + 5] = (ushort)(sm + 5);
        }

        for (int i = 0; i < cSkin.VERTS.Length; i++)
        {
            vertexData[i] = cSkin.VERTS[i];
        }

        for (int i = 0; i < cSkin.NRMLS.Length; i++)
        {
            normalData[i] = new int3(cSkin.NRMLS[i].x, cSkin.NRMLS[i].y, cSkin.NRMLS[i].z);
        }

        int v = vertexBuffer.Length - 4;
        int l = indexBuffer.Length - 6;
        indexBuffer[l] = (ushort)v;
        indexBuffer[l + 1] = (ushort)(v + 1);
        indexBuffer[l + 2] = (ushort)(v + 2);
        indexBuffer[l + 3] = (ushort)(v + 3);
        indexBuffer[l + 4] = (ushort)(v + 2);
        indexBuffer[l + 5] = (ushort)(v + 1);
        indicies[1] += 6;

        mesh.SetVertexBufferData(vertexBuffer, 0, 0, cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 4);
        mesh.SetIndexBufferData(indexBuffer, 0, 0, cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 6);
        mesh.SetSubMesh(0, new SubMeshDescriptor(0, indicies[0]));
        mesh.SetSubMesh(1, new SubMeshDescriptor(indicies[0], indicies[1]));
    }

    //FUN_7569C
    public void MeshJob(Tmd2ScriptableObject param1)
    {
        int index = boneCount - 1;
        CriBone b = skeleton;

        if (index != -1)
        {
            do
            {
                if (b.cMesh != null)
                    b.MeshJob(b.cMesh);
                
                bonesTransform[b.boneId] = b.cTransform;
                b = (CriBone)b.next;
                index--;
            } while (index != -1);
        }

        SkinnedMeshJob job = new SkinnedMeshJob
        {
            bonesTransform = bonesTransform,
            bonesPosition = bonesPosition, 
            bonesIndex = bonesIndex, 
            bonesColor = bonesColor, 
            vertexBuffer = vertexBuffer,
            indexData = indexData, 
            vertexData = vertexData, 
            normalData = normalData, 
            skinnedData = skinnedData,
            skinnedTransform = cTransform,
            colorCode = Coprocessor.colorCode, 
            backgroundColor = Coprocessor.backgroundColor,
            skeleton = skeleton.boneId, 
            boneCount = boneCount, 
            triCount = cSkin.TRI_COUNT, 
            quadCount = cSkin.QUAD_COUNT
        };
        JobHandle handle = job.Schedule();
        JobManager.instance.AddJob(handle);
    }

    public void ShadowJob()
    {
        ShadowMeshJob job = new ShadowMeshJob
        {
            vertexBuffer = vertexBuffer,
            length = vertexBuffer.Length,
            DAT_1f80006c = new int3(GameManager.DAT_1f80006c.x, GameManager.DAT_1f80006c.y, GameManager.DAT_1f80006c.z),
            DAT_1f800074 = new int3(GameManager.DAT_1f800074.x, GameManager.DAT_1f800074.y, GameManager.DAT_1f800074.z),
            DAT_1f80007c = new int3(GameManager.DAT_1f80007c.x, GameManager.DAT_1f80007c.y, GameManager.DAT_1f80007c.z),
            DAT_1f800084 = new int3(GameManager.DAT_1f800084.x, GameManager.DAT_1f800084.y, GameManager.DAT_1f800084.z),
            DAT_1f800068 = new int4(GameManager.DAT_1f800068.r, GameManager.DAT_1f800068.g, GameManager.DAT_1f800068.b, GameManager.DAT_1f800068.a),
            DAT_1f80007a = GameManager.DAT_1f80007a,
            DAT_1f800072 = GameManager.DAT_1f800072,
            DAT_1f800070 = GameManager.DAT_1f800070,
            DAT_1f800071 = GameManager.DAT_1f800071,
            DAT_1f800078 = GameManager.DAT_1f800078,
            DAT_1f800079 = GameManager.DAT_1f800079,
            DAT_1f800080 = GameManager.DAT_1f800080,
            DAT_1f800081 = GameManager.DAT_1f800081,
            DAT_1f800088 = GameManager.DAT_1f800088,
            DAT_1f800089 = GameManager.DAT_1f800089
        };
        JobHandle handle = job.Schedule();
        JobManager.instance.AddJob(handle);
    }

    public void SetSkeletonPrevious(CriPlayer player)
    {
        skeleton.prev = player;
        skeleton.prevId = -1;
        bonesIndex[skeleton.boneId] = new CriBoneIndex
        (
            skeleton.nextId,
            skeleton.prevId,
            skeleton.DAT_42
        );
    }

    public void SetBoneTransform(CriBone bone)
    {
        bone.cTransform = bonesTransform[bone.boneId];
        bone.BoneTransform();
    }

    public void SetBoneColor(ref Matrix3x3 lm, ref Matrix3x3 cm, int index)
    {
        bonesColor[index] = new CriBoneColor(lm, cm);
    }

    public void UpdateMesh()
    {
        if ((flags & 2) != 0)
        {
            if ((DAT_174 & 0x80) != 0)
            {
                mesh.SetVertexBufferData(vertexBuffer, 0, 0, cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6 + 4);
                mesh.RecalculateBounds();
            }
            else
            {
                mesh.SetVertexBufferData(vertexBuffer, 0, 0, cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6);
                mesh.RecalculateBounds();
            }
        }
    }

    public void FUN_60278()
    {
        bool bVar1;
        int iVar2;
        CriBone oVar3;

        oVar3 = skeleton;
        iVar2 = boneCount - 2;

        if (boneCount != 0)
        {
            do
            {
                oVar3.flags = 0;
                oVar3 = (CriBone)oVar3.next;
                bVar1 = iVar2 != -1;
                iVar2--;
            } while (bVar1);
        }
    }

    public void FUN_60444()
    {
        Bone puVar2;
        int iVar3;
        CriBone oVar4;
        int puVar5;

        oVar4 = skeleton;
        iVar3 = boneCount - 1;
        puVar5 = 0;

        if (iVar3 != -1)
        {
            do
            {
                puVar2 = cSkin.BONES[puVar5];
                oVar4.DAT_44 = puVar2.DAT_00;
                bonesPosition[oVar4.boneId] = new int3(puVar2.DAT_00.x, puVar2.DAT_00.y, puVar2.DAT_00.z);
                iVar3--;
                puVar5++;
            } while (iVar3 != -1);
        }
    }

    public void FUN_604A4(Tmd2ScriptableObject param1)
    {
        byte bVar1;
        CriBone oVar2;
        uint uVar4;
        int iVar5;
        Bone puVar7;
        uint uVar8;
        CriBone[] local_a0;

        uVar8 = (uint)param1.BONE_COUNT;
        uVar4 = 0;
        local_a0 = new CriBone[30];

        if (uVar8 != 0)
        {
            do
            {
                puVar7 = param1.BONES[uVar4];
                oVar2 = SceneManager.instance.FUN_601F0();
                local_a0[uVar4] = oVar2;
                oVar2.DAT_44 = puVar7.DAT_00;

                if (puVar7.DAT_06 < 0)
                {
                    oVar2.prev = this;
                    oVar2.prevId = -1;
                }
                else
                {
                    oVar2.prev = local_a0[puVar7.DAT_06];
                    oVar2.prevId = puVar7.DAT_06;
                }

                bVar1 = puVar7.DAT_07;
                oVar2.boneId = (int)uVar4;
                uVar4++;
                oVar2.DAT_42 = bVar1;
            } while (uVar4 < uVar8);
        }

        uVar4 = 0;

        if (uVar8 != 1)
        {
            do
            {
                uVar4++;
                local_a0[uVar4 - 1].next = local_a0[uVar4];
                local_a0[uVar4 - 1].nextId = (int)uVar4;
            } while (uVar4 < uVar8 - 1);
        }

        local_a0[uVar4].next = null;
        local_a0[uVar4].nextId = -1;
        skinSize = new Vector3Int(0x1000, 0x1000, 0x1000);
        shadowSize = new Vector2Int(0x1000, 0x1000);
        tint = new Color32(0x80, 0x80, 0x80, 0x00);
        boneCount = (int)uVar8;
        DAT_5E = (byte)((uVar8 * 0x24 + 0x1f >> 5) * 4 + 12);
        DAT_198 = -1;
        cSkin = param1;
        DAT_1A5 = 5;
        skeleton = local_a0[0];
        FUN_66208();
        iVar5 = boneCount;
        oVar2 = skeleton;

        while (--iVar5 != -1)
        {
            oVar2.DAT_4C = oVar2.screen;
            oVar2 = (CriBone)oVar2.next;
        }

        bonesTransform = new NativeArray<CriTransform>(boneCount, Allocator.Persistent);
        bonesPosition = new NativeArray<int3>(boneCount, Allocator.Persistent);
        bonesIndex = new NativeArray<CriBoneIndex>(boneCount, Allocator.Persistent);
        bonesColor = new NativeArray<CriBoneColor>(boneCount, Allocator.Persistent);

        for (int i = 0; i < boneCount; i++)
        {
            CriBone b = local_a0[i];
            bonesTransform[i] = b.cTransform;
            bonesPosition[i] = new int3(b.DAT_44.x, b.DAT_44.y, b.DAT_44.z);
            bonesIndex[i] = new CriBoneIndex(b.nextId, b.prevId, b.DAT_42);
        }
    }

    public bool FUN_60AB4()
    {
        byte bVar1;
        byte bVar2;
        byte bVar3;
        uint uVar4;
        bool bVar6;

        bVar1 = DAT_5C;
        DAT_60++;
        bVar6 = false;

        if ((bVar1 & 0x20) == 0)
        {
            if (DAT_62 != 0) goto LAB_60C78;

            bVar3 = frameNum;
            frameNum = (byte)(bVar3 + 1);

            if ((bVar1 & 4) != 0)
            {
                bVar6 = frameCount <= bVar3 + 1U;

                if (frameCount < bVar3 + 1U)
                {
                    if ((bVar1 & 1) == 0)
                        frameNum = bVar3;
                    else
                    {
                        frameNum = 0;
                        DAT_60 = 0;
                    }
                }

                if ((uint)frames[frameNum].DAT_00 >> 1 == 0)
                    frameNum++;
            }

            if ((uint)frameCount <= frameNum)
            {
                bVar6 = true;

                if ((bVar1 & 1) == 0)
                    DAT_5C |= 0x20;
            }

            if ((uint)frameCount < frameNum)
            {
                if ((bVar1 & 1) == 0)
                    frameNum--;
                else
                {
                    frameNum = 0;
                    DAT_60 = 0;
                }
            }

            if ((bVar1 & 2) == 0)
                uVar4 = frameNum;
            else
                uVar4 = (uint)frameCount - frameNum;

            packet = packets[frames[uVar4].DAT_01];
            bVar2 = frames[uVar4].DAT_00;
            DAT_62 = bVar2;

            if ((bVar1 & 4) != 0 && 1U < bVar2)
                DAT_62 = (byte)((uint)bVar2 >> 1);

            if ((bVar1 & 8) == 0) goto LAB_60C78;

            bVar3 = (byte)(DAT_62 << 1);
        }
        else
            bVar3 = (byte)(DAT_62 + 1);

        DAT_62 = bVar3;
        LAB_60C78:
        FUN_607A4();
        return bVar6;
    }

    public void FUN_607A4()
    {
        byte bVar1;
        int iVar1;
        CriBone oVar2;
        Packet psVar3;
        Vector3Int local_18;

        psVar3 = packet;
        oVar2 = skeleton;

        if ((DAT_5C & 2) == 0)
            bVar1 = frameNum;
        else
            bVar1 = (byte)(frameCount - frameNum);

        frame = frames[bVar1];
        DAT_64 = psVar3.DAT_06;

        if ((DAT_5C & 0x10) == 0)
        {
            local_18 = psVar3.DAT_00;

            if (DAT_5D == 0)
                bVar1 = DAT_62;
            else
                bVar1 = (byte)(DAT_62 + DAT_5D);

            if (bVar1 == 0)
                return; //trap(0x1c00)

            oVar2.DAT_44 = Utilities.LoadAverageShort12
                (ref oVar2.DAT_44, ref local_18, 0x1000 - 0x1000 / bVar1, 0x1000 / bVar1);
            bonesPosition[oVar2.boneId] = new int3(oVar2.DAT_44.x, oVar2.DAT_44.y, oVar2.DAT_44.z);
        }
        else
        {
            oVar2.DAT_44 = psVar3.DAT_00;
            bonesPosition[oVar2.boneId] = new int3(oVar2.DAT_44.x, oVar2.DAT_44.y, oVar2.DAT_44.z);
        } 

        if (DAT_5D == 0)
        {
            Utilities.FUN_60C94(psVar3.COMP, GameManager.instance.todUncomp, boneCount);

            if (DAT_62 == 0)
                return; //trap(0x1c00)

            FUN_60EF0((uint)boneCount, 0x1000 / DAT_62);
        }
        else
        {
            Utilities.FUN_60C94(psVar3.COMP, GameManager.instance.todUncomp, boneCount);
            iVar1 = DAT_62 + DAT_5D;

            if (iVar1 == 0)
                return; //trap(0x1c00)

            FUN_60EF0((uint)boneCount, 0x1000 / iVar1);
            DAT_5D--;
        }

        DAT_62--;
    }

    public void FUN_609C8(TodScriptableObject param1, byte param2, byte param3, uint param4)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;

        if (param1 == null)
        {
            FUN_609C8(REFS[param4 / 4], param2, param3);
            return;
        }

        packets = param1.PACKETS;
        bVar1 = (byte)param1.FRAME_COUNT;
        frames = param1.FRAMES;
        DAT_74 = param1.FRAMES;
        frameNum = 0;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
            uVar3 = frameNum;
        else
            uVar3 = (uint)(bVar1 - frameNum);

        packet = packets[frames[uVar3].DAT_01];
        DAT_62 = frames[uVar3].DAT_00;
        bVar2 = frames[0].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = param3;
        FUN_607A4();
    }

    public void FUN_609C8(int param1, byte param2, byte param3)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;

        packets = DAT_98[param1].PACKETS;
        bVar1 = (byte)DAT_98[param1].FRAME_COUNT;
        frames = DAT_98[param1].FRAMES;
        DAT_74 = DAT_98[param1].FRAMES;
        frameNum = 0;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
            uVar3 = frameNum;
        else
            uVar3 = (uint)(bVar1 - frameNum);

        packet = packets[frames[uVar3].DAT_01];
        DAT_62 = frames[uVar3].DAT_00;
        bVar2 = frames[0].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = param3;
        FUN_607A4();
    }

    public void FUN_60EF0(uint param1, int param2)
    {
        uint uVar1;
        CriBone oVar2;
        List<Vector3Int> puVar3;
        int iVar4;
        bool bVar5;
        int iVar6;

        puVar3 = GameManager.instance.todUncomp;
        oVar2 = skeleton;
        bVar5 = false;

        if ((DAT_5C & 0x40) == 0)
        {
            uVar1 = 0;

            if (param1 != 0)
            {
                do
                {
                    Vector3Int temp = puVar3[(int)uVar1];
                    Utilities.FUN_665D8(ref oVar2.vr, ref temp, ref oVar2.vr, param2);
                    puVar3[(int)uVar1] = temp;
                    oVar2 = (CriBone)oVar2.next;
                    uVar1++;
                } while (uVar1 < param1);
            }
        }
        else
        {
            uVar1 = 0;

            if (param1 != 0)
            {
                iVar4 = -1;

                do
                {
                    if (uVar1 - 1 < 14)
                    {
                        switch (iVar4)
                        {
                            case 0:
                                bVar5 = true;
                                break;
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                                if ((DAT_5C & 0x40) != 0)
                                    bVar5 = true;

                                break;
                            case 7:
                                bVar5 = false;
                                break;
                            case 8:
                            case 9:
                            case 10:
                            case 11:
                            case 12:
                            case 13:
                                if ((DAT_5C & 0x80) != 0)
                                    bVar5 = true;

                                break;
                        }
                    }

                    Vector3Int temp = puVar3[(int)uVar1];
                    iVar6 = bVar5 ? param2 : 0x1000;
                    Utilities.FUN_665D8(ref oVar2.vr, ref temp, ref oVar2.vr, iVar6);
                    oVar2 = (CriBone)oVar2.next;
                    uVar1++;
                    iVar4++;
                } while (uVar1 < param1);
            }
        }
    }

    public void FUN_6103C(TodScriptableObject param1, byte param2, byte param3, int param4)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;
        CriBone oVar4;

        packets = param1.PACKETS;
        bVar1 = (byte)param1.FRAME_COUNT;
        frames = param1.FRAMES;
        DAT_74 = param1.FRAMES;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
        {
            frameNum = param3;
            uVar3 = param3;
        }
        else
        {
            frameNum = (byte)(bVar1 - param3);
            uVar3 = (uint)bVar1 - frameNum;
        }

        packet = packets[frames[uVar3].DAT_01];
        bVar2 = frames[uVar3].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = (byte)param4;

        if (param4 == 0)
        {
            oVar4 = skeleton;

            if (oVar4 != null)
            {
                oVar4.vr = new Vector3Int(0, 0, 0);
                oVar4 = oVar4.next as CriBone;
            }
        }

        FUN_607A4();
    }

    public void FUN_6103C(int param1, byte param2, byte param3, int param4)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;
        CriBone oVar4;

        packets = DAT_98[param1].PACKETS;
        bVar1 = (byte)DAT_98[param1].FRAME_COUNT;
        frames = DAT_98[param1].FRAMES;
        DAT_74 = DAT_98[param1].FRAMES;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
        {
            frameNum = param3;
            uVar3 = param3;
        }
        else
        {
            frameNum = (byte)(bVar1 - param3);
            uVar3 = (uint)bVar1 - frameNum;
        }

        packet = packets[frames[uVar3].DAT_01];
        bVar2 = frames[uVar3].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = (byte)param4;

        if (param4 == 0)
        {
            oVar4 = skeleton;

            if (oVar4 != null)
            {
                oVar4.vr = new Vector3Int(0, 0, 0);
                oVar4 = oVar4.next as CriBone;
            }
        }

        FUN_607A4();
    }

    public void FUN_6449C(ushort param2)
    {
        bool bVar1;
        int iVar2;
        int iVar3;

        if (0 < screen.y)
            screen.y = 0;

        iVar3 = DAT_34.y / 425 * -0x1000000 >> 0x18;
        iVar2 = screen.y / 425 * -0x1000000 >> 0x18;

        if (iVar2 < iVar3)
        {
            do
            {
                if (iVar3 < iVar2)
                    return;

                bVar1 = SceneManager.instance.FUN_64210(ref screen, (byte)iVar3, param2);
                iVar3--;
            } while (!bVar1);
        }
        else
        {
            do
            {
                if (iVar3 < iVar2)
                    return;

                bVar1 = SceneManager.instance.FUN_64210(ref screen, (byte)iVar2, param2);
                iVar2++;
            } while (!bVar1);
        }
    }

    private void FUN_65618(CriSkinned param1)
    {
        GameManager.DAT_1f80002c = DAT_64;
        Utilities.RotMatrix_gte(ref vr, ref GameManager.DAT_1f800034);
        GameManager.DAT_1f80002c = Utilities.ApplyMatrixSV
            (ref GameManager.DAT_1f800034, ref GameManager.DAT_1f80002c);
        DAT_14C.x = screen.x - GameManager.DAT_1f80002c.x;
        DAT_14C.y = screen.y - GameManager.DAT_1f80002c.y;
        DAT_14C.z = screen.z - GameManager.DAT_1f80002c.z;
        param1.DAT_14C = DAT_14C;
    }

    public void FUN_656EC()
    {
        FUN_65618(SceneManager.instance.skinnedObjects[10]);
    }

    public void FUN_65714()
    {
        GameManager.DAT_1f80002c = new Vector3Int(DAT_64.x, -DAT_64.y, -DAT_64.z);
        Utilities.RotMatrix_gte(ref vr, ref GameManager.DAT_1f800034);
        GameManager.DAT_1f80002c = Utilities.ApplyMatrixSV
            (ref GameManager.DAT_1f800034, ref GameManager.DAT_1f80002c);
        screen.x = DAT_14C.x + GameManager.DAT_1f80002c.x;
        screen.y = DAT_14C.y + GameManager.DAT_1f80002c.y;
        screen.z = DAT_14C.z + GameManager.DAT_1f80002c.z;
    }

    public void FUN_65890()
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        short sVar5;
        int iVar6;

        uVar4 = frame.DAT_01;

        if ((DAT_5C & 2) == 0)
        {
            iVar6 = (int)(uVar4 - 1);

            if (uVar4 == 0)
            {
                sVar2 = 0;
                sVar3 = 0;
                sVar5 = 0;
                goto LAB_65928;
            }

            bVar1 = DAT_5E;
            //iVar6 *= bVar1;
        }
        else
        {
            if (uVar4 != frameCount)
            {
                bVar1 = DAT_5E;
                iVar6 = (int)(uVar4 + 1);
                //iVar6 *= bVar1;
            }
            else
                iVar6 = (int)uVar4;
        }

        sVar5 = (short)packets[iVar6].DAT_06.x;
        sVar3 = (short)-packets[iVar6].DAT_06.y;
        sVar2 = (short)-packets[iVar6].DAT_06.z;
        LAB_65928:
        DAT_40.x = DAT_64.x - sVar5;
        DAT_40.y = -sVar3 - DAT_64.y;
        DAT_40.z = -sVar2 - DAT_64.z;

        if ((DAT_5C & 8) != 0)
        {
            DAT_40.x >>= 1;
            DAT_40.y >>= 1;
            DAT_40.z >>= 1;
        }
    }

    public void FUN_659D0()
    {
        CriBone oVar1;
        uint uVar2;

        FUN_66208();
        uVar2 = 0;

        do
        {
            oVar1 = DAT_184[uVar2];
            uVar2++;
            oVar1.DAT_4C = oVar1.screen;
        } while (uVar2 < 2);
    }

    public void FUN_65984(int param1, int param2)
    {
        CriBone oVar1;

        DAT_18C = 0;
        oVar1 = Utilities.FUN_601C8(skeleton, param1) as CriBone;
        DAT_184[0] = oVar1;
        oVar1 = Utilities.FUN_601C8(skeleton, param2) as CriBone;
        DAT_184[1] = oVar1;
    }

    public uint FUN_65A28()
    {
        short sVar1;
        short sVar2;
        CriBone oVar3;
        short sVar4;
        CriBone oVar5;
        uint uVar6;

        uVar6 = DAT_18C;

        if (uVar6 == 0)
            uVar6 = frames[frameNum].DAT_02;

        if ((uVar6 & 0xe0) != 0)
        {
            oVar5 = DAT_184[uVar6 & 1];

            if ((uVar6 & 0x80) != 0)
            {
                screen.x -= oVar5.screen.x - oVar5.DAT_4C.x;
                screen.z -= oVar5.screen.z - oVar5.DAT_4C.z;
            }

            if ((uVar6 & 0x40) == 0)
            {
                if ((uVar6 & 0x20) == 0)
                    return uVar6;

                oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
                sVar4 = (short)oVar5.screen.y;
                sVar1 = (short)oVar5.DAT_4C.y;
                sVar2 = (short)oVar3.DAT_44.y;
            }
            else
            {
                oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
                sVar1 = (short)screen.y;
                sVar2 = (short)oVar3.DAT_44.y;
                sVar4 = (short)(oVar5.screen.y + 0x74);
            }

            oVar3.DAT_44.y = sVar2 - (sVar4 - sVar1);
            bonesPosition[oVar3.boneId] = new int3(oVar3.DAT_44.x, oVar3.DAT_44.y, oVar3.DAT_44.z);
        }

        return uVar6;
    }

    public void FUN_65C4C(CriPlayer param1)
    {
        param1.DAT_1DC = (CriPlayer)this;

        if (param1.DAT_98 != DAT_98)
        {
            param1.DAT_1E0 = param1.DAT_98;
            param1.DAT_98 = DAT_98;
        }
    }

    public void FUN_65CF8(byte param1, byte param2, byte param3)
    {
        DAT_164 = param1;
        DAT_165 = 0;
        DAT_166 = param2;
        DAT_167 = param3;
    }

    public void FUN_65D0C(byte param1, byte param2)
    {
        DAT_164 = param1;
        DAT_165 = 0;
        DAT_167 = param2;
    }

    public bool FUN_65D78(ref UNK_9B314 param1, byte param2, byte param3)
    {
        bool bVar2;
        CriStatic oVar3;
        CriInteract oVar4;
        CriBone oVar5;

        oVar3 = SceneManager.instance.FUN_5FE78();
        bVar2 = false;

        if (oVar3 != null)
        {
            oVar4 = SceneManager.instance.FUN_5FF08();
            bVar2 = oVar4 != null;

            if (bVar2)
            {
                oVar3.flags = 3;
                oVar5 = (CriBone)Utilities.FUN_601C8(skeleton, param1.bone);
                oVar3.DAT_40 = oVar5;
                oVar3.screen = param1.screen;
                oVar3.vr = param1.vr;
                oVar3.cMesh = (TmdScriptableObject)GameManager.instance.playerCore.objects[0x80180178];
                oVar4.DAT_01 = 12;
                oVar4.DAT_1C = oVar3;
                oVar4.DAT_20 = this;
                oVar4.DAT_18 = param2;
                oVar4.DAT_19 = param3;
                oVar4.DAT_16 = (short)param1.bone;
            }
        }

        return bVar2;
    }

    public void FUN_65EDC()
    {
        int iVar1;
        CriBone oVar2;

        iVar1 = boneCount;
        oVar2 = skeleton;

        while (--iVar1 != -1)
        {
            oVar2.flags &= 0xfffffffd;
            oVar2 = (CriBone)oVar2.next;
        }
    }

    public int FUN_6615C()
    {
        short sVar1;
        WallCollider puVar2;
        ushort uVar3;
        Vector3Int local_10;

        puVar2 = DAT_134;
        uVar3 = 0;

        switch (puVar2.DAT_00)
        {
            case 0:
                uVar3 = (ushort)((DAT_142 - 1 & 0xff) << 10);
                goto LAB_661A0;
            case 1:
            case 6:
                local_10 = new Vector3Int(puVar2.DAT_04.x, 0, puVar2.DAT_04.y);
                break;
            case 2:
            case 3:
            case 4:
            case 5:
                Utilities.FUN_6608C(puVar2, out local_10);
                break;
            default:
                goto LAB_661A0;
        }

        sVar1 = (short)Utilities.FUN_615EC(screen, local_10);
        uVar3 = (ushort)(sVar1 + 0x800 & 0xfff);
        LAB_661A0:
        return (short)uVar3;
    }

    public void FUN_66208()
    {
        long lVar3;
        int iVar4;
        int iVar6;
        int iVar7;
        int iVar8;
        CriObject puVar9;
        int iVar10;
        CriBone m;

        Utilities.RotMatrix_gte(ref vr, ref cTransform.rotation);
        Utilities.ScaleMatrix(ref cTransform.rotation, ref skinSize);
        m = skeleton;
        iVar10 = boneCount - 1;
        cTransform.position = screen;

        do
        {
            puVar9 = m.prev;

            if (!m.DAT_43)
                Utilities.RotMatrix_gte(ref m.vr, ref m.cTransform.rotation);
            else
                Utilities.RotMatrixYXZ_gte(ref m.vr, ref m.cTransform.rotation);

            Coprocessor.rotationMatrix.rt11 = puVar9.cTransform.rotation.V00;
            Coprocessor.rotationMatrix.rt12 = puVar9.cTransform.rotation.V01;
            Coprocessor.rotationMatrix.rt13 = puVar9.cTransform.rotation.V02;
            Coprocessor.rotationMatrix.rt21 = puVar9.cTransform.rotation.V10;
            Coprocessor.rotationMatrix.rt22 = puVar9.cTransform.rotation.V11;
            Coprocessor.rotationMatrix.rt23 = puVar9.cTransform.rotation.V12;
            Coprocessor.rotationMatrix.rt31 = puVar9.cTransform.rotation.V20;
            Coprocessor.rotationMatrix.rt32 = puVar9.cTransform.rotation.V21;
            Coprocessor.rotationMatrix.rt33 = puVar9.cTransform.rotation.V22;
            Coprocessor.vector0.vx0 = (short)m.DAT_44.x;
            Coprocessor.vector0.vy0 = (short)m.DAT_44.y;
            Coprocessor.vector0.vz0 = (short)m.DAT_44.z;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            lVar3 = Coprocessor.mathsAccumulator.mac1;
            m.cTransform.position.x = (int)lVar3;
            lVar3 = Coprocessor.mathsAccumulator.mac2;
            m.cTransform.position.y = (int)lVar3;
            lVar3 = Coprocessor.mathsAccumulator.mac3;
            m.cTransform.position.z = (int)lVar3;
            Coprocessor.accumulator.ir1 = m.cTransform.rotation.V00;
            Coprocessor.accumulator.ir2 = m.cTransform.rotation.V10;
            Coprocessor.accumulator.ir3 = m.cTransform.rotation.V20;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = m.cTransform.position.x + puVar9.cTransform.position.x;
            m.cTransform.position.x = iVar4;
            m.screen.x = iVar4;
            iVar6 = Coprocessor.accumulator.ir1;
            iVar7 = Coprocessor.accumulator.ir2;
            iVar8 = Coprocessor.accumulator.ir3;
            m.cTransform.rotation.V00 = (short)iVar6;
            m.cTransform.rotation.V10 = (short)iVar7;
            m.cTransform.rotation.V20 = (short)iVar8;
            Coprocessor.accumulator.ir1 = m.cTransform.rotation.V01;
            Coprocessor.accumulator.ir2 = m.cTransform.rotation.V11;
            Coprocessor.accumulator.ir3 = m.cTransform.rotation.V21;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = m.cTransform.position.y + puVar9.cTransform.position.y;
            m.cTransform.position.y = iVar4;
            m.screen.y = iVar4;
            iVar6 = Coprocessor.accumulator.ir1;
            iVar7 = Coprocessor.accumulator.ir2;
            iVar8 = Coprocessor.accumulator.ir3;
            m.cTransform.rotation.V01 = (short)iVar6;
            m.cTransform.rotation.V11 = (short)iVar7;
            m.cTransform.rotation.V21 = (short)iVar8;
            Coprocessor.accumulator.ir1 = m.cTransform.rotation.V02;
            Coprocessor.accumulator.ir2 = m.cTransform.rotation.V12;
            Coprocessor.accumulator.ir3 = m.cTransform.rotation.V22;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = m.cTransform.position.z + puVar9.cTransform.position.z;
            m.cTransform.position.z = iVar4;
            m.screen.z = iVar4;
            iVar6 = Coprocessor.accumulator.ir1;
            iVar7 = Coprocessor.accumulator.ir2;
            iVar8 = Coprocessor.accumulator.ir3;
            m.cTransform.rotation.V02 = (short)iVar6;
            m.cTransform.rotation.V12 = (short)iVar7;
            m.cTransform.rotation.V22 = (short)iVar8;
            iVar10--;
            m = (CriBone)m.next;
        } while (iVar10 != -1);
    }

    public void FUN_66404(byte param1, short param2, short param3)
    {
        DAT_174 = (byte)(param1 | 0x80);
        shadowSize = new Vector2Int(param2, param3);
    }

    public void FUN_66418()
    {
        DAT_174 &= 0x7f;
    }

    public void FUN_6642C(bool param1)
    {
        if (param1)
        {
            DAT_174 |= 0x80;
            return;
        }

        DAT_174 &= 0x7f;
    }

    public void FUN_66460(bool param1)
    {
        if (param1)
        {
            DAT_174 |= 0x40;
            return;
        }

        DAT_174 &= 0xbf;
    }

    public void FUN_77784(uint param1, ushort param2)
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = param1 & 0xff;

        if (uVar2 == 0)
            return; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar1 == -0x80000000)
            return; //trap(0x1800)

        DAT_146 = param2;
        DAT_144 = (ushort)(((param1 & 0xff) - 1) * 400 | 0x8000 | (ushort)(iVar1 & (int)uVar2));
    }

    public void FUN_2D704()
    {
        short sVar1;
        int iVar2;
        uint uVar3;

        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = 850;

        if (iVar2 == (iVar2 / 3) * 3)
        {
            uVar3 = GameManager.FUN_64650();
            sVar1 = 1000;

            if ((uVar3 & 2) == 0)
                sVar1 = 750;
        }

        maxHealth = sVar1;
    }
}

[BurstCompile]
struct SkinnedMeshJob : IJob
{
    public NativeArray<CriTransform> bonesTransform;
    [ReadOnly] public NativeArray<int3> bonesPosition;
    [ReadOnly] public NativeArray<CriBoneIndex> bonesIndex;
    [ReadOnly] public NativeArray<CriBoneColor> bonesColor;
    public NativeArray<MyVertex> vertexBuffer;
    [ReadOnly] public NativeArray<ushort> indexData;
    [ReadOnly] public NativeArray<float3> vertexData;
    [ReadOnly] public NativeArray<int3> normalData;
    public NativeArray<MyVertex2> skinnedData;
    public Cop2ClrCode colorCode;
    public Cop2BC backgroundColor;
    public CriTransform skinnedTransform;
    public int skeleton;
    public int boneCount;
    public int triCount;
    public int quadCount;

    public void Execute()
    {
        Cop2Vector0 vector0;
        Cop2Vector1 vector1;
        Cop2Vector2 vector2;
        Cop2Accumulator accumulator = new Cop2Accumulator();
        Cop2Maths mathsAccumulator = new Cop2Maths();
        Cop2RT rotationMatrix;
        Cop2TV translationVector;
        Cop2LLM lightMatrix;
        Cop2LCM lightColorMatrix;
        Cop2ClrFIFO colorFIFO = new Cop2ClrFIFO();
        CriTransform cTransform = new CriTransform();
        Matrix4x4 m = new Matrix4x4();
        int puVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        int puVar10;
        int iVar12;
        int iVar19;
        int iVar20;
        int3 DAT_1f800380;
        int3 DAT_1f800388;
        int3 DAT_1f800390;

        puVar10 = skeleton;
        iVar12 = boneCount - 1;

        if (iVar12 != -1)
        {
            iVar20 = 0;

            do
            {
                lightMatrix.l11 = bonesColor[puVar10].lightMatrix.V00;
                lightMatrix.l12 = bonesColor[puVar10].lightMatrix.V01;
                lightMatrix.l13 = bonesColor[puVar10].lightMatrix.V02;
                lightMatrix.l21 = bonesColor[puVar10].lightMatrix.V10;
                lightMatrix.l22 = bonesColor[puVar10].lightMatrix.V11;
                lightMatrix.l23 = bonesColor[puVar10].lightMatrix.V12;
                lightMatrix.l31 = bonesColor[puVar10].lightMatrix.V20;
                lightMatrix.l32 = bonesColor[puVar10].lightMatrix.V21;
                lightMatrix.l33 = bonesColor[puVar10].lightMatrix.V22;
                lightColorMatrix.lr1 = bonesColor[puVar10].colorMatrix.V00;
                lightColorMatrix.lr2 = bonesColor[puVar10].colorMatrix.V01;
                lightColorMatrix.lr3 = bonesColor[puVar10].colorMatrix.V02;
                lightColorMatrix.lg1 = bonesColor[puVar10].colorMatrix.V10;
                lightColorMatrix.lg2 = bonesColor[puVar10].colorMatrix.V11;
                lightColorMatrix.lg3 = bonesColor[puVar10].colorMatrix.V12;
                lightColorMatrix.lb1 = bonesColor[puVar10].colorMatrix.V20;
                lightColorMatrix.lb2 = bonesColor[puVar10].colorMatrix.V21;
                lightColorMatrix.lb3 = bonesColor[puVar10].colorMatrix.V22;
                puVar6 = bonesIndex[puVar10].prev;

                if (puVar6 != -1)
                {
                    rotationMatrix.rt11 = bonesTransform[puVar6].rotation.V00;
                    rotationMatrix.rt12 = bonesTransform[puVar6].rotation.V01;
                    rotationMatrix.rt13 = bonesTransform[puVar6].rotation.V02;
                    rotationMatrix.rt21 = bonesTransform[puVar6].rotation.V10;
                    rotationMatrix.rt22 = bonesTransform[puVar6].rotation.V11;
                    rotationMatrix.rt23 = bonesTransform[puVar6].rotation.V12;
                    rotationMatrix.rt31 = bonesTransform[puVar6].rotation.V20;
                    rotationMatrix.rt32 = bonesTransform[puVar6].rotation.V21;
                    rotationMatrix.rt33 = bonesTransform[puVar6].rotation.V22;
                    vector0.vx0 = (short)bonesPosition[puVar10].x;
                    vector0.vy0 = (short)bonesPosition[puVar10].y;
                    vector0.vz0 = (short)bonesPosition[puVar10].z;
                    MVMVA_rotation_vector0_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector0);
                    cTransform.position.x = mathsAccumulator.mac1;
                    cTransform.position.y = mathsAccumulator.mac2;
                    cTransform.position.z = mathsAccumulator.mac3;
                    accumulator.ir1 = bonesTransform[puVar10].rotation.V00;
                    accumulator.ir2 = bonesTransform[puVar10].rotation.V10;
                    accumulator.ir3 = bonesTransform[puVar10].rotation.V20;
                    MVMVA_rotation_accumulator_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator);
                    cTransform.position.x += bonesTransform[puVar6].position.x;
                    iVar7 = accumulator.ir1;
                    iVar8 = accumulator.ir2;
                    iVar9 = accumulator.ir3;
                    cTransform.rotation.V00 = (short)iVar7;
                    cTransform.rotation.V10 = (short)iVar8;
                    cTransform.rotation.V20 = (short)iVar9;
                    accumulator.ir1 = bonesTransform[puVar10].rotation.V01;
                    accumulator.ir2 = bonesTransform[puVar10].rotation.V11;
                    accumulator.ir3 = bonesTransform[puVar10].rotation.V21;
                    MVMVA_rotation_accumulator_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator);
                    cTransform.position.y += bonesTransform[puVar6].position.y;
                    iVar7 = accumulator.ir1;
                    iVar8 = accumulator.ir2;
                    iVar9 = accumulator.ir3;
                    cTransform.rotation.V01 = (short)iVar7;
                    cTransform.rotation.V11 = (short)iVar8;
                    cTransform.rotation.V21 = (short)iVar9;
                    accumulator.ir1 = bonesTransform[puVar10].rotation.V02;
                    accumulator.ir2 = bonesTransform[puVar10].rotation.V12;
                    accumulator.ir3 = bonesTransform[puVar10].rotation.V22;
                    MVMVA_rotation_accumulator_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator);
                    cTransform.position.z += bonesTransform[puVar6].position.z;
                    iVar7 = accumulator.ir1;
                    iVar8 = accumulator.ir2;
                    iVar9 = accumulator.ir3;
                    cTransform.rotation.V02 = (short)iVar7;
                    cTransform.rotation.V12 = (short)iVar8;
                    cTransform.rotation.V22 = (short)iVar9;
                }
                else
                {
                    rotationMatrix.rt11 = skinnedTransform.rotation.V00;
                    rotationMatrix.rt12 = skinnedTransform.rotation.V01;
                    rotationMatrix.rt13 = skinnedTransform.rotation.V02;
                    rotationMatrix.rt21 = skinnedTransform.rotation.V10;
                    rotationMatrix.rt22 = skinnedTransform.rotation.V11;
                    rotationMatrix.rt23 = skinnedTransform.rotation.V12;
                    rotationMatrix.rt31 = skinnedTransform.rotation.V20;
                    rotationMatrix.rt32 = skinnedTransform.rotation.V21;
                    rotationMatrix.rt33 = skinnedTransform.rotation.V22;
                    vector0.vx0 = (short)bonesPosition[puVar10].x;
                    vector0.vy0 = (short)bonesPosition[puVar10].y;
                    vector0.vz0 = (short)bonesPosition[puVar10].z;
                    MVMVA_rotation_vector0_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector0);
                    cTransform.position.x = mathsAccumulator.mac1;
                    cTransform.position.y = mathsAccumulator.mac2;
                    cTransform.position.z = mathsAccumulator.mac3;
                    accumulator.ir1 = bonesTransform[puVar10].rotation.V00;
                    accumulator.ir2 = bonesTransform[puVar10].rotation.V10;
                    accumulator.ir3 = bonesTransform[puVar10].rotation.V20;
                    MVMVA_rotation_accumulator_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator);
                    cTransform.position.x += skinnedTransform.position.x;
                    iVar7 = accumulator.ir1;
                    iVar8 = accumulator.ir2;
                    iVar9 = accumulator.ir3;
                    cTransform.rotation.V00 = (short)iVar7;
                    cTransform.rotation.V10 = (short)iVar8;
                    cTransform.rotation.V20 = (short)iVar9;
                    accumulator.ir1 = bonesTransform[puVar10].rotation.V01;
                    accumulator.ir2 = bonesTransform[puVar10].rotation.V11;
                    accumulator.ir3 = bonesTransform[puVar10].rotation.V21;
                    MVMVA_rotation_accumulator_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator);
                    cTransform.position.y += skinnedTransform.position.y;
                    iVar7 = accumulator.ir1;
                    iVar8 = accumulator.ir2;
                    iVar9 = accumulator.ir3;
                    cTransform.rotation.V01 = (short)iVar7;
                    cTransform.rotation.V11 = (short)iVar8;
                    cTransform.rotation.V21 = (short)iVar9;
                    accumulator.ir1 = bonesTransform[puVar10].rotation.V02;
                    accumulator.ir2 = bonesTransform[puVar10].rotation.V12;
                    accumulator.ir3 = bonesTransform[puVar10].rotation.V22;
                    MVMVA_rotation_accumulator_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator);
                    cTransform.position.z += skinnedTransform.position.z;
                    iVar7 = accumulator.ir1;
                    iVar8 = accumulator.ir2;
                    iVar9 = accumulator.ir3;
                    cTransform.rotation.V02 = (short)iVar7;
                    cTransform.rotation.V12 = (short)iVar8;
                    cTransform.rotation.V22 = (short)iVar9;
                }

                bonesTransform[puVar10] = cTransform;
                rotationMatrix.rt11 = cTransform.rotation.V00;
                rotationMatrix.rt12 = cTransform.rotation.V01;
                rotationMatrix.rt13 = cTransform.rotation.V02;
                rotationMatrix.rt21 = cTransform.rotation.V10;
                rotationMatrix.rt22 = cTransform.rotation.V11;
                rotationMatrix.rt23 = cTransform.rotation.V12;
                rotationMatrix.rt31 = cTransform.rotation.V20;
                rotationMatrix.rt32 = cTransform.rotation.V21;
                rotationMatrix.rt33 = cTransform.rotation.V22;
                translationVector._trx = cTransform.position.x;
                translationVector._try = cTransform.position.y;
                translationVector._trz = cTransform.position.z;
                float3 position = new float3(
                   cTransform.position.x / 16f, 
                   cTransform.position.y / -16f, 
                   cTransform.position.z / 16f);
                Quaternion rotation = cTransform.rotation.Matrix2Quaternion;
                float3 euler = rotation.eulerAngles;
                rotation.eulerAngles = new float3(-euler.x, euler.y, -euler.z);
                float3 scale = new float3(1, 1, 1);
                m = new Matrix4x4();
                m.SetTRS(position, rotation, scale);
                iVar19 = bonesIndex[puVar10].DAT_42 - 1;

                if (iVar19 != -1)
                {
                    do
                    {
                        /*vector0.vx0 = (short)puVar15[iVar20].x;
                        vector0.vy0 = (short)puVar15[iVar20].y;
                        vector0.vz0 = (short)puVar15[iVar20].z;
                        vector1.vx1 = (short)puVar15[iVar20 + 1].x;
                        vector1.vy1 = (short)puVar15[iVar20 + 1].y;
                        vector1.vz1 = (short)puVar15[iVar20 + 1].z;
                        vector2.vx2 = (short)puVar15[iVar20 + 2].x;
                        vector2.vy2 = (short)puVar15[iVar20 + 2].y;
                        vector2.vz2 = (short)puVar15[iVar20 + 2].z;
                        ExecuteRTPT(12, false);*/
                        //setting screen coords...
                        float3 v1 = m.MultiplyPoint3x4(vertexData[iVar20]);
                        float3 v2 = m.MultiplyPoint3x4(vertexData[iVar20 + 1]);
                        float3 v3 = m.MultiplyPoint3x4(vertexData[iVar20 + 2]);
                        vector0.vx0 = (short)normalData[iVar20].x;
                        vector0.vy0 = (short)normalData[iVar20].y;
                        vector0.vz0 = (short)normalData[iVar20].z;
                        vector1.vx1 = (short)normalData[iVar20 + 1].x;
                        vector1.vy1 = (short)normalData[iVar20 + 1].y;
                        vector1.vz1 = (short)normalData[iVar20 + 1].z;
                        vector2.vx2 = (short)normalData[iVar20 + 2].x;
                        vector2.vy2 = (short)normalData[iVar20 + 2].y;
                        vector2.vz2 = (short)normalData[iVar20 + 2].z;
                        MVMVA_rotation_vector0_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector0);
                        //modifying screen coords...
                        iVar7 = accumulator.ir1;
                        iVar8 = accumulator.ir2;
                        iVar9 = accumulator.ir3;
                        DAT_1f800380 = new int3(iVar7, iVar8, iVar9);
                        MVMVA_rotation_vector1_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector1);
                        //modifying screen coords...
                        iVar7 = accumulator.ir1;
                        iVar8 = accumulator.ir2;
                        iVar9 = accumulator.ir3;
                        DAT_1f800388 = new int3(iVar7, iVar8, iVar9);
                        MVMVA_rotation_vector2_shift(ref rotationMatrix, ref mathsAccumulator, ref accumulator, ref vector2);
                        //modifying screen coords...
                        iVar7 = accumulator.ir1;
                        iVar8 = accumulator.ir2;
                        iVar9 = accumulator.ir3;
                        DAT_1f800390 = new int3(iVar7, iVar8, iVar9);
                        vector0.vx0 = (short)DAT_1f800380.x;
                        vector0.vy0 = (short)DAT_1f800380.y;
                        vector0.vz0 = (short)DAT_1f800380.z;
                        vector1.vx1 = (short)DAT_1f800388.x;
                        vector1.vy1 = (short)DAT_1f800388.y;
                        vector1.vz1 = (short)DAT_1f800388.z;
                        vector2.vx2 = (short)DAT_1f800390.x;
                        vector2.vy2 = (short)DAT_1f800390.y;
                        vector2.vz2 = (short)DAT_1f800390.z;
                        NCCT_shift_lm(ref mathsAccumulator, ref accumulator, ref lightMatrix, ref lightColorMatrix, ref vector0, ref vector1, ref vector2, ref colorFIFO);
                        //setting color rgb...
                        float4 c1 = new float4(colorFIFO.r0, colorFIFO.g0, colorFIFO.b0, colorFIFO.cd0) / 255;
                        float4 c2 = new float4(colorFIFO.r1, colorFIFO.g1, colorFIFO.b1, colorFIFO.cd1) / 255;
                        float4 c3 = new float4(colorFIFO.r2, colorFIFO.g2, colorFIFO.b2, colorFIFO.cd2) / 255;
                        skinnedData[iVar20] = new MyVertex2(v1, c1);
                        skinnedData[iVar20 + 1] = new MyVertex2(v2, c2);
                        skinnedData[iVar20 + 2] = new MyVertex2(v3, c3);
                        iVar19--;
                        iVar20 += 3;
                    } while (iVar19 != -1);
                }

                puVar10 = bonesIndex[puVar10].next;
                iVar12--;
            } while (iVar12 != -1);
        }

        for (int i = 0; i < triCount; i++)
        {
            int tri = i * 3;
            vertexBuffer[tri] = new MyVertex(skinnedData[indexData[tri]].vertex, skinnedData[indexData[tri]].color, vertexBuffer[tri].uv, vertexBuffer[tri].uv2);
            vertexBuffer[tri + 1] = new MyVertex(skinnedData[indexData[tri + 1]].vertex, skinnedData[indexData[tri + 1]].color, vertexBuffer[tri + 1].uv, vertexBuffer[tri + 1].uv2);
            vertexBuffer[tri + 2] = new MyVertex(skinnedData[indexData[tri + 2]].vertex, skinnedData[indexData[tri + 2]].color, vertexBuffer[tri + 2].uv, vertexBuffer[tri + 2].uv2);
        }

        for (int i = 0, j = triCount; i < quadCount; i++)
        {
            int quad = j * 3 + i * 6;
            vertexBuffer[quad] = new MyVertex(skinnedData[indexData[quad]].vertex, skinnedData[indexData[quad]].color, vertexBuffer[quad].uv, vertexBuffer[quad].uv2);
            vertexBuffer[quad + 1] = new MyVertex(skinnedData[indexData[quad + 1]].vertex, skinnedData[indexData[quad + 1]].color, vertexBuffer[quad + 1].uv, vertexBuffer[quad + 1].uv2);
            vertexBuffer[quad + 2] = new MyVertex(skinnedData[indexData[quad + 2]].vertex, skinnedData[indexData[quad + 2]].color, vertexBuffer[quad + 2].uv, vertexBuffer[quad + 2].uv2);
            vertexBuffer[quad + 3] = new MyVertex(skinnedData[indexData[quad + 3]].vertex, skinnedData[indexData[quad + 3]].color, vertexBuffer[quad + 3].uv, vertexBuffer[quad + 3].uv2);
            vertexBuffer[quad + 4] = new MyVertex(skinnedData[indexData[quad + 4]].vertex, skinnedData[indexData[quad + 4]].color, vertexBuffer[quad + 4].uv, vertexBuffer[quad + 4].uv2);
            vertexBuffer[quad + 5] = new MyVertex(skinnedData[indexData[quad + 5]].vertex, skinnedData[indexData[quad + 5]].color, vertexBuffer[quad + 5].uv, vertexBuffer[quad + 5].uv2);
        }
    }

    void MVMVA_rotation_accumulator_shift(ref Cop2RT rotationMatrix, ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator)
    {
        short Vx = 0;
        short Vy = 0;
        short Vz = 0;

        Vx = accumulator.ir1;
        Vy = accumulator.ir2;
        Vz = accumulator.ir3;

        MultMatVec_RT(ref mathsAccumulator, ref accumulator, ref rotationMatrix, Vx, Vy, Vz, 12, false);
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

    void NCCT_shift_lm(ref Cop2Maths mathsAccumulator, ref Cop2Accumulator accumulator, ref Cop2LLM lightMatrix, ref Cop2LCM lightColorMatrix, ref Cop2Vector0 vector0, ref Cop2Vector1 vector1, ref Cop2Vector2 vector2, ref Cop2ClrFIFO colorFIFO)
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

[BurstCompile]
struct ShadowMeshJob : IJob
{
    [WriteOnly] public NativeArray<MyVertex> vertexBuffer;
    public int length;
    public int3 DAT_1f80006c;
    public int3 DAT_1f800074;
    public int3 DAT_1f80007c;
    public int3 DAT_1f800084;
    public int4 DAT_1f800068;
    public ushort DAT_1f80007a;
    public ushort DAT_1f800072;
    public byte DAT_1f800070;
    public byte DAT_1f800071;
    public byte DAT_1f800078;
    public byte DAT_1f800079;
    public byte DAT_1f800080;
    public byte DAT_1f800081;
    public byte DAT_1f800088;
    public byte DAT_1f800089;

    public void Execute()
    {
        float translateFactor = 16f;
        int v = length - 4;
        float3 v1 = new float3(DAT_1f80006c.x, -DAT_1f80006c.y, DAT_1f80006c.z) / translateFactor;
        float3 v2 = new float3(DAT_1f800074.x, -DAT_1f800074.y, DAT_1f800074.z) / translateFactor;
        float3 v3 = new float3(DAT_1f80007c.x, -DAT_1f80007c.y, DAT_1f80007c.z) / translateFactor;
        float3 v4 = new float3(DAT_1f800084.x, -DAT_1f800084.y, DAT_1f800084.z) / translateFactor;
        float4 c1 = new float4(DAT_1f800068.x, DAT_1f800068.y, DAT_1f800068.z, 255) / 255;
        float4 c2 = new float4(DAT_1f800068.x, DAT_1f800068.y, DAT_1f800068.z, 255) / 255;
        float4 c3 = new float4(DAT_1f800068.x, DAT_1f800068.y, DAT_1f800068.z, 255) / 255;
        float4 c4 = new float4(DAT_1f800068.x, DAT_1f800068.y, DAT_1f800068.z, 255) / 255;
        ushort texpage = DAT_1f80007a;
        ushort palette = DAT_1f800072;
        bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
        int clutX = (palette & 0x3f) * 16;
        int clutY = palette >> 6;
        float3 p = new float3((float)(clutX - 0x300) / 0x100, (float)(clutY - 0x1f6) / 2, lowColors ? 0f : 1f);
        int f = lowColors ? 4 : 2;
        int d = lowColors ? 1 : 1;
        int pageX = (texpage & 0xf) * 64 * f;
        int pageY = (texpage >> 4 & 1) * 256;
        float width = lowColors ? 0x200 : 0x100;
        float height = 0x1d0;
        int vramX = 0x380 * f;
        int vramY = 0;
        float2 uv1 = new float2(DAT_1f800070, DAT_1f800071);
        float2 uv2 = new float2(DAT_1f800078, DAT_1f800079);
        float2 uv3 = new float2(DAT_1f800080, DAT_1f800081);
        float2 uv4 = new float2(DAT_1f800088, DAT_1f800089);
        uv1.x = pageX + (uv1.x / d) - vramX;
        uv1.y = pageY + uv1.y - vramY;
        uv1 = new float2(uv1.x / width, 1f - uv1.y / height);
        uv2.x = pageX + (uv2.x / d) - vramX;
        uv2.y = pageY + uv2.y - vramY;
        uv2 = new float2(uv2.x / width, 1f - uv2.y / height);
        uv3.x = pageX + (uv3.x / d) - vramX;
        uv3.y = pageY + uv3.y - vramY;
        uv3 = new float2(uv3.x / width, 1f - uv3.y / height);
        uv4.x = pageX + (uv4.x / d) - vramX;
        uv4.y = pageY + uv4.y - vramY;
        uv4 = new float2(uv4.x / width, 1f - uv4.y / height);
        vertexBuffer[v] = new MyVertex(v1, c1, uv1, p);
        vertexBuffer[v + 1] = new MyVertex(v2, c2, uv2, p);
        vertexBuffer[v + 2] = new MyVertex(v3, c3, uv3, p);
        vertexBuffer[v + 3] = new MyVertex(v4, c4, uv4, p);
    }
}