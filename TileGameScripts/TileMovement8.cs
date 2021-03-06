﻿using UnityEngine;
using System.Collections;

public class TileMovement8 : MonoBehaviour {

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
		
		if ((Timer <= 11 && Timer > 6.5) && transform.position.x <= 6f ) {
			//rigidbody.velocity = TileSpeed1;
			posx += .02f;
			//posz += .02f;
			transform.position = new Vector3(posx, 0f, posz);
		}
		
		if (transform.position.x >= 6.0001f) {
			transform.position = new Vector3( 6.0001f, 0f, .25f);
		}
		
		if ((Timer <= 5.5f && Timer > .5f) && transform.position.x >= 2f ) {
			//rigidbody.velocity = TileSpeed2;
			posx -= .02f;
			//posz -= .02f;
			transform.position = new Vector3(posx, 0f, posz);
		}
		
		if (transform.position.x <= 1.999f) {
			transform.position = new Vector3 ( 1.999f, 0f, .25f);
		}
		if (Timer <= 0f) {
			Timer = TimeSet;
		}
	}
}
