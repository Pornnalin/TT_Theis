using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractText : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ShowText());

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
        //    text.SetActive(false);

        //}
    }

    IEnumerator ShowText()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1f);
        text.SetActive(false);
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
