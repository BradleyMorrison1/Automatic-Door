using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool openDoor;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("door"))
        {
            Debug.Log("Triggered");
            openDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("door"))
        {
            openDoor = false;
        }
    }
}
