using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBoxFall : MonoBehaviour
{
    public Rigidbody rigi;
    //public Animator animator;
    public GameObject target;
    //public GameObject box;
    bool isPush;
    // Start is called before the first frame update
    void Start()
    {
        //rigi.isKinematic = true;
        //rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void FixedUpdate()
    {

        //rigi.velocity = new Vector3(0, 0, -10);

        if (isPush)
        {
            rigi.isKinematic = false;
            //Invoke("wait", 3);
            Destroy(target);
            //box.GetComponent<Rigidbody>().AddForce(Vector3.back * 5f);
            Debug.Log("'d");
        }
    }
    public void push()
    {
        isPush = true;
       
    }

    public void wait()
    {
        rigi.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

    }


}
