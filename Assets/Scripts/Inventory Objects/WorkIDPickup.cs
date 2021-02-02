using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkIDPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the Work ID, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[4] = true;
        InventorySystem.mainInventory.inventoryCounter++;

        // Destroys gameobject
        Destroy(gameObject);
    }
}
