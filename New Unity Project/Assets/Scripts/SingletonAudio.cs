using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonAudio : MonoBehaviour
{
    private static SingletonAudio instance = null;
    public static SingletonAudio Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        GetComponent<AudioSource>().Play(0);
    }
}
