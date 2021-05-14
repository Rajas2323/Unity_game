// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public bool right_movement, left_movement;
    public Rigidbody2D rb;
    public float speed = 13f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * 100);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(speed, 0f, 0f);
        
        if (right_movement == true && left_movement == false) 
            transform.position += movement * Time.deltaTime;
        
        
        if (right_movement == false && left_movement == true) 
            transform.position -= movement * Time.deltaTime;;
    }
    
    void OnCollisionEnter2D(Collision2D collision2D) {
        
        if (collision2D.collider.name == "win_door")
        {
            
        }
        
        if (collision2D.collider.name == "crate")
        {
            right_movement = true;
            left_movement = false;
        }
        
        if (collision2D.collider.name == "crate (1)")
        {
            left_movement = true;
            right_movement = false;
        }
            // FindObjectOfType<GameManager>().EndGame();
    }
}
