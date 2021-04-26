using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        // When player finds the house keys, it puts it into you inventory and increments you item amount
        InventorySystem.mainInventory.items[3] = true;
        InventorySystem.mainInventory.inventoryCounter++;
        SoundEffectBoard.GrabSound();

        // Destroys key
        Destroy(gameObject);
    }
}
