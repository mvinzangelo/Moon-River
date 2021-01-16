using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyRock();
    }

<<<<<<< Updated upstream
    private void DestroyRock() 
    {
        Destroy(gameObject);
    }
=======
    private void DestroyRock()
    {
        Destroy(gameObject);
    }

>>>>>>> Stashed changes
}
