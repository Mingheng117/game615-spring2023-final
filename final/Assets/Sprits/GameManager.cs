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
        if (Input.GetKeyDown(KeyCode.Space))
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
