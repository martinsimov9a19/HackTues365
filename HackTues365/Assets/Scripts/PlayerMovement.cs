using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool isGrounded = true;

    private float fallmultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    [Range(1, 10)]
    public float jumpVelocity = 5;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumpVelocity = 5f;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        movement = new Vector2(horizontal, 0);
        if (Input.GetButton("Jump") && isGrounded && rb.velocity.y == 0)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * jumpVelocity;
            Debug.Log("hi");
        }
        if (rb.velocity.y < 0) {
            isGrounded = true;
        }

    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(movement / 10);
    }

}
