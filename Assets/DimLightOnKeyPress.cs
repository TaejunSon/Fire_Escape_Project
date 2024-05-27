using UnityEngine;

public class DimLightOnKeyPress : MonoBehaviour
{
    public Light directionalLight; // ������ Directional Light
    public float dimAmount = 0.1f; // ��⸦ ���� ��

    void Update()
    {
        // 'B' Ű�� ���ȴ��� üũ�մϴ�.
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Directional Light�� ��⸦ ���Դϴ�.
            directionalLight.intensity -= dimAmount;

            // ��Ⱑ 0���� �۾����� �ʵ��� �մϴ�.
            if (directionalLight.intensity < 0)
            {
                directionalLight.intensity = 0;
            }
        }
    }
}
