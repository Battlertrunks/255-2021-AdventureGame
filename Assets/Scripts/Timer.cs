using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeLimit = 900; // Setting time limit that the player has
    public Text clock; // Test for the time to count down

    public bool timeEnded = false; // bool for when the time is over

    void Update()
    {
        if (!timeEnded) // if time did not end
        {
            if (timeLimit > 0)
            {
                timeLimit -= Time.deltaTime; // counts time down
                ShowTime(timeLimit); // call function ShowTime and sends argument float timeLimit
            }

            else
            {
                timeLimit = 0f; // assigns timeLimit to 0
                LoseCondition lost = transform.GetComponent<LoseCondition>(); // Create local variable lost to run LoseCondition Class functions
                lost.LostTheGame(); // Calls LostTheGame
            }
        }
    }

    void ShowTime(float timeLimitDisplay) // Calculates the time
    {
        timeLimitDisplay++;

        float minutes = Mathf.FloorToInt(timeLimitDisplay / 60); // Calculates minutes
        float seconds = Mathf.FloorToInt(timeLimitDisplay % 60); // Calculates seconds

        clock.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Formats the layout
    }
}
