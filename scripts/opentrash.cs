using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opentrash : MonoBehaviour
{
    public GameObject lid;
    public bool open;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            if (lid.transform.rotation.x > -0.8)
            {
                lid.transform.Rotate(-Vector3.right * Time.deltaTime * 80f);
            }
            
            
        }
        else
        {
            if (lid.transform.rotation.x < 0)
            {
                lid.transform.Rotate(Vector3.right * Time.deltaTime * 80f);
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            open = true;
        }
        
            
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            open = false;
        }
        

    }
}
