using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisblePause : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pause.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        pause.SetActive(true);
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
