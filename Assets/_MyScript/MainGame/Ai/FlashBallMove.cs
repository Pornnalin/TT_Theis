using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBallMove : MonoBehaviour
{
    //public Transform startPos;
    //public Transform endPos;

    //public GameObject flashBall;

    public float speed;
    public FlashBallFind flashBallFind;
    public float time;
    public Vector3 target;
    public GameObject caseModel;
    bool isStop = false;
    bool isSpawnCase;
    //private float startTime;
    //private float journeyLength;

    //public bool ispass;
    // Start is called before the first frame update
    void Start()
    {
        //    startTime = Time.time;
        //    journeyLength = Vector3.Distance(startPos.position, endPos.position);
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        Destroy(this.gameObject, 20f);
        //}}

    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (ispass)
    //    {
    //        transform.Translate(-speed * Time.deltaTime, 0, 0);
    //        //float distCovered = (Time.time - startTime) * speed;
    //        //float fractionOfJoureny = distCovered / journeyLength;
    //        //transform.position = Vector3.Lerp(startPos.position, endPos.position, fractionOfJoureny);
    //    }
    //}
    public void Update()
    {
        StartMove();
        //transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    public void StartMove()
    {
        if (!isStop && !flashBallFind.isBodyDead)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

        }
        else
        {
            StartCoroutine(FindSomthing());
        }
    }
    IEnumerator FindSomthing()
    {
        if (flashBallFind.isSpawnToAnother)
        {
            Instantiate(caseModel, target, Quaternion.identity);
            flashBallFind.isSpawnToAnother = false;
        }
        //Instantiate(caseModel, target, Quaternion.identity);
        yield return new WaitForSeconds(time);
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

   }
    
    // void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        ispass = true;

    //    }

    //}



    
