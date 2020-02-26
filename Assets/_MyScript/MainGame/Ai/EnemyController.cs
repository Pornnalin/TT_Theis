using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public static EnemyController enemyController;
    public Transform[] patrolPoint;
    public int currentPatrolPoint;


    public NavMeshAgent agent;
    //public float speedNav;
    public Animator anim;
    public enum AIState
    {
        isIdle, IsPatrolling,/*IsFollower*/
    }
    public AIState currentState;

    public float waitAtPoint;
    private float waitCounter;

    //public float targetRange;
    //public float rage;



    // Start is called before the first frame update
    void Start()
    {
        waitCounter = waitAtPoint;
       
        agent.baseOffset = -0.1f;

        //agent.speed = speedNav;
    }
    private void Awake()
    {
        if (enemyController == null)
        {
            enemyController = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.IsInputEnabled)
        {
            //float distanceToPlayer = Vector3.Distance(transform.position, MainPlayerController.instance.transform.position);
            //Debug.Log(distanceToPlayer + "position");
            switch (currentState)
            {
                case AIState.isIdle:
                    anim.SetBool("IsMoving", false);

                    if (waitCounter > 0)
                    {
                        waitCounter -= Time.deltaTime;
                    }
                    else
                    {
                        currentState = AIState.IsPatrolling;
                        agent.SetDestination(patrolPoint[currentPatrolPoint].position);

                    }
                    //if (distanceToPlayer <= rage)
                    //{
                    //    currentState = AIState.IsFollower;
                    //    anim.SetBool("IsMoving", true);

                    //}

                    break;

                case AIState.IsPatrolling:


                    if (agent.remainingDistance <= 0.5f)
                    {
                        currentPatrolPoint++;
                        if (currentPatrolPoint >= patrolPoint.Length)//เช็คว่าครบตำแหน่งยัง
                        {
                            currentPatrolPoint = 0;//ถ้าครบทำการเริ่มใหม่
                        }
                        currentState = AIState.isIdle;
                        waitCounter = waitAtPoint;
                    }
                    //if (distanceToPlayer <= rage)
                    //{
                    //    currentState = AIState.IsFollower;
                    //}

                    anim.SetBool("IsMoving", true);
                    break;


                //case AIState.IsFollower:

                //    agent.SetDestination(MainPlayerController.instance.transform.position);
                   
                    
                //    break;
               
            }
            
        }


        else
        {
            anim.SetBool("IsMoving", false);
           
        }

       
    }


}

