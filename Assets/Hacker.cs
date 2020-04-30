using UnityEngine;

public class Hacker : MonoBehaviour
{
    private string mainMenuScreen = "What would you like to hack into?\nPress 1 for local shop\nPress 2 for CrossFit gym\nPress 3 for Hogwarts";
    private string mainMenuScreenPL = "Do czego chcesz się włamać?\nNaciśnij 1 dla sklepu żabka\nNaciśnij 2 dla Rebel Nature Gym\nNaciśnij 3 dla Hogwartu";

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

    private void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Hello Agent Bond, your car is waiting.");
        }
        else if (input == "666")
        {
            Terminal.WriteLine("† ]:-> †");
        }
        else if (input == "1")
        {
            Terminal.WriteLine("You successfully hacked into local shop");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }
}
