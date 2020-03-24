using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PauseGame : MonoBehaviour
{
    public Animator bgPauseAnim;
    public Animator[] textAnim;
    // Start is called before the first frame update
    void Start()
    {
        bgPauseAnim.GetComponent<Animator>().enabled = false;
        foreach(Animator anim in textAnim)
        {
            anim.GetComponent<Animator>().enabled = false;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
           
            bgPauseAnim.GetComponent<Animator>().enabled = true;

            foreach (Animator anim in textAnim)
            {
                anim.GetComponent<Animator>().enabled = true;
            }
            bgAnimtionOpen();
        }
    }

   
    public void bgAnimtionOpen()
    {
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
        bgPauseAnim.SetTrigger("Close");

        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }
        yield return new WaitForSeconds(1f);

        foreach (Animator anim in textAnim)
        {
            anim.GetComponent<Animator>().enabled = false;
        }
        bgPauseAnim.GetComponent<Animator>().enabled = false;

    }

    public void RestScen()
    {
        Time.timeScale = 1f;
        bgPauseAnim.SetTrigger("Close");
        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }

        StartCoroutine(waitToClose());
        
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        TrasitionScene.Trasition.Menu();
        bgPauseAnim.SetTrigger("Close");
        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }
        StartCoroutine(waitToCloseAndToMenu());
    }

    IEnumerator waitToCloseAndToRest()
    {
        yield return new WaitForSeconds(1f);

        foreach (Animator anim in textAnim)
        {
            anim.GetComponent<Animator>().enabled = false;
        }
        TrasitionScene.Trasition.EndGame();
        bgPauseAnim.GetComponent<Animator>().enabled = false;

    }
    IEnumerator waitToCloseAndToMenu()
    {
        yield return new WaitForSeconds(1f);

        foreach (Animator anim in textAnim)
        {
            anim.GetComponent<Animator>().enabled = false;
        }
        TrasitionScene.Trasition.Menu();
        bgPauseAnim.GetComponent<Animator>().enabled = false;

    }

}
