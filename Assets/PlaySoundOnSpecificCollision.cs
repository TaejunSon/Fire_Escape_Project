using System.Diagnostics;
using UnityEngine;

public class PlaySoundOnSpecificCollision : MonoBehaviour
{
 
    public AudioClip audioClip;
    private AudioSource audioSource; 

    void Start()
    {
 
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("RightController"))
        {


            audioSource.Play();

        }
    }
}
