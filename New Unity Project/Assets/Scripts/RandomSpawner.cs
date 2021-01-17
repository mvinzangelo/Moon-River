using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    [SerializeField] float spawnDelay = 3f;
    [SerializeField] float startSpawnDelay = 15f;
    [SerializeField] float rockChance;
    // Start is called before the first frame update
    public void StartSpawning()
    {
        StartCoroutine(StartSpawn());
    }

     IEnumerator StartSpawn()
    {
        yield return new WaitForSecondsRealtime(startSpawnDelay);
        StartCoroutine(SpawnRandomEnemy());
    }

    IEnumerator SpawnRandomEnemy()
    {
        
        int randEnemy = Random.Range(0, 100);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        int randomSpawn = Random.Range(0, enemyPrefabs.Length);
        int flipCoin = Random.Range(0, 2);
        //Instantiate(enemyPrefabs[randomSpawn], spawnPoints[randSpawnPoint].position, transform.rotation);
        if (randEnemy >= 1 && randEnemy <= rockChance)
        {
            GameObject enemy = Instantiate(enemyPrefabs[1], spawnPoints[randSpawnPoint].position, transform.rotation);
            Destroy(enemy, 20f);
        }
        else 
        {
            if (flipCoin == 0)
            {
                GameObject enemy = Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
                Destroy(enemy, 20f);
            }
            else
            {
                GameObject enemy = Instantiate(enemyPrefabs[2], spawnPoints[randSpawnPoint].position, transform.rotation);
                Destroy(enemy, 20f);
            }
        }
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(SpawnRandomEnemy());
        
    }
}
