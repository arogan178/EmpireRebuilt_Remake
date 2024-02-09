using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public List<GameObject> itemList = new List<GameObject>();

    void Awake()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Item"))
        {
            itemList.Add(item);
            item.AddComponent<ItemManager>(); // Attach ItemManager script
        }

        foreach (GameObject item in itemList)
        {
            ItemManager itemManager = item.GetComponent<ItemManager>();

            if (itemManager != null)
            {
                // Extract item ID from object name (adjust based on naming convention)
                int itemID = int.Parse(item.name.Substring(item.name.IndexOf('_') + 1));

                // Assuming there's a way to get the corresponding ScriptableObject based on ID
                ScriptableObject itemObject = GetScriptableObjectForID(itemID);
                if (itemObject is Item)
                {
                    itemManager.item = (Item)itemObject;
                }
                else
                {
                    Debug.LogError("GetScriptableObjectForID did not return an Item!");
                }

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

    private ScriptableObject GetScriptableObjectForID(int itemID)
    {
        // Replace with your actual logic to find the ScriptableObject
        // based on the provided itemID
        ScriptableObject item = Resources.Load<ScriptableObject>("Items/" + itemID); // Example
        return item;
    }

    void Start() { }
}
