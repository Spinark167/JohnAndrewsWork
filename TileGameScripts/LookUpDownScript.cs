using UnityEngine;
using System.Collections;

public class LookUpDownScript : MonoBehaviour {

	/*
	public KeyCode lookUp;
	public KeyCode lookDown;

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
		
		if (transform.eulerAngles.y > 90 && transform.eulerAngles.y <= 270) {
			factorZ = factorZ * -1;
		}

		if(Input.GetKey (lookUp)) {
			transform.Rotate(moveFactor * factorX, 0f, moveFactor * factorZ);
		}
		if(Input.GetKey (lookDown)) {
			rigidbody.AddForce(-moveFactor * factorZ, 0f, moveFactor * factorX);
		}

	}
*/
}	