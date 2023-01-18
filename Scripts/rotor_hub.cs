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
        //check if the level is finished
        if (MyGameManager.hasfinished == 1)
        {
            //rotate the blades of the windturbine
            transform.Rotate(new Vector3(0, 0, 20) * speed * Time.deltaTime);
        }
    }
}
