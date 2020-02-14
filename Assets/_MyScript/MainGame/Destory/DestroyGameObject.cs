using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public GameObject FB;
    public GameObject Player;
    public GameObject par;
    public float countTime;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Collider>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        //Destroy(gameObject,2f);
    }

   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Found Player2");
            //SpawnParticle();
            GameManager._gameEnd = true;
            GameManager._GameManager.SoundFound();
            MainPlayerController.instance.anim.SetBool("IsDead", true);
            GameManager._GameManager.SpawnCase();
            this.gameObject.GetComponent<Collider>().enabled = false;

        }
        else
        {
            this.gameObject.GetComponent<Collider>().enabled = true;

        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "FB")
        {
            Destroy(FB, countTime);

        }
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Found Player");
            //SpawnParticle();
            GameManager._gameEnd = true;
            GameManager._GameManager.SoundFound();
            MainPlayerController.instance.anim.SetBool("IsDead", true);
            GameManager._GameManager.SpawnCase();
            this.gameObject.GetComponent<Collider>().enabled = false;

        }
        else
        {
            this.gameObject.GetComponent<Collider>().enabled = true;

        }
    }


    //public void SpawnParticle()
    //{
    //    GameObject _spark = Instantiate(par, transform.position, transform.rotation) as GameObject;
    //    _spark.transform.parent = MainPlayerController.instance.transform;
    //}
}