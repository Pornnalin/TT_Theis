using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaformDestruction : MonoBehaviour
{
    public GameObject prefab;
    //public GameObject des;
    public float time;
    public Transform spawnPosition;
    //public GameObject origin;
    //public Transform postionSpawn;
    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Destroy(gameObject);
            //origin.GetComponent<MeshRenderer>().enabled = false;
            //Instantiate(prefab,transform.position, transform.rotation);
            //origin.GetComponent<Collider>().enabled = false;
            StartCoroutine(wait());
        }

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);

        Instantiate(prefab, spawnPosition.transform.position, Quaternion.Euler(-90, 0, 0));
        //Instantiate(prefab, spawnPosition.transform.position, Quaternion.identity);
        gameObject.GetComponent<Collider>().enabled = false;

    }
}
