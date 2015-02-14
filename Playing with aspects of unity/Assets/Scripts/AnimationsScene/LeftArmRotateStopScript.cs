using UnityEngine;
using System.Collections;

public class LeftArmRotateStopScript : MonoBehaviour {

	Animator anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject body = GameObject.Find ("CharacterHolder");
		float speedx = body.rigidbody.velocity.x;
		float speedz = body.rigidbody.velocity.z; 
		//float rotationxp = gameObject.transform.rotation.x;
		//float rotationxn = -.6f;

		if (speedx < 0) {
			speedx = speedx * -1;
		}
		if (speedz < 0) {
			speedz = speedz * -1;
		}
		//if (rotationxp < 0) {
		//	rotationxn = rotationxp;
		//}

		//Debug.Log (rotationxp);

		if (speedx <= .05f && speedz <= .05f) {
			//anim.active = false;
			//Animator.enabled = false; 
			anim.enabled = false;
			Center ();

		} else {
			anim.enabled = true;
		}
		//while(transform.rotation.x > 0) {
	}

	/*void Center() {
		while(transform.rotation.eulerAngles.x >= .5f) {
			transform.Rotate( -1.5f, 0f, 0f);
		}
		while(transform.rotation.eulerAngles.x <= -.5f) {
			gameObject.transform.Rotate( 1.5f, 0f, 0f);
		}
	}*/

	void Center() {
		//Debug.Log ("centering");
		if (transform.rotation.eulerAngles.x > .5f && transform.rotation.eulerAngles.x < 90f) {
			transform.Rotate (-.5f, 0f, 0f);
		}
		if (transform.rotation.eulerAngles.x < 359.5f && transform.rotation.eulerAngles.x > 270f) {
			transform.Rotate (.5f, 0f, 0f);
		}
	}
}
