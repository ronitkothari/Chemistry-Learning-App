--------------------------
HOW TO CREATE A GAME EASY!
--------------------------

This is a quick-setup on how to start and which prefabs you need in your scene to create your own
drag and drop game. Please see the documenation for a more detailed approach.

You can create a very simple drag-and-drop game where you have to place the shapes with the correct
ones in order for you to win the game and advance levels. The setup is really easy and we will show
you how easy it is.


1. Create a new scene and delete the Main Camera.


2. Go on your Prefabs > Settings folder and there you will have all the settings to setup your game.
Drag and drop these prefabs into your scene;

- Background Music - (To play music in your background scene)
- End Game Sound Prefab (Disabled at start) - (This is to play the end game sound when the game ends)
- Game Manager (Game Win Settings) - (This is the prefab to win the game, display GUIs and everything)
- Main Camera - (The main camera for the game with features ready such as fade out etc.)
- Particle System - (Totally optional, this is just a particle effect to make your game look better)
- Tutorial Text - (Totally optional, this is to display a text that will fade out in 5 seconds)


3. Once you put all the main important prefabs in your scene, then you can start to setting it up. 

Click on the Game Manager (Game Win Settings) and there you have the main game settings fields, such as Game
Score which you can customize, Shapes Left GUI, End Game Screen and so on. Go on the End Game Sound Prefab
Field in your Game Manager and drag and drop the 'End Game Sound Prefab (Disabled At Start) In your scene to 
the End Game Sound Prefab in the Game Manager. This is to play the sound when the game ends which can be changed
from the prefab.

4. You are now ready to place the shapes. These are split into two folders one for the shape to be dragged and the win zone.

Go in Prefabs folder and there you have 2 important shapes folders.
These are the Animal Shapes (Drag Prefabs) which are the ones that can be dragged and the Animal Shapes (Win Prefabs)
and these are the ones that needs to be dragged onto. Go on your first folder and for example drag and drop;

- Bear Shape (Drag Zone)

Now you need to drag the win zone of the Bear Shape. Go ahead in your second folder and for example drag and drop;

- Bear Shape (Win Zone)

The win zone are always in BLACK and needs to be in the scene, this is needed for each shape you place in the scene so
if you put any other Drag Zone shape then you will always need to put the same Drag Zone shape of it.

Once that is done, you need to set the win zone to your drag zone. Click on your 'Bear Shape (Drag Zone)' and there you will
see a Win Zone field. Drag and drop the 'Bear Shape (Win Zone)' into it from your scene. YOU WILL ALWAYS NEED TO DO THIS 
FOR EACH SHAPE YOU HAVE IN YOUR SCENE.

5. You are basically done, if you done it right you can place more shapes in the scene and the game automatically collects how many
shape there is in the game and when all the shapes are in the right places, the game is won and the GUIs are displayed. 


----------------------------
QUICK OVERVIEW OF EVERYTHING
----------------------------

1. Create a new scene and delete the main camera.

2. Place these prefabs into your scene;


- Background Music
- End Game Sound Prefab (Disabled at start) 
- Game Manager (Game Win Settings) 
- Main Camera 
- Particle System
- Tutorial Text

3. Click on the Game Manager (Game Win Settings) and put the End Game Sound Prefab (Disabled At Start) in the field of 'End Game SOund Prefab'.

4. Place a drag zone and a win zone shape. Be sure to click on the drag zone in your scene and put the win zone in your scene to the drag zone's field
where it says 'Win Zone Shape'. This is needed for each shape you have in your scene.

5. You are basically done.


----------------------------
HOW TO CREATE LEVELS UNLOCK
----------------------------

Each scene you have can be unlocked if you complete it and this is to create the 'level selection menu' but it's a little more complex. You will firstly 
need to have the scenes in your build settings and the first one or two needs to be the 'Menu' and 'Level Selection Menu' and after that you will have the 
levels such as level01, level02 etc. Each scene of levels that you have needs to have the Level Manager (Unlock Next Level) into the scene with the same
tag that you will have for the Level Selection Menu.

Go in your Prefabs > Settings and there you will see a 'Level Manager (Unlock Next Level)' prefab. This is needed to unlock a level with a tag, so for example
the default tag is level2lock which means it will unlock level02.

The first level will always be unlocked, so in your first scene (level01 for example) you need to put the prefab and to unlock level02 you need to use the 'level2lock' tag.
In the second level (level02 for example) you need to put the prefab AGAIN and to unlock level03 you need to use the 'level3lock' tag and so on. This goes on how many levels
you like to unlock. That means you will need to PUT THE LEVEL MANAGER (UNLOCK NEXT LEVEL) IN EACH SCENE.

Go in your level selection menu scene and there you will have the levels.

In the 'Level Selection Menu' scene you have the buttons which are level 1 button, level 2
buttons and so on. These are the levels that will load up each scene seperatly. 

The script to load up the levels can be found in SCRIPTS > Load Scenes Scripts and there are
about 6 scripts named "LoadScene01, LoadScene02 etc." these needs to be placed in the buttons
to load up each scene. Make sure the button you are using have a BOX COLLIDER 3D and NOT a BOX COLLIDER 2D.

Each of the script (LoadScene01 etc) last number (01, 02, 03 etc.) means which scene will be loaded. Check the Build
settings and see which scene is your levels. (Menu should be scene 0 in the build settings and level selection should be scene 1)

EXAMPLE: to load level 1 which is scene 2 then you need to put the 'LoadScene02' to load the first level.

The 'Level Selection Menu' you will be loading a new scene when you click on the buttons, so if you have Level 1 
which is Scene 2, then you need to place the 'LoadScene02.cs' script inside the button.

Once that is done, all we need to do is place a BOX COLLIDER 3D to block the level load script, and only unlock when the player completed the level.
The first level will always be unlocked, but the others (from level 2 and so on) need to have a 'Locked Button' as a child with a 3D BOX COLLIDER. 

In the Level Menu Unlock Manager (Unlock Levels) there you will have level tags. You need to tag them with level1lock, level2lock and so on, the same as
they are in your scene as you did before.

These are the tags to unlock levels from each scene, so for example if you go to your first level (Level01) 
there you will have a 'Level Manager (Unlock Next Level)' prefab and you need to use the same tag you used 
to unlock the level (which is level02lock) and this will unlock level 2. If you are on Level 1 that means you need to unlock level 2 so in the 
'Level Manager (Unlock Next Level)' where it says Level Tag you will put level2lock.'

You will also need to place the Locked Buttons for each one. You need to put the Locked Buttons of each level (level 2 - and so on)
which is the child of the buttons in the Level Menu Manager (Unlock Next Levels)'s field of Locked Buttons.


Please see the documentation for more details and more helpful way (with screenshots) to add level unlock menu easy into your game.