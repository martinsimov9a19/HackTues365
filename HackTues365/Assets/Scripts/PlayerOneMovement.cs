using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerOneMovement : MonoBehaviour
{
    public float speed = 1f, speed_temp;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool isGrounded = true;


    private float fallmultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    private int player_index;

    private string[,] controlls =  { { "a", "w", "d" }, { "left", "up", "right"} };

    [Range(1, 10)]
    public float jumpVelocity = 5f;

    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        
        if (gameObject.tag == "PlayerOne")
        {
            player_index = 0;
        }
        else if(gameObject.tag == "PlayerTwo"){
            player_index = 1;
        }
    }

    void Update()
    {

        if (Input.GetButtonDown(controlls[player_index, 0]))
        {

            speed_temp = -speed;
        }
        else if (Input.GetKeyDown(controlls[player_index, 2]))
        {

            speed_temp = Mathf.Abs(speed);
        }
        else if (Input.GetButtonUp(controlls[player_index, 0]) || Input.GetButtonUp(controlls[player_index, 2]))
        {
            speed_temp = 0;
        }
        movement = new Vector2(speed_temp, 0);


        if (Input.GetKeyDown(controlls[player_index, 1]) && isGrounded && rb.velocity.y == 0)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * jumpVelocity;
            Debug.Log("hi");
        }
        if (rb.velocity.y < 0)
        {
            isGrounded = true;
        }

    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(movement / 10);
    }

}
