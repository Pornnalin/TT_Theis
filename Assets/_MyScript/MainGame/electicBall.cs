using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electicBall : MonoBehaviour
{
    Rigidbody rigi;
    bool isSmash;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //rigi.AddForce(Vector3.forward * speed * Time.deltaTime);
        //rigi.velocity = new Vector3(0, 0, speed);
    }
    private void FixedUpdate()
    {
        rigi.velocity = new Vector3(0, 0, speed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {

            Destroy(gameObject, 0.5f);
            Debug.Log("SmashWall");
        }
    }

}
