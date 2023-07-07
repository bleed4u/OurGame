using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TorchController : MonoBehaviour
{
    public Light myLight;

    // Update is called once per frame
    void Update()
    {
        myLight.intensity -= Time.deltaTime * 0.04f;
        if (myLight.intensity == 0)
        {
            GetComponent<Deathscript>().Death();
        }
    }
}