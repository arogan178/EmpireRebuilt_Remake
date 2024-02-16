using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public void pauseGame(bool GameIsPaused) { }

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
