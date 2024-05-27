using UnityEngine;

public class TouchColorChange : MonoBehaviour
{
    public static bool ElevatorBool = false;
    public GameObject subObject; // ���� ������ ���� ������Ʈ
    public AudioClip audioClip; // ����� ����� Ŭ��
    private AudioSource audioSource; // ����� �ҽ� ������Ʈ

    void Start()
    {
        // ����� �ҽ� ������Ʈ�� �ʱ�ȭ�մϴ�.
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
