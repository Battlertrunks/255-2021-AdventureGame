using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    
/// <summary>
/// This class if for when the player, minion, and boss does sound effect actions
/// </summary>
public class SoundEffectBoard : MonoBehaviour {

    /// <summary>
    /// This is a Singleton!
    /// </summary>
    public static SoundEffectBoard main;

    /// <summary>
    /// When the player shoots
    /// </summary>
    public AudioClip jump;

    /// <summary>
    /// Sound when the player dies
    /// </summary>
    public AudioClip grab;

    /// <summary>
    /// Sound when the player shoots the rocket
    /// </summary>
    public AudioClip openingDoor;

    public AudioClip closingDoor;

    /// <summary>
    /// Sound when the player hurts themself
    /// </summary>
    public AudioClip garageDoor;

    /// <summary>
    /// Sound when the player dashes
    /// </summary>
    public AudioClip bushCutter;

    /// <summary>
    /// Sound when the boss dies
    /// </summary>
    public AudioClip uiButtonsSFX;

    /// <summary>
    /// Sound when the boss is shooting
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
    /// Plays when the player shoots
    /// </summary>
    public static void PlayerJump() {
        main.player.PlayOneShot(main.jump);
    }

    /// <summary>
    /// Sound when the boss shoots
    /// </summary>
    public static void GrabSound() {
        main.player.PlayOneShot(main.grab);
    }

    /// <summary>
    /// Plays when the player shoots the rocket
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
    /// Plays the sound death file when the player dies
    /// </summary>
    public static void GarageSound() {
        main.player.PlayOneShot(main.garageDoor);
    }

    /// <summary>
    /// Plays the sound when the player takes damage
    /// </summary>
    public static void BushCutterSound() {
        main.player.PlayOneShot(main.bushCutter);
    }

    /// <summary>
    /// Plays when the player is dashing
    /// </summary>
    public static void UISound() {
        main.player.PlayOneShot(main.uiButtonsSFX);
    }

    /// <summary>
    /// Plays when the boss dies
    /// </summary>
    public static void CarRunning() {
        main.player.PlayOneShot(main.carRunning);
    }
}
