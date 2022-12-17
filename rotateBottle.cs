using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBottle : MonoBehaviour
{
    public GameObject hand;
    public bool Rotate =true;
    public bool pickup;
    public bool drop;
    
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

        }
        else if (drop)
        {

            Vector3 direction = endPoint.position - transform.position;

            // Normalize the direction to get a unit vector (a vector with a length of 1)
            direction.Normalize();

            // Move the object towards the target point at the specified speed
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);





        }
        else if (Rotate)
        {
            transform.RotateAround(transform.position, Vector3.up, 40f * Time.deltaTime);
        }
        
    }
    
        
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Rotate)
        {
            Debug.Log("hit");
            pickup = true;
            Rotate = false;
        }

        
    }
}
