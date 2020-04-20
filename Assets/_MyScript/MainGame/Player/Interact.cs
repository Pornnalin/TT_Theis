﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interact : MonoBehaviour
{
    //public GameObject texFist;
    //public TextMeshProUGUI _press;
    bool isShowText;
    //public GameObject texSceond;
    //public static Interact _interact;
    public  bool isPressE;
    public Material switchColor;
    // Start is called before the first frame update

    void Start()
    {
        //texFist.SetActive(false);
        //texSceond.SetActive(false);

        isPressE = false;
        


    }

    //public void Awake()
    //{
    //    if (_interact == null)
    //    {
    //        _interact = this;
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }

       
    //}
    // Update is called once per frame
    void Update()
    {
        if (isShowText)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                StartCoroutine(wait());
                isPressE = true;
                isShowText = false;


            }
        }
        if (isPressE)
        {
            
            gameObject.GetComponent<Renderer>().material = switchColor;
            this.gameObject.GetComponent<Collider>().enabled = false;
            //texSceond.SetActive(false);


        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            
            //texSceond.SetActive(true);
            isShowText = true;
            //gameObject.GetComponent<Collider>().enabled = false;



        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //texSceond.SetActive(true);
            Debug.Log("Press E");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Out");
        //texSceond.SetActive(false);

        //texFist.SetActive(false);
      

    }

    IEnumerator wait()
    {
        SoundManager.soundManager.PlaySound(soundInGame.powerOn_sound);
        SoundManager.soundManager.audioS.volume = 0.1f;
        yield return new WaitForSeconds(0.5f);
       

    }
}
