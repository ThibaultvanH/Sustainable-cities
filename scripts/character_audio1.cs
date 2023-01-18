using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class character_audio1 : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioClip audioClip2;
    private int index;
    float time;
    float timeDelay;
    // Start is called before the first frame update
    void Start()
    {
        index = 1;
        time = 0f;
        timeDelay = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timeDelay = 0.5f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            timeDelay = 0.25f;
        }
        time = time + 1f * Time.deltaTime;

        if (time >= timeDelay)
        {
            time = 0f;
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                if (audioClip)
                {
                    if (gameObject.GetComponent<AudioSource>())
                    {
                        //gameobject has audiosource
                        if (index == 1)
                        {
                            gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
                            index++;
                        }
                        else
                        {
                            gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip2);
                            index--;
                        }
                    }
                    else
                    {
                        //add audiosource to gameobject: dynamically create object with audiosource,it will remove itself
                        if (index == 1)
                        {
                            AudioSource.PlayClipAtPoint(audioClip, transform.position);
                            index++;
                        }
                        else
                        {
                            AudioSource.PlayClipAtPoint(audioClip2, transform.position);
                            index--;
                        }
                    }
                }
            }
        }

    }
}
