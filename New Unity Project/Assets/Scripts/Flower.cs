using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flower : MonoBehaviour
{
    [SerializeField] AudioClip[] chime;
    public float speed;
    public bool MoveLeft;
    [SerializeField] int pointValue = 10;
    [SerializeField] float chimeVolume = 0.2f;
    [SerializeField] GameObject flowerHitVFX;
    [SerializeField] float flowerDuration = 2f;
    [SerializeField] ScoreUI scoreUI;
    [SerializeField] Sprite[] sprites;

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
        GameObject flowerVFX = Instantiate(flowerHitVFX, transform.position, Quaternion.Euler(-179, 89, -90));
        Destroy(flowerVFX, flowerDuration);
    }

    private void Update()
    {
        transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
    }

    private void Start()
    {
        scoreUI = FindObjectOfType<ScoreUI>();
        int randomSprite = Random.Range(0, 2);
        GetComponent<SpriteRenderer>().sprite = sprites[randomSprite];
    }
}
