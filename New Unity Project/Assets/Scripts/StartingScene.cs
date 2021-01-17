using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI playButtonText;
    [SerializeField] Camera MainCam;
    [SerializeField] float textMoveSpeed = 2f;
    [SerializeField] float cameraMoveSpeed = 2f;
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            titleText.transform.Translate(0, textMoveSpeed * Time.deltaTime, 0);
            playButtonText.transform.Translate(0, textMoveSpeed * Time.deltaTime, 0);
            MainCam.transform.Translate(0, -cameraMoveSpeed * Time.deltaTime, 0);
            if (MainCam.transform.position.y <= 0)
            {
                move = false;
            }
        }

    }

    public void MoveTextBoxes()
    {
        move = true;
    }
    
}
