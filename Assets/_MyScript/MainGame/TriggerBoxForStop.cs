using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxForStop : MonoBehaviour
{
    public Animator anim;
    public Animator animLight;
    public bool isStuck;
    public GameObject on;
    public GameObject off;
    public GameObject sound;
    bool isSound = false;

    // Start is called before the first frame update
    void Start()
    {
        on.SetActive(false);
        animLight.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSound)
        {
            sound.SetActive(true);
        }
        else
        {
            sound.SetActive(false);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            //anim.speed = 0f;
            //anim.SetBool("Shake", true);
            //isStuck = true;
        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            isSound = true;
            anim.speed = 0f;
            animLight.GetComponent<Animator>().enabled = true;
            on.SetActive(false);
            animLight.SetBool("isWink", true);
            //anim.SetBool("Shake",true);
            //isStuck = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ob_Box"))
        {
            isSound = false;
            //anim.SetBool("Shake", false);
            //anim.speed = 1f;
            StartCoroutine(waitToPlay());
            animLight.GetComponent<Animator>().enabled = false;
            on.SetActive(true);
            off.SetActive(false);

            //moveStell.renderer.sharedMaterial = moveStell.switchLightMat[1];
            //renderer.sharedMaterial = switchLightMat[1];
            animLight.SetBool("isWink", false);

            //isStuck = false;
        }
    }
    IEnumerator waitToPlay()
    {
        yield return new WaitForSeconds(2f);
        anim.speed = 1f;
    }


}
