using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Creating a Singleton design that makes a inventory system

    public List<bool> items; // A List of the items that the player and abtain

    public int inventoryCounter = 0;

    private static InventorySystem _mainInventory;
    public static InventorySystem mainInventory
    {
        get
        {
            return _mainInventory;
        }
    }
    
    private void Start()
    {
        if (_mainInventory == null)
        {
            _mainInventory = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }


}
