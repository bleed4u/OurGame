using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchPickUp : MonoBehaviour, IInteractable
{
    public GameObject Torch;
    public GameObject DeadCube;

    public void Interact()
    {
        Torch.SetActive(true);
        DeadCube.SetActive(false);
        Destroy(gameObject);
    }
}
