using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorPlayer : MonoBehaviour
{
    public GameObject Player;

    void Update()
    {
        Vector2 PlayerPos = Player.transform.position;

        gameObject.transform.position = new Vector2(PlayerPos.x * -1, PlayerPos.y);

    }
}
