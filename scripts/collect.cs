using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class collect : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioClip audioClip2;
    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (audioClip)
            {
                if (gameObject.GetComponent<AudioSource>())
                {
                    //gameobject has audiosource
                    gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
                }
                else
                {

                    //add audiosource to gameobject: dynamically create object with audiosource,it will remove itself
                    AudioSource.PlayClipAtPoint(audioClip, transform.position);
                }
            }
            count.score += 1;
            Destroy(gameObject);
        }
    }
}