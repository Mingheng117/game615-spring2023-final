using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public GameObject player;
    public GameObject futureplayer;
    public GameObject CheckPoint;
    public GameObject FCheckPoint;

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
            player.transform.position = CheckPoint.transform.position;
            futureplayer.transform.position = FCheckPoint.transform.position;
        }
    }
}
