using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    
/// <summary>
/// This class if for when the player does sound effects
/// </summary>
public class SoundEffectBoard : MonoBehaviour {

    /// <summary>
    /// This is a Singleton!
    /// </summary>
    public static SoundEffectBoard main;

    /// <summary>
    /// When the player jumps
    /// </summary>
    public AudioClip jump;

    /// <summary>
    /// Sound when the player grabs
    /// </summary>
    public AudioClip grab;

    /// <summary>
    /// Sound when the player opens the door
    /// </summary>
    public AudioClip openingDoor;

    /// <summary>
    /// Sound when the player closes the door
    /// </summary>
    public AudioClip closingDoor;

    /// <summary>
    /// Sound when the player opens and closes the garage
    /// </summary>
    public AudioClip garageDoor;

    /// <summary>
    /// Sound when the player uses the bush cutter
    /// </summary>
    public AudioClip bushCutter;

    /// <summary>
    /// Sound when the player presses UI buttons
    /// </summary>
    public AudioClip uiButtonsSFX;

    /// <summary>
    /// Sound when the player wins and clicks on the car
    /// </summary>
    public AudioClip carRunning;

    /// <summary>
    /// Creating audio source to play sounds on
    /// </summary>
    private AudioSource player;

    // Start is called before the first frame update
    void Start() {

        if (main == null) {
            main = this;
            player = GetComponent<AudioSource>();
        } else {
            Destroy(this.gameObject);
        }

    }

    /// <summary>
    /// Plays when the player jumps
    /// </summary>
    public static void PlayerJump() {
        main.player.PlayOneShot(main.jump);
    }

    /// <summary>
    /// Sound when the player grabs
    /// </summary>
    public static void GrabSound() {
        main.player.PlayOneShot(main.grab);
    }

    /// <summary>
    /// Plays when the player opens doors
    /// </summary>
    public static void DoorsSound() {
        main.player.PlayOneShot(main.openingDoor);
    }

    /// <summary>
    /// Plays when player closes a door
    /// </summary>
    public static void DoorClosingSound() {
        main.player.PlayOneShot(main.closingDoor);
    }

    /// <summary>
    /// Plays when the garage is opening or closing 
    /// </summary>
    public static void GarageSound() {
        main.player.PlayOneShot(main.garageDoor);
    }

    /// <summary>
    /// Plays the sound when the player uses the bush cutter
    /// </summary>
    public static void BushCutterSound() {
        main.player.PlayOneShot(main.bushCutter);
    }

    /// <summary>
    /// Plays when the player clicks on UI
    /// </summary>
    public static void UISound() {
        main.player.PlayOneShot(main.uiButtonsSFX);
    }

    /// <summary>
    /// Plays when the player wins clicking the car
    /// </summary>
    public static void CarRunning() {
        main.player.PlayOneShot(main.carRunning);
    }
}
