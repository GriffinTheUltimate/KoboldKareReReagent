using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

[System.Serializable]
public class PotassiumConsumption : ReagentConsumptionMetabolize {
    public override void OnConsume(Kobold k, ScriptableReagent scriptableReagent, ref float amountProcessed,
        ref ReagentContents reagentMemory, ref ReagentContents addBack, ref KoboldGenes genes, ref float energy) {
        base.OnConsume(k, scriptableReagent, ref amountProcessed, ref reagentMemory, ref addBack, ref genes, ref energy);
        genes.dickThickness+= amountProcessed/200;
    }
}
