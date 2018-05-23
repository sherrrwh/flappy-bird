using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

	public static GameMenu _instance;
	public Text nowScoreText;
	public Text highScoreText;
	public Button reStartButton;

	void Awake() {
		_instance = this;
		this.gameObject.SetActive(false);

		reStartButton.onClick.AddListener(OnClickReStart);
	}

	public void UpdateScore(float nowScore) {
		float highScore = PlayerPrefs.GetFloat("score", 0);
		if (nowScore > highScore) {
			highScore = nowScore;
		}
		PlayerPrefs.SetFloat("score", highScore);
		this.nowScoreText.text = nowScore + "";
		this.highScoreText.text = highScore + "";
	}
	void OnClickReStart() {
		if (GameManager._instance.gamestate == GameManager.GAMESTATE_END) {
			SceneManager.LoadScene(0);
		}
	}
}
