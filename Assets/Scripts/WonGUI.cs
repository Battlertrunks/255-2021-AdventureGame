using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class WonGUI : MonoBehaviour
{
    // Declaring an EventSystem and Gameobject to bring in
    EventSystem eventWon;
    public GameObject inventoryManager;

    void Start()
    {
        eventWon = GetComponentInChildren<EventSystem>(); // Getting EventSystem component in child and assigning it to eventWon
    }

    void Update()
    {
        // Used to navigate with the buttons

        if (eventWon == null) return;

        if (eventWon.currentSelectedGameObject == null)
            if (eventWon.firstSelectedGameObject != null)
                eventWon.SetSelectedGameObject(eventWon.firstSelectedGameObject);
    }

    public void ReturnToMainMenu() // If player presses to return to the main menu button
    {
        Destroy(inventoryManager);
        SceneManager.LoadScene("MainMenu"); // Loads the Main Menu scene
    }
}
