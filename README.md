# The Blossom Game.

## The Objective

The Balls is the original game name (and the name of the Unity Project).
As the project progressed the name was changed to Blossom.
The objective of the game is for the player = Lotus flower, to catch/tap as many Bees as possible.
One Bee tap equals one point.
The player has to be careful as black bees as Bee Bombs and tapping one equals to exploding and loosing.
The game consists of 3 scenes: Menu, Game and Rules.

## Game Navigation

"Welcome to the Blossom Game" is the welcome screen, along with 3 buttons:
     1. Game button - navigates to the Game scene;
     2. Rules - navigates to the Rules scene;
     3. Quit - to leave the game (not active in the current version of the game).
After clicking on the game button, the player lands in the game scene.
The Game scene has the game board, timer, score display, and 3 buttons:
     1. Play button - after clicking it, the timer starts and the score count is becoming active.
     2. Rules - navigates to the Rules scene;
     3. Go Back -  - navigates to the Menu scene.
The game board has walls with colliders, so the player as well as the spawning randomly Bees and Bee Bombs stay within the play area.
The Rules scene has two active buttons:
     1. Main Menu - navigates to the Menu scene;
     2. Go To Game - navigates to the Game scene.

## Mechanics
 The player uses the keyboard arrows to move on the game board. "Up" and "down" keys to move along the Y axis,
 and "left" and "right" arrow keys to move along the X axis.

 ## Build environment
 The game was built for the Android OS in Unity 2020.3.32f1 game engine.

 ## Future fixes and development

 ### Saving the highest score achieved.  
 This feature was not developed in this version.

 ### Sound effects.
 There is no sound effect in this version.

 ### Visual effects.
 There is an explosion sprite which is not attached to the Game Objects and not executed in this version.
 The Bee Bomb object will explode when tapped by the Player. The Player object will be destroyed as well and the game is over then.



