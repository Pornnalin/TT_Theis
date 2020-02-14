using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject texFist;
    bool isShowText;
    public GameObject texSceond;
    // Start is called before the first frame update
    void Start()
    {
        texFist.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isShowText)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(wait());
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("press E");
            isShowText = true;
            
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("press E");
    //    }
    //}
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Out");
        texFist.SetActive(false);
    }

    IEnumerator wait()
    {
        texFist.SetActive(true);
        yield return new WaitForSeconds(2f);
        texFist.SetActive(false);
        isShowText = false;

    }
}
