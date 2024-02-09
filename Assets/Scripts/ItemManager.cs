using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    // public Item item;
    public TMP_Text itemName;
    public TMP_Text itemCost;
    public Item item;

    void Awake()
    {
        {
            itemName = GameObject.Find("ItemName").GetComponent<TMP_Text>();
            itemCost = GameObject.Find("ItemCost").GetComponent<TMP_Text>();
        }
    }

    void Start() { }

    public void onClick()
    {
        // item.currentAmount++;
        // itemCost.text = (item.cost * (float)Math.Pow(1.15f, item.currentAmount)).ToString();
    }
    //     // (0, "item1", 0.1f, 10, 15);
    //     // (1, "item2", 1, 0, 100);
    //     // (2, "item3", 8, 0, 1100);
    //     // (3, "item4", 47, 0, 12000);
    //     // (4, "item5", 260, 0, 130000);
    //     // (5, "item6", 1400, 0, 1400000);
    //     // (6, "item7", 7800, 0, 20000000);
    //     // (7, "item8", 44000, 0, 330000000);
    //     // (8, "item9", 260000, 0, 5100000000);
    //
}
