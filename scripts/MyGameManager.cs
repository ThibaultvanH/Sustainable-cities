using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject playingCanvas;
    public GameObject pausedCanvas;
    public GameObject finishedCanvas;
    public static float hasfinished = 0;
    public string nextlevel;

    finish finish = new finish();
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

                if (hasfinished == 1)
                {
                    gameState = GameStates.LevelFinish;
                    playingCanvas.SetActive(false);
                }
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    gameState = GameStates.Paused;
                    playingCanvas.SetActive(false);
                }
                break;
            case GameStates.Paused:
                pausedCanvas.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    gameState = GameStates.Playing;
                    pausedCanvas.SetActive(false);
                    playingCanvas.SetActive(true);
                }
                break;
            case GameStates.LevelFinish:
                finishedCanvas.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    SceneManager.LoadScene(nextlevel);
                }

                break;
        }
    }
}
