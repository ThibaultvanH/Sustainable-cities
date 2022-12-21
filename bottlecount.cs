using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class bottlecount : MonoBehaviour
{
    public int count = 0;
    public GameObject txt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.GetComponent<TextMeshProUGUI>().text = "Bottles in the trash: " + count;
    }
}
