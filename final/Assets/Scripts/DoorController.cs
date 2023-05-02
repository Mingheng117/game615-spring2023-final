using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public float doorMoveSpeed = 1.0f;
    private Vector3 doorInitialPosition;
    private bool doorMovingUp = false;

    void Start()
    {
        doorInitialPosition = door.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorMovingUp = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorMovingUp = false;
        }
    }

    void Update()
    {
        if (doorMovingUp)
        {
            door.transform.position += Vector3.up * doorMoveSpeed * Time.deltaTime;
        }
        else
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, doorInitialPosition, doorMoveSpeed * Time.deltaTime);
        }
    }
}
