using UnityEngine;
using System.Collections;

public class playerRotater : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider otherCollider) {
		if (otherCollider.tag == "wallTriggerNorth") {
			transform.Rotate (90, 0, 0);
		}

		/*switch (otherCollider.tag) {
		case "wallTriggerNorth": transform.Rotate(0,0,90); break;
		case "wallTriggerSouth": transform.Rotate(0,0,0); break;
		case "wallTriggerWest": transform.Rotate(0,0,0); break;
		case "wallTriggerEast":	transform.Rotate(0,0,0); break;*/

	}
}
