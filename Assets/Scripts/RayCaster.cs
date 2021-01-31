using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Camera rayCam;

    // Start is called before the first frame update
    void Start()
    {
        rayCam = GetComponent<Camera>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (rayCam != null && Input.GetButtonDown("Fire1"))
        {
            Ray rayCast = new Ray(rayCam.transform.position, rayCam.transform.forward);
            RaycastHit hasBeenHit;

            if (Physics.Raycast(rayCast, out hasBeenHit))
            {
                PlayerItemPickup remote = hasBeenHit.transform.GetComponent<PlayerItemPickup>();
                if (remote != null)
                    remote.PlayerPickingUpItem();

                TrimmerPickup trimmer = hasBeenHit.transform.GetComponent<TrimmerPickup>();
                if (trimmer != null)
                    trimmer.PlayerPickingUpItem();

                KeysPickup keys = hasBeenHit.transform.GetComponent<KeysPickup>();
                if (keys != null)
                    keys.PlayerPickingUpItem();
                
                FoodPickup lunch = hasBeenHit.transform.GetComponent<FoodPickup>();
                if (lunch != null)
                    lunch.PlayerPickingUpItem();

                WorkIDPickup id = hasBeenHit.transform.GetComponent<WorkIDPickup>();
                if (id != null)
                    id.PlayerPickingUpItem();
                
                UniformPickup workClothes = hasBeenHit.transform.GetComponent<UniformPickup>();
                if (workClothes != null)
                    workClothes.PlayerPickingUpItem();

                CarKeysPickup vehicleKeys = hasBeenHit.transform.GetComponent<CarKeysPickup>();
                if (vehicleKeys != null)
                    vehicleKeys.PlayerPickingUpItem();

                CoffeePickup coffee = hasBeenHit.transform.GetComponent<CoffeePickup>();
                if (coffee != null)
                    coffee.PlayerPickingUpItem();

                DestroyBush cuttingBush = hasBeenHit.transform.GetComponent<DestroyBush>();
                if (cuttingBush != null)
                    cuttingBush.CuttingBushWithTrimmer();

                DoorMechanic doorFunction = hasBeenHit.transform.GetComponentInParent<DoorMechanic>();
                if (doorFunction != null)
                    doorFunction.PlayerInteractionWithDoor(transform.parent.position);

                GarageMechanic garageFunction = hasBeenHit.transform.GetComponentInParent<GarageMechanic>();
                if (garageFunction != null)
                    garageFunction.PlayerInteractionWithDoor(transform.parent.position);

                YouWin winCon = hasBeenHit.transform.GetComponentInParent<YouWin>();
                if (InventorySystem.mainInventory.inventoryCounter == 8 && winCon != null)
                {
                    winCon.WinCondition();
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.Confined;
                    Time.timeScale = 0;
                }
            }
        }
    }
}
