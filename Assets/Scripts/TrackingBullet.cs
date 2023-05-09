using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingBullet : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 200f;
    public Transform target;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            // Rotate towards the target
            Vector2 direction = (Vector2)target.position - rb.position;
            direction.Normalize();
            float rotateAmount = Vector3.Cross(direction, transform.right).z;
            rb.angularVelocity = -rotateAmount * rotateSpeed;

            // Move towards the target
            rb.velocity = transform.right * speed;
        }
        else
        {
            // If the target is null, destroy the bullet
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the bullet collides with an enemy, destroy both the bullet and the enemy
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}