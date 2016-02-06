using UnityEngine;
using System.Collections;

public class HealthPack : MonoBehaviour {

	void OnTriggerEnter(Collider coll){

		if (coll.gameObject.tag == "Player")// adds 25 points to the player.
			MainGameManager.Instance.adjustHealth (25);
	}
}
