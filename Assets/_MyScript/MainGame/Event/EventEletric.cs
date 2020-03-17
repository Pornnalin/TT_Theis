using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEletric : MonoBehaviour
{
    public GameObject[] stuffEle;
    public GameObject target;
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
        if (other.gameObject.CompareTag("Box"))
        {
            target.GetComponent<PushItem>().enabled = false;
            foreach (GameObject game in stuffEle)
            {
                //target.GetComponent<PushItem>().enabled = false;
                game.SetActive(false);
            }
        }
    }
}
