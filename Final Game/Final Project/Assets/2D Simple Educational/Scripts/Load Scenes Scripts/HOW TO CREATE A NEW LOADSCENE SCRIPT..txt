----------------------------------
WHAT IS THE LOADSCENE SCRIPTS?
----------------------------------

These scripts are simple scripts that you can place into a button with a box collider 3D and when you press on 
the button then the script will load the scene from the BUILD SETTINGS. For example if your BUILD SETTINGS is like 
something like this:

Main Menu = Scene 0
Level Selection Menu = Scene 1
Level 1 = Scene 2
Level 2 = Scene 3

That means that the script 'LoadScene01' will load scene 1 which will be the Level Selection Menu.

The script 'LoadScene02' will load scene 2 which will load the level 1 and so on.

This means, that to load Level 1 then you need to use the LoadScene02 script and to load Level 2 you need to use the LoadScene03 script.
It depends on the scene you have in your build settings to load it, so if you use LoadScene01 then it won't work, because that will load 
the level selection menu which is scene 1.

EXAMPLE: to load level 1 which is scene 2 then you need to put the 'LoadScene02' to load the first level.

You can also create how many LOadScene scripts as you want and it's very easy. You can see the more detailed
documentation provided on more information.

----------------------------------
HOW TO CREATE A LOADSCENE SCRIPT?
----------------------------------

You can create as much as you like, these are just scripts to load the scenes from the BUILD SETTINGS.

Find the Load Scene Scripts folder and see which the last script is. If you have LoadScene06 last then we 
will be creating LoadScene07. Create a new C# by clicking the right mouse button > create > C# Script and name it LoadScene07. 

Open up the script, delete the Void Start and Void Update and add this:


    	void OnMouseDown() {
        	SceneManager.LoadScene(+7);
    	} 


At the top under Using Unity.Engine add this:


	using UnityEngine.SceneManagement; 



That means that the full script will look like this:

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene01 : MonoBehaviour {


	void OnMouseDown() {
		SceneManager.LoadScene(+7);
	}
}


You can put the (+7) to whatever you want, that means the scene that it will load so if you put +7 then it will mean
that it will load scene 7 from the build settings and if you put +8 then it will load scene 8 from the build settings.


You are basically done, save the script and that’s it! You can add a new button with a BOX COLLIDER 3D and add the script to it.