using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlashBall : MonoBehaviour
{
    public Transform postionSpawn;
    public GameObject flashBall;
    public Rigidbody pefabFlash;
    
    bool isSpawn;
    // Start is called before the first frame update
    void Start()
    {
        flashBall.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawn)
        {
            //Rigidbody rigi;
            flashBall.SetActive(true);
            isSpawn = false;
          
        }
   

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isSpawn = true;
            ////GameObject Fb = Instantiate(pefabFlash, postionSpawn.transform.position, Quaternion.identity) as GameObject;
            //SoundManager.soundManager.audioS.volume = 0.8f;
            //SoundManager.soundManager.PlaySound(soundInGame.hit_sound);
            //Rigidbody rigi;
            //rigi = Instantiate(pefabFlash, newPostionSpawn.position, newPostionSpawn.rotation) as Rigidbody;
            Debug.Log("PlayeSpound");
            gameObject.GetComponent<Collider>().enabled = false;
        }
           
    }

    public void OnTriggerExit(Collider other)
    {
        //gameObject.GetComponent<Collider>().enabled = false;
    }

   
}
