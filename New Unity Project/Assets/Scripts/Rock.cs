using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] AudioClip damage;
    [SerializeField] float damageVolume = .2f;
    [SerializeField] int pointValue = -20;
    [SerializeField] ScoreUI scoreUI;
    public float speed;
    public bool MoveLeft;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyRock();
        AudioSource.PlayClipAtPoint(damage, Camera.main.transform.position, damageVolume);

    }

    private void DestroyRock()
    {
        scoreUI.DecreaseScore(pointValue);
        Destroy(gameObject);
    }

    private void Update()
    {
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

}
