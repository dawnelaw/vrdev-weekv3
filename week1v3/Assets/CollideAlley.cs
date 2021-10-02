using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAlley : MonoBehaviour
{
    Vector3 originalPos;

    public AudioSource laneRoll;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        laneRoll = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Detect collision with floor
    void OnCollisionEnter(Collision hit)
    {

        if (hit.gameObject.tag == "lane")
        {
            laneRoll.Play();
        }
    }
}
