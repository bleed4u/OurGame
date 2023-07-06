using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathscript : MonoBehaviour
{
    public float delay = 2.5f;
    public GameObject deathScreen;
    public AudioSource ambience;
    public AudioSource drops;
    public AudioSource dead;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Death();
        }
    }

    private void Death()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
        ambience.Pause();
        drops.Pause();
        dead.Play();

        StartCoroutine(Delay(delay));
    }
    
    IEnumerator Delay(float secs)
    {
        yield return new WaitForSecondsRealtime(secs);
        deathScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        ambience.UnPause();
        drops.UnPause();
    }
}
