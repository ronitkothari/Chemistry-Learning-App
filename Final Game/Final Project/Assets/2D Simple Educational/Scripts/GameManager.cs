using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GUIStyle GameScoreGUI = new GUIStyle(); //This is the GUI style of the score displayed oon the screeeeeeeeeeeeen.
	public GUIStyle ShapesLeftGUI = new GUIStyle(); //This is the GUI style of the shapes left displayed on the screen.
	bool showGUI = true; //The active GUI for the main screen that will be displayed 
	float m_Timer = 1.0f; //How much time will pass till you get an increase in the score distance. 1.0f for 1 second.
	bool TimerStop = false; //Bool to calculate timer.
	public static int score; //This is the score that will be displayed.(The score is the time)

	public Texture EndGameFullScreenGUI; //The GUI that will display a big texture on the full screen when you lose.
	public GUIStyle EndGameScoreGUI = new GUIStyle(); //This is the GUI style of the End Game text that will be displayed. (EX: Finish Time: 9 seconds)
	public GUIStyle EndGameGUI = new GUIStyle(); //This is the GUI style of the End Game text that will be displayed. (EX: Good work!)
	public Texture ExitGameButtonHUD; //The exit HUD button that will display when the game ends.
	public Texture NextGameButtonHUD; //The restart HUD button that will display when the game ends.

	public GameObject EndGameSoundPrefab; //Sound that will play when game ends. You can change the sound in the 'End Game Sound Prefab'.

	public static int numberofshapes = 0; //Calculate how many shapes you have to put in the scene in order to win the game.

	void Start() {
		score = 0;
		TimerStop = true; //Set the timer to true to calculate the time distance.
		showGUI = false; //Show GUI for the game ending.
		showGUI = false; //Show GUI for the game ending.
	}
		
	void Update () {
		if (numberofshapes < 1) {
					showGUI = true;
					TimerStop = false;
					Destroy (GameObject.FindWithTag("BackgroundMusic"));
					EndGameSoundPrefab.SetActive (true);
		}
	
		if (TimerStop) {
			m_Timer -= Time.deltaTime;
			if(m_Timer <= 0.00f) {
				score++;
				m_Timer = 1.00f;
			}	
		}
	}

	void StartTimer () {
		if (TimerStop) {
			m_Timer -= Time.deltaTime;
			if(m_Timer <= 0.00f) {
				score++;
				m_Timer = 0.01f;
			}
		}
	}

	void OnGUI() {
		GUI.Label (new Rect (2, 7, 60, 60), "<b>Time: </b>" + score, GameScoreGUI);
		GUI.Label (new Rect (2, 7, 60, 60), "<b>Shapes Left: </b>" + numberofshapes, ShapesLeftGUI);
		if (showGUI) {
			GUI.DrawTexture(new Rect(((Screen.width / 3) - 868f), ((Screen.height / 5) - 741.5f), 5600, 2975), EndGameFullScreenGUI, ScaleMode.ScaleToFit, true, 0.0F); //Display the end game full screen.
			GUI.Label (new Rect(Screen.width / 2 - 48f, ((Screen.height / 2) - 34.5f), 40, -210), "Finish Time: " + score + " sec", EndGameScoreGUI);
			GUI.Label (new Rect(Screen.width / 2 - 48f, ((Screen.height / 2) - 34.5f), 40, -210), "Good Work, You're amazing!", EndGameGUI);

			if ( GUI.Button(new Rect(Screen.width / 2 - (320f / 2), Screen.height / 2 - -150, 110, 110), ExitGameButtonHUD)) {
				SceneManager.LoadScene(0);
			}

			if ( GUI.Button(new Rect(Screen.width / 2 - (-100f / 2), Screen.height / 2 - -150, 110, 110), NextGameButtonHUD)) {
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

			}
		}
	}
}
	



