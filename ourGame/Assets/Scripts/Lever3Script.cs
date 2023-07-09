using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever3Script : MonoBehaviour, IInteractable
{
    public Animator lever3Anim;

    private PuzzleInfo puzzle;

    private void Start()
    {
        GameObject.Find("Player").TryGetComponent<PuzzleInfo>(out puzzle);
    }

    public void Interact()
    {
        if (puzzle.isLever3)
        {
            lever3Anim.SetTrigger("Lever3Down");
            puzzle.isLever3 = false;
        }
        else
        {
            lever3Anim.SetTrigger("Lever3Up");
            puzzle.isLever3 = true;
        }
    }
}
