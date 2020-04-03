using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;

    [SerializeField]
    private AudioClip[] clipsland;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Step()
    {
        audioSource.volume = 0.02f;
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }

    private void Land()
    {
        audioSource.volume = 0.1f;
        AudioClip clipL = GetRandomClipLand();
        audioSource.PlayOneShot(clipL);
    }

    private AudioClip GetRandomClipLand()
    {
        return clips[UnityEngine.Random.Range(0, clipsland.Length)];
    }
}
