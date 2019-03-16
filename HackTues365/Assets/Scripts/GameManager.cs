using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    public void RespawnPlayer(Vector2 StartPosition, GameObject player) {
        player.transform.position = StartPosition;
    }

    public void WinGame() {
        Debug.Log("You win!");
    }
}
