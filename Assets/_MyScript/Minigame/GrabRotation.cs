using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{
   
    public float speedRotation = 5f;
    [SerializeField]
    public Vector3 originalRotation;
    //Quaternion originalRotation;
    public float XaxisRotaion;
    public float YaxisRotaion;
    public float count;
    bool _wait;
    public float time;

    private void Start()
    {
        originalRotation = transform.rotation.eulerAngles;
        time = count;
    }
    void OnMouseDrag()
    {
        XaxisRotaion = Input.GetAxis("Mouse X") * speedRotation;
        YaxisRotaion = Input.GetAxis("Mouse Y") * speedRotation;

        //Vector3 XaxisRotaion = new Vector3(Input.GetAxis("Mouse X") * speedRotation, 0, 0);

        transform.Rotate(Vector3.right, YaxisRotaion);
        transform.Rotate(Vector3.down, XaxisRotaion);
        //transform.RotateAround(transform.position, new Vector3(0, 1, 0) * Time.deltaTime * -1, XaxisRotaion);
    }

    ////}
    //    public void OnMouseEnter()
    //{
    //    XaxisRotaion = Input.GetAxis("Mouse X") * speedRotation;
    //    YaxisRotaion = Input.GetAxis("Mouse Y") * speedRotation;

    //    //Vector3 XaxisRotaion = new Vector3(Input.GetAxis("Mouse X") * speedRotation, 0, 0);

    //    //transform.Rotate(Vector3.right, YaxisRotaion);
    //    //transform.Rotate(Vector3.down, XaxisRotaion);
    //    Quaternion rotationAmount = Quaternion.Euler(0, 0, 90);
    //    Quaternion postRotation = transform.rotation * rotationAmount;
    //    transform.RotateAround(transform.position, new Vector3(0, 1, 0) * Time.deltaTime, 90);




    //}

    //public void OnMouseDown()
    //{
    //    XaxisRotaion = Input.GetAxis("Mouse X") * speedRotation;
    //    YaxisRotaion = Input.GetAxis("Mouse Y") * speedRotation;

    //    //Vector3 XaxisRotaion = new Vector3(Input.GetAxis("Mouse X") * speedRotation, 0, 0);

    //    //transform.Rotate(Vector3.right, YaxisRotaion);
    //    //transform.Rotate(Vector3.down, XaxisRotaion);
    //    transform.RotateAround(transform.position, new Vector3(0, 0, 1) * Time.deltaTime, 90);
    //}

    //}
    public void Update()
    {
        

    }


    private void OnMouseUp()
    {
        //transform.eulerAngles = new Vector3(originalRotation.x, originalRotation.y, 0);
        //Debug.Log("Original");

        //StartCoroutine(wait());
     
    }

    IEnumerator wait()
    {
        //SoundManager.soundManager.audioS.volume = 5f;
        //SoundManager.soundManager.PlaySound(soundInGame.countDown);
        _wait = true;
        yield return new WaitForSeconds(count);
        //transform.eulerAngles = new Vector3(originalRotation.x, originalRotation.y, 0);

        Debug.Log("Original");
        //SoundManager.soundManager.audioS.volume = 0f;
    }


}
