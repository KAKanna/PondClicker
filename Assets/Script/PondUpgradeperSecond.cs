using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pond Upgrade/Pond per Second", fileName = "Pond per Second")]
public class PondUpgradeperSecond : PondUpgrade
{
    public override void ApplyUpgrade()
    {
       GameObject go = Instantiate(PondManager.instance.ChillPerSecObjToSpawn,Vector3.zero, Quaternion.identity);
        go.GetComponent<PondPerSecondTimer>().PondperSecond = UpgradeAmount;

        PondManager.instance.SimplePondPerSecondIncrease(UpgradeAmount);
    }
}
