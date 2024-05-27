using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class MessageDisplay : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    private float displayTime = 2.0f; 

    void Update()
    {
        if (DoorCollision.DoorCollision_message == true) 
        {
            StartCoroutine(DisplayMessage("The handle may be hot, so check before opening it."));
        }
    }

    IEnumerator DisplayMessage(string message)
    {
        messageText.text = message; 
        messageText.enabled = true; 
        yield return new WaitForSeconds(displayTime); 
        messageText.enabled = false;

        DoorCollision.DoorCollision_message = false;
    }
}
