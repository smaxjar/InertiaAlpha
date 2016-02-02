using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	 
	
	void OnGUI () {
				// Makes a box for the Buttons.
				GUI.Box (new Rect (Screen.width/2,Screen.height/2, 200, 200), "");
		
				// Makes the "Start" button.
		if (GUI.Button (new Rect (Screen.width/2+70,Screen.height/2+75, 85, 20), "Start Game")) {
					//	Application.LoadLevel (2);
				}
		        // Makes the "how to play" button.
		if (GUI.Button (new Rect (Screen.width/2+70,Screen.height/2+115, 85, 20), "How To Play")) {
			//Application.LoadLevel (1);
		}
		
				// Makes the "Exit" button.
		if (GUI.Button (new Rect (Screen.width/2+70,Screen.height/2+150, 85, 20), "Exit")) {
			        //    Application.Quit();
				}
		}
}
