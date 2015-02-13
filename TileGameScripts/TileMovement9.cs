using UnityEngine;
using System.Collections;

public class TileMovement9 : MonoBehaviour {

	public float Timer;
	public float TimeSet;
	
	public float posx;
	public float posz;
	public float posy;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Timer -= .02f;
		
		if ((Timer <= 11 && Timer > 6.5) && transform.position.y >= 0f ) {
			//rigidbody.velocity = TileSpeed1;
			//posx += .02f;
			//posz += .02f;
			posy -= .02f;
			transform.position = new Vector3(posx, posy, posz);
		}
		
		if (transform.position.y >= 4.0001f) {
			transform.position = new Vector3( 0f, 4.0001f, .25f);
		}
		
		if ((Timer <= 5.5f && Timer > .5f) && transform.position.y <= 4f ) {
			//rigidbody.velocity = TileSpeed2;
			//posx -= .02f;
			//posz -= .02f;
			posy += .02f;
			transform.position = new Vector3(posx, posy, posz);
		}
		
		if (transform.position.x <= -.0001f) {
			transform.position = new Vector3 ( 0f, -.0001f, .25f);
		}

		if (Timer <= 0f) {
			Timer = TimeSet;
		}
	}
}
