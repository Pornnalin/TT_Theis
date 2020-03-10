using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadFall : MonoBehaviour
{
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
            Debug.Log("Found ladder");
            StartCoroutine(WaitForTurnOff());
            //GameManager._GameManager.SoundFound();

            //GameManager._GameManager.SpawnCase();

        }
    }

    IEnumerator WaitForTurnOff()
    {
        MainPlayerController.instance.anim.SetBool("IsDead", true);
        GameManager._gameEnd = true;
        SoundManager.soundManager.audioS.volume = 0.5f;
        SoundManager.soundManager.PlaySound(soundInGame.crack_sound);
        yield return new WaitForSeconds(3f);
        SoundManager.soundManager.audioS.volume = 0f;
        TrasitionScene.Trasition.LoadSceneCurrent();
    }

}
