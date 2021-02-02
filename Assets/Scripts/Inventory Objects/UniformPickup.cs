using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the Uniform, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[5] = true;
        InventorySystem.mainInventory.inventoryCounter++;

        // Destroy gameobject
        Destroy(gameObject);
    }
}
