﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventLogFall : MonoBehaviour
{
    public Rigidbody[] rigi;
    public PlayableDirector playable;
    // Start is called before the first frame update
    
    

    // Update is called once per frame
    void Update()
    {
       
    }


    public void OnTriggerEnter(Collider other)
    {
        playable.Play();
        foreach (Rigidbody g in rigi)
        {
            g.useGravity = true;
            g.isKinematic = false;
        }
       
       
    }

    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }

   
}
