using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFollow : MonoBehaviour
{
    public Transform target;
    public Rigidbody buRigi;

    public float turn;
    public float missleVelocity;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {

        // missleRigibody.velocity = transform.forward * missleVelocity;

        var buTargetRotation = Quaternion.LookRotation(target.position - transform.position);

        if (buTargetRotation != null && target != null)
        {
            buRigi.velocity = transform.forward * missleVelocity;
            buRigi.MoveRotation(Quaternion.RotateTowards(transform.rotation, buTargetRotation, turn));

        }
    }
}
