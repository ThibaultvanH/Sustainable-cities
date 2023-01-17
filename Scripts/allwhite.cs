using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allwhite : MonoBehaviour
{
    public Material newMaterial;
    public string ignoreTag;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects = FindObjectsOfType<GameObject>();

        // Iterate over all objects
        foreach (GameObject obj in objects)
        {
            // Check if the object has a renderer component
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && obj.tag != ignoreTag)
            {
                // Assign the new material to the renderer
                renderer.material = newMaterial;
             }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
