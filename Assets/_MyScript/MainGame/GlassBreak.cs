using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBreak : MonoBehaviour
{
    public GameObject prefab;
    public GameObject origin;
    public Transform postionSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            origin.GetComponent<MeshRenderer>().enabled = false;
            Instantiate(prefab, postionSpawn.transform.position, transform.rotation);
            origin.GetComponent<Collider>().enabled = false;

        }

    }

}