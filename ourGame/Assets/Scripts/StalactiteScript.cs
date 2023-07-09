using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StalactiteScript : MonoBehaviour
{
    public Animator Stalactite;

    private PuzzleInfo puzzle;
    private bool isDone = false;
    
    public void Start()
    {
        GameObject.Find("Player").TryGetComponent<PuzzleInfo>(out puzzle);
    }

    public void Update()
    {
        if (!puzzle.isLever1 && puzzle.isLever2 && !puzzle.isLever3 && !isDone)
        {
            Stalactite.SetTrigger("Stalactite");
            isDone = true;
        }
    }
    
}
