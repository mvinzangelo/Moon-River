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

        if (collision.gameObject.name == "Rock" || collision.gameObject.name == "Rock(Clone)")
        {
            
            currentHealth -= 1;
            
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
            Debug.Log("Health: " + currentHealth);

        }
        
        if (currentHealth == 0)
        {
            isDead = true;
            Debug.Log("MAN IM DEAD");
        }

        if (collision.gameObject.name == "Flower" || collision.gameObject.name == "Flower(Clone)")
        {
            currentHealth += 1;
            if (currentHealth > 2)
            {
                currentHealth = 3;
            }
            Debug.Log("Health: " + currentHealth);
            
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
