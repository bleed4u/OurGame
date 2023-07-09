using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever2Script : MonoBehaviour, IInteractable
{
    public Animator lever2Anim;

    private PuzzleInfo puzzle;

    private void Start()
    {
        GameObject.Find("Player").TryGetComponent<PuzzleInfo>(out puzzle);
    }

    public void Interact()
    {
        if (puzzle.isLever2)
        {
            lever2Anim.SetTrigger("Lever2Down");
            puzzle.isLever2 = false;
        }
        else
        {
            lever2Anim.SetTrigger("Lever2Up");
            puzzle.isLever2 = true;
        }
    }
}
