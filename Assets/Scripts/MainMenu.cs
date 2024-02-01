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

    public void Settings()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
