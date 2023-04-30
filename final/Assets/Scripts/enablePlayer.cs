using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePlayer : MonoBehaviour
{
    public GameObject nowplayer;
    public GameObject futureplayer;
    private BoxCollider checkPointcollider;

    void Awake()
    {
        checkPointcollider = GetComponent<BoxCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nowplayer.GetComponent<playerController>().enabled = true;
            //Debug.Log("no1");
            futureplayer.GetComponent<playerController>().enabled = true;
            //Debug.Log("no2");
            checkPointcollider.enabled = false;
            //Debug.Log("no3");
        }
    }
}
