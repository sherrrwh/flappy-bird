using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {
	
	public Button startButton;
	public static StartMenu _instance;

	void Awake() {
		_instance = this;
		startButton.onClick.AddListener(OnClickStart);
	}

	void OnClickStart() {
		if (GameManager._instance.gamestate == GameManager.GAMESTATE_MENU) {
			GameManager._instance.gamestate = GameManager.GAMESTATE_PLAYING;
			GameManager._instance.bird.SendMessage("Getlife");
		}
	}
}
