using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public Canvas BuyMenuCanvas;
    public Canvas PauseMenuCanvas;
    public bool isOpen = false;

    public void OpenBuyMenu(bool isOpen)
    {
        if (isOpen)
        {
            BuyMenuCanvas.sortingOrder = 3;
        }
        else
        {
            BuyMenuCanvas.sortingOrder = -3;
        }
    }

    public void OpenPauseMenu(bool isOpen)
    {
        if (isOpen)
        {
            PauseMenuCanvas.sortingOrder = 10;
            Time.timeScale = 0f;
            Debug.Log("Game Paused");
        }
        else
        {
            PauseMenuCanvas.sortingOrder = -10;
            Time.timeScale = 1f;
            Debug.Log("Game Unpaused");
        }
    }
}
