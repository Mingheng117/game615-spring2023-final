using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombPlot : MonoBehaviour
{
    public string targetScene;

    // Start is called before the first frame update
    void Start()
    {
        
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
            SceneManager.LoadScene(targetScene);
        }
    }
}
