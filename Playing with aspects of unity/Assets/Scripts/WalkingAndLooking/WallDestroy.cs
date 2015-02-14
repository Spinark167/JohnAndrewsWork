using UnityEngine;
using System.Collections;

public class WallDestroy : MonoBehaviour {

	public KeyCode destroyer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (destroyer)) {
			Destroy(gameObject);
		}
	}
}
