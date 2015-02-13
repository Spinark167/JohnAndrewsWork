using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
	public KeyCode moveForward;
	public KeyCode moveLeft;
	public KeyCode moveBackward;
	public KeyCode moveRight;
	public KeyCode Stop;

	public KeyCode lookLeft;
	public KeyCode lookRight;
	public KeyCode lookCenter;

	public KeyCode jump;

	public float moveFactor;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float DegValX = 0;
		if (transform.eulerAngles.y > 0 && transform.eulerAngles.y <= 90) {
			DegValX = transform.eulerAngles.y;
		}
		if (transform.eulerAngles.y > 90 && transform.eulerAngles.y <= 180) {
			DegValX = (90 - ( transform.eulerAngles.y - 90 ));
		}
		if (transform.eulerAngles.y > 180 && transform.eulerAngles.y <= 270) {
			DegValX = (0 - ( transform.eulerAngles.y - 180 ));
		}
		if (transform.eulerAngles.y > 270 && transform.eulerAngles.y <= 360) {
			DegValX = (-90 + ( transform.eulerAngles.y - 270 ));
		}

		float factorX = ((DegValX / 90) * 2);
		float factorZ = 0;

		if (factorX >= 0) {
			factorZ = 2 - factorX;
		}
		if (factorX < 0) {
			factorZ = (2 - (factorX * -1));
		}

		//Debug.Log (factorX);

		if (transform.eulerAngles.y > 90 && transform.eulerAngles.y <= 270) {
			factorZ = factorZ * -1;
		}

		/*if (factorX > 2 && factorX <= 4) {
			factorX -= 2;
		}
		if (factorX > 4 && factorX <= 6) {
			factorX -= 4;
		}
		if (factorX > 6 && factorX <= 8) {
			factorX -= 6;
		}*/
		//Debug.Log (factorX);

		/*float factorX2 = 0; 
		if (transform.eulerAngles.y > 0 && transform.eulerAngles.y <= 90) {
			factorX2 = factorZ;
		}
		if (transform.eulerAngles.y > 90 && transform.eulerAngles.y <= 180) {
			factorX2 = factorZ;
		}
		if (transform.eulerAngles.y > 180 && transform.eulerAngles.y <= 270) {
			factorX2 = factorZ;
		}
		if (transform.eulerAngles.y > 270 && transform.eulerAngles.y <= 360) {
			factorX2 = factorZ;
		}*/

		/*float factorZ2 = 0; 
		if (transform.eulerAngles.y > 0 && transform.eulerAngles.y <= 90) {
			factorZ2 = factorX;
		}
		if (transform.eulerAngles.y > 90 && transform.eulerAngles.y <= 180) {
			factorZ2 = factorX;
		}
		if (transform.eulerAngles.y > 180 && transform.eulerAngles.y <= 270) {
			factorZ2 = factorX;
		}
		if (transform.eulerAngles.y > 270 && transform.eulerAngles.y <= 360) {
			factorZ2 = factorX;
		}*/

		if(Input.GetKey (moveForward)) {
			rigidbody.AddForce(moveFactor * factorX, 0f, moveFactor * factorZ);
		}
		if(Input.GetKey (moveLeft)) {
			rigidbody.AddForce(-moveFactor * /*factorX2*/factorZ, 0f, moveFactor * /*factorZ2*/factorX);
		}
		if(Input.GetKey (moveBackward)) {
			rigidbody.AddForce(-moveFactor * factorX, 0f, -moveFactor * factorZ);
		}
		if(Input.GetKey (moveRight)) {
			rigidbody.AddForce(moveFactor * /*factorX2*/factorZ, 0f, -moveFactor * /*factorZ2*/factorX);
		}
		if (Input.GetKey (Stop)) {
			rigidbody.velocity = new Vector3(0f, rigidbody.velocity.y, 0f);

		}
	}

	//Quaternion rotation = Quaternion.identity;

	float timeTwo = 0f;
	public float jumpHeight;

	void FixedUpdate() {
		timeTwo -= .02f;

		if(Input.GetKey(lookLeft)) {
			transform.Rotate(0f, -2.5f, 0f);
		}
		if (Input.GetKey (lookRight)) {
			transform.Rotate(0f, 2.5f, 0f);
		}
		if (Input.GetKey (lookCenter)) {
			//transform.rotation.eulerAngles = new Vector3(0f, 45f, 0f);
			if (gameObject.transform.rotation.eulerAngles.y > 45.25) {
				transform.Rotate(0f, -.5f, 0f);
			} else if( gameObject.transform.rotation.eulerAngles.y < 44.75) {
				transform.Rotate( 0f, .5f, 0f );
			} else if( gameObject.transform.rotation.eulerAngles.y == 45) {
				transform.Rotate( 0f, 0f, 0f);
			}
		}
		if (Input.GetKey (jump) && timeTwo <= 0f) {
			rigidbody.AddForce(0f, jumpHeight, 0f);
			timeTwo = 1f;
		}
	}

	public void Die1() {
		Application.LoadLevel ("TGLv1");

		//rigidbody.transform.position = new Vector3 (-8f, .375f, -7.75f);
		//rigidbody.velocity = new Vector3 (0f, 0f, 0f); 

		//I could also reload the scene here that way the moveing platforms would reset and all i would have to 
		//is not destroy the attemptsGUI and mabe make sure new coins arent added. or i could let them be added and
		//take away what ever was already gotten. like let the score reset when you die on a level but not when u 
		// advance

		//GameObject attemptsGUI = GameObject.Find ("AttemptsGUI");
		//AttemptsGUIScript attemptsGUIScript = attemptsGUI.GetComponent<AttemptsGUIScript> ();
		//attemptsGUIScript.Plus ();
	}

	public void Die2() {
		Application.LoadLevel ("TGLv2");
	}
}
