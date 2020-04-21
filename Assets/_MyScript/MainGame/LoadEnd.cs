using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("EndCredit");
        //CheckPointControl.checkPointControl.lastCheckPos = new Vector3(-51.8f, 0.267f, -1.73f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
