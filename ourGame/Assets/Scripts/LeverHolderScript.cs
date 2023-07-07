using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverHolderScript : MonoBehaviour, IInteractable
{
    public GameObject Lever;
    public Animator leverAnimator;

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
            if (leverAnimator != null)
            {
                leverAnimator.SetTrigger("LeverDown");
            }
        }
    }
}
