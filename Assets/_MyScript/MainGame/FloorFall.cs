﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFall : MonoBehaviour
{
    public Animator anim;
    public float timeToFall;
    public GameObject rockPrefab;
    public GameObject rockFloor;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(waitToFall());
            Debug.Log("Fall!!");
        }
    }

    //public void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        //StartCoroutine(waitToFall());
    //        Debug.Log("Fall!!");
    //    }
    //}

    IEnumerator waitToFall()
    {
        yield return timeToFall;
        anim.SetBool("Fall", true);
        Destroy(rockPrefab, 1.5f);
        Destroy(rockFloor, 0.5f);
        Destroy(this.gameObject,5f);


    }

    public void PlaySoundRockFall()
    {
        SoundManager.soundManager.audioS.volume = 0.5f;
        SoundManager.soundManager.PlaySound(soundInGame.rockFall_sound);
    }
}
