using UnityEngine;

public class TouchColorChange : MonoBehaviour
{
    public static bool ElevatorBool = false;
    public GameObject subObject; // 색을 변경할 하위 오브젝트
    public AudioClip audioClip; // 재생할 오디오 클립
    private AudioSource audioSource; // 오디오 소스 컴포넌트

    void Start()
    {
        // 오디오 소스 컴포넌트를 초기화합니다.
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Start");
      
            audioSource.Play();

            ElevatorBool = true;
        }
    }
}
