using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public Vector3 doorPos;
    public float startPos;
    public float moveSpeed = 4f;

    public static bool openDoorBool;
    private void Start()
    {
        doorPos = new Vector3(door.transform.position.x, door.transform.position.y, door.transform.position.z);
        startPos = doorPos.y;
    }

    void Update()
    {
        doorPos = new Vector3(door.transform.position.x, door.transform.position.y, door.transform.position.z);
        openDoorBool = Trigger.openDoor;
        if (openDoorBool)
        {
            Debug.Log("Opening");
            OpenDoor();
        }

        else if(!openDoorBool)
        {
            Debug.Log("Closing");
            CloseDoor();
        }
    }

    public void OpenDoor()
    {
        if (doorPos.y < startPos + 2)
        {
            door.transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
    }

    public void CloseDoor()
    {
        if (doorPos.y > startPos)
        {
            door.transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
    }
}
