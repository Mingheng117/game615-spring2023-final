using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour
{
    GameObject player;
    GameObject futureplayer;
    GameObject checkpoint;
    GameObject futurecheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        futureplayer = GameObject.Find("FuturePlayer");
        checkpoint = GameObject.Find("checkPointC2");
        futurecheckpoint = GameObject.Find("checkPointF2");
        //GameObject gm = GameObject.Find("GameMagager");
        //GameManager isnow = gm.GetComponent<GameManager>();
        //nowPlayerRender = isnow;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //player.transform.position = respawn.transform.position;
            //GameObject dzObj = GameObject.Find("DeadZone");
            //DeadZone dz = dzObj.GetComponent<DeadZone>();
            //player.transform.position = dz.nowCheckPoint.transform.position;
            player.transform.position = checkpoint.transform.position;
            futureplayer.transform.position = futurecheckpoint.transform.position;
            //Debug.Log("yes");
        }
    }
}
