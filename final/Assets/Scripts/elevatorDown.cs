using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorDown : MonoBehaviour
{
    public GameObject player;
    public GameObject elevatorWall;
    public Animator goDown1;
    public Animator goDown2;
    public bool isDown;
    // Start is called before the first frame update
    void Start()
    {
        isDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            goDown1.SetBool("isDown", true);
            goDown2.SetBool("isDown", true);
            elevatorWall.SetActive(true);
        }
    }
}
