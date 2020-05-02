using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    
    // Game configuration data
    // Passwords
    string[] locations = { "Local shop", "CrossFit gym", "Hogwarts"};
    string[] locationsPL = { "Sklep żabka", "Rebel Nature Gym", "Hogwart"};
    string[] level1Passwords = { "beer", "icecream", "drink", "fruits", "food"};
    string[] level2Passwords = { "functional", "backsquat", "barbell", "dumbbell", "exercise"};
    string[] level3Passwords = { "quidditch", "blackmagic", "slytherin", "sectumsempra", "buckbeak"};
    string[] level1PasswordsPL = { "piwo", "lody", "napój", "owoce", "jedzenie"};
    string[] level2PasswordsPL = { "funkcjonalny", "przysiad", "sztanga", "sztangielka", "ćwiczenie"};
    string[] level3PasswordsPL = { "quidditch", "czarnoksięstwo", "slytherin", "sectumsempra", "hardodziob"};

    // Level rewards
    //string[] level1rewards = { "book", "icecream"};
    Dictionary<string, string> level1rewards = new Dictionary<string, string>
    {
        { "book", @"You got the book!
    _______
   /      /,
  /      //
 /______//
(______(/
        "},
        {
            "icecream", @"You got the icecream!
        _.-.
     ,'  /  \
    /// //  /)
   /// // ///
  (`: // ///
   `;`: ///
   / /:`:/
  (_/  
        "}
    };

    // Game State
    int level;  // member variable storing current level
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    string password;

    int money = 0;
    Dictionary<string, int> inventory = new Dictionary<string, int>();
    Dictionary<string, int> inventoryCounter = new Dictionary<string, int>();
 
    // Strings
    string mainMenuScreen = "What would you like to hack into?\nPress 1 for {0}\nPress 2 for {1}\nPress 3 for {2}";
    string mainMenuScreenPL = "Do czego chcesz się włamać?\nNaciśnij 1 dla sklepu żabka\nNaciśnij 2 dla Rebel Nature Gym\nNaciśnij 3 dla Hogwartu";
    string menuHint = "You may type 'menu' any time";
    string menuHintPL = "Możesz wpisąć 'menu' kiedy chcesz";
    string passwordScreen;
    string passwordScreenPL;
    string tryAgainMessage = "Password incorrect, please try again.";
    string tryAgainMessagePL = "Błędne hasło, spróbuj ponownie.";

    void Start()
    {
        ShowMainMenu();
        passwordScreen = "{0}\n*hint: {1}\nPlease enter a password:";
        passwordScreenPL = "{0}\n*podpowiedź: {1}Wprowadź hasło:";
    }

    // Display main menu
    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(string.Format(mainMenuScreen, locations[0], locations[1], locations[2]));
    }

    private void Update()
    {
        print("contains: " + inventory.ContainsKey("book"));
        if (inventory.ContainsKey("book"));
        {
            print("books value: " + inventory["book"]);
            print("books count: " + inventoryCounter["book"]);
        }
    }
    // Method deciding how to handle user input
    void OnUserInput(string input)
    {
        // Player can always go to main menu
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    // Method handling player main menu choices
    void RunMainMenu(string input)
    {
        var isValidLevel = (input == "1" || input == "2" || input == "3");
        if (isValidLevel)
        {
            level = int.Parse(input);
            AskForPassword();
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
            Terminal.WriteLine(menuHint);
        }
    }

    // Method setting random password
    void AskForPassword()
    {
        currentScreen = Screen.Password;
        SetRandomPassword();
        Terminal.ClearScreen();
        Terminal.WriteLine(menuHint);
        Terminal.WriteLine(string.Format(passwordScreen, locations[level - 1], password.Anagram()));
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number.");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        string icecream = @"You got the icecream!
        _.-.
     ,'  /  \
    /// //  /)
   /// // ///
  (`: // ///
   `;`: ///
   / /:`:/
  (_/  
        ";
        string db = @"You got the dumbbell!

❚█══█❚
        ";
        string book = @"You got the book!
    _______
   /      /,
  /      //
 /______//
(______(/
        ";
        switch (level)
        {
            case 1:
                // TODO pick one of 5 rewards -> sort them from worst to best, each of them should give different money value -> show reward, random money value, add money od add money to sell for reward
                Terminal.WriteLine(icecream);
                if (inventory.ContainsKey("book"))
                {
                    var rnd = Random.Range(1, 51);
                    print("book value" + rnd);
                    inventory["book"] += rnd;
                    inventoryCounter["book"] += 1;
                }
                else
                {
                    var rnd = Random.Range(1, 51);
                    print("book value" + rnd);
                    inventory.Add("book", rnd);
                    inventoryCounter.Add("book", 1);
                }

                break;
            case 2:
                Terminal.WriteLine(db);
                break;
            case 3:
                Terminal.WriteLine(book);
                break;
            default:
                Debug.LogError("Invalid level number for reward.");
                break;
        }

    }
}
