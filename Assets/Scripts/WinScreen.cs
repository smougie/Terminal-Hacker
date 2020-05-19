using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject displayObject;
    public GameObject winScreenUI;
    public bool gameFinished = false;  // delete

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
        displayObject.SetActive(true);
        winScreenUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
