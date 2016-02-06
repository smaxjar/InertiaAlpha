using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

	

	void OnTriggerEnter(Collider coll){

		if (coll.gameObject.tag == "Player")// adds 100 points to the player score if he exits the barrels trigger.
			MainGameManager.Instance.adjustHealth (-25);
	}
}
