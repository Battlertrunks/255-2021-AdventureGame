using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarKeysPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the Car Keys, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[6] = true;
        InventorySystem.mainInventory.inventoryCounter++;
        SoundEffectBoard.GrabSound();

        // Destroys gameobject
        Destroy(gameObject);
    }
}
