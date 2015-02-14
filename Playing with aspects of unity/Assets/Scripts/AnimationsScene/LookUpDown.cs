using UnityEngine;
using System.Collections;

public class LookUpDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public KeyCode lookUp;
	public KeyCode lookDown;

	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey( lookUp )) {
			transform.Rotate (-.5f,0f,0f);
		}
		if(Input.GetKey( lookDown )) {
			transform.Rotate (.5f,0f,0f);
		}
	}
}
