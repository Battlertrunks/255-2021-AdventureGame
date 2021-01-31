using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrimmerPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.trimmer = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
