using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -5f;
    public float maxY = 5f;

    private Vector2 targetPosition;

    void Start()
    {
        // Set the initial target position to a random location within the range
        targetPosition = GetRandomPosition();
    }

    void Update()
    {
        // Move towards the target position
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // If the target position is reached, get a new random position
        if ((Vector2)transform.position == targetPosition)
        {
            targetPosition = GetRandomPosition();
        }
    }

    private Vector2 GetRandomPosition()
    {
        // Generate a random position within the specified range
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector2(randomX, randomY);
    }
}