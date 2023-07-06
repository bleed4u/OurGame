using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource audioSource;
    public CharacterController cc;
    public AudioClip[] footstepSounds;
    public float minTimeBetweenFootsteps = 0.6f;
    public float maxTimeBetweenFootsteps = 1;
    
    private bool isWalking = false;
    private float timeSinceLastFootstep;
    private int prev = 0;

    private void Update()
    {
        isWalking = (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && cc.isGrounded;

        // Check if the player is walking
        if (isWalking)
        {
            // Check if enough time has passed to play the next footstep sound
            if (Time.time - timeSinceLastFootstep >= Random.Range(minTimeBetweenFootsteps, maxTimeBetweenFootsteps))
            {
                // Play a random footstep sound from the array
                AudioClip stepSound = footstepSounds[prev];
                prev = (prev + 1) % footstepSounds.Length;
                audioSource.PlayOneShot(stepSound);

                timeSinceLastFootstep = Time.time; // Update the time since the last footstep sound
            }
        }
    }
}
