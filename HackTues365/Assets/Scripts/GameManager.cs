using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int player_index;

    public void RespawnPlayer(Vector2 StartPosition, GameObject player) {
        player.transform.position = StartPosition;
    }

    public void WinGame() {
        Debug.Log("You win!");
    }
    public int GetPlayerIndex(GameObject player) {

        if (player.tag == "PlayerOne")
        {
            player_index = 0;
        }
        else if (player.tag == "PlayerTwo")
        {
            player_index = 1;
        }


        return player_index;
    }
}
