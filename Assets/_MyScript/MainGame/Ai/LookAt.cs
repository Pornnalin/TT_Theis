using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    //public Transform origin;
    // Start is called before the first frame update
    void Start()
    {
        //origin.position = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
    }
}
