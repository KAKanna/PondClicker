using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpText : MonoBehaviour
{
    [SerializeField] private float startingVelocity = 750f;
    [SerializeField] private float velocityDecayRate = 1500f;
    [SerializeField] private float timeBeforeFadeStarts = 0.6f;
    [SerializeField] private float fadeSpeed = 3f;

    private TextMeshProUGUI clickAmountText;

    private Vector2 currentVelocity;

    private Color startColor;
    private float timer;
    private float textAlpha;

    public void OnEnable()
    {
        clickAmountText = GetComponent<TextMeshProUGUI>();

        Color newColor = clickAmountText.color;
        newColor.a = 1f;
        clickAmountText.color = newColor;

        startColor = newColor;
        timer = 0f;
        textAlpha = 5f;
    }
    public static PopUpText Create(double amount)
    {
        GameObject popupObj = ObjectPoolManager.SpawnObject(PondManager.instance.pondTextPopup, PondManager.instance.MainGameCanvas.transform);
        popupObj.transform.position = PondManager.instance.MainGameCanvas.transform.position;

        PopUpText chillPopUp = popupObj.GetComponent<PopUpText>();
        chillPopUp.Init(amount);

        return chillPopUp;
    }

    public void Init(double amount)
    {
        clickAmountText.text = "+" + amount.ToString("0");

        float randomX = Random.Range(-300f, 300f);
        currentVelocity = new Vector2(randomX,startingVelocity);
    }

    private void Update()
    {
        //move
        currentVelocity.y = Time.deltaTime * velocityDecayRate;
        transform.Translate(currentVelocity * Time.deltaTime);

        //change color
        textAlpha -= Time.deltaTime * fadeSpeed;
        startColor.a = textAlpha;
        clickAmountText.color = startColor;
        if (textAlpha <= 0f)
        {
            ObjectPoolManager.ReturnObjectToPool(gameObject);
        }
    }
}
