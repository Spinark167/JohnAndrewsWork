using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter( Collision other ) {
		//Debug.Log ("hit");
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
