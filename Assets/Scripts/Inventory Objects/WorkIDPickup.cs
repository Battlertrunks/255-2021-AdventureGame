using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkIDPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.workID = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
