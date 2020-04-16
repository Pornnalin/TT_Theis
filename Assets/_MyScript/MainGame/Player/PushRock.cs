using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushRock : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody _rigidbody;
    public float time = 0.0f;
    Vector3 dir;

    public bool isPush;
    bool isLeft;
    bool isRight;
    //public bool isMove;

    //public BlockBin blockBin;
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
                    isPush = true;
                    
                    //MainPlayerController.instance.anim.speed = 0f;

                    if (Input.GetKey(KeyCode.D) && !MainPlayerController.instance.isCrouched)
                    {
                        isRight = true;
                        isLeft = false;
                        MainPlayerController.instance.anim.speed = 1f;
                        MainPlayerController.instance.anim.SetBool("IsPush", true);
                        //transform.Translate(Vector3.right * Time.deltaTime);
                        //MainPlayerController.instance.charController.height = 1.7f;
                    }



                }


                else if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 180)
                {
                    isPush = true;

                    isRight = false;
                    isLeft = true;
                    //MainPlayerController.instance.anim.speed = 0f;

                    if (Input.GetKey(KeyCode.A) && !MainPlayerController.instance.isCrouched)
                    {

                        MainPlayerController.instance.anim.speed = 1f;
                        MainPlayerController.instance.anim.SetBool("IsPush", true);
                        //transform.Translate(Vector3.left * Time.deltaTime);
                        //MainPlayerController.instance.charController.height = 1.7f;
                    }
                }


            }
            else
            {
                isRight = false;
                isLeft = false;
                MainPlayerController.instance.anim.SetBool("IsPush", false);
            }
        }


    }

    public void FixedUpdate()
    {

        //time = time + Time.fixedDeltaTime / 100;

        if (isLeft)
        {
            _rigidbody.velocity = new Vector3(0.1f, 0, 0);

        }

        if (isRight)
        {
            _rigidbody.velocity = new Vector3(0.1f, 0, 0);

        }

        //if (time > 10.0f)
        //{
        //    Debug.Log(gameObject.transform.position.y + " : " + time);
        //    time = 0.0f;
        //}

    }

    public void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
        //    isPush = true;

        //}
        //isPush = true;

        //if (other.gameObject.CompareTag("Bin"))
        //{
        //    isMove = false;
        //    //speed = 0;

        //    Debug.Log("Bin");
        //}

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
        isRight = false;
        isLeft = false;
        isPush = false;
        Debug.Log("outofbox");
        MainPlayerController.instance.anim.SetBool("IsPush", false);
        //MainPlayerController.instance.anim.SetBool("IsPushHang", false);
        MainPlayerController.instance.charController.height = 1.86f;

    }
}
