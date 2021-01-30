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
                DoorMechanic doorFunction = hasBeenHit.transform.GetComponentInParent<DoorMechanic>();
                if (doorFunction != null)
                    doorFunction.PlayerInteractionWithDoor(transform.parent.position);
            }
        }
    }
}
