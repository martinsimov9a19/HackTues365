using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CollisionManager : MonoBehaviour
{

    public GameManager gameManager;
    private Vector2 StartPosition;
    private int player_index;
    public bool PlayerNearDoor = false;

    void Start()
    {
        StartPosition = gameObject.transform.position;
        player_index = gameManager.GetPlayerIndex(gameObject);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trap") {
            gameManager.RespawnPlayer(StartPosition, gameObject);
            gameManager.DeathCounter++;
        }
        if (other.tag == "Bush") {
            changeOpacity(0.5f, other.gameObject);
        }
        if (other.tag == "KeyOne" || other.tag == "KeyTwo") {
            AddUniquePlayerKey(player_index, other.gameObject);
        }
        if (other.tag == "Door") {
            PlayerNearDoor = true;
        }
        

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bush") {
            changeOpacity(1f, collision.gameObject);
        }
        if (collision.tag == "Door") {
            PlayerNearDoor = false;
        }
    }


    private void changeOpacity(float alpha, GameObject gameObject)
    {
        Color tempColor = gameObject.GetComponent<SpriteRenderer>().color;
        tempColor.a = alpha;
        gameObject.GetComponent<SpriteRenderer>().color = tempColor;
    }
    private void AddUniquePlayerKey(int player_index, GameObject key)
    {
        if (player_index == 0 && key.tag == "KeyOne")
        {
            PickUpAndRemove(key);
        }
        else if (player_index == 1 && key.tag == "KeyTwo")
        {
            PickUpAndRemove(key);
        }
    }

    private void PickUpAndRemove(GameObject key){
        gameObject.GetComponent<PlayerInventory>().PickUpKey();
        key.GetComponent<ObjectRemoval>().DestroyGameObject();
    }
}
