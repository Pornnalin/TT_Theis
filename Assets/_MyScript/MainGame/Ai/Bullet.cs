using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody buPrefab;
    public Transform barrelEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuMove()
    {
        Rigidbody buInstance;
        buInstance = Instantiate(buPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        buInstance.AddForce(barrelEnd.forward * 5000);


    }
}
