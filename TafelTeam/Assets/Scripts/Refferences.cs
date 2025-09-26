using Unity.VisualScripting;
using UnityEngine;

public class Refferences : MonoBehaviour
{
    public static Refferences Instance { get; private set; }
    public GameObject Inventory;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        //Inventory = GameObject.FindGameObjectWithTag("Inventory");
    }
    
}
