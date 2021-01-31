using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBush : MonoBehaviour
{
    public void CuttingBushWithTrimmer()
    {
        if (InventorySystem.mainInventory.trimmer)
        {
            Destroy(gameObject);
        }
    }
}
