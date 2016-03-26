using UnityEngine;
using System.Collections;

public class ColorCube : MonoBehaviour {

	public GameObject cube;

	private bool inTrigger = false;

	void OnTriggerEnter(Collider c) {
		if (c.tag == "Player") {
			Color randomColor = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));
			cube.GetComponent<Renderer>().material.color = randomColor;
		}
	}

	void OnTriggerExit(Collider c) {
		if (c.tag == "Player") {
			inTrigger = false;
		}
	}

}

