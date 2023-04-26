using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public bool isRun = false;
    public bool isJump = false;
    public SpriteRenderer playerRender;
    public Animator Runanim;
    public Animator Jumpanim;
    public GameObject bombs;
    public GameObject bombsSpawnPoint;


    //public animator Idleanim;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerRender.flipX = false;
            Runanim.SetBool("isRun", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Runanim.SetBool("isRun", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRender.flipX = true;
            Runanim.SetBool("isRun", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Runanim.SetBool("isRun", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Runanim.SetBool("isRun", false);
            Jumpanim.SetBool("isJump", true);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jumpanim.SetBool("isJump", false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BombRespawn"))
        {
            GameObject bomb = Instantiate(bombs, bombsSpawnPoint.transform.position, Quaternion.identity);
        }
    }

}
