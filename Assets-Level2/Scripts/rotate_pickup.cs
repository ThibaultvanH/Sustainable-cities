using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_pickup : MonoBehaviour
{
    public GameObject hand;
    public bool Rotate = true;
    public bool pickup;
    public bool drop;
    public GameObject txt;
    public Transform endPoint;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {


        // start moving the object along the parabola

    }

    // Update is called once per frame
    void Update()
    {
        if (pickup)
        {
            transform.position = hand.transform.position;
            transform.rotation = hand.transform.rotation;
            transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);

            if (Input.GetKeyDown(KeyCode.D))
            {
                pickup = false;
                drop = true;
                txt.GetComponent<bottlecount>().count += 1;
            }

        }
        else if (drop)
        {

            Vector3 direction = endPoint.position - transform.position;

            // Normalize the direction to get a unit vector (a vector with a length of 1)
            direction.Normalize();

            // Move the object towards the target point at the specified speed
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);

            Invoke("DestroyObject", 5f);



        }
        else if (Rotate)
        {
            transform.RotateAround(transform.position, Vector3.up, 40f * Time.deltaTime);
        }

    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Rotate)
        {
            pickup = true;
            Rotate = false;
        }


    }
}
