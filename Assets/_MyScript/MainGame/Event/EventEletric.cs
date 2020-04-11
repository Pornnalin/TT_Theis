using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEletric : MonoBehaviour
{
    public GameObject[] stuffEle;
    public GameObject target;
    public GameObject[] obDes;
    Rigidbody rigib;
    public Rigidbody checkPip;
    public GameObject blockWay;
    bool isPlaySound;
    // Start is called before the first frame update
    void Start()
    {
        blockWay.SetActive(false);

        rigib = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {

            SoundManager.soundManager.audioS.volume = 0.1f;
            SoundManager.soundManager.PlaySound(soundInGame.turnOff_sound);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {

            
            //rigib.Sleep();
            target.GetComponent<PushItem>().enabled = false;
            target.GetComponent<Rigidbody>().Sleep();
            checkPip.Sleep();
            //Debug.Log(rigib.IsSleeping());
            //Debug.Log(target.GetComponent<Rigidbody>().IsSleeping());
            blockWay.SetActive(true);
            //Destroy(obDes, 2f);
            foreach (GameObject game in stuffEle)
            {
                //target.GetComponent<PushItem>().enabled = false;
                game.SetActive(false);

            }

            foreach (GameObject game in obDes)
            {
                //target.GetComponent<PushItem>().enabled = false;
                Destroy(game, 0.5f);

            }

        }
    }
}
