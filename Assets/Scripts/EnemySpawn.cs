using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;
    public Vector2 spawnBoundaryMin;
    public Vector2 spawnBoundaryMax;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnRate);
    }

    private void SpawnEnemy()
    {
        float spawnX = Random.Range(spawnBoundaryMin.x, spawnBoundaryMax.x);
        float spawnY = Random.Range(spawnBoundaryMin.y, spawnBoundaryMax.y);
        Vector2 spawnPosition = new Vector2(
            Mathf.Clamp(spawnX, spawnBoundaryMin.x, spawnBoundaryMax.x),
            Mathf.Clamp(spawnY, spawnBoundaryMin.y, spawnBoundaryMax.y)
        );
        Instantiate(enemyPrefab, spawnPosition + (Vector2)transform.position, Quaternion.identity);
    }
}