using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerOneMovement : MonoBehaviour
{
    public float speed = 1f, speed_temp;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool isGrounded = true;
    

    private int player_index;

    private string[,] controlls =  { { "a", "w", "d" }, { "left", "up", "right"} };

    [Range(1, 10)]
    public float jumpVelocity = 5f;

    public GameManager gameManager;

    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();

        player_index = gameManager.GetPlayerIndex(gameObject);
        Debug.Log(player_index);
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
