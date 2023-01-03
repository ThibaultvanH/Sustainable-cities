using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    public GameObject scoretext;
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        setscore(0);
    }
    public void setscore(float scoretoadd)
    {
        score += scoretoadd;
        //scoretext.GetComponent<Text>().text = score.ToString("F0");
    }
    // Update is called once per frame
    void Update()
    {
        //scoretext.GetComponent<Text>().text = score.ToString("F0");
    }
}
