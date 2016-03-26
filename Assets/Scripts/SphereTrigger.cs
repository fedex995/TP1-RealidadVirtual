using UnityEngine;
using System.Collections;

public class SphereTrigger : MonoBehaviour {

	public Rigidbody[] spheres;
	public Vector3 Gravity;
	private bool isTriggered;

	void OnTriggerEnter(Collider c) {
		if (c.tag == "Player") {
			for (int i = 0; i < spheres.Length; i++) {
				spheres [i].useGravity = true;
			}
		}
	}
}
