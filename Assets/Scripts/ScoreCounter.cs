using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void clickButtonForPoints()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
