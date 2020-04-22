using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evenStart : MonoBehaviour
{
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
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(waitToDis());
        }
    }


    IEnumerator waitToDis()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        MainPlayerController.instance.anim.SetBool("wakeUp", true);
        GameManager._gameEnd = true;
        yield return new WaitForSeconds(11.23f);
        MainPlayerController.instance.anim.SetBool("wakeUp", false);
        GameManager._gameEnd = false;
    }
}
