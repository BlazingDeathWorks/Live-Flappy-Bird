using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpPower = 1;
    private Rigidbody2D rb;
    private bool canJump = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }
    }

    private void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
            rb.velocity = Vector2.up * jumpPower;
        }
    }
}
