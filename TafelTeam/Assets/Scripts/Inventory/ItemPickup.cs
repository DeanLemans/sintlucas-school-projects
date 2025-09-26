using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;

    void Pickup()
    {
        if (ZoomCam.camOn == true)
        {
            InventoryManager.Instance.Add(Item);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        Pickup();
        InventoryManager.Instance.ListItems();
    }
}
