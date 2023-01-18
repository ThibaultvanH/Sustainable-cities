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
<<<<<<< HEAD
        //check if game is paused
        if (manager.gameState != MyGameManager.GameStates.Paused)
        {

            //check if shift is pressed to start sprinting
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //move character with the horizontal en vertical axis
=======
        if (manager.gameState != MyGameManager.GameStates.Paused)
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
>>>>>>> Thibault
                characterController.Move((cam.transform.right * Input.GetAxis("Horizontal") * MovementSpeed + cam.transform.forward * Input.GetAxis("Vertical") * MovementSpeed * SprintSpeed) * Time.deltaTime);
            }
            else
            {
<<<<<<< HEAD
                //move character with the horizontal en vertical axis
                characterController.Move((cam.transform.right * Input.GetAxis("Horizontal") * MovementSpeed + cam.transform.forward * Input.GetAxis("Vertical") * MovementSpeed) * Time.deltaTime);
            }
            //check of character op de grond staat
            if (!characterController.isGrounded)
            {
                //apply gravity to character in the air
=======
                characterController.Move((cam.transform.right * Input.GetAxis("Horizontal") * MovementSpeed + cam.transform.forward * Input.GetAxis("Vertical") * MovementSpeed) * Time.deltaTime);
            }
            if (!characterController.isGrounded)
            {
>>>>>>> Thibault
                velocity -= Gravity * Time.deltaTime;
                characterController.Move(new Vector3(0, velocity, 0));
            }
        }
    }
}
