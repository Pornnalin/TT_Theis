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
    public AudioSource audioSourceWalk;
    
    public enum AIState
    {
        /*isIdle, IsPatrolling, */IsFollower,Stop,Jump
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
        //speedNav = 10.2f;
        agent.speed = speedNav;
        currentState = AIState.IsFollower;
        //audioSource = GetComponent<AudioSource>();
        //audioSource.volume = 0.3f;
    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.IsInputEnabled && GameManager._gameEnd == false) 
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
                    agent.speed = speedNav;
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("Jump", false);

                    if (isStop)
                    {
                        currentState = AIState.Stop;
                    }
 
                    break;

                case AIState.Stop:

                    anim.SetBool("IsMoving", false);

                    break;

                case AIState.Jump:

                    anim.SetBool("IsMoving", false);
                    anim.SetBool("Jump", true);

                    break;
            }
          

        }


        else
        {
            anim.SetBool("IsMoving", false);
            agent.enabled = false;
            audioSource.volume = 0f;
            audioSourceWalk.volume = 0f;

        }

        if (isStop)
        {
            StartCoroutine(waitSound());

        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "SetAi")
        {
            Debug.Log("stay!!");
            isStop = true;
            audioSourceWalk.volume = 0f;
          
            //StartCoroutine(waitSound());

        }
    }

    IEnumerator waitSound()
    {
        yield return new WaitForSeconds(0.1f);
        audioSource.volume -= 5f * Time.deltaTime / 10f;
       
        //audioSource.volume = 0.1f;
        //audioSource.Stop();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("JumpAi"))
        {
            agent.speed = 5f;
            //anim.SetBool("Jump", true);

            //currentState = AIState.Jump;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        agent.speed = speedNav;
        //anim.SetBool("Jump", false);

        //currentState = AIState.IsFollower;





    }




}
