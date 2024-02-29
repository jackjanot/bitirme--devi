using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adımSesleri : MonoBehaviour
{
    public AudioClip normal;
    public AudioSource audioSource;
    bool isMoving;
    Rigidbody rb;
    float zamanlayici;
    public float zaman;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }
    void Walk()
    {
        if (rb.velocity.magnitude >= 3)
        {
            isMoving = true;
            if (isMoving && Time.time > zamanlayici)
            {
                zamanlayici = Time.time + zaman;
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = normal;
                    audioSource.Play();

                }
                else
                
                    audioSource.Stop();
                
            }
        }
    }
    
}
