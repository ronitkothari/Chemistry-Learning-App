using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevelsButton : MonoBehaviour {

	//This script can be placed on a button with a 2D/3D Collider and when it's pressed it will restart the scene and restart the levels.

	void OnMouseDown() {
			PlayerPrefs.DeleteAll ();
			Application.LoadLevel(Application.loadedLevel);
	}
}
