using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    //public FadeScreen fadeScreen;
    // Start is called before the first frame update
    public void GoToScene(int SceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(SceneIndex));
    }
    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        //fadeScreen.FadeOut();
        //yield return new WaitForSeconds(fadeScreen.fadeDuration);
        yield return null;
        SceneManager.LoadScene(sceneIndex);
    }

    public void GoToSceneAsync(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
        //StartCoroutine(GoToSceneAsyncRoutine(SceneIndex));
    }
    IEnumerator GoToSceneAsyncRoutine(int sceneIndex)
    {
        // fadeScreen.FadeOut();

        UnityEngine.AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;

        //float timer = 0;
        /*while(timer < fadeScreen.fadeDuration &&!operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }
        */
        yield return null;
        operation.allowSceneActivation = true;
    }
}
