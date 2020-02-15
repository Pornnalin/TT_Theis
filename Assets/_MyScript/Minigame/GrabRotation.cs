using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{
   
    public float speedRotation = 5f;
    [SerializeField]
    public Vector3 originalRotation;
    public float XaxisRotaion;
    public float YaxisRotaion;
    public float count;
    bool _wait;
    public float time;

    private void Start()
    {
        originalRotation = gameObject.transform.localEulerAngles;
        time = count;
    }
    void OnMouseDrag()
    {
         XaxisRotaion = Input.GetAxis("Mouse X") * speedRotation;
         YaxisRotaion = Input.GetAxis("Mouse Y") * speedRotation;


        //transform.Rotate(Vector3.right, YaxisRotaion);
        transform.Rotate(Vector3.down, XaxisRotaion);
        
    }
    public void Update()
    {
    }


    private void OnMouseUp()
    {
        //transform.eulerAngles = new Vector3(originalRotation.x, originalRotation.y, 0);
        //Debug.Log("Original");

        StartCoroutine(wait());
     
    }

    IEnumerator wait()
    {
        //SoundManager.soundManager.audioS.volume = 5f;
        //SoundManager.soundManager.PlaySound(soundInGame.countDown);
        _wait = true;
        yield return new WaitForSeconds(count);
        transform.eulerAngles = new Vector3(originalRotation.x, originalRotation.y, 0);
        Debug.Log("Original");
        //SoundManager.soundManager.audioS.volume = 0f;
    }


}
