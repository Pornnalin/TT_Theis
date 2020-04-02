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
     
        anim.SetTrigger("Click");
    }
    public void Hover()
    {
        anim.SetTrigger("Hover");
    }

    public void IdleExit()
    {
        animExit.SetTrigger("Idle");
    }
    public void ClickExit()
    {
        
        animExit.SetTrigger("Click");
    }
    public void HoverExit()
    {
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
