using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CollisionManager : MonoBehaviour
{

    public GameManager gameManager;


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trap") {
            gameManager.EndGame();
        }
        if (other.tag == "Bush") {
            Color tempColor = other.GetComponent<SpriteRenderer>().color;
            tempColor.a = 0.5f;
            other.GetComponent<SpriteRenderer>().color = tempColor;
            Debug.Log("Im working");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bush") {
            Color tempColor = collision.GetComponent<SpriteRenderer>().color;
            tempColor.a = 1f;
            collision.GetComponent<SpriteRenderer>().color = tempColor;
            Debug.Log("Im working");
        }
    }

}
