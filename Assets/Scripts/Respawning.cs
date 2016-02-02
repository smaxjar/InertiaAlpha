using UnityEngine;
using System.Collections;

public class Respawning : MonoBehaviour {
	private MainGameManager Game;
	public Transform SpawnPoint;
	public Transform Player;

	void Update(){
		
		if(MainGameManager.Instance.cur_Health <=0){     //respawns player when player dies
			Player.transform.position = SpawnPoint.position;
		}
  }
}
