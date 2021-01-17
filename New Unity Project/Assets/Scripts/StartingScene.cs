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
    [SerializeField] HeartsUI healthUI;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float scoreMoveSpeed = 2f;
    [SerializeField] float healthMoveSpeed = 2f;
    bool move = false;
    bool secondMove = false;
    bool thirdMove = false;
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
                secondMove = true;
                thirdMove = true;
            }
        }
        if (secondMove == true)
        {
            healthUI.transform.Translate(0, -healthMoveSpeed * Time.deltaTime, 0);
            if (healthUI.transform.position.y <= 960)
            {
                secondMove = false;
            }
        }
        if (thirdMove == true)
        {
            scoreText.transform.Translate(0, -scoreMoveSpeed * Time.deltaTime, 0);
            if (healthUI.transform.position.y <= 960)
            {
                thirdMove = false;
            }
        }

    }

    public void MoveTextBoxes()
    {
        move = true;
    }
    
}
