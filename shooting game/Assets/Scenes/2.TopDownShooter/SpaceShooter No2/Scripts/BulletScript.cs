using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;  // Apply velocity immediately
        Debug.Log("Bullet instantiated with velocity: " + rb.velocity);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Bullet hit: " + collider.gameObject.name);

        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(collider.gameObject);
        }

        Destroy(gameObject);
    }
}
