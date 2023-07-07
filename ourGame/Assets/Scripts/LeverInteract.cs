using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteract : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        PuzzleInfo puzzle;
        GameObject.Find("Player").TryGetComponent<PuzzleInfo>(out puzzle);
        puzzle.hasLever = true;
        Destroy(gameObject);
    }
}
