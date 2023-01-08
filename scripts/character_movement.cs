using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_movement : MonoBehaviour
{
    CharacterController characterController;
    public Camera cam;
    public MyGameManager manager;
    public float MovementSpeed = 1;
    public float SprintSpeed = 1;
    //public float JumpSpeed = 3;
    private float Yvelocity;
    public float Gravity = 9.8f;
    private float velocity = 0;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (manager.gameState != MyGameManager.GameStates.Paused)
        {
            float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
            float vertical = Input.GetAxis("Vertical") * MovementSpeed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical * SprintSpeed) * Time.deltaTime);
            }
            else
            {
                characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);
            }

            if (characterController.isGrounded)
            {
                velocity = 0;
            }
            else
            {
                velocity -= Gravity * Time.deltaTime;
                characterController.Move(new Vector3(0, velocity, 0));
            }
            /*
            if (characterController.isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Physics.gravity * (JumpSpeed - 1) * rb.mass);
            }
            */



        }
    }
}
