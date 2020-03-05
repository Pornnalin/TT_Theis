using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLogFall : MonoBehaviour
{
    public Rigidbody[] rigi;
    // Start is called before the first frame update
    
    

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        foreach(Rigidbody g in rigi)
        {
            g.useGravity = true;
            g.isKinematic = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
