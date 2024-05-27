using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // ������ �� ����
    public GameObject targetObject; // �浹 ����� �� ������Ʈ
    private Renderer renderer; // ���� ������Ʈ�� ������
    private bool hasCollided = false; // �浹�� �߻��ߴ��� �����ϴ� �÷���

    void Start()
    {
        // ������Ʈ�� ������ ������Ʈ�� �����ɴϴ�.
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // �浹�� �߻��߰�, ���� ������ ������� �ʾҴٸ�
        if (hasCollided && renderer.material != newMaterial)
        {
            // �������� ������ �� ������ �����մϴ�.
            renderer.material = newMaterial;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Ư�� ������Ʈ���� ������ �����մϴ�.
        if (other.gameObject == targetObject)
        {
            // �浹 �÷��׸� true�� �����մϴ�.
            hasCollided = true;
        }
    }
}
