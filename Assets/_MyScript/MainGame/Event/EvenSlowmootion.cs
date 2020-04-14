using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenSlowmootion : MonoBehaviour
{
    //public AudioSource audioSource;
    bool exit;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.pitch = 1f;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (exit)
        {
            StartCoroutine(waitSound());
        }
    }

    public void timeMotion()
    {
        
        Time.timeScale = 0.3f;

       

        //audioSource.pitch = 0.3f;
    }
    public void timeNormal()
    {
      
        Time.timeScale = 1f;
        //audioSource.pitch = 1f;
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SetAi"))
        {
            SoundManager.soundManager.PlaySound(soundInGame.slowAi_sound);
            SoundManager.soundManager.audioS.volume = 0.5f;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        exit = true;
       
    }

    IEnumerator waitSound()
    {
        yield return new WaitForSeconds(0.1f);
        SoundManager.soundManager.audioS.volume -= 1f * Time.deltaTime / 10f;

        //audioSource.volume = 0.1f;
        //audioSource.Stop();

    }
}
