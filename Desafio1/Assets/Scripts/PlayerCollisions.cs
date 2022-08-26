using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameManager.VidaPlayer--;
        Debug.Log(GameManager.VidaPlayer);

        if (GameManager.VidaPlayer == 0)
        {
            Destroy(other.gameObject);
            Debug.Log("GAME OVER");
        }
    }

}

