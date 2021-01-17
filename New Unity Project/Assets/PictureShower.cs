using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureShower : MonoBehaviour
{
    bool showOnce = true;
    [SerializeField] FadeInFadeOut fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > 11f && showOnce)
        {
            fade.FadeInBlack();
            showOnce = false;
        }
        if (Time.timeSinceLevelLoad > 18f && !showOnce)
        {
            fade.FadeOutBlack();
            showOnce = true;
        }
    }
}
