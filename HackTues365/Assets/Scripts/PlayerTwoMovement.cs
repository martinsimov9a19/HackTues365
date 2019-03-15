using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public float speed = 1f, speed_temp;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool isGrounded = true;

    private float fallmultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    [Range(1, 10)]
    public float jumpVelocity = 5f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumpVelocity = 5f;
    }

    void Update()
    {


        if (Input.GetButtonDown("a"))
        {
 
            speed_temp = -speed;
        }
        else if (Input.GetKeyDown("d"))
        {

            speed_temp = Mathf.Abs(speed);
        }
        else if (Input.GetButtonUp("a") || Input.GetButtonUp("d")) {
            speed_temp = 0;
        }
        movement = new Vector2(speed_temp, 0);

        
        if (Input.GetKeyDown("w") && isGrounded && rb.velocity.y == 0)
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
