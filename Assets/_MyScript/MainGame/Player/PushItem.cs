using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushItem : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float speed;
    Vector3 dir;
    public float disGround;

    public bool isPush;
    bool isLeft;
    bool isRight;
     public bool isMove;

    //public BlockBin blockBin;
    // Start is called before the first frame update
    void Start()
    {
        isPush = false;
        _rigidbody = GetComponent<Rigidbody>();
        //_rigidbody.isKinematic = true;
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
                    isMove = true;
                    MainPlayerController.instance.anim.speed = 0f;

                    if (Input.GetKey(KeyCode.D) && !MainPlayerController.instance.isCrouched && isMove) 
                    {

                        MainPlayerController.instance.anim.speed = 1f;
                        MainPlayerController.instance.anim.SetBool("IsPush", true);
                        transform.Translate(Vector3.right * Time.deltaTime * speed);
                        //MainPlayerController.instance.charController.height = 1.7f;
                    }

                   

                }


                else if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 180)
                {
                    isPush = true;
                    isMove = true;

                    MainPlayerController.instance.anim.speed = 0f;

                    if (Input.GetKey(KeyCode.A) && !MainPlayerController.instance.isCrouched && isMove) 
                    {

                        MainPlayerController.instance.anim.speed = 1f;
                        MainPlayerController.instance.anim.SetBool("IsPush", true);
                        transform.Translate(Vector3.left * Time.deltaTime * speed);
                        //MainPlayerController.instance.charController.height = 1.7f;
                    }
                }


            }
            else
            {
                MainPlayerController.instance.anim.SetBool("IsPush", false);
            }
        }

       
    }
    public void FixedUpdate()
    {
        CheckFloat();
    }

    public void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
        //    isPush = true;

        //}
        //isPush = true;

        if (other.gameObject.CompareTag("Bin"))
        {
            isMove = false;
            speed = 0;

            Debug.Log("Bin");
        }

        if (other.gameObject.CompareTag("FloorGlass"))
        {
            SoundManager.soundManager.audioS.volume = 1f;
            SoundManager.soundManager.PlaySound(soundInGame.glass_sound);
            _rigidbody.isKinematic = true;

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
        Debug.Log("outofbox");
        MainPlayerController.instance.anim.SetBool("IsPush", false);
        //MainPlayerController.instance.anim.SetBool("IsPushHang", false);
        MainPlayerController.instance.charController.height = 1.86f;

    }

    public void CheckFloat()
    {
        //if (isCrouched)
        //{
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, Vector3.down, disGround + 0.1f))
        {
            Debug.DrawLine(transform.position, Vector3.down, Color.red);
            Debug.Log("box in air");
           _rigidbody.isKinematic = false;
           

        }
        else
        {
            _rigidbody.isKinematic = true;

        }
    }

    //public void checkRotaion()
    //{
    //    if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 0)
    //    {
    //        //MainPlayerController.instance.anim.SetBool("IsPush", true);
    //        MainPlayerController.instance.charController.height = 1.7f;

    //        if (Input.GetKey(KeyCode.D))
    //        {
    //            transform.Translate(Vector3.right * Time.deltaTime);

    //        }


    //        //MainPlayerController.instance.anim.SetBool("IsPush", true);
    //        //MainPlayerController.instance.charController.height = 1.7f;
    //        ////rigidbody.velocity = Vector3.right * Time.deltaTime * speed;
    //        //transform.Translate(Vector3.right * Time.deltaTime);

    //        Debug.Log("0");
    //    }
    //    if (MainPlayerController.instance.playerModel.transform.rotation.eulerAngles.y == 180)
    //    {
    //        //MainPlayerController.instance.anim.SetBool("IsPush", true);
    //        MainPlayerController.instance.charController.height = 1.7f;

    //        if (Input.GetKey(KeyCode.A))
    //        {
    //            transform.Translate(Vector3.left * Time.deltaTime);

    //        }


    //        //rigidbody.velocity = Vector3.right * Time.deltaTime * speed;


    //        Debug.Log("180");
    //    }
    //}
}
