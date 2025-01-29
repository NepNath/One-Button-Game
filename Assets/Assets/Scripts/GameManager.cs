using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("TextLabels")]
    public Text TotalClickText;
    public Text UpgradeLevelText;
    [Header("Upgrade Button")]
    public Button UpgradeButton;
    float TotalClick;

    [Header("Upgrades")]
    public int UpgradeLevel;
    public int MinimumClickToUnlock;

    public void Start(){
        UpdateClickText(); 
        UpdateUpgradeButton();
    }
    public void Click()
    {
        TotalClick++;
        UpdateClickText(); 
        UpdateUpgradeButton();
    }

    public void AutoClickUpgrade()
    {
        if (TotalClick >= MinimumClickToUnlock)
        {
            TotalClick -= MinimumClickToUnlock;
            UpgradeLevel += 1;
            UpdateClickText();
            UpdateUpgradeButton();
        }
        
    }

    void Update()
    {
        if (UpgradeLevel > 0)
        {
            TotalClick += UpgradeLevel * Time.deltaTime;
            UpdateClickText();
            UpdateUpgradeButton();
        }
    }

    void UpdateClickText()
    {
        TotalClickText.text = TotalClick.ToString("0");
        UpgradeLevelText.text = UpgradeLevel.ToString("0");
    }
    
    void UpdateUpgradeButton(){
        UpgradeButton.interactable = TotalClick >= MinimumClickToUnlock;
    }
}
