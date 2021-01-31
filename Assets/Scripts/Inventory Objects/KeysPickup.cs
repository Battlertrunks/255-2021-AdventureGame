using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysPickup : MonoBehaviour
{
    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.houseKeys = true;

        Destroy(gameObject);
    }
}
