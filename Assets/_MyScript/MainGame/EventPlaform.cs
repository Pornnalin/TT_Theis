using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPlaform : MonoBehaviour
{
    public GameObject[] wall;
    public GameObject cctv;
    public bool isSwtichOn;
    public GameObject switchButton;
    public GameObject lightButtnOn;
    public GameObject lightButtOff;

    // Start is called before the first frame update
    void Start()
    {
        isSwtichOn = false;
        cctv.SetActive(false);
        wall[0].SetActive(true);
        wall[1].SetActive(false);
        lightButtOff.SetActive(true);
        lightButtnOn.SetActive(false);
        switchButton.gameObject.GetComponent<Collider>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSwtichOn)
        {
            lightButtOff.SetActive(false);
            lightButtnOn.SetActive(true);
            cctv.SetActive(true);
            wall[0].SetActive(false);
            wall[1].SetActive(true);
            switchButton.gameObject.GetComponent<Collider>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isSwtichOn = true;
            gameObject.GetComponent<Collider>().enabled = false;

        }
    }
}
