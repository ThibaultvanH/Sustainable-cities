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
        if (planted)
        {
            if(!spawned)
            {
                
                clonedSapling = Instantiate(sapling, spawnPos.position, Quaternion.identity);
                clonedSapling.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                spawned = true;
                growing = true;
                Inventory.AddPoint();
            }
            else if(growing)
            {
                StartCoroutine(GrowCoroutine());
            }
        }
    }

    IEnumerator GrowCoroutine(){
        var num = Random.Range(5, 20);
        yield return new WaitForSeconds(num);

        clonedSapling.transform.localScale = new Vector3(1f, 1f, 1f);
        growing = false;
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
