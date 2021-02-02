using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBush : MonoBehaviour
{
    // Bring in the bush trimmer object using the main ui class
    public GameObject trimmerObj;
    public void CuttingBushWithTrimmer()
    {
        // Creating local variable 
        InventoryGUI trimmerEquip = trimmerObj.GetComponent<InventoryGUI>();

        // if the player has the trimmer and has it equiped
        if (InventorySystem.mainInventory.items[0] && trimmerEquip.trimmerUsingOrNot == true)
        {
            Destroy(gameObject);
            
        }
        // Returns InventoryGUI bools 
        trimmerEquip.trimmerUsingOrNot = false;
        trimmerEquip.attempts = true;
    }
}
