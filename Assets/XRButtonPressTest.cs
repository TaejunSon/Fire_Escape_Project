using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System.Diagnostics;

public class XRButtonPressTest : MonoBehaviour
{
    public InputActionReference xButtonActionReference; 

    private void OnEnable()
    {
        
        xButtonActionReference.action.performed += OnXButtonPressed;
    }

    private void OnDisable()
    {
       
        xButtonActionReference.action.performed -= OnXButtonPressed;
    }

    private void OnXButtonPressed(InputAction.CallbackContext context)
    {
        UnityEngine.Debug.Log("Yes");
    }
}
