using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMovement : MonoBehaviour
{

    private CharacterController characterObject;
    private Vector3 speed;

    public float playerSpeed = 3;
    public float mouseSenSpeedX = 15;
    public float mouseSenSpeedY = 15;
    private float camsPitch = 0;

    private float jumpHeight = 2f;
    private float gravity = -9f;

    private Vector3 jump;

    private bool playerGrounded;

    private Camera userCam;

    // Start is called before the first frame update
    void Start()
    {
        characterObject = GetComponent<CharacterController>();
        userCam = GetComponentInChildren<Camera>();

        // Restricts user's cursor and hides it
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovementControls();

        if(Time.timeScale != 0) // time scale is not at zero, then the player can look around (If the game is paused or the player is looking at other menus, the camera won't move)
            CameraView();
        
        Jump();
        characterObject.Move(speed * Time.deltaTime); // Calculates the player movement using spped and delta time
    }


    void PlayerMovementControls()
    {
        float hMovement = Input.GetAxis("Horizontal"); // Gets player's horizontal input and stores it as a float
        float vMovement = Input.GetAxis("Vertical"); // Gets player's vertical input and stores it as a float

        Vector3 newSpeed = (transform.right * hMovement + transform.forward * vMovement) * playerSpeed; // Calculates playe's vector3 using the floats above

        speed.x = newSpeed.x; // stores newSpeed x and z into speed for jump to work properly.
        speed.z = newSpeed.z;
        
    }

    void CameraView()
    {
        float vLookAround = Input.GetAxis("Mouse Y"); // Gets players input of X and Y from players mouse movements and stores it to floats
        float hLookAround = Input.GetAxis("Mouse X");

        transform.Rotate(0, hLookAround * mouseSenSpeedX, 0); // Rotates camera based on players mouse movement on the X axis
        camsPitch += vLookAround * mouseSenSpeedY; // Rotates camera based on players mouse movement on the Y axis
        camsPitch = Mathf.Clamp(camsPitch, -85, 85); // Clamps rotations so camera doesn't freak out past 85 and -85

        userCam.transform.localRotation = Quaternion.Euler(camsPitch, 0, 0); // rotates the camera local rotation

    }

    void Jump()
    {
        playerGrounded = characterObject.isGrounded; // Checks to see if player is grounded
        if (playerGrounded && speed.y < 0) // If player is grounded and y axis is greater than 0
            speed.y = 0f;

        if (Input.GetButtonDown("Jump") && playerGrounded) // if the player presses space bar and playerGrounded is true
        {
            speed.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity); // Executes the jump mechanic
        }

        speed.y += gravity * Time.deltaTime; 
        
    }
}
