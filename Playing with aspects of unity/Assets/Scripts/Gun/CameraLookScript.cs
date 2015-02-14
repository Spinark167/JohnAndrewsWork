using UnityEngine;
using System.Collections;

public class CameraLookScript : MonoBehaviour {

	public KeyCode lookUp;
	public KeyCode lookDown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		if (Input.GetKey (lookUp)) {
			transform.Rotate (1.5f, 0f, 0f);
		}
		if (Input.GetKey (lookDown)) {
			transform.Rotate (-1.5f, 0f, 0f);
		}
	}
}
