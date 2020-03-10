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
    public Material[] switchLightMat;
    public Renderer renderer;
    bool isMove;
    bool isMoveNext;
    public Animator anim;
    public EventPlaform plaform;
    public SteelInfo steelInfo;

    // Start is called before the first frame update
    void Start()
    {
        steelInfo.GetComponent<SteelInfo>().enabled = false;
        //origin = steel.transform.position;
        //origin = steel.transform.eulerAngles;
        //renderer.sharedMaterial = switchLightMat[];
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
            renderer.sharedMaterial = switchLightMat[1];

        }
        if (isMoveNext)
        {
            //renderer.sharedMaterial = switchLightMat[2];
            //anim.SetTrigger("IsMoveNext");
            StartCoroutine(Retrun());
        }
        else
        {
            //renderer.sharedMaterial = switchLightMat[1];
        }

        //if (!isMoveNext && !isMove) 
        //{
        //    renderer.sharedMaterial = switchLightMat[2];
        //}
        //else
        //{
        //    renderer.sharedMaterial = switchLightMat[1];
        //}

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
            renderer.sharedMaterial = switchLightMat[0];
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
        //renderer.sharedMaterial = switchLightMat[1];

    }

    IEnumerator Retrun()
    {
        
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("IsMoveNext", true);
        steelInfo.GetComponent<SteelInfo>().enabled = true;

        //steel.transform.position = Vector3.MoveTowards(steel.transform.position, postionTarget.position, 5f * Time.deltaTime);
        //steel.transform.position = new Vector3(origin.x, origin.y, origin.z);
        ////steel.transform.eulerAngles = new Vector3(origin.x, origin.y, origin.z);


    }

    
}
