using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriTrigger : MonoBehaviour
{
    public byte DAT_01; //0x00
    public Vector3Int DAT_04; //0x04
    public short DAT_0A; //0x0A
    public short DAT_0C; //0x0C
    public short DAT_0E; //0x0E
    public short DAT_10; //0x10
    public short DAT_12; //0x12
    public byte DAT_14; //0x14
    public ushort DAT_16; //0x16

    public void ResetValues()
    {
        DAT_01 = 0;
        DAT_04 = Vector3Int.zero;
        DAT_0A = 0;
        DAT_0C = 0;
        DAT_0E = 0;
        DAT_10 = 0;
        DAT_12 = 0;
        DAT_14 = 0;
        DAT_16 = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
