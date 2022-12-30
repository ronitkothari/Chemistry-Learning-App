using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockLevel : MonoBehaviour {

	// This script is used in the LEVEL SELECTION MENU to unlock buttons for scenes. That means if you completed level 1, then you can now prorgess
	// to level 2 in the level selection menu. Use the same tags you have the levelTags form the level selection menu and the scenes.
	// That means if you are on level 1, and you want to unlock the button on level 2 then use the same tag.

	public string[] levelTags; //The tag used to unlock the next level in the level selection menu/scene.

	public GameObject[] lockedButtons; //The locked buttons which are set as a child for the main buttons. These needs to be as a prefab with a BOX COLLIDER 3D.
	public bool[] levelUnlocked; //Tag the ones that will be unlocked, only level 1 should be unlocked at start. Be sure to remove the locked button on level 1 too.

	void Start () {
		for(int i = 0; i < levelTags.Length; i++)
		{
			if(PlayerPrefs.GetInt(levelTags[i]) == null)
			{
				levelUnlocked[i] = false;
			} else if (PlayerPrefs.GetInt(levelTags[i]) == 0)
			{
				levelUnlocked[i] = false;
			} else {
				levelUnlocked[i] = true;
			}

			if(levelUnlocked[i])
			{
				lockedButtons[i].SetActive (false);
			}
		}
	}
}
