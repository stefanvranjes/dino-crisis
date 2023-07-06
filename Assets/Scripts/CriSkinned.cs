using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriSkinned : CriObject
{
    public Vector3Int DAT_34; //0x34
    public byte DAT_3C; //0x3C
    public byte DAT_3D; //0x3D
    public byte DAT_3E; //0x3E
    public byte DAT_3F; //0x3F
    public Vector3Int DAT_40; //0x40
    public short DAT_46; //0x46
    public sbyte DAT_48; //0x48
    public CriBone skeleton; //0x4C
    public int boneCount; //0x50
    public Packet packet; //0x54
    public Frame[] frames; //0x58
    public byte DAT_5C; //0x5C
    public byte DAT_5D; //0x5D
    public byte DAT_5E; //0x5E
    public ushort DAT_60; //0x60
    public byte DAT_62; //0x62
    public Vector3Int DAT_64; //0x64
    public Packet[] packets; //0x70
    public Frame[] DAT_74; //0x74
    public byte frameCount; //0x78
    public byte frameNum; //0x79
    public Frame frame; //0x7C
    public TodScriptableObject[] DAT_98; //0x98
    public Tmd2ScriptableObject cSkin; //0x9C
    public Vector3Int skinSize; //0xA4
    public Color32 tint; //0xB0
    public Vector3Int[] DAT_B4; //0xB4
    public Vector3Int DAT_EC; //0xEC
    public Vector3Int DAT_F2; //0xF2
    public Vector3Int DAT_F8; //0xF8
    public Vector3Int DAT_10C; //0x10C
    public short DAT_112; //0x112
    public short health; //0x118
    public short maxHealth; //0x11A
    public short DAT_11C; //0x11C
    public byte DAT_11E; //0x11E
    public int DAT_120; //0x120
    public CapsuleCollider[] PTR_120;
    public int DAT_124; //0x124
    public CapsuleCollider[] PTR_124;
    public ushort DAT_128; //0x128
    public byte DAT_12A; //0x12A
    public byte DAT_12B; //0x12B
    public ushort DAT_12C; //0x12C
    public sbyte DAT_12E; //0x12E
    public byte DAT_12F; //0x12F
    public int DAT_130; //0x130
    public CapsuleCollider[] PTR_130;
    public WallCollider DAT_134; //0x134
    public Vector2Int DAT_13C; //0x13C
    public ushort DAT_140; //0x140
    public sbyte DAT_142; //0x142
    public ushort DAT_144; //0x144
    public ushort DAT_146; //0x146
    public ushort DAT_148; //0x148
    public Vector3Int DAT_14C; //0x14C
    public short DAT_152; //0x152
    public CriSkinned DAT_154; //0x154
    public Vector3Int DAT_158; //0x158
    public byte DAT_162; //0x162
    public byte DAT_163; //0x163
    public byte DAT_164; //0x164
    public byte DAT_165; //0x165
    public byte DAT_166; //0x166
    public byte DAT_167; //0x167
    public Vector3Int DAT_168; //0x168
    public Vector2Int shadowSize; //0x170
    public byte DAT_174; //0x174
    public byte DAT_175; //0x175
    public byte DAT_176; //0x176
    public byte DAT_177; //0x177
    public CriBone[] DAT_184; //0x184
    public byte DAT_18C; //0x18C
    public bool DAT_18D; //0x18D
    public byte DAT_18E; //0x18E
    public byte DAT_18F; //0x18F
    public int DAT_190; //0x190
    public Vector3Int[] PTR_190; //0x190
    public short DAT_194; //0x194
    public short DAT_196; //0x196
    public sbyte DAT_198; //0x198
    public byte DAT_199; //0x199
    public ushort DAT_19A; //0x19A
    public ushort DAT_19E; //0x19E
    public byte DAT_1A0; //0x1A0
    public byte DAT_1A1; //0x1A1
    public bool DAT_1A2; //0x1A2
    public byte DAT_1A3; //0x1A3
    public byte DAT_1A4; //0x1A4
    public byte DAT_1A5; //0x1A5
    public bool DAT_1A6; //0x1A6
    public byte DAT_1A7; //0x1A7
    public int[] REFS;

    public Transform shadow;
    private List<byte> commandList;
    private List<Vector3> vertexList;
    private List<Vector2> uvList;
    private List<Vector3> uv2List;
    private List<Color> colorList;
    private List<int> triangleList;
    public Material[] materials;

    protected override void Awake()
    {
        base.Awake();
        DAT_184 = new CriBone[2];
        DAT_B4 = new Vector3Int[3];
    }

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

    private void OnRenderObject()
    {
        if (cSkin != null && (flags & 2) != 0)
        {
            GL.PushMatrix();
            GL.MultMatrix(Matrix4x4.identity);

            for (int i = 0; i < cSkin.TRI_COUNT; i++)
            {
                materials[commandList[i] & 0xef].SetPass(0);
                GL.Begin(GL.TRIANGLES);
                int j = i * 3;

                for (int k = 0; k < 3; k++)
                {
                    if (!GameManager.instance.disableColors && (commandList[i] & 0x10) != 0)
                        GL.Color(colorList[triangleList[j + k]]);
                    GL.MultiTexCoord(0, uvList[j + k]);
                    GL.MultiTexCoord(1, uv2List[i]);
                    GL.Vertex(vertexList[triangleList[j + k]]);
                }

                GL.End();
            }

            for (int i = 0; i < cSkin.QUAD_COUNT; i++)
            {
                materials[commandList[cSkin.TRI_COUNT + i] & 0xef].SetPass(0);
                GL.Begin(GL.TRIANGLES);
                int j = cSkin.TRI_COUNT * 3 + i * 6;

                for (int k = 0; k < 6; k++)
                {
                    if (!GameManager.instance.disableColors && (commandList[i] & 0x10) != 0)
                        GL.Color(colorList[triangleList[j + k]]);
                    GL.MultiTexCoord(0, uvList[j + k]);
                    GL.MultiTexCoord(1, uv2List[cSkin.TRI_COUNT + i]);
                    GL.Vertex(vertexList[triangleList[j + k]]);
                }

                GL.End();
            }

            RenderQueue.AddMatrix(shadow);
            RenderQueue.AddCommand(commandList[cSkin.TRI_COUNT + cSkin.QUAD_COUNT]);
            RenderQueue.AddMaterial(materials[commandList[cSkin.TRI_COUNT + cSkin.QUAD_COUNT] & 0xef]);
            RenderQueue.AddMatrix(shadow);
            RenderQueue.AddCommand(commandList[cSkin.TRI_COUNT + cSkin.QUAD_COUNT]);
            RenderQueue.AddMaterial(materials[commandList[cSkin.TRI_COUNT + cSkin.QUAD_COUNT] & 0xef]);
            int m = cSkin.TRI_COUNT * 3 + cSkin.QUAD_COUNT * 6;

            for (int k = 0; k < 6; k++)
            {
                RenderQueue.AddColor(colorList[triangleList[m + k]]);
                RenderQueue.AddUV(uvList[m + k]);
                RenderQueue.AddUV2(uv2List[cSkin.TRI_COUNT + cSkin.QUAD_COUNT]);
                RenderQueue.AddVertex(vertexList[triangleList[m + k]]);
            }

            GL.PopMatrix();
        }
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_34 = Vector3Int.zero;
        DAT_3C = 0;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_40 = Vector3Int.zero;
        DAT_46 = 0;
        DAT_48 = 0;
        skeleton = null;
        boneCount = 0;
        packet = null;
        frames = null;
        DAT_5C = 0;
        DAT_5D = 0;
        DAT_5E = 0;
        DAT_60 = 0;
        DAT_62 = 0;
        DAT_64 = Vector3Int.zero;
        packets = null;
        DAT_74 = null;
        frameCount = 0;
        frameNum = 0;
        frame = null;
        DAT_98 = null;
        cSkin = null;
        skinSize = Vector3Int.zero;
        tint = Color.clear;
        DAT_B4 = new Vector3Int[3];
        DAT_EC = Vector3Int.zero;
        DAT_F2 = Vector3Int.zero;
        DAT_F8 = Vector3Int.zero;
        DAT_10C = Vector3Int.zero;
        DAT_112 = 0;
        health = 0;
        maxHealth = 0;
        DAT_11C = 0;
        DAT_11E = 0;
        DAT_120 = 0;
        PTR_120 = null;
        DAT_124 = 0;
        PTR_124 = null;
        DAT_128 = 0;
        DAT_12A = 0;
        DAT_12B = 0;
        DAT_12C = 0;
        DAT_12E = 0;
        DAT_12F = 0;
        DAT_130 = 0;
        PTR_130 = null;
        DAT_134 = null;
        DAT_13C = Vector2Int.zero;
        DAT_140 = 0;
        DAT_142 = 0;
        DAT_144 = 0;
        DAT_146 = 0;
        DAT_148 = 0;
        DAT_14C = Vector3Int.zero;
        DAT_152 = 0;
        DAT_154 = null;
        DAT_158 = Vector3Int.zero;
        DAT_162 = 0;
        DAT_163 = 0;
        DAT_164 = 0;
        DAT_165 = 0;
        DAT_166 = 0;
        DAT_167 = 0;
        DAT_168 = Vector3Int.zero;
        shadowSize = Vector2Int.zero;
        DAT_174 = 0;
        DAT_175 = 0;
        DAT_176 = 0;
        DAT_177 = 0;
        DAT_184[0] = null;
        DAT_184[1] = null;
        DAT_18C = 0;
        DAT_18D = false;
        DAT_18E = 0;
        DAT_18F = 0;
        DAT_190 = 0;
        PTR_190 = null;
        DAT_194 = 0;
        DAT_196 = 0;
        DAT_198 = 0;
        DAT_199 = 0;
        DAT_19A = 0;
        DAT_19E = 0;
        DAT_1A0 = 0;
        DAT_1A1 = 0;
        DAT_1A2 = false;
        DAT_1A3 = 0;
        DAT_1A4 = 0;
        DAT_1A5 = 0;
        DAT_1A6 = false;
        DAT_1A7 = 0;
        REFS = null;
    }

    public void FUN_60278()
    {
        bool bVar1;
        int iVar2;
        CriBone oVar3;

        oVar3 = skeleton;
        iVar2 = boneCount - 2;

        if (boneCount != 0)
        {
            do
            {
                oVar3.flags = 0;
                oVar3 = (CriBone)oVar3.next;
                bVar1 = iVar2 != -1;
                iVar2--;
            } while (bVar1);
        }
    }

    public void FUN_60444()
    {
        Bone puVar2;
        int iVar3;
        CriBone oVar4;
        int puVar5;

        oVar4 = skeleton;
        iVar3 = boneCount - 1;
        puVar5 = 0;

        if (iVar3 != -1)
        {
            do
            {
                puVar2 = cSkin.BONES[puVar5];
                oVar4.DAT_44 = puVar2.DAT_00;
                iVar3--;
                puVar5++;
            } while (iVar3 != -1);
        }
    }

    public void FUN_604A4(Tmd2ScriptableObject param1)
    {
        byte bVar1;
        CriBone oVar2;
        uint uVar4;
        int iVar5;
        Bone puVar7;
        uint uVar8;
        CriBone[] local_a0;

        uVar8 = (uint)param1.BONE_COUNT;
        uVar4 = 0;
        local_a0 = new CriBone[30];

        if (uVar8 != 0)
        {
            do
            {
                puVar7 = param1.BONES[uVar4];
                oVar2 = SceneManager.instance.FUN_601F0();
                local_a0[uVar4] = oVar2;
                oVar2.DAT_44 = puVar7.DAT_00;

                if (puVar7.DAT_06 < 0)
                    oVar2.prev = this;
                else
                    oVar2.prev = local_a0[puVar7.DAT_06];

                bVar1 = puVar7.DAT_07;
                uVar4++;
                oVar2.DAT_42 = bVar1;
            } while (uVar4 < uVar8);
        }

        uVar4 = 0;

        if (uVar8 != 1)
        {
            do
            {
                uVar4++;
                local_a0[uVar4 - 1].next = local_a0[uVar4];
            } while (uVar4 < uVar8 - 1);
        }

        local_a0[uVar4].next = null;
        skinSize = new Vector3Int(0x1000, 0x1000, 0x1000);
        shadowSize = new Vector2Int(0x1000, 0x1000);
        tint = new Color32(0x80, 0x80, 0x80, 0x00);
        boneCount = (int)uVar8;
        DAT_5E = (byte)((uVar8 * 0x24 + 0x1f >> 5) * 4 + 12);
        DAT_198 = -1;
        cSkin = param1;
        DAT_1A5 = 5;
        skeleton = local_a0[0];
        FUN_66208();
        iVar5 = boneCount;
        oVar2 = skeleton;

        while (--iVar5 != -1)
        {
            oVar2.DAT_4C = oVar2.screen;
            oVar2 = (CriBone)oVar2.next;
        }
    }

    public bool FUN_60AB4()
    {
        byte bVar1;
        byte bVar2;
        byte bVar3;
        uint uVar4;
        bool bVar6;

        bVar1 = DAT_5C;
        DAT_60++;
        bVar6 = false;

        if ((bVar1 & 0x20) == 0)
        {
            if (DAT_62 != 0) goto LAB_60C78;

            bVar3 = frameNum;
            frameNum = (byte)(bVar3 + 1);

            if ((bVar1 & 4) != 0)
            {
                bVar6 = frameCount <= bVar3 + 1U;

                if (frameCount < bVar3 + 1U)
                {
                    if ((bVar1 & 1) == 0)
                        frameNum = bVar3;
                    else
                    {
                        frameNum = 0;
                        DAT_60 = 0;
                    }
                }

                if ((uint)frames[frameNum].DAT_00 >> 1 == 0)
                    frameNum++;
            }

            if ((uint)frameCount <= frameNum)
            {
                bVar6 = true;

                if ((bVar1 & 1) == 0)
                    DAT_5C |= 0x20;
            }

            if ((uint)frameCount < frameNum)
            {
                if ((bVar1 & 1) == 0)
                    frameNum--;
                else
                {
                    frameNum = 0;
                    DAT_60 = 0;
                }
            }

            if ((bVar1 & 2) == 0)
                uVar4 = frameNum;
            else
                uVar4 = (uint)frameCount - frameNum;

            packet = packets[frames[uVar4].DAT_01];
            bVar2 = frames[uVar4].DAT_00;
            DAT_62 = bVar2;

            if ((bVar1 & 4) != 0 && 1U < bVar2)
                DAT_62 = (byte)((uint)bVar2 >> 1);

            if ((bVar1 & 8) == 0) goto LAB_60C78;

            bVar3 = (byte)(DAT_62 << 1);
        }
        else
            bVar3 = (byte)(DAT_62 + 1);

        DAT_62 = bVar3;
        LAB_60C78:
        FUN_607A4();
        return bVar6;
    }

    public void FUN_607A4()
    {
        byte bVar1;
        int iVar1;
        CriBone oVar2;
        Packet psVar3;
        Vector3Int local_18;

        psVar3 = packet;
        oVar2 = skeleton;

        if ((DAT_5C & 2) == 0)
            bVar1 = frameNum;
        else
            bVar1 = (byte)(frameCount - frameNum);

        frame = frames[bVar1];
        DAT_64 = psVar3.DAT_06;

        if ((DAT_5C & 0x10) == 0)
        {
            local_18 = psVar3.DAT_00;

            if (DAT_5D == 0)
                bVar1 = DAT_62;
            else
                bVar1 = (byte)(DAT_62 + DAT_5D);

            if (bVar1 == 0)
                return; //trap(0x1c00)

            oVar2.DAT_44 = Utilities.LoadAverageShort12
                (ref oVar2.DAT_44, ref local_18, 0x1000 - 0x1000 / bVar1, 0x1000 / bVar1);
        }
        else
            oVar2.DAT_44 = psVar3.DAT_00;

        if (DAT_5D == 0)
        {
            Utilities.FUN_60C94(psVar3.COMP, GameManager.instance.todUncomp, boneCount);

            if (DAT_62 == 0)
                return; //trap(0x1c00)

            FUN_60EF0((uint)boneCount, 0x1000 / DAT_62);
        }
        else
        {
            Utilities.FUN_60C94(psVar3.COMP, GameManager.instance.todUncomp, boneCount);
            iVar1 = DAT_62 + DAT_5D;

            if (iVar1 == 0)
                return; //trap(0x1c00)

            FUN_60EF0((uint)boneCount, 0x1000 / iVar1);
            DAT_5D--;
        }

        DAT_62--;
    }

    public void FUN_609C8(TodScriptableObject param1, byte param2, byte param3, uint param4)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;

        if (param1 == null)
        {
            FUN_609C8(REFS[param4 / 4], param2, param3);
            return;
        }

        packets = param1.PACKETS;
        bVar1 = (byte)param1.FRAME_COUNT;
        frames = param1.FRAMES;
        DAT_74 = param1.FRAMES;
        frameNum = 0;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
            uVar3 = frameNum;
        else
            uVar3 = (uint)(bVar1 - frameNum);

        packet = packets[frames[uVar3].DAT_01];
        DAT_62 = frames[uVar3].DAT_00;
        bVar2 = frames[0].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = param3;
        FUN_607A4();
    }

    public void FUN_609C8(int param1, byte param2, byte param3)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;

        packets = DAT_98[param1].PACKETS;
        bVar1 = (byte)DAT_98[param1].FRAME_COUNT;
        frames = DAT_98[param1].FRAMES;
        DAT_74 = DAT_98[param1].FRAMES;
        frameNum = 0;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
            uVar3 = frameNum;
        else
            uVar3 = (uint)(bVar1 - frameNum);

        packet = packets[frames[uVar3].DAT_01];
        DAT_62 = frames[uVar3].DAT_00;
        bVar2 = frames[0].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = param3;
        FUN_607A4();
    }

    public void FUN_60EF0(uint param1, int param2)
    {
        uint uVar1;
        CriBone oVar2;
        List<Vector3Int> puVar3;
        int iVar4;
        bool bVar5;
        int iVar6;

        puVar3 = GameManager.instance.todUncomp;
        oVar2 = skeleton;
        bVar5 = false;

        if ((DAT_5C & 0x40) == 0)
        {
            uVar1 = 0;

            if (param1 != 0)
            {
                do
                {
                    Vector3Int temp = puVar3[(int)uVar1];
                    Utilities.FUN_665D8(ref oVar2.vr, ref temp, ref oVar2.vr, param2);
                    puVar3[(int)uVar1] = temp;
                    oVar2 = (CriBone)oVar2.next;
                    uVar1++;
                } while (uVar1 < param1);
            }
        }
        else
        {
            uVar1 = 0;

            if (param1 != 0)
            {
                iVar4 = -1;

                do
                {
                    if (uVar1 - 1 < 14)
                    {
                        switch (iVar4)
                        {
                            case 0:
                                bVar5 = true;
                                break;
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                                if ((DAT_5C & 0x40) != 0)
                                    bVar5 = true;

                                break;
                            case 7:
                                bVar5 = false;
                                break;
                            case 8:
                            case 9:
                            case 10:
                            case 11:
                            case 12:
                            case 13:
                                if ((DAT_5C & 0x80) != 0)
                                    bVar5 = true;

                                break;
                        }
                    }

                    Vector3Int temp = puVar3[(int)uVar1];
                    iVar6 = bVar5 ? param2 : 0x1000;
                    Utilities.FUN_665D8(ref oVar2.vr, ref temp, ref oVar2.vr, iVar6);
                    oVar2 = (CriBone)oVar2.next;
                    uVar1++;
                    iVar4++;
                } while (uVar1 < param1);
            }
        }
    }

    public void FUN_6103C(TodScriptableObject param1, byte param2, byte param3, int param4)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;
        CriBone oVar4;

        packets = param1.PACKETS;
        bVar1 = (byte)param1.FRAME_COUNT;
        frames = param1.FRAMES;
        DAT_74 = param1.FRAMES;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
        {
            frameNum = param3;
            uVar3 = param3;
        }
        else
        {
            frameNum = (byte)(bVar1 - param3);
            uVar3 = (uint)bVar1 - frameNum;
        }

        packet = packets[frames[uVar3].DAT_01];
        bVar2 = frames[uVar3].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = (byte)param4;

        if (param4 == 0)
        {
            oVar4 = skeleton;

            if (oVar4 != null)
            {
                oVar4.vr = new Vector3Int(0, 0, 0);
                oVar4 = oVar4.next as CriBone;
            }
        }

        FUN_607A4();
    }

    public void FUN_6103C(int param1, byte param2, byte param3, int param4)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;
        CriBone oVar4;

        packets = DAT_98[param1].PACKETS;
        bVar1 = (byte)DAT_98[param1].FRAME_COUNT;
        frames = DAT_98[param1].FRAMES;
        DAT_74 = DAT_98[param1].FRAMES;
        DAT_60 = 0;
        DAT_5C = param2;
        frameCount = bVar1;

        if ((param2 & 2) == 0)
        {
            frameNum = param3;
            uVar3 = param3;
        }
        else
        {
            frameNum = (byte)(bVar1 - param3);
            uVar3 = (uint)bVar1 - frameNum;
        }

        packet = packets[frames[uVar3].DAT_01];
        bVar2 = frames[uVar3].DAT_00;
        DAT_62 = bVar2;

        if ((param2 & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = (byte)param4;

        if (param4 == 0)
        {
            oVar4 = skeleton;

            if (oVar4 != null)
            {
                oVar4.vr = new Vector3Int(0, 0, 0);
                oVar4 = oVar4.next as CriBone;
            }
        }

        FUN_607A4();
    }

    public void FUN_6449C(ushort param2)
    {
        bool bVar1;
        int iVar2;
        int iVar3;

        if (0 < screen.y)
            screen.y = 0;

        iVar3 = DAT_34.y / 425 * -0x1000000 >> 0x18;
        iVar2 = screen.y / 425 * -0x1000000 >> 0x18;

        if (iVar2 < iVar3)
        {
            do
            {
                if (iVar3 < iVar2)
                    return;

                bVar1 = SceneManager.instance.FUN_64210(ref screen, (byte)iVar3, param2);
                iVar3--;
            } while (!bVar1);
        }
        else
        {
            do
            {
                if (iVar3 < iVar2)
                    return;

                bVar1 = SceneManager.instance.FUN_64210(ref screen, (byte)iVar2, param2);
                iVar2++;
            } while (!bVar1);
        }
    }

    private void FUN_65618(CriSkinned param1)
    {
        GameManager.DAT_1f80002c = DAT_64;
        Utilities.RotMatrix_gte(ref vr, ref GameManager.DAT_1f800034);
        GameManager.DAT_1f80002c = Utilities.ApplyMatrixSV
            (ref GameManager.DAT_1f800034, ref GameManager.DAT_1f80002c);
        DAT_14C.x = screen.x - GameManager.DAT_1f80002c.x;
        DAT_14C.y = screen.y - GameManager.DAT_1f80002c.y;
        DAT_14C.z = screen.z - GameManager.DAT_1f80002c.z;
        param1.DAT_14C = DAT_14C;
    }

    public void FUN_656EC()
    {
        FUN_65618(SceneManager.instance.DAT_27C[10]);
    }

    public void FUN_65714()
    {
        GameManager.DAT_1f80002c = new Vector3Int(DAT_64.x, -DAT_64.y, -DAT_64.z);
        Utilities.RotMatrix_gte(ref vr, ref GameManager.DAT_1f800034);
        GameManager.DAT_1f80002c = Utilities.ApplyMatrixSV
            (ref GameManager.DAT_1f800034, ref GameManager.DAT_1f80002c);
        screen.x = DAT_14C.x + GameManager.DAT_1f80002c.x;
        screen.y = DAT_14C.y + GameManager.DAT_1f80002c.y;
        screen.z = DAT_14C.z + GameManager.DAT_1f80002c.z;
    }

    public void FUN_659D0()
    {
        CriBone oVar1;
        uint uVar2;

        FUN_66208();
        uVar2 = 0;

        do
        {
            oVar1 = DAT_184[uVar2];
            uVar2++;
            oVar1.DAT_4C = oVar1.screen;
        } while (uVar2 < 2);
    }

    public void FUN_65984(int param1, int param2)
    {
        CriBone oVar1;

        DAT_18C = 0;
        oVar1 = Utilities.FUN_601C8(skeleton, param1) as CriBone;
        DAT_184[0] = oVar1;
        oVar1 = Utilities.FUN_601C8(skeleton, param2) as CriBone;
        DAT_184[1] = oVar1;
    }

    public uint FUN_65A28()
    {
        short sVar1;
        short sVar2;
        CriBone oVar3;
        short sVar4;
        CriBone oVar5;
        uint uVar6;

        uVar6 = DAT_18C;

        if (uVar6 == 0)
            uVar6 = frames[frameNum].DAT_02;

        if ((uVar6 & 0xe0) != 0)
        {
            oVar5 = DAT_184[uVar6 & 1];

            if ((uVar6 & 0x80) != 0)
            {
                screen.x -= oVar5.screen.x - oVar5.DAT_4C.x;
                screen.z -= oVar5.screen.z - oVar5.DAT_4C.z;
            }

            if ((uVar6 & 0x40) == 0)
            {
                if ((uVar6 & 0x20) == 0)
                    return uVar6;

                oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
                sVar4 = (short)oVar5.screen.y;
                sVar1 = (short)oVar5.DAT_4C.y;
                sVar2 = (short)oVar3.DAT_44.y;
            }
            else
            {
                oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
                sVar1 = (short)screen.y;
                sVar2 = (short)oVar3.DAT_44.y;
                sVar4 = (short)(oVar5.screen.y + 0x74);
            }

            oVar3.DAT_44.y = sVar2 - (sVar4 - sVar1);
        }

        return uVar6;
    }

    public void FUN_65C4C(CriPlayer param1)
    {
        param1.DAT_1DC = (CriPlayer)this;

        if (param1.DAT_98 != DAT_98)
        {
            param1.DAT_1E0 = param1.DAT_98;
            param1.DAT_98 = DAT_98;
        }
    }

    public void FUN_65CF8(byte param1, byte param2, byte param3)
    {
        DAT_164 = param1;
        DAT_165 = 0;
        DAT_166 = param2;
        DAT_167 = param3;
    }

    public bool FUN_65D78(ref UNK_9B314 param1, byte param2, byte param3)
    {
        bool bVar2;
        CriStatic oVar3;
        CriInteract oVar4;
        CriBone oVar5;

        oVar3 = SceneManager.instance.FUN_5FE78();
        bVar2 = false;

        if (oVar3 != null)
        {
            oVar4 = SceneManager.instance.FUN_5FF08();
            bVar2 = oVar4 != null;

            if (bVar2)
            {
                oVar3.flags = 3;
                oVar5 = (CriBone)Utilities.FUN_601C8(skeleton, param1.bone);
                oVar3.DAT_40 = oVar5;
                oVar3.screen = param1.screen;
                oVar3.vr = param1.vr;
                oVar3.cMesh = (TmdScriptableObject)GameManager.instance.playerCore.objects[0x80180178];
                oVar4.DAT_01 = 12;
                oVar4.DAT_1C = oVar3;
                oVar4.DAT_20 = this;
                oVar4.DAT_18 = param2;
                oVar4.DAT_19 = param3;
                oVar4.DAT_16 = param1.bone;
            }
        }

        return bVar2;
    }

    public void FUN_66208()
    {
        long lVar3;
        int iVar4;
        int iVar6;
        int iVar7;
        int iVar8;
        CriObject puVar9;
        int iVar10;
        CriBone m;

        Utilities.RotMatrix_gte(ref vr, ref cTransform.rotation);
        Utilities.ScaleMatrix(ref cTransform.rotation, ref skinSize);
        m = skeleton;
        iVar10 = boneCount - 1;
        cTransform.position = screen;

        do
        {
            puVar9 = m.prev;

            if (!m.DAT_43)
                Utilities.RotMatrix_gte(ref m.vr, ref m.cTransform.rotation);
            else
                Utilities.RotMatrixYXZ_gte(ref m.vr, ref m.cTransform.rotation);

            Coprocessor.rotationMatrix.rt11 = puVar9.cTransform.rotation.V00;
            Coprocessor.rotationMatrix.rt12 = puVar9.cTransform.rotation.V01;
            Coprocessor.rotationMatrix.rt13 = puVar9.cTransform.rotation.V02;
            Coprocessor.rotationMatrix.rt21 = puVar9.cTransform.rotation.V10;
            Coprocessor.rotationMatrix.rt22 = puVar9.cTransform.rotation.V11;
            Coprocessor.rotationMatrix.rt23 = puVar9.cTransform.rotation.V12;
            Coprocessor.rotationMatrix.rt31 = puVar9.cTransform.rotation.V20;
            Coprocessor.rotationMatrix.rt32 = puVar9.cTransform.rotation.V21;
            Coprocessor.rotationMatrix.rt33 = puVar9.cTransform.rotation.V22;
            Coprocessor.vector0.vx0 = (short)m.DAT_44.x;
            Coprocessor.vector0.vy0 = (short)m.DAT_44.y;
            Coprocessor.vector0.vz0 = (short)m.DAT_44.z;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            lVar3 = Coprocessor.mathsAccumulator.mac1;
            m.cTransform.position.x = (int)lVar3;
            lVar3 = Coprocessor.mathsAccumulator.mac2;
            m.cTransform.position.y = (int)lVar3;
            lVar3 = Coprocessor.mathsAccumulator.mac3;
            m.cTransform.position.z = (int)lVar3;
            Coprocessor.accumulator.ir1 = m.cTransform.rotation.V00;
            Coprocessor.accumulator.ir2 = m.cTransform.rotation.V10;
            Coprocessor.accumulator.ir3 = m.cTransform.rotation.V20;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = m.cTransform.position.x + puVar9.cTransform.position.x;
            m.cTransform.position.x = iVar4;
            m.screen.x = iVar4;
            iVar6 = Coprocessor.accumulator.ir1;
            iVar7 = Coprocessor.accumulator.ir2;
            iVar8 = Coprocessor.accumulator.ir3;
            m.cTransform.rotation.V00 = (short)iVar6;
            m.cTransform.rotation.V10 = (short)iVar7;
            m.cTransform.rotation.V20 = (short)iVar8;
            Coprocessor.accumulator.ir1 = m.cTransform.rotation.V01;
            Coprocessor.accumulator.ir2 = m.cTransform.rotation.V11;
            Coprocessor.accumulator.ir3 = m.cTransform.rotation.V21;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = m.cTransform.position.y + puVar9.cTransform.position.y;
            m.cTransform.position.y = iVar4;
            m.screen.y = iVar4;
            iVar6 = Coprocessor.accumulator.ir1;
            iVar7 = Coprocessor.accumulator.ir2;
            iVar8 = Coprocessor.accumulator.ir3;
            m.cTransform.rotation.V01 = (short)iVar6;
            m.cTransform.rotation.V11 = (short)iVar7;
            m.cTransform.rotation.V21 = (short)iVar8;
            Coprocessor.accumulator.ir1 = m.cTransform.rotation.V02;
            Coprocessor.accumulator.ir2 = m.cTransform.rotation.V12;
            Coprocessor.accumulator.ir3 = m.cTransform.rotation.V22;
            Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
            iVar4 = m.cTransform.position.z + puVar9.cTransform.position.z;
            m.cTransform.position.z = iVar4;
            m.screen.z = iVar4;
            iVar6 = Coprocessor.accumulator.ir1;
            iVar7 = Coprocessor.accumulator.ir2;
            iVar8 = Coprocessor.accumulator.ir3;
            m.cTransform.rotation.V02 = (short)iVar6;
            m.cTransform.rotation.V12 = (short)iVar7;
            m.cTransform.rotation.V22 = (short)iVar8;
            iVar10--;
            m = (CriBone)m.next;
        } while (iVar10 != -1);
    }

    public void FUN_66404(byte param1, short param2, short param3)
    {
        DAT_174 = (byte)(param1 | 0x80);
        shadowSize = new Vector2Int(param2, param3);
    }

    public void FUN_66460(bool param1)
    {
        if (param1)
        {
            DAT_174 |= 0x40;
            return;
        }

        DAT_174 &= 0xbf;
    }

    public void FUN_77784(uint param1, ushort param2)
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = param1 & 0xff;

        if (uVar2 == 0)
            return; //trap(0x1c00)

        if (uVar2 == 0xffffffff && iVar1 == -0x80000000)
            return; //trap(0x1800)

        DAT_146 = param2;
        DAT_144 = (ushort)(((param1 & 0xff) - 1) * 400 | 0x8000 | (ushort)(iVar1 & (int)uVar2));
    }

    public void FUN_2D704()
    {
        short sVar1;
        int iVar2;
        uint uVar3;

        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = 850;

        if (iVar2 == (iVar2 / 3) * 3)
        {
            uVar3 = GameManager.FUN_64650();
            sVar1 = 1000;

            if ((uVar3 & 2) == 0)
                sVar1 = 750;
        }

        maxHealth = sVar1;
    }

    public void FUN_7569C(Tmd2ScriptableObject param1)
    {
        vertexList = GameManager.instance.skinnedVertices;
        colorList = GameManager.instance.skinnedColors;
        FUN_75718(param1, param1.TRI_COUNT);
        FUN_75944(param1, param1.QUAD_COUNT);
    }

    private void FUN_75718(Tmd2ScriptableObject param1, int param2)
    {
        int uv = 0;
        int uv2 = 0;
        int tri = 0;
        commandList.Clear();
        uvList.Clear();
        uv2List.Clear();
        triangleList.Clear();

        while (-1 < --param2)
        {
            commandList.Add(0x10); //0x34
            uvList.Add(param1.UVS[uv]);
            uvList.Add(param1.UVS[uv + 1]);
            uvList.Add(param1.UVS[uv + 2]);
            uv2List.Add(param1.UVS2[uv2]);
            triangleList.Add(param1.TRIS[tri]);
            triangleList.Add(param1.TRIS[tri + 1]);
            triangleList.Add(param1.TRIS[tri + 2]);
            GameManager.DAT_1f800026++;
            GameManager.DAT_1f800024++;

            uv += 3;
            uv2++;
            tri += 3;
        }
    }

    private void FUN_75944(Tmd2ScriptableObject param1, int param2)
    {
        int begin = param1.TRI_COUNT;
        int uv = begin * 3;
        int uv2 = begin;
        int tri = 0;

        while (-1 < --param2)
        {
            commandList.Add(0x10); //0x3C
            uvList.Add(param1.UVS[uv]);
            uvList.Add(param1.UVS[uv + 1]);
            uvList.Add(param1.UVS[uv + 2]);
            uvList.Add(param1.UVS[uv + 3]);
            uvList.Add(param1.UVS[uv + 2]);
            uvList.Add(param1.UVS[uv + 1]);
            uv2List.Add(param1.UVS2[uv2]);
            triangleList.Add(param1.QUADS[tri]);
            triangleList.Add(param1.QUADS[tri + 1]);
            triangleList.Add(param1.QUADS[tri + 2]);
            triangleList.Add(param1.QUADS[tri + 3]);
            triangleList.Add(param1.QUADS[tri + 4]);
            triangleList.Add(param1.QUADS[tri + 5]);
            GameManager.DAT_1f80002a++;
            GameManager.DAT_1f800028++;

            uv += 4;
            uv2++;
            tri += 6;
        }
    }

    public void AddShadows()
    {
        commandList.Add(0x13); //GameManager.DAT_1f800068.a
        float translateFactor = 16f;
        int tri = vertexList.Count;
        vertexList.Add(GameManager.DAT_1f80006c.InvertY() / translateFactor);
        vertexList.Add(GameManager.DAT_1f800074.InvertY() / translateFactor);
        vertexList.Add(GameManager.DAT_1f80007c.InvertY() / translateFactor);
        vertexList.Add(GameManager.DAT_1f800084.InvertY() / translateFactor);
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        ushort texpage = GameManager.DAT_1f80007a;
        ushort palette = GameManager.DAT_1f800072;
        bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
        int clutX = (palette & 0x3f) * 16;
        int clutY = palette >> 6;
        uv2List.Add(new Vector3((float)(clutX - 0x300) / 0x100, (float)(clutY - 0x1f6) / 2, lowColors ? 0f : 1f));
        int f = lowColors ? 4 : 2;
        int d = lowColors ? 1 : 1;
        int pageX = (texpage & 0xf) * 64 * f;
        int pageY = (texpage >> 4 & 1) * 256;
        float width = lowColors ? 0x200 : 0x100;
        float height = 0x1d0;
        int vramX = 0x380 * f;
        int vramY = 0;
        Vector2Int uv1 = new Vector2Int(GameManager.DAT_1f800070, GameManager.DAT_1f800071);
        Vector2Int uv2 = new Vector2Int(GameManager.DAT_1f800078, GameManager.DAT_1f800079);
        Vector2Int uv3 = new Vector2Int(GameManager.DAT_1f800080, GameManager.DAT_1f800081);
        Vector2Int uv4 = new Vector2Int(GameManager.DAT_1f800088, GameManager.DAT_1f800089);
        uv1.x = pageX + (uv1.x / d) - vramX;
        uv1.y = pageY + uv1.y - vramY;
        uvList.Add(new Vector2(uv1.x / width, 1f - uv1.y / height));
        uv2.x = pageX + (uv2.x / d) - vramX;
        uv2.y = pageY + uv2.y - vramY;
        uvList.Add(new Vector2(uv2.x / width, 1f - uv2.y / height));
        uv3.x = pageX + (uv3.x / d) - vramX;
        uv3.y = pageY + uv3.y - vramY;
        uvList.Add(new Vector2(uv3.x / width, 1f - uv3.y / height));
        uv4.x = pageX + (uv4.x / d) - vramX;
        uv4.y = pageY + uv4.y - vramY;
        uvList.Add(new Vector2(uv4.x / width, 1f - uv4.y / height));
        uvList.Add(new Vector2(uv3.x / width, 1f - uv3.y / height));
        uvList.Add(new Vector2(uv2.x / width, 1f - uv2.y / height));
        triangleList.Add(tri);
        triangleList.Add(tri + 1);
        triangleList.Add(tri + 2);
        triangleList.Add(tri + 3);
        triangleList.Add(tri + 2);
        triangleList.Add(tri + 1);
    }
}
