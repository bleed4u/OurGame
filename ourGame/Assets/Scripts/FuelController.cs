using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public void Interact();
}

public class FuelController : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            Ray r = new Ray(InteractorSource.position,InteractorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}
