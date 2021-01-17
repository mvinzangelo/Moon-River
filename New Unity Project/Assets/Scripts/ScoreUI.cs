using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] int currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void ResetScore()
    {
        currentScore = 0;
        GetComponent<TextMeshProUGUI>().text = currentScore.ToString();
    }
    
    public void IncreaseScore(int pointValue)
    {
        currentScore += pointValue;
        GetComponent<TextMeshProUGUI>().text = currentScore.ToString();
    }

    public void DecreaseScore(int pointValue)
    {
        currentScore -= pointValue;
        GetComponent<TextMeshProUGUI>().text = currentScore.ToString();
    }
}
