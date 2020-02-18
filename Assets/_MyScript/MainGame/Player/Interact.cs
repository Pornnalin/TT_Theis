using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interact : MonoBehaviour
{
    public GameObject texFist;
    //public TextMeshProUGUI _press;
    bool isShowText;
    public GameObject texSceond;
    public static Interact _interact;
    public  bool isPressE;
    // Start is called before the first frame update

    void Start()
    {
        texFist.SetActive(false);
        texSceond.SetActive(false);

        isPressE = false;
       

    }

    public void Awake()
    {
        if (_interact == null)
        {
            _interact = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

       
    }
    // Update is called once per frame
    void Update()
    {
        if (isShowText)
        {
            if (Input.GetKey(KeyCode.E))
            {
                //StartCoroutine(wait());
                isPressE = true;
            }
        }

      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("press E");
            texSceond.SetActive(true);
            isShowText = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            texSceond.SetActive(true);
            Debug.Log("Press E");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Out");
        texSceond.SetActive(false);

        //texFist.SetActive(false);
      

    }

    //IEnumerator wait()
    //{
    //    texFist.SetActive(true);
    //    yield return new WaitForSeconds(2f);
    //    texFist.SetActive(false);
    //    isShowText = false;

    //}
}
