using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObj : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target.SetActive(true);
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
