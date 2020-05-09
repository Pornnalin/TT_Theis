using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSound : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.soundManager.audioS.volume = 0.5f;
        SoundManager.soundManager.PlaySound(soundInGame.woodSmash_sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
