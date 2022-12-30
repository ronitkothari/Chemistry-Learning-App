using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFade : MonoBehaviour {

		/*
		 * This script will allow you to select two colors, and change the duration time that these 
		 * two colors will blend it and create a nice, colorful background fade.
		*/

		public Color color1 = Color.red; //Choose the color from the inspector.
		public Color color2 = Color.blue;  //Choose the color from the inspector.
		public float duration = 3.0F;  //Time it will take till it starts to fade the 2 colors.

		Camera cam; //Get the camera in the inspector.

		void Start()
		{
			cam = GetComponent<Camera>();
			cam.clearFlags = CameraClearFlags.SolidColor;

		}

		void Update()
		{
			float t = Mathf.PingPong(Time.time, duration) / duration;
			cam.backgroundColor = Color.Lerp (color1, color2, t);

		}
	}