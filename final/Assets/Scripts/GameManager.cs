using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer futurePlayerRender;
    public Renderer nowPlayerRender;
    public bool isnow;
    void Start()
    {
        isnow = true;
        nowPlayerRender.enabled = true;
        futurePlayerRender.enabled = false;
        
    }


    void Update()
    {
        Invoke("Teleport", 1.0f);
    }

    void Teleport()
    {
        if (Input.GetKeyDown(KeyCode.Q))
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

}
