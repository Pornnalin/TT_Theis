using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PauseGame : MonoBehaviour
{
    public Animator bgPauseAnim;
    public Animator[] textAnim;
    bool isStop = false;
    int num = 0;
    public AudioSource[] audioSource;
  
    // Start is called before the first frame update
   
    void Start()
    {
        //bgPauseAnim.GetComponent<Animator>().enabled = false;
        bgPauseAnim.gameObject.SetActive(false);
        foreach(Animator anim in textAnim)
        {
            anim.gameObject.SetActive(false);
        }
     

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && num == 0) 
        {
            PasueMusicBG();
            num++;
            if (num == 1)
            {
                Time.timeScale = 0f;

                bgPauseAnim.gameObject.SetActive(true);
                foreach (Animator anim in textAnim)
                {
                    anim.gameObject.SetActive(true);
                }
                bgAnimtionOpen();
            }
            
        }
        
        //if (isStop)
        //{
        //    bgPauseAnim.GetComponent<Animator>().enabled = false;

        //    foreach (Animator anim in textAnim)
        //    {
        //        anim.GetComponent<Animator>().enabled = false;
        //    }
        //}
    }

   
    public void bgAnimtionOpen()
    {
        //isStop = false;
        bgPauseAnim.SetTrigger("Open");

        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Open");
        }
    }
    public void bgAnimtionCloseAndPlay()
    {
        
        StartCoroutine(waitToClose());

    }

    IEnumerator waitToClose()
    {
        PlayMusicBG();
        Time.timeScale = 1f;
        num = 0;
        bgPauseAnim.SetTrigger("Close");
        //isStop = true;
        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }
        yield return new WaitForSeconds(0.5f);

        foreach (Animator anim in textAnim)
        {
            anim.gameObject.SetActive(false);
        }
       
        //isStop = true;
        //foreach (Animator anim in textAnim)
        //{
        //    anim.GetComponent<Animator>().enabled = false;
        //}
        //bgPauseAnim.GetComponent<Animator>().enabled = false;

    }

    public void RestScen()
    {
        num = 0;
        Time.timeScale = 1f;
        bgPauseAnim.SetTrigger("Close");
        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }
        GameManager._gameEnd = true;
        TrasitionScene.Trasition.EndGame();

    }
    //IEnumerator waitToCloseAndToRest()
    //{
    //    yield return new WaitForSeconds(1f);
    //    //isStop = true;
    //    //foreach (Animator anim in textAnim)
    //    //{
    //    //    anim.GetComponent<Animator>().enabled = false;
    //    //}
    //    TrasitionScene.Trasition.EndGame();

    //    //bgPauseAnim.GetComponent<Animator>().enabled = false;

    //}

    public void Menu()
    {
        num = 0;
        Time.timeScale = 1f;
        TrasitionScene.Trasition.Menu();
        GameManager._gameEnd = true;

        bgPauseAnim.SetTrigger("Close");

        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }
        //StartCoroutine(waitToCloseAndToMenu());
    }

    public void Hover()
    {
        Debug.Log("Hover");
        SoundManager.soundManager.audioS.volume = 1f;
        SoundManager.soundManager.PlaySound(soundInGame.hover_sound);
    }
    public void Click()
    {
        SoundManager.soundManager.audioS.volume = 1f;
        SoundManager.soundManager.PlaySound(soundInGame.click_sound);
    }

    public void PasueMusicBG()
    {
        foreach(AudioSource audio in audioSource)
        {
            audio.Pause();
        }
    }
    public void PlayMusicBG()
    {
        foreach (AudioSource audio in audioSource)
        {
            audio.Play();
        }
    }

    //IEnumerator waitToCloseAndToMenu()
    //{
    //    yield return new WaitForSeconds(1f);

    //    TrasitionScene.Trasition.Menu();
    //    //bgPauseAnim.GetComponent<Animator>().enabled = false;

    //}

}
