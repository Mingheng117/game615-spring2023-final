using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 1.5f;
    public bool isRun = false;
    public SpriteRenderer playerRender;
    public Animator Runanim;


    //public animator Idleanim;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRender.flipX = false;
            Runanim.SetBool("isRun", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Runanim.SetBool("isRun", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRender.flipX = true;
            Runanim.SetBool("isRun", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Runanim.SetBool("isRun", false);
        }





    }

}
