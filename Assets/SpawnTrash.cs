using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    public GameObject[] prefeb;
   
    public int prefeb_num;
    // Start is called before the first frame update
    void Start()
    {
        //int prefeb_num = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        prefeb_num = Random.Range(0, 5);
        Instantiate(prefeb[prefeb_num], transform.position, transform.rotation);
    }
}
