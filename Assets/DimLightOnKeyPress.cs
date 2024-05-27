using UnityEngine;

public class DimLightOnKeyPress : MonoBehaviour
{
    public Light directionalLight; // 조절할 Directional Light
    public float dimAmount = 0.1f; // 밝기를 줄일 양

    void Update()
    {
        // 'B' 키가 눌렸는지 체크합니다.
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Directional Light의 밝기를 줄입니다.
            directionalLight.intensity -= dimAmount;

            // 밝기가 0보다 작아지지 않도록 합니다.
            if (directionalLight.intensity < 0)
            {
                directionalLight.intensity = 0;
            }
        }
    }
}
