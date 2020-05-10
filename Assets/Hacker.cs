using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    // Locations
    [HideInInspector] string[] locations = {"Local shop", "CrossFit gym", "Hogwarts"};
    [HideInInspector] string[] locationsPL = {"Sklep żabka", "Rebel Nature Gym", "Hogwart"};

    // Level rewards names
    [HideInInspector] string[] level1RewardsNames = {"icecream", "laptop", "revenue", "tape", "vodka"};
    [HideInInspector] string[] level2RewardsNames = {"dumbbell", "plate", "barbell", "picture", "cashRegister"};
    [HideInInspector] string[] level3RewardsNames = {"broom", "book", "map", "key", "wand"};


    // Level passwords and passwords hints
    #region Level 1 passwords and hints
    [HideInInspector] string[] level1Passwords = {"beer", "icecream", "drink", "fruits", "food"};
    [HideInInspector] string[] level1PasswordsPL = {"piwo", "lody", "napój", "owoce", "jedzenie"};
    [HideInInspector] Dictionary<string, string[]> passwordsHints = new Dictionary<string, string[]>
    {
        // Level 1
        {"beer", new string[] {"alcohol", "sprakling", "pub"}},
        {"icecream", new string[] {"cold", "summer", "refreshing"}},
        { "drink", new string[] {"liquid", "thirst", "refreshing"}},
        { "fruits", new string[] {"vitamins", "sweet", "sour"}},
        { "food", new string[] {"hot-dog", "bread", "eat"}},
        
        // Level 2
        {"functional", new string[] {"type of training", "daily movements", "versatile"}},
        {"backsquat", new string[] {"exercise", "powerlifting", "sit" }},
        {"barbell", new string[] {"long", "heavy", "steel" }},
        {"dumbbell", new string[] {"can be heavy", "for one hand mostly", "use to exercise" }},
        {"exercise", new string[] {"home", "gym", "body activity" }},

        // Level 3
        {"quidditch", new string[] {"game", "golden snitch", "broom"}},
        {"blackmagic", new string[] {"forbidden", "dangerous", "used by bad people"}},
        {"slytherin", new string[] {"cunning", "snake", "salazar"}},
        {"sectumsempra", new string[] {"deep", "bleed", "spell"}},
        {"buckbeak", new string[] {"animal", "flying", "magic"}},
    };
    #endregion

    #region Level 2 passwords and hints
    [HideInInspector] string[] level2Passwords = {"functional", "backsquat", "barbell", "dumbbell", "exercise"};
    [HideInInspector] string[] level2PasswordsPL = {"funkcjonalny", "przysiad", "sztanga", "sztangielka", "ćwiczenie"};
    //[HideInInspector] Dictionary<string, string[]> level2hints = new Dictionary<string, string[]>
    //{
    //    {"functional", new string[] {"type of training", "daily movements", "versatile"}},
    //    {"backsquat", new string[] {"exercise", "powerlifting", "sit" }},
    //    {"barbell", new string[] {"long", "heavy", "steel" }},
    //    {"dumbbell", new string[] {"can be heavy", "for one hand mostly", "use to exercise" }},
    //    {"exercise", new string[] {"home", "gym", "body activity" }},
    //};
    #endregion

    #region Level 3 passwords and hints
    [HideInInspector] string[] level3Passwords = {"quidditch", "blackmagic", "slytherin", "sectumsempra", "buckbeak"};
    [HideInInspector] string[] level3PasswordsPL = {"quidditch", "czarnoksięstwo", "slytherin", "sectumsempra", "hardodziob"};
    //[HideInInspector] Dictionary<string, string[]> level3hints = new Dictionary<string, string[]>
    //{
    //    {"quidditch", new string[] {"game", "golden snitch", "broom"}},
    //    {"blackmagic", new string[] {"forbidden", "dangerous", "used by bad people"}},
    //    {"slytherin", new string[] {"cunning", "snake", "salazar"}},
    //    {"sectumsempra", new string[] {"deep", "bleed", "spell"}},
    //    {"buckbeak", new string[] {"animal", "flying", "magic"}},
    //};
    #endregion

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
  | Value: {0}$
  | 
 /X\
