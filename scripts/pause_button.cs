using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pause_button : MonoBehaviour
{
    MyGameManager gameManager;
    public void unpause()
    {
        gameManager.gameState = MyGameManager.GameStates.Playing;
        gameManager.pausedCanvas.SetActive(false);


    }

}
