using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamerScript : MonoBehaviour
{
    public AudioSource scream;
    public Animator doorClose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scream.Play();
            doorClose.SetTrigger("Screamer");
            Destroy(gameObject);
        }
    }
}
