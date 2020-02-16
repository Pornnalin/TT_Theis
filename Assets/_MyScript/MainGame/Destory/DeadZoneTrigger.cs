using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Found ladder");
            GameManager._gameEnd = true;
            TrasitionScene.Trasition.LoadSceneCurrent();
            //GameManager._GameManager.SoundFound();
        
            //GameManager._GameManager.SpawnCase();

        }
    }

    

}
