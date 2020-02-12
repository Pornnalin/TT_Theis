using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTigger : MonoBehaviour
{
    // Start is called before the first frame update
   
    public bool _stay = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            //cM.view[1].gameObject.SetActive(true);
            //cM.view[0].gameObject.SetActive(false);
            _stay = true;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            //cM.view[0].gameObject.SetActive(true);
            //cM.view[1].gameObject.SetActive(false);
            _stay = false;
        }
    }
}
