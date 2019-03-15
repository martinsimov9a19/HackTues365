using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool isJumping = false;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        //float vertical = Input.GetAxis("Vertical") * speed;
        //movement = new Vector2(horizontal, gameObjecst.transform.position.y);

    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("w") && isJumping == false)
        {

            rb.AddForce(new Vector2(0f, 100f));
        }
        rb.velocity = movement;
        
    }

}
