using UnityEngine;
using System.Collections;

public class TileMovement1 : MonoBehaviour {

	public float Timer;
	public float TimeSet;


	//Vector3 TileSpeed1 = new Vector3(-1f, 0f, -1f);
	//Vector3 TileSpeed2 = new Vector3(1f, 0f, 1f);
	//Vector3 TileStop = new Vector3(0f, 0f, 0f);

	// Use this for initialization
	void Start () {

	}

	public float posx; //= transform.position.x;
	public float posz; //= transform.position.z;

	//public float startx;
	//public float startz;

	//public float start1x;
	//public float start1z;

	// Update is called once per frame
	void FixedUpdate () {
		Timer -= .02f;

		//public float posx; //= transform.position.x;
		//public float posz; //= transform.position.z;

		//float posx = gameObject.transform.position.x;
		//float posz = gameObject.transform.position.z;

		if ((Timer <= 11 && Timer > 6.5f) && transform.position.x >= -6f ) {
			//rigidbody.velocity = TileSpeed1;
			posx -= .02f;
			posz -= .02f;
			transform.position = new Vector3(posx, 0f, posz);
		}

		/*if (Timer <= 7 && Timer > 5.5) {
			//rigidbody.velocity = TileStop;
			transform.position = new Vector3(start1x, 0f, start1z);
		}*/

		if (transform.position.x <= -6.000001f) {
			transform.position = new Vector3( -6.000001f, 0f, -5.75f);
		}

		if ((Timer <= 5.5f && Timer > .5f) && transform.position.x <= -2f ) {
			//rigidbody.velocity = TileSpeed2;
			posx += .02f;
			posz += .02f;
			transform.position = new Vector3(posx, 0f, posz);
		}

		if (transform.position.x > -1.99999f) {
			transform.position = new Vector3 ( -1.99999f, 0f, -1.75f);
		}

		/*if (Timer <= 1.5f && Timer > 0f) {
			//rigidbody.velocity = TileStop;
			transform.position = new Vector3(startx, 0f, startz);
		}*/

		/*if ((Timer <= 7f && Timer > 5.5f) && transform.position.x > -6) {
			transform.position = new Vector3( -6f, 0f, -5.75f);
			Timer = 7f;
		}*/

		if (Timer <= 0f) {
			Timer = TimeSet;
		}
	}
}
