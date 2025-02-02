using UnityEngine;
using UnityEngine.UI;

public class RessourcesManager : MonoBehaviour
{

    [Header("V. Energy")]
    public float EnergyAmount;
    public Text EnergyAmountText;
    public int EnergyGatherAmount;

    [Header("Stone")]
    public Text StoneAmountText;
    public Button StoneButton;
    public int StoneAmount;
    [Header("Wood")]
    public Text WoodAmountText;
    public Button WoodButton;
    public int WoodAmount;
    [Header("Ore")]
    public Text OreAmountText;
    public Button OreButton;
    public int OreAmount;
    [Header("Upgrade & Transfers")]
    public int EnergyTransferCost;
    

    void Start(){
        UpdateTexts();
    }

    public void GetEnergy(){
        EnergyAmount += EnergyGatherAmount;
        UpdateTexts();
    }

    public void GetStone(){
        if(EnergyAmount >= EnergyTransferCost){
            EnergyAmount -= EnergyTransferCost;
            StoneAmount += EnergyTransferCost;
        }
        
        UpdateTexts();
    }

    public void GetWood(){
        if(EnergyAmount >= EnergyTransferCost){
            EnergyAmount -= EnergyTransferCost;
            WoodAmount += EnergyTransferCost;
        }
        UpdateTexts();
    }

    public void GetOre(){
        if(EnergyAmount >= EnergyTransferCost){
            EnergyAmount -= EnergyTransferCost;
            OreAmount += EnergyTransferCost;
        }
        
        UpdateTexts();
    }

    public void UpdateTexts(){
        
        StoneAmountText.text = StoneAmount.ToString("0");
        WoodAmountText.text = WoodAmount.ToString("0");
        OreAmountText.text = OreAmount.ToString("0");
        EnergyAmountText.text = EnergyAmount.ToString("0");
        StoneButton.interactable = EnergyAmount >= EnergyTransferCost;
        WoodButton.interactable = EnergyAmount >= EnergyTransferCost;
        OreButton.interactable = EnergyAmount >= EnergyTransferCost;
        
    }
  
}
