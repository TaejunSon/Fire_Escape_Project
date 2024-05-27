using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DoorCollsion_2 : MonoBehaviour
{

    static public bool DoorCollision_message = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Message Here for becareful of doorknob.");
            other.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.position += new Vector3(0f, 0f, -10f);
            other.GetComponent<CharacterController>().enabled = true;
            DoorCollision_message = true;
        }
    }
}


