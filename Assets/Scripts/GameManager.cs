using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static int GAMESTATE_MENU = 0;
	public static int GAMESTATE_PLAYING = 1;
	public static int GAMESTATE_END = 2;

	public Transform firstBg;
	public int score = 0;
	public int gamestate = GAMESTATE_MENU;
	public static GameManager _instance;

	public GameObject bird;

	void Awake() {
		_instance = this;
		bird = GameObject.FindGameObjectWithTag("Player");
	}

	void Update() {
		// if (gamestate == GAMESTATE_MENU) {
		// 	if (Input.GetMouseButtonDown(0)) {
		// 		gamestate = GAMESTATE_PLAYING;
		// 		bird.SendMessage("Getlife");
		// 	}
		// }

		if (gamestate == GameManager.GAMESTATE_PLAYING) {
			StartMenu._instance.gameObject.SetActive(false);
		}
		if (gamestate == GameManager.GAMESTATE_END) {
			GameMenu._instance.gameObject.SetActive(true);
			GameMenu._instance.UpdateScore(score);
		}
		
	}

}
