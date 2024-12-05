using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMinus : CoinManager
{    
    public override void OnClick()
    {
        PondManager.instance.CurrentChillCount /= 2; 
        PondManager.instance.UpdateChillUI(); 
        
    }
    
}
