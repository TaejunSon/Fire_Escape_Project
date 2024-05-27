using UnityEngine;

public class FallOnCollision : MonoBehaviour
{
    public Transform objectToFall; // 쓰러질 오브젝트
    private bool shouldFall = false; // 쓰러질지 여부를 결정하는 플래그
    private float rotationSpeed = 20f; // 초당 회전 속도 (도)

    void Update()
    {
        // shouldFall이 true일 경우, 오브젝트를 서서히 회전시킵니다.
        if (shouldFall)
        {
            objectToFall.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            Debug.Log("Collision Checking");
        }
    }

    // 특정 콜라이더에 Player 태그를 가진 오브젝트가 닿았을 때 호출됩니다.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldFall = true; // 쓰러지는 동작 시작
        }
    }
}
