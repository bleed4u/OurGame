using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource ambience;
    public AudioSource gameSound;

    private float privateDelta;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        gameSound.volume = 0f;
        privateDelta = Time.deltaTime;
    }

    void Update()
    {
        if (!isPaused && gameSound.volume < 1f)
        {
            gameSound.volume += 0.001f * privateDelta;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        ResumeGame();
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
        gameSound.Pause();
        ambience.Pause();
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        gameSound.UnPause();
        ambience.UnPause();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
