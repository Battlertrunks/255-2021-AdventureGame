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
        CameraView();
        Jump();
        characterObject.Move(speed * Time.deltaTime);
    }


    void PlayerMovementControls()
    {
        float hMovement = Input.GetAxis("Horizontal");
        float vMovement = Input.GetAxis("Vertical");

        Vector3 newSpeed = (transform.right * hMovement + transform.forward * vMovement) * playerSpeed;

        speed.x = newSpeed.x;
        speed.z = newSpeed.z;
        
    }

    void CameraView()
    {
        float vLookAround = Input.GetAxis("Mouse Y");
        float hLookAround = Input.GetAxis("Mouse X");

        transform.Rotate(0, hLookAround * mouseSenSpeedX, 0);
        camsPitch += vLookAround * mouseSenSpeedY;
        camsPitch = Mathf.Clamp(camsPitch, -85, 85);

        userCam.transform.localRotation = Quaternion.Euler(camsPitch, 0, 0);

    }

    void Jump()
    {
        playerGrounded = characterObject.isGrounded;
        if (playerGrounded && speed.y < 0)
            speed.y = 0f;

        if (Input.GetButtonDown("Jump") && playerGrounded)
        {
            speed.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            print(playerGrounded);
        }

        speed.y += gravity * Time.deltaTime;
        
    }
}
