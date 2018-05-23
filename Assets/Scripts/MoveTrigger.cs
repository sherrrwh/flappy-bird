using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour {
	public Transform currentBg;

	public void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Transform firstBg = GameManager._instance.firstBg;
			currentBg.position = new Vector3(firstBg.position.x + 10, currentBg.position.y, currentBg.position.z);
			GameManager._instance.firstBg = currentBg;
		}
	}

}
