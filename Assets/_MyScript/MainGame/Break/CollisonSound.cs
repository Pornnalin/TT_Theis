using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EleBall"))
        {
            StartCoroutine(waitSoundDestory());
            Debug.Log("soundBreak");

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(waitSoundWindow());
            Debug.Log("soundBreak");

        }

        
    }

    IEnumerator waitSoundWindow()
    {
        SoundManager.soundManager.audioS.volume = 0.9f;
        SoundManager.soundManager.PlaySound(soundInGame.window_sound);
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

    IEnumerator waitSoundDestory()
    {
        SoundManager.soundManager.audioS.volume = 0.5f;
        SoundManager.soundManager.PlaySound(soundInGame.hit_sound);
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
