using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller
{
    public ushort DAT_B1418;
    public ushort DAT_B141A;
    public ushort DAT_B141C;
    public ushort DAT_B5898;
    public ushort DAT_B58B8;
    public ushort DAT_C2550;
    public ushort DAT_C2552;
    public ushort DAT_C2554;
    public ushort DAT_C2556;
    public short DAT_C2558;
    public short DAT_C255a;
}

public struct PSXInput
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public byte DAT_02; //0x02
    public byte DAT_03; //0x03
    public byte DAT_04; //0x04
    public byte DAT_05; //0x05
    public byte DAT_06; //0x06
    public byte DAT_07; //0x07
}

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public static Controller[] controllers;
    public static PSXInput[,] inputs;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        controllers = new Controller[2];
        inputs = new PSXInput[2, 9];

        for (int i = 0; i < 2; i++)
            controllers[i] = new Controller();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 1; i++)
        {
            string player = "P" + (i + 1) + "_";
            inputs[i, 0].DAT_00 = 0;
            inputs[i, 0].DAT_01 = 115;
            inputs[i, 0].DAT_02 = 0xff;
            inputs[i, 0].DAT_03 = 0xff;
            inputs[i, 0].DAT_04 = 0x80;
            inputs[i, 0].DAT_05 = 0x80;
            inputs[i, 0].DAT_06 = 0x80;
            inputs[i, 0].DAT_07 = 0x80;

            if (Input.GetButton(player + "CROSS"))
                inputs[i, 0].DAT_03 &= 0xbf;

            if (Input.GetButton(player + "CIRCLE"))
                inputs[i, 0].DAT_03 &= 0xdf;

            if (Input.GetButton(player + "SQUARE"))
                inputs[i, 0].DAT_03 &= 0x7f;

            if (Input.GetButton(player + "TRIANGLE"))
                inputs[i, 0].DAT_03 &= 0xef;

            if (Input.GetButton(player + "R1"))
                inputs[i, 0].DAT_03 &= 0xf7;

            if (Input.GetButton(player + "L1"))
                inputs[i, 0].DAT_03 &= 0xfb;

            if (Input.GetButton(player + "R2"))
                inputs[i, 0].DAT_03 &= 0xfd;

            if (Input.GetButton(player + "L2"))
                inputs[i, 0].DAT_03 &= 0xfe;

            if (Input.GetButton(player + "UP"))
                inputs[i, 0].DAT_02 &= 0xef;

            if (Input.GetButton(player + "DOWN"))
                inputs[i, 0].DAT_02 &= 0xbf;

            if (Input.GetButton(player + "RIGHT"))
                inputs[i, 0].DAT_02 &= 0xdf;

            if (Input.GetButton(player + "LEFT"))
                inputs[i, 0].DAT_02 &= 0x7f;

            if (Input.GetButton(player + "START"))
                inputs[i, 0].DAT_02 &= 0xf7;

            if (Input.GetButton(player + "SELECT"))
                inputs[i, 0].DAT_02 &= 0xfe;

            for (int j = 1; j < 9; j++)
            {
                inputs[i, j].DAT_00 = inputs[i, 0].DAT_00;
                inputs[i, j].DAT_01 = inputs[i, 0].DAT_01;
                inputs[i, j].DAT_02 = inputs[i, 0].DAT_02;
                inputs[i, j].DAT_03 = inputs[i, 0].DAT_03;
                inputs[i, j].DAT_04 = inputs[i, 0].DAT_04;
                inputs[i, j].DAT_05 = inputs[i, 0].DAT_05;
                inputs[i, j].DAT_06 = inputs[i, 0].DAT_06;
                inputs[i, j].DAT_07 = inputs[i, 0].DAT_07;
            }
        }
    }

    private void FixedUpdate()
    {
        FUN_1DAEC();
    }

    public void FUN_1DAEC()
    {
        int iVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        Vector3Int local_20;
        Vector3Int local_18;

        local_18 = new Vector3Int(0, 0, 0);

        if (inputs[0, 0].DAT_00 == 0)
        {
            if (inputs[0, 0].DAT_01 == 0x41)
                uVar4 = ~((uint)(inputs[0, 0].DAT_02 << 8) | inputs[0, 0].DAT_03);
            else
            {
                if (inputs[0, 0].DAT_01 == 0x73)
                {
                    iVar3 = inputs[0, 0].DAT_06 - 0x80;
                    iVar1 = 0x80 - inputs[0, 0].DAT_07;
                    local_20 = new Vector3Int(iVar3, 0, iVar1);
                    uVar2 = (uint)Utilities.SquareRoot0(iVar3 * iVar3 + iVar1 * iVar1);
                    controllers[0].DAT_C255a = 0;

                    if (0x34 < (uVar2 & 0xffff))
                    {
                        controllers[0].DAT_C255a = (short)uVar2;
                        controllers[0].DAT_C2558 = (short)Utilities.FUN_615EC(local_18, local_20);
                    }

                    uVar4 = ~((uint)(inputs[0, 0].DAT_02 << 8) | inputs[0, 0].DAT_03);
                }
                else
                    uVar4 = 0;
            }

            controllers[0].DAT_C2556 = (ushort)(inputs[0, 0].DAT_01 == 0x73 ? 1 : 0);
            controllers[0].DAT_C2554 = controllers[0].DAT_C2550;
            controllers[0].DAT_C2552 = (ushort)(uVar4 & ~controllers[0].DAT_C2550);
            controllers[0].DAT_C2550 = (ushort)uVar4;
        }
        else
        {
            controllers[0].DAT_C2552 = 0;
            controllers[0].DAT_C2550 = 0;
            controllers[0].DAT_C2554 = 0;
            controllers[0].DAT_C2556 = 0;
        }

        FUN_1D9C8(controllers[0]);
        controllers[0].DAT_B5898 = controllers[0].DAT_B1418;
        controllers[0].DAT_B58B8 = controllers[0].DAT_B141A;

        if ((GameManager.instance.DAT_40 & 4) == 0)
        {
            if ((controllers[0].DAT_B141A & 0x80) != 0)
                controllers[0].DAT_B58B8 = (ushort)(controllers[0].DAT_B141A & 0xffef);

            GameManager.instance.DAT_1f800008 = controllers[0].DAT_B1418;
            GameManager.instance.DAT_1f80000a = controllers[0].DAT_B58B8;
        }
        else
        {
            GameManager.instance.DAT_1f800008 = 0;
            GameManager.instance.DAT_1f80000a = 0;
        }
    }

    private void FUN_1D9C8(Controller param1)
    {
        byte bVar1;
        uint uVar2;
        ushort uVar3;
        ushort uVar4;
        ushort[] local_10;
        ushort[] local_8;

        local_8 = new ushort[3] { 0x10, 0x40, 0x80 };
        uVar4 = (ushort)(param1.DAT_C2550 & 0xff0f);
        bVar1 = GameManager.instance.DAT_A2CF;
        local_10 = new ushort[4];

        if (bVar1 == 1)
        {
            local_10[0] = 0x10;
            local_10[1] = 0x80;
            local_10[2] = 0x60;
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 != 0) goto LAB_1DA84;

                local_10[0] = 0x10;
                local_10[1] = 0x40;
                local_10[2] = 0xa0;
            }
        }

        LAB_1DA84:
        uVar3 = 0;
        uVar2 = 0;

        do
        {
            if ((param1.DAT_C2550 & local_10[uVar2]) != 0)
                uVar4 |= local_8[uVar2];

            uVar3++;
            uVar2 = uVar3;
        } while (uVar3 < 3);

        uVar3 = param1.DAT_B1418;
        param1.DAT_B1418 = uVar4;
        param1.DAT_B141C = uVar3;
        param1.DAT_B141A = (ushort)(uVar4 & ~uVar3);
    }
}
