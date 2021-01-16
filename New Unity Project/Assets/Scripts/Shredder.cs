using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    // destroy object when collided with
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // destroy the whole game object
        Destroy(collision.gameObject);
    }
}
