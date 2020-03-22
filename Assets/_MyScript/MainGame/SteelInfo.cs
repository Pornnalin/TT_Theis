using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteelInfo : MonoBehaviour
{
    //public GameObject blockWay;
    public GameObject deadZone;
    public GameObject deadZoneSec;
    public GameObject box;
    public bool isPlayerStay;
    public float time;
    public Animator anim;
    public EventBoxFall boxFall;
    //public GameObject ai;

    // Start is called before the first frame update
    void Start()
    {
        //blockWay.SetActive(false);
        deadZone.SetActive(false);
        deadZoneSec.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerStay)
        {
            StartCoroutine(wait());
        }
       
    }
    //public void OpenBlock()
    //{
    //    blockWay.SetActive(true);

    //}
    //public void CloseBlock()
    //{
    //    blockWay.SetActive(false);
    //}

    //public void OpendeadZone()
    //{
    //    deadZone.SetActive(true);

    //}

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerStay = true;
            Destroy(box);
            gameObject.GetComponent<Collider>().enabled = false;
            boxFall.GetComponent<EventBoxFall>().enabled = false;

        }
        else
        {
            isPlayerStay = false;
        }

    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Box"))
    //    {


    //    }


    //}
    public void OnTriggerExit(Collider other)
    {
        isPlayerStay = false;
        Debug.Log("out");

    }
    IEnumerator wait()
    {
        //Destroy(ai);
        anim.SetBool("IsMoveNext", true);
        //anim.SetBool("IsMove", true);
        yield return new WaitForSeconds(time);
        deadZone.SetActive(true);
        deadZoneSec.SetActive(true);


    }

}
