using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeUpOrDown : MonoBehaviour {

	public AudioSource hitMusic;
	public AudioSource dieMusic;

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Player" && GameManager._instance.gamestate != GameManager.GAMESTATE_END) {
			hitMusic.Play();
			dieMusic.Play();
			GameManager._instance.gamestate = GameManager.GAMESTATE_END;
		}
	}
}
