using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrimmerPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the Bush Trimmer, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[0] = true;
        InventorySystem.mainInventory.inventoryCounter++;

        // Destroys gameobject
        Destroy(gameObject);
    }
}
