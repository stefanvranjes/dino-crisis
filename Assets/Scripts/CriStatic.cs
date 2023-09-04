using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BoxCollider
{
    public string prefabName;

    public Vector3Int DAT_00; //0x00
    public short DAT_06; //0x06
}

public class CriStatic : CriObject
{
    public Vector3Int DAT_34; //0x34
    public TmdScriptableObject cMesh; //0x3C
    public CriObject DAT_40; //0x40
    public BoxCollider cCollider; //0x44
    public byte DAT_48; //0x48
    public ushort DAT_4A; //0x4A
    public Vector3Int DAT_4C; //0x4C
    public uint DAT_74;
    public byte DAT_78;
    public ushort DAT_7A;
    public byte DAT_7C;
    public byte DAT_7D;
    public sbyte DAT_7E;
    public Vector3Int DAT_80;
    private delegate void FUN_AA430();
    private delegate void FUN_AA438();
    private delegate void FUN_7B20(); //FUN_7B20 (ST1)
    private FUN_AA430[] PTR_FUN_AA430;
    private FUN_AA438[] PTR_FUN_AA438;
    private FUN_7B20[] PTR_FUN_7B20; //PTR_FUN_7B20 (ST1)

    private List<byte> commandList;
    private List<Vector3> vertexList;
    private List<Vector2> uvList;
    private List<Vector3> uv2List;
    private List<Color> colorList;
    private List<int> triangleList;
    public Material[] materials;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_AA430 = new FUN_AA430[2]
        {
            FUN_7F734,
            FUN_7F748
        };
        PTR_FUN_AA438 = new FUN_AA438[5]
        {
            FUN_7F844,
            FUN_7F928,
            FUN_7FAE0,
            FUN_7FB4C,
            FUN_5FF00
        };
        PTR_FUN_7B20 = new FUN_7B20[2]
        {
            FUN_6CB0,
            FUN_6CF4,
        };
    }

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
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_34 = Vector3Int.zero;
        cMesh = null;
        DAT_40 = null;
        cCollider = null;
        DAT_48 = 0;
        DAT_4A = 0;
        DAT_74 = 0;
        DAT_78 = 0;
        DAT_7A = 0;
        DAT_7C = 0;
        DAT_7D = 0;
        DAT_7E = 0;
        DAT_80 = Vector3Int.zero;
    }

    private void OnRenderObject()
    {
        if (cMesh != null && (flags & 3) == 3)
        {
            GL.PushMatrix();
            GL.MultMatrix(transform.localToWorldMatrix);

            for (int i = cMesh.TRI_COUNT - 1; i >= 0; i--)
            {
                if ((commandList[i] & 0xef) > 0)
                {
                    RenderQueue.AddMatrix(transform);
                    RenderQueue.AddCommand(commandList[i]);
                    RenderQueue.AddMaterial(materials[commandList[i] & 0xef]);
                    int j = i * 3;

                    for (int k = 0; k < 3; k++)
                    {
                        RenderQueue.AddColor(colorList[triangleList[j + k]]);
                        RenderQueue.AddUV(uvList[triangleList[j + k]]);
                        RenderQueue.AddUV2(uv2List[i]);
                        RenderQueue.AddVertex(vertexList[triangleList[j + k]]);
                    }
                }
                else
                {
                    materials[0].SetPass(0);
                    GL.Begin(GL.TRIANGLES);
                    int j = i * 3;

                    for (int k = 0; k < 3; k++)
                    {
                        if (!GameManager.instance.disableColors && (commandList[i] & 0x10) != 0)
                            GL.Color(colorList[triangleList[j + k]]);
                        GL.MultiTexCoord(0, uvList[triangleList[j + k]]);
                        GL.MultiTexCoord(1, uv2List[i]);
                        GL.Vertex(vertexList[triangleList[j + k]]);
                    }

                    GL.End();
                }
            }

            for (int i = cMesh.QUAD_COUNT - 1; i >= 0; i--)
            {
                if ((commandList[cMesh.TRI_COUNT + i] & 0xef) > 0)
                {
                    RenderQueue.AddMatrix(transform);
                    RenderQueue.AddCommand(commandList[cMesh.TRI_COUNT + i]);
                    RenderQueue.AddMaterial(materials[commandList[cMesh.TRI_COUNT + i] & 0xef]);
                    RenderQueue.AddMatrix(transform);
                    RenderQueue.AddCommand(commandList[cMesh.TRI_COUNT + i]);
                    RenderQueue.AddMaterial(materials[commandList[cMesh.TRI_COUNT + i] & 0xef]);
                    int j = cMesh.TRI_COUNT * 3 + i * 6;

                    for (int k = 0; k < 6; k++)
                    {
                        RenderQueue.AddColor(colorList[triangleList[j + k]]);
                        RenderQueue.AddUV(uvList[triangleList[j + k]]);
                        RenderQueue.AddUV2(uv2List[cMesh.TRI_COUNT + i]);
                        RenderQueue.AddVertex(vertexList[triangleList[j + k]]);
                    }
                }
                else
                {
                    materials[0].SetPass(0);
                    GL.Begin(GL.TRIANGLES);
                    int j = cMesh.TRI_COUNT * 3 + i * 6;

                    for (int k = 0; k < 6; k++)
                    {
                        if (!GameManager.instance.disableColors && (commandList[cMesh.TRI_COUNT + i] & 0x10) != 0)
                            GL.Color(colorList[triangleList[j + k]]);
                        GL.MultiTexCoord(0, uvList[triangleList[j + k]]);
                        GL.MultiTexCoord(1, uv2List[cMesh.TRI_COUNT + i]);
                        GL.Vertex(vertexList[triangleList[j + k]]);
                    }

                    GL.End();
                }
            }

            GL.PopMatrix();
        }
    }

    public void SetMaterials()
    {
        materials = new Material[16];
        TmdScriptableObject tmd = cMesh;

        if (tmd != null)
        {
            Material mat1 = new Material(GameManager.instance.materials[0]);
            Material mat2 = new Material(GameManager.instance.materials[1]);
            Material mat3 = new Material(GameManager.instance.materials[2]);
            Material mat4 = new Material(GameManager.instance.materials[3]);
            mat1.mainTexture = tmd.TEX_2D;
            mat1.SetTexture("_Tex8", tmd.TEX8_2D);
            mat1.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[0] = mat1;
            mat2.mainTexture = tmd.TEX_2D;
            mat2.SetTexture("_Tex8", tmd.TEX8_2D);
            mat2.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[1] = mat2;
            mat3.mainTexture = tmd.TEX_2D;
            mat3.SetTexture("_Tex8", tmd.TEX8_2D);
            mat3.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[2] = mat3;
            mat4.mainTexture = tmd.TEX_2D;
            mat4.SetTexture("_Tex8", tmd.TEX8_2D);
            mat4.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[3] = mat4;
        }
    }

    public void FUN_75F10(TmdScriptableObject param1, int param2)
    {
        uint uVar11;
        uint uVar12;

        int begin = param1.TRI_COUNT;
        int cmd = begin;
        int vert = begin * 3;
        int uv = begin * 3;
        int uv2 = begin;
        int clr = begin * 3;
        int tri = 0;
        uVar12 = GameManager.DAT_1f80002a;
        uVar11 = GameManager.DAT_1f800028;

        while (true)
        {
            param2--;
            uVar12++;

            if (param2 < 0) break;

            commandList.Add(param1.CMDS[cmd]);
            vertexList.Add(param1.VERTS[vert]);
            vertexList.Add(param1.VERTS[vert + 1]);
            vertexList.Add(param1.VERTS[vert + 2]);
            vertexList.Add(param1.VERTS[vert + 3]);
            uvList.Add(param1.UVS[uv]);
            uvList.Add(param1.UVS[uv + 1]);
            uvList.Add(param1.UVS[uv + 2]);
            uvList.Add(param1.UVS[uv + 3]);
            uv2List.Add(param1.UVS2[uv2]);
            colorList.Add(param1.CLRS[clr]);
            colorList.Add(param1.CLRS[clr + 1]);
            colorList.Add(param1.CLRS[clr + 2]);
            colorList.Add(param1.CLRS[clr + 3]);
            triangleList.Add(param1.QUADS[tri]);
            triangleList.Add(param1.QUADS[tri + 1]);
            triangleList.Add(param1.QUADS[tri + 2]);
            triangleList.Add(param1.QUADS[tri + 3]);
            triangleList.Add(param1.QUADS[tri + 4]);
            triangleList.Add(param1.QUADS[tri + 5]);

            cmd++;
            vert += 4;
            uv += 4;
            uv2++;
            clr += 4;
            tri += 6;
            uVar11++;
        }

        GameManager.DAT_1f800028 = (ushort)uVar11;
        GameManager.DAT_1f80002a = (ushort)uVar12;
    }

    public void FUN_75BEC(TmdScriptableObject param1, int param2)
    {
        uint uVar7;
        uint uVar8;

        int cmd = 0;
        int vert = 0;
        int uv = 0;
        int uv2 = 0;
        int clr = 0;
        int tri = 0;
        uVar7 = GameManager.DAT_1f800024;
        uVar8 = GameManager.DAT_1f800026;
        commandList.Clear();
        vertexList.Clear();
        uvList.Clear();
        uv2List.Clear();
        colorList.Clear();
        triangleList.Clear();

        while (true)
        {
            param2--;
            uVar8++;

            if (param2 < 0) break;

            commandList.Add(param1.CMDS[cmd]);
            vertexList.Add(param1.VERTS[vert]);
            vertexList.Add(param1.VERTS[vert + 1]);
            vertexList.Add(param1.VERTS[vert + 2]);
            uvList.Add(param1.UVS[uv]);
            uvList.Add(param1.UVS[uv + 1]);
            uvList.Add(param1.UVS[uv + 2]);
            uv2List.Add(param1.UVS2[uv2]);
            colorList.Add(param1.CLRS[clr]);
            colorList.Add(param1.CLRS[clr + 1]);
            colorList.Add(param1.CLRS[clr + 2]);
            triangleList.Add(param1.TRIS[tri]);
            triangleList.Add(param1.TRIS[tri + 1]);
            triangleList.Add(param1.TRIS[tri + 2]);

            cmd++;
            vert += 3;
            uv += 3;
            uv2++;
            clr += 3;
            tri += 3;
            uVar7++;
        }

        GameManager.DAT_1f800024 = (ushort)uVar7;
        GameManager.DAT_1f800026 = (ushort)uVar8;
    }

    public void FUN_7F6F8()
    {
        PTR_FUN_AA430[tags]();
    }

    private void FUN_7F734()
    {
        uint uVar1;

        DAT_74 &= 0xffffff00;
        tags++;
    }

    private void FUN_7F748()
    {
        return;
    }

    public void FUN_7F750()
    {
        bool bVar1;

        if (DAT_2F != 0)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 0x1b);

            if (bVar1)
            {
                InventoryManager.FUN_4A7E8(2, 0x1b, false);
                flags |= 2;
            }
        }

        bVar1 = InventoryManager.FUN_4A87C(2, 2);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 3);

            if (!bVar1)
                vr.y = vr.y + 0x40 & 0xfff;
        }
    }

    public void FUN_7F7E4()
    {
        if (tags == 0)
        {
            tags++;
            //DAT_74 = DAT_44; ???
        }
    }

    public void FUN_7F808()
    {
        PTR_FUN_AA438[tags]();
    }

    private void FUN_7F844()
    {
        sbyte sVar1;
        uint uVar2;
        CriSkinned oVar3;

        cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80180178);
        cCollider = null;
        flags |= 2;
        DAT_7A = 0x14;
        tags = 1;
        oVar3 = SceneManager.instance.DAT_27C[10];
        uVar2 = SceneManager.instance.FUN_83534(ref screen, oVar3.screen);

        if ((uVar2 & 0xff) == 8)
        {
            oVar3 = SceneManager.instance.DAT_27C[(uVar2 & 0xffff) >> 8];
            oVar3.DAT_11E |= 0x80;
            oVar3.DAT_1A0 = DAT_7C;
            oVar3.DAT_1A1 = DAT_7D;
            sVar1 = 4;
        }
        else
        {
            if ((uVar2 & 0xff) == 0)
                return;

            DAT_7A = 4;
            sVar1 = 2;
        }

        tags = sVar1;
    }

    private void FUN_7F928()
    {
        sbyte sVar1;
        short sVar2;
        uint uVar3;
        CriSkinned oVar4;
        CriObject oVar5;
        Vector3Int local_50;
        Vector3Int local_48;
        Matrix3x3 MStack64;

        local_50 = screen;

        if (DAT_7E != -1)
        {
            oVar4 = SceneManager.instance.DAT_27C[DAT_7E];
            oVar5 = Utilities.FUN_601C8(oVar4.skeleton, oVar4.DAT_175 & 15);
            sVar2 = Utilities.FUN_51C8C(screen, oVar5.screen, DAT_80.y, 0x10);
            DAT_80.y += sVar2;
        }

        MStack64 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref DAT_80, ref MStack64);
        local_48 = new Vector3Int(0, 0, 800);
        local_48 = Utilities.ApplyMatrixSV(ref MStack64, ref local_48);
        screen.x += local_48.x;
        screen.y += local_48.y;
        screen.z += local_48.z;
        uVar3 = SceneManager.instance.FUN_83534(ref screen, local_50);

        if ((uVar3 & 0xff) == 8)
        {
            oVar4 = SceneManager.instance.DAT_27C[(uVar3 & 0xffff) >> 8];
            oVar4.DAT_11E |= 0x80;
            oVar4.DAT_1A0 = DAT_7C;
            oVar4.DAT_1A1 = DAT_7D;
        }
        else
        {
            if ((uVar3 & 0xff) != 0)
            {
                DAT_7A = 4;
                sVar1 = 2;
                goto LAB_7FAC4;
            }

            sVar2 = (short)(DAT_7A - 1);
            DAT_7A = (ushort)sVar2;

            if (sVar2 != 0)
                return;
        }

        sVar1 = 4;
        LAB_7FAC4:
        tags = sVar1;
    }

    private void FUN_7FAE0()
    {
        short sVar1;

        if ((DAT_7A & 1) == 0)
            sVar1 = (short)(vr.x - 0x100);
        else
            sVar1 = (short)(vr.x + 0x100);

        vr.x = sVar1;
        sVar1 = (short)(DAT_7A - 1);
        DAT_7A = (ushort)sVar1;

        if (sVar1 == 0)
        {
            DAT_7A = 0x1a;
            tags++;
        }
    }

    private void FUN_7FB4C()
    {
        short sVar1;

        sVar1 = (short)(DAT_7A - 1);
        DAT_7A = (ushort)sVar1;

        if (sVar1 == 0)
            tags = 4;
    }

    public void FUN_4A26C()
    {
        return;
    }

    //FUN_6C74 (ST1)
    public void FUN_6C74()
    {
        PTR_FUN_7B20[tags]();
    }

    //FUN_6CB0 (ST1)
    private void FUN_6CB0()
    {
        tags++;
        DAT_4C = new Vector3Int(0, 0, 0);
        //FUN_6D14
    }

    private void FUN_6CF4()
    {
        //FUN_6ED4
    }

    //FUN_6D14 (ST1)
    private void FUN_6D14()
    {

    }

    //FUN_6ED4 (ST1)
    private void FUN_6ED4()
    {

    }
}
