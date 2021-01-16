﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    [SerializeField] Sprite[] healthSprites;
    [SerializeField] int healthIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetHealthToFull();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            IncreaseHealth();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DecreaseHealth();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetHealthToFull();
        }
    }

    public void SetHealthToFull()
    {
        healthIndex = 0;
        GetComponent<Image>().sprite = healthSprites[healthIndex];
    }

    public void DecreaseHealth()
    {
        healthIndex += 1;
        GetComponent<Image>().sprite = healthSprites[healthIndex];
    }

    public void IncreaseHealth()
    {
        healthIndex -= 1;
        GetComponent<Image>().sprite = healthSprites[healthIndex];
    }

}