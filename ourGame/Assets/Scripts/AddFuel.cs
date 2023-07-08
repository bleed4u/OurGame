using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour, IInteractable
{
    public Light myLight;
    public float startIntensity = 5f;
    public AudioSource gameSound;

    public void Interact()
    {
        myLight.intensity = startIntensity;
        gameSound.Play();
        gameSound.volume = 0f;
        Destroy(gameObject);
    }
}
