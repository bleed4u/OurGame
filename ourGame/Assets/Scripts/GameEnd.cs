using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour, IInteractable
{
    public GameObject gameEnd;
    public AudioSource ambience;
    public AudioSource menuSound;
    public AudioSource VIKA;
    
    public void Interact()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 0f;
        gameEnd.SetActive(true);
        ambience.Pause();
        menuSound.Pause();
        VIKA.Play();
    }
}
