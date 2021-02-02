using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the Food, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[2] = true;
        InventorySystem.mainInventory.inventoryCounter++;

        // Destroys gameobject
        Destroy(gameObject);
    }
}
