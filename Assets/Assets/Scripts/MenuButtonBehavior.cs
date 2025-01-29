using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startGame()
    {
        // Load the game scene
        SceneManager.LoadScene("MainGame");
    }

    

    public void quitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
