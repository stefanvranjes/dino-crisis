using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//writable class (needs instantiating upon start)
public class TriggerScriptableObject : ScriptableObject
{
    public string prefabName;

    public Vector2Int[] DAT_00; //0x00
    public byte DAT_10; //0x10
    public byte DAT_11; //0x11
    public byte DAT_12; //0x12
    public bool DAT_13; //0x13 - writable
    public byte DAT_18; //0x18
    public byte DAT_19; //0x19
    public byte DAT_1A; //0x1A - writable
    public byte DAT_1B; //0x1B - writable
    public ushort DAT_1C; //0x1C
    public byte DAT_1E; //0x1E
    public byte DAT_1F; //0x1F
    public TmdScriptableObject DAT_20; //0x20
    public byte DAT_23; //0x23
    public byte BDAT_24; //0x24
    public int IDAT_24; //0x24
    public byte DAT_28; //0x28
    public byte DAT_29; //0x29

    public void FUN_57488(int param1)
    {
        bool bVar1;
        CriStatic oVar1;
        TriggerScriptableObject tVar2;
        Vector3Int local_18;

        if (DAT_1C == 0)
        {
            local_18 = new Vector3Int();
            local_18.y = 0;
            local_18.x = DAT_00[2].x + ((DAT_00[0].x - DAT_00[2].x) / 2);
            local_18.z = DAT_00[2].y + ((DAT_00[0].y - DAT_00[2].y) / 2);

            if (DAT_1E != 0xff)
            {
                oVar1 = SceneManager.instance.DAT_7CDC[DAT_1E];
                FUN_1A638(oVar1, local_18);

                if (IDAT_24 != 0)
                {
                    oVar1.DAT_2F = 1;
                    oVar1.flags &= 0xfffffffd;
                }
            }
        }
        else
        {
            if ((ushort)(DAT_18 | DAT_19 << 8) == 0xff)
            {
                //...
                tVar2 = SceneManager.instance.triggers[param1]; //tmp
            }
            else
            {
                bVar1 = InventoryManager.FUN_4A87C(7, DAT_1C);

                if (!bVar1)
                {
                    local_18 = new Vector3Int();
                    local_18.y = 0;
                    local_18.x = DAT_00[2].x + ((DAT_00[0].x - DAT_00[2].x) / 2);
                    local_18.z = DAT_00[2].y + ((DAT_00[0].y - DAT_00[2].y) / 2);

                    if (DAT_1E != 0xff)
                    {
                        oVar1 = SceneManager.instance.DAT_7CDC[DAT_1E];
                        FUN_1A638(oVar1, local_18);

                        if (IDAT_24 != 0)
                        {
                            oVar1.DAT_2F = 1;
                            oVar1.flags &= 0xfffffffd;
                        }
                    }

                    return;
                }

                tVar2 = SceneManager.instance.triggers[param1];
            }

            tVar2.DAT_13 = false;
        }
    }

    public void FUN_1A638(CriStatic param1, Vector3Int param2)
    {
        param1.flags = 3;
        param1.DAT_2E = 2;
        param1.DAT_48 = 1;
        param1.DAT_4A = 0;
        param1.DAT_2F = 0;
        param1.tags = 0;
        param1.cMesh = DAT_20;
        param1.screen = param2;
        param1.vr.x = 0;
        param1.vr.y = 0;

        if ((ushort)(DAT_18 | DAT_19 << 8) < 11)
            param1.vr.z = 0xc00;
        else
            param1.vr.z = 0;

        param1.cCollider = null;
    }
}
