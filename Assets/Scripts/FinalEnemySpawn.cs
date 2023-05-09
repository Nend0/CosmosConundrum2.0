using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject bossPrefab;
    public int numEnemiesToSpawn;
    public float spawnDelay;
    public float spawnRange;
    private int numEnemiesSpawned;
    private bool isBossSpawned;

    private void Start()
    {
        numEnemiesSpawned = 0;
        isBossSpawned = false;
    }

    public void EnemyKilled()
    {
        numEnemiesSpawned++;

        if (!isBossSpawned && numEnemiesSpawned >= numEnemiesToSpawn)
        {
            isBossSpawned = true;
            Instantiate(bossPrefab, transform.position, Quaternion.identity);
        }
    }

    public void SpawnEnemy()
    {
        if (!isBossSpawned)
        {
            Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRange;
            spawnPos.y = 0f; // Make sure the enemy is spawned at ground level
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            Invoke("SpawnEnemy", spawnDelay);
        }
    }
}