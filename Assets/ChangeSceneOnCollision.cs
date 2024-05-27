using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public int sceneToLoad;

    void Start()
    {
        GoToScene(sceneToLoad);
    }
    public void GoToScene(int SceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(SceneIndex));
    }
    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneIndex);
    }

    
}