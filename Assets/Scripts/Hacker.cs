using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    // Locations
    [HideInInspector] string[] locations = {"Local shop", "CrossFit gym", "Police Station", "Hogwarts", "NASA" };
    [HideInInspector] string[] shopNames = { "Crazy Hacker Shop", "Weird Guys Shop", "Police .Net Vendor", "IP DataBase"};

    // Level rewards names
    [HideInInspector] string[] level1RewardsNames = {"icecream", "laptop", "revenue", "tape", "vodka"};
    [HideInInspector] string[] level2RewardsNames = {"dumbbell", "plate", "barbell", "picture", "cashRegister"};
    [HideInInspector] string[] level3RewardsNames = {"handcuff", "gun", "weapon", "badge", "dna"};
    [HideInInspector] string[] level4RewardsNames = {"broom", "book", "map", "key", "wand"};
    [HideInInspector] string[] level5RewardsNames = {"hole", "star", "ticket", "rocket", "alien"};


    // Level passwords
    #region Passwords and Passwords Hints
    [HideInInspector] string[] level1Passwords = {"beer", "icecream", "drink", "fruits", "food", "candy", "jelly", "cookie", "rice", "cigarettes", "bread", "money", "specie",
        "vegetables", "meat", "discount", "customer", "storage", "basket", "payment", "assortment", "stand", "products", "cosmetics", "dairy"};

    [HideInInspector] string[] level2Passwords = { "functional", "backsquat", "barbell", "dumbbell", "exercise", "isolation", "streching", "cutting", "powerlifting",
        "conditioning", "gymnastics", "steroids", "bodybuilding", "repeats", "compete", "coach", "spinning", "suplements", "creatine", "proteins", "cloakroom", "showers", "exhaustion", "record", "atlas"};

    [HideInInspector] string[] level3Passwords = { "handcuffs", "officer", "suspect", "pistol", "prison", "detective", "evidence", "radiostation", "badge", "taser", "drugs",
        "deposit", "chase", "felony", "bulletproof", "uniform", "epaulets", "distinctions", "baton", "baton", "notebook", "robbery", "violence", "aggression", "victim", "investigation"};

    [HideInInspector] string[] level4Passwords = { "quidditch", "blackmagic", "slytherin", "sectumsempra", "buckbeak", "gryffindor", "hufflepuff", "ravenclaw", "polyjuice",
        "muggles", "phoenix", "dumbledore", "horcrux", "dudley", "basilisk", "animagus", "alohomora", "philosopher", "invisibility", "centaur", "azkaban", "dementor", "nagini", "aragog", "werewolf"};

    [HideInInspector] string[] level5Passwords = { "apollo", "astronaut", "research", "asteroid", "spacecraft", "eisenhower", "explorer", "skylab", "telescope", "armstrong",
        "columbia", "satellite", "planet", "comet", "solar", "cosmos", "budget", "alien", "radar", "secret", "weightlessness", "theory", "shuttle", "counting", "science"};
    #endregion

    // Passwords hints
    #region Passwords Hints
    [HideInInspector] Dictionary<string, string[]> passwordsHints = new Dictionary<string, string[]>
    {
        // Level 1
        {"beer", new string[] {"alcohol", "sprakling", "pub"}},
        {"icecream", new string[] {"cold", "summer", "refreshing"}},
        {"drink", new string[] {"liquid", "thirst", "refreshing"}},
        {"fruits", new string[] {"vitamins", "sweet", "sour"}},
        {"food", new string[] {"hot-dog", "bread", "eat"}},
        {"candy", new string[] {"sweet", "sugar", "colorful"}},
        {"jelly", new string[] {"sweet", "gummy", "colorful"}},
        {"cookie", new string[] {"sweet", "brown", "jar"}},
        {"rice", new string[] {"china", "sushi", "chicken"}},
        {"cigarettes", new string[] {"addiction", "smoke", ""}},
        {"bread", new string[] {"flour", "loaf", "baker"}},
        {"money", new string[] {"bank", "dolar", "euro"}},
        {"specie", new string[] {"silver", "copper", "coin"}},
        {"vegetables", new string[] {"green", "farmer", "garden"}},
        {"meat", new string[] {"chicken", "fish", "beef"}},
        {"discount", new string[] {"sale", "crowd", "products"}},
        {"customer", new string[] {"person", "regular", "burdensome"}},
        {"storage", new string[] {"area", "shelves", "products"}},
        {"basket", new string[] {"handle", "shopping", "help"}},
        {"payment", new string[] {"transaction", "receipt", "check"}},
        {"assortment", new string[] {"products", "offer", "change"}},
        {"stand", new string[] {"products", "assortment", "prices"}},
        {"products", new string[] {"assortment", "items", "label"}},
        {"cosmetics", new string[] {"soap", "deodorant", "shampoo"}},
        {"dairy", new string[] {"milk", "cheese", "yoghurt"}},
        
        // Level 2
        {"functional", new string[] {"type of training", "daily movements", "versatile"}},
        {"backsquat", new string[] {"exercise", "powerlifting", "sit" }},
        {"barbell", new string[] {"long", "heavy", "steel" }},
        {"dumbbell", new string[] {"can be heavy", "for one hand mostly", "use to exercise" }},
        {"exercise", new string[] {"home", "gym", "body activity" }},
        {"isolation", new string[] {"single", "exercises", "part"}},
        {"streching", new string[] {"body", "gymnastics", "motion"}},
        {"cutting", new string[] {"diet", "weight", "austerity"}},
        {"powerlifting", new string[] {"heavy", "olympiad", "strength"}},
        {"conditioning", new string[] {"run", "bike", "oxygen"}},
        {"gymnastics", new string[] {"olympiad", "strength", "bodyweight"}},
        {"steroids", new string[] {"forbidden", "needle", "strenght"}},
        {"repeats", new string[] {"exercise", "max", "amount"}},
        {"compete", new string[] {"athlete", "lose", "win"}},
        {"bodybuilding", new string[] {"strength", "goodlooking", "arnold"}},
        {"coach", new string[] {"team", "classes", "discipline"}},
        {"spinning", new string[] {"bike", "classes", "cycling"}},
        {"suplements", new string[] {"creatine", "bcaa", "proteins"}},
        {"creatine", new string[] {"suplements", "strength", "endurance"}},
        {"proteins", new string[] {"suplements", "muscle", "build"}},
        {"cloakroom", new string[] {"lockers", "clothes", "showers"}},
        {"showers", new string[] {"cloakroom", "hygiene", "gel"}},
        {"exhaustion", new string[] {"workout", "exercise", "powerless"}},
        {"record", new string[] {"personal", "exercise", "max"}},
        {"atlas", new string[] {"multifunctional", "exercises", "bodybuilding"}},

        // Level 3
        {"handcuffs", new string[] {"metal", "arrested", "aggressive"}},
        {"officer", new string[] {"superior", "person", "duty"}},
        {"suspect", new string[] {"charge", "felony", "crime"}},
        {"pistol", new string[] {"bullet", "cop", "dangerous"}},
        {"prison", new string[] {"liberty", "building", "suspect"}},
        {"detective", new string[] {"case", "suspect", "solved"}},
        {"evidence", new string[] {"crime", "suspect", "in case"}},
        {"radiostation", new string[] {"between", "talk", "waves"}},
        {"badge", new string[] {"shield", "sign", "star"}},
        {"taser", new string[] {"weapon", "electricity", "shoot"}},
        {"drugs", new string[] {"gang", "cartel", "substance"}},
        {"deposit", new string[] {"items", "lost", "airport"}},
        {"chase", new string[] {"traffic", "car", "street"}},
        {"felony", new string[] {"guilt", "crime", "level"}},
        {"bulletproof", new string[] {"vest", "guns", "deadly"}},
        {"uniform", new string[] {"belt", "shoes", "shirt"}},
        {"epaulets", new string[] {"uniform", "distinctions", "rank"}},
        {"distinctions", new string[] {"rank", "officer", "commander"}},
        {"baton", new string[] {"necessity", "violence", "defence"}},
        {"notebook", new string[] {"pen", "paper", "cover"}},
        {"robbery", new string[] {"money", "burglar", "thief"}},
        {"violence", new string[] {"aggression", "person", "victim"}},
        {"aggression", new string[] {"violence", "torturer", "blood"}},
        {"victim", new string[] {"felony", "torturer", "judgment"}},
        {"investigation", new string[] {"detective", "suspect", "evidence"}},

        // Level 4
        {"quidditch", new string[] {"game", "golden snitch", "broom"}},
        {"blackmagic", new string[] {"forbidden", "dangerous", "used by bad people"}},
        {"slytherin", new string[] {"cunning", "snake", "salazar"}},
        {"sectumsempra", new string[] {"deep", "bleed", "spell"}},
        {"buckbeak", new string[] {"animal", "flying", "magic"}},
        {"gryffindor", new string[] {"lion", "harry", "godric"}},
        {"hufflepuff", new string[] {"helga", "badger", "cedrik"}},
        {"ravenclaw", new string[] {"rowena", "eagle", "luna"}},
        {"polyjuice", new string[] {"potion", "advanced", "shift"}},
        {"muggles", new string[] {"people", "usual", "artur weasley"}},
        {"phoenix", new string[] {"magic", "animal", "fire"}},
        {"dumbledore", new string[] {"school", "wizard", "powerful"}},
        {"horcrux", new string[] {"part", "soul", "items"}},
        {"dudley", new string[] {"cousin", "harry", "fat"}},
        {"basilisk", new string[] {"eyes", "stone", "fang"}},
        {"animagus", new string[] {"animal", "wizard", "transform"}},
        {"alohomora", new string[] {"spell", "lock", "unlock"}},
        {"philosopher", new string[] {"stone", "first", "immortal"}},
        {"invisibility", new string[] {"cloak", "hide", "sneak"}},
        {"centaur", new string[] {"firenze", "hagrid", "forest"}},
        {"azkaban", new string[] {"prison", "dementors", "syrius"}},
        {"demetor", new string[] {"guard", "kiss", "soul"}},
        {"nagini", new string[] {"snake", "riddle", "horcrux"}},
        {"aragog", new string[] {"spider", "hagrid", "forest"}},
        {"werewolf", new string[] {"animal", "lupin", "moon"}},

        // Level 5
        {"apollo", new string[] {"program", "astronauts", "moon"}},
        {"astronaut", new string[] {"person", "space", "station"}},
        {"research", new string[] {"science", "scientis", "instruments"}},
        {"asteroid", new string[] {"rock", "ice", "atmosphere"}},
        {"spacecraft", new string[] {"crew", "ignition", "fuel"}},
        {"eisenhower", new string[] {"last name", "president", "founder"}},
        {"explorer", new string[] {"first", "satelite", "atificial"}},
        {"skylab", new string[] {"first", "station", "space"}},
        {"telescope", new string[] {"hubble", "orbit", "high resolution"}},
        {"armstrong", new string[] {"last name", "moon", "first"}},
        {"columbia", new string[] {"name", "first", "space shuttle"}},
        {"satellite", new string[] {"orbit", "body", "skirting"}},
        {"planet", new string[] {"earth", "mercury", "venus"}},
        {"comet", new string[] {"gas", "solar system", "body"}},
        {"solar", new string[] {"system", "sun", "planets"}},
        {"cosmos", new string[] {"stars", "planets", "asteroids"}},
        {"budget", new string[] {"millions", "money", "government"}},
        {"alien", new string[] {"ufo", "space", "ship"}},
        {"radar", new string[] {"data", "co-ordinates", "visibility"}},
        {"secret", new string[] {"mission", "data", "information"}},
        {"weightlessness", new string[] {"state", "gravity", "space"}},
        {"theory", new string[] {"big", "bang", "beginning"}},
        {"shuttle", new string[] {"discovery", "columbia", "ignition"}},
        {"counting", new string[] {"down", "start", "ignition"}},
        {"science", new string[] {"research", "laboratory", "instruments"}},
    };
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
            "plate", @"You received 25kg plate!
          .-""-.
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
    Dictionary<string, string> level4Rewards = new Dictionary<string, string>
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

    #region Level 4 Rewards
    Dictionary<string, string> level3Rewards = new Dictionary<string, string>
    {
        {
            "handcuff", @"You received handcuff!
           /`  `\
          |      | Value: {0}$
[___]>=-=' \____/
"
        },
        {
            "gun", @"You received gun!
      __,_____
     / __.==--' Value: {0}$
    /#(-'
    `-'
"
        },
        {
            "weapon", @"
You received murder weapon!
 ______
|_,.,--\
   ||
   || Value: {0}$
   ##
   ##
"
        },
        {
            "badge", @"
   ,   /\   ,
  / '-'  '-' \
  |  POLICE  | You received police
  |   .--.   | badge!
  |  ( 19 )  | Value: {0}$
  \   '--'   /
   '--.  .--'
       \/
"
        },
        {
            "dna", @"You received DNA!
-. .-.   .-. 
  \   \ /   \  Value: {0}$
 / \   \   / \ 
~   `-~ `-`   `
"
        },
    };
    #endregion

    #region Level 5 Rewards
    Dictionary<string, string> level5Rewards = new Dictionary<string, string>
    {
        {
            "hole", @"
You found a hole in NASA fence!
=|===|===|/\=|===|===
=|===|===|\/=|===|===
    Value: {0}$
"
        },
        {
            "star", @"You received star!
   ,
__/ \__
\     / Value: {0}$
/_   _\
  \ /
   '
"
        },
        {
            "ticket", @"You received ticket to the moon!
     _..,
   .' .-'`_______
  /  /    |TICKET|
  |  |     ------
  \  '.___.; Value: {0}$
   '._  _.'
      ``
"
        },
        {
            "rocket", @"
     | You are now owner of rocket!
    / \
   |--o| Value: {0}$
  /     \
 |       |
 |       |
 |_______|
  |@| |@|
  ''' '''
"
        },
        {
            "alien", @"You received alien dead body!
  .-.
 (@ @)
  \-/ Value: {0}$
  / \
 /\ /\
/ _H_ \
"
        },
    };
    #endregion

    // Game items variables
    #region Game items variables
    [HideInInspector] string itemToBuy = "";
    [HideInInspector] int itemName = 0;
    [HideInInspector] int itemPrice = 1;
    [HideInInspector] int itemLevel = 2;
    [HideInInspector] int itemShopLevel = 3;
    [HideInInspector] int itemLvl2UpgradeCost = 4;
    [HideInInspector] int itemLvl3UpgradeCost = 5;
    [HideInInspector] int itemStartingPrice = 6;
    [HideInInspector] int itemDescription = 7;
    #endregion

    #region gameItems container
    Dictionary<string, string[]> gameItems = new Dictionary<string, string[]>
    {
        {"enigma", new string[]
        {
            "enigma",  // itemName 0
            "12500",  // itemPrice 1
            "0",  // itemLevel 2
            "1",  // itemShopLevel 3
            "37500",  // LvL 2 upgrade cost 4
            "50000",  // LvL 3 upgrade cost 5
            "12500",  // starting price 6 - must be the same as item price 1
            "Shows first letters of password",
        }
        },
        {"decoder", new string[]
        {
            "decoder",
            "12500",
            "0",
            "1",
            "37500",
            "50000",
            "12500",
            "Shows word hints about password",
        }
        },
        {"hacktimer", new string[]
        {
            "hacking timer",
            "12500",
            "0",
            "1",
            "37500",
            "50000",
            "12500",
            "Increases location hacking time",
        }
        },
        {"auctioneer", new string[]
        {
            "auctioneer",
            "12500",
            "0",
            "1",
            "40000",
            "70000",
            "12500",
            "Icreases items sell value",
        }
        },
        {"loster", new string[]
        {
            "loster",
            "37500",
            "0",
            "1",
            "50000",
            "70000",
            "37500",
            "Chance to avoid felony level increase",
        }
        },
        {"timeencoder", new string[]
        {
            "time encoder",
            "37500",
            "0",
            "1",
            "45000",
            "60000",
            "37500",
            "Reduces time penalty after not\nguessing password",
        }
        },
        {"bribe", new string[]
        {
            "bribe",
            "3",
            "0",
            "1",
        }
        },
        {"ipdatabase", new string[]
        {
            "ipdatabase",
        }
        },
    };
    #endregion

    // Game Variables
    #region Game State variables
    // Shop adjustables
    int complexPrice = 400000;  // Own hacking complex building cost
    float shopCrimeChance = .5f;  // chance to get shop crime event while selling items in shop
    int[] timeEncoderReduceValues = { 1, 2, 3 };  // encoder item values, index matches item level - reduce time (seconds) for time penalty provided by item
    float[] hackTimerTimeBonus = { 5f, 10f, 15f};  // hack timer time bonus values, index matches item level - value increasing level time value
    float[] LosterAvoidChances = { .2f, .25f, .33f };  // loster avoid chance, index matches item level - chance to avoid felony level penalty after hacking fail
    float[] auctioneerPercentageValues = { .1f, .2f, .3f};  // auctioneer item values, index matches item level - percentage value (.1f = 10%) of increased item sell value
    int[] IPcost = { 12500, 20000, 125000, 150000};  // ip addresses cost, index matches level (index 0 = level 2 ip address)
    int[] bribeCost = { 5000, 10000, 15000, 35000 };  // bribe cost, index: 0: -1f(felony), 1: -2f, 2: -3f, 4: set felony to 0
    int[] bribeReduceValue = { 1, 2, 3, 10 };  // bribe reduce felony level values

    // Level time values
    int[] timePenaltyValues = { 3, 4, 5, 5, 5 };  // level time penalty value (seconds), index matches level (0 index = 1 level)
    float[] levelTimeValues = { 20f, 30f, 40f, 40f, 40f};  // max hacking time for each level, index matches level (index 0 = level 1)

    // Game Objects section
    Slider slider;
    [SerializeField] GameObject progressBar = null;
    [SerializeField] Text counterText = null;
    public GameObject complexAnimationObject;
    public GameObject winScreenObject;
    private ComplexAnimation complexAnimationRef;
    private WinScreen winScreenRef;
    public GameObject complexWindowObject;
    private ComplexWindow complexWindowRef;

    // Game State varbiables
    int shopNumber;
    int menuCounter = 0;
    int crimeLevel = 1;
    float levelTime = 0f;
    float currentCounterTime = 0f;
    int level;  // member variable storing current level
    int money = 0;
    int felonyLevel = 0;
    string password;
    string previousPassword;
    enum Screen { MainMenu, Password, Win, WinAdditional, Inventory, Shop, Sell, Sold, Back, ItemBuyConfirm, Stop, ShopCrime, TimesUp, ChooseShop, Shop1, Shop2, Shop3, Shop4,
        BuildMenu, BuildConfirm,
        Build
    };
    Screen currentScreen;
    Dictionary<string, int> inventory = new Dictionary<string, int>();
    Dictionary<string, int> inventoryCounter = new Dictionary<string, int>();

    // Flag section
    private bool timerOn;
    private bool complexBuild;
    bool additionalReward = false;
    bool level1Locked = false;
    bool level2Locked = true;
    bool level3Locked = true;
    bool level4Locked = true;
    bool level5Locked = true;
    bool enigmaActive = false;
    bool enigmaMaxLevel = false;
    bool decoderActive = false;
    bool decoderMaxLevel = false;
    bool hackTimerActive = false;
    bool hackTimerMaxLevel = false;
    bool auctioneerActive = false;
    bool auctioneerMaxLevel = false;
    bool losterActive = false;
    bool losterMaxLevel = false;
    bool timeEncoderActive = false;
    bool timeEncoderMaxLevel = false;

    // String section
    string[] bribeNames = { "Harry", "Nikita", "Jackarta", "'Chief Smith'" };
    string passwordHint = "";
    string enigmaHint = "";
    string decoderHint = "";

    // Strings
    #region Errors, hints, prompt messagess
    [HideInInspector] string mainMenuScreen = "Press 'd' for DarkWeb shop\nPress 'i' for inventory\n\nWhat would you like to hack into?";
    [HideInInspector] string mainMenuScreenComplex = "Press 'd' for DarkWeb shop\nPress 'i' for inventory\nPress 'c' to visit your OHC\n\nWhat would you like to hack into?";
    [HideInInspector] string menuHint = "Type 'menu' for menu";
    [HideInInspector] string validOptionHint = "Please choose a valid option\nor type 'menu' for menu";
    [HideInInspector] string validOption2Hint = "Please choose a valid option";
    [HideInInspector] string backHint = "Type 'b' for back or 'menu' for menu";
    [HideInInspector] string forwardHint = "You found something else...\nType 'next'/'n' to check it";
    [HideInInspector] string passwordPrompt = "Please enter a password:";
    [HideInInspector] string shopMenu = "Welcome to the DarkWeb store!\nPress 1 for Buy\nPress 2 for Sell\nPress 3 for Build";
    [HideInInspector] string sellItemQuestion = "Would you like to sell all your items?\nPress y/Yes or n/NO";
    [HideInInspector] string cantAfford = "You can't afford this item.";
    [HideInInspector] string notEnoughMoneyMsg = "Not enough money.";
    [HideInInspector] string itemMaxLevelHint = "Item already in your inventory.";
    [HideInInspector] string shopCrimeMessage = "Something went wrong...\nWhen you were leaving the shop, the\npolice appeared!\nYou managed to escape but you lost\nhalf of your sell value and felony\nlevel icreased by {0}0%!\nType '/felony' to check felony level.";
    [HideInInspector] string counterString = "{0} sec.";
    [HideInInspector] string counterBonusString = "{0} sec. ({1} sec. time bonus)";
    [HideInInspector] string timesUpMessage = "You fail to hack in time...\nSomeone notified the police.\nFelony level increased by {0}0%!\nType '/felony' to check felony level.\nType '/saldo' to check money balance.";
    [HideInInspector] string losterMessage = "You fail to hack in time...\nBut fast connection provided by loster\nallows you to close hacking connection\nsoon enough to avoid raising an alarm!";
    [HideInInspector] string timePenaltyMessage = "Wrong password.\nHack time reduced by {0} sec.";
    [HideInInspector] string safeConnectionMessage = "You didn't close safe connection\nproperly when you decided to finish\nhacking. Police found your network\ntrace. Felony level " +
        "increased by\n{0}0%!";
    [HideInInspector] string leavingPasswordMessage = "\nRepeat 'menu' if you want to quit\nhacking - this action will cause you\npenalty.";
    [HideInInspector] string itemLabel = "\n{0} Name: {1} Level: {2}\nPrice: {3}$\n{4}";
    [HideInInspector] string itemLabelMax = "\n{0} Name: {1}, Level: \nMAX LEVEL\n{2}";
    [HideInInspector] string notEnoughFelonyLevel = "You are not under police eye.";
    [HideInInspector] string bribeSuccessfulMsg = "Bribe successful";
    [HideInInspector] string addressAddMessage = "IP Address successfully added into\nyour DateBase.";
    [HideInInspector] string additionalRewardMsg = "You found the '{0}'\nIP Address! You can now hack this\nlocation.";
    [HideInInspector] string levelLockedMessage = "Level locked. You need to find or buy\nIP address of this location.";
    [HideInInspector] string addressMaxLvL = "IP Address already in your DataBase.";
    [HideInInspector] string saldoMessage = "\nType '/saldo' to check money balance.";

    #endregion
    #endregion


    void Start()
    {
        complexWindowRef = complexWindowObject.GetComponent<ComplexWindow>();
        winScreenRef = winScreenObject.GetComponent<WinScreen>();  // delete
        complexAnimationRef = complexAnimationObject.GetComponent<ComplexAnimation>();  // delete
        slider = gameObject.GetComponentInChildren<Slider>();
        progressBar.SetActive(false);
        counterText.gameObject.SetActive(false);
        ShowMainMenu();
        money = 125000;  // DELETE
    }

    void Update()
    {
        CheckFelony();
        LevelTimeCounter();
        if (currentScreen == Screen.Password && timerOn)
        {
            trackTimerTime();
        }
    }

    // Display main menu
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        SetScreen(Screen.MainMenu);
        if (complexBuild)
        {
            Terminal.WriteLine(mainMenuScreenComplex);
        }
        else
        {
            Terminal.WriteLine(mainMenuScreen);
        }
        ShowLocations();
    }

    void ShowLocations()
    {
        string locationsString = "";
        for (int i = 1; i <= locations.Length; i++)
        {
            if (LevelLocked(i))
            {
                locationsString += $"\nPress {i} for {locations[i - 1]} LOCKED";
            }
            else
            {
                locationsString += $"\nPress {i} for {locations[i-1]}";
            }
        }
        Terminal.WriteLine(locationsString);
    }

    void SetScreen(Screen screen)
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
            SetScreen(Screen.Back);
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
        if (input == "menu" && !additionalReward)
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
            Terminal.WriteLine(string.Format("Money: {0:n0}$", money));
        }
        else if (input == "/felony")
        {
            ShowFelonyLevel();
        }
        else if (input == "/done")  // delete
        {
            winScreenRef.gameFinished = true;
        }
        else if (input == "/build")  // delete
        {
            complexAnimationRef.buildingActive = true;
        }
        else if (input == "/items")  // delete
        {
            foreach (KeyValuePair<string, string[]> item in gameItems)
            {
                if (item.Key == "ipdatabase" || item.Key == "bribe")
                {
                    continue;
                }
                else
                {
                    item.Value[itemLevel] = "3";
                }
            }
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
                case Screen.WinAdditional:
                    GoForward(input);
                    break;
                case Screen.Inventory:
                    GoBack(input);
                    break;
                case Screen.Shop:
                    RunShopMenu(input);
                    break;
                //case Screen.BuyMenu:
                //    ChooseBuyItem(input);
                //    break;
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
                case Screen.ChooseShop:
                    RunChooseShop(input);
                    break;
                case Screen.Shop1:
                    ChooseBuyItem(input);
                    break;
                case Screen.Shop2:
                    ChooseBuyItem(input);
                    break;
                case Screen.Shop3:
                    ChooseBuyItem(input);
                    break;
                case Screen.Shop4:
                    ChooseBuyItem(input);
                    break;
                case Screen.BuildMenu:
                    RunBuildMenu(input);
                    break;
                case Screen.BuildConfirm:
                    BuildConfirm(input);
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

    void IncreaseMenuCounter()
    {
        menuCounter += 1;
    }

    // Method handling player main menu choices
    void RunMainMenu(string input)
    {
        var isValidLevel = (input == "1" || input == "2" || input == "3" || input == "4" || input == "5");
        if (isValidLevel && LevelLocked(int.Parse(input)))
        {
            Terminal.WriteLine(levelLockedMessage);
        }
        else if (isValidLevel)
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
        else if (complexBuild && input == "c")
        {
            complexWindowRef.ShowComplex();
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
        else
        {
            Terminal.WriteLine(validOptionHint);
        }
    }

    bool LevelLocked(int levelNumber)
    {
        bool levelLocked = true;
        switch (levelNumber)
        {
            case 1:
                levelLocked = level1Locked;
                break;
            case 2:
                levelLocked = level2Locked;
                break;
            case 3:
                levelLocked = level3Locked;
                break;
            case 4:
                levelLocked = level4Locked;
                break;
            case 5:
                levelLocked = level5Locked;
                break;
            default:
                break;
        }
        return levelLocked;
    }

    void GoBack(string input)
    {
        var inputBackIsValid = (input == "b" || input == "B" || input == "back" || input == "Back" || input == "BACK");
        if (inputBackIsValid)
        {
            switch (currentScreen)
            {
                #region currentScreen cases
                case Screen.Win:
                    AskForPassword();
                    break;
                //case Screen.BuyMenu:
                //    ShowShop();
                //    break;
                case Screen.Sold:
                    ShowShop();
                    break;
                case Screen.Inventory:
                    ShowMainMenu();
                    break;
                case Screen.TimesUp:
                    AskForPassword();
                    break;
                case Screen.ChooseShop:
                    ShowShop();
                    break;
                case Screen.Shop:
                    ShowMainMenu();
                    break;
                case Screen.Shop1:
                    ShowChooseShop();
                    break;
                case Screen.Shop2:
                    ShowChooseShop();
                    break;
                case Screen.Shop3:
                    ShowChooseShop();
                    break;
                case Screen.Shop4:
                    ShowChooseShop();
                    break;
                case Screen.BuildMenu:
                    ShowShop();
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

    void GoForward(string input)
    {
        var inputForwardIsValid = (input == "n" || input == "N" || input == "next" || input == "Next" || input == "NEXT" || input == "menu");
        if (inputForwardIsValid)
        {
            DisplayAdditionalReward();
        }
        else
        {
            Terminal.WriteLine(forwardHint);
        }
    }

    // Method setting random password
    void AskForPassword()
    {
        SetScreen(Screen.Password);
        if (string.IsNullOrEmpty(password))
        {
            SetRandomPassword();
        }
        if (string.IsNullOrEmpty(passwordHint))
        {
            SetPasswordHint();
        }
        if (decoderActive && string.IsNullOrEmpty(decoderHint))
        {
            SetDecoderHint();
        }
        if (enigmaActive && string.IsNullOrEmpty(enigmaHint))
        {
            SetEnigmaHint();
        }
        StartTimer();
        DisplayPasswordScreen();
    }

    void DisplayPasswordScreen()
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

    void SetLevelTime()
    {
        if (hackTimerActive)
        {
            levelTime = levelTimeValues[level - 1] + hackTimerTimeBonus[int.Parse(gameItems["hacktimer"][itemLevel]) - 1];
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
            if (losterActive && LosterAvoidChance())
            {
                DisplayLosterMessage();
            }
            else
            {
                DisplayTimesUp();
                TimesUp();
            }
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
        SetScreen(Screen.TimesUp);
        ClearPasswordAndHints();
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(timesUpMessage, level));
    }

    void TimesUp()
    {
         IncreaseFelony(level);
    }

    bool LosterAvoidChance()
    {
        float randomValue = Random.value;
        if (randomValue <= LosterAvoidChances[int.Parse(gameItems["loster"][itemLevel]) - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void DisplayLosterMessage()
    {
        SetScreen(Screen.TimesUp);
        Terminal.ClearScreen();
        Terminal.WriteLine(losterMessage);
    }

    void TimePenalty()
    {
        DisplayPasswordScreen();
        if (timeEncoderActive)
        {
            Terminal.WriteLine(string.Format(timePenaltyMessage, timePenaltyValues[level - 1] - timeEncoderReduceValues[int.Parse(gameItems["timeencoder"][itemLevel]) - 1]));
            Terminal.WriteLine($"Penalty reduced by {timeEncoderReduceValues[int.Parse(gameItems["timeencoder"][itemLevel]) - 1]} sec.");
        }
        else
        {
            Terminal.WriteLine(string.Format(timePenaltyMessage, timePenaltyValues[level - 1]));
            currentCounterTime -= timePenaltyValues[level - 1];
        }
    }

    void SetPasswordHint()
    {
        string hint = "*hint: {0}";
        passwordHint = string.Format(hint, password.Anagram());
    }

    void SetEnigmaHint()
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

    void SetDecoderHint()
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
            case 4:
                password = level4Passwords[Random.Range(0, level4Passwords.Length)];
                break;
            case 5:
                password = level5Passwords[Random.Range(0, level5Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number.");
                break;
        }
        if (password == previousPassword)
        {
            SetRandomPassword();
        }
        previousPassword = password;
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
        ManageLevelReward();
        if (additionalReward)
        {
            SetScreen(Screen.WinAdditional);
        }
        else
        {
            SetScreen(Screen.Win);
        }
    }

    void ManageLevelReward()
    {
        string selectedReward;
        int selectedRewardValue;
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                if (level2Locked)
                {
                    RandomLocationUnlock();
                }
                selectedReward = DrawReward(level1RewardsNames);  // picking random reward from level rewards
                selectedRewardValue = SetRewardValue(selectedReward);  // setting random value of reward based on reward name
                InventoryAddReward(selectedReward, selectedRewardValue);  // adding reward with value to inventory and increasing item count value
                DisplayReward(selectedReward, selectedRewardValue, level1Rewards);  // showing reward ASCII art, name, value
                break;
            case 2:
                if (level3Locked)
                {
                    RandomLocationUnlock();
                }
                selectedReward = DrawReward(level2RewardsNames);
                selectedRewardValue = SetRewardValue(selectedReward);
                InventoryAddReward(selectedReward, selectedRewardValue);
                DisplayReward(selectedReward, selectedRewardValue, level2Rewards);
                break;
            case 3:
                if (level4Locked)
                {
                    RandomLocationUnlock();
                }
                selectedReward = DrawReward(level3RewardsNames);
                selectedRewardValue = SetRewardValue(selectedReward);
                InventoryAddReward(selectedReward, selectedRewardValue);
                DisplayReward(selectedReward, selectedRewardValue, level3Rewards);
                break;
            case 4:
                if (level5Locked)
                {
                    RandomLocationUnlock();
                }
                selectedReward = DrawReward(level4RewardsNames);
                selectedRewardValue = SetRewardValue(selectedReward);
                InventoryAddReward(selectedReward, selectedRewardValue);
                DisplayReward(selectedReward, selectedRewardValue, level4Rewards);
                break;
            case 5:
                selectedReward = DrawReward(level5RewardsNames);
                selectedRewardValue = SetRewardValue(selectedReward);
                InventoryAddReward(selectedReward, selectedRewardValue);
                DisplayReward(selectedReward, selectedRewardValue, level5Rewards);
                break;
            default:
                Debug.LogError("Invalid level number for reward.");
                break;
        }
    }

    void RandomLocationUnlock()
    {
        float randomChance = Random.value;
        if (randomChance <= .01f) 
        {
            UnlockLevel(level);
            additionalReward = true;
        }
    }

    void UnlockLevel(int levelUnlock)
    {
        switch (levelUnlock)
        {
            case 1:
                level2Locked = false;
                break;
            case 2:
                level3Locked = false;
                break;
            case 3:
                level4Locked = false;
                break;
            case 4:
                level5Locked = false;
                break;
            default:
                break;
        }
    }

    void DisplayAdditionalReward()
    {
        SetScreen(Screen.Win);
        additionalReward = false;
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(additionalRewardMsg, locations[level]));
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
            case "handcuff":
                selectedRewardValue = SetItemValue(350, 550);
                break;
            case "gun":
                selectedRewardValue = SetItemValue(1500, 4500);
                break;
            case "weapon":
                selectedRewardValue = SetItemValue(2500, 7500);
                break;
            case "badge":
                selectedRewardValue = SetItemValue(5000, 10000);
                break;
            case "dna":
                selectedRewardValue = SetItemValue(7000, 15000);
                break;
            // Level 4 rewards
            case "broom":
                selectedRewardValue = SetItemValue(2500, 5000);
                break;
            case "book":
                selectedRewardValue = SetItemValue(3500, 7500);
                break;
            case "map":
                selectedRewardValue = SetItemValue(5500, 11000);
                break;
            case "key":
                selectedRewardValue = SetItemValue(11000, 20000);
                break;
            case "wand":
                selectedRewardValue = SetItemValue(15000, 25000);
                break;
            // Level 5 rewards
            case "hole":
                selectedRewardValue = SetItemValue(4000, 6000);
                break;
            case "star":
                selectedRewardValue = SetItemValue(6500, 14000);
                break;
            case "ticket":
                selectedRewardValue = SetItemValue(15000, 25000);
                break;
            case "rocket":
                selectedRewardValue = SetItemValue(20000, 35000);
                break;
            case "alien":
                selectedRewardValue = SetItemValue(35000, 50000);
                break;
            default:
                Debug.LogError("Select Reward switch Error.");
                break;
        }
        #endregion
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

    int SetRewardTier()
    {
        int tierIndex = 0;
        float dropChance = Random.value;
        if (dropChance <= .3f)
        {
            // tier 5 - index 0 == tier 5
            tierIndex = 0;
        }
        else if (dropChance > .3f && dropChance <= .55f)
        {
            // tier 4
            tierIndex = 1;
        }
        else if (dropChance > .55f && dropChance <= .75f)
        {
            // tier 3
            tierIndex = 2;
        }
        else if (dropChance > .75f && dropChance <= .90f)
        {
            // tier 2
            tierIndex = 3;
        }
        else if (dropChance > .90f)
        {
            // tier 1 - index 4 == tier 1
            tierIndex = 4;
        }
        else
        {
            Debug.LogError("RewardTier() drop chance Error.");
        }
        return tierIndex;
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
        SetScreen(Screen.Shop);
        Terminal.ClearScreen();
        Terminal.WriteLine(shopMenu);
    }

    void RunShopMenu(string input)
    {
        if (input == "1")
        {
            ShowChooseShop();
        }
        else if (input == "2")
        {
            CanSell();
        }
        else if (input == "3")
        {
            ShowBuildMenu();
        }
        else
        {
            GoBack(input);
        }
    }

    void ShowBuildMenu()
    {
        SetScreen(Screen.BuildMenu);
        Terminal.ClearScreen();
        if (!complexBuild)
        {
            DisplayBuildOptions();
        }
        else
        {
            DisplayBuildings();
        }
    }

    void DisplayBuildings()
    {
        string buildings = "What would you like to build?\n1 Own Hacking Complex:\nOWNED";
        Terminal.WriteLine(buildings);
    }

    void DisplayBuildOptions()
    {
        string chooseBuildingOption = "What would you like to build?\n1 Own Hacking Complex:\n  Price: {0:n0}$ Requriements:\n  Felony 0% current ";
        if (felonyLevel > 0)
        {
            chooseBuildingOption += $"{felonyLevel}0%";
        }
        else
        {
            chooseBuildingOption += $"{felonyLevel}% √";
        }

        foreach (KeyValuePair<string, string[]> item in gameItems)
        {
            if (item.Key == "ipdatabase" || item.Key == "bribe")
            {
                continue;
            }
            else
            {
                if (item.Value[itemLevel] == "3")
                {
                    chooseBuildingOption += $"\n  {item.Key} lvl.3 √";
                }
                else
                {
                    chooseBuildingOption += $"\n  {item.Key} lvl.3 (current lvl.{item.Value[itemLevel]})";
                }
            }
        }
        Terminal.WriteLine(string.Format(chooseBuildingOption, complexPrice, felonyLevel));
    }

    void RunBuildMenu(string input)
    {
        if (input == "1")
        {
            BuildingAvailable();
        }
        else
        {
            Terminal.WriteLine(validOption2Hint);
            GoBack(input);
        }
    }

    void BuildingAvailable()
    {
        if (felonyLevel > 0)
        {
            Terminal.WriteLine("Too high felony level.");
        }
        else if (money < complexPrice)
        {
            Terminal.WriteLine("Not enough money.");
        }
        else if (!EnoughItemLevel())
        {
            Terminal.WriteLine("To low items level.");
        }
        else if (complexBuild)
        {
            Terminal.WriteLine("You already own this building.");
        }
        else
        {
            ShowBuildConfirm();
        }
    }

    void ShowBuildConfirm()
    {
        string buildConfirmQuestion = "Would you like to build:\nOwn Hacking Complex for {0:n0}$?\n\nPress y/Yes or n/NO";
        SetScreen(Screen.BuildConfirm);
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(buildConfirmQuestion, complexPrice));
    }

    void BuildConfirm(string input)
    {
        var isValidYes = (input == "y" || input == "yes" || input == "Yes" || input == "YES");
        var isValidNo = (input == "n" || input == "no" || input == "No" || input == "NO");

        if (isValidYes)
        {
            Build();
        }
        else if (isValidNo)
        {
            ShowBuildMenu();
        }
        else
        {
            Terminal.WriteLine(validOption2Hint);
        }
    }

    void Build()
    {
        complexBuild = true;
        money -= complexPrice;
        complexAnimationRef.buildingActive = true;
        ShowBuildMenu();
    }

    bool EnoughItemLevel()
    {
        bool canBuild = false;
        foreach (KeyValuePair<string, string[]> item in gameItems)
        {
            if (item.Key == "bribe" || item.Key == "ipdatabase")
            {
                continue;
            }
            else if (item.Value[itemLevel] == "3")
            {
                canBuild = true;
            }
            else
            {
                canBuild = false;
            }
        }
        return canBuild;
    }

    void ShowChooseShop()
    {
        SetScreen(Screen.ChooseShop);
        Terminal.ClearScreen();
        DisplayAvailableShops();
    }

    void DisplayAvailableShops()
    {
        string chooseShopMenu = "Choose the shop you want to vist:";
        for (int i = 1; i < shopNames.Length + 1; i++)
        {
            chooseShopMenu += string.Format($"\n{i} {shopNames[i - 1]}");
        }
        Terminal.WriteLine(chooseShopMenu);
    }

    void RunChooseShop(string input)
    {
        var isValidChoice = (input == "1" || input == "2" || input == "3" || input == "4");
        if (isValidChoice)
        {
            switch (input)
            {
                case "1":
                    shopNumber = 1;
                    break;
                case "2":
                    shopNumber = 2;
                    break;
                case "3":
                    shopNumber = 3;
                    break;
                case "4":
                    shopNumber = 4;
                    break;
                default:
                    Debug.LogError("RunChooseShop Switch on input Error.");
                    break;
            }
            SetCurrentShopScreen(shopNumber);
            ShowBuyMenu();
        }
        else
        {
            Terminal.WriteLine(validOption2Hint);
            GoBack(input);
        }
    }

    void SetCurrentShopScreen(int shopNumber)
    {
        switch (shopNumber)
        {
            case 1:
                SetScreen(Screen.Shop1);
                break;
            case 2:
                SetScreen(Screen.Shop2);
                break;
            case 3:
                SetScreen(Screen.Shop3);
                break;
            case 4:
                SetScreen(Screen.Shop4);
                break;
            default:
                Debug.LogError("SetCurrentShopScreen() Switch on shopNumber Error.");
                break;
        }
    }

    /*
     * ShowBuyMenu displays items to buy depending on shop number e.x.:
     * Shop1 - shop number: 1 - shopItemsDivision[shopNumber] is equal to 1, 2, 3, gameItems with indexes 1-3(inclusive) will be showed in shop 1
     * Shop2 - shop number: 2 - shopItemsDivision[shopNumber] is equal to 4, 5, 6, gameItems with indexes 4-6(inclusive) will be showed in shop 2
     */
    void ShowBuyMenu()
    {
        SetCurrentShopScreen(shopNumber);
        Terminal.ClearScreen();
        string buyMenu = "What would you like to buy?";
        Dictionary<int, int[]> shopItemsDivision = new Dictionary<int, int[]>
        {
            { 1, new int[] { 1, 2, 3} },
            { 2, new int[] { 4, 5, 6} },
            { 3, new int[] { 7} },
            { 4, new int[] { 8} }
        };

        var counter = 1;
        var ordinalNumber = 1;
        foreach (KeyValuePair<string, string[]> item in gameItems)
        {
            if (counter == 7 && currentScreen == Screen.Shop3)
            {
                ShowBribeOptions();
                break;
            }
            if (counter == 8 && currentScreen == Screen.Shop4)
            {
                ShowIPAddresses();
                break;
            }
            if (shopItemsDivision[shopNumber].Contains(counter))
            {
                if (int.Parse(item.Value[itemLevel]) == 3)
                {
                    buyMenu += string.Format(itemLabelMax, ordinalNumber, item.Value[itemName], item.Value[itemDescription]);
                }
                else
                {
                    buyMenu += string.Format(itemLabel, ordinalNumber, item.Value[itemName], item.Value[itemShopLevel], item.Value[itemPrice], item.Value[itemDescription]);
                }
                ordinalNumber++;
            }
            counter++;
        }

        if (currentScreen != Screen.Shop3 && currentScreen != Screen.Shop4)
        {
        Terminal.WriteLine(buyMenu);
        }
    }

    void ShowIPAddresses()
    {
        Terminal.ClearScreen();

        string IPaddresses = "Which IP address would you like to buy and add to your DataBase: ";
        for (int i = 1; i < locations.Length; i++)
        {
            if (LevelLocked(i + 1))
            {
                IPaddresses += string.Format("\n{0} {1} IP {2:n0}$", i, locations[i], IPcost[i-1]);
            }
            else
            {
                IPaddresses += $"\n{i} {locations[i]} IP - in database";
            }
        }
        Terminal.WriteLine(IPaddresses);
    }

    void ShowBribeOptions()
    {
        Terminal.ClearScreen();

        string bribeOptions = "Someone can remove felony from your\naccount:";
        for (int i = 0; i < bribeNames.Length; i++)
        {
            bribeOptions += string.Format("\n{0} {1} can remove {2}0% felony\nfor {3:n0}$", i+1, bribeNames[i], bribeReduceValue[i], bribeCost[i]);
        }
        Terminal.WriteLine(bribeOptions);
    }

    void ChooseBuyItem(string input)
    {
        var isValidChoice = (input == "1" || input == "2" || input == "3" || input == "4");
        if (isValidChoice)
        {
            switch (currentScreen)
            {
                case Screen.Shop1:
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
                    break;
                case Screen.Shop2:
                    if (input == "1")
                    {
                        if (auctioneerMaxLevel)
                        {
                            Terminal.WriteLine(itemMaxLevelHint);
                        }
                        else if (CanAffordItem("auctioneer"))
                        {
                            ShowBuyConfirm("auctioneer");
                        }
                        else
                        {
                            Terminal.WriteLine(cantAfford);
                        }
                    }
                    else if (input == "2")
                    {
                        if (losterMaxLevel)
                        {
                            Terminal.WriteLine(itemMaxLevelHint);
                        }
                        else if (CanAffordItem("loster"))
                        {
                            ShowBuyConfirm("loster");
                        }
                        else
                        {
                            Terminal.WriteLine(cantAfford);
                        }
                    }
                    else if (input == "3")
                    {
                        if (timeEncoderMaxLevel)
                        {
                            Terminal.WriteLine(itemMaxLevelHint);
                        }
                        else if (CanAffordItem("timeencoder"))
                        {
                            ShowBuyConfirm("timeencoder");
                        }
                        else
                        {
                            Terminal.WriteLine(cantAfford);
                        }
                    }
                    break;
                case Screen.Shop3:
                    if (input == "1")
                    {
                        RunBribeMachine(input);
                    }
                    else if (input == "2")
                    {
                        RunBribeMachine(input);
                    }
                    else if (input == "3")
                    {
                        RunBribeMachine(input);
                    }
                    else if (input == "4")
                    {
                        RunBribeMachine(input);
                    }
                    break;
                case Screen.Shop4:
                    if (input == "1" && CanAffordIP(input) && LevelLocked(int.Parse(input) + 1))
                    {
                        BuyIP(input);
                        DisplayBuyIPMessage();
                    }
                    else if (input == "2" && CanAffordIP(input) && LevelLocked(int.Parse(input) + 1))
                    {
                        BuyIP(input);
                        DisplayBuyIPMessage();
                    }
                    else if (input == "3" && CanAffordIP(input) && LevelLocked(int.Parse(input) + 1))
                    {
                        BuyIP(input);
                        DisplayBuyIPMessage();
                    }
                    else if (input == "4" && CanAffordIP(input) && LevelLocked(int.Parse(input) + 1))
                    {
                        BuyIP(input);
                        DisplayBuyIPMessage();
                    }
                    else if (!LevelLocked(int.Parse(input) + 1))
                    {
                        Terminal.WriteLine(addressMaxLvL);
                    }
                    else
                    {
                        Terminal.WriteLine(cantAfford);
                    }
                    break;
                default:
                    Debug.LogError("ChooseBuyItem() Switch on currentScreen Error.");
                    break;
            }
        }
        else
        {
            Terminal.WriteLine(validOption2Hint);
            GoBack(input);
        }
    }

    void BuyIP(string buyOption)
    {
        UnlockLevel(int.Parse(buyOption));
        money -= IPcost[int.Parse(buyOption) - 1];
    }

    void DisplayBuyIPMessage()
    {
        Terminal.ClearScreen();
        ShowIPAddresses();
        Terminal.WriteLine(addressAddMessage);
    }

    void RunBribeMachine(string input)
    {
        if (!VerifyFelonyLevel())
        {
            DisplayNotEnoughFelonyMsg();
        }
        else if (!CanAffordBribe(int.Parse(input)))
        {
            DisplayNotEnoughMoneyMsg();
        }
        else
        {
            Bribe(int.Parse(input));
            DisplayBribeSuccessfulMsg();
        }
    }

    void Bribe(int bribeOption)
    {
        int bribeIndex = bribeOption - 1;
        money -= bribeCost[bribeIndex];
        if (felonyLevel < bribeReduceValue[bribeIndex])
        {
            felonyLevel = 0;
        }
        else
        {
            felonyLevel -= bribeReduceValue[bribeIndex];
        }
    }

    void DisplayBribeSuccessfulMsg()
    {
        Terminal.ClearScreen();
        ShowBribeOptions();
        Terminal.WriteLine(bribeSuccessfulMsg);
    }

    void DisplayNotEnoughFelonyMsg()
    {
        ShowBribeOptions();
        Terminal.WriteLine(notEnoughFelonyLevel);
    }

    void DisplayNotEnoughMoneyMsg()
    {
        ShowBribeOptions();
        Terminal.WriteLine(notEnoughMoneyMsg);
    }

    bool VerifyFelonyLevel()
    {
        bool canResetFelony;
        if (felonyLevel > 0)
        {
            canResetFelony = true;
        }
        else
        {
            canResetFelony = false;
        }

        return canResetFelony;
    }
    
    bool CanAffordIP(string buyOption)
    {
        bool canAfford = false;
        if (money >= IPcost[int.Parse(buyOption) - 1])
        {
            canAfford = true;
        }
        return canAfford;
    }

    bool CanAffordBribe(int bribeValueIndex)
    {
        int properIndex = bribeValueIndex - 1;
        bool canAfford = false;
        if (money >= bribeCost[properIndex])
        {
            canAfford = true;
        }
        else
        {
            canAfford = false;
        }

        return canAfford;
    }

    bool CanAffordItem(string item)
    {

        bool canAfford = false;
        if (money >= int.Parse(gameItems[item][itemPrice]))
        {
            canAfford = true;
        }
        return canAfford;
    }

    void ShowBuyConfirm(string item)
    {
        itemToBuy = item;
        SetScreen(Screen.ItemBuyConfirm);
        string confirmQuestion = "Would you like to buy:\n{0} lvl. {1} for {2}$?\n\nPress y/Yes or n/NO";
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(confirmQuestion, gameItems[item][itemName], gameItems[item][itemShopLevel], gameItems[item][itemPrice]));
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
                money -= int.Parse(gameItems[item][itemPrice]);
                enigmaActive = true;
                break;
            case "decoder":
                money -= int.Parse(gameItems[item][itemPrice]);
                decoderActive = true;
                break;
            case "hacktimer":
                money -= int.Parse(gameItems[item][itemPrice]);
                hackTimerActive = true;
                break;
            case "auctioneer":
                money -= int.Parse(gameItems[item][itemPrice]);
                auctioneerActive = true;
                break;
            case "loster":
                money -= int.Parse(gameItems[item][itemPrice]);
                losterActive = true;
                break;
            case "timeencoder":
                money -= int.Parse(gameItems[item][itemPrice]);
                timeEncoderActive = true;
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
                    newLevelValue = int.Parse(gameItems[item][itemLevel]) + 1;
                    gameItems[item][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 3)
                    {
                        enigmaMaxLevel = true;
                        break;
                    }
                    gameItems[item][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 1)
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "decoder":
                if (!decoderMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems[item][itemLevel]) + 1;
                    gameItems[item][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 3)
                    {
                        decoderMaxLevel = true;
                        break;
                    }
                    gameItems[item][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 1)
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "hacktimer":
                if (!hackTimerMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems[item][itemLevel]) + 1;
                    gameItems[item][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 3)
                    {
                        hackTimerMaxLevel = true;
                        break;
                    }
                    gameItems[item][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 1)
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "auctioneer":
                if (!auctioneerMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems[item][itemLevel]) + 1;
                    gameItems[item][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 3)
                    {
                        auctioneerMaxLevel = true;
                        break;
                    }
                    gameItems[item][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 1)
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "loster":
                if (!losterMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems[item][itemLevel]) + 1;
                    gameItems[item][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 3)
                    {
                        losterMaxLevel = true;
                        break;
                    }
                    gameItems[item][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 1)
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl3UpgradeCost];
                    }
                }
                break;
            case "timeencoder":
                if (!timeEncoderMaxLevel)
                {
                    newLevelValue = int.Parse(gameItems[item][itemLevel]) + 1;
                    gameItems[item][itemLevel] = newLevelValue.ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 3)
                    {
                        timeEncoderMaxLevel = true;
                        break;
                    }
                    gameItems[item][itemShopLevel] = (newLevelValue + 1).ToString();
                    if (int.Parse(gameItems[item][itemLevel]) == 1)
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl2UpgradeCost];
                    }
                    else
                    {
                        gameItems[item][itemPrice] = gameItems[item][itemLvl3UpgradeCost];
                    }
                }
                break;
            default:
                break;
        }
    }

    void CanSell()
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
        SetScreen(Screen.Sell);
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
                SetScreen(Screen.Sold);
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
        SetScreen(Screen.ShopCrime);
        Terminal.ClearScreen();
        Terminal.WriteLine(string.Format(shopCrimeMessage + saldoMessage, crimeLevel));
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
        string sellMessage = $"You sold {itemsNumber} item{plural} for {string.Format("{0:n0}", sellValue)}$.";

        AddMoney(sellValue);

        if (itemsNumber > 1)
        {
            plural = "s";
        }
        if (auctioneerActive)
        {
            sellMessage += string.Format("\n(+{0}% auctioneer bonus)", auctioneerPercentageValues[int.Parse(gameItems["auctioneer"][itemLevel]) - 1] * 100);
        }
        Terminal.ClearScreen();
        Terminal.WriteLine(sellMessage + saldoMessage);
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
        if (auctioneerActive)
        {
            sellValue += (int)(sellValue * auctioneerPercentageValues[int.Parse(gameItems["auctioneer"][itemLevel]) - 1]);
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
        SetScreen(Screen.Inventory);
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
        SetScreen(Screen.Stop);
        Terminal.ClearScreen();
        money = -5000;
        enigmaActive = false;
        enigmaMaxLevel = false;
        decoderActive = false;
        decoderMaxLevel = false;
        hackTimerActive = false;
        hackTimerMaxLevel = false;
        auctioneerActive = false;
        auctioneerMaxLevel = false;
        losterActive = false;
        losterMaxLevel = false;
        timeEncoderActive = false;
        timeEncoderMaxLevel = false;
        foreach (KeyValuePair<string, string[]> item in gameItems)
        {
            if (item.Key != "bribe" && item.Key != "ipdatabase")
            {
            gameItems[item.Key][itemPrice] = gameItems[item.Key][itemStartingPrice];
            gameItems[item.Key][itemLevel] = "0";  // TEST on 
            gameItems[item.Key][itemShopLevel] = "1";  // TEST on
            }
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
