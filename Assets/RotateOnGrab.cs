using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class RotateOnGrab : MonoBehaviour
{
    public Transform childToRotate; // 회전시킬 하위 객체
    private XRGrabInteractable grabInteractable; // XR 그랩 인터랙터블 컴포넌트
    public Vector3 movementOffset = new Vector3(457.4f, 226.8f, -4.3f);
    public InputActionReference xButtonActionReference; // X 버튼 Input Action 참조
    private bool isGrabbed = false; // 그랩 상태 추적
    public GameObject objectToDisappear;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(OnGrabbed); // 그랩 이벤트에 리스너 추가
            grabInteractable.onSelectExited.AddListener(OnReleased); // 릴리즈 이벤트에 리스너 추가
        }

        xButtonActionReference.action.performed += OnXButtonPressed; // 버튼 이벤트에 리스너 추가
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
