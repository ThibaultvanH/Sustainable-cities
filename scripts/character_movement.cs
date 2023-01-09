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
    public float Gravity = 9;
    private float velocity;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (manager.gameState != MyGameManager.GameStates.Paused)
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                characterController.Move((cam.transform.right * Input.GetAxis("Horizontal") * MovementSpeed + cam.transform.forward * Input.GetAxis("Vertical") * MovementSpeed * SprintSpeed) * Time.deltaTime);
            }
            else
            {
                characterController.Move((cam.transform.right * Input.GetAxis("Horizontal") * MovementSpeed + cam.transform.forward * Input.GetAxis("Vertical") * MovementSpeed) * Time.deltaTime);
            }
            if (!characterController.isGrounded)
            {
                velocity -= Gravity * Time.deltaTime;
                characterController.Move(new Vector3(0, velocity, 0));
            }
        }
    }
}
