using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roses : MonoBehaviour
{
    [SerializeField] AudioClip heal;
    public float speed;
    public bool MoveLeft;
    [SerializeField] ScoreUI scoreUI;
    [SerializeField] int pointValue = 10;
    [SerializeField] float healVolume = 0.2f;
    [SerializeField] GameObject roseHitVFX;
    [SerializeField] float roseDuration = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyRose();
        AudioSource.PlayClipAtPoint(heal, Camera.main.transform.position, healVolume);
    }

    private void DestroyRose()
    {
        scoreUI.IncreaseScore(pointValue);
        Destroy(gameObject);
        GameObject flowerVFX = Instantiate(roseHitVFX, transform.position, Quaternion.Euler(-179, 89, -90));
        Destroy(flowerVFX, roseDuration);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-2 * Time.deltaTime * speed, 0, 0); 
    }
}
