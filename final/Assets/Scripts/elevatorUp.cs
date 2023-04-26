using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorUp : MonoBehaviour
{

    public GameObject player;
    public Animator goUp;
    public bool isUp = false;
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
            goUp.SetBool("isUp", true);
        }
    }
}
