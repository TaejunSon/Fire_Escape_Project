using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabShowObject : MonoBehaviour
{


    public XRGrabInteractable grabInteractable; // �׷� ������ ��ü�� XRGrabInteractable ������Ʈ
    public GameObject objectToMove; // ��ġ�� ������ �ٸ� ��ü

    void Update()
    {
        // �׷� ���¸� �� �����Ӹ��� Ȯ���մϴ�.
        if (grabInteractable.isSelected)
        {
            // ù ��° ��ü�� �׷��Ǿ��� ��, �� ��° ��ü�� ��ġ�� (100, 100, 100)���� �����մϴ�.
            objectToMove.transform.position = new Vector3(10000, 100, 100);
        }
    }
}
