using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideBall : MonoBehaviour
{ 

    public AudioSource pinStrike;
  //  public AudioSource alleyRoll;


    // Start is called before the first frame update
    void Start()
    {

        pinStrike = GetComponent<AudioSource>();
   //     alleyRoll = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Detect collision with floor
    void OnCollisionEnter(Collision hit)
    {

        if (hit.gameObject.tag == "pin")
        {
            pinStrike.Play();
        }
    }
}
