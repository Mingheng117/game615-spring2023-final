using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.ParticleSystem;

public class bomb : MonoBehaviour
{
    float countDown = 10;
    public TMP_Text text;
    public GameObject boomParticle;
    public GameObject killZone;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown > 0) 
        {
            countDown -= Time.deltaTime;
        }
        text.text = Mathf.FloorToInt(countDown%60).ToString();

        if (countDown < 1)
        {
            killZone.SetActive(true);
            boomParticle.SetActive(true);
            Destroy(gameObject, 1.0f);
        }
    }
}
