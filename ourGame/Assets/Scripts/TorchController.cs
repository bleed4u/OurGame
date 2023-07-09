using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TorchController : MonoBehaviour
{
    public Light myLight;
    public AudioSource deathSource;

    private float startIntensity;
    private float startRange;
    private Deathscript deathScript;

    private void Start()
    {
        deathSource.enabled = false;
        startIntensity = myLight.intensity;
        startRange = myLight.range;
        deathScript = GetComponent<Deathscript>();
    }

    // Update is called once per frame
    void Update()
    {
        myLight.intensity -= Time.deltaTime * 0.016f * startIntensity;
        myLight.range -= Time.deltaTime * 0.01f * startRange;

        if (myLight.intensity == 0)
        {
            deathSource.enabled = true;
            deathScript.Death();
        }
    }
}