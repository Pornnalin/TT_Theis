using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventAnimPost : MonoBehaviour
{
    Animator anim;
    public GameObject blockWay;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        blockWay.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Play", true);
            blockWay.SetActive(true);
        }
    }

}
