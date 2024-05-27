using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // 변경할 새 재질
    public GameObject targetObject; // 충돌 대상이 될 오브젝트
    private Renderer renderer; // 현재 오브젝트의 렌더러
    private bool hasCollided = false; // 충돌이 발생했는지 추적하는 플래그

    void Start()
    {
        // 오브젝트의 렌더러 컴포넌트를 가져옵니다.
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // 충돌이 발생했고, 아직 재질이 변경되지 않았다면
        if (hasCollided && renderer.material != newMaterial)
        {
            // 렌더러의 재질을 새 재질로 변경합니다.
            renderer.material = newMaterial;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 특정 오브젝트와의 접촉을 감지합니다.
        if (other.gameObject == targetObject)
        {
            // 충돌 플래그를 true로 설정합니다.
            hasCollided = true;
        }
    }
}
