using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeePickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the Coffee, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[7] = true;
        InventorySystem.mainInventory.inventoryCounter++;
        SoundEffectBoard.GrabSound();

        // Destroys gameobject
        Destroy(gameObject);
    }
}
