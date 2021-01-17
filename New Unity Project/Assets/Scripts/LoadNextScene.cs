using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;
    [SerializeField] float loadingTime = 120f;
    [SerializeField] bool goToStart = false;
    // Start is called before the first frame update
    public void StartLoadingNextScene()
    {
        if (goToStart)
        {
            StartCoroutine(LoadToStart());
        }
        else
        {
            StartCoroutine(Loading());
        }

    }

    IEnumerator Loading()
    {
        yield return new WaitForSecondsRealtime(loadingTime);
        sceneLoader.LoadNextScene();
    }
    IEnumerator LoadToStart()
    {
        yield return new WaitForSecondsRealtime(loadingTime);
        sceneLoader.LoadStartScene();
    }
}
