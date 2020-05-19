using System.Collections;
using UnityEngine;

public class ComplexWindow : MonoBehaviour
{
    public GameObject displayObject;
    public GameObject complexWindow;

    public void ShowComplex()
    {
        Time.timeScale = 0f;
        displayObject.SetActive(false);
        complexWindow.SetActive(true);
        StartCoroutine(ExecuteAfterTime(5));
    }

    public void HideComplex()
    {
        Time.timeScale = 1f;
        displayObject.SetActive(true);
        complexWindow.SetActive(false);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        HideComplex();
    }
}
