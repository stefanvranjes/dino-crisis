using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.Collections;

public class RenderQueue : MonoBehaviour
{
    public static Camera camera2; //transparent
    public static Camera camera3; //shadows
    public static Camera camera4; //ignore

    void Awake()
    {
        camera3 = GameObject.Find("Camera3").GetComponent<Camera>();
        camera2 = GameObject.Find("Camera2").GetComponent<Camera>();
        camera4 = GameObject.Find("Camera4").GetComponent<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public static Camera GetCamera(int index)
    {
        switch (index)
        {
            default:
                return Camera.main;
            case 1:
                return camera2;
            case 2:
                return camera3;
            case 3:
                return camera4;
        }
    }
}
