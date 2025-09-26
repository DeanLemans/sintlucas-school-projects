using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ItemLocationManager : MonoBehaviour
{
    public static ItemLocationManager Instance;

    [System.Serializable]
    public class ItemLocation
    {
        public Item item;
        public GameObject location;
        public bool isPlaced = false; 
    }

    public List<ItemLocation> itemLocations = new List<ItemLocation>();
    //start is only used for debugging, can be deleted
    private void Start()
    {
        foreach (var mapping in itemLocations)
        {
            Debug.Log($"Item in list: {mapping.item.itemName}, isPlaced = {mapping.isPlaced}");
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //checks if the gameobject has a loctaion set to it
    public GameObject GetLocation(Item item)
    {
        foreach (var bark in itemLocations)
        {
            if (bark.item == item)
                return bark.location;
        }

        Debug.LogError($"No location found for item: {item.itemName}");
        return null;
    }
   
    //marks the object as placed 
    public void MarkAsPlaced(Item item)
    {
        foreach (var mapping in itemLocations)
        {
            if (mapping.item == item)
            {
                mapping.isPlaced = true;
                Debug.Log($"Marking item {item.itemName} as placed.");
                return;
            }
        }

        Debug.LogError($"Item not found in mapping: {item.itemName}");
    }
    //checks if all pieces are placed so you can win the game
    public bool AreAllPiecesPlaced()
    {
        foreach (var meow in itemLocations)
        {
            Debug.Log($"{meow.item.itemName}: isPlaced = {meow.isPlaced}");
            if (!meow.isPlaced)
            {
                Debug.Log("Not all pieces placed yet");
                //checks if everything is placed and return false if its not
                return false; 

            }
            
        }
        SceneManager.LoadScene("Win");
        Debug.Log("all pieces placed");
        return true;
        
    }
}
