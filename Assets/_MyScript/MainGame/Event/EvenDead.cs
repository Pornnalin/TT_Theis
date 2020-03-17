using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenDead : MonoBehaviour
{
    public Animator anim;
 
    bool isTri;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTri)
        {
            
            StartCoroutine(wati());
          
            //isTri = false;
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTri = true;
            //StartCoroutine(wati());
        }
    }
    IEnumerator wati()
    {
        
        anim.SetBool("eat", true);
        yield return new WaitForSeconds(0.3f);
        anim.SetBool("Dead", true);
        

    }
    
    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
