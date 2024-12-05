using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinX2 : CoinManager
{
    public void OnChillcoinClicked() { }
    public override void OnClick()
    {
        PondManager.instance.CurrentChillCount *= 2; 
        PondManager.instance.UpdateChillUI(); 
        
    }
    
}
