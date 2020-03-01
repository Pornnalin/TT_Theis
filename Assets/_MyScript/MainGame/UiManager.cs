using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
   


    public void LoadNextLevel()
    {
        TrasitionScene.Trasition.NextLevel();
    }

   

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void OnTriggerEnter(Collider other)
    {
        LoadNextLevel();
    }

}

    

 

