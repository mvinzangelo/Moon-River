using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public bool isDead = false;
    [SerializeField] HeartsUI heartsUI; // make sure to re-add commented lines once heart sprites are implemented
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 3;
        Debug.Log("Health: " + currentHealth);
        //heartsUI.SetHealthToFull();
    }



    void OnCollisionEnter2D(Collision2D collision)
    { 
        Debug.Log("COLLISION");

        // Check if collided with flower. If so, add 1 to current health, capped at 3.
        // If collided with anything else, subtract 1 to current health, capped to 0.
        // If health is 0, set isDead to true. 
        // If isDead is true, go to the Game Over scene.

        if (collision.gameObject.tag == "Rose")
            {
            if (currentHealth < 3)
            {
                currentHealth += 1;
            }
                Debug.Log("Health: " + currentHealth);

            }
        else if (collision.gameObject.tag == "Obstacles")
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
