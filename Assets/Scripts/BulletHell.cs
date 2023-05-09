using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHell : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    public float bulletSpeed = 5.0f;
    public float bulletLifetime = 2.0f;
    public int numberOfShots = 5;
    public float bulletSpread = 30.0f;
    public float spiralSpeed = 5.0f;
    public float spiralRadius = 2.0f;
    public float spiralOffset = 0.0f;

    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            for (int i = 0; i < numberOfShots; i++)
            {
                float angle = (360.0f / numberOfShots) * i + spiralOffset;
                float rad = angle * Mathf.Deg2Rad;

                Vector2 direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
                direction += Random.insideUnitCircle * bulletSpread;

                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * bulletSpeed;
                Destroy(bullet, bulletLifetime);
            }

            spiralOffset += spiralSpeed;
            transform.position += new Vector3(Mathf.Cos(spiralOffset) * spiralRadius, Mathf.Sin(spiralOffset) * spiralRadius, 0);
        }
    }

    private float nextFire = 0.0f;
}