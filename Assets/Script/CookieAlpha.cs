using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieAlpha : MonoBehaviour
{
    private Image head_pond;
    private void Awake()
    {
        head_pond = gameObject.AddComponent<Image>();
        head_pond.alphaHitTestMinimumThreshold = 0.001f;
    }
}
