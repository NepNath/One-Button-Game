using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalButtonBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoBackToMainMenu()
    {
        // Load the game scene
        SceneManager.LoadScene("MainMenuScene");
    }
}
