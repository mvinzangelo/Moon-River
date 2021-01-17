using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;
    [SerializeField] float loadingTime = 120f;
    // Start is called before the first frame update
    public void StartLoadingNextScene()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        Debug.Log("START LOAD");
        yield return new WaitForSecondsRealtime(loadingTime);
        sceneLoader.LoadNextScene();
    }
}
