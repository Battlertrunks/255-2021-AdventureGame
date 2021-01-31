using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.uniform = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
