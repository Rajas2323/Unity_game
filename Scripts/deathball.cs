using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathball : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision2D) {
        
        if (collision2D.collider.name == "player")
        {
            Destroy(player);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
