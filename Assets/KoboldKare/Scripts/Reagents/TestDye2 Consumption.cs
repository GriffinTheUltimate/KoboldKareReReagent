using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

[System.Serializable]
public class TestDye2Consumption : ReagentConsumptionMetabolize {
    public override void OnConsume(Kobold k, ScriptableReagent scriptableReagent, ref float amountProcessed,
        ref ReagentContents reagentMemory, ref ReagentContents addBack, ref KoboldGenes genes, ref float energy) {
        base.OnConsume(k, scriptableReagent, ref amountProcessed, ref reagentMemory, ref addBack, ref genes, ref energy);
        float Hue = (float)genes.hue / 255;
        float averaged = (Hue + (float)0.07) / 2;
        float converted = (averaged * 255);
        genes.hue = (byte)converted;
    }
}
