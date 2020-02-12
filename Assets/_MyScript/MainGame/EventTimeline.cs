using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTimeline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void PlayerStop()
    {
        GameManager.IsInputEnabled = false;
    }

    void PlayerCanMove()
    {
        GameManager.IsInputEnabled = true;
    }
}
