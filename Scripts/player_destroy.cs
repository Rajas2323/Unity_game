using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_destroy : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D collision2D) {
        
        if (collision2D.collider.name == "player")
        {
             Destroy(player);
             FindObjectOfType<GameManager>().EndGame();
        }
    }
}
