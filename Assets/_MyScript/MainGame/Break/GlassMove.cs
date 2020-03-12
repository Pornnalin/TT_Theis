using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassMove : MonoBehaviour
{

    public Rigidbody rigi;
    // Start is called before the first frame update
    void Start()
    {

        rigi = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(wait());

    }
    private void FixedUpdate()
    {
        StartCoroutine(wait());
        //gavity();
        //rigi.AddForce(-transform.right * 4f);
    }

    public void gavity()
    {
        //rigi.AddForce(-transform.right / 3f, ForceMode.Impulse);
        //StartCoroutine(wait());

    }
    IEnumerator wait()
    {
       
        rigi.AddForce(-transform.right * 2f);
        //rigi.AddForce(Physics.gravity * rigi.mass * rigi.mass * 2);
        yield return new WaitForSeconds(0.5f);
        //rigi.constraints = RigidbodyConstraints.None;
        rigi.useGravity = true;
    }

    
}
