using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
}
