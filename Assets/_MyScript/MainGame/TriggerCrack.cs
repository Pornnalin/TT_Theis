using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCrack : MonoBehaviour
{
    public GameObject prefab;
    public GameObject origin;
    public Transform[] potionSpawn;
    public GameObject plummet;


    //public Transform postionSpawn;
    // Start is called before the first frame update
    void Start()
    {
        plummet.GetComponent<Rigidbody>().useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if ((Interact._interact.isPressE))
        {
            StartCoroutine(waitToFall());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            
            Instantiate(prefab, potionSpawn[0].position, Quaternion.identity);
            Instantiate(prefab, potionSpawn[1].position, Quaternion.identity);
            Destroy(origin);
            Debug.Log("wodd");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            this.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    IEnumerator waitToFall()
    {
        yield return new WaitForSeconds(2f);
        plummet.GetComponent<Rigidbody>().useGravity = true;
        Interact._interact.isPressE = false;
    }
}
