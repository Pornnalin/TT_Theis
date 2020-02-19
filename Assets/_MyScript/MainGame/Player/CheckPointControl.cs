﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointControl : MonoBehaviour
{
    public static CheckPointControl checkPointControl;
    public Vector3 lastCheckPos;
    //public Vector3 lastCheckPosCamera;
    //public Vector3 lastCheckPosCrounded;

    // Start is called before the first frame update
    void Start()
    {
        if (checkPointControl == null)
        {
            checkPointControl = this;
            DontDestroyOnLoad(checkPointControl);
        }
        else
        {
            Destroy(gameObject);
        }

       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
