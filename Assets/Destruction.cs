using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject prefeb;
    public Transform lastTraform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //lastTraform.transform.position = transform.position;
    }

    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.relativeVelocity.magnitude > 2)
    //    {
    //        Instantiate(prefeb, lastTraform, transform.rotation);
    //        Destroy(gameObject);
    //    }
    //}
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Instantiate(prefeb, lastTraform.transform.position, transform.rotation);
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
