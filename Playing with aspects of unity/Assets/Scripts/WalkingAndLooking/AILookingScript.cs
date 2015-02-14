using UnityEngine;
using System.Collections;

public class AILookingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("Guy");

		float playerX = player.transform.position.x;
		float playerZ = player.transform.position.z;

		float diffX = transform.position.x - playerX;
		float diffZ = transform.position.z - playerZ;
		//Debug.Log (diffX);
		//Debug.Log (diffZ);

		float TurnAround = 0;
		//float TurnAroundZ = 0;

		if (diffX >= 0) {
			TurnAround = 180;
		} else {
			TurnAround = 0;			
		}



		float diff = diffZ / diffX;
		//Debug.Log (diff);
	
		float AngDiff = Mathf.Atan (diff);
		//Debug.Log (AngDiff);

		float AngDiffDeg = ((AngDiff * 180) / Mathf.PI);

		//float rotX = Mathf.Sin (AngDiff);
		//float rotZ = Mathf.Cos (AngDiff);

		transform.eulerAngles = new Vector3 (0f, -AngDiffDeg + TurnAround /*+ TurnAroundZ*/, 0f);

		float rotOfObj = transform.rotation.eulerAngles.y;
		//Debug.Log (rotOfObj);
		float radRotObj = ((rotOfObj * Mathf.PI) / 180);

		float factorX = Mathf.Sin (radRotObj);
		float factorZ = Mathf.Cos (radRotObj);

		//Debug.Log (factorX);
		//Debug.Log (factorZ);

		/*if (diffZ > 0) {
			factorZ = factorZ * -1;
		}*/

		if (rotOfObj > 270 && rotOfObj < 360) {
			factorX = factorX * -1;
		}
		if (rotOfObj > 0 && rotOfObj < 90) {
			factorX = factorX * -1;
		}
		if (rotOfObj > 90 && rotOfObj < 180) {
			factorX = factorX * -1;
		}
		if (rotOfObj > 180 && rotOfObj < 270) {
			
			factorX = factorX * -1;
		}

		if (rotOfObj < 2.5 || rotOfObj > 357.5) {
			factorX = 0;
			factorZ = 1;
		}
		if (rotOfObj < 92.5 && rotOfObj > 87.5) {
			factorX = -1;
			factorZ = 0;
		}
		if (rotOfObj < 182.5 && rotOfObj > 177.5) {
			factorX = 0;
			factorZ = -1;
		}
		if (rotOfObj < 272.5 && rotOfObj > 267.5) {
			factorX = 1;
			factorZ = 0;
		}

		rigidbody.velocity = new Vector3 (1f * factorZ, 0f, 1f * factorX);

		if (rigidbody.velocity.x >= 2.5) {
			rigidbody.velocity = new Vector3(2.4f ,rigidbody.velocity.y ,rigidbody.velocity.z);	
		}
		if (rigidbody.velocity.x <= -2.5) {
			rigidbody.velocity = new Vector3(-2.4f ,rigidbody.velocity.y ,rigidbody.velocity.z);	
		}
		if (rigidbody.velocity.z >= 2.5) {
			rigidbody.velocity = new Vector3(rigidbody.velocity.x ,rigidbody.velocity.y ,2.4f);	
		}
		if (rigidbody.velocity.z <= -2.5) {
			rigidbody.velocity = new Vector3(rigidbody.velocity.x ,rigidbody.velocity.y ,-2.4f);	
		}

	}


}
