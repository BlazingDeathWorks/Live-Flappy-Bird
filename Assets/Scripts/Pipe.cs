using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float lifeSpan = 5;
    public float speed = 1;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Destroy(gameObject, lifeSpan);
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * speed;
    }
}
