using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TorchController : MonoBehaviour
{
    public Light myLight;
    public float startIntensity;
    private Deathscript deathScript;

    private void Start()
    {
        startIntensity = myLight.intensity;
        deathScript = GetComponent<Deathscript>();
    }

    // Update is called once per frame
    void Update()
    {
        myLight.intensity -= Time.deltaTime * 0.015f * startIntensity;
        
        if (myLight.intensity == 0)
        {
            deathScript.Death();
        }
    }
}