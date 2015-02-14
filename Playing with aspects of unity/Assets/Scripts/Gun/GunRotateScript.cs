using UnityEngine;
using System.Collections;

public class GunRotateScript : MonoBehaviour {

	public KeyCode lookLeft;
	public KeyCode lookRight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (lookLeft)) {
			transform.Rotate (0f, -2.5f, 0f);
		}
		if (Input.GetKey (lookRight)) {
			transform.Rotate (0f, 2.5f, 0f);
		}
	}
}
