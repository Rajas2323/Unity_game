using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate : MonoBehaviour
{
    public float speed = 10f;
    public bool right_movement = false, left_movement = false;
    Vector3 movement;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * 100);
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(speed, 0f, 0f);
        
        if (right_movement && !left_movement)
            transform.position += movement * Time.deltaTime;
            
        if (left_movement && !right_movement)
            transform.position -= movement * Time.deltaTime;
    }
    
    void OnCollisionEnter2D(Collision2D collision2D) {
        if (collision2D.collider.name == "Grass (2)")
        {
            right_movement = true;
            left_movement = false;
        }
        
        if (collision2D.collider.name == "Grass (3)")
        {
            left_movement = true;
            right_movement = false;
        }
        
        if (collision2D.collider.name == "player")
            collision2D.collider.transform.SetParent(transform);
        
    }
    
    void OnCollisionExit2D(Collision2D collision2D) {
        if (collision2D.collider.name == "player")
        {
            collision2D.collider.transform.SetParent(null);
        }
    }
}
