using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even_Light : MonoBehaviour
{
    public GameObject scen_1;
   
    // Start is called before the first frame update
    void Start()
    {
        scen_1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scen_1.SetActive(true);
            gameObject.GetComponent<Collider>().enabled = false;

            //SoundManager.soundManager.audioS.volume = 1f;
            //SoundManager.soundManager.PlaySound(soundInGame.hit_sound);
           
        }
    }

    
}
