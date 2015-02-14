using UnityEngine;
using System.Collections;

public class CapMovement : MonoBehaviour {
	public KeyCode moveForward;
	public KeyCode moveLeft;
	public KeyCode moveBackward;
	public KeyCode moveRight;
	public KeyCode Stop;

	public KeyCode lookLeft;
	public KeyCode lookRight;

	public KeyCode jump;

	//public KeyCode testing;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float DegValX = ((transform.eulerAngles.y * Mathf.PI) / 180);
		float factorX = Mathf.Sin (DegValX);
		float factorZ = Mathf.Cos (DegValX);

		//Debug.Log (factorX);
		//Debug.Log (factorZ);

		/*if (Input.GetKey (testing)) {
				Debug.Log ("testing");
				rigidbody.velocity = new Vector3 (-15f, 0f, 0f);
		};*/

		if(Input.GetKey (moveForward)) {
			//Debug.Log ("forward");
			rigidbody.AddForce(15f * factorX, 0f, 15f * factorZ);
		};
		if(Input.GetKey (moveLeft)) {
			//Debug.Log ("left");
			rigidbody.AddForce(-15f * factorZ, 0f, 15f * factorX);
		};
		if(Input.GetKey (moveBackward)) {
			//Debug.Log ("backward");
			rigidbody.AddForce(-15f * factorX, 0f, -15f * factorZ);
		};
		if(Input.GetKey (moveRight)) {
			//Debug.Log ("right");
			rigidbody.AddForce(15f * factorZ, 0f, -15f * factorX);
		};
		if (Input.GetKey (Stop)) {
			rigidbody.velocity = new Vector3(0f, rigidbody.velocity.y, 0f);
			//rigidbody.velocity = Vector3.zero;
		};
		//Debug.Log (rigidbody.velocity.x);
		if (rigidbody.velocity.x >= 2.5) {
			rigidbody.velocity = new Vector3(2.4f ,rigidbody.velocity.y ,rigidbody.velocity.z);	
		};
		if (rigidbody.velocity.x <= -2.5) {
			rigidbody.velocity = new Vector3(-2.4f ,rigidbody.velocity.y ,rigidbody.velocity.z);	
		};
		if (rigidbody.velocity.z >= 2.5) {
			rigidbody.velocity = new Vector3(rigidbody.velocity.x ,rigidbody.velocity.y ,2.4f);	
		};
		if (rigidbody.velocity.z <= -2.5) {
			rigidbody.velocity = new Vector3(rigidbody.velocity.x ,rigidbody.velocity.y ,-2.4f);	
		};


	}
	
	float timeTwo = 0f;
	public float jumpHeight;

	void FixedUpdate() {
		timeTwo -= .02f;

		if(Input.GetKey(lookLeft)) {
			transform.Rotate(0f, -1.5f, 0f);
		};
		if (Input.GetKey (lookRight)) {
			transform.Rotate(0f, 1.5f, 0f);
		};

		if (Input.GetKey (jump) && timeTwo <= 0f) {
			rigidbody.AddForce(0f, jumpHeight, 0f);
			timeTwo = 1f;
		};
	}

	public void Die1() {
		Application.LoadLevel ("TGLv1");
	}

	public void Die2() {
		Application.LoadLevel ("TGLv2");
	}
}
