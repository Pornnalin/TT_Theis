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
    public AudioClip em, cd, hit, footStep, glassBreak, shutter, eletric, crack, window, click, hover, alarm, powerOn, woodSmash, woodDes, slow, log, rockFall,turnOff;


    
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
            case soundInGame.countDown_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(cd);
                break;
            case soundInGame.hit_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(hit);
                break;

            case soundInGame.footStep_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(footStep);
                break;
            case soundInGame.glass_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(glassBreak);
                break;


            case soundInGame.shutter_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(shutter);
                break;


            case soundInGame.eletric_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(eletric);
                break;

            case soundInGame.crack_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(crack);
                break;

            case soundInGame.window_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(window);
                break;

            case soundInGame.click_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(click);
                break;

            case soundInGame.hover_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(hover);
                break;

            case soundInGame.alarm_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(alarm);
                break;

            case soundInGame.powerOn_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(powerOn);
                break;

            case soundInGame.woodSmash_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(woodSmash);
                break;

            case soundInGame.woodDes_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(woodDes);
                break;

            case soundInGame.slow_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(slow);
                break;

            case soundInGame.log_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(log);
                break;

            case soundInGame.rockFall_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(rockFall);
                break;

            case soundInGame.turnOff_sound:
                //audioS.volume = 1f;
                audioS.PlayOneShot(turnOff);
                break;
        }
    }


   

}


public enum soundInGame
{
    em_sound,countDown_sound,hit_sound,footStep_sound,glass_sound,
    shutter_sound,eletric_sound,crack_sound,window_sound,click_sound,hover_sound,alarm_sound,
    powerOn_sound,woodSmash_sound,woodDes_sound,slow_sound,log_sound, rockFall_sound,turnOff_sound
}


