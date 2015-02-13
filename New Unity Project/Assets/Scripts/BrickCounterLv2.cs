using UnityEngine;
using System.Collections;

public class BrickCounterLv2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] bricks = GameObject.FindGameObjectsWithTag ("Brick");
		if (bricks.Length <= 0) {
			Application.LoadLevel("level3");
		};
	}
}
