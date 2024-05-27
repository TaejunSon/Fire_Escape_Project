using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class LightAction : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    public InputActionReference xButtonActionReference;
    private bool isGrabbed = false;
    public Light directionalLight; // Directional Light ����
    public Light spotLight; // Spot Light ����

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(OnGrabbed); // �׷� �̺�Ʈ�� ������ �߰�
            grabInteractable.onSelectExited.AddListener(OnReleased); // ������ �̺�Ʈ�� ������ �߰�
        }

        xButtonActionReference.action.performed += OnXButtonPressed; // ��ư �̺�Ʈ�� ������ �߰�
        spotLight.enabled = false; // ó���� Spot Light ����
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        isGrabbed = true;

        // Directional Light ����
        directionalLight.enabled = false;
    }

    private void OnReleased(XRBaseInteractor interactor)
    {
        isGrabbed = false;

        // Directional Light �ѱ� �� Spot Light ����
        directionalLight.enabled = true;
        spotLight.enabled = false;
    }

    private void OnXButtonPressed(InputAction.CallbackContext context)
    {
        if (isGrabbed)
        {
            // Spot Light �ѱ�
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
