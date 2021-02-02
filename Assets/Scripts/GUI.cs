using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    // Instantiating a EventSystem and Gameobject
    EventSystem eventManagement;
    public GameObject aboutScreen;

    void Start()
    {
        // Getting the EventSystem
        eventManagement = GetComponentInChildren<EventSystem>();
    }


    void Update()
    {
        if (eventManagement == null) return; // if player clicks nothing

        if (eventManagement.currentSelectedGameObject == null)
            if (eventManagement.firstSelectedGameObject != null)
                eventManagement.SetSelectedGameObject(eventManagement.firstSelectedGameObject);
    }

    public void PlayBttn() // If player presses the play button, it will load and play the game
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void AboutBtnn() // If player presses the about button, it will open the about screen
    {
        aboutScreen.SetActive(true);
    }

    public void BackBttn() // If player presses the back button on the about screen, it will set the aboutscreen's active to false
    {
        aboutScreen.SetActive(false);
    }

    public void QuitBttn() // If player presses the quit button, the application ends
    {
        Application.Quit();
    }
}
