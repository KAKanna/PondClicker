using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinX3 : CoinManager
{
    public void OnChillcoinClicked() { }
    public override void OnClick()
    {
        PondManager.instance.CurrentChillCount *= 3; 
        PondManager.instance.UpdateChillUI(); 
        
    }
    
}
