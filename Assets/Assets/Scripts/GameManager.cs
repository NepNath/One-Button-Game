using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("TextLabels")]
    public Text TotalClickText;
    public Text UpgradeLevelText;

    float TotalClick;

    [Header("Upgrades")]
    public int UpgradeLevel;
    public int MinimumClickToUnlock;

    public void Click()
    {
        TotalClick++;
        UpdateClickText(); // Met à jour l'affichage immédiatement après un clic
    }

    public void AutoClickUpgrade()
    {
        if (TotalClick >= MinimumClickToUnlock)
        {
            TotalClick -= MinimumClickToUnlock;
            UpgradeLevel += 1;
            UpdateClickText(); // Met à jour l'affichage après un achat
        }
    }

    void Update()
    {
        if (UpgradeLevel > 0)
        {
            TotalClick += UpgradeLevel * Time.deltaTime;
            UpdateClickText();
        }
    }

    void UpdateClickText()
    {
        TotalClickText.text = TotalClick.ToString("0");
        UpgradeLevelText.text = UpgradeLevel.ToString("0");
    }
}
