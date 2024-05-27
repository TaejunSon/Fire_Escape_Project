using UnityEngine;

public class FallOnCollision : MonoBehaviour
{
    public Transform objectToFall; // ������ ������Ʈ
    private bool shouldFall = false; // �������� ���θ� �����ϴ� �÷���
    private float rotationSpeed = 20f; // �ʴ� ȸ�� �ӵ� (��)

    void Update()
    {
        // shouldFall�� true�� ���, ������Ʈ�� ������ ȸ����ŵ�ϴ�.
        if (shouldFall)
        {
            objectToFall.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            Debug.Log("Collision Checking");
        }
    }

    // Ư�� �ݶ��̴��� Player �±׸� ���� ������Ʈ�� ����� �� ȣ��˴ϴ�.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldFall = true; // �������� ���� ����
        }
    }
}
