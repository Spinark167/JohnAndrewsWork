using UnityEngine;
using System.Collections;

public class BulletDeathScript : MonoBehaviour {

	float Timer = 1f;

	// Use this for initialization
	void Start () {
	
	}

	void Update() {
		//Debug.Log (rigidbody.velocity.x);
		//Debug.Log (rigidbody.velocity.z);
	}

	void OnCollisionEnter( Collision  other ) {
		if (other.gameObject.tag == "AI") {
			Destroy (other.gameObject);
		};

		Destroy (gameObject);
	}

	// Update is called once per frame
	void FixedUpdate () {
		Timer -= .02f;

		if (Timer <= 0) {
			Destroy(gameObject);
		}
	}
}
