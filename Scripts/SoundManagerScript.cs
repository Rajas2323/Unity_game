using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip jump_sound, start_sound, background_music;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        jump_sound = Resources.Load<AudioClip>("mariosound");
        start_sound = Resources.Load<AudioClip>("sasound");
        background_music = Resources.Load<AudioClip>("background_music");
        audioSource = GetComponent<AudioSource>();
        
        audioSource.PlayOneShot(start_sound);
        audioSource.PlayOneShot(background_music);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     audioSource.PlayOneShot(jump_sound);
        // }
    }
}
