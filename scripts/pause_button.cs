using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pause_button : MonoBehaviour
{
    public GameObject GameManager;
    public void unpause()
    {
        GameManager.GetComponent<MyGameManager>().gameState = MyGameManager.GameStates.Playing;
        GameManager.GetComponent<MyGameManager>().pausedCanvas.SetActive(false);
        GameManager.GetComponent<MyGameManager>().playingCanvas.SetActive(true);
    }

}
