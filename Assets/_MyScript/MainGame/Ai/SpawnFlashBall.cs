using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlashBall : MonoBehaviour
{
    public Transform postionSpawn;
 
    public Rigidbody pefabFlash;
    
    bool isSpawn;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawn)
        {
            Rigidbody rigi;
            rigi = Instantiate(pefabFlash, postionSpawn.position, postionSpawn.rotation) as Rigidbody;
            isSpawn = false;
          
        }
   

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isSpawn = true;
            ////GameObject Fb = Instantiate(pefabFlash, postionSpawn.transform.position, Quaternion.identity) as GameObject;
            SoundManager.soundManager.audioS.volume = 1f;
            SoundManager.soundManager.PlaySound(soundInGame.hit_sound);
            //Rigidbody rigi;
            //rigi = Instantiate(pefabFlash, newPostionSpawn.position, newPostionSpawn.rotation) as Rigidbody;
            Debug.Log("PlayeSpound");
        }
           
    }

    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }

   
}
