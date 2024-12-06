using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class CoinX2 : CoinManager
{
    [SerializeField] private AudioClip soundAwake;
    [SerializeField] private AudioClip soundEnd;

    private AudioSource audioSource;
    private bool isGone = false;
    private float time = 4;
    private int wait = 2;
    private void Start()
    {
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
        PondManager.instance.CurrentChillCount *= 2;
        PondManager.instance.UpdateChillUI();
        isGone = true;
        //Destroy(gameObject);
    }
    private void FixedUpdate()
    {
        time -= Time.deltaTime;
        if (isGone == true)
        {
            if (time <= 0)
            { Destroy(gameObject); }

        }
        else if (time <= 0)
        { Destroy(gameObject); }
    }

}
    

