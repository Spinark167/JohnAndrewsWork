using UnityEngine;
using System.Collections;

public class TileFallScript : MonoBehaviour {
	float Timer = 0f;
	bool Faller = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Timer -= .02f;

		if ((Timer <= 0f) && (Faller == true)) {
			rigidbody.isKinematic = false;
			rigidbody.useGravity = true;
		}
		//Debug.Log (Timer);
	}

	void OnCollisionEnter() {
		//Debug.Log ("on");
		Timer = .86f;
		Faller = true;
	}
}
