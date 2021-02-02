using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    // Bring in the youWinScreen
    public GameObject youWinScreen;

    public void WinCondition() // once the WinCondition is called
    {
        // Shows the win screen
        youWinScreen.SetActive(true);
    }
}
