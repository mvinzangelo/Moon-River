using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    Rock rock;
    // Start is called before the first frame update
    void Start()
    {
        Health health = new Health(3);
        currentHealth = health.GetHealth();
        Debug.Log("Health: " + currentHealth);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        Debug.Log("COLLISION");

        if (collision.gameObject.name == "Rock")
        {
            currentHealth -= 1;
            Debug.Log("Health: " + currentHealth);
        }

        if (collision.gameObject.name == "Flower")
        {
            currentHealth += 1;
            Debug.Log("Health: " + currentHealth); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
