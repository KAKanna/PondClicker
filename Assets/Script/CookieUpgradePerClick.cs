using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Cookie Upgrade/Cookies per Click",fileName =  "Cookies per Click")]
public class CookieUpgradePerClick : CookieUpgrade
{
    public override void ApplyUpgrade()
    {
        PondManager.instance.ChillPerClickUpgrade += UpgradeAmount;
    }
}
