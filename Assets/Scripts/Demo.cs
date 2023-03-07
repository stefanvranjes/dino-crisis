using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    public int room;
    public Dropdown roomDropdown;
    public RamScriptableObject ram;
    public GianScriptableObject[] gians;
    public IniScriptableObject[] inis;

    public void SetRoom()
    {
        room = roomDropdown.value + 1;
    }

    public void LoadScene()
    {
        SetRoom();
        UnityEngine.SceneManagement.SceneManager.LoadScene(room, LoadSceneMode.Single);
    }

    public void GameStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(GameManager.instance.gameObject);
        DontDestroyOnLoad(GameObject.Find("EventSystem"));

        for (int i = 0; i < gians.Length; i++)
            GameManager.PTR_DAT_9E708[gians[i].INDEX] = gians[i];

        for (int i = 0; i < inis.Length; i++)
        {
            int j = (int)(inis[i].ADDR - 0x801fe900) / 4;

            for (int k = 0; k < inis[i].DATA.Length; k++)
                GameManager.DAT_1FE900[j + k] = inis[i].DATA[k];
        }

        foreach (KeyValuePair<uint, UnityEngine.Object> t in ram.objects)
        {
            if (!GameManager.globalRam.objects.ContainsKey(t.Key))
                GameManager.globalRam.objects.Add(t.Key, t.Value);
            else
                GameManager.globalRam.objects[t.Key] = t.Value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
