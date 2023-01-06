using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static float saplingCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static float GetSaplingCount()
    {
        return saplingCount;
    }

    public static void AddSapling()
    {
        saplingCount++;
    }
    public static void RemoveSapling()
    {
        if (saplingCount > 0)
            saplingCount--;
        else 
            throw new System.Exception("Negative amount of saplings");
    }
}
