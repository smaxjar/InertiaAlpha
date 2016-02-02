using UnityEngine;
using System.Collections;

public class wallTriggerEast : MonoBehaviour {

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

		if (pcFloor == null) {
			print ("pcws is null");
		} else {
			pcFloor.enabled = false;
			pcwSimple.enabled = false;
			pcwSouth.enabled = false;
			pcwWest.enabled = false;
			pcwEast.enabled = true;
		}



	}
}
