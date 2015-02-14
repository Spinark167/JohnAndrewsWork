using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

	public GameObject thePrefab;

	public KeyCode shoot;

	float Timer = .5f;
	float TimeSet = .5f;

	//Vector3 movement = new Vector3(0f,0f,0f);

	// Use this for initialization
	void Start () {
	
	}

	//float DegValX = 0;

	// Update is called once per frame
	void Update () {
		//GameObject Gun = GameObject.Find ("GunHolder");

		float DegValX = ((transform.eulerAngles.y * Mathf.PI) / 180);
		float factorX = Mathf.Sin (DegValX);
		float factorZ = Mathf.Cos (DegValX);

		//Debug.Log (DegValX);
		//Debug.Log (factorX);
		//Debug.Log (factorZ);

		/*float DegValX = 0;
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
		}*/
		
		/*float factorX = ((DegValX / 90) * 2);
		float factorZ = 0;

		if (factorX >= 0) {
			factorZ = 2 - factorX;
		}
		if (factorX < 0) {
			factorZ = (2 - (factorX * -1));
		}
		
		if (transform.eulerAngles.y > 90 && transform.eulerAngles.y <= 270) {
			factorZ = factorZ * -1;
		}*/

		//Debug.Log ( Mathf.Sin(DegValX) );
		//Debug.Log (factorX);
		//movement = new Vector3 (-500f * factorX, 20f, 500f * factorZ);

		GameObject cameraPivot = GameObject.Find ("CameraPivot");
		float rotUp = cameraPivot.transform.rotation.eulerAngles.x;
		//Debug.Log (rotUp);
		float rotUpRad = ((rotUp * Mathf.PI) / 180);
		float factorYUp = Mathf.Sin (rotUpRad);
		float factorYOut = Mathf.Cos (rotUpRad);

		//if (rotUp >= 270 && rotUp <= 360) {
		//	rotUp = -1 * (rotUp - 360);
		//}

		//just trying to keep the code working for no upward rotation.
		//float rotUp = 0f;

		if (Input.GetKey (shoot) && Timer <= 0) {
			//Make ();
			Timer = TimeSet;
			GameObject bullet = (GameObject)Instantiate (thePrefab, transform.position, /*Quaternion.Euler(Vector3(0, 0, 90))*/ transform.rotation);
			
			bullet.rigidbody.velocity = new Vector3(75f * factorX * factorYOut, -75f * factorYUp , 75f * factorZ * factorYOut);
		}
	}

	void FixedUpdate(){
		Timer -= .02f;
	}

	//transfrom.eulerAngles.rotation.z - 90)));

	//void Make () {
		//Timer = TimeSet;
		//GameObject bullet = (GameObject)Instantiate (thePrefab, transform.position, /*Quaternion.Euler(Vector3(0, 0, 90))*/ transform.rotation);

		//bullet.rigidbody.velocity = new Vector3(-500f , 20f, 0f);

		//GameObject shot = GameObject.Find ("Bullet");
		//BulletScript bullScri = shot.GetComponent<BulletScript> ();
		//bullScri.Move ();
	//}
}
