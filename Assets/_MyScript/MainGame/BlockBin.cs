using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBin : MonoBehaviour
{
    public PushItem pushItem;
    //public BlockBinSec blockBinSec;
    //public bool isEnable;
    //public GameObject target;
    //public GameObject floorTrigger;
    // Start is called before the first frame update
    void Start()
    {
        //floorTrigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (isEnable)
        //{
        //    target.GetComponent<Collider>().enabled = false;
        //    //blockBinSec.GetComponent<Collider>().enabled = true;
        //    pushItem.GetComponent<Collider>().enabled = true;
        //    pushItem.GetComponent<PushItem>().enabled = true;
        //    Debug.Log("IsWork");


        //}

        //if (blockBinSec.isTri)
        //{
        //    target.GetComponent<Collider>().enabled = true;

        //}
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        isEnable = true;
    //        //target.GetComponent<Collider>().enabled = false;

    //    }
    //}
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //isEnable = true;
            pushItem.isMove = true;
            pushItem.speed = 0.5f;
            //target.GetComponent<Collider>().enabled = false;

        }
    }
    //public void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        floorTrigger.SetActive(true);

    //    }
    //}
}
