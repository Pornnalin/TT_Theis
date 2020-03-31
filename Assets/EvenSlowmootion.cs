using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenSlowmootion : MonoBehaviour
{
    public AudioSource audioSource;
   
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.pitch = 1f;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void timeMotion()
    {
        
        Time.timeScale = 0.3f;
        //audioSource.pitch = 0.3f;
    }
    public void timeNormal()
    {
      
        Time.timeScale = 1f;
        //audioSource.pitch = 1f;

    }
}
