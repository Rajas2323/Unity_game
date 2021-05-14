using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    bool play_sound = true; 
    public Animator animator;
    public GameObject player;
    public AudioClip jump_sound;
    public AudioSource audioSource;
    public Rigidbody2D rb;
    public CharacterController2D controller;
    public float speed = 450f;
    public float horizontalMove = 0f;
    bool jump = false;
    
    void Start() 
    {
        jump_sound = Resources.Load<AudioClip>("mariosound");
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isjumping", true);
            play_sound = false;
        }

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        
    }
    
    public void OnLanding()
    {
        play_sound = true;
        animator.SetBool("isjumping", false);
    }
    
    void FixedUpdate() {
        
        if (play_sound == true && Input.GetKeyDown(KeyCode.Space)) 
            audioSource.PlayOneShot(jump_sound);
        
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        
        jump = false;
    }
    
    void OnCollisionEnter2D(Collision2D collision2D) {
        if (collision2D.collider.tag == "spike")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
        
        if (collision2D.collider.name == "win_door")
        {
            FindObjectOfType<GameManager>().Game_Won();
        }
    }
}
