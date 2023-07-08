using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverHolderScript : MonoBehaviour, IInteractable
{
    public GameObject Lever;
    public Animator leverAnimator;
    private AudioSource sound;

    public void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        PuzzleInfo puzzle;
        GameObject.Find("Player").TryGetComponent<PuzzleInfo>(out puzzle);
        if (!puzzle.isLeverInHolder && puzzle.hasLever)
        {
            puzzle.isLeverInHolder = true;
            Lever.SetActive(true);
        }
        else if (puzzle.isLeverInHolder)
        {
            var startTime = Time.time;
            sound.Play();
            leverAnimator.SetTrigger("LeverDown");
            if (startTime - Time.time == 2)
            {
                sound.Stop();
            }
        }
    }
}
