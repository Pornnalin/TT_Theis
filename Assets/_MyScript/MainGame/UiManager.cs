using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sound;
 


    public void Update()
    {
      
    }



    public void LoadNextLevel()
    {
       
        TrasitionScene.Trasition.NextLevel();
    }

   

    public void Exit()
    {
        StartCoroutine(WaitExit());
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Wait());
            //MainPlayerController.instance.anim.SetFloat("Speed", 0);
            LoadNextLevel();
            Destroy(sound);
        }
        
    }
    IEnumerator WaitExit()
    {
        TrasitionScene.Trasition.anim.SetTrigger("End");
        //anim.SetBool("EndGame", true);
        //LoadSceneNext();
        yield return new WaitForSeconds(1.5f);
        Application.Quit();

    }

    IEnumerator Wait()
    {
        MainPlayerController.instance.anim.SetFloat("Speed", 0);
        GameManager._gameEnd = true;
        yield return new WaitForSeconds(0.5f);

    }
}

    

 

