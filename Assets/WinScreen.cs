using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject displayObject;
    public GameObject winScreenUI;
    public bool gameFinished = false;

    void Update()
    {
        if (gameFinished)
        {
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        Time.timeScale = 0f;
        winScreenUI.SetActive(true);
        displayObject.SetActive(false);
    }

    public void ContinueGame()
    {
        gameFinished = false;
        Time.timeScale = 1f;
        winScreenUI.SetActive(false);
        displayObject.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
