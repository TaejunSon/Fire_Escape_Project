using UnityEngine;

public class ShowObjectOnKeyPress : MonoBehaviour
{
    public GameObject objectToShow; // ǥ���� ������Ʈ

    void Start()
    {
        // ������ ���۵� �� ������Ʈ�� ��Ȱ��ȭ�մϴ�.
        objectToShow.SetActive(false);
    }

    void Update()
    {
        // 'A' Ű�� ó�� ������ ���� üũ�մϴ�.
        if (Input.GetKeyDown(KeyCode.A))
        {
            // ������Ʈ�� Ȱ��ȭ�մϴ�.
            objectToShow.SetActive(true);
        }
    }
}
