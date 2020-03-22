using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    //public GameObject prefeb1, prefeb2, prefeb3, prefeb4, prefeb5;
    public GameObject[] prefeb;
    public int prefeb_num;
    public int num;

    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //num = whatToSpawn;
        //int prefeb_num = Random.Range(0, 3);
        //num = prefeb_num;
       
        //Instantiate(prefeb[prefeb_num], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            num = prefeb.Length;
            whatToSpawn = Random.Range(0, num);
            //switch (whatToSpawn)
            //{
            //    case 1:
            //        Instantiate(prefeb1, transform.position, transform.rotation);
            //        break;
            //    case 2:
            //        Instantiate(prefeb2, transform.position, transform.rotation);
            //        break;
            //    case 3:
            //        Instantiate(prefeb3, transform.position, transform.rotation);
            //        break;
            //    case 4:
            //        Instantiate(prefeb4, transform.position, transform.rotation);
            //        break;
            //    case 5:
            //        Instantiate(prefeb5, transform.position, transform.rotation);
            //        break;

            //}
            Instantiate(prefeb[whatToSpawn], transform.position, transform.rotation);

            nextSpawn = Time.time + spawnRate;
        }
       
        //StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
        //Instantiate(prefeb[prefeb_num], transform.position, transform.rotation);
    }
}
