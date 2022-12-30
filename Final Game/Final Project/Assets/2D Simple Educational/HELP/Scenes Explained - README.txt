---------------------
EXPLANATION OF SCENES
---------------------

You may be confused of the build scenes, but they are fairly easy. Especially to use
the level selection menu and manger.

You can find the scene numbers in FILE > BUILD SETTINGS AND SCENE IN BUILD. There near
your scene you will have the numbers (0, 1, 2, etc.) of each scene.

The first scene should ALWAYS be the MENU which will be scene 0. Then you will have the
'Level Selection Menu' scene which will be scene 1.

That means it should be like this in your BUILD settings:

Main Menu = Scene 0
Level Selection Menu = Scene 1
Level 1 = Scene 2
Level 2 = Scene 3

and so on..

---------------------
LEVEL SELECTION MENU
---------------------

In the 'Level Selection Menu' scene you have the buttons which are level 1 button, level 2
buttons and so on. These are the levels that will load up each scene seperatly. 

The script to load up the levels can be found in SCRIPTS > Load Scenes Scripts and there are
about 6 scripts named "LoadScene01, LoadScene02 etc." these needs to be placed in the buttons
to load up each scene. Make sure the button you are using have a BOX COLLIDER 3D and NOT a BOX COLLIDER 2D.

Each of the script (LoadScene01 etc) last number (01, 02, 03 etc.) means which scene will be loaded so for
example to load level 1 which is scene 2 then you need to put the 'LoadScene02' to load the first level.

The 'Level Selection Menu' you will be loading a new scene when you click on the buttons, so if you have Level 1 
which is Scene 2, then you need to place the 'LoadScene02.cs' script inside the button.

---------------------
HOW TO LOCK LEVELS
---------------------

Again in the 'Level Selection Menu' where you have all the buttons be sure that the LEVEL 1 will not have the
Locked Button blocking it. The others (Level 2 and so on) need to have a 'Locked Button'. 

For example: Level 2 Button needs to have 'Level 2 Locked Button' as a child which will block the button. BE SURE
THEY BOTH HAVE A BOX COLLIDER 3D ATTACHED.

In the Level Menu Unlock Manager (Unlock Levels) there you will have level tags. You need to tag them with level1lock, level2lock and so on.

These are the tags to unlock levels from each scene, so for example if you go to your first level (Level01) 
there you will have a 'Level Manager (Unlock Next Level)' prefab and you need to use the same tag you used 
to unlock the level. If you are on Level 1 that means you need to unlock level 2 so in the 
'Level Manager (Unlock Next Level)' where it says Level Tag you will put level2lock.'

In the Level Unlock Manager (Unlock Levels) there is also Locked Buttons. You need to put the Locked Buttons of each level (level 2 - and so on)
which is the child of the buttons. You can leave the Level Unlocked as it is.

-----------------------------
HOW TO UNLOCK LEVELS - SIMPLE
-----------------------------

Go in your scene and we assume it's your first level 1 scene. Go and drag and drop the Level Manager (Unlock Next Level) from your prefabs. 
In the Level Tag type in level2lock and this is needed to unlock level 2 which is the next level. You will need to do this for each scene
to unlock all of them. (So for level 2 - you put level3lock in the prefab, for level 3 you put level4lock in the prefab and so on.

EXAMPLE: 

Level 1 - Put the Level Tag in 'Level Manager (Unlock Next Level)' to level1lock or the same one you have in the 'Level Selection Menu' scene
in the level tags in the Level Selection Menu. Each tag that have the same ones will unlock that level button so it can be clicked.


Please see the documentation for more details and more helpful way (with screenshots) to add level unlock menu easy into your game.

