using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObjects : MonoBehaviour
{
    public float pushForce = 1f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigg = hit.collider.attachedRigidbody;
        if (rigg != null) 
        { 
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0f;
            forceDirection.Normalize();
            rigg.AddForceAtPosition(forceDirection * pushForce, transform.position, ForceMode.Impulse);
        }
    }
}
