using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject spawnAi;
    // Start is called before the first frame update
    void Start()
    {
        spawnAi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spawnAi.SetActive(true);
            SoundManager.soundManager.audioS.volume = 0.3f;
            SoundManager.soundManager.PlaySound(soundInGame.hit_sound);

        }

    }
}
