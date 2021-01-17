using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    Health health;
    
    void Start()
    {
        Health health = new Health(3);
        Debug.Log("Health: " + health.GetHealth());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COLLISION");
        health.Damage(1);
        Debug.Log("Health: " + health.GetHealth());
    }

}
