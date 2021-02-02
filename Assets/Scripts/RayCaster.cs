using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Camera rayCam;


    void Start()
    {
        // Getting the player's camera
        rayCam = GetComponent<Camera>();
        
        // Setting timescale
        Time.timeScale = 1;
    }

    void Update()
    {
        if (rayCam != null && Input.GetButtonDown("Fire1"))
        {
            Ray rayCast = new Ray(rayCam.transform.position, rayCam.transform.forward);
            RaycastHit hasBeenHit;

            if (Physics.Raycast(rayCast, out hasBeenHit))
            {
                // When the player clicks on the garage remote
                PlayerItemPickup remote = hasBeenHit.transform.GetComponent<PlayerItemPickup>();
                if (remote != null)
                    remote.PlayerPickingUpItem();

                // When the player clicks on the Bush Trimmer
                TrimmerPickup trimmer = hasBeenHit.transform.GetComponent<TrimmerPickup>();
                if (trimmer != null)
                    trimmer.PlayerPickingUpItem();

                // When the player clicks on the House Keys
                KeysPickup keys = hasBeenHit.transform.GetComponent<KeysPickup>();
                if (keys != null)
                    keys.PlayerPickingUpItem();

                // When the player clicks on the Food
                FoodPickup lunch = hasBeenHit.transform.GetComponent<FoodPickup>();
                if (lunch != null)
                    lunch.PlayerPickingUpItem();

                // When the player clicks on the Work ID
                WorkIDPickup id = hasBeenHit.transform.GetComponent<WorkIDPickup>();
                if (id != null)
                    id.PlayerPickingUpItem();

                // When the player clicks on the Uniform
                UniformPickup workClothes = hasBeenHit.transform.GetComponent<UniformPickup>();
                if (workClothes != null)
                    workClothes.PlayerPickingUpItem();

                // When the player clicks on the Car Keys
                CarKeysPickup vehicleKeys = hasBeenHit.transform.GetComponent<CarKeysPickup>();
                if (vehicleKeys != null)
                    vehicleKeys.PlayerPickingUpItem();

                // When the player clicks on the Coffee
                CoffeePickup coffee = hasBeenHit.transform.GetComponent<CoffeePickup>();
                if (coffee != null)
                    coffee.PlayerPickingUpItem();

                // When the player clicks on the Bush
                DestroyBush cuttingBush = hasBeenHit.transform.GetComponent<DestroyBush>();
                if (cuttingBush != null)
                    cuttingBush.CuttingBushWithTrimmer();

                // When the player clicks on the Doors
                DoorMechanic doorFunction = hasBeenHit.transform.GetComponentInParent<DoorMechanic>();
                if (doorFunction != null)
                    doorFunction.PlayerInteractionWithDoor(transform.parent.position);

                // When the player clicks on the Garage
                GarageMechanic garageFunction = hasBeenHit.transform.GetComponentInParent<GarageMechanic>();
                if (garageFunction != null)
                    garageFunction.PlayerInteractionWithDoor(transform.parent.position);

                // When the player clicks on the Car in the garage once the player has all of the items
                YouWin winCon = hasBeenHit.transform.GetComponentInParent<YouWin>();
                if (InventorySystem.mainInventory.inventoryCounter == 8 && winCon != null)
                {
                    // Executes WinCondition, lets player use their mouse cursor, and stops the time
                    winCon.WinCondition();
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.Confined;
                    Time.timeScale = 0;
                }
            }
        }
    }
}
