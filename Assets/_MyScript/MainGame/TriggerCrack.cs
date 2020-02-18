using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCrack : MonoBehaviour
{
    public GameObject prefab;
    public GameObject origin;
    public Transform[] potionSpawn;
    //public Transform postionSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            
            Instantiate(prefab, potionSpawn[0].position, Quaternion.identity);
            Instantiate(prefab, potionSpawn[1].position, Quaternion.identity);
            Destroy(origin);
            Debug.Log("wodd");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
    }


}
