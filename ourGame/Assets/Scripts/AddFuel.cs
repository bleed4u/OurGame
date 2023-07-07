using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour, IInteractable
{
    public Light myLight;
    public void Interact()
    {
        myLight.intensity = 4f;
        Destroy(gameObject);
    }
}
