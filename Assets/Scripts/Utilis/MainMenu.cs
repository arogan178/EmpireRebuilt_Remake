using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void toggleVibrate(bool vibrate)
    {
        if (vibrate == true)
        {
            PlayerPrefs.SetInt("vibrate", 1);
            Debug.Log("Vibrate On");
        }
        else
        {
            PlayerPrefs.SetInt("vibrate", 0);
            Debug.Log("Vibrate Off");
        }
    }
}
