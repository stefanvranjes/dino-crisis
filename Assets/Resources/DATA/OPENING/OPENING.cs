using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPENING : MonoBehaviour
{
    public RamScriptableObject ram;
    public GianScriptableObject[] gians;
    public IniScriptableObject[] inis;

    // Start is called before the first frame update
    void Start()
    {
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

        GameManager.instance.gameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
