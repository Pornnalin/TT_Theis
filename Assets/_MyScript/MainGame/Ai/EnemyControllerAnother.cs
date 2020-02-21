using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyControllerAnother : MonoBehaviour
{
   
    //public int currentPatrolPoint;


    public NavMeshAgent agent;
    public float speedNav;
    public Animator anim;
    bool isStop;
    //public AudioClip walk;
    public AudioSource audioSource;
    public enum AIState
    {
        /*isIdle, IsPatrolling, */IsFollower,Stop
    }
    public AIState currentState;

    //public float waitAtPoint;
    //private float waitCounter;

    //public float targetRange;
    //public float rage;



    // Start is called before the first frame update
    void Start()
    {
        //waitCounter = waitAtPoint;

        agent.baseOffset = -0.1f;

        agent.speed = speedNav;
        currentState = AIState.IsFollower;
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.5f;
    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.IsInputEnabled)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, MainPlayerController.instance.transform.position);
            //Debug.Log(distanceToPlayer + "position");
            switch (currentState)
            {
                //case AIState.isIdle:
                //    anim.SetBool("IsMoving", false);

                //    if (waitCounter > 0)
                //    {
                //        waitCounter -= Time.deltaTime;
                //    }
                //    else
                //    {
                //        currentState = AIState.IsPatrolling;
                //        agent.SetDestination(patrolPoint[currentPatrolPoint].position);

                //    }
                //    if (distanceToPlayer <= rage)
                //    {
                //        currentState = AIState.IsFollower;
                //        anim.SetBool("IsMoving", true);

                //    }

                //    break;

                //case AIState.IsPatrolling:


                //    if (agent.remainingDistance <= 0.5f)
                //    {
                //        currentPatrolPoint++;
                //        if (currentPatrolPoint >= patrolPoint.Length)//เช็คว่าครบตำแหน่งยัง
                //        {
                //            currentPatrolPoint = 0;//ถ้าครบทำการเริ่มใหม่
                //        }
                //        currentState = AIState.isIdle;
                //        waitCounter = waitAtPoint;
                //    }
                //    if (distanceToPlayer <= rage)
                //    {
                //        currentState = AIState.IsFollower;
                //    }

                //    anim.SetBool("IsMoving", true);
                //    break;


                case AIState.IsFollower:

                    agent.SetDestination(MainPlayerController.instance.transform.position);
                   
                    anim.SetBool("IsMoving", true);

                    if (isStop)
                    {
                        currentState = AIState.Stop;
                    }

                    break;

                case AIState.Stop:

                    anim.SetBool("IsMoving", false);

                    break;


            }
          

        }


        else
        {
            anim.SetBool("IsMoving", false);
            audioSource.volume = 0f;

        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "SetAi")
        {
            Debug.Log("stay!!");
            isStop = true;
            StartCoroutine(waitSound());

        }
    }

    IEnumerator waitSound()
    {
        yield return new WaitForSeconds(0.1f);
        audioSource.volume -= 0.5f * Time.deltaTime / 3f;
        
        //audioSource.volume = 0.1f;
        //audioSource.Stop();

    }
}
