using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorDown : MonoBehaviour
{
    public GameObject player;
    public Animator goDown;
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
            goDown.SetBool("isDown", true);
        }
    }
}
