using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject playingCanvas;
    public GameObject pausedCanvas;
    public GameObject finishedCanvas;

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

                playingCanvas.SetActive(true);
                if (finish.hasfinished == true)
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
                }
                break;
            case GameStates.LevelFinish:

                finishedCanvas.SetActive(true);
                StartCoroutine(gameover());

                break;
        }
    }
    private IEnumerator gameover()
    {
        yield return waitforkeypress(KeyCode.Return);
        SceneManager.LoadScene(nextlevel);
    }

    private IEnumerator waitforkeypress(KeyCode key)
    {
        bool done = false;
        while (!done)
        {
            if (Input.GetKeyDown(key))
            {
                done = true;
            }
        }
        yield return null;
    }
}
