# Terminal Hacker
This is my second project created while processing through "Complete C# Unity Developer 3D: Learn to Code Making Games" course. I decided to expand  course project concept with my ideas. To achieve that I used acquired skills, also I had to find solution for few other cases. I wanted to provide players possibility to earn something during gameplay. 
Did I succeed? 

## Game Description:
The player takes the role of hacker, starting from zero, with no money. After successful hacking he's getting awarded with valuable items which could be sold on Dark Web. With bigger money in background, new and more attractive places to hack are being unlocked. Hacker need to pay attention to his felony level, no one wants to spend his life in prison but no worries, Dark Web market provide a lot of capabilities like attractive deals and advanced technologies.

## Project Description:
The main goal of this project is to consolidate knowledge about basic foundation of c# skills, variables, statements, etc. 

## Game Mechanics:
#### Main Menu:
Player starts in the main menu, this time created by using *canvas*. Controlling menu section by unity events. 

#### Terminal Screen (main game screen):
Player is moved to terminal screen, there are few options at terminal main menu screen:
-Dark Web store 
-Inventory 
-Location which could be hacked 
Moving through sections by typing option number and going back using back or main input. 

#### Dark Web store
Store provides capability to buy unique items which can help player guess the password by displaying some hints. Items which can be bought:
- enigma
Shows password first letters:
`password = something`
Item level 1 `s********`
Item level 2 `so*******`
Item level 3 `som******`
- decoder
Shows password word hints:
`password = tree`
Item level 1 `wood`
Item level 2 `wood leavs`
Item level 3 `wood leavs forest`

- hacking timer
Increases level hacking time:
Item level 1 by `5 seconds`
Item level 2 by `10 seconds`
Item level 3 by  `15 seconds`

- auctioneer
Increases items sell value:
Item level 1 by `10%`
Item level 2 by `20%`
Item level 3 by `30%`

- loster
Provides chance to avoid increasing felony level after not guessing password or after shop crime event:
Item level 1 by `20%`
Item level 2 by `25%`
Item level 3 by `33%`

- time encoder
Reduces time penalty after not guessing password:
Item level 1 by `1 second`
Item level 2 by `2 seconds`
Item level 3 by `3 seconds`

#### Inventory 
Simple screen showing items count, items dell value and money balance. 

#### Hacking locations 
Choosing unlocked location moves Player to guess password screen. Player has specified time for guessing password. Password is a word strictly linked with choosen location and Word is showed as anagram. Each wrong password input results with time penalty (-x time in seconds). 
If Player will not guess the password or try to finish hacking before end of time using 'menu' input he will be punished with increasing felony level by x% (depends on hack location, higher more attractive locations results with higher felony level punish). 
If Player succed in guessing the password he is moved to reward screen. 
Each level has its own reward pool divided into tiers. 
Reward chance depends on reward tier, higher tier reward has lower drop chance. 
Reward tier specifies money value. 

#### Win/Lose
Win Condition is building Own Hacking Complex, which requires:
-Felony level 0%
-XXX XXX $
-Unlocked and development all items
-Unlocked all locations 
If requirements are met Player can build Own Hacking Complex, Win screen animation is being shown. 
Player can also lose the game if he does not pay attention to felony level. If felony level reaches 100% player gets busted.

## Game Systems
#### Rewards Tier
Each location has 5 unique rewards which are divided into tiers, every tier has its own drop chance:
Tier 1 `30%` drop chance.
Tier 2 `25%` drop chance.
Tier 3 `20%` drop chance.
Tier 4 `15%` drop chance.
Tier 5 `10%` drop chance.

#### Shop Crime
Every item sell transaction in Dark Web store may result in Shop Crime event which involves increasing felony level by `10%` and loosing `90%` of sell value.

#### Felony
Felony level increases when player fails to guess the password or when Shop Crime event occurs. When felony level reaches 100% player gets busted.
Getting busted leads to lose all money, items and fine - `5000`$.
