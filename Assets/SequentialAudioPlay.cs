using UnityEngine;
using System.Collections;

public class SequentialAudioPlay : MonoBehaviour
{
    public AudioSource audioSource;    // AudioSource 컴포넌트
    public AudioClip[] audioClips;     // 재생할 오디오 클립 배열

    void Start()
    {
        // AudioSource 컴포넌트가 없는 경우 추가
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // 각 오디오 클립을 순차적으로 재생하는 코루틴 시작
        StartCoroutine(PlaySoundsSequentially());
    }

    IEnumerator PlaySoundsSequentially()
    {
        // 네 개의 오디오 클립에 대한 재생 시간 지연
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[0], 30));   // 30초 후
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[1], 60));   // 60초 후
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[2], 90));   // 90초 후
        yield return StartCoroutine(PlaySoundAfterDelay(audioClips[3], 120));  // 120초 후
    }

    IEnumerator PlaySoundAfterDelay(AudioClip clip, float delay)
    {
        // 지정된 지연 시간만큼 대기
        yield return new WaitForSeconds(delay);

        // 오디오 클립 재생
        audioSource.clip = clip;
        audioSource.Play();
    }
}
