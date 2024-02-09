using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text InGameScoreText;
    public TMP_Text BuyMenuScoreText;
    public int InGameScore;

    void Start()
    {
        InGameScore = 0;
        InGameScoreText.text = InGameScore.ToString();
    }

    void Update()
    {
        BuyMenuScoreText.text = InGameScoreText.text;
    }

    public void clickButtonForPoints()
    {
        InGameScore += 1;
        InGameScoreText.text = InGameScore.ToString();
    }
}
