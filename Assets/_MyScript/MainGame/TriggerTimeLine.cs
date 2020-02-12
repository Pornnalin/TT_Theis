using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLine : MonoBehaviour
{
    public GameObject target;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        PlayableDirector _target = target.GetComponent<PlayableDirector>();
        if (_target != null)
        {
            _target.Play();
            
          
        }


    }
}
