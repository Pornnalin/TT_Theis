using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    


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
            LoadNextLevel();
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
}

    

 

