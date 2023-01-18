using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotor_hub : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MyGameManager.hasfinished == 1)
        {
            //transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            transform.Rotate(new Vector3(0, 0, 20) * speed * Time.deltaTime);
        }
    }
}
