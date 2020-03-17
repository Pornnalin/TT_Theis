using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrashFall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] targetObject;
    void Start()
    {
        foreach (GameObject game in targetObject)
        {
            game.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Collider>().enabled = false;
            foreach(GameObject game in targetObject)
            {
                game.SetActive(true);
            }
        }
    }
}
