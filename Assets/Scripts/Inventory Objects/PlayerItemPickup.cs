using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemPickup : MonoBehaviour
{

    public void PlayerPickingUpItem()
    {
        InventorySystem.mainInventory.garageDoorRemote = true;

        Destroy(gameObject);
    }
}
