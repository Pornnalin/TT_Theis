using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform camTransform;

    //ระยะเวลา
    public float shakeDuration = 0f;

    //ความกว้าง
    public float shakeAmount = 0.7f;
    public float dereaseFactor = 1.0f;

    Vector3 originPos;


    private void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    //private void OnEnable()
    //{
    //    originPos = camTransform.localPosition;
    //}
    private void Update()
    {
        originPos = camTransform.localPosition;

        if (MainPlayerController.instance.isShake)
        {
            if (shakeDuration > 0)
            {
                //camTransform.localPosition = originPos + Random.insideUnitSphere * shakeAmount;
                camTransform.localPosition = originPos+Random.insideUnitSphere * shakeAmount;

                shakeDuration -= Time.deltaTime * dereaseFactor;
            }
            else
            {
                shakeDuration = 0f;
                camTransform.localPosition = originPos;
            }
        }
    }
}
