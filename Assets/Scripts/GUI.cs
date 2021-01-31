using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    EventSystem eventManagement;
    public GameObject aboutScreen;

    void Start()
    {
        eventManagement = GetComponentInChildren<EventSystem>();
    }


    void Update()
    {
        if (eventManagement == null) return;

        if (eventManagement.currentSelectedGameObject == null)
            if (eventManagement.firstSelectedGameObject != null)
                eventManagement.SetSelectedGameObject(eventManagement.firstSelectedGameObject);
    }

    public void PlayBttn()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void AboutBtnn()
    {
        aboutScreen.SetActive(true);
    }

    public void BackBttn()
    {
        aboutScreen.SetActive(false);
    }

    public void QuitBttn()
    {
        Application.Quit();
    }
}
