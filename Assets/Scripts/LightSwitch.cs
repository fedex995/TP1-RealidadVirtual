using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {
	public GameObject[] lights;
	private bool lightsOn = true;
	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Player") {
			Debug.Log ("Lights!!");
			for (int i = 0; i < lights.Length; i++) {
				lights [i].GetComponent<Light> ().enabled = !lightsOn;
			}
			lightsOn = !lightsOn;
		}
	}
}
