using JetBrains.Annotations;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class ItemToPainting : MonoBehaviour
{
    public Item Item;
    public PaintingControl Controller;
    public GameObject itemID;


    private void OnMouseDown()
    {
        if (ZoomCam.camOn && Item != null)
        {
            // Check if the camera is on the painting the same as the item id
            if (Item.id == ZoomCam.currentPaintingId)
            {
                FinishedPuzzle(Item);
                ItemLocationManager.Instance.AreAllPiecesPlaced();
                //if (ItemLocationManager.Instance.AreAllPiecesPlaced())
                //{
                //   //when all pieces placed do stuff
                //}
                
                InventoryManager.Instance.ListItems();
            }
            
        }
        else
        {
            Debug.LogWarning("ZoomCam is not active or the Item is not assigned.");
        }
    }

    //handles the painting pieces being placed again from the inventory 
    public void FinishedPuzzle(Item item)
    {
        GameObject paintingPos = ItemLocationManager.Instance.GetLocation(item);
        if (paintingPos == null)
        {
            Debug.LogError($"The location for item {item.itemName} is not assigned");
            return;
        }

        paintingPos.SetActive(true);
        ItemLocationManager.Instance.MarkAsPlaced(item);
        InventoryManager.Instance.Remove(item);
    }
}
