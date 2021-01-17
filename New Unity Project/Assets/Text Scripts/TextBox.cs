using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Text", menuName = "Text")] 
public class TextBox : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string textBoxText;
    [SerializeField] float timeSinceLoad;
    [SerializeField] float textDuration;

    public string GetTextString()
    {
        return textBoxText;
    }
    public float ReturnTimeSinceLoad()
    {
        return timeSinceLoad;
    }
    public float ReturnTextDuration()
    {
        return textDuration;
    }
}
