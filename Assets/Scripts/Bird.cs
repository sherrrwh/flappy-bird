using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	public float timer;
	public int frameNumber = 10;
	public int frameCount = 0;

	public bool birdAni = false;
	public bool canJump = false;

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		if (GameManager._instance.gamestate == GameManager.GAMESTATE_PLAYING) {
			timer += Time.deltaTime;
			if (timer >= 1.0f / frameNumber) {
				frameCount++;
				timer -= 1.0f / frameNumber;
				int frameIndex = frameCount % 3;
				this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.333333f * frameIndex, 0));
			}
		}
		if (GameManager._instance.gamestate == GameManager.GAMESTATE_PLAYING) {
			if (Input.GetMouseButton(0)) {
				GetComponent<AudioSource>().Play();
				Vector3 vel2 = this.GetComponent<Rigidbody>().velocity;
				this.GetComponent<Rigidbody>().velocity = new Vector3(vel2.x, 5, vel2.z);

			}
		}

	}

	void Getlife() {
		GetComponent<Rigidbody>().useGravity = true;
		this.GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 0);
	}
}
