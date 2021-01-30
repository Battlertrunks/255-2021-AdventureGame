using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic : MonoBehaviour
{
    public Transform doorHinge;

    // Degrees for door angle

    private float doorsAngle = 0;

    /// <summary>
    /// Animations variables for the door
    /// </summary>
    public float lengthOfAnim = 0.5f;
    private float timeOfAnim = 0;
    private bool isAnimPlaying = false;
    private bool closedOrOpen = true;

    void Update()
    {
        //Playing the animation of the door when the player clicks on it
        if (isAnimPlaying) {
            if (!closedOrOpen)
                timeOfAnim += Time.deltaTime; // These play the door animation backwards and forwards when the player interacts
            else
                timeOfAnim -= Time.deltaTime;

            float percentOfAnim = timeOfAnim / lengthOfAnim;

            if (percentOfAnim < 0 && closedOrOpen)
            {
                isAnimPlaying = false;
                percentOfAnim = 0;
            }
            else if (percentOfAnim > 1 && !closedOrOpen)
            {
                isAnimPlaying = false;
                percentOfAnim = 1;
            }

            // Setting the door's angle
            doorHinge.localRotation = Quaternion.Euler(0, doorsAngle * percentOfAnim, 0);
        }
    }

    public void PlayerInteractionWithDoor(Vector3 pos)
    {
        if (isAnimPlaying)
            return; // This executes nothing

        Vector3 playersDisToDoor = pos - transform.position;
        playersDisToDoor = playersDisToDoor.normalized;
        bool sidePlayerIsOn = (Vector3.Dot(playersDisToDoor, transform.forward) < 0f);

        closedOrOpen = !closedOrOpen;
        if (!closedOrOpen)
        {
            doorsAngle = 90;
            if (sidePlayerIsOn)
                doorsAngle = -90;
        }

        isAnimPlaying = true;
        if (closedOrOpen)
            timeOfAnim = lengthOfAnim;
        else
            timeOfAnim = 0;
    }
}
