using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 3;
        Debug.Log("Health: " + currentHealth);
    }



    void OnCollisionEnter2D(Collision2D collision)
    { 
        Debug.Log("COLLISION");

        if (collision.gameObject.name == "Rock")
        {
            
            currentHealth -= 1;
            Debug.Log("Health: " + currentHealth);
            if (currentHealth < 1)
            {
                currentHealth = 0;
                isDead = true;
            }
            
        }

        if (collision.gameObject.name == "Flower")
        {
            currentHealth += 1;
            Debug.Log("Health: " + currentHealth);
            if (currentHealth > 3)
            {
                currentHealth = 3;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
