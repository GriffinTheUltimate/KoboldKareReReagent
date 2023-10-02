using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

[System.Serializable]
public class RedDyeConsumption : ReagentConsumptionMetabolize {
    public override void OnConsume(Kobold k, ScriptableReagent scriptableReagent, ref float amountProcessed,
        ref ReagentContents reagentMemory, ref ReagentContents addBack, ref KoboldGenes genes, ref float energy) {
        base.OnConsume(k, scriptableReagent, ref amountProcessed, ref reagentMemory, ref addBack, ref genes, ref energy);
        byte Hue = genes.hue;
        float Amount = amountProcessed * 2.2f;
        int Col = 255;
        genes.hue = (byte)Mathf.Clamp(Mathf.Clamp(Amount, 1f, 4.4f) + Hue, 0, (byte)Col);
    }
}
