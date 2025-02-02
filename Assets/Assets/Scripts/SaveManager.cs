using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private RessourcesManager ressourcesManager;
    private UpgradeManager upgradeManager;

    public bool IsSaved = false;

    public void Start(){
        ressourcesManager = FindFirstObjectByType<RessourcesManager>();
        upgradeManager = FindFirstObjectByType<UpgradeManager>();
    }

    public void SaveGame(){

        //Ressource Manager Save
        PlayerPrefs.SetFloat("EnergyAmount", ressourcesManager.EnergyAmount);
        PlayerPrefs.SetInt("EnergyGatherAmount", ressourcesManager.EnergyGatherAmount);
        PlayerPrefs.SetInt("StoneAmount", ressourcesManager.StoneAmount);
        PlayerPrefs.SetInt("WoodAmount", ressourcesManager.WoodAmount);
        PlayerPrefs.SetInt("OreAmount", ressourcesManager.OreAmount);
        PlayerPrefs.SetInt("EnergyTransferCost", ressourcesManager.EnergyTransferCost);
        PlayerPrefs.SetInt("MinEnergy", ressourcesManager.MinEnergy);
        PlayerPrefs.SetInt("MaxEnergy", ressourcesManager.MaxEnergy);

        //Upgrade Manager Save
        PlayerPrefs.SetInt("ClickLevel", upgradeManager.ClickLevel);
        PlayerPrefs.SetFloat("ClickUpgradeCost", upgradeManager.ClickUpgradeCost);
        PlayerPrefs.SetInt("TransferLevel", upgradeManager.TransferLevel);
        PlayerPrefs.SetFloat("TransferUpgradeCost", upgradeManager.TransferUpgradeCost);
        PlayerPrefs.SetInt("AutoEnergyLevel", upgradeManager.AutoEnergyLevel);
        PlayerPrefs.SetFloat("AutoUpgradeCost", upgradeManager.AutoUpgradeCost);

        PlayerPrefs.Save();
        Debug.LogWarning("Game Saved");

        IsSaved = true;
    }

    public void LoadGame(){
        //Ressource Manager Load
        ressourcesManager.EnergyAmount = PlayerPrefs.GetFloat("EnergyAmount", ressourcesManager.EnergyAmount);
        ressourcesManager.EnergyGatherAmount = PlayerPrefs.GetInt("EnergyGatherAmount", ressourcesManager.EnergyGatherAmount);
        ressourcesManager.StoneAmount = PlayerPrefs.GetInt("StoneAmount", ressourcesManager.StoneAmount);
        ressourcesManager.WoodAmount = PlayerPrefs.GetInt("WoodAmount", ressourcesManager.WoodAmount);
        ressourcesManager.OreAmount = PlayerPrefs.GetInt("OreAmount", ressourcesManager.OreAmount);
        ressourcesManager.EnergyTransferCost = PlayerPrefs.GetInt("EnergyTransferCost", ressourcesManager.EnergyTransferCost);
        ressourcesManager.MinEnergy = PlayerPrefs.GetInt("MinEnergy", ressourcesManager.MinEnergy);
        ressourcesManager.MaxEnergy = PlayerPrefs.GetInt("MaxEnergy", ressourcesManager.MaxEnergy);

        // Upgrade Manager Load
        upgradeManager.ClickLevel = PlayerPrefs.GetInt("ClickLevel", upgradeManager.ClickLevel);
        upgradeManager.ClickUpgradeCost = PlayerPrefs.GetFloat("ClickUpgradeCost", upgradeManager.ClickUpgradeCost);
        upgradeManager.TransferLevel = PlayerPrefs.GetInt("TransferLevel", upgradeManager.TransferLevel);
        upgradeManager.TransferUpgradeCost = PlayerPrefs.GetFloat("TransferUpgradeCost", upgradeManager.TransferUpgradeCost);
        upgradeManager.AutoEnergyLevel = PlayerPrefs.GetInt("AutoEnergyLevel", upgradeManager.AutoEnergyLevel);
        upgradeManager.AutoUpgradeCost = PlayerPrefs.GetFloat("AutoUpgradeCost", upgradeManager.AutoUpgradeCost);
        ressourcesManager.UpdateTexts();
        upgradeManager.UpdateUI();

        Debug.LogWarning("Game Loaded !");

        IsSaved = false;

    }
}
