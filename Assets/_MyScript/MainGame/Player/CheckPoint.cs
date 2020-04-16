using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckPointControl check;
    public GameObject cpOn, cpOff;
    
    // Start is called before the first frame update
    void Start()
    {
        cpOn.SetActive(false);
        cpOff.SetActive(true);
        check = GameObject.FindGameObjectWithTag("CPC").GetComponent<CheckPointControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            check.lastCheckPos = transform.position;
            //check.lastCheckPosCamera = transform.position;
            //check.lastCheckPosCrounded = transform.position;
            gameObject.GetComponent<Collider>().enabled = false;
            SoundManager.soundManager.PlaySound(soundInGame.checkPoint_sound);
            SoundManager.soundManager.audioS.volume = 0.1f;

        }

        cpOn.SetActive(true);
        cpOff.SetActive(false);
    }
}
