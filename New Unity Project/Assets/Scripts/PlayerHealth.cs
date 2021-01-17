using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (collision.gameObject.name == "Flower" || collision.gameObject.name == "Flower(Clone)")
            {
                currentHealth += 1;
                if (currentHealth > 2)
                {
                    currentHealth = 3;
                }
                Debug.Log("Health: " + currentHealth);

            }
        else
        {
            currentHealth -= 1;

            if (currentHealth < 1)
            {
                currentHealth = 0;
                isDead = true;
                Debug.Log("MAN IM DEAD");
                Object.Destroy(gameObject);
            }
            Debug.Log("Health: " + currentHealth);
        }

        if (isDead)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public int GetHealth()
    {
        return currentHealth;
        // USE THIS TO REFERENCE HEALTH IN OTHER SCRIPTS
    }

    public bool PlayerDead()
    {
        return isDead;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
