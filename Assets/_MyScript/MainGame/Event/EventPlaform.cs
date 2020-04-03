using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPlaform : MonoBehaviour
{
    public GameObject[] wall;
    public GameObject cctv;
    public bool isSwtichOn;
    public GameObject switchButton;
    public GameObject lightButtnOn;
    public GameObject lightButtOff;
    public GameObject thisLightOn;
    public GameObject thisLightOff;

    public GameObject[] pole;
    public GameObject[] paticelEle;
    public Material changeMat;
    //public Renderer renderer;
    bool isOff;


    // Start is called before the first frame update
    void Start()
    {
        isSwtichOn = false;
        cctv.SetActive(false);
        wall[0].SetActive(true);
        wall[1].SetActive(false);
        lightButtOff.SetActive(true);
        lightButtnOn.SetActive(false);
        switchButton.gameObject.GetComponent<Collider>().enabled = false;
        thisLightOn.SetActive(false);
        thisLightOff.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isOff)
        {
            thisLightOn.SetActive(true);
            thisLightOff.SetActive(false);
            isSwtichOn = true;
            foreach(GameObject game in paticelEle)
            {
                game.SetActive(true);
            }
            foreach (GameObject po in pole)
            {
                po.GetComponent<Renderer>().material = changeMat;

            }
            //gameObject.GetComponent<Collider>().enabled = false;
        }

        if (isSwtichOn)
        {
            lightButtOff.SetActive(false);
            lightButtnOn.SetActive(true);
            cctv.SetActive(true);
            wall[0].SetActive(false);
            wall[1].SetActive(true);
            switchButton.gameObject.GetComponent<Collider>().enabled = true;
        }

      
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        if (isOff) 
    //        {
    //            thisLightOn.SetActive(true);
    //            thisLightOff.SetActive(false);
    //            isSwtichOn = true;
    //            gameObject.GetComponent<Collider>().enabled = false;
    //        }


    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                thisLightOn.SetActive(true);
                thisLightOff.SetActive(false);
                isOff = true;
                gameObject.GetComponent<Collider>().enabled = false;
                SoundManager.soundManager.PlaySound(soundInGame.powerOn_sound);
                SoundManager.soundManager.audioS.volume = 0.3f;
                //Debug.Log(thisLightOff.activeSelf);

            }



        }
    }
}
