using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.food = true;
        InventorySystem.mainInventory.inventoryCounter++;

        Destroy(gameObject);
    }
}
