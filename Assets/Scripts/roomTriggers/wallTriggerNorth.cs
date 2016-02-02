using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wallTriggerNorth : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider Player) {
		playerControllerFloorSimple pcFloor = GameObject.Find ("Player").GetComponent<playerControllerFloorSimple> ();
		playerControllerWallSimple pcwSimple = GameObject.Find ("Player").GetComponent<playerControllerWallSimple> ();
		playerControllerWallEast pcwEast = GameObject.Find ("Player").GetComponent<playerControllerWallEast> ();
		playerControllerWallSouth pcwSouth = GameObject.Find ("Player").GetComponent<playerControllerWallSouth> ();
		playerControllerWallWest pcwWest = GameObject.Find ("Player").GetComponent<playerControllerWallWest> ();
		//Image = GameObject.Find ("Player").GetComponent<Image> ();
		if (pcFloor == null) {
			print ("pcws is null");
		} else {
			pcFloor.enabled = false;
			pcwSimple.enabled = true;
			pcwSouth.enabled = false;
			pcwWest.enabled = false;
			pcwEast.enabled = false;
			//Image.transform.Rotate (0, 0, 0);
		}


	}
}
