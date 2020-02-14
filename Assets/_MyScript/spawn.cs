using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject particle;
    public Transform postionSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager._gameEnd)
        {
            Invoke("SpawnParticle", 5f);
        }
    }

    public void SpawnParticle()
    {
        GameObject _spark = Instantiate(particle, transform.position, Quaternion.Euler(0, 90, 0));
    }
}
