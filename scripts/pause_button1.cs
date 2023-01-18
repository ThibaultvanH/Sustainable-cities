using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pause_button1 : MonoBehaviour
{
    public GameObject GameManager;
    public void unpause()
    {
        GameManager.GetComponent<MyGameManager1>().gameState = MyGameManager1.GameStates.Playing;
        GameManager.GetComponent<MyGameManager1>().pausedCanvas.SetActive(false);
        GameManager.GetComponent<MyGameManager1>().playingCanvas.SetActive(true);
    }

}
