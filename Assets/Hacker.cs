using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    // Passwords
    string[] locations = { "Local shop", "CrossFit gym", "Hogwarts"};
    string[] locationsPL = { "Sklep żabka", "Rebel Nature Gym", "Hogwart"};
    string[] level1Passwords = { "beer", "icecream", "drink", "fruits", "food"};
    string[] level2Passwords = { "functional", "backsquat", "barbell", "dumbbell", "exercise", "aabb"};
    string[] level3Passwords = { "quidditch", "blackmagic", "slytherin", "sectumsempra", "buckbeak"};
    string[] level1PasswordsPL = { "piwo", "lody", "napój", "owoce", "jedzenie"};
    string[] level2PasswordsPL = { "funkcjonalny", "przysiad", "sztanga", "sztangielka", "ćwiczenie"};
    string[] level3PasswordsPL = { "quidditch", "czarnoksięstwo", "slytherin", "sectumsempra", "hardodziob"};

    // Level rewards names
    string[] level1RewardsNames = { "icecream", "laptop", "revenue", "tape", "vodka"};
    string[] level2RewardsNames = { "dumbbell", "plate", "barbell", "picture", "cashRegister"};
    string[] level3RewardsNames = { "broom", "book", "map", "key", "wand"};

    // Level rewards "objects"
    #region Level 1 Rewards
    Dictionary<string, string> level1Rewards = new Dictionary<string, string>
    {
        {
            "icecream", @"You received icecream!
        _.-.
     ,'  /  \
    /// //  /)
   /// // /// Value: {0}$
  (`: // ///
   `;`: ///
   / /:`:/
  (_/  
"
        },
        {
            "vodka", @"You received vodka!
      _
     ]=[
  .-'(P)'-.
  |absolut|
  | ~~~~~ |
  | ~~~~~ | Value: {0}$
  | ~~~~~ |
  '_______'
"
        },
        {
            "tape", @"You received monitoring tape!
 _________
|   ___   |
|  o___o  | Value: {0}$
|__/___\__| 
"
        },
        {
            "laptop", @"
 ______________
||            ||
||            ||
||            ||
||            ||
||____________||
|______________| Value: {0}$
 \\############\\
  \\############\\
   \      ____    \   
    \_____\___\____\
You received shop owner's laptop!
"
        },
        {
            "revenue", @"You received daily revenue!
          \`\/\/\/`/
           )======(
         .'        '. Value: {0}$
        /    _||__   \
       /    (_||_     \
      |     __||_)     |
      |       ||       |
      '.              .'
        '------------'
"
        }
    };
    #endregion

    #region Level 2 Rewards
    Dictionary<string, string> level2Rewards = new Dictionary<string, string>
    {
        {
            "dumbbell", @"
You received the dumbbell!

❚█══█❚ Value: {0}$
"
        },
        {
            "plate", @"You received the 25kg plate!
          .-"" -.
         / 25kg \  
        ;  { }   ; Value: {0}$
         \      /
          '-..-'
"
        },
        {
            "barbell", @"
You received the barbell!

❚██════════════██❚ Value: {0}$
"
        },
        {
            "picture", @"You received the owner's
 __________nude picture!
|  _______ |
| |       ||
| |    _O || Value: {0}$
| |______\||
|__________|
"
        },
        {
            "cashRegister", @"You received the cash register!
   _____
  | ___ |
  ||   ||
  ||___||
  |   _ | Value: {0}$
  |_____|
 /_/_|_\_\
/_/__|__\_\
"
        }
    };
    #endregion

    #region Level 3 Rewards
    Dictionary<string, string> level3Rewards = new Dictionary<string, string>
    {
        {
            "broom", @"You received firebolt!
  |
  |
  | Value: {0}
  | 
 /X\
//X\\
"
        },
        {
            "book", @"You received book!
    _______
   /      /,
  /      // Value: {0}
 /______//
(______(/
'This Book is the Property 
of the Half-Blood Prince'
"
        },
        {
            "map", @"You received Marauder's Map!
_________
\ x  |  o\
 \   | x  \ Value: {0}
  \.,..,.,.\
"
        },
        {
            "key", @"You received key to Gringott's vault!

 ,o.          8 8
d   bzzzzzzzza8o8b 
 `o'
Value: {0}
"
        },
        {
            "wand", @"You received Blackwand!
( ͡° ͜ʖ ͡°)⊃―━━☆⌒*・。.
'Avada Kedavra!'

Value: {0}
"
        }
    };
    #endregion

    // Game State
    int level;  // member variable storing current level
    enum Screen { MainMenu, Password, Win, Inventory, Shop, Buy, Sell, Back };
    Screen currentScreen;
    string password;

    int money = 0;
    Dictionary<string, int> inventory = new Dictionary<string, int>();
    Dictionary<string, int> inventoryCounter = new Dictionary<string, int>();
 
    // Strings
    string mainMenuScreen = "Press 'd' for DarkWeb shop\nPress 'i' for inventory\n\nWhat would you like to hack into?\nPress 1 for {0}\nPress 2 for {1}\nPress 3 for {2}";
    string mainMenuScreenPL = "Do czego chcesz się włamać?\nNaciśnij 1 dla sklepu żabka\nNaciśnij 2 dla Rebel Nature Gym\nNaciśnij 3 dla Hogwartu";
    string menuHint = "Type 'menu' for menu";
    string menuHintPL = "Wpisz 'menu' aby wrócić do menu";
    string validLevelHint = "Please choose a valid level";
    string validLevelHintPL = "Wybierz odpowiedni poziom";
    string validOptionHint = "Please choose a valid option\nor type 'menu' for menu";
    string validOptionHintPL = "Wybierz odpowiednią opcję";
    string passwordScreen;
    string passwordScreenPL;
    string tryAgainMessage = "Password incorrect, please try again.";
    string tryAgainMessagePL = "Błędne hasło, spróbuj ponownie.";
    string shopMenu = "Welcome to the DarkWeb store!\nPress 'b' for Buy\nPress 's' for Sell";
    string sellItemQuestion = "Would you like to sell all your items?\nPress y/Yes or n/NO";

    void Start()
    {
        ShowMainMenu();
        passwordScreen = "{0}\n*hint: {1}\nPlease enter a password:";
        passwordScreenPL = "{0}\n*podpowiedź: {1}Wprowadź hasło:";
        //print(level1RewardsNames.Length);
        //print(level1RewardsNames[Random.Range(0, level1RewardsNames.Length)]);
        //Terminal.WriteLine(level2Rewards["cashRegister"]);
    }

    private void Update()
    {

    }

    // Display main menu
    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(string.Format(mainMenuScreen, locations[0], locations[1], locations[2]));
    }

    // Method deciding how to handle user input
    void OnUserInput(string input)
    {
        // Player can always go to main menu
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else switch (currentScreen)
            {
                case Screen.MainMenu:
                    RunMainMenu(input);
                    break;
                case Screen.Password:
                    CheckPassword(input);
                    break;
                case Screen.Win:
                    Terminal.WriteLine(menuHint);
                    break;
                case Screen.Inventory:
                    Terminal.WriteLine(menuHint);
                    break;
                case Screen.Shop:
                    RunShopMenu(input);
                    break;
                case Screen.Buy:
                    //RunBuyMenu();
                    break;
                case Screen.Sell:
                    // TODO call method which will sell items and print items/value/count if "yes" and write Bye if "no"
                    SellItemsMenu(input);
                    break;
                case Screen.Back:
                    Terminal.WriteLine(menuHint);
                    break;
                default:
                    Debug.LogError("OnUserInput currentScreen switch statement Error.");
                    break;
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
        else if (input == "i")
        {
            ShowInventory();
        }
        else if (input == "d")
        {
            ShowShop();
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
            Terminal.WriteLine(validLevelHint);
        }
    }

    void ShowInventory()
    {
        currentScreen = Screen.Inventory;
        Terminal.ClearScreen();
        string plural = "";
        var itemsValue = 0;
        var itemsAmount = 0;
        string inventoryString = "Money: {0}$\nYou've got {1} item{2} worth {3}$.";

        foreach (KeyValuePair<string, int> item in inventory)
        {
            itemsAmount += inventoryCounter[item.Key];
            itemsValue += item.Value;
        }

        if (itemsAmount == 0)
        {
            Terminal.WriteLine($"Money: {money}$\nThere are no items in your inventory.");
        }
        else if (itemsAmount == 1)
        {
            Terminal.WriteLine(string.Format(inventoryString, money, itemsAmount, plural, itemsValue));
        }
        else
        {
            Terminal.WriteLine(string.Format(inventoryString, money,itemsAmount, plural = "s", itemsValue));
        }
    }

    void ShowShop()
    {
        currentScreen = Screen.Shop;
        Terminal.ClearScreen();
        Terminal.WriteLine(shopMenu);

    }

    void RunShopMenu(string input)
    {
        if (input == "b")
        {
            RunBuyMenu();
        }
        else if (input == "s")
        {
            CanSell();
        }
        else
        {
            Terminal.WriteLine(validOptionHint);
        }
    }

    private void CanSell()
    {
        if (inventory.Count != 0)
        {
            RunSellMenu();
        }
        else
        {
            Terminal.WriteLine("You have nothing to sell.");
        }
    }

    void RunBuyMenu()
    {
        currentScreen = Screen.Buy;
        Terminal.ClearScreen();
    }

    void RunSellMenu()
    {
        currentScreen = Screen.Sell;
        Terminal.ClearScreen();
        Terminal.WriteLine(sellItemQuestion);
    }

    void SellItemsMenu(string input)
    {
        var isValidYes = (input == "y" || input == "yes" || input == "Yes" || input == "YES");
        var isValidNo = (input == "n" || input == "no" || input == "No" || input == "NO");
        if (isValidYes)
        {
            SellItems();
            RemoveInventory();
            currentScreen = Screen.Back;
        }
        else if (isValidNo)
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("As you wish, Bye!");
            currentScreen = Screen.Back;
            Invoke("ShowMainMenu", 2);
        }
        else
        {
            Terminal.WriteLine(validOptionHint);
        }
    }

    void SellItems()
    {
        int itemsNumber = 0;
        int sellValue = 0;
        string plural = "";

        foreach (KeyValuePair<string, int> item in inventory)
        {
            sellValue += item.Value;
            itemsNumber += inventoryCounter[item.Key];
        }

        money += sellValue;

        if (itemsNumber > 1)
        {
            plural = "s";
        }
        Terminal.ClearScreen();
        Terminal.WriteLine($"You sold {itemsNumber} item{plural} for {sellValue}$.");
    }

    void RemoveInventory()
    {
        inventory.Clear();
        inventoryCounter.Clear();
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
        ManageLevelReward();
    }

    void ManageLevelReward()
    {
        string selectedReward;
        int selectedRewardValue;
        switch (level)
        {
            case 1:
                selectedReward = DrawReward(level1RewardsNames);  // picking random reward from level rewards
                selectedRewardValue = SetRewardValue(selectedReward);  // setting random value of reward based on reward name
                InventoryAddReward(selectedReward, selectedRewardValue);  // adding reward with value to inventory and increasing item count value
                DisplayReward(selectedReward, selectedRewardValue, level1Rewards);  // showing reward ASCII art, name, value
                break;
            case 2:
                selectedReward = DrawReward(level2RewardsNames);
                selectedRewardValue = SetRewardValue(selectedReward);
                InventoryAddReward(selectedReward, selectedRewardValue);
                DisplayReward(selectedReward, selectedRewardValue, level2Rewards);
                break;
            case 3:
                selectedReward = DrawReward(level3RewardsNames);
                selectedRewardValue = SetRewardValue(selectedReward);
                InventoryAddReward(selectedReward, selectedRewardValue);
                DisplayReward(selectedReward, selectedRewardValue, level3Rewards);
                break;
            default:
                Debug.LogError("Invalid level number for reward.");
                break;
        }
    }

    private int SetRewardValue(string selectedReward)
    {
        int selectedRewardValue = 0;

        // Reward value configuration
        switch (selectedReward)
        {
            #region configuration
            // Level 1 rewards
            case "icecream":
                selectedRewardValue = SetItemValue(1, 10);
                break;
            case "vodka":
                selectedRewardValue = SetItemValue(10, 50);
                break;
            case "tape":
                selectedRewardValue = SetItemValue(50, 100);
                break;
            case "laptop":
                selectedRewardValue = SetItemValue(100, 500);
                break;
            case "revenue":
                selectedRewardValue = SetItemValue(500, 1000);
                break;
            // Level 2 rewards
            case "dumbbell":
                selectedRewardValue = SetItemValue(100, 250);
                break;
            case "plate":
                selectedRewardValue = SetItemValue(250, 350);
                break;
            case "barbell":
                selectedRewardValue = SetItemValue(350, 1100);
                break;
            case "picture":
                selectedRewardValue = SetItemValue(500, 2000);
                break;
            case "cashRegister":
                selectedRewardValue = SetItemValue(1000, 2500);
                break;
            // Level 3 rewards
            case "broom":
                selectedRewardValue = SetItemValue(2500, 5000);
                break;
            case "book":
                selectedRewardValue = SetItemValue(3500, 6000);
                break;
            case "map":
                selectedRewardValue = SetItemValue(4500, 7000);
                break;
            case "key":
                selectedRewardValue = SetItemValue(7000, 15000);
                break;
            case "wand":
                selectedRewardValue = SetItemValue(15000, 20000);
                break;
            default:
                Debug.LogError("Select Reward switch Error.");
                break;
            #endregion
        }

        return selectedRewardValue;
    }

    private void DisplayReward(string selectedReward, int selectedRewardValue,Dictionary<string, string> levelRewards)
    {
        Terminal.WriteLine(string.Format(levelRewards[selectedReward], selectedRewardValue));
    }

    string DrawReward(string[] rewardsList)
    {
        int randomIndex = Random.Range(0, rewardsList.Length);
        string reward = rewardsList[randomIndex];
        return reward;
    }

    int SetItemValue(int minValue, int maxValue)
    {
        int value = Random.Range(minValue, maxValue + 1);
        return value;
    }

    private void InventoryAddReward(string selectedReward, int selectedRewardValue)
    {
        if (inventory.ContainsKey(selectedReward))
        {
            inventory[selectedReward] += selectedRewardValue;
            inventoryCounter[selectedReward] += 1;
        }
        else
        {
            inventory.Add(selectedReward, selectedRewardValue);
            inventoryCounter.Add(selectedReward, 1);
        }
    }
}
