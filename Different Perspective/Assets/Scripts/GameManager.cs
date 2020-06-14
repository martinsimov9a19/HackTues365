using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int player_index;
    public int KeysInsertedCount = 0;
    public Canvas WinMenu, LoseMenu;
   
    public int DeathCounter = 0;


    public void RespawnPlayer(Vector2 StartPosition, GameObject player) {
        player.transform.position = StartPosition;
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

    void Update()
    {
        if (KeysInsertedCount == 2) {
            WinGame();
        }
        if (DeathCounter >= 5) {
            LoseGame();
        }
    }

    private void WinGame() {
        WinMenu.GetComponent<Canvas>().enabled = true;
        
    }
    private void LoseGame() {
        LoseMenu.GetComponent<Canvas>().enabled = true;
        
    }
}
