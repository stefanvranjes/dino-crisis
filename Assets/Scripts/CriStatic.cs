using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriStatic : CriObject
{
    public byte DAT_48; //0x48
    public ushort DAT_4A; //0x4A

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
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_48 = 0;
        DAT_4A = 0;
    }

    private void OnRenderObject()
    {
        if (cMesh != null)
        {
            GL.PushMatrix();
            GL.MultMatrix(transform.localToWorldMatrix);

            for (int i = 0; i < cMesh.TRI_COUNT; i++)
            {
                materials[commandList[i]].SetPass(0);
                GL.Begin(GL.TRIANGLES);
                int j = i * 3;

                for (int k = 0; k < 3; k++)
                {
                    //if (uv2List[i].z == 1)
                    //{
                    if (!GameManager.instance.disableColors)
                        GL.Color(colorList[triangleList[j + k]]);
                    GL.MultiTexCoord(0, uvList[triangleList[j + k]]);
                    GL.MultiTexCoord(1, uv2List[i]);
                    GL.Vertex(vertexList[triangleList[j + k]]);
                    //}
                }

                GL.End();
            }

            for (int i = 0; i < cMesh.QUAD_COUNT; i++)
            {
                materials[commandList[cMesh.TRI_COUNT + i]].SetPass(0);
                GL.Begin(GL.TRIANGLES);
                int j = cMesh.TRI_COUNT * 3 + i * 6;

                for (int k = 0; k < 6; k++)
                {
                    //if (uv2List[cMesh.TRI_COUNT + i].z == 1)
                    //{
                    if (!GameManager.instance.disableColors)
                        GL.Color(colorList[triangleList[j + k]]);
                    GL.MultiTexCoord(0, uvList[triangleList[j + k]]);
                    GL.MultiTexCoord(1, uv2List[cMesh.TRI_COUNT + i]);
                    GL.Vertex(vertexList[triangleList[j + k]]);
                    //}
                }

                GL.End();
            }

            GL.PopMatrix();
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
        uVar12 = GameManager.instance.DAT_1f80002a;
        uVar11 = GameManager.instance.DAT_1f800028;

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

        GameManager.instance.DAT_1f800028 = (ushort)uVar11;
        GameManager.instance.DAT_1f80002a = (ushort)uVar12;
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
        uVar7 = GameManager.instance.DAT_1f800024;
        uVar8 = GameManager.instance.DAT_1f800026;
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

        GameManager.instance.DAT_1f800024 = (ushort)uVar7;
        GameManager.instance.DAT_1f800026 = (ushort)uVar8;
    }
}
