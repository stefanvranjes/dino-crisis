using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    public int room;
    public Dropdown roomDropdown;

    public void SetRoom()
    {
        room = roomDropdown.value + 1;
    }

    public void LoadScene()
    {
        SetRoom();
        UnityEngine.SceneManagement.SceneManager.LoadScene(room, LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
