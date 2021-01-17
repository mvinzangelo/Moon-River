using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] TextBox[] storyText;
    [SerializeField] int textIndex = 0;
    private bool startFade = true;
    private bool endFade = true;

    private void Start()
    {
        startFade = true;
        endFade = true;
        textIndex = 0;
    }
    private void Update()
    {
        Debug.Log(Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad >= storyText[textIndex].ReturnTimeSinceLoad() && startFade)
        {
            endFade = true;
            textComponent.text = storyText[textIndex].GetTextString();
            textComponent.GetComponent<FadeInFadeOutText>().TextStart();
            startFade = false;
            Debug.Log(textIndex);
        }
        if (Time.timeSinceLevelLoad >= storyText[textIndex].ReturnTimeSinceLoad() + storyText[textIndex].ReturnTextDuration() && endFade)
        {
            endFade = false;
            textComponent.GetComponent<FadeInFadeOutText>().TextEnd();
            textIndex += 1;
            startFade = true;
        }
    }
}
