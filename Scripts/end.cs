using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public Material newMaterial;

    private GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj = FindObjectsOfType<GameObject>();
        // applies textures to the objects if 10/20/30/... % of sapligns are planted
        switch (Inventory.GetScore())
        {
            case 1:
                for (int i = 0; i < obj.Length / 10; i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 2: 
                for (int i = 0; i < 2 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 3: 
                for (int i = 0; i < 3 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 4: 
                for (int i = 0; i < 4 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 5: 
                for (int i = 0; i < 5 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 6: 
                for (int i = 0; i < 6 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 7: 
                for (int i = 0; i < 7 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 8: 
                for (int i = 0; i < 8 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 9: 
                for (int i = 0; i < 9 * (obj.Length / 10); i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
            case 10: 
                for (int i = 0; i < obj.Length; i++)
                {
                    Renderer r = obj[i].GetComponent<Renderer>();
                    if(r != null && obj[i].tag != "Player")
                        r.material = newMaterial;
                }
                break;
        }
    }
}
