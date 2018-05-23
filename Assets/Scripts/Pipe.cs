using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {
	void Start() {
		RandomGeneratePosition();
	}

	public void RandomGeneratePosition() {
		float pos_y = Random.Range(-0.4f, -0.1f);
		this.GetComponent<Transform>().localPosition = new Vector3(this.GetComponent<Transform>().localPosition.x, pos_y, this.GetComponent<Transform>().localPosition.z);
	}
	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			GetComponent<AudioSource>().Play();
			GameManager._instance.score++;
		}
	}

	void OnGUI() {
		GUILayout.Label("Score:" + GameManager._instance.score);
	}
}
