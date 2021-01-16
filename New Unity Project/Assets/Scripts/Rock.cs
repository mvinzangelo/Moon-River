using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float speed;
    public bool MoveLeft;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyRock();
    }

    private void DestroyRock()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

}
