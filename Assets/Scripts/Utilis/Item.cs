using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ItemProperties")]
public class Item : ScriptableObject
{
    public int itemID;
    public new string name;
    public float clicksPerSecond;
    public int currentAmount;
    public float baseCost;
    public float cost;

    public Item()
    {
        itemID = 0;
        name = "";
        clicksPerSecond = 0;
        currentAmount = 0;
        baseCost = 0;
        cost = 0;
    }

    private void OnEnable()
    {
        cost = baseCost;
        currentAmount = 0;
    }
}
