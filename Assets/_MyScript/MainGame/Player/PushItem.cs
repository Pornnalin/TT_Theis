using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushItem : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float speed;
    Vector3 dir;

    public bool isPush;

    // Start is called before the first frame update
    void Start()
    {
        isPush = false;
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isPush)
        {

            if (GameManager.IsInputEnabled && !MainPlayerController.instance.isClimb && !MainPlayerController.instance.Isjump && !MainPlayerController.instance.isCrouched) 
            {

                //MainPlayerController.instance.anim.SetBool("IsPush", true);
                //MainPlayerController.instance.charController.height = 1.7f;
                //rigidbody.velocity = Vector3.right * Time.deltaTime * speed;
                //transform.Translate(Vector3.right * Time.deltaTime);
                if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 0)
                {
                    if (Input.GetKey(KeyCode.D))
                    {
                        MainPlayerController.instance.anim.SetBool("IsPush", true);
                        transform.Translate(Vector3.right * Time.deltaTime);
                        MainPlayerController.instance.charController.height = 1.7f;
                    }

                }
               

               else if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 180)
                {
                    if (Input.GetKey(KeyCode.A))
                    {
                        MainPlayerController.instance.anim.SetBool("IsPush", true);
                        transform.Translate(Vector3.left * Time.deltaTime);
                        MainPlayerController.instance.charController.height = 1.7f;
                    }
                }

                else
                {
                    MainPlayerController.instance.anim.SetBool("IsPush", false);
                }
            }
        }
    }
   
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FloorGlass"))
        {
            SoundManager.soundManager.audioS.volume = 1f;
            SoundManager.soundManager.PlaySound(soundInGame.glass_sound);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Isplayer");
            MainPlayerController.instance.charController.height = 1.7f;
            isPush = true;
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        isPush = false;
        MainPlayerController.instance.anim.SetBool("IsPush", false);
        MainPlayerController.instance.anim.SetBool("IsPushHang", false);
        MainPlayerController.instance.charController.height = 1.86f;

    }

    public void checkRotaion()
    {
        if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 0)
        {
            //MainPlayerController.instance.anim.SetBool("IsPush", true);
            MainPlayerController.instance.charController.height = 1.7f;

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime);

            }
          

            //MainPlayerController.instance.anim.SetBool("IsPush", true);
            //MainPlayerController.instance.charController.height = 1.7f;
            ////rigidbody.velocity = Vector3.right * Time.deltaTime * speed;
            //transform.Translate(Vector3.right * Time.deltaTime);

            Debug.Log("0");
        }
        if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 180)
        {
            //MainPlayerController.instance.anim.SetBool("IsPush", true);
            MainPlayerController.instance.charController.height = 1.7f;

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime);

            }

           
            //rigidbody.velocity = Vector3.right * Time.deltaTime * speed;


            Debug.Log("180");
        }
    }
}
