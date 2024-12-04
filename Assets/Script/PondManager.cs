using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PondManager : MonoBehaviour
{
    public static PondManager instance;

    public GameObject MainGameCanvas;
    [SerializeField] private GameObject upgradeCanvas;
    [SerializeField] private TextMeshProUGUI chillCountText;
    [SerializeField] private TextMeshProUGUI chillPerSecText;
    [SerializeField] private GameObject pondObj;
    public GameObject pondTextPopup;
    [SerializeField] private GameObject backgroundObj;

    [Space]
    [SerializeField] private GameObject upgradeUIToSpawn;
    [SerializeField] private Transform upgradeUIParent;
    public GameObject ChillPerSecObjToSpawn;

    public double CurrentChillCount {  get; set; }
    public double CurrentChillPerSec { get; set; }

    //เขตอัพของ

    public double ChillPerClickUpgrade { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        UpdateChillUI();
        UpdateChillPerSecondUI();

        upgradeCanvas.SetActive(false);
        MainGameCanvas.SetActive(true);
    }

    #region On Clicked
    public void OnChillClicked()
    {
        IncreaseChill();

        pondObj.transform.DOBlendableScaleBy(new Vector3(0.10f, 0.05f, 0.10f), 0.10f).OnComplete(PondscaleBack);
        backgroundObj.transform.DOBlendableScaleBy(new Vector3(0.0f, 0.0f, 0.0f), 0.0f).OnComplete(BackgroundScaleBack);
    }

    private void PondscaleBack()
    {
        pondObj.transform.DOBlendableScaleBy(new Vector3(-0.10f, -0.05f, -0.10f), -0.10f);
    }

    private void BackgroundScaleBack()
    {
        backgroundObj.transform.DOBlendableScaleBy(new Vector3(0.00f, 0.0f, 0.0f), 0.0f);
    }

    public void IncreaseChill()
    {
        CurrentChillCount += 1 + ChillPerClickUpgrade;
        UpdateChillUI();
    }

    #endregion

    #region UI Update
    //อัพเดต
    private void UpdateChillUI()
    {
        chillCountText.text = CurrentChillCount.ToString();
    }

    private void UpdateChillPerSecondUI()
    {
        chillPerSecText.text = CurrentChillPerSec.ToString() + "Chill/S";
    }
    #endregion

    #region button presses
    public void OnUpgradeButtonpress() 
    {
        MainGameCanvas.SetActive(false);
        upgradeCanvas.SetActive(true);
    }
    public void OnResumeButtonpress() 
    {
        upgradeCanvas.SetActive(false);
        MainGameCanvas.SetActive(true);
    }
    #endregion

    #region Simple increases
    public void SimplePondIncreases(double amount)
    {
        CurrentChillCount += amount;
        UpdateChillUI();
        
    }
    public void SimplePondPerSecondIncrease(double amount)
    {
        CurrentChillCount += amount; 
        UpdateChillPerSecondUI();

    }
    #endregion
}
