using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject nowPlayer;
    public GameObject futurePlayer;
    public GameObject nowCheckPoint;
    public GameObject futureCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            nowPlayer.transform.position = nowCheckPoint.transform.position;
            futurePlayer.transform.position = futureCheckPoint.transform.position;
        }
    }
}
