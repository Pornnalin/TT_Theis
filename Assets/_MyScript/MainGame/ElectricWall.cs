using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricWall : MonoBehaviour
{
    public GameObject prefabEletic;
    bool isTouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch)
        {
            GameManager._gameEnd = true;
            MainPlayerController.instance.anim.SetBool("IsDead", true);
            GameManager._GameManager.SoundEle();
            Instantiate(prefabEletic, MainPlayerController.instance.playerModel.transform.position, Quaternion.identity);
            isTouch = false;
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTouch = true;

            if (isTouch)
            {
                gameObject.GetComponent<Collider>().enabled = false;
            }

        }
    }
}
