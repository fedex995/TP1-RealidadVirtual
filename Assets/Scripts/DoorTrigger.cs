using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public GameObject door;

	private bool inTrigger = false;

	void Update() {
		if (Input.GetKeyDown (KeyCode.E) && inTrigger) {
			door.SendMessage("Toggle");
		}
	}

	void OnTriggerEnter(Collider c) {
		if (c.tag == "Player") {
			inTrigger = true;
		}
	}

	void OnTriggerExit(Collider c) {
		if (c.tag == "Player") {
			inTrigger = false;
		}
	}

}
