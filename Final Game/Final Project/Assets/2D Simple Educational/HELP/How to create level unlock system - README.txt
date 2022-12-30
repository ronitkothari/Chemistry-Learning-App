----------------------------------
HOW TO CREATE LEVELS UNLOCK SYSTEM
----------------------------------

Firstly you need to understand the build settings.

You can find the scene numbers in FILE > BUILD SETTINGS AND SCENE IN BUILD. There near
your scene you will have the numbers (0, 1, 2, etc.) of each scene.

The first scene should ALWAYS be the MENU which will be scene 0 and the second scene will be the
level selection menu scene which will be scene 1. Then the levels should follow up right after that
with level 1 to be scene 2 and level 2 to be scene 3 and so on.

That means it should be like this in your BUILD settings:

Main Menu = Scene 0
Level Selection Menu = Scene 1
Level 1 = Scene 2
Level 2 = Scene 3

Each scene you have can be unlocked if you complete it and this is to create the 'level selection menu'. You will firstly  need to have the scenes 
in your build settings just like in the example. Go in your first level and be sure you have the 'Level Manager (Unlock Next Level)' in your scene. 
The tag needs to be the SAME TAG you have in your Level Selection Menu scene in the Level Tags field. The level tags in the Level Selection Menu 
should be as follows:

Level Tags In Level Selection Menu Scene:

Level Tags >
Element 0 level1lock
Element 1 level2lock
Element 2 level3lock
Element 3 level4lock
Element 4 level5lock
and so one to how many levels you want.

Now, in your FIRST level scene you will need to use the same tag to unlock level 2. (level1lock won't be used, since level 1 will always be unlocked so we start with level2lock)
so as we said before, in your first level (level 1) you will have the Level Manager (Unlock Next Level) and the tag should be level2lock. This means;

When level 1 is complete > unlock level 2 with the tag 'level2lock'.

You will need to do this for all levels so for example to then unlock level 3 in level 2, you will need to have the Level Manager (Unlock Next Level) in the scene and the tag should be
'level3lock' to unlock level 3. For level 3, the tag needs to be 'level4lock' and so on. 

The 'Level Manager (Unlock Next Level)' prefab needs to be in all the scenes. This is needed to unlock a level with a tag, so for example
the default tag is level2lock which means it will unlock level02.

Now go in the Level Selection Menu Scene agian - we see that the first level will always be unlocked os it will not have the locked button enabled. 

In this scene you will have the buttons you can click and it will load the levels. The levels can be loaded by using the 'LoadScene Scripts' which will
load a scene individually. This means that you need to get the levels in the BUILD SETTINGS and see which scenes are they on.

We will take this example by default from your build settings:

Main Menu = Scene 0
Level Selection Menu = Scene 1
Level 1 = Scene 2
Level 2 = Scene 3

This means, that to load Level 1 then you need to use the LoadScene02 script and to load Level 2 you need to use the LoadScene03 script.
It depends on the scene you have in your build settings to load it, so if you use LoadScene01 then it won't work, because that will load 
the level selection menu which is scene 1.

EXAMPLE: to load level 1 which is scene 2 then you need to put the 'LoadScene02' to load the first level.

Go ahead and see if all the scripts are attached right for each levels with the same BUILD SETTINGS scene numbers you have.

In the 'Level Selection Menu' scene you have the buttons which are level 1 button, level 2
buttons and so on. These are the levels that will load up each scene seperatly. 

The script to load up the levels can be found in SCRIPTS > Load Scenes Scripts and there are
about 6 scripts and you can also create more. These are named "LoadScene01, LoadScene02 etc." these needs 
to be placed in the buttons to load up each scene. Make sure the button you are using have a BOX COLLIDER 3D 
and NOT a BOX COLLIDER 2D.

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