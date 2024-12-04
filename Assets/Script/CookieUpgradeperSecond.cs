using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cookie Upgrade/Cookies Per Second", fileName = "Cookies per Second")]
public class CookieUpgradeperSecond : CookieUpgrade
{
    public override void ApplyUpgrade()
    {
       GameObject go = Instantiate(PondManager.instance.ChillPerSecObjToSpawn,Vector3.zero, Quaternion.identity);
        go.GetComponent<PondPerSecondTimer>().PondperSecond = UpgradeAmount;

        PondManager.instance.SimplePondPerSecondIncrease(UpgradeAmount);
    }
}
