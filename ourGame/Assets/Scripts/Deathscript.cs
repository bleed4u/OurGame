using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathscript : MonoBehaviour
{
    public float delay = 3f;
    public GameObject deathScreen;
    public AudioSource ambience;
    public AudioSource menuSound;
    public AudioSource fell;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fell.Play();
            Death();
        }
    }

    public void Death()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
        ambience.Pause();
        menuSound.Pause();

        StartCoroutine(Delay(delay));
    }
    
    IEnumerator Delay(float secs)
    {
        yield return new WaitForSecondsRealtime(secs);
        deathScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        ambience.UnPause();
        menuSound.UnPause();
    }
}
