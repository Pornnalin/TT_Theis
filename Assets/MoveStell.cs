using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStell : MonoBehaviour
{
    //public Transform steel;
    //public Rigidbody rigidbody;
    //public Transform postionTarget;
    //public Transform postionDown;
    //public Transform postionOrigin;
    //public Vector3 origin;
    bool isMove;
    bool isMoveNext;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //origin = steel.transform.position;
        //origin = steel.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.E))
        //{
        //    isMove = true;
        //}
        //else
        //{
        //    isMove = false;
        //}

        if (isMove)
        {
            anim.SetBool("IsMove", true);
        }
        if (isMoveNext)
        {
            //anim.SetTrigger("IsMoveNext");
            StartCoroutine(Retrun());
        }

    }

    private void FixedUpdate()
    {
        //if (isMove)
        //{
        //    //steel.transform.Translate(Vector3.down * 2f * Time.deltaTime);
        //    steel.transform.position = Vector3.MoveTowards(steel.transform.position, postionDown.position, 5f * Time.deltaTime);
        //}
        //else
        //{
        //    //steel.transform.position = Vector3.MoveTowards(steel.transform.position, postionTarget.position, 5f * Time.deltaTime);
        //    StartCoroutine(Retrun());
        //}
               

      
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isMove = true;

        }
        else
        {
            isMove = false;
        }

        

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            isMoveNext = true;
            Debug.Log("Next!!");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        isMoveNext = false;

        isMove = false;
        anim.SetBool("IsMove", false);
        anim.SetBool("IsMoveNext", false);

    }

    IEnumerator Retrun()
    {
        yield return new WaitForSeconds(2f);
        anim.SetBool("IsMoveNext", true);
        //steel.transform.position = Vector3.MoveTowards(steel.transform.position, postionTarget.position, 5f * Time.deltaTime);
        //steel.transform.position = new Vector3(origin.x, origin.y, origin.z);
        ////steel.transform.eulerAngles = new Vector3(origin.x, origin.y, origin.z);


    }
}
