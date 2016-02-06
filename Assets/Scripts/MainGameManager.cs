using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour {

	//private Spikes player; // Calls the player script
	public static MainGameManager Instance = null;
 	private int playerLives = 2;
	private int playerHealth = 100;
	public Image bar;
	public float cur_Health;
	float this_Health = 100; 
	public Transform player;
	public Transform SpawnPoint;
	void Awake(){
		//player = FindObjectOfType <Spikes> (); // Allows script to use player variables.

				
						if (Instance == null) {
								Instance = this;
								DontDestroyOnLoad (this.gameObject);
						} 
						 else
								Destroy (this.gameObject);
				
		}

	void Start(){
		
		cur_Health = playerHealth;

	}

void Update(){
		if (cur_Health >= 101)
			cur_Health = 100;

		
		if (cur_Health <= 0) {
		//	adjustlive (-1); //minus 1 life for player
			adjustHealth(100);
			player.transform.position = SpawnPoint.position;

		}

	//if (playerLives == -1) {// Sets the Player lives when he has no more lives.

		  //  playerLives = 2;//Sets the lives back to 2
		//	playerHealth = 100;//Sets the health back to 100.

			//	}
	}


  	public void adjustlive(int num){ // Controls the lives
		playerLives = playerLives + num;
		}

	public void adjustHealth(float num){//Controls the health
			cur_Health = cur_Health + num;
			this_Health = cur_Health / playerHealth; //get the player health in 
			bar.fillAmount = this_Health;
		    
		}
		
 }
 