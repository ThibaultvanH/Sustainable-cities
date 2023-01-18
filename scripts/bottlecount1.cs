using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class bottlecount1 : MonoBehaviour
{
    public int count = 0;
    public bool inhand = false;
    public GameObject txt;
    public GameObject gamemanager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 5)
        {
            MyGameManager1.hasfinished = 1;
        }
        txt.GetComponent<TextMeshProUGUI>().text = "Bottles in the trash: " + count + "/5";
    }
}
