using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("TextLabels")]
    public Text TotalClickText;

    float TotalClick;

    [Header("Upgrades")]
    
    public Button UpgradeButton;
    public Text UpgradeLevelText;
    public Text UpgradeCostText;
    public int UpgradeLevel;
    public int MinimumClickToUnlock;

    public void Start(){
        UpdateUI();
    }
    public void Click()
    {
        TotalClick++;
        UpdateUI();
    }

    public void AutoClickUpgrade()
    {
        if (TotalClick >= MinimumClickToUnlock)
        {
            TotalClick -= MinimumClickToUnlock;
            UpgradeLevel += 1;
            AugmentUpgradeCost();
            UpdateUI();
        }
        
    }

    void Update()
    {
        if (UpgradeLevel > 0)
        {
            TotalClick += UpgradeLevel * Time.deltaTime;
            UpdateUI();
        }
    }

    
    
    

    void AugmentUpgradeCost(){
        MinimumClickToUnlock = Mathf.CeilToInt(MinimumClickToUnlock * 1.2f);
    }

    void UpdateUI(){
        TotalClickText.text = TotalClick.ToString("0");
        UpgradeLevelText.text = UpgradeLevel.ToString("0");
        UpgradeCostText.text = MinimumClickToUnlock.ToString("0");
        UpgradeButton.interactable = TotalClick >= MinimumClickToUnlock;

    }
}
