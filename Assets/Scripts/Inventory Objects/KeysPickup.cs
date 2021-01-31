using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.houseKeys = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
