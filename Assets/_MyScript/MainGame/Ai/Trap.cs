using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject spawnAi;
    public AudioSource soundStart;
    // Start is called before the first frame update
    void Start()
    {
        spawnAi.SetActive(false);

        soundStart.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spawnAi.SetActive(true);
            //SoundManager.soundManager.audioS.volume = 0.3f;
            //SoundManager.soundManager.PlaySound(soundInGame.hit_sound);
            soundStart.Play();
            this.gameObject.GetComponent<Collider>().enabled = false;
        }

    }
    public void OnTriggerExit(Collider other)
    {
      
    }

}
