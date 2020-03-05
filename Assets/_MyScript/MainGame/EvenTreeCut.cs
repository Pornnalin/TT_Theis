using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EvenTreeCut : MonoBehaviour
{
    //public Animator animTreeFirst;
    //public Animator animTreeSce;
    //public ParticleSystem particle;
    public PlayableDirector treeCut;

    // Start is called before the first frame update
    void Start()
    {
        treeCut = GetComponent<PlayableDirector>();
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //StartCoroutine(wait());
            treeCut.Play();
        }
       


    }
    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false; 
    }
    //IEnumerator wait()
    //{
    //    animTreeFirst.SetBool("IsFall", true);
    //    yield return new WaitForSeconds(3f);
    //    animTreeSce.SetBool("IsFall", true);
    //}

  
    //public void StopSpawn()
    //{
        
    //}

   
}
