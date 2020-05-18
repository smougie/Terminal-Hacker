using System;
using UnityEngine;

public class ComplexAnimation : MonoBehaviour
{
    public GameObject displayObject;
    public GameObject complexAnimationObject;
    public bool buildingActive = false;

    void Update()
    {
        if (buildingActive)
        {
            ShowAnimation();
        }
    }

    void ShowAnimation()
    {
        Time.timeScale = 0f;
        displayObject.SetActive(false);
        complexAnimationObject.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        displayObject.SetActive(false);
        complexAnimationObject.SetActive(false);
        buildingActive = false;
    }
}
