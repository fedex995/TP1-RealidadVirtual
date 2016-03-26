using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public float rotation = 80f;
	public float maxRotation = 90f;
	public GameObject pivot;

	private float rotateDirection = 1f;
	private bool rotating = false;
	private float startingRotation;

	void Update() {
		if (rotating) {
			float rotated = Mathf.Abs(gameObject.transform.rotation.eulerAngles.y - startingRotation);
			if (rotated >= maxRotation) {
				Toggle (rotateDirection);
			} else {
				gameObject.transform.RotateAround (pivot.transform.position, Vector3.up, rotation * Time.deltaTime * rotateDirection);
			}
		}
	}

	void Toggle() {
		Toggle(rotateDirection * -1);
	}

	void Toggle(float direction) {
		float rotated = Mathf.Abs(gameObject.transform.rotation.eulerAngles.y - startingRotation);
		if (rotated < maxRotation && rotated > 0)
			return;
		startingRotation = gameObject.transform.rotation.eulerAngles.y;
		rotateDirection = direction;
		rotating = !rotating;
	}

}