//X\\
"
        },
        {
            "book", @"You received book!
    _______
   /      /,
  /      // Value: {0}$
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
 \   | x  \ Value: {0}$
  \.,..,.,.\
"
        },
        {
            "key", @"You received key to Gringott's vault!

 ,o.          8 8
d   bzzzzzzzza8o8b 
 `o'
Value: {0}$
"
        },
        {
            "wand", @"You received Blackwand!
( ͡° ͜ʖ ͡°)⊃―━━☆⌒*・。.
'Avada Kedavra!'

Value: {0}$
"
        }
    };
    #endregion

    // Game items variables
    [HideInInspector] string itemToBuy = "";
    [HideInInspector] int itemName = 0;
    [HideInInspector] int itemPrice = 1;
    [HideInInspector] int itemLevel = 2;
    [HideInInspector] int itemShopLevel = 3;
    [HideInInspector] int itemLvl2UpgradeCost = 4;
    [HideInInspector] int itemLvl3UpgradeCost = 5;
    [HideInInspector] int itemStartingPrice = 6;

    #region gameItems container
    Dictionary<string, string[]> gameItems = new Dictionary<string, string[]>
    {
        {"enigma", new string[]
        {
            "enigma",  // itemName 0
            "1",  // itemPrice 1
            "0",  // itemLevel 2
            "1",  // itemShopLevel 3
            "2",  // LvL 2 upgrade cost 4
            "3",  // LvL 3 upgrade cost 5
            "1",  // starting price 6 - must be the same as item price 1
        }
        },
        {"decoder", new string[]
        {
            "decoder",
            "1",
            "0",
            "1",
            "3",
            "6",
            "1",
        }
        },
        {"hacktimer", new string[]
        {
            "hacking timer",
            "3",
            "0",
            "1",
            "4",
            "8",
            "3",
        }
        },
        {"auctioneer", new string[]
        {
            "auctioneer",
            "3",
            "0",
            "1",
            "4",
            "8",
            "3",
        }
        },
        {"loster", new string[]
        {
            "loster",
            "3",
            "0",
            "1",
            "4",
            "8",
            "3",
        }
        },
        {"timeencoder", new string[]
        {
            "timeencoder",
            "3",
            "0",
            "1",
            "4",
            "8",
            "3",
        }
        },
        {"bribe", new string[]
        {
            "bribe",
            "3",
            "0",
            "1",
            "4",
            "8",
            "3",
        }
        },
    };
    #endregion

    // Game State
    string passwordHint = "";
    string enigmaHint = "";
    string decoderHint = "";
    int menuCounter = 0;
    int crimeLevel = 1;
    float shopCrimeChance = .5f;
    private bool timerOn;
    float levelTime = 0f;
    float currentCounterTime = 0f;
    float[] levelTimeValues = { 20f, 30f, 40f};
    float[] hackTimerTimeBonus = { 5f, 10f, 15f};
    bool enigmaActive = false;
    bool enigmaMaxLevel = false;
    bool decoderActive = false;
    bool decoderMaxLevel = false;
    bool hackTimerActive = false;
    bool hackTimerMaxLevel = false;
    bool busted = false;
    int level;  // member variable storing current level
    int money = 0;
    int felonyLevel = 0;
    string password;
    enum Screen { MainMenu, Password, Win, Inventory, Shop, BuyMenu, Sell, Sold, Back, ItemBuyConfirm, Stop, ShopCrime, TimesUp };
    Screen currentScreen;
    Dictionary<string, int> inventory = new Dictionary<string, int>();
    Dictionary<string, int> inventoryCounter = new Dictionary<string, int>();

    // Strings
    #region Errors, hints, prompt messagess
    [HideInInspector] string mainMenuScreen = "Press 'd' for DarkWeb shop\nPress 'i' for inventory\n\nWhat would you like to hack into?\nPress 1 for {0}\nPress 2 for {1}\nPress 3 for {2}";
    [HideInInspector] string mainMenuScreenPL = "Do czego chcesz się włamać?\nNaciśnij 1 dla sklepu żabka\nNaciśnij 2 dla Rebel Nature Gym\nNaciśnij 3 dla Hogwartu";
    [HideInInspector] string menuHint = "Type 'menu' for menu";
    [HideInInspector] string menuHintPL = "Wpisz 'menu' aby wrócić do menu";
    [HideInInspector] string validOptionHint = "Please choose a valid option\nor type 'menu' for menu";
    [HideInInspector] string validOptionHintPL = "Wybierz odpowiednią opcję";
    [HideInInspector] string validOption2Hint = "Please choose a valid option";
    [HideInInspector] string backHint = "Type 'b' for back or 'menu' for menu";

    [HideInInspector] string passwordPrompt = "Please enter a password:";
    [HideInInspector] string passwordPromptPL = "*podpowiedź: {1}\nWprowadź hasło:";
    [HideInInspector] string tryAgainMessage = "Password incorrect, please try again.";
    [HideInInspector] string tryAgainMessagePL = "Błędne hasło, spróbuj ponownie.";
    [HideInInspector] string shopMenu = "Welcome to the DarkWeb store!\nPress 1 for Buy\nPress 2 for Sell";
    [HideInInspector] string sellItemQuestion = "Would you like to sell all your items?\nPress y/Yes or n/NO";
    [HideInInspector] string BuyMenu = "What would like to buy?";
    [HideInInspector] string cantAfford = "You can't afford this item.";
    [HideInInspector] string itemMaxLevelHint = "Item already in your inventory.";
    [HideInInspector] string shopCrimeMessage = "Something went wrong...\nWhen you were leaving the shop, the\npolice appeared!\nYou managed to escape but you\nlost half of your sell value" +
        "and\nfelony level icreased by {0}0%!";
    [HideInInspector] string counterString = "{0} sec.";
    [HideInInspector] string counterBonusString = "{0} sec. ({1} sec. time bonus)";
    [HideInInspector] string timesUpMessage = "You fail to hack in time...\nSomeone notified the police.\nFelony level increased by {0}0%!";
    [HideInInspector] string timePenaltyMessage = "Wrong password.\nHack time reduced by {0} sec.";
    [HideInInspector] string safeConnectionMessage = "You didn't close safe connection\nproperly when you decided to finish\nhacking. Police found your network\ntrace. Felony level " +
        "increased by\n{0}0%!";
    [HideInInspector] string leavingPasswordMessage = "\nRepeat 'menu' if you want to quit\nhacking - this action will cause you\npenalty.";

    Slider slider;
    [SerializeField] GameObject progressBar = null;
    [SerializeField] Text counterText = null;
    #endregion

    void Start()
    {
        slider = gameObject.GetComponentInChildren<Slider>();
        progressBar.SetActive(false);
        counterText.gameObject.SetActive(false);
        ShowMainMenu();
        money = 100000;  // DELETE
    }

    private void Update()
    {
        CheckFelony();
        LevelTimeCounter();
        if (currentScreen == Screen.Password && timerOn)
        {
            trackTimerTime();
        }
    }

    // Display main menu
    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        SetUpScreen(Screen.MainMenu);
        Terminal.WriteLine(string.Format(mainMenuScreen, locations[0], locations[1], locations[2]));
    }

    void SetUpScreen(Screen screen)
    {
        currentScreen = screen;
    }

    void CheckMenuCounter()
    {
        if (menuCounter == 2)
        {
            ResetMenuCounter();
            DisableTimer();
            ClearPasswordAndHints();
            IncreaseFelony(level);
            SetUpScreen(Screen.Back);
            Terminal.ClearScreen();
            Terminal.WriteLine(string.Format(safeConnectionMessage, level));
        }
        else
        {
            DisplayPasswordScreen();
            Terminal.WriteLine(leavingPasswordMessage);
        }
    }

    // Method deciding how to handle user input
    void OnUserInput(string input)
    {
        // Player can always go to main menu
        if (input == "menu")
        {
            if (currentScreen == Screen.Password)
            {
                IncreaseMenuCounter();
                CheckMenuCounter();       
            }
            else
            {
                ShowMainMenu();
            }

        }
        else if (input == "/saldo")
        {
            Terminal.WriteLine($"Money: {money}$");
        }
        else if (input == "/felony")
        {
            ShowFelonyLevel();
        }
        else switch (currentScreen)
            {
                #region currentScreen cases
                case Screen.MainMenu:
                    RunMainMenu(input);
                    break;
                case Screen.Password:
                    CheckPassword(input);
                    break;
                case Screen.Win:
                    GoBack(input);
                    break;
                case Screen.Inventory:
                    GoBack(input);
                    break;
                case Screen.Shop:
                    RunShopMenu(input);
                    break;
                case Screen.BuyMenu:
                    ChooseBuyItem(input);
                    break;
                case Screen.ItemBuyConfirm:
                    ConfirmBuy(input);
                    break;
                case Screen.Sell:
                    SellItemsMenu(input);
                    break;
                case Screen.Sold:
                    GoBack(input);
                    break;
                case Screen.Back:
                    Terminal.WriteLine(menuHint);
                    break;
                case Screen.Stop:
                    Terminal.WriteLine(menuHint);
                    break;
                case Screen.ShopCrime:
                    Terminal.WriteLine(menuHint);
                    break;
                case Screen.TimesUp:
                    GoBack(input);
                    break;
                default:
                    Debug.LogError("OnUserInput currentScreen switch statement Error.");
                    break;
                #endregion
            }
    }

    void ResetMenuCounter()
    {
        menuCounter = 0;
    }

    private void IncreaseMenuCounter()
    {
        menuCounter += 1;
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
            Terminal.WriteLine(validOptionHint);
        }
    }

    void GoBack(string input)
    {
        var inputBackIsValid = (input == "b" || input == "back" || input == "Back" || input == "BACK");
        if (inputBackIsValid)
        {
            switch (currentScreen)
            {
                #region currentScreen cases
                case Screen.Win:
                    AskForPassword();
                    break;
                case Screen.BuyMenu:
                    ShowShop();
                    break;
                case Screen.Sold:
                    ShowShop();
                    break;
                case Screen.Inventory:
                    ShowMainMenu();
                    break;
                case Screen.TimesUp:
                    AskForPassword();
                    break;
                default:
                    break;
                #endregion
            }
        }
        else
        {
            Terminal.WriteLine(backHint);
        }
    }

    // Method setting random password
    void AskForPassword()
    {
        SetUpScreen(Screen.Password);
        if (string.IsNullOrEmpty(password))
        {
            SetRandomPassword();
        }
        if (string.IsNullOrEmpty(passwordHint))
        {
            CreatePasswordHint();
        }
        if (decoderActive && string.IsNullOrEmpty(decoderHint))
        {
            CreateDecoderHint();
        }
        if (enigmaActive && string.IsNullOrEmpty(enigmaHint))
        {
            CreateEnigmaHint();
        }
        StartTimer();
        DisplayPasswordScreen();
    }

    private void DisplayPasswordScreen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(menuHint);
        Terminal.WriteLine(locations[level - 1]);
        Terminal.WriteLine(passwordHint);
        if (decoderActive)
        {
            Terminal.WriteLine(decoderHint);
        }
        if (enigmaActive)
        {
            Terminal.WriteLine(enigmaHint);
        }
        Terminal.WriteLine(string.Format(passwordPrompt));
    }

    void ClearPassword()
    {
        password = "";
    }

    void StartTimer()
    {
        timerOn = true;
        SetLevelTime();
        progressBar.SetActive(true);
        counterText.gameObject.SetActive(true);
        currentCounterTime = levelTime;
    }

    private void SetLevelTime()
    {
        if (hackTimerActive)
        {
            levelTime = levelTimeValues[level - 1] + hackTimerTimeBonus[level - 1];
        }
        else
        {
            levelTime = levelTimeValues[level - 1];
        }
    }

    void LevelTimeCounter()
    {
        if (currentCounterTime > 0 && timerOn)
        {
            currentCounterTime -= Time.deltaTime;
            slider.value = currentCounterTime / levelTime;
            if (hackTimerActive)
            {
                counterText.text = string.Format(counterBonusString, (currentCounterTime).ToString("0.0"), hackTimerTimeBonus[int.Parse(gameItems["hacktimer"][itemLevel]) - 1]);
            }
            else
            {
                counterText.text = string.Format(counterString, (currentCounterTime).ToString("0.0"));
            }
        }
    }

    void trackTimerTime()
    {
        if (currentCounterTime <= 0)
        {
            DisableTimer();
            DisplayTimesUp();
            TimesUp();
        }
    }

    void DisableTimer()
    {
        timerOn = false;
        currentCounterTime = 0;
        levelTime = 0;
        progressBar.SetActive(false);
        counterText.gameObject.SetActive(false);

    }

    void DisplayTimesUp()
    {
        SetUpScreen(Screen.TimesUp);
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(timesUpMessage, level));
    }

    void TimesUp()
    {
        ClearPasswordAndHints();
        IncreaseFelony(level);
    }

    void TimePenalty()
    {
        DisplayPasswordScreen();
        Terminal.WriteLine(string.Format(timePenaltyMessage, level));
        currentCounterTime -= level;
    }

    void CreatePasswordHint()
    {
        string hint = "*hint: {0}";
        passwordHint = string.Format(hint, password.Anagram());
    }

    void CreateEnigmaHint()
    {
        string hint = "*enigma: ";
        switch (gameItems["enigma"][itemLevel])
        {
            case "1":
                hint += password[0] + new string('*', password.Length - int.Parse(gameItems["enigma"][itemLevel]));
                break;
            case "2":
                hint += password.Substring(0, 2) + new string('*', password.Length - int.Parse(gameItems["enigma"][itemLevel]));
                break;
            case "3":
                hint += password.Substring(0, 3) + new string('*', password.Length - int.Parse(gameItems["enigma"][itemLevel]));
                break;
            default:
                break;
        }
        enigmaHint = hint;
    }

    void CreateDecoderHint()
    {
        string hint = "*decoder: ";
        List<int> shuffledList = new List<int>();
        for (int i = 0; i < passwordsHints[password].Length; i++)
        {
            shuffledList.Insert(Random.Range(0, shuffledList.Count + 1), i);
        }

        for (int i = 1; i <= int.Parse(gameItems["decoder"][itemLevel]); i++)
        {
            hint += $"{passwordsHints[password][shuffledList[i-1]]} ";
        }

        decoderHint = hint;
    }

    void ClearPasswordAndHints()
    {
        ClearPassword();
        ClearPasswordHint();
        ClearEnigmaHint();
        ClearDecoderHint();
    }

    void ClearEnigmaHint()
    {
        enigmaHint = "";
    }

    void ClearDecoderHint()
    {
        decoderHint = "";
    }

    void ClearPasswordHint()
    {
        passwordHint = "";
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
            ClearPasswordAndHints();
            DisableTimer();
        }
        else
        {
            TimePenalty();
        }
    }

    void DisplayWinScreen()
    {
        SetUpScreen(Screen.Win);
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

    int SetRewardValue(string selectedReward)
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

    void DisplayReward(string selectedReward, int selectedRewardValue,Dictionary<string, string> levelRewards)
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

    void InventoryAddReward(string selectedReward, int selectedRewardValue)
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

    void ShowShop()
    {
        SetUpScreen(Screen.Shop);
        Terminal.ClearScreen();
        Terminal.WriteLine(shopMenu);
    }

    void RunShopMenu(string input)
    {
        if (input == "1")
        {
            ShowBuyMenu();
        }
        else if (input == "2")
        {
            CanSell();
        }
        else
        {
            Terminal.WriteLine(validOptionHint);
        }
    }

    void ShowBuyMenu()
    {
        SetUpScreen(Screen.BuyMenu);
        string itemLabel = "{0} Name: {1} Level: {2}\nPrice: {3}$";
        string itemLabelMax = "{0} Name: {1}, Level: \nMAX LEVEL";
        Terminal.ClearScreen();
        Terminal.WriteLine(BuyMenu);
        if (!enigmaMaxLevel)
        {
            Terminal.WriteLine(string.Format(itemLabel, "1", gameItems["enigma"][itemName], gameItems["enigma"][itemShopLevel], gameItems["enigma"][itemPrice]));
        }
        if (enigmaMaxLevel)
        {
            Terminal.WriteLine(string.Format(itemLabelMax, "1", gameItems["enigma"][itemName]));
        }
        if (!decoderMaxLevel)
        {
            Terminal.WriteLine(string.Format(itemLabel, "2", gameItems["decoder"][itemName], gameItems["decoder"][itemShopLevel], gameItems["decoder"][itemPrice]));
        }
        if (decoderMaxLevel)
        {
            Terminal.WriteLine(string.Format(itemLabelMax, "2", gameItems["decoder"][itemName]));
        }
        if (!hackTimerMaxLevel)
        {
            Terminal.WriteLine(string.Format(itemLabel, "3", gameItems["hacktimer"][itemName], gameItems["hacktimer"][itemShopLevel], gameItems["hacktimer"][itemPrice]));
        }
        if (hackTimerMaxLevel)
        {
            Terminal.WriteLine(string.Format(itemLabelMax, "3", gameItems["hacktimer"][itemName], gameItems["hacktimer"][itemShopLevel], gameItems["hacktimer"][itemPrice]));
        }

    }

    void ChooseBuyItem(string input)
    {
        var isValidChoice = (input == "1" || input == "2" || input == "3");
        if (isValidChoice)
        {
            if (input == "1")
            {
                if (enigmaMaxLevel)
                {
                    Terminal.WriteLine(itemMaxLevelHint);
                }
                else if (CanAffordItem("enigma"))
                {
                    ShowBuyConfirm("enigma");
                }
                else
                {
                    Terminal.WriteLine(cantAfford);
                }
            }
            else if (input == "2")
            {
                if (decoderMaxLevel)
                {
                    Terminal.WriteLine(itemMaxLevelHint);
                }
                else if (CanAffordItem("decoder"))
                {
                    ShowBuyConfirm("decoder");
                }
                else
                {
                    Terminal.WriteLine(cantAfford);
                }
            }
            else if (input == "3")
            {
                if (hackTimerMaxLevel)
                {
                    Terminal.WriteLine(itemMaxLevelHint);
                }
                else if (CanAffordItem("hacktimer"))
                {
                    ShowBuyConfirm("hacktimer");
                }
                else
                {
                    Terminal.WriteLine(cantAfford);
                }
            }
        }
        else
        {
            Terminal.WriteLine(validOption2Hint);
            GoBack(input);
        }
    }

    bool CanAffordItem(string item)
    {
        bool canAfford = false;
        switch (item)
        {
            case "enigma":
                if (money >= int.Parse(gameItems["enigma"][itemPrice]))
                {
                    canAfford = true;
                }
                break;
            case "decoder":
                if (money >= int.Parse(gameItems["decoder"][itemPrice]))
                {
                    canAfford = true;
                }
                break;
            case "hacktimer":
                if (money >= int.Parse(gameItems["hacktimer"][itemPrice]))
                {
                    canAfford = true;
                }
                break;
            default:
                Debug.LogError("CanAffordItem switch statement Error.");
                break;
        }
        return canAfford;
    }

    void ShowBuyConfirm(string item)
    {
        SetUpScreen(Screen.ItemBuyConfirm);
        string confirmQuestion = "Would you like to buy:\n{0} lvl. {1} for {2}$?\n\nPress y/Yes or n/NO";
        Terminal.ClearScreen();
        switch (item)
        {
            case "enigma":
                Terminal.WriteLine(string.Format(confirmQuestion, gameItems["enigma"][itemName], gameItems["enigma"][itemShopLevel], gameItems["enigma"][itemPrice]));
                itemToBuy = "enigma";
                break;
            case "decoder":
                Terminal.WriteLine(string.Format(confirmQuestion, gameItems["decoder"][itemName], gameItems["decoder"][itemShopLevel], gameItems["decoder"][itemPrice]));
                itemToBuy = "decoder";
                break;
            case "hacktimer":
                Terminal.WriteLine(string.Format(confirmQuestion, gameItems["hacktimer"][itemName], gameItems["hacktimer"][itemShopLevel], gameItems["hacktimer"][itemPrice]));
                itemToBuy = "hacktimer";
                break;
            default:
                Debug.LogError("ShowBuyConfirm switch statement Error.");
                break;
        }
    }

    void ConfirmBuy(string input)
    {
        var isValidYes = (input == "y" || input == "yes" || input == "Yes" || input == "YES");
        var isValidNo = (input == "n" || input == "no" || input == "No" || input == "NO");

        if (isValidYes)
        {
            BuyItem(itemToBuy);
        }
        else if (isValidNo)
        {
            ShowBuyMenu();
        }
        else
        {
            Terminal.WriteLine(validOptionHint);
        }
    }

    void BuyItem(string item)
    {
        switch (item)
        {
            case "enigma":
                money -= int.Parse(gameItems["enigma"][itemPrice]);
                enigmaActive = true;
                break;
            case "decoder":
                money -= int.Parse(gameItems["decoder"][itemPrice]);
                decoderActive = true;
                break;
            case "hacktimer":
                money -= int.Parse(gameItems["hacktimer"][itemPrice]);
                hackTimerActive = true;
                break;
            default:
                break;
        }
        UpdateShopValues(itemToBuy);
        itemToBuy = "";
        ShowBuyMenu();
    }

    void UpdateShopValues(string item)
    {
        int newLevelValue;
        switch (item)
        {
            case "enigma":
                if (!enigmaMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems["enigma"][itemLevel]) + 1;
                    gameItems["enigma"][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems["enigma"][itemLevel]) == 3)
                    {
                        enigmaMaxLevel = true;
                        break;
                    }
                    gameItems["enigma"][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems["enigma"][itemLevel]) == 1)
                    {
                        gameItems["enigma"][itemPrice] = gameItems["enigma"][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems["enigma"][itemPrice] = gameItems["enigma"][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "decoder":
                if (!decoderMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems["decoder"][itemLevel]) + 1;
                    gameItems["decoder"][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems["decoder"][itemLevel]) == 3)
                    {
                        decoderMaxLevel = true;
                        break;
                    }
                    gameItems["decoder"][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems["decoder"][itemLevel]) == 1)
                    {
                        gameItems["decoder"][itemPrice] = gameItems["decoder"][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems["decoder"][itemPrice] = gameItems["decoder"][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "hacktimer":
                if (!hackTimerMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems["hacktimer"][itemLevel]) + 1;
                    gameItems["hacktimer"][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems["hacktimer"][itemLevel]) == 3)
                    {
                        hackTimerMaxLevel = true;
                        break;
                    }
                    gameItems["hacktimer"][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems["hacktimer"][itemLevel]) == 1)
                    {
                        gameItems["hacktimer"][itemPrice] = gameItems["hacktimer"][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems["hacktimer"][itemPrice] = gameItems["hacktimer"][itemLvl3UpgradeCost];
                    }
                }
                break;
            default:
                break;
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

    void RunSellMenu()
    {
        SetUpScreen(Screen.Sell);
        Terminal.ClearScreen();
        Terminal.WriteLine(sellItemQuestion);
    }

    void SellItemsMenu(string input)
    {
        var isValidYes = (input == "y" || input == "yes" || input == "Yes" || input == "YES");
        var isValidNo = (input == "n" || input == "no" || input == "No" || input == "NO");
        if (isValidYes)
        {
            if (Random.value <= shopCrimeChance)
            {
                DisplayShopCrimeScreen();
                ShopCrime();
            }
            else
            {
                SellItems();
                RemoveInventory();
                SetUpScreen(Screen.Sold);
            }
        }
        else if (isValidNo)
        {
            ShowShop();
        }
        else
        {
            Terminal.WriteLine(validOptionHint);
        }
    }

    void DisplayShopCrimeScreen()
    {
        SetUpScreen(Screen.ShopCrime);
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(shopCrimeMessage, crimeLevel));
    }

    void ShopCrime()
    {
        float percentageTaken = .9f;  // maybe move it to variable section as public var not local
        int sellValue = CalculateSellValueItems()[0];
        int newMoneyValue = (int) (sellValue - (sellValue * percentageTaken));  // int number representation e.x. sell value 100, ShopCrime(), 100 - 90% = (100 - (100 * .9f))

        RemoveInventory();
        IncreaseFelony(crimeLevel);
        AddMoney(newMoneyValue);
    }

    void SellItems()
    {
        int[] sellValueItemsNumber = CalculateSellValueItems();
        int sellValue = sellValueItemsNumber[0];
        int itemsNumber = sellValueItemsNumber[1];
        string plural = "";

        //foreach (KeyValuePair<string, int> item in inventory)
        //{
        //    sellValue += item.Value;
        //    itemsNumber += inventoryCounter[item.Key];
        //}

        AddMoney(sellValue);

        if (itemsNumber > 1)
        {
            plural = "s";
        }
        Terminal.ClearScreen();
        Terminal.WriteLine($"You sold {itemsNumber} item{plural} for {sellValue}$.");
    }

    void AddMoney(int value)
    {
        money += value;
    }

    int[] CalculateSellValueItems()
    {
        int sellValue = 0;
        int itemsNumber = 0;

        foreach (KeyValuePair<string, int> item in inventory)
        {
            sellValue += item.Value;
            itemsNumber += inventoryCounter[item.Key];
        }
        
        return new [] { sellValue, itemsNumber};
    }

    void RemoveInventory()
    {
        inventory.Clear();
        inventoryCounter.Clear();
    }

    void ShowInventory()
    {
        SetUpScreen(Screen.Inventory);
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
            Terminal.WriteLine(string.Format(inventoryString, money, itemsAmount, plural = "s", itemsValue));
        }
    }

    void IncreaseFelony(int increaseValue)
    {
        felonyLevel += increaseValue;
        if (currentScreen == Screen.Password)
        {
            Terminal.WriteLine(timePenaltyMessage);
        }
    }

    void ShowFelonyLevel()
    {
        string felonyReadyLabel;
        if (felonyLevel == 0)
        {
            felonyReadyLabel = "[{0}] {1}%";
        }
        else
        {
            felonyReadyLabel = "[{0}] {1}0%";
        }

        string felonyLevelsString = "";
        for (int i = 1; i <= felonyLevel; i++)
        {
            felonyLevelsString += "*";
        }
        felonyLevelsString += new string('-', 10 - felonyLevel);
        Terminal.WriteLine(string.Format(felonyReadyLabel, felonyLevelsString, felonyLevel));
    }

    void Busted()
    {
        felonyLevel = 0;
        SetUpScreen(Screen.Stop);
        Terminal.ClearScreen();
        money = -5000;
        enigmaActive = false;
        enigmaMaxLevel = false;
        decoderActive = false;
        decoderMaxLevel = false;
        hackTimerActive = false;
        hackTimerMaxLevel = false;
        foreach (KeyValuePair<string, string[]> item in gameItems)
        {
            gameItems[item.Key][itemPrice] = gameItems[item.Key][itemStartingPrice];
            gameItems[item.Key][itemLevel] = "0";  // TEST on 
            gameItems[item.Key][itemShopLevel] = "1";  // TEST on
        }
        Terminal.WriteLine("Felony level reached 100% and...\nYou got BUSTED!\nThe Police commandeered all your money and items.\nYou also have to pay 5000$ penalty.");
    }

    void CheckFelony()
    {
        if (felonyLevel >= 10)
        {
            Busted();
        }
    }
}
