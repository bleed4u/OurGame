using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever1Script : MonoBehaviour, IInteractable
{
    public Animator lever1Anim;

    private PuzzleInfo puzzle;

    private void Start()
    {
        GameObject.Find("Player").TryGetComponent<PuzzleInfo>(out puzzle);
    }

    public void Interact()
    {
        if (puzzle.isLever1)
        {
            lever1Anim.SetTrigger("Lever1Down");
            puzzle.isLever1 = false;
        }
        else
        {
            lever1Anim.SetTrigger("Lever1Up");
            puzzle.isLever1 = true;
        }
    }
}
