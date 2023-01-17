using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float rotateSpeed;
    public float bobSpeed;
    public AudioClip audioClip;

    private bool pickedUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pickedUp)
        {
            transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
            float y = 0.5f + (0.2f * Mathf.Sin(Time.time * bobSpeed));
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
        else {
            if(audioClip){
                if(gameObject.GetComponent<AudioSource>())
                    gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
                else
                    AudioSource.PlayClipAtPoint(audioClip, transform.position);
            }
            Inventory.AddSapling();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("picked up");
            pickedUp = true;
        }
    }
}
