using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiFindPlayer : MonoBehaviour
{
    //public float rotationSpeed;
    //public Number number;
    public float distance;
    public EnemyController enemyController;
    //public float[] test;
    private bool spawnCase = false;
    private bool findTarget;

    //public Transform[] postitionRay;

    //public GameObject particle;
    //public Transform postionSpawn;



    // Start is called before the first frame update
    void Start()
    {
        findTarget = true;
        //test = number._distane;
        //enemyController = GetComponent<EnemyController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //Vector3 direction = transform.TransformDirection(Vector3.forward) * 10;
        if (GameManager.IsInputEnabled && findTarget)
        {
            Ray ray= new Ray(transform.position, transform.forward);
          
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, distance))
            { 
                if (hitInfo.collider.CompareTag("Player"))
                {
                   
                    GameManager._GameManager.SoundFound();
                    MainPlayerController.instance.anim.SetBool("IsDead", true);
                    Debug.Log(hitInfo.collider.gameObject.name);
                    Debug.Log("PlayerDead");
                    GameManager._gameEnd = true;
                    spawnCase = true;
                    findTarget = false;
                  

                }

                else
                {
                    Debug.Log("Not found anything");
                }
                Debug.DrawLine(ray.origin, hitInfo.point, Color.green);

            }
        }
        else
        {
            //if (!findTarget)
            //{
            //    findTarget = false;
            //    distance = 0f;
            //}

            findTarget = false;
            if (spawnCase)
            {
                //StartCoroutine(SpawnCase());
              
                //EnemyController.enemyController.currentState = EnemyController.AIState.isIdle;
                enemyController.currentState = EnemyController.AIState.isIdle;
                //EnemyController.enemyController.anim.speed = 0f;
                enemyController.anim.speed = 0f;
                GameManager._GameManager.SpawnCase();
                distance = 0f;
                spawnCase = false;
            }
        }


        //soundManager.PlaySound(SoundManager.soundInGame.em_sound);
    }


    //IEnumerator WaitForTurnOff()
    //{

    //   
    //    //SoundManager.soundManager.audioS.volume = 0.3f;
    //    //SoundManager.soundManager.PlaySound(soundInGame.em_sound);
    //    //yield return new WaitForSeconds(3f);
    //    //SoundManager.soundManager.audioS.volume = 0f;
    //    //TrasitionScene.Trasition.EndGame();
    //}

    //IEnumerator SpawnCase()
    //{
    //    Instantiate(MainPlayerController.instance.caseModel, MainPlayerController.instance.playerModel.transform.position, Quaternion.identity);
    //    yield return new WaitForSeconds(3f);

    //}

    //public void SpawnParticle()
    //{
    //    GameObject _spark = Instantiate(particle, postionSpawn.transform.position, Quaternion.identity) as GameObject;
    //    _spark.transform.parent = MainPlayerController.instance.playerModel.transform;
    //    postionSpawn.transform.LookAt(MainPlayerController.instance.playerModel.transform);
    //}
}
//[SerializeField]
//[System.Serializable]
//public class Number
//{
//    public float[] _distane;
   
//}



