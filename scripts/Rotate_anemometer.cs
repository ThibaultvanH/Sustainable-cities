using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_anemometer : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotate the anemometer on top of the windturbine
        transform.Rotate(new Vector3(0, 20, 0) * speed * Time.deltaTime);
    }
}
