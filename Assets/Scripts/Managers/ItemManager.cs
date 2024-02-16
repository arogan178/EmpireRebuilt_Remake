using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemManager : MonoBehaviour
{
    public Item item;
    public TMP_Text itemName;
    public TMP_Text itemCost;
    public Button itemButton;
    ScoreManager scoreManager;

    // ShopManager shopManager;

    void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        if (itemButton != null)
        {
            itemButton.onClick.AddListener(BuyItem);
        }
        else
        {
            Debug.LogError("ItemManager is missing Button component!");
        }
    }

    void Update()
    {
        scoreManager.InGameScore += item.clicksPerSecond * item.currentAmount * Time.deltaTime;
        scoreManager.InGameScoreText.text = scoreManager.InGameScore.ToString("0.0");

        if (scoreManager.InGameScore >= item.cost)
        {
            itemButton.interactable = true;
        }
        else
        {
            itemButton.interactable = false;
        }
    }

    public void BuyItem()
    {
        if (scoreManager != null)
        {
            if (scoreManager.InGameScore >= item.cost)
            {
                scoreManager.InGameScore -= item.cost;
                scoreManager.InGameScoreText.text = scoreManager.InGameScore.ToString();
                Debug.Log("Bought " + item.name + " for " + item.cost + " points!");

                item.currentAmount++;
                item.cost = (float)
                    Math.Round(item.cost * (float)(Math.Pow(1.15f, item.currentAmount)), 1);
                itemCost.text = item.cost.ToString();
            }
            else
            {
                Debug.Log("Not enough points to buy " + item.name + "!");
            }
        }
        else
        {
            Debug.LogError("ItemManager is missing ScoreManager script!");
        }
    }

    //   Item Stats
    //   (1, "item1", 0.1f, 10, 15);
    //   (2, "item2", 1, 0, 100);
    //   (3, "item3", 8, 0, 1100);
    //   (4, "item4", 47, 0, 12000);
    //   (5, "item5", 260, 0, 130000);
    //   (6, "item6", 1400, 0, 1400000);
    //   (7, "item7", 7800, 0, 20000000);
    //   (8, "item8", 44000, 0, 330000000);
    //   (9, "item9", 260000, 0, 5100000000);
}
