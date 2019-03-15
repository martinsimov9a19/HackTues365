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
            changeOpacity(0.5f, other.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bush") {
            changeOpacity(1f, collision.gameObject);
        }
    }


    private void changeOpacity(float alpha, GameObject gameObject)
    {
        Color tempColor = gameObject.GetComponent<SpriteRenderer>().color;
        tempColor.a = alpha;
        gameObject.GetComponent<SpriteRenderer>().color = tempColor;
    }
}
