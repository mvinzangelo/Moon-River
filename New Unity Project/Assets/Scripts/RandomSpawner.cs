using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    [SerializeField] float spawnDelay = 3f;
    // Start is called before the first frame update
    public void StartSpawning()
    {
        StartCoroutine(SpawnRandomEnemy());
    }
    IEnumerator SpawnRandomEnemy()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        int randomSpawn = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[randomSpawn], spawnPoints[randSpawnPoint].position, transform.rotation);
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(SpawnRandomEnemy());
    }
}
