using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _GameManager;
    public static bool IsInputEnabled = true;
    public static bool _gameEnd = false;
    
   

    //public static bool isChagn;

    // Start is called before the first frame update
    void Start()
    {

        IsInputEnabled = true;
        _gameEnd = false;
    }
    private void Awake()
    {
        if (_GameManager == null)
        {
            _GameManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameEnd == true) 
        {
            //UIManager.iManager.endGameTxt.enabled = true;
            IsInputEnabled = false;
            
            //MainPlayerController.instance.anim.SetFloat("Speed", 0f);
            
        }
        else
        {
            //UIManager.iManager.endGameTxt.enabled = false;
            IsInputEnabled = true;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        //    isChagn = true;
        //    SceneManager.LoadScene("TestCameraFollow2");
        //}
    }
   
    /// 
    public void SpawnCase()
    {
        StartCoroutine(WaitSpawnCase());
    }
    IEnumerator WaitSpawnCase()
    {
        Instantiate(MainPlayerController.instance.caseModel, MainPlayerController.instance.playerModel.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(3f);

    }

    ///
    public void SoundFound()
    {
        StartCoroutine(WaitForTurnOff());
    }
    IEnumerator WaitForTurnOff()
    {
        //anim.speed = 0;
        //Instantiate(MainPlayerController.instance.caseModel, MainPlayerController.instance.playerModel.transform.position, Quaternion.identity);
        SoundManager.soundManager.audioS.volume = 0.3f;
        SoundManager.soundManager.PlaySound(soundInGame.em_sound);
        yield return new WaitForSeconds(3f);
        SoundManager.soundManager.audioS.volume = 0f;
        TrasitionScene.Trasition.EndGame();

    }
    ///
    public void SoundEle()
    {
        StartCoroutine(WaitForTurnOffEle());
    }
    IEnumerator WaitForTurnOffEle()
    {
        //anim.speed = 0;
        //Instantiate(MainPlayerController.instance.caseModel, MainPlayerController.instance.playerModel.transform.position, Quaternion.identity);

        SoundManager.soundManager.audioS.volume = 0.3f;
        SoundManager.soundManager.PlaySound(soundInGame.eletric_sound);
        yield return new WaitForSeconds(3f);
        SoundManager.soundManager.audioS.volume = 0f;
        TrasitionScene.Trasition.EndGame();

    }





}
