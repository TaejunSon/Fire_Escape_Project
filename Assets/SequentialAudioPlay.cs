using UnityEngine;
using System.Collections;

public class SequentialAudioPlay : MonoBehaviour
{
    public AudioSource audioSource;    // AudioSource ������Ʈ
    public AudioClip[] audioClips;     // ����� ����� Ŭ�� �迭

    void Start()
    {
        // AudioSource ������Ʈ�� ���� ��� �߰�
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // �� ����� Ŭ���� ���������� ����ϴ� �ڷ�ƾ ����
        StartCoroutine(PlaySoundsSequentially());
    }

    IEnumerator PlaySoundsSequentially()
    {
        // �� ���� ����� Ŭ���� ���� ��� �ð� ����
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[0], 30));   // 30�� ��
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[1], 60));   // 60�� ��
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[2], 90));   // 90�� ��
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[3], 120));  // 120�� ��
    }

    IEnumerator PlaySoundAfterDelay(AudioClip clip, float delay)
    {
        // ������ ���� �ð���ŭ ���
        yield return new WaitForSeconds(delay);

        // ����� Ŭ�� ���
        audioSource.clip = clip;
        audioSource.Play();
    }
}
