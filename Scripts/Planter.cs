using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planter : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject sapling;
    
    
    private bool spawned;
    public bool planted;
    private bool growing;
    private GameObject clonedSapling;
    
    // Start is called before the first frame update
    void Start()
    {
        spawned = false;
        growing = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Checks to see if the tree is planted
        if (planted)
        {
            if(!spawned)
            {
                // If the tree is planted but hasnt spawned yet it will clone a tree under the map, put its scale as 1% of itself and put the spawned and growing booleans to true
                clonedSapling = Instantiate(sapling, spawnPos.position, Quaternion.identity);
                clonedSapling.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                spawned = true;
                growing = true;
                Inventory.AddPoint(); // Adds a point to the score which is kept in the inventory class
            }
            else if(growing)
            {
                StartCoroutine(GrowCoroutine()); // starts the growing process of the planted tree
            }
        }
    }

    IEnumerator GrowCoroutine(){
        var num = Random.Range(5, 20);
        yield return new WaitForSeconds(num); // waits for 5 to 20 seconds to scale up the tree to its original size

        clonedSapling.transform.localScale = new Vector3(1f, 1f, 1f);
        growing = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // checks if the player entered the trigger
        {
            try 
            {
                planted = true;
                Inventory.RemoveSapling();
                Debug.Log("planted");
            } 
            catch (System.Exception exc)
            {
                Debug.Log(exc.Message); // the only exception is the sapling exception
            }
        }
    }
}
