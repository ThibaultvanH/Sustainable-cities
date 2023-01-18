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
        objectiveText.GetComponent<Text>().text = "Collect all the saplings and plant the trees."; // sets the objective text
    }

    // Update is called once per frame
    void Update()
    {
        inventoryText.GetComponent<Text>().text = $"Saplings: {saplingCount.ToString()}"; // sets the sapling counter
        if(score >= 10){
            objectiveText.GetComponent<Text>().text = "";
            MyGameManager.hasfinished = 1; // if the score is higher or equal to 10 it will end the level
        }
    }
    public static float GetScore(){ // returns current score
        return score;
    }

    public static void AddPoint(){ // adds one point to the score
        score++;
    }

    public static float GetSaplingCount() // gets the amount of saplings in the inventory
    {
        return saplingCount;
    }

    public static void AddSapling() // adds one sapling to the inventory
    {
        saplingCount++;
    }
    public static void RemoveSapling() // checks if there is saplings in the inventory, then removes one if there is. if not throws an error.
    {
        if (saplingCount > 0)
            saplingCount--;
        else 
            throw new System.Exception("Negative amount of saplings");
    }
}
