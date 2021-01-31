using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class WonGUI : MonoBehaviour
{
    EventSystem eventWon;
    public GameObject inventoryManager;

    void Start()
    {
        eventWon = GetComponentInChildren<EventSystem>();
    }

    void Update()
    {
        if (eventWon == null) return;

        if (eventWon.currentSelectedGameObject == null)
            if (eventWon.firstSelectedGameObject != null)
                eventWon.SetSelectedGameObject(eventWon.firstSelectedGameObject);
    }

    public void ReturnToMainMenu()
    {
        Destroy(inventoryManager);
        SceneManager.LoadScene("MainMenu");
    }
}
