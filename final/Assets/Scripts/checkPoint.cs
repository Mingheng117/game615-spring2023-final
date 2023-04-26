using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    private DeadZone respawn;
    private BoxCollider checkPointcollider;

    void Awake()
    {
        checkPointcollider = GetComponent<BoxCollider>();
        respawn = GameObject.FindGameObjectWithTag("DeadZone").GetComponent<DeadZone>();
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
            respawn.CheckPoint = this.gameObject;
            checkPointcollider.enabled = false;
        }
    }
}
