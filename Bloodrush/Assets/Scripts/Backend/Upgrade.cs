using UnityEngine;
using System.Collections;
// ReSharper disable InconsistentNaming

public class Upgrade : MonoBehaviour {
            
    public void BuyBPM(float BPMAmount, ulong CalCost, BeatManager bm)
    {
        bm.TimeBetweenBeats(BPMAmount);
        ScoreManager.DecreaseCalories(CalCost);
    }

    public void BuyBC(ulong BCAmount, ulong O2Cost)
    {
        ScoreManager.IncreaseMult(BCAmount);
        ScoreManager.DecreaseOxygen(O2Cost);
    }

    public void BuyCAL(ulong CalAmount, ulong O2Cost, ulong O2pBCost)
    {
        ScoreManager.IncreaseCALMult(CalAmount);
        ScoreManager.DecreaseOxygen(O2Cost);
        ScoreManager.DecreaseMult(O2pBCost);
    }

}
