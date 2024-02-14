using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public List<GameObject> itemList = new List<GameObject>();
    public Item[] itemObjectList = new Item[9];
    ItemManager itemManager;

    void Awake()
    {
        // Load all ScriptableObjects of type Item
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Item"))
        {
            itemList.Add(item);
            item.AddComponent<ItemManager>(); // Attach ItemManager script
            itemList.Sort((a, b) => a.name.CompareTo(b.name));
        }
        Debug.Log("Items in List:" + itemList.Count);
    }

    void Start()
    {
        foreach (GameObject item in itemList)
        {
            ItemManager itemManager = item.GetComponent<ItemManager>();

            if (itemManager != null)
            {
                // Extract item ID from object name (adjust based on naming convention)
                int itemID = int.Parse(item.name.Substring(item.name.IndexOf('_') + 1));

                // Assuming there's a way to get the corresponding ScriptableObject based on ID

                itemManager.item = GetScriptableObjectForID(itemID);

                // Update item name and cost (assuming fields are correctly assigned)
                if (itemManager.itemName != null && itemManager.itemCost != null)
                {
                    itemManager.itemName.text = itemManager.item.name;
                    itemManager.itemCost.text = itemManager.item.cost.ToString();
                }
                else
                {
                    Debug.LogError("ItemManager is missing required text components!");
                }
            }
            else
            {
                Debug.LogError("Item " + item.name + " is missing ItemManager script!");
            }
        }
    }

    public Item GetScriptableObjectForID(int itemID)
    {
        Item itemObject = Resources.Load<Item>("Items/Item " + itemID);

        if (itemObject is Item)
        {
            return (Item)itemObject;
        }
        else
        {
            Debug.LogError("ScriptableObject with ID " + itemID + " is not of type Item!");

            return null; // or handle it differently
        }
    }
}
