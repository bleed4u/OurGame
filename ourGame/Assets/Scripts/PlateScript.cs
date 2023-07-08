using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateScript : MonoBehaviour
{
    public AudioSource doorSound;
    public Animator doorOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CUBE"))
        {
            doorSound.Play();
            doorOpen.SetTrigger("Door0Open");
            var plate = GetComponent<Collider>();
            plate.enabled = false;
        }
    }
}