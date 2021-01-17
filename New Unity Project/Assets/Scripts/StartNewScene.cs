using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewScene : MonoBehaviour
{
    [SerializeField] RandomSpawner randomSpawner;
    [SerializeField] LoadNextScene loadNext;
    void Start()
    {
        loadNext.StartLoadingNextScene();
        randomSpawner.StartSpawning();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
