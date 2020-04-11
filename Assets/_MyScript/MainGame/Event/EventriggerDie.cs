using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EventriggerDie : MonoBehaviour
{
    public GameObject evenDie;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        evenDie.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //MainPlayerController.instance.anim.SetFloat("Speed", 0);
            //GameManager._gameEnd = true;
            //evenDie.SetActive(true);
            //gameObject.GetComponent<Collider>().enabled = false;
            StartCoroutine(wait());

        }
    }

    IEnumerator wait()
    {
        MainPlayerController.instance.anim.SetFloat("Speed", 0);
        GameManager._gameEnd = true;
        evenDie.SetActive(true);
        gameObject.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Map_4");

    }
}
