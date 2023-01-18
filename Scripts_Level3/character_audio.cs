using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class character_audio : MonoBehaviour
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
        //create small delay between footsteps
        timeDelay = 0.5f;
        //if character is sprinting reduce the interval time
        if (Input.GetKey(KeyCode.LeftShift))
        {
            timeDelay = 0.25f;
        }
        time = time + 1f * Time.deltaTime;

        if (time >= timeDelay)
        {
            time = 0f;
            //check if character is moving
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                //check if audioclip exists
                if (audioClip)
                {
                    //check if an audiosource exists on the gameobject
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
