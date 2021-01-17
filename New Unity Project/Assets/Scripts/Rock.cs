using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] AudioClip damage;
    [SerializeField] float damageVolume = .2f;
    [SerializeField] int pointValue = 20;
    [SerializeField] ScoreUI scoreUI;
    public float speed;
    public bool MoveLeft;
    [SerializeField] GameObject rockHitVFX;
    [SerializeField] float rockHitTime = 2f;
    [SerializeField] HeartsUI heartsUI;
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] Sprite[] rockSprites;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyRock();
        AudioSource.PlayClipAtPoint(damage, Camera.main.transform.position, damageVolume);
    }
    private void Start()
    {
        scoreUI = FindObjectOfType<ScoreUI>();
        heartsUI = FindObjectOfType<HeartsUI>();
        playerHealth = FindObjectOfType<PlayerHealth>();
        int rockIndex = Random.Range(0, 2);
        GetComponent<SpriteRenderer>().sprite = rockSprites[rockIndex];

    }

    private void DestroyRock()
    {
        if (scoreUI.GetCurrentScore() >= pointValue)
        {
            scoreUI.DecreaseScore(pointValue);
        }
        heartsUI.DecreaseHealth();
        Destroy(gameObject);
        GameObject rockVFX = Instantiate(rockHitVFX, transform.position, transform.rotation);
        Destroy(rockVFX, rockHitTime);
    }

    private void Update()
    {
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

}
