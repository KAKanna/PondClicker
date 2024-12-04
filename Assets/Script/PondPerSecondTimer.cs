using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondPerSecondTimer : MonoBehaviour
{
   public float TimerDuration = 1.0f;
    public double PondperSecond {  get;  set; }
    private float _counter;
    private void Update()
    {
        _counter += Time.deltaTime;
        if (TimerDuration >= _counter )
        {
            PondManager.instance.SimplePondIncreases(PondperSecond);
        }    
    }
}
