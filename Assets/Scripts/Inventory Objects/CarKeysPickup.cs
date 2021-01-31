using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarKeysPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.carKeys = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
