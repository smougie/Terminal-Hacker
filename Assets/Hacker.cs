using System;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    int level;  // member variable storing current level
    
    // Strings
    string mainMenuScreen = "What would you like to hack into?\nPress 1 for local shop\nPress 2 for CrossFit gym\nPress 3 for Hogwarts";
    string mainMenuScreenPL = "Do czego chcesz się włamać?\nNaciśnij 1 dla sklepu żabka\nNaciśnij 2 dla Rebel Nature Gym\nNaciśnij 3 dla Hogwartu";

    void Start()
    {
        ShowMainMenu();
    }

    void Update()
    {

    }

    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(mainMenuScreen);
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Hello Agent Bond, your car is waiting.");
        }
        else if (input == "666")
        {
            Terminal.WriteLine("† ]:-> †");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
    }
}
