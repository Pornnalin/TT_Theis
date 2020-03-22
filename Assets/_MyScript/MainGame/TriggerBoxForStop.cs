using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxForStop : MonoBehaviour
{
    public Animator anim;
    public bool isStuck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            //anim.speed = 0f;
            anim.SetBool("Shake", true);
            //isStuck = true;
        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            //anim.speed = 0f;
            anim.SetBool("Shake",true);
            //isStuck = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            anim.SetBool("Shake", false);
            //anim.speed = 1f;
            //isStuck = false;
        }
    }
}
