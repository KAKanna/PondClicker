using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CookieUpgrade : ScriptableObject
{
    public float UpgradeAmount = 1f;
    public double OriginalUpgradeCost = 100;
    public double CurrentUpgradeCost = 100;
    public double CostIncreasePerPurchase = 0.05f;
    
    public string UpgradeButtonText;
    [TextArea(3,10)]
    public string UpgradeButtonDesscription;

    public abstract void ApplyUpgrade();

    private void OnValidate()
    {
        CurrentUpgradeCost = OriginalUpgradeCost;
    }


}
