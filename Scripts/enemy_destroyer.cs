using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_destroyer : MonoBehaviour
{
    public GameObject enemy;
    void OnCollisionEnter2D(Collision2D collision2D) {
        if (collision2D.collider.name == "player")
        {
            Destroy(enemy);
        }
    }
}
