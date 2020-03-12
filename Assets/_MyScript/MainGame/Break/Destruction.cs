using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject prefeb;
    public Transform lastTraform;
    public float radius,power,upwarp;
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
    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        gameObject.GetComponent<MeshRenderer>().enabled = false;
    //        Instantiate(prefeb, lastTraform.transform.position, transform.rotation);
    //        gameObject.GetComponent<Collider>().enabled = false;
    //    }


    //}
    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("EleBall"))
    //    {
    //        gameObject.GetComponent<MeshRenderer>().enabled = false;
    //        Instantiate(prefeb, transform.position, transform.rotation);
    //        gameObject.GetComponent<Collider>().enabled = false;
    //    }
    //}
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EleBall")|| collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            //gameObject.GetComponent<MeshRenderer>().enabled = false;
            Instantiate(prefeb, transform.position, transform.rotation);
            //prefeb.gameObject.transform.localScale = transform.localScale;
            Vector3 exlosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(exlosionPos, radius);

            foreach (Collider hit in colliders)
            {
                if (hit.attachedRigidbody)
                {
                    hit.attachedRigidbody.AddExplosionForce(power * collision.relativeVelocity.magnitude, exlosionPos, radius, upwarp);
                }
            }
            //Debug.Log(collision.relativeVelocity.magnitude);
            //gameObject.GetComponent<Collider>().enabled = false;
            //}
            //if (collision.relativeVelocity.magnitude > 3)
            //{
            //    Destroy(gameObject);
            //    Instantiate(prefeb, transform.position, transform.rotation);

        }

    }


}
