using UnityEngine;

public class ShowObjectOnKeyPress : MonoBehaviour
{
    public GameObject objectToShow; // 표시할 오브젝트

    void Start()
    {
        // 게임이 시작될 때 오브젝트를 비활성화합니다.
        objectToShow.SetActive(false);
    }

    void Update()
    {
        // 'A' 키가 처음 눌렸을 때만 체크합니다.
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 오브젝트를 활성화합니다.
            objectToShow.SetActive(true);
        }
    }
}
