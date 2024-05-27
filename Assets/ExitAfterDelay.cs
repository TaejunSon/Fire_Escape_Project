using UnityEngine;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

public class ExitAfterDelay : MonoBehaviour
{
    void Start()
    {

        StartCoroutine(ExitApplicationAfterDelay(10)); 
    }

    IEnumerator ExitApplicationAfterDelay(float delay)
    {
       
        yield return new WaitForSeconds(delay);

       
        UnityEngine.Application.Quit();

     
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
