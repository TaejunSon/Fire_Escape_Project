using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class LightAction : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    public InputActionReference xButtonActionReference;
    private bool isGrabbed = false;
    public Light directionalLight; // Directional Light 참조
    public Light spotLight; // Spot Light 참조

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(OnGrabbed); // 그랩 이벤트에 리스너 추가
            grabInteractable.onSelectExited.AddListener(OnReleased); // 릴리즈 이벤트에 리스너 추가
        }

        xButtonActionReference.action.performed += OnXButtonPressed; // 버튼 이벤트에 리스너 추가
        spotLight.enabled = false; // 처음에 Spot Light 끄기
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        isGrabbed = true;

        // Directional Light 끄기
        directionalLight.enabled = false;
    }

    private void OnReleased(XRBaseInteractor interactor)
    {
        isGrabbed = false;

        // Directional Light 켜기 및 Spot Light 끄기
        directionalLight.enabled = true;
        spotLight.enabled = false;
    }

    private void OnXButtonPressed(InputAction.CallbackContext context)
    {
        if (isGrabbed)
        {
            // Spot Light 켜기
            spotLight.enabled = true;
        }
    }

    void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnGrabbed);
            grabInteractable.onSelectExited.RemoveListener(OnReleased);
        }

        xButtonActionReference.action.performed -= OnXButtonPressed;
    }
}
