using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAi : MonoBehaviour
{
    public GameObject targetDestory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(targetDestory);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //BoxCollider box = GetComponent(typeof(BoxCollider)) as BoxCollider;
        //box.isTrigger = false;
    }
}
