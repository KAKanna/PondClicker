using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinX3 : CoinManager
{
    [SerializeField] private AudioClip soundAwake;
    [SerializeField] private AudioClip soundEnd;
    private bool isGone = false;
    private float time = 4;
    private AudioSource audioSource;
    private void Start()
    {
        AudioSource newAudioSource = gameObject.AddComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();
    

        if (soundAwake != null)
        {
            audioSource.PlayOneShot(soundAwake);
        }

       

    }

    public override void OnClick()
    {
        time = 0.1f;
        audioSource.PlayOneShot(soundEnd);           
        PondManager.instance.CurrentChillCount *= 3;
        PondManager.instance.UpdateChillUI();
        isGone = true;

    }
    private void FixedUpdate()
    {
        time -= Time.deltaTime;
        if (isGone == true)
        {
            if (time <= 0) 
            { Destroy(gameObject); }
            
        }
        else if(time <= 0)
            { Destroy(gameObject); }
    }

}
