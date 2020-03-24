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
        Time.timeScale = 1f;

        bgPauseAnim.SetTrigger("Close");
        //isStop = true;
        foreach (Animator anim in textAnim)
        {
            anim.SetTrigger("Close");
        }
        yield return new WaitForSeconds(0.5f);
        //isStop = true;
        //foreach (Animator anim in textAnim)
        //{
        //    anim.GetComponent<Animator>().enabled = false;
        //}
        //bgPauseAnim.GetComponent<Animator>().enabled = false;

    }

    public void RestScen()
    {
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

   
    //IEnumerator waitToCloseAndToMenu()
    //{
    //    yield return new WaitForSeconds(1f);

    //    TrasitionScene.Trasition.Menu();
    //    //bgPauseAnim.GetComponent<Animator>().enabled = false;

    //}

}
