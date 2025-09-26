using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }
    //Refresh
    public void ListItems()
    {
        //Clean Inv before open
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        foreach (Item item in Items)
        {
            //if (ZoomCam.currentPaintingId != -1 && item.id != ZoomCam.currentPaintingId)
            //{
            //    // Skip items that don't match the current painting's ID
            //    continue;
            //}
            GameObject obj = Instantiate(InventoryItem, ItemContent);

            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<SpriteRenderer>();

            itemIcon.sprite = item.icon;
            itemName.text = item.itemName;

            var itemToPainting = obj.GetComponent<ItemToPainting>();
            if (itemToPainting != null)
            {
                itemToPainting.Item = item; //dynamically link the Item
            }

            Debug.Log($"Added Item: {item.itemName}, Icon: {item.icon.name}");
        }
    }
}
