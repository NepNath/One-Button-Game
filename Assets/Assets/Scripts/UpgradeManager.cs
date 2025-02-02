using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
//-----------------------------------------------------------------------//
    [Header("Upgrade Click")]
    public int ClickLevel;
    public Text ClickLevelText;
    public Button ClickUpgradeButton;
    public Text ClickUpgradeCostText;
    public float ClickUpgradeCost;
    public float ClickUpgradeMultiplier;
//-----------------------------------------------------------------------//
    [Header("Transfer Amount")]
    public int TransferLevel;
    public Text TransferLevelText;
    public float TransferUpgradeCost;
    public Text TransferUpgradeCostText;
    
    public Button TransferUpgradeButton;
    public float TransferUpgradeMultiplier;
//-----------------------------------------------------------------------//
    [Header("Auto Energy")]
    public int AutoEnergyLevel;
    public float AutoUpgradeCost;
    public Text AutoEnergyLevelText;
    public Text AutoUpgradeCostText;
    public Button AutoUpgradeButton;
    public float AutoUpgradeMultiplier;
//-----------------------------------------------------------------------//
    [Header("variable annexe")]
    private RessourcesManager rm;

    public void Start(){
        rm = FindFirstObjectByType<RessourcesManager>();
        UpdateUI();
    }

    public void Update(){
        UpdateUI();
        if(AutoEnergyLevel > 0){
            rm.EnergyAmount += AutoEnergyLevel * Time.deltaTime;
            UpdateUI();
        }
        rm.UpdateTexts();
    }


    public void ClickUpgrade(){
        //increase the amount of generated energy per click
         if(rm.EnergyAmount >= ClickUpgradeCost){
            rm.EnergyAmount -= ClickUpgradeCost;      
            rm.MinEnergy += 1;
            rm.MaxEnergy += 1;
            ClickLevel++;           
            ClickUpgradeCost = Mathf.CeilToInt(ClickUpgradeCost * ClickUpgradeMultiplier);               
            UpdateUI();
            rm.UpdateTexts();                      
        }
    }

    public void TransferUpgrade(){
        //Increase the amount of Void Energy used to generate basic ressources
        if (rm.EnergyAmount >= TransferUpgradeCost){
            rm.EnergyAmount -= TransferUpgradeCost;
            rm.EnergyTransferCost += 1;
            TransferLevel++;
            TransferUpgradeCost = Mathf.CeilToInt(TransferUpgradeCost * TransferUpgradeMultiplier);
            UpdateUI();
            rm.UpdateTexts();         
        }

    }

    public void AutoClick(){
        //enable and increase the amount of autoclick
        if(rm.EnergyAmount >= AutoUpgradeCost){
            rm.EnergyAmount -= AutoUpgradeCost;
            AutoEnergyLevel++;
            AutoUpgradeCost = Mathf.CeilToInt(AutoUpgradeCost * AutoUpgradeMultiplier);
            UpdateUI();
            rm.UpdateTexts();
        }
        
    }

    public void UpdateUI(){
        ClickLevelText.text = ClickLevel.ToString("0");
        TransferLevelText.text = TransferLevel.ToString("0");
        AutoEnergyLevelText.text = AutoEnergyLevel.ToString("0");
        ClickUpgradeCostText.text = ClickUpgradeCost.ToString("0");
        TransferUpgradeCostText.text = TransferUpgradeCost.ToString("0");
        AutoUpgradeCostText.text = AutoUpgradeCost.ToString("0");
        ClickUpgradeButton.interactable = rm.EnergyAmount >= ClickUpgradeCost;
        TransferUpgradeButton.interactable = rm.EnergyAmount >= TransferUpgradeCost;
        AutoUpgradeButton.interactable = rm.EnergyAmount >= AutoUpgradeCost;
    }
}
