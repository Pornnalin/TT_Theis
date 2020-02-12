using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTimeline : MonoBehaviour
{
    public bool isTimeline = false;
    // Start is called before the first frame update
    void Start()
    {
        isTimeline = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void PlayerStop()
    {

        isTimeline = true;
        Debug.Log("stop");
    }

    void PlayerCanMove()
    {
        isTimeline = false;
    }
}
