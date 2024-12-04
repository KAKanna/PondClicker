using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pond Upgrade/Pond per Click", fileName =  "Pond per Click")]
public class PondUpgradePerClick : PondUpgrade
{
    public override void ApplyUpgrade()
    {
        PondManager.instance.ChillPerClickUpgrade += UpgradeAmount;
    }
}
