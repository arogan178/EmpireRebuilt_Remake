using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public void pauseGame(bool GameIsPaused)
    {
        if (GameIsPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("Game Paused");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("Game Unpaused");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void toggleVibrate(bool Vibrate)
    {
        if (Vibrate == true)
        {
            PlayerPrefs.SetInt("Vibrate", 1);
            Debug.Log("Vibrate On");
        }
        else
        {
            PlayerPrefs.SetInt("Vibrate", 0);
            Debug.Log("Vibrate Off");
        }
    }
}
