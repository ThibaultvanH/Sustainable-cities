using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allwhite : MonoBehaviour
{
    public Material newMaterial;
    public Material oldmaterial;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects = FindObjectsOfType<GameObject>();
        Material[] originalMaterials = new Material[objects.Length];


        // Iterate over all objects
        for (int i = 0; i < objects.Length; i++)
        {
            GameObject obj = objects[i];
            
            // Check if the object has a renderer component
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && obj.tag != "bottle" && obj.tag != "trash" && obj.tag != "Player")
            {
                originalMaterials[i] = renderer.material;
                // Assign the new material to the renderer
                
                renderer.material = newMaterial;
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        findClossestBottle();
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
            arrow.transform.LookAt(closestBottle.transform);
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
