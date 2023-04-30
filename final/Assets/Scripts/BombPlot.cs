using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlot : MonoBehaviour
{
    GameObject player;
    GameObject futureplayer;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        futureplayer = GameObject.Find("FuturePlayer");
        
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
            Destroy(player);
            Destroy(futureplayer);
        }
    }
}
