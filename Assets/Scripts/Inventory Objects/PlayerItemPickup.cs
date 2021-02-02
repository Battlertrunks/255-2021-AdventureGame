using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemPickup : MonoBehaviour
{

    public void PlayerPickingUpItem()
    {
        // When player finds the Garage Remote, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[1] = true;
        InventorySystem.mainInventory.inventoryCounter++;

        // Destroyes gameobject
        Destroy(gameObject);
    }
}
