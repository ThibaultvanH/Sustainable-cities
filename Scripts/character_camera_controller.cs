using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_camera_controller : MonoBehaviour
{
    public float horizontalSpeed = 2f;
    public float verticalSpeed = 2f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    public MyGameManager manager;
    Camera cam;
    //private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        //check if game is paused
        if (manager.gameState != MyGameManager.GameStates.Paused)
        {
            //rotate camera with mousemovement
            float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;
            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);
            cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
        }
    }
}
