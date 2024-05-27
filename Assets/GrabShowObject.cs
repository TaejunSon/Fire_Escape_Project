using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabShowObject : MonoBehaviour
{


    public XRGrabInteractable grabInteractable; // 그랩 가능한 물체의 XRGrabInteractable 컴포넌트
    public GameObject objectToMove; // 위치를 변경할 다른 물체

    void Update()
    {
        // 그랩 상태를 매 프레임마다 확인합니다.
        if (grabInteractable.isSelected)
        {
            // 첫 번째 물체가 그랩되었을 때, 두 번째 물체의 위치를 (100, 100, 100)으로 변경합니다.
            objectToMove.transform.position = new Vector3(10000, 100, 100);
        }
    }
}
