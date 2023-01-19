using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allwhite1 : MonoBehaviour
{
    public Material newMaterial;
    public Material originalMaterials;
    GameObject[] objects;

    public GameObject arrow;
   
    public GameObject points;

    // Start is called before the first frame update
    //in the start func all gameobjects will turn white.
    void Start()
    {
         objects = FindObjectsOfType<GameObject>(); // get all gameobjects in the scene


        // Iterate over all objects
        for (int i = 0; i < objects.Length; i++)
        {
            GameObject obj = objects[i];
            
            // Check if the object has a renderer component
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && obj.tag != "bottle" && obj.tag != "trash" && obj.tag != "Player")
            { 
                originalMaterials = renderer.material;
                Debug.Log(renderer.material.name);
                // Assign the new material to the renderer
                
                renderer.material = newMaterial;
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        findClossestBottle();
        bottledeposit();
        
        }

    void bottledeposit() // in this function the function is checking howmany bottles the player had put in the trash 
    {
        
        switch (points.GetComponent<bottlecount>().count)
        {
            case 0:
                break;
            case 1: // when he deposits 1 bottle the trees will have color
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "eik")
                    {
                        objects[i].GetComponent<Renderer>().material = originalMaterials;
                    }
                    }
                    
                }
                break;
            case 2:// when he deposits 2 bottles the other trees will have color
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "den")
                        {
                            objects[i].GetComponent<Renderer>().material = originalMaterials;
                        }
                    }
                }
                break;
            case 3:// when he deposits 3 bottles the houses will have color
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "house")
                        {
                            objects[i].GetComponent<Renderer>().material = originalMaterials;
                        }
                    }
                }
                break;
            case 4:// when he deposits 4 bottles the roads will have color
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "road")
                        {
                            objects[i].GetComponent<Renderer>().material = originalMaterials;
                        }
                    }
                }
                break;
            case 5:// when he deposits 5 bottles everything will have his color back
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i] != null && objects[i].GetComponent<Renderer>() != null && objects[i].GetComponent<Renderer>().tag != "bottle" && objects[i].GetComponent<Renderer>().tag != "trash" && objects[i].GetComponent<Renderer>().tag != "Player")
                    
                        objects[i].GetComponent<Renderer>().material = originalMaterials;
                    
                }
                break;
            default:
                break;
        }
        
    }

    private void findClossestBottle() // this function controlles the arrow 
    {
        GameObject[] bottles = GameObject.FindGameObjectsWithTag("bottle");

        
        float minDistance = float.MaxValue;

        
        GameObject closestBottle = null;

        foreach (GameObject bottle in bottles)
        { // finding the clossest bottle
            
            float distance = Vector3.Distance(transform.position, bottle.transform.position); // calculating the clossest bottle

            
            if (distance < minDistance)
            { 
                minDistance = distance;
                closestBottle = bottle;
                
            }
            if (distance < 4)
            {
                closestBottle = null;
            }
        }

        if (closestBottle != null)
        {
            arrow.SetActive(true);
            arrow.transform.LookAt(closestBottle.transform );// pointing the arrow to the clossest bottle
            

        }
        // If there is no closest bottle, make the arrow invisible
        else
        {
            arrow.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
