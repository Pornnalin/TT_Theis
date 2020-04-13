using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCrack : MonoBehaviour
{
    public GameObject prefab;
    public GameObject origin;
    public Transform[] potionSpawn;
    public GameObject plummet;
    public GameObject switchLight;
    public Interact interact;
    public Animator plumAnim;
    bool isChangeColor;


    //public Transform postionSpawn;
    // Start is called before the first frame update
    void Start()
    {
        plummet.GetComponent<Rigidbody>().useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if ((interact.isPressE))
        {
            StartCoroutine(waitToFall());
            //isChangeColor = true;
        }

        //if (isChangeColor)
        //{
        //    switchLight.GetComponent<ChangeColor>().BeenHit();
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            SoundManager.soundManager.PlaySound(soundInGame.woodSmash_sound);
            SoundManager.soundManager.audioS.volume = 0.3f;
            Instantiate(prefab, potionSpawn[0].position, Quaternion.identity);
            Instantiate(prefab, potionSpawn[1].position, Quaternion.identity);
            Destroy(origin);
            Debug.Log("wodd");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            this.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    IEnumerator waitToFall()
    {
        plumAnim.SetBool("Fall", true);
      
        yield return new WaitForSeconds(2f);
        plumAnim.enabled = false;
        //plumAnim.SetBool("Fall", true);
        plummet.GetComponent<Rigidbody>().useGravity = true;
        interact.isPressE = false;
        Destroy(plummet, 5f);
    }

   
}
