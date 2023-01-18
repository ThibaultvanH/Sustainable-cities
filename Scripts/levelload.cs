using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class CharacterMovement : MonoBehaviour
{

CharacterController player;
public float MovementSpeed;
public float Gravity;
public float Yvelocity;

private Camera cam;
public float JSpeed;

private void Start()
{
player = GetComponent();
cam = Camera.main;

}
void Update()
{
// player movement – forward, backward, left, right
float horizontal = Input.GetAxis(“Horizontal”) * MovementSpeed;
float vertical = Input.GetAxis(“Vertical”) * MovementSpeed;

if (player.isGrounded)
{
Debug.Log(“CharacterController is grounded”);
}

// Gravity
if (Input.GetKeyDown(KeyCode.Space) && player.isGrounded)
{
Debug.Log("2");
Yvelocity = JSpeed;
}

Yvelocity -= Gravity * Time.deltaTime;
player.Move(new Vector3(0, Yvelocity, 0));

player.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);

}

private void OnCollisionEnter(Collision other)
{
if (other.gameObject.tag == “Ground”)
this.gameObject.transform.parent = other.gameObject.transform;
}

}
*/