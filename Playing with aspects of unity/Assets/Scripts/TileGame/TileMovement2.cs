using UnityEngine;
using System.Collections;

public class TileMovement2 : MonoBehaviour {

	public float Timer;
	public float TimeSet;
	
	public float posx;
	public float posz;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Timer -= .02f;
		
		if ((Timer <= 11 && Timer > 6.5) && transform.position.z >= -5.75f ) {
			//rigidbody.velocity = TileSpeed1;
			//posx += .02f;
			posz -= .02f;
			transform.position = new Vector3(posx, 0f, posz);
		}
		
		if (transform.position.z <= -5.750001f) {
			transform.position = new Vector3( 0f, 0f, -5.750001f);
		}
		
		if ((Timer <= 5.5f && Timer > .5f) && transform.position.z <= -1.75f ) {
			//rigidbody.velocity = TileSpeed2;
			//posx -= .02f;
			posz += .02f;
			transform.position = new Vector3(posx, 0f, posz);
		}
		
		if (transform.position.z >= -1.74999f) {
			transform.position = new Vector3 ( 0f, 0f, -1.74999f);
		}
		if (Timer <= 0f) {
			Timer = TimeSet;
		}
	}
}
