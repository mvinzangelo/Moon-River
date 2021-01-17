using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] ScoreUI scoreUI;

    public void Increase(int pointValue)
    {
        scoreUI.IncreaseScore(pointValue);
    }
    public void Decrease(int pointValue)
    {
        scoreUI.DecreaseScore(pointValue);
    }
}
