using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnGUI () {
		// Makes a box for the Buttons.
		GUI.Box (new Rect (Screen.width/2 - 70,Screen.height/2, 200, 200), "Game Over");
		
		// Makes the "Play Again" button.
		if (GUI.Button (new Rect (Screen.width/2,Screen.height/2+75, 85, 20), "Play Again")) {
			//Application.LoadLevel (2);
		}
		// Makes the "Main menu" button.
		if (GUI.Button (new Rect (Screen.width/2,Screen.height/2+115, 85, 20), "Main Menu")) {
			//Application.LoadLevel (0);
		}
		
		// Makes the "Exit" button.
		if (GUI.Button (new Rect (Screen.width/2,Screen.height/2+150, 85, 20), "Exit")) {
			//Application.Quit();
		}
	}
}
