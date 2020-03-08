using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCM : MonoBehaviour
{
    //public static SwitchCM _SwitchCM;
    // Start is called before the first frame update
    public Transform[] view;
    public float traitionSpeed;
    public Transform currentView;
    public CameraShake cameraShake;
    //public CheckTiggerCamera checkTigger;


    //public GameObject player;
    //private Vector3 offset;//distance between the player's position and camera's position.


    // Start is called before the first frame update
    void Start()
    {
        //gameOjectTaget3.SetActive(false);
        //gameOjectTaget.SetActive(true);
        //gameOjectTaget2.SetActive(false);

        //offset = transform.position - player.transform.position;
        currentView = view[0].GetComponent<Transform>();
        //view[0].gameObject.SetActive(true);
        //view[1].gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Mouse1))
        //{
        //    currentView = view[1];
        //    switchInput = false;
        //}
        //if (Input.GetKeyDown(KeyCode.Mouse2))
        //{
        //    currentView = view[0];
        //    switchInput = false;
        //}
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    currentView = view[2];
        //    switchInput = true;
        //}

        //switch (checkTigger._stay)
        //{
        //    case true:
        //        currentView = view[1];

        //        break;

        //    case false:
        //        currentView = view[0];

        //        break;




        //}
        switch (MainPlayerController.instance._isStayInCave)
        {
            case true:
                currentView = view[1];

                break;

            case false:

                //if (MainPlayerController.instance.isZoomOut)
                //{
                //    currentView = view[2];
                //}
                //else
                //{
                //    currentView = view[0];
                //}
                currentView = view[0];

                break;

        }

       
        //switch (MainPlayerController.instance._isOverview)
        //{
        //    case true:
        //        currentView = view[2];
        //        traitionSpeed = 0.5f;
        //        break;

        //    case false:
        //        currentView = view[0];
        //        traitionSpeed = 2f;
        //        break;

        //}



        //ControlCamera();
    }


    private void LateUpdate()
    {
        ////transform.position = player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * traitionSpeed);
        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * traitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * traitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * traitionSpeed));

        transform.eulerAngles = currentAngle;




    }

    //public void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        view[1].gameObject.SetActive(true);
    //        view[0].gameObject.SetActive(false);
    //    }
       
    //}

    //public void OnTriggerExit(Collider other)
    //{
    //    view[0].gameObject.SetActive(true);
    //    view[1].gameObject.SetActive(false);
    //}
}
