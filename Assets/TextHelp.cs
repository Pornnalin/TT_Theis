using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHelp : MonoBehaviour
{
    public TMP_Text dot;
    public string dotString;
    // Start is called before the first frame update
    void Start()
    {

        dot.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    IEnumerator Showtext()
    {
        dot.text = dotString;
        for (int i = 0; i < dotString.Length; i++)
        {
            dot.enabled = true;
            dot.text = dotString;
            dot.text = dotString.Substring(0, i + 1);
            yield return new WaitForSeconds(0.04f);
            Debug.Log("lenght" + dotString.Length);

        }
        yield return new WaitForSeconds(2f);
        dot.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Showtext());
           
        }


    }
    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }

}
