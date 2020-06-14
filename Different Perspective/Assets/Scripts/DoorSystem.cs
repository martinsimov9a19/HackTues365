using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    public GameManager gameManager;

    public void InserKey(GameObject Player) {
        gameManager.KeysInsertedCount++;
    }
    
}
