using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryText;
    public GameObject objectiveText;

    private static float saplingCount;
    private static float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        objectiveText.GetComponent<Text>().text = "Collect all the saplings and plant the trees.";
    }

    // Update is called once per frame
    void Update()
    {
        inventoryText.GetComponent<Text>().text = $"Saplings: {saplingCount.ToString()}";
        if(score >= 10){
            objectiveText.GetComponent<Text>().text = "";
            MyGameManager.hasfinished = 1;
        }
    }
    public static float GetScore(){
        return score;
    }

    public static void AddPoint(){
        score++;
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
