using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class MyGameManager1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject playingCanvas;
    public GameObject pausedCanvas;
    public GameObject finishedCanvas;
    public static float hasfinished = 0;
    public string nextlevel;
    public enum GameStates
    {
        Playing,
        Paused,
        LevelFinish
    }

    public GameStates gameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        hasfinished = 0;
        playingCanvas.SetActive(true);
        pausedCanvas.SetActive(false);
        finishedCanvas.SetActive(false);
        if (Player == null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }


    }

    // Update is called once per frame
    void Update()
    {
        //State machine of the game
        switch (gameState)
        {
            case GameStates.Playing:
                //if finished change the state to finished
                if (hasfinished == 1)
                {
                    gameState = GameStates.LevelFinish;
                    //set playing ui to non active
                    playingCanvas.SetActive(false);
                }
                //if paused change state to paused
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    gameState = GameStates.Paused;
                    //set playing ui to non active
                    playingCanvas.SetActive(false);
                }
                break;
            case GameStates.Paused:
                //set paused ui to active
                pausedCanvas.SetActive(true);
                //if unpaused change state to playing
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    gameState = GameStates.Playing;
                    //set paused ui to non active
                    pausedCanvas.SetActive(false);
                    //set playing ui to active
                    playingCanvas.SetActive(true);
                }
                break;
            case GameStates.LevelFinish:
                //set finished ui to active
                finishedCanvas.SetActive(true);
                //if continue pressed load next level
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    SceneManager.LoadScene(nextlevel);
                }
                break;
        }
    }
}