using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorFUp : MonoBehaviour
{
    public GameObject player;
    public GameObject elevatorWall;
    GameObject nowplayer;
    public Animator goUp;
    public GameObject checkpoint;
    public bool isUp = false;
    // Start is called before the first frame update
    void Start()
    {
        nowplayer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            goUp.SetBool("isUp", true);
            nowplayer.transform.position = checkpoint.transform.position;
            elevatorWall.SetActive(true);

        }
    }
}
