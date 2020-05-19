using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject confirmWindowUI;
    public GameObject displayObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ManagePauseMenu();
        }
    }

    private void ManagePauseMenu()
    {
        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        displayObject.SetActive(true);
        pauseMenuUI.SetActive(false);
        confirmWindowUI.SetActive(false);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;
        displayObject.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void LoadMenu()
    {
        gameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
