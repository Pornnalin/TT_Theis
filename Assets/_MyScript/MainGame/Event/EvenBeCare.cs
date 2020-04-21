using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvenBeCare : MonoBehaviour
{
    public Animator anim;
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
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Showtext());
            anim.SetBool("care", true);
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    IEnumerator Showtext()
    {
        dot.text = dotString;
        for (int i = 0; i < dotString.Length; i++)
        {
            dot.enabled = true;
            dot.text = dotString;
            dot.text = dotString.Substring(0, i + 1);
            yield return new WaitForSeconds(0.08f);
            Debug.Log("lenght" + dotString.Length);

        }
        yield return new WaitForSeconds(2f);
        dot.enabled = false;
    }
}
