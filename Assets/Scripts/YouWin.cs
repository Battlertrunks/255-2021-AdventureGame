using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public GameObject youWinScreen;

    public void WinCondition()
    {
        youWinScreen.SetActive(true);
    }
}
