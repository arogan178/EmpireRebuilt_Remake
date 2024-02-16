using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource buttonClickSound;

    void Start()
    {
        Button[] allButtons = GameObject.FindObjectsOfType<Button>();

        foreach (Button button in allButtons)
        {
            button.onClick.AddListener(buttonClickSound.Play);
        }
    }
}
