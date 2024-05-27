using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class RotateOnGrab : MonoBehaviour
{
    public Transform childToRotate; // ȸ����ų ���� ��ü
    private XRGrabInteractable grabInteractable; // XR �׷� ���ͷ��ͺ� ������Ʈ
    public Vector3 movementOffset = new Vector3(457.4f, 226.8f, -4.3f);
    public InputActionReference xButtonActionReference; // X ��ư Input Action ����
    private bool isGrabbed = false; // �׷� ���� ����
    public GameObject objectToDisappear;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(OnGrabbed); // �׷� �̺�Ʈ�� ������ �߰�
            grabInteractable.onSelectExited.AddListener(OnReleased); // ������ �̺�Ʈ�� ������ �߰�
        }

        xButtonActionReference.action.performed += OnXButtonPressed; // ��ư �̺�Ʈ�� ������ �߰�
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        UnityEngine.Debug.Log("Grabbed");
        isGrabbed = true;

        if (childToRotate != null)
        {
            childToRotate.Rotate(0, 0, 66, Space.Self);
            childToRotate.localPosition += movementOffset;
        }
    }

    private void OnReleased(XRBaseInteractor interactor)
    {
        UnityEngine.Debug.Log("Released");
        isGrabbed = false;
    }

    private void OnXButtonPressed(InputAction.CallbackContext context)
    {
        if (isGrabbed && objectToDisappear != null)
        {
            objectToDisappear.SetActive(false);
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
