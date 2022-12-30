using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {

	//This script is used in the SCENES to unlock a next level in the Level Selection Menu via a tag. 
	//That means if you are on level 1, then use this script on level 1 to load level 2 with the same tag.
	//If in the scene 'Level Selection Menu' you have level 2 set as 'level2lock' then in level 1 use the tag 'level2lock' to unlock level 2.

	public string levelTag; //The tag used to unlock the next level in the level selection menu/scene.

	void Start () {
		PlayerPrefs.SetInt (levelTag, 1);
	}
}
