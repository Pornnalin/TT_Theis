﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxForStop : MonoBehaviour
{
    public Animator anim;
    public bool isStuck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            anim.speed = 0f;
            //isStuck = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
           
            anim.speed = 1f;
            //isStuck = false;
        }
    }
}
