using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    private Vector2 movement;


    private float fallmultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    [Range(1, 10)]
    public float jumpVelocity;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        movement = new Vector2(horizontal, 0);
        if (Input.GetButton("Jump"))
        {
            rb.velocity = Vector2.up * jumpVelocity;
            Debug.Log("hi");
        }


    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(movement / 10);
    }

}
