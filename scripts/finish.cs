using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class finish : MonoBehaviour
{
    public Material newMaterial;
    public Material oldmaterial;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //check if the player ran into the pickup and his score is 4
        if (other.gameObject.tag == "Player" && count.score >= 4)
        {
            //set the gamemanager on stage finished
            MyGameManager.hasfinished = 1;

            GameObject[] objects = FindObjectsOfType<GameObject>();

            // Iterate over all objects
            foreach (GameObject obj in objects)
            {
                // Check if the object has a renderer component
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer != null && obj.tag != "pickup" && obj.tag != "windturbine" && obj.tag != "Player")
                {
                    // Assign the new material to the renderer to return to the colored state
                    renderer.material = newMaterial;
                }
            }

        }
    }

}
