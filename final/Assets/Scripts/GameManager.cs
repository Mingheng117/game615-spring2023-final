using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer futurePlayerRender;
    public Renderer nowPlayerRender;
    public GameObject nowPlayer;
    public GameObject futurePlayer;
    public bool isnow;
    public bool transport;

    public float abilityCooldown;
    private float timeSinceLastAbility = 0.0f;
    void Start()
    {
        isnow = true;
        transport = true;
        nowPlayerRender.enabled = true;
        futurePlayerRender.enabled = false;
        //Rigidbody rbF = futurePlayer.GetComponent<Rigidbody>();
        //rbF.useGravity = false;



    }


    void Update()
    {
        timeSinceLastAbility += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q) && timeSinceLastAbility >= abilityCooldown && transport)
        {
            timeSinceLastAbility = 0.0f;
            Teleport();
        }
        
    }

    void Teleport()
    {
        if (isnow == true)
        {
            nowPlayerRender.enabled = false;
            futurePlayerRender.enabled = true;
            isnow = false;
        }
        else
        {
            nowPlayerRender.enabled = true;
            futurePlayerRender.enabled = false;
            isnow = true;
        }
    }

}
