using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUi : MonoBehaviour
{
    public Animator anim;
    public Animator animExit;
    public GameObject startBu;
    public GameObject exitBu;
    public GameObject logo;
    public GameObject bg;
    
   
    //public float time;

    // Start is called before the first frame update
    void Start()
    {
       
        startBu.SetActive(false);
        logo.SetActive(false);
        exitBu.SetActive(false);
        bg.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(waitLogo());
        StartCoroutine(wait());

      

    }
    public void Idle()
    {
        anim.SetTrigger("Idle");
    }
    public void Click()
    {
        CheckPointControl.checkPointControl.lastCheckPos = new Vector3(-51.8f, 0.267f, -1.73f);
        anim.SetTrigger("Click");
        SoundManager.soundManager.audioS.volume = 1f;
        SoundManager.soundManager.PlaySound(soundInGame.click_sound);
    }
    public void Hover()
    {

        anim.SetTrigger("Hover");
        SoundManager.soundManager.PlaySound(soundInGame.hover_sound);
        SoundManager.soundManager.audioS.volume = 1f;

    }

    public void IdleExit()
    {
        animExit.SetTrigger("Idle");
    }
    public void ClickExit()
    {
        SoundManager.soundManager.audioS.volume = 1f;
        SoundManager.soundManager.PlaySound(soundInGame.click_sound);
        animExit.SetTrigger("Click");
    }
    public void HoverExit()
    {
        SoundManager.soundManager.PlaySound(soundInGame.hover_sound);
        SoundManager.soundManager.audioS.volume = 1f;
        animExit.SetTrigger("Hover");
    }

    IEnumerator wait()
    {
       
        yield return new WaitForSeconds(3f);
        startBu.SetActive(true);
        exitBu.SetActive(true);

    }
    IEnumerator waitLogo()
    {
     
        yield return new WaitForSeconds(1f);
        logo.SetActive(true);
       
    }
}
