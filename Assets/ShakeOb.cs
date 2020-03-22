using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOb : MonoBehaviour
{
    public float speed = 1.0f;
    public float amount = 1.0f;
    Vector3 originPos;
    bool isShake = false;
    // Start is called before the first frame update
    void Start()
    {

        //originPos = transform.position;
        //originPos = transform.position;
    }

    public void Update()
    {
        StartCoroutine(shake());

    }
    public void shakeNow()
    {
        StartCoroutine(shake());
    }
    IEnumerator shake()
    {
        originPos = transform.position;
        Vector3 newPo = Random.insideUnitCircle * (Time.time * amount);
        newPo.z = transform.position.z;
        newPo.y = transform.position.y;

        transform.position = newPo;

        yield return new WaitForSeconds(5f);

        isShake = false;
        transform.position = originPos;
    }
}

    