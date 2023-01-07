using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planter : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject sapling;
    public float growSpeed;
    
    
    private bool spawned;
    public bool planted;
    private GameObject clonedSapling;
    
    // Start is called before the first frame update
    void Start()
    {
        spawned = false;
        if (growSpeed == 0)
            growSpeed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (planted)
        {
            if(!spawned)
            {
                clonedSapling = Instantiate(sapling, spawnPos.position, Quaternion.identity);
                clonedSapling.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                spawned = true;
            }
            else 
            {
                while (clonedSapling.transform.localScale.x < 1)
                {
                    clonedSapling.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f) * Time.deltaTime * growSpeed;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            try 
            {
                Inventory.RemoveSapling();
                Debug.Log("planted");
                planted = true;
            } 
            catch (System.Exception exc)
            {
                Debug.Log(exc.Message);
            }
        }
    }
}
