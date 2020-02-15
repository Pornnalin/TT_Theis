using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;
    [HideInInspector]
    public AudioSource audioS;
    public AudioClip em,cd;


    
    public void Awake()
    {
        if (soundManager == null)
        {
            soundManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        audioS = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        audioS.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(soundInGame sound)
    {
        switch (sound)
        {
            case soundInGame.em_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(em);
                    break;
            case soundInGame.countDown:
                //audioS.volume = 1f;
                audioS.PlayOneShot(cd);
                break;
        }
    }


   

}


public enum soundInGame
{
    em_sound,countDown
}


