using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeePickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.coffee = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
