using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public Vector3 doorPos;
    public float moveSpeed = 4f;

    public static bool openDoorBool;

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
        if (doorPos.y < 2)
        {
            door.transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
    }

    public void CloseDoor()
    {
        if (doorPos.y > 0)
        {
            door.transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
    }
}
