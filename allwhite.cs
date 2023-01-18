using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allwhite : MonoBehaviour
{
    public Material newMaterial;
    Material[] originalMaterials;
    GameObject[] objects;

    public GameObject arrow;
   
    public GameObject points;

    // Start is called before the first frame update
    void Start()
    {
         objects = FindObjectsOfType<GameObject>();
        originalMaterials = new Material[objects.Length];


        // Iterate over all objects
        for (int i = 0; i < objects.Length; i++)
        {
            GameObject obj = objects[i];
            
            // Check if the object has a renderer component
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && obj.tag != "bottle" && obj.tag != "trash" && obj.tag != "Player")
            {
                originalMaterials[i] = renderer.material;
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

    void bottledeposit()
    {
        
        switch (points.GetComponent<bottlecount>().count)
        {
            case 0:
                break;
            case 1:
                for (int i = 0; i < originalMaterials.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "eik")
                    {
                        objects[i].GetComponent<Renderer>().material = originalMaterials[i];
                    }
                    }
                    
                }
                break;
            case 2:
                for (int i = 0; i < originalMaterials.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "den")
                        {
                            objects[i].GetComponent<Renderer>().material = originalMaterials[i];
                        }
                    }
                }
                break;
            case 3:
                for (int i = 0; i < originalMaterials.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "house")
                        {
                            objects[i].GetComponent<Renderer>().material = originalMaterials[i];
                        }
                    }
                }
                break;
            case 4:
                for (int i = 0; i < originalMaterials.Length; i++)
                {
                    if (objects[i] != null)
                    {
                        if (objects[i]?.tag == "road")
                        {
                            objects[i].GetComponent<Renderer>().material = originalMaterials[i];
                        }
                    }
                }
                break;
            case 5:
                for (int i = 0; i < originalMaterials.Length; i++)
                {
                    if (objects[i] != null && objects[i].GetComponent<Renderer>() != null && objects[i].GetComponent<Renderer>().tag != "bottle" && objects[i].GetComponent<Renderer>().tag != "trash" && objects[i].GetComponent<Renderer>().tag != "Player")
                    
                        objects[i].GetComponent<Renderer>().material = originalMaterials[i];
                    
                }
                break;
            default:
                break;
        }
        
    }

    private void findClossestBottle()
    {
        GameObject[] bottles = GameObject.FindGameObjectsWithTag("bottle");

        
        float minDistance = float.MaxValue;

        
        GameObject closestBottle = null;

        foreach (GameObject bottle in bottles)
        {
            
            float distance = Vector3.Distance(transform.position, bottle.transform.position);

            
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
            arrow.transform.LookAt(closestBottle.transform );
            

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
