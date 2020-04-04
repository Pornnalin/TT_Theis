using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EventAnimPost : MonoBehaviour
{
    Animator anim;
    public GameObject blockWay;
    public GameObject[] des;
    Color newCol;
    bool bConverted;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        blockWay.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        //ChangColorFog();
        if (bConverted)
        {
            bConverted = ColorUtility.TryParseHtmlString("#806C61", out newCol);
            RenderSettings.fogColor = newCol;
           

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
           
            Debug.Log("changclolo");
            anim.SetBool("Play", true);
            blockWay.SetActive(true);
            foreach(GameObject game in des)
            {
                Destroy(game);
            }
            bConverted = true;
            //RenderSettings.fogColor = newCol;
            //bConverted = ColorUtility.TryParseHtmlString("A17C67", out newCol);

        }
    }

   
}
