using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorCollision : MonoBehaviour
{
    static public bool DoorCollision_message = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Message Here for becareful of doorknob.");
            other.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.position += new Vector3(0f, 0f, 2f);
            other.GetComponent<CharacterController>().enabled = true;
            DoorCollision_message = true;
        }
    }
}
