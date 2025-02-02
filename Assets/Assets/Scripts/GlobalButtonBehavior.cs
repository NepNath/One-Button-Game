using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalButtonBehavior : MonoBehaviour
{

    public GameObject CraftCanvas;


    void Start(){
        CraftCanvas.SetActive(false);
    }
    public void GoBackToMainMenu()
    {
        // Load the game scene
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ShowCraftCanvas(){
        //show the crafting canvas
        CraftCanvas.SetActive(true);
    }

    public void HideCraftCanvas(){
        //Hides the crafting canvas
        CraftCanvas.SetActive(false);
    }

}
