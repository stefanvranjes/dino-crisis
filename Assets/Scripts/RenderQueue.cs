using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.Collections;

public class RenderQueue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
