using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public GameObject scoretext;
    public GameObject objective;
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        setscore(0);
        objective.GetComponent<Text>().text = "Collect 4 gears to repair the windturbine.";
    }
    public void setscore(float scoretoadd)
    {
        score += scoretoadd;
        scoretext.GetComponent<Text>().text = score.ToString("F0");
    }
    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<Text>().text = score.ToString("F0");
        if (score == 4)
        {
            objective.GetComponent<Text>().text = "Good job! Now you can repair the windturbine in the forest.";
        }
    }
}
