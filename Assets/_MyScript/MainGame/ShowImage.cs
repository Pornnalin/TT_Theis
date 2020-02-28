using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImage : MonoBehaviour
{
    public GameObject imageRed;
    bool isStay;
    // Start is called before the first frame update
    void Start()
    {
        imageRed.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (isStay)
        //{
        //    StartCoroutine(waitForSound());
        //    isStay = false;
        //}
    }
    public void OnTriggerEnter(Collider other)
    {
        isStay = true;
    }
    private void OnTriggerStay(Collider other)
    {
        imageRed.gameObject.SetActive(true);
     
        
    }

    private void OnTriggerExit(Collider other)
    {
        imageRed.gameObject.SetActive(false);
        //isStay = false;
        //gameObject.GetComponent<Collider>().enabled = false;
    }
    IEnumerator waitForSound()
    {
        yield return new WaitForSeconds(2f);
        SoundManager.soundManager.audioS.volume = 1f;
        SoundManager.soundManager.PlaySound(soundInGame.shutter_sound);
    }
}
