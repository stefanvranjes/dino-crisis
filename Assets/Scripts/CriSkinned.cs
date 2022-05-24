using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriSkinned : CriObject
{
    public Vector3Int DAT_34_2; //0x34
    public short DAT_46; //0x46
    public CriBone skeleton; //0x4C
    public int boneCount; //0x50
    public byte DAT_5E; //0x5E
    public Tmd2ScriptableObject cSkin; //0x9C
    public Vector3Int skinSize; //0xA4
    public Color32 tint; //0xB0
    public short health; //0x118
    public short maxHealth; //0x11A
    public byte DAT_11E; //0x11E
    public short DAT_12C; //0x12C
    public bool DAT_12E; //0x12E
    public bool DAT_12F; //0x12F
    public Vector2Int DAT_13C; //0x13C
    public short DAT_140; //0x140
    public short DAT_152; //0x152
    public byte DAT_164; //0x164
    public Vector2Int shadowSize; //0x170
    public byte DAT_174; //0x174
    public byte DAT_175; //0x175
    public byte DAT_177; //0x177
    public CriBone DAT_184; //0x184
    public CriBone DAT_188; //0x188
    public bool DAT_18C; //0x18C
    public bool DAT_18D; //0x18D
    public sbyte DAT_198; //0x198
    public byte DAT_1A5; //0x1A5

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_34_2 = Vector3Int.zero;
        DAT_46 = 0;
        skeleton = null;
        boneCount = 0;
        DAT_5E = 0;
        cSkin = null;
        skinSize = Vector3Int.zero;
        tint = Color.clear;
        health = 0;
        maxHealth = 0;
        DAT_11E = 0;
        DAT_12C = 0;
        DAT_12E = false;
        DAT_12F = false;
        DAT_13C = Vector2Int.zero;
        DAT_140 = 0;
        DAT_152 = 0;
        shadowSize = Vector2Int.zero;
        DAT_174 = 0;
        DAT_175 = 0;
        DAT_177 = 0;
        DAT_184 = null;
        DAT_188 = null;
        DAT_18C = false;
        DAT_18D = false;
        DAT_198 = 0;
        DAT_1A5 = 0;
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
                    oVar2.DAT_38 = this;
                else
                    oVar2.DAT_38 = local_a0[puVar7.DAT_06];

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
                local_a0[uVar4 - 1].DAT_34 = local_a0[uVar4];
            } while (uVar4 < uVar8 - 1);
        }

        local_a0[uVar4].DAT_34 = null;
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
            oVar2 = (CriBone)oVar2.DAT_34;
        }
    }

    public void FUN_65984(int param1, int param2)
    {
        CriBone oVar1;

        DAT_18C = false;
        oVar1 = Utilities.FUN_601C8(skeleton, param1) as CriBone;
        DAT_184 = oVar1;
        oVar1 = Utilities.FUN_601C8(skeleton, param2) as CriBone;
        DAT_188 = oVar1;
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
        iVar10 = boneCount;
        cTransform.position = screen;

        do
        {
            puVar9 = m.DAT_38;

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
            iVar10++;
            m = (CriBone)m.DAT_34;
        } while (iVar10 != -1);
    }

    public void FUN_66404(byte param1, short param2, short param3)
    {
        DAT_174 = (byte)(param1 | 0x80);
        shadowSize = new Vector2Int(param2, param3);
    }
}
