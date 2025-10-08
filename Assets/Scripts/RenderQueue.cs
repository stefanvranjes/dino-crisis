using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.Collections;

public class RenderQueue : MonoBehaviour
{
    private List<byte> commandList;
    private List<Material> materialList;
    private List<Transform> matrixList;
    private List<Vector3> vertexList;
    private List<Vector2> uvList;
    private List<Vector3> uv2List;
    private List<Color> colorList;

    // Start is called before the first frame update
    void Start()
    {
        commandList = new List<byte>();
        materialList = new List<Material>();
        matrixList = new List<Transform>();
        vertexList = new List<Vector3>();
        uvList = new List<Vector2>();
        uv2List = new List<Vector3>();
        colorList = new List<Color>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < SceneManager.instance.skinnedObjects.Length; i++)
        {
            SceneManager.instance.skinnedObjects[i].Draw();
        }

        for (int i = 0; i < SceneManager.instance.staticObjects.Length; i++)
        {
            SceneManager.instance.staticObjects[i].Draw();
        }
    }

    private void OnRenderObject()
    {
        GL.PushMatrix();
        
        for (int i = 0; i < commandList.Count; i++)
        {
            GL.MultMatrix(matrixList[i].localToWorldMatrix);
            materialList[i].SetPass(0);
            GL.Begin(GL.TRIANGLES);
            int j = i * 3;

            for (int k = 0; k < 3; k++)
            {
                if (!GameManager.instance.disableColors && (commandList[i] & 0x10) != 0)
                    GL.Color(colorList[j + k]);
                GL.MultiTexCoord(0, uvList[j + k]);
                GL.MultiTexCoord(1, uv2List[j + k]);
                GL.Vertex(vertexList[j + k]);
            }

            GL.End();
        }

        GL.PopMatrix();
        matrixList.Clear();
        materialList.Clear();
        commandList.Clear();
        colorList.Clear();
        uvList.Clear();
        uv2List.Clear();
        vertexList.Clear();
    }

    public static void AddMaterial(Material mat)
    {
        SceneManager.instance.renderQueue.materialList.Add(mat);
    }

    public static void AddMaterialLast(Material mat)
    {
        SceneManager.instance.renderQueue.materialList.Insert(0, mat);
    }

    public static void AddMatrix(Transform t)
    {
        SceneManager.instance.renderQueue.matrixList.Add(t);
    }

    public static void AddMatrixLast(Transform t)
    {
        SceneManager.instance.renderQueue.matrixList.Insert(0, t);
    }

    public static void AddCommand(byte cmd)
    {
        SceneManager.instance.renderQueue.commandList.Add(cmd);
    }

    public static void AddCommandLast(byte cmd)
    {
        SceneManager.instance.renderQueue.commandList.Insert(0, cmd);
    }

    public static void AddColor(Color clr)
    {
        SceneManager.instance.renderQueue.colorList.Add(clr);
    }

    public static void AddColorLast(Color clr)
    {
        SceneManager.instance.renderQueue.colorList.Insert(0, clr);
    }

    public static void AddUV(Vector2 uv)
    {
        SceneManager.instance.renderQueue.uvList.Add(uv);
    }

    public static void AddUVLast(Vector2 uv)
    {
        SceneManager.instance.renderQueue.uvList.Insert(0, uv);
    }

    public static void AddUV2(Vector3 uv2)
    {
        SceneManager.instance.renderQueue.uv2List.Add(uv2);
    }

    public static void AddUV2Last(Vector3 uv2)
    {
        SceneManager.instance.renderQueue.uv2List.Insert(0, uv2);
    }

    public static void AddVertex(Vector3 v3)
    {
        SceneManager.instance.renderQueue.vertexList.Add(v3);
    }

    public static void AddVertexLast(Vector3 v3)
    {
        SceneManager.instance.renderQueue.vertexList.Insert(0, v3);
    }
}
