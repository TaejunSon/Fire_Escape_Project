using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using TMPro;
using UnityEngine.SceneManagement;

public class SceneTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText; 
    private float startTime;
    public int sceneToLoad;

    void Start()
    {
        startTime = Time.time;
        GoToScene(sceneToLoad);
    }

    void Update()
    {
        float timeSinceStart = Time.time - startTime;
        timerText.text = FormatTime(timeSinceStart);
 
            

    }

    string FormatTime(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds); 
    }
    public void GoToScene(int SceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(SceneIndex));
    }
    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        yield return new WaitForSeconds(150);
        SceneManager.LoadScene(sceneIndex);
    }
}
