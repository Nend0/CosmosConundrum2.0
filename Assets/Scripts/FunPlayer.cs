using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunPlayer : MonoBehaviour
{
    public float speed;
    public GameObject laserPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(HorizontalInput * speed * Time.deltaTime * Vector2.right);
        transform.Translate(VerticalInput * speed * Time.deltaTime * Vector2.up);

        if (transform.position.y > 6.2f)
        {
            transform.position = new Vector2(transform.position.x, 6.2f);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector2(transform.position.x, -4.2f);
        }

        if (transform.position.x > 9.74f)
        {
            transform.position = new Vector2(9.74f, transform.position.y);
        }
        else if (transform.position.x < -9.73f)
        {
            transform.position = new Vector2(-9.73f, transform.position.y);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
