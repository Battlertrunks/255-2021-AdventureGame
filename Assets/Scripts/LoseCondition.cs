using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    // Declaring lostScreen and inventoryManager gameobjects to be brought in
    public GameObject lostScreen;
    public GameObject inventoryManager;

    public void LostTheGame()
    {
        // When the player loses the game, the lost game screen appears with the player's cursor to press buttons
        lostScreen.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0; // Stops game time
    }

    public void PlayAgain() // Player can press "Play Again" button to play the game again
    {
        Destroy(inventoryManager);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reloads scene
    }

    public void MainMenu() // Player can press "Main Menu" to go back to he main menu
    {
        Destroy(inventoryManager);
        SceneManager.LoadScene("MainMenu"); // Loads main menu scene
    }
}
