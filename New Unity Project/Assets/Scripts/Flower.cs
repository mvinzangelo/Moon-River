using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public float speed;
    public bool MoveLeft;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyFlower();
    }

    private void DestroyFlower()
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
