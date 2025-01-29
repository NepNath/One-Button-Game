using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonBehavior : MonoBehaviour
{
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
