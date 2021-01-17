using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flower : MonoBehaviour
{
    [SerializeField] AudioClip[] chime;
    public float speed;
    public bool MoveLeft;
    [SerializeField] ScoreUI scoreUI;
    [SerializeField] int pointValue = 10;
    [SerializeField] float chimeVolume = 0.2f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyFlower();
        int randomChime = Random.Range(0, chime.Length);
        AudioSource.PlayClipAtPoint(chime[randomChime], Camera.main.transform.position, chimeVolume);
    }

    private void DestroyFlower()
    {
        
        scoreUI.IncreaseScore(pointValue);
        Destroy(gameObject);
    }

    private void Update()
    {
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }
}
