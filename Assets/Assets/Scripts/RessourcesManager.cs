using UnityEngine;
using UnityEngine.UI;

public class RessourcesManager : MonoBehaviour
{
    float TotalClick;

    [Header("Stone")]
    public Text StoneAmountText;
    float StoneAmount;
    [Header("Wood")]
    public Text WoodAmountText;
    float WoodAmount;
    [Header("Ore")]
    public Text OreAmountText;
    float OreAmount;

    void Start(){
        UpdateTexts();
    }

    public void GetStone(){
        StoneAmount++;
        UpdateTexts();
    }

    public void GetWood(){
        WoodAmount++;
        UpdateTexts();
    }

    public void GetOre(){
        OreAmount++;
        UpdateTexts();
    }

    public void UpdateTexts(){
        
        StoneAmountText.text = StoneAmount.ToString("0");
        WoodAmountText.text = WoodAmount.ToString("0");
        OreAmountText.text = OreAmount.ToString("0");
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
}
