using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewScene : MonoBehaviour
{
    [SerializeField] RandomSpawner randomSpawner;
    [SerializeField] LoadNextScene loadNext;
    [SerializeField] FadeInFadeOut fade;
    [SerializeField] float fadeInTime = 5f;
    private bool fadeInBlack = true;
    void Start()
    {
        fadeInBlack = true;
        loadNext.StartLoadingNextScene();
        randomSpawner.StartSpawning();
        fade.FadeOutBlack();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= fadeInTime && fadeInBlack)
        {
            fadeInBlack = false;
            fade.FadeInBlack();
        }
    }
}
