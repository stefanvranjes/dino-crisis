using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriSkinned : CriObject
{
    public CriBone skeleton; //0x4C
    public int boneCount; //0x50
    public byte DAT_5E; //0x5E
    public Tmd2ScriptableObject cSkin; //0x9C
    public Vector3Int skinSize; //0xA4
    public Color32 tint; //0xB0
    public Vector2Int shadowSize; //0x170
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
        skeleton = null;
        boneCount = 0;
        DAT_5E = 0;
        cSkin = null;
        skinSize = Vector3Int.zero;
        tint = Color.clear;
        shadowSize = Vector2Int.zero;
        DAT_198 = 0;
        DAT_1A5 = 0;
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

            if (m.DAT_43 == 0)
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
}
