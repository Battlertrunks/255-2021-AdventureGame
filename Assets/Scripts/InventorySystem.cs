using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Creating a Singleton design

    public bool trimmer = false, garageDoorRemote = false, houseKeys = false, food = false,
        uniform = false, workID = false, carKeys = false, coffee = false;

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
